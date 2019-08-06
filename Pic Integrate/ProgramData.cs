using MyLibrary.LogNet;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Odbc;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Pic_Integrate.Library;
using MyLibrary.BasicFramework;

namespace Pic_Integrate
{
    class ProgramData
    {
        public static Para SysPara;//系统参数
        private static ILogNet LogNet;//日志
        public static string ConfigPath = @"./Config/";//配置文件目录
        public static string TemplatePath = @"./Template/";//模板目录
        public static string GlassInfoPath = @"./GlassInfo/";//GlassInfo目录
        public static string DateFormat = "yyyyMMdd";//日期格式
        public static string SelectTips = "---Please Select---";//选择提示语
        public static Size ArrowSize = new Size(80,80);//箭头大小，长度
        public static int DirectType = 0;//0-三角形，1-直线箭头
        public static DataTable SheetTemplate = new DataTable();//sheet图片合成模板
        public static string SealStr = "Seal";//Seal字符串名
        public static string SheetStr = "Sheet";//Sheet字符串名
        public static string ImgSuffix = ".jpg";//IMG后缀
        public static string TextSuffix = ".csv";//Text后缀
        public static int ReadEQLine = 17;//Eqipment ID 所在行
        public static int Point1Line = 22;//Point1 所在行
        public static int Point2Line = 24;//Point2 所在行
        public static int Point3Line = 26;//Point3 所在行
        public static int Point4Line = 28;//Point4 所在行
        
        /// <summary>
        /// 初始化SheetTemplate数据
        /// </summary>
        public static void IniSheetTemplate()
        {
            SheetTemplate.Clear();//清空
            string sheetTemplateFile = ConfigPath + "SheetTemplate.csv";
            if (File.Exists(sheetTemplateFile))
            {
                SheetTemplate = ResolveCsvFile(sheetTemplateFile);
                return;
            }
            //无配置文件时初始化相关参数
            int rows = 2;//行数
            int colmuns = 2;//列数
            //追加列数据
            for (int i = 0;i < colmuns;i++)
            {
                DataColumn dc = new DataColumn();
                SheetTemplate.Columns.Add(dc);
            }
            //追加列数据
            for (int i = 0; i < rows; i++)
            {
                DataRow dr = SheetTemplate.NewRow();
                for (int j = 0; j < colmuns; j++)
                {
                    dr[j] = "0";
                }
                SheetTemplate.Rows.Add(dr);
            }
            //设置模板数据
            SheetTemplate.Rows[0][0] = "1";//左上角
            SheetTemplate.Rows[0][1] = "2";//右上角
            SheetTemplate.Rows[1][0] = "3";//左下角
            SheetTemplate.Rows[1][1] = "4";//右下角
        }
        /// <summary> 
        /// 初始化Log组件
        /// </summary>
        public static void IniLogComponent()
        {
            //初始化日志
            LogNet = new LogNetFileSize(@"./Log/", 5 * 1024 * 1024);
        }
        /// <summary>
        /// 初始化系统参数
        /// </summary>
        public static void InitialSysPara()
        {
            string ConfigFile = ConfigPath + "Config.dat"; 
            FileInfo fileInfo = new FileInfo(ConfigFile);
            if (!Directory.Exists(fileInfo.DirectoryName))
            {
                Directory.CreateDirectory(fileInfo.DirectoryName);
                LogNet.WriteError("InitialSysPara():Create Directory!");
                SysPara = new Para();
                return;
            }
            else
            {
                if (File.Exists(ConfigFile))
                {
                    SysPara = (Para)CommonMethod.GetDataFromFile(ConfigFile);
                }
                else
                {
                    LogNet.WriteError("InitialSysPara()：Config.dat is not exist!");
                    SysPara = new Para();
                }
            }
        }
        /// <summary>
        /// 刷新模板文件列表
        /// </summary>
        public static void RefreshTemplateFileList()
        {
            if (!Directory.Exists(TemplatePath))
            {
                Directory.CreateDirectory(TemplatePath);
                SysPara.TemplateFile = "Template File Lost";
                SysPara.TemplateFileList = new List<string>();
                LogNet.WriteError("RefreshTemplateFileList()：There is no Templatefile!");
                return;
            }
            else
            {
                List<FileInfo> Temp = CommonMethod.GetFile(TemplatePath, ".csv");
                if (Temp.Count <=0)
                {
                    SysPara.TemplateFile = "Template File Lost";
                    SysPara.TemplateFileList = new List<string>();
                    LogNet.WriteError("RefreshTemplateFileList()：Template File read error!");
                    return;
                }
                else
                {
                    SysPara.TemplateFileList = Temp.Select(o => o.Name).ToList();//汇总模板文件List
                }
            }
        }
        /// <summary>
        /// 刷新模板配置文件
        /// </summary>
        public static void RefreshTemplateTable()
        {
            if(SysPara.TemplateFile == "Template File Lost")
            {
                //确认
                MessageBox.Show("TemplateFile is not config，Please Check!", "Tip", MessageBoxButtons.YesNo);
                SysPara.TemplateFile = "Template File Lost";
                SysPara.TemplateData = null;
                LogNet.WriteError("RefreshTemplateFileList()：TemplateFile is not exist!");
                return;
            }

            //校验当前模板配置文件是否存在
            if (!SysPara.TemplateFileList.Contains(SysPara.TemplateFile))
            {
                //确认
                MessageBox.Show("TemplateFile is not exist，Please ReSelect!", "Tip", MessageBoxButtons.YesNo);
                SysPara.TemplateFile = "Template File Lost";
                SysPara.TemplateData = null;
                LogNet.WriteError("RefreshTemplateFileList()：TemplateFile is not exist!");
                return;
            }

            //文件是否存在
            string TemplateFile = TemplatePath + SysPara.TemplateFile;
            if (File.Exists(TemplateFile))
            {
                SysPara.TemplateData = null;
                SysPara.TemplateData = ResolveCsvFile(TemplateFile);
            }
            else
            {
                //确认
                MessageBox.Show("TemplateFile is not exist，Please Check!", "Tip", MessageBoxButtons.YesNo);
                SysPara.TemplateFile = "Template File Lost";
                SysPara.TemplateData = null;
                LogNet.WriteError("RefreshTemplateFileList()：TemplateFile is not exist!");
            }
        }

