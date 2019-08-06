using Emgu.CV;
using Emgu.CV.CvEnum;
using Emgu.CV.Structure;
using Emgu.CV.Util;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Windows.Forms;

namespace Pic_Integrate.Library
{
    class CommonMethod
    {
        /// <summary>
        /// 获得目录下所有文件或指定文件类型文件
        /// </summary>
        /// <param name="path">文件夹路径</param>
        /// <param name="extName">扩展名可以多个 例如 .mp3.wma.rm</param>
        /// <returns>List<FileInfo></returns>
        public static List<FileInfo> GetFile(string path, string extName)
        {
            if (!Directory.Exists(path)) return null;
            try
            {
                List<FileInfo> lst = new List<FileInfo>();
                string[] dir = Directory.GetDirectories(path); //文件夹列表   
                DirectoryInfo fdir = new DirectoryInfo(path);
                FileInfo[] file = fdir.GetFiles();  
                if (file.Length != 0 || dir.Length != 0) //当前目录文件或文件夹不为空                   
                {
                    foreach (FileInfo f in file) //显示当前目录所有文件   
                    {
                        if (extName.ToLower().IndexOf(f.Extension.ToLower()) >= 0)
                        {
                            lst.Add(f);
                        }
                    }
                    //递归访问下一级，即所有文件包含子文件
                    //foreach (string d in dir)
                    //{
                    //    GetFile(d, extName);//递归   
                    //}
                }
                return lst;
            }
            catch (Exception e)
            {
                throw new Exception("GetFile" + e.Message);
            }
        }
        /// <summary>
        /// 获得目录下文件夹
        /// </summary>
        /// <param name="path">文件夹路径</param>
        /// <param name="extName">扩展名可以多个 例如 .mp3.wma.rm</param>
        /// <returns>List<FileInfo></returns>
        public static List<DirectoryInfo> GetFilePath(string path) 
        {
            List<DirectoryInfo> Result = new List<DirectoryInfo>();
            if (!Directory.Exists(path)) return Result;
            try
            {
                string[] dir = Directory.GetDirectories(path); //文件夹列表  
                foreach (var o in dir)
                {
                    DirectoryInfo dirInfo = new DirectoryInfo(o);
                    Result.Add(dirInfo);
                }
                return Result;
            }
            catch (Exception e)
            {
                throw new Exception("GetFilePath" + e.Message);
            }
        }
        /// <summary>
        /// 从FileInfo中检索，filename包含指定字符的Fileinfo
        /// </summary>
        /// <param name="fileInfos"></param>
        /// <param name="charStr"></param>
        /// <returns></returns>
        public static List<FileInfo> GetFileByChar(List<FileInfo> fileInfos,string charStr)
        {
            try
            {
                return fileInfos.Where(o => o.Name.Contains(charStr)).ToList();
            }
            catch (Exception e)
            {
                throw new Exception("GetFilePath" + e.Message);
            }
        }
        /// <summary>
        /// 创建Seal图像并填入指定图像
        /// </summary>
        /// <param name="Result"></param>
        /// <param name="ImgSize"></param>
        /// <param name="Template"></param>
        /// <param name="ImgFilePath"></param>
        /// <param name="charStr"></param>
        /// <param name="direction"></param>
        public static void CreateImg(ref Mat Result, Size ImgSize, DataTable Template, string ImgFilePath, string charStr,Direction direction)
        {
            //异常检测
            if (Template.Rows.Count <= 0 || Template.Columns.Count <= 0) return;
            //确定基本图像大小
            int width = ImgSize.Width;//Columns
            int height = ImgSize.Height;//Rows
            //创建图像
            Result = new Mat(new Size(ImgSize.Width * Template.Columns.Count, ImgSize.Height * Template.Rows.Count), DepthType.Cv8U, 3);//大小，深度 - 8u，通道 - 3
            //获取ImgFileList
            List<FileInfo> ImgFile = GetFile(ImgFilePath, ProgramData.ImgSuffix);

            //Result追加图像
            string id = "";//ID编号
            string name = "";//文件名
            for (int i = 0; i < Template.Rows.Count; i++)
            {
                for (int j = 0; j < Template.Columns.Count; j++)
                {
                    if(charStr == ProgramData.SealStr)
                    {
                        id = Template.Rows[i][j].ToString().PadLeft(3, '0');//获取ID
                        if (id == "000" || string.IsNullOrEmpty(id)) continue;
                    }
                    else
                    {
                        id = Template.Rows[i][j].ToString();//获取ID
                        if (id == "0" || string.IsNullOrEmpty(id)) continue;
                    }
                    //拼接文件名
                    name = charStr + id;
                    //检测文件是否存在
                    FileInfo fileInfo = ImgFile.Where(o => o.Name.Contains(name)).FirstOrDefault();
                    if (fileInfo == null)
                    {
                        CvInvoke.PutText(Result, "Lost:" + name, new Point(width * j, height * i + height / 2), FontFace.HersheySimplex, 2, new MCvScalar(255, 255, 0), 2);//追加文字lost+文件名
                    }
                    else//图片存在
                    {
                        //判断文件是否被移除
                        if (File.Exists(fileInfo.FullName))
                        {
                            Mat Img = new Mat(fileInfo.FullName, ImreadModes.Color);//读取文件
                            //CvInvoke.Imshow("Result"+ id, Img);
                            Rectangle rectangle = new Rectangle(new Point(width * j, height * i), new Size(Img.Width, Img.Height));//创建放置区域,点和大小
                            Mat figureTo = new Mat(Result, rectangle);//定义指向区域
                            Img.CopyTo(figureTo);//将图像粘贴过去
                        }
                        else
                        {
                            CvInvoke.PutText(Result, "Lost:" + fileInfo.Name, new Point(width * i + width / 2, height * j + height / 2), FontFace.HersheySimplex, 10, new MCvScalar(255, 255, 0), 5);//追加文字lost+文件名
                        }
                    }
                }
            }
            //绘制网格线
            for (int i = 0; i <= Template.Rows.Count; i++)//横线 Rows
            {
                CvInvoke.Line(Result, new Point(0, height * i), new Point(width * Template.Columns.Count, height * i), new MCvScalar(0, 255, 0), 2, LineType.EightConnected);
            }
            for (int j = 0; j <= Template.Columns.Count; j++)//竖线 Columns
            {
                CvInvoke.Line(Result, new Point(width * j, 0), new Point(width * j, height * Template.Rows.Count), new MCvScalar(0, 255, 0), 2, LineType.EightConnected);
            }
            //绘制方向
            if (ProgramData.DirectType == 0)
            {
                //绘制三角形 方式0
                VectorOfPoint pointsArray = new VectorOfPoint();
                Point[] points = new Point[3];
                switch (direction)
                {
                    case Direction.TopLeft:
                        points[0] = new Point(0, 0);
                        points[1] = new Point(ProgramData.ArrowSize.Width, 0);
                        points[2] = new Point(0, ProgramData.ArrowSize.Height);
                        pointsArray.Push(points);
                        CvInvoke.FillConvexPoly(Result, pointsArray, new MCvScalar(0, 0, 255), LineType.EightConnected);
                        break;
                    case Direction.BottomLeft:
                        points[0] = new Point(0, Result.Height - ProgramData.ArrowSize.Height);
                        points[1] = new Point(0, Result.Height);
                        points[2] = new Point(ProgramData.ArrowSize.Width, Result.Height);
                        pointsArray.Push(points);
                        CvInvoke.FillConvexPoly(Result, pointsArray, new MCvScalar(0, 0, 255), LineType.EightConnected);
                        break;
                    case Direction.TopRigth:
                        points[0] = new Point(Result.Width - ProgramData.ArrowSize.Width, 0);
                        points[1] = new Point(Result.Width, 0);
                        points[2] = new Point(Result.Width, ProgramData.ArrowSize.Height);
                        pointsArray.Push(points);
                        CvInvoke.FillConvexPoly(Result, pointsArray, new MCvScalar(0, 0, 255), LineType.EightConnected);
                        break;
                    case Direction.BottomRight:
                        points[0] = new Point(Result.Width, Result.Height - ProgramData.ArrowSize.Height);
                        points[1] = new Point(Result.Width, Result.Height);
                        points[2] = new Point(Result.Width - ProgramData.ArrowSize.Width, Result.Height);
                        pointsArray.Push(points);
                        CvInvoke.FillConvexPoly(Result, pointsArray, new MCvScalar(0, 0, 255), LineType.EightConnected);
                        break;
                    default:
                        break;
                }
            }
            else if (ProgramData.DirectType == 1)
            {
                //绘制箭头 方式1
                switch (direction)
                {
                    case Direction.TopLeft:
                        CvInvoke.ArrowedLine(Result, new Point(ProgramData.ArrowSize), new Point(0, 0), new MCvScalar(0, 0, 255), 2, LineType.EightConnected);
                        break;
                    case Direction.BottomLeft:
                        CvInvoke.ArrowedLine(Result, new Point(ProgramData.ArrowSize.Width, Result.Height - ProgramData.ArrowSize.Height), new Point(0, Result.Height), new MCvScalar(0, 0, 255), 5, LineType.EightConnected);
                        break;
                    case Direction.TopRigth:
                        CvInvoke.ArrowedLine(Result, new Point(Result.Width - ProgramData.ArrowSize.Width, ProgramData.ArrowSize.Height), new Point(Result.Width, 0), new MCvScalar(0, 0, 255), 5, LineType.EightConnected);
                        break;
                    case Direction.BottomRight:
                        CvInvoke.ArrowedLine(Result, new Point(Result.Width - ProgramData.ArrowSize.Width, Result.Height - ProgramData.ArrowSize.Height), new Point(Result.Width, Result.Height), new MCvScalar(0, 0, 255), 5, LineType.EightConnected);
                        break;
                    default:
                        break;
                }
            }
            GC.Collect();//回收资源
        }

