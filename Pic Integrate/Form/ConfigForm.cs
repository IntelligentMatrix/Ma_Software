using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace Pic_Integrate
{
    public partial class ConfigForm : Form
    {
        public ConfigForm()
        {
            InitializeComponent();
        }
        /// <summary>
        /// 页面加载
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ConfigForm_Load(object sender, EventArgs e)
        {
            //初始化Template页面显示
            IniTemplateDisplay();

            //初始化Para数据
            IniParaDisplay();
        }
        #region 属性发生改变
        /*********************Template页面******************************/
        bool TemplatePropertyChanged = false;//Template页面属性值改变标志
        bool TemplatePropertyIniFlag = false;//Template页面属性值初始化标志
        string ConfigFileListPreValue = "";
        /// <summary>
        /// Template配置文件选项发生改变
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void comboBox_ConfigFileList_SelectedIndexChanged(object sender, EventArgs e)
        {

            //保存修改参数
            if (TemplatePropertyChanged)//属性发生改变
            {
                TemplatePropertyChanged = false;
                //确认是否保存
                if (DialogResult.Yes == MessageBox.Show("Save the Change", "Tip", MessageBoxButtons.YesNo))
                {
                    //传入保存函数
                    TemplateSaveProcess(ConfigFileListPreValue);
                }
            }
            ConfigFileListPreValue = comboBox_ConfigFileList.SelectedItem.ToString();
            //置位初始化标志
            TemplatePropertyIniFlag = true;

            //读取新的配置文件
            ProgramData.SysPara.TemplateData = ProgramData.ResolveCsvFile(ProgramData.TemplatePath+ comboBox_ConfigFileList.SelectedItem.ToString());
            //刷新表格
            SetDatagrid();

            //刷新Template界面数据
            numericUpDown_Row.Value = ProgramData.SysPara.TemplateData.Rows.Count > 0 ? ProgramData.SysPara.TemplateData.Rows.Count : 1;
            numericUpDown_Cols.Value = ProgramData.SysPara.TemplateData.Columns.Count > 0 ? ProgramData.SysPara.TemplateData.Columns.Count : 1;

            //延时
            Thread.Sleep(30);

            //清除初始化标志
            TemplatePropertyIniFlag = false;
        }
        /// <summary>
        /// Rows改变
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void numericUpDown_Row_ValueChanged(object sender, EventArgs e)
        {
            //初始化标志
            if (TemplatePropertyIniFlag) return;
            //属性修改标志
            TemplatePropertyChanged = true;
            //修正数据
            if (ProgramData.SysPara.TemplateData.Rows.Count == numericUpDown_Row.Value) return;
            //修正Row
            if (ProgramData.SysPara.TemplateData.Rows.Count > numericUpDown_Row.Value)//删除行Row
            {
                do
                {
                    ProgramData.SysPara.TemplateData.Rows.RemoveAt(ProgramData.SysPara.TemplateData.Rows.Count - 1);
                } while (ProgramData.SysPara.TemplateData.Rows.Count > numericUpDown_Row.Value);
                return;
            }
            if (ProgramData.SysPara.TemplateData.Rows.Count < numericUpDown_Row.Value)//增加行Row
            {
                do
                {
                    ProgramData.SysPara.TemplateData.Rows.Add(new DataColumn());
                    //填充数据
                    for (int i = 0; i < ProgramData.SysPara.TemplateData.Columns.Count; i++)
                    {
                        ProgramData.SysPara.TemplateData.Rows[ProgramData.SysPara.TemplateData.Rows.Count - 1][i] = "0";
                    }
                } while (ProgramData.SysPara.TemplateData.Rows.Count < numericUpDown_Row.Value);
                return;
            }
            //刷新表格
            SetDatagrid();
        }
        /// <summary>
        /// Cols改变
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void numericUpDown_Cols_ValueChanged(object sender, EventArgs e)
        {
            //初始化标志
            if (TemplatePropertyIniFlag) return;
            //属性修改标志
            TemplatePropertyChanged = true;
            //修正数据
            if (ProgramData.SysPara.TemplateData.Columns.Count == numericUpDown_Cols.Value) return;
            //修正Column
            if (ProgramData.SysPara.TemplateData.Columns.Count > numericUpDown_Cols.Value)//删除列Column
            {
                do
                {
                    ProgramData.SysPara.TemplateData.Columns.RemoveAt(ProgramData.SysPara.TemplateData.Columns.Count - 1);
                } while (ProgramData.SysPara.TemplateData.Columns.Count > numericUpDown_Cols.Value);                
                return;
            }
            if (ProgramData.SysPara.TemplateData.Columns.Count < numericUpDown_Cols.Value)//增加列Column
            {
                do
                {
                    ProgramData.SysPara.TemplateData.Columns.Add(new DataColumn());
                    //填充数据
                    for (int i = 0;i < ProgramData.SysPara.TemplateData.Rows.Count;i++)
                    {
                        ProgramData.SysPara.TemplateData.Rows[i][ProgramData.SysPara.TemplateData.Columns.Count - 1] = "0";
                    }
                } while (ProgramData.SysPara.TemplateData.Columns.Count < numericUpDown_Cols.Value);
                return;
            }
            //刷新表格
            SetDatagrid();
        }
        /// <summary>
        /// Template Cell Valuechanged
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dataGridView_Template_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            //初始化标志
            if (TemplatePropertyIniFlag) return;
            //属性修改标志
            TemplatePropertyChanged = true;
        }
        /// <summary>
        /// 设置Data Grid数据和格式
        /// </summary>
        private void SetDatagrid()
        {
            dataGridView_Template.DataSource = null;//清空数据
            dataGridView_Template.DataSource = ProgramData.SysPara.TemplateData;//绑定数据
            //设置列宽
            for(int i = 0;i < dataGridView_Template.Columns.Count; i++)
            {
                dataGridView_Template.Columns[i].Width = 80;
            }
            //设置行高
            for (int i = 0; i < dataGridView_Template.Rows.Count; i++)
            {
                dataGridView_Template.Rows[i].Height = 80;
            }
        }

        /// <summary>
        /// Template属性改变保存流程
        /// </summary>
        private void TemplateSaveProcess(string filename)
        {
            //保存流程
            ProgramData.SaveTemplateFile(ProgramData.TemplatePath+ filename, (DataTable)dataGridView_Template.DataSource);
        }
        /// <summary>
        /// 新建配置文件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void userButton_Create_Click(object sender, EventArgs e)
        {
            NewTemplateFile addTemplateFile = new NewTemplateFile();
            addTemplateFile.GetResult += addTemplateFileEvent;
            addTemplateFile.StartPosition = FormStartPosition.CenterScreen;
            addTemplateFile.ShowDialog();
        }
        /// <summary>
        /// 添加新Template文件事件
        /// </summary>
        /// <param name="name"></param>
        /// <param name="cols"></param>
        /// <param name="rows"></param>
        /// <returns></returns>
        private bool addTemplateFileEvent(string name, int cols, int rows)
        {
            if (ProgramData.SysPara.TemplateFileList.Count <= 0)
            {
                CreateNewTemplate(name, cols, rows);//创建文件
                //返回事件
                return true;
            }
            else
            {
                if (ProgramData.SysPara.TemplateFileList.Contains(name + ".csv"))
                {
                    return false;
                }
                else
                {
                    CreateNewTemplate(name, cols, rows);//创建文件
                    //返回事件
                    return true;
                }
            }

        }
        /// <summary>
        /// 新建数据并刷新
        /// </summary>
        /// <param name="name"></param>
        /// <param name="cols"></param>
        /// <param name="rows"></param>
        private void CreateNewTemplate(string name, int cols, int rows)
        {
            //添加列表
            ProgramData.SysPara.TemplateFileList.Add(name + ".csv");
            //创建数据
            ProgramData.SysPara.TemplateData = new DataTable();
            DataTable dataTable = new DataTable();
            //追加列数据
            for (int i = 0; i < cols; i++)
            {
                dataTable.Columns.Add(new DataColumn());
            }
            //追加行数据            
            for (int i = 0; i < rows; i++)
            {
                DataRow dr = dataTable.NewRow();
                for (int j = 0; j < cols; j++)
                {
                    dr[j] = "0";
                }
                dataTable.Rows.Add(dr);
            }
            //添加数据
            ProgramData.SysPara.TemplateData = dataTable;
            //保存至文件
            ProgramData.SaveTemplateFile(ProgramData.TemplatePath+ name + ".csv", ProgramData.SysPara.TemplateData);
            //刷新数据
            comboBox_ConfigFileList.Items.Clear();
            comboBox_ConfigFileList.Items.AddRange(ProgramData.SysPara.TemplateFileList.ToArray());
            if (comboBox_ConfigFileList.Items.Count > 0)
            {
                comboBox_ConfigFileList.SelectedIndex = comboBox_ConfigFileList.Items.Count - 1;
                //刷新表格
                SetDatagrid();
            }
        }

        /// <summary>
        /// 删除配置文件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void userButton_Delete_Click(object sender, EventArgs e)
        {
            //判断是否选中文件
            if (comboBox_ConfigFileList.SelectedIndex < 0)
            {
                MessageBox.Show("请先选中相应的配置文件！");
                return;
            }
            //确认
            if (DialogResult.No == MessageBox.Show("Delete the Option?", "Tip", MessageBoxButtons.YesNo))
                return;
            //删除操作
            string FilePath = ProgramData.TemplatePath + comboBox_ConfigFileList.SelectedItem.ToString();
            FileInfo fileInfo = new FileInfo(FilePath);
            if (File.Exists(fileInfo.FullName))
            {
                File.Delete(fileInfo.FullName);
                Thread.Sleep(30);
            }

            //刷新文件列表
            ProgramData.RefreshTemplateFileList();
            //初始化Template页面显示
            IniTemplateDisplay();
        }
        /// <summary>
        /// 刷新模板文件list
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void userButton_Refresh_Click(object sender, EventArgs e)
        {
            //刷新文件列表
            ProgramData.RefreshTemplateFileList();
            //初始化Template页面显示
            IniTemplateDisplay();
        }
        /// <summary>
        /// 初始化Template页面显示
        /// </summary>
        private void IniTemplateDisplay()
        {
            //刷新数据
            comboBox_ConfigFileList.Items.Clear();
            comboBox_ConfigFileList.Items.AddRange(ProgramData.SysPara.TemplateFileList.ToArray());
            if (comboBox_ConfigFileList.Items.Count > 0)
            {
                comboBox_ConfigFileList.SelectedIndex = 0;
                //读取新的配置文件
                ProgramData.SysPara.TemplateData = ProgramData.ResolveCsvFile(ProgramData.TemplatePath + comboBox_ConfigFileList.SelectedItem.ToString());
                //刷新表格
                SetDatagrid();
            }

            //设置上一次值
            ConfigFileListPreValue = comboBox_ConfigFileList.SelectedItem.ToString();

        }

        /// <summary>
        /// Tab Control Changed
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tabControl_Template_SelectedIndexChanged(object sender, EventArgs e)
        {
            //保存Template参数
            if (TemplatePropertyChanged)//属性发生改变
            {
                TemplatePropertyChanged = false;
                //确认是否保存
                if (DialogResult.Yes == MessageBox.Show("Save the Template File Change!", "Tip", MessageBoxButtons.YesNo))
                {
                    //传入保存函数
                    TemplateSaveProcess(comboBox_ConfigFileList.SelectedItem.ToString());
                }
            }
            //保存SysPara参数
            if (ParaPropertyChanged)//属性发生改变
            {
                ParaPropertyChanged = false;
                //确认是否保存
                if (DialogResult.Yes == MessageBox.Show("Save the SysPara Change!", "Tip", MessageBoxButtons.YesNo))
                {
                    //更新数据
                    ProgramData.SysPara.SourcePath = textBox_SourcePath.Text;
                    ProgramData.SysPara.TemplateFile = comboBox_CurrentTemplateFile.SelectedIndex >= 0 ? comboBox_CurrentTemplateFile.SelectedItem.ToString() : "Not Config";
                    ProgramData.SysPara.SealSize = new Size((int)numericUpDown_SealWidth.Value, (int)numericUpDown_SealHeight.Value);
                    ProgramData.SysPara.SheetSize = new Size((int)numericUpDown_SheetWidth.Value, (int)numericUpDown_SheetHeight.Value);
                    ProgramData.SysPara.ImgSavePath = textBox_ImgSavePath.Text;
                    ProgramData.SysPara.IsSaveSearchHistory = checkBox_IsSaveSearchHistory.Checked;

                    //保存数据
                    ProgramData.SaveSysPara();
                }
            }
        }

        /*********************Para页面******************************/
        bool ParaPropertyChanged = false;//Para页面属性值改变标志
        bool ParaPropertyIniFlag = false;//Para页面属性值初始化标志
        /// <summary>
        /// Para页面属性值改变事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ParaPropertyChangedEvent(object sender, EventArgs e)
        {
            if (ParaPropertyIniFlag) return;
            ParaPropertyChanged = true;
        }

        /// <summary>
        /// 初始化Para页面显示
        /// </summary>
        private void IniParaDisplay()
        {
            //置位初始化标志
            ParaPropertyIniFlag = true;
            //刷新数据
            comboBox_CurrentTemplateFile.Items.Clear();
            comboBox_CurrentTemplateFile.Items.AddRange(ProgramData.SysPara.TemplateFileList.ToArray());
            if (comboBox_CurrentTemplateFile.Items.Count > 0)
            {
                if(!ProgramData.SysPara.TemplateFileList.Contains(ProgramData.SysPara.TemplateFile))
                {
                    comboBox_CurrentTemplateFile.SelectedIndex = 0;
                    ProgramData.SysPara.TemplateFile = comboBox_CurrentTemplateFile.SelectedItem.ToString();
                }
                else
                {
                    comboBox_CurrentTemplateFile.SelectedIndex = comboBox_CurrentTemplateFile.Items.IndexOf(ProgramData.SysPara.TemplateFile);
                }
            }
            //SourcePath
            textBox_SourcePath.Text = ProgramData.SysPara.SourcePath;
            //Seal图片尺寸
            numericUpDown_SealWidth.Value = ProgramData.SysPara.SealSize.Width;
            numericUpDown_SealHeight.Value = ProgramData.SysPara.SealSize.Height;
            //Sheet图片尺寸
            numericUpDown_SheetWidth.Value = ProgramData.SysPara.SheetSize.Width;
            numericUpDown_SheetHeight.Value = ProgramData.SysPara.SheetSize.Height;
            //ImgSavePath
            textBox_ImgSavePath.Text = ProgramData.SysPara.ImgSavePath;
            //IsSaveSearchHistory
            checkBox_IsSaveSearchHistory.Checked = ProgramData.SysPara.IsSaveSearchHistory;
            //清除初始化标志
            Thread.Sleep(30);
            ParaPropertyIniFlag = false;

            //绑定事件
            comboBox_CurrentTemplateFile.SelectedIndexChanged += ParaPropertyChangedEvent;
            textBox_SourcePath.TextChanged += ParaPropertyChangedEvent;
            numericUpDown_SealWidth.ValueChanged += ParaPropertyChangedEvent;
            numericUpDown_SealHeight.ValueChanged += ParaPropertyChangedEvent;
            numericUpDown_SheetWidth.ValueChanged += ParaPropertyChangedEvent;
            numericUpDown_SheetHeight.ValueChanged += ParaPropertyChangedEvent;
            textBox_ImgSavePath.TextChanged += ParaPropertyChangedEvent;
            checkBox_IsSaveSearchHistory.CheckedChanged += ParaPropertyChangedEvent;
        }
        /// <summary>
        /// 设置文件监控目录
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void userButton_Set_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog path = new FolderBrowserDialog();
            path.ShowDialog();
            textBox_SourcePath.Text = path.SelectedPath;
        }
        /// <summary>
        /// 图片保存目录
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void UserButtonImg_SavePath_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog path = new FolderBrowserDialog();
            path.ShowDialog();
            textBox_ImgSavePath.Text = path.SelectedPath;
        }
        #endregion
        /// <summary>
        /// 窗口关闭
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ConfigForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            //保存事件
            if (ParaPropertyChanged || TemplatePropertyChanged)
            {
                if (DialogResult.Yes == MessageBox.Show("Save the Change", "Tip", MessageBoxButtons.YesNo))
                {
                    //保存Template 参数
                    if (TemplatePropertyChanged)//属性发生改变
                    {
                        TemplatePropertyChanged = false;
                        //传入保存函数
                        TemplateSaveProcess(comboBox_ConfigFileList.SelectedItem.ToString());
                    }
                    //保存SysPara 参数
                    if (ParaPropertyChanged)//属性发生改变
                    {
                        ParaPropertyChanged = false;

                        //更新数据
                        ProgramData.SysPara.SourcePath = textBox_SourcePath.Text;
                        ProgramData.SysPara.TemplateFile = comboBox_CurrentTemplateFile.SelectedIndex >= 0 ? comboBox_CurrentTemplateFile.SelectedItem.ToString() : "Not Config";
                        ProgramData.SysPara.SealSize = new Size((int)numericUpDown_SealWidth.Value,(int)numericUpDown_SealHeight.Value);
                        ProgramData.SysPara.SheetSize = new Size((int)numericUpDown_SheetWidth.Value, (int)numericUpDown_SheetHeight.Value);
                        ProgramData.SysPara.ImgSavePath = textBox_ImgSavePath.Text;
                        ProgramData.SysPara.IsSaveSearchHistory = checkBox_IsSaveSearchHistory.Checked;
                        
                        //保存数据
                        ProgramData.SaveSysPara();
                    }
                }
            }
            //重新读取Template
            ProgramData.RefreshTemplateTable();
        }
        
    }
}