        /// <summary>
        /// 读取Glassinfo，参数Filename,不含后缀
        /// </summary>
        /// <param name="filepath"></param>
        public static void ReadGlassInfo(string fileName)
        { 
            SysPara.GlassInfos.Clear();
            SysPara.GlassInfos = new List<GlassInfo>();
            if (SysPara.SourcePath == "Not Config")
            {
                //MessageBox.Show("Please config the Retrieving Source Catalogue!");
                //MessageBox.Show("Please config the Source Path!");
                MessageBox.Show("Please config the Source Path!", "Tips", MessageBoxButtons.OK, MessageBoxIcon.None, MessageBoxDefaultButton.Button1, MessageBoxOptions.ServiceNotification);
                return;
            }
            string filePath = GlassInfoPath + fileName + ".dat";
            FileInfo fileInfo = new FileInfo(filePath);
            if (!Directory.Exists(fileInfo.DirectoryName))
            {
                Directory.CreateDirectory(fileInfo.DirectoryName);
                LogNet.WriteInfo("ReadGlassInfo():Create Directory!");
            }
            if (File.Exists(filePath))
            {
                SysPara.GlassInfos = (List<GlassInfo>)CommonMethod.GetDataFromFile(filePath);
            }
            
            //扫描文件目录
            string SearchPath = SysPara.SourcePath + "\\" + fileName;
            List<DirectoryInfo> GlassIDListDirectory = CommonMethod.GetFilePath(SearchPath);
            List<FileInfo> GlassIDCsvList = CommonMethod.GetFile(SearchPath,TextSuffix);
            //提取数据
            if(SysPara.GlassInfos.Count != GlassIDListDirectory.Count)//数据不相等
            {
                foreach (var o in GlassIDListDirectory)
                {
                    if (SysPara.GlassInfos.Count <= 0 || SysPara.GlassInfos.Where(p => p.DirName == o.Name).ToList().Count <= 0)
                    {
                        GlassInfo glassInfo = new GlassInfo();
                        //提取ID
                        string tmpID = o.Name;
                        int index = tmpID.IndexOf("TB");
                        if (index != -1)
                        {
                            tmpID = tmpID.Remove(0, index + 2);
                        }
                        glassInfo.Id = tmpID;
                        //提取EQID，Point坐标
                        FileInfo textInfo = GlassIDCsvList.Where(p => p.Name.Contains(tmpID)).FirstOrDefault();
                        if (textInfo != null)
                        {
                            StreamReader sr = new StreamReader(textInfo.FullName);
                            int iLnTmp = 0; //记录文件行数
                            string sTmp = "";//读取的数据
                            while (!sr.EndOfStream && iLnTmp <= Point4Line + 1)//不为最后一行，且小于要读的最后的行数
                            {
                                iLnTmp++;
                                sTmp = sr.ReadLine();    //读取当前行
                                //设备ID
                                if (iLnTmp == ReadEQLine)
                                {
                                    glassInfo.Equip00_ID = GetLastStr(sTmp,',');
                                    glassInfo.Equip01_ID = glassInfo.Equip00_ID;
                                    continue;
                                }
                                //Point1
                                if (iLnTmp == Point1Line)
                                {
                                    glassInfo.Point1.X = GetLastStr(sTmp, ',');
                                    continue;
                                }
                                if (iLnTmp == Point1Line + 1)
                                {
                                    glassInfo.Point1.Y = GetLastStr(sTmp, ',');
                                    continue;
                                }
                                //Point2
                                if (iLnTmp == Point2Line)
                                {
                                    glassInfo.Point2.X = GetLastStr(sTmp, ',');
                                    continue;
                                }
                                if (iLnTmp == Point2Line + 1)
                                {
                                    glassInfo.Point2.Y = GetLastStr(sTmp, ',');
                                    continue;
                                }
                                //Point3
                                if (iLnTmp == Point3Line)
                                {
                                    glassInfo.Point3.X = GetLastStr(sTmp, ',');
                                    continue;
                                }
                                if (iLnTmp == Point3Line + 1)
                                {
                                    glassInfo.Point3.Y = GetLastStr(sTmp, ',');
                                    continue;
                                }
                                //Point4
                                if (iLnTmp == Point4Line)
                                {
                                    glassInfo.Point4.X = GetLastStr(sTmp, ',');
                                    continue;
                                }
                                if (iLnTmp == Point4Line + 1)
                                {
                                    glassInfo.Point4.Y = GetLastStr(sTmp, ',');
                                    continue;
                                }
                            }
                            sr.Close();
                        }
                        //记录文件目录
                        glassInfo.DirName = o.Name;
                        //添加数据
                        SysPara.GlassInfos.Add(glassInfo);
                        //{
                        //    Id = tmpID,
                        //    DirName = o.Name,
                        //    CreateTime = o.CreationTime.ToString("yyyyMMdd hh:ss"),
                        //    Equip00_ID = "",
                        //    Equip01_ID = "",
                        //    Point1 = new SheetShift(0, 0),
                        //    Point2 = new SheetShift(0, 0),
                        //    Point3 = new SheetShift(0, 0),
                        //    Point4 = new SheetShift(0, 0)
                        //});
                    }
                }
            }
        }
        /// <summary>
        /// 拆分字符串，获取最后的值
        /// </summary>
        /// <param name="str"></param>
        /// <param name="splitStr"></param>
        /// <returns></returns>
        public static string GetLastStr(string str,char splitStr)
        {
            string[] tmp = str.Split(splitStr);
            if(tmp.Length>0)
            {
                return tmp[tmp.Length -1];
            }
            else
            {
                return "Err";
            }
        }