        /// <summary>
        /// 为ComboBox绑定数据源并提供下拉提示
        /// </summary>
        /// <typeparam name="T">泛型</typeparam>
        /// <param name="combox">ComboBox</param>
        /// <param name="list">数据源</param>
        /// <param name="displayMember">显示字段</param>
        /// <param name="valueMember">隐式字段</param>
        /// <param name="displayText">下拉提示文字</param>
        public static void Bind<T>(ref ComboBox combox, IList<T> list, string displayMember, string valueMember, string displayText)
        {
            AddItem(list, displayMember, displayText);
            combox.DataSource = list;
            combox.DisplayMember = displayMember;
            if (!string.IsNullOrEmpty(valueMember))
                combox.ValueMember = valueMember;
        }
        private static void AddItem<T>(IList<T> list, string displayMember, string displayText)
        {
            Object _obj = Activator.CreateInstance<T>();
            Type _type = _obj.GetType();
            if (!string.IsNullOrEmpty(displayMember))
            {
                PropertyInfo _displayProperty = _type.GetProperty(displayMember);
                _displayProperty.SetValue(_obj, displayText, null);//设置显示名
                _displayProperty = _type.GetProperty("CreateTime");
                _displayProperty.SetValue(_obj, "", null);//设置生成时间
            }
            list.Insert(0, (T)_obj);
        }