        /// <summary>
        /// 保存GlassInfo
        /// </summary>
        /// <param name="fileName"></param>
        public static void SaveGlassInfo(string fileName) 
        {
            if (!SysPara.IsSaveSearchHistory) return;//不保存则退出
            string filePath = GlassInfoPath + fileName + ".dat";
            SysPara.GlassInfos.RemoveAll(o=>o.Id == SelectTips);
            CommonMethod.SaveDataToFile<List<GlassInfo>>(filePath, SysPara.GlassInfos);
        }

        /// <summary>
        /// 解析CSV文件
        /// </summary>
        /// <param name="FilePath"></param>
        public static DataTable ResolveCsvFile(string FilePath) 
        {
            //解析文件路径和文件信息
            FileInfo fileInfo = new FileInfo(FilePath); 
            if (!File.Exists(fileInfo.FullName))
            {
                LogNet.WriteError("ResolveCsvFile()： File is not exist!");
                return null;
            }
            //读取数据
            try
            {
                return CommonMethod.ReadCsvToDt(FilePath,false);
            }
            catch (Exception ex)
            {
                LogNet.WriteError("ResolveCsvFile()： Read File Error!");
                throw ex;
            }
        }

        /// <summary>
        /// 保存CSV数据
        /// </summary>
        /// <param name="FilePath"></param>
        public static void SaveTemplateFile(string FilePath, DataTable dataTable) 
        {
            FileInfo fileInfo = new FileInfo(FilePath);
            if (!Directory.Exists(fileInfo.DirectoryName))
            {
                Directory.CreateDirectory(fileInfo.DirectoryName);
            }
            //检查数据是否为空
            if (dataTable.Columns.Count <= 0 || dataTable.Rows.Count <= 0)
            {
                MessageBox.Show("dataTable is null，Please Check!", "Tip", MessageBoxButtons.YesNo);
                return;
            }
            //保存文件
            var sr = new StreamWriter(FilePath, false, Encoding.UTF8);
            var line = new StringBuilder();

            //保存Columns信息
            //for (int i = 0; i < dataTable.Columns.Count; i++)
            //{
            //    line.Append(dataTable.Columns[i].ColumnName + ",");
            //}
            //line.Remove(line.Length - 1, 1);
            //sr.WriteLine(line.ToString());

            //保存Rows信息
            for (int i = 0; i < dataTable.Rows.Count; i++)
            {
                line.Remove(0, line.Length);
                for (int j = 0; j < dataTable.Columns.Count; j++)
                {
                    line.Append(dataTable.Rows[i][j] + ",");
                }
                line.Remove(line.Length - 1, 1);
                sr.WriteLine(line.ToString());
            }
            sr.Close();
        }

        /// <summary>
        /// 保存SysPara
        /// </summary>
        public static void SaveSysPara()
        {
            string ConfigPath = @"./Config/Config.dat";
            SysPara.GlassInfos.Clear();//清空GlassInfos数据
            CommonMethod.SaveDataToFile<Para>(ConfigPath,SysPara);
        }
    }
}