        #region 读取/写入 磁盘文件
        /// <summary>
        /// 读取 磁盘文件
        /// </summary>
        /// <param name="path"></param>
        /// <returns></returns>
        public static object GetDataFromFile(string path)
        {
            FileStream fs = null;
            try
            {
                fs = new FileStream(path, FileMode.Open);
                BinaryFormatter bf = new BinaryFormatter();
                return bf.Deserialize(fs);
            }
            catch(Exception e)
            {
                throw new Exception("GetDataToFile" + e.Message);
            }
            finally
            {
                if (fs != null) fs.Close();
            }
        }
        /// <summary>
        /// 写入 磁盘文件
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="path"></param>
        /// <param name="data"></param>
        public static void SaveDataToFile<T>(string path, T data)
        {
            FileStream fs = null;
            try
            {
                fs = new FileStream(path, FileMode.OpenOrCreate);
                BinaryFormatter bf = new BinaryFormatter();
                bf.Serialize(fs, data);
                fs.Close();
            }
            catch (Exception e)
            {
                throw new Exception("SaveDataToFile" + e.Message);
            }
            finally
            {
                if (fs != null) fs.Close();
            }
        }
        #endregion

        #region Csv文件操作
        /// <summary>
        /// 将CSV文件的数据读取到DataTable中
        /// </summary>
        /// <param name="filePath"></param>
        /// <param name="IsContainColHeader"></param>
        /// <returns></returns>
        public static DataTable ReadCsvToDt(string filePath,bool IsContainColHeader)
        {
            Encoding encoding = EncodingType.GetType(filePath); //获取编码格式
            DataTable dt = new DataTable();
            FileStream fs = new FileStream(filePath, System.IO.FileMode.Open, System.IO.FileAccess.Read);
            //StreamReader sr = new StreamReader(fs, Encoding.UTF8);
            StreamReader sr = new StreamReader(fs, encoding);
            //string fileContent = sr.ReadToEnd();
            //encoding = sr.CurrentEncoding;
            //记录每次读取的一行记录
            string strLine = "";
            //记录每行记录中的各字段内容
            string[] aryLine = null;
            string[] tableHead = null;
            //标示列数
            int columnCount = 0;
            //标示是否是读取的第一行
            bool IsFirst = true;
            //逐行读取CSV中的数据
            while ((strLine = sr.ReadLine()) != null)
            {
                //strLine = Common.ConvertStringUTF8(strLine, encoding);
                //strLine = Common.ConvertStringUTF8(strLine);
                if (IsFirst == true)
                {
                    tableHead = strLine.Split(',');
                    IsFirst = false;
                    columnCount = tableHead.Length;

                    //创建列
                    for (int i = 0; i < columnCount; i++)
                    {
                        //判断是否包含行标题
                        if (IsContainColHeader)
                        {
                            DataColumn dc = new DataColumn(tableHead[i]);
                            dt.Columns.Add(dc);
                        }
                        else
                        {
                            DataColumn dc = new DataColumn();
                            dt.Columns.Add(dc);
                        }
                    }
                    //追加行数据
                    if (!IsContainColHeader)
                    {
                        aryLine = strLine.Split(',');
                        DataRow dr = dt.NewRow();
                        for (int j = 0; j < columnCount; j++)
                        {
                            dr[j] = aryLine[j];
                        }
                        dt.Rows.Add(dr);
                    }
                }
                else
                {
                    aryLine = strLine.Split(',');
                    DataRow dr = dt.NewRow();
                    for (int j = 0; j < columnCount; j++)
                    {
                        dr[j] = aryLine[j];
                    }
                    dt.Rows.Add(dr);
                }
            }
            //关闭文件流
            sr.Close();
            fs.Close();
            return dt;
        }
        /// <summary>
        /// 将DataTable中数据写入到CSV文件中
        /// </summary>
        /// <param name="dt">提供保存数据的DataTable</param>
        /// <param name="fullPath">CSV的文件路径</param>
        public static void SaveDtToCsv(string fullPath, DataTable dt)  
        {
            FileInfo fi = new FileInfo(fullPath);
            if (!fi.Directory.Exists)
            {
                fi.Directory.Create();
            }
            FileStream fs = new FileStream(fullPath, System.IO.FileMode.Create, System.IO.FileAccess.Write);
            //StreamWriter sw = new StreamWriter(fs, System.Text.Encoding.Default);
            StreamWriter sw = new StreamWriter(fs, System.Text.Encoding.UTF8);
            string data = "";
            //写出列名称
            for (int i = 0; i < dt.Columns.Count; i++)
            {
                data += dt.Columns[i].ColumnName.ToString();
                if (i < dt.Columns.Count - 1)
                {
                    data += ",";
                }
            }
            sw.WriteLine(data);
            //写出各行数据
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                data = "";
                for (int j = 0; j < dt.Columns.Count; j++)
                {
                    string str = dt.Rows[i][j].ToString();
                    str = str.Replace("\"", "\"\"");//替换英文冒号 英文冒号需要换成两个冒号
                    if (str.Contains(',') || str.Contains('"')
                        || str.Contains('\r') || str.Contains('\n')) //含逗号 冒号 换行符的需要放到引号中
                    {
                        str = string.Format("\"{0}\"", str);
                    }

                    data += str;
                    if (j < dt.Columns.Count - 1)
                    {
                        data += ",";
                    }
                }
                sw.WriteLine(data);
            }
            sw.Close();
            fs.Close();
        }
        #endregion

    }

    //编码问题目前为止，基本上没人解决，就连windows的IE的自动识别有时还识别错编码呢。--yongfa365   
    //如果文件有BOM则判断，如果没有就用系统默认编码，缺点：没有BOM的非系统编码文件会显示乱码。   
    //调用方法： EncodingType.GetType(filename) 
    public class EncodingType
    {
        /// <summary>
        /// 获取文件编码格式
        /// </summary>
        /// <param name="FILE_NAME"></param>
        /// <returns></returns>
        public static System.Text.Encoding GetType(string FILE_NAME)
        {
            FileStream fs = new FileStream(FILE_NAME, FileMode.Open, FileAccess.Read);
            System.Text.Encoding r = GetType(fs);
            fs.Close();
            return r;
        }
        /// <summary> 
        /// 通过给定的文件流，判断文件的编码类型 
        /// </summary> 
        /// <param name=“fs“>文件流</param> 
        /// <returns>文件的编码类型</returns> 
        public static System.Text.Encoding GetType(FileStream fs)
        {
            byte[] Unicode = new byte[] { 0xFF, 0xFE, 0x41 };
            byte[] UnicodeBIG = new byte[] { 0xFE, 0xFF, 0x00 };
            byte[] UTF8 = new byte[] { 0xEF, 0xBB, 0xBF }; //带BOM 
            Encoding reVal = Encoding.Default;
            BinaryReader r = new BinaryReader(fs, System.Text.Encoding.Default);
            int.TryParse(fs.Length.ToString(), out int i);
            byte[] ss = r.ReadBytes(i);
            if (IsUTF8Bytes(ss) || (ss[0] == 0xEF && ss[1] == 0xBB && ss[2] == 0xBF))
            {
                reVal = Encoding.UTF8;
            }
            else if (ss[0] == 0xFE && ss[1] == 0xFF && ss[2] == 0x00)
            {
                reVal = Encoding.BigEndianUnicode;
            }
            else if (ss[0] == 0xFF && ss[1] == 0xFE && ss[2] == 0x41)
            {
                reVal = Encoding.Unicode;
            }
            r.Close();
            return reVal;
        }

        /// <summary> 
        /// 判断是否是不带 BOM 的 UTF8 格式 
        /// </summary> 
        /// <param name=“data“></param> 
        /// <returns></returns> 
        private static bool IsUTF8Bytes(byte[] data)
        {
            int charByteCounter = 1; //计算当前正分析的字符应还有的字节数 
            byte curByte; //当前分析的字节. 
            for (int i = 0; i < data.Length; i++)
            {
                curByte = data[i];
                if (charByteCounter == 1)
                {
                    if (curByte >= 0x80)
                    {
                        //判断当前 
                        while (((curByte <<= 1) & 0x80) != 0)
                        {
                            charByteCounter++;
                        }
                        //标记位首位若为非0 则至少以2个1开始 如:110XXXXX...........1111110X 
                        if (charByteCounter == 1 || charByteCounter > 6)
                        {
                            return false;
                        }
                    }
                }
                else
                {
                    //若是UTF-8 此时第一位必须为1 
                    if ((curByte & 0xC0) != 0x80)
                    {
                        return false;
                    }
                    charByteCounter--;
                }
            }
            if (charByteCounter > 1)
            {
                throw new Exception("非预期的byte格式");
            }
            return true;
        }
       
    }
    /// <summary>
    /// 用于Combox显示绑定的枚举对象
    /// </summary>
    public class BindComboxEnumType<T>
    {
        /// <summary>
        /// 类型的名字
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// 类型
        /// </summary>
        public T Type { get; set; }

        private static readonly List<BindComboxEnumType<T>> bindTyps;

        static BindComboxEnumType()
        {
            bindTyps = new List<BindComboxEnumType<T>>();

            foreach (var name in Enum.GetNames(typeof(T)))
            {
                bindTyps.Add(new BindComboxEnumType<T>()
                {
                    Name = name,
                    Type = (T)Enum.Parse(typeof(T), name)
                });
            }
        }

        /// <summary>
        /// 绑定的类型数据
        /// </summary>
        public static List<BindComboxEnumType<T>> BindTyps
        {
            get { return bindTyps; }
        }
    }
}
