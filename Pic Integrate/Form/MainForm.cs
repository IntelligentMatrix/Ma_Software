using Emgu.CV;
using System;
using System.ComponentModel;
using System.IO;
using System.Threading;
using System.Windows.Forms;
using Pic_Integrate.Library;

namespace Pic_Integrate
{
    public partial class MainForm : Form
    {
        Mat SealImgMat = new Mat();//Seal图片
        Mat SheetImgMat = new Mat();//Sheet图片
        private BackgroundWorker bgWorker = new BackgroundWorker();//后台运行程序 
        public MainForm()
        {
            InitializeComponent();
            InitializeBackgroundWorker();
        }
        
        bool IniFlag = false;
        /// <summary>
        /// 窗口加载函数
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MainForm_Load(object sender, EventArgs e)
        {
           
            //置位初始化标志
            IniFlag = true;
            Thread.Sleep(30);
            //玻璃ID信息
            bgWorker.RunWorkerAsync();

            //Glass方向
            comboBox_GlassDirection.DataSource = BindComboxEnumType<Direction>.BindTyps;
            comboBox_GlassDirection.DisplayMember = "Name";
            comboBox_GlassDirection.ValueMember = "Type";
            int index = BindComboxEnumType<Direction>.BindTyps.FindIndex(o => o.Name == ProgramData.SysPara.GlassDirection.ToString());
            if (index >= 0)
            {
                comboBox_GlassDirection.SelectedIndex = index;
            }
            //清除初始化标志
            IniFlag = false;
        }
        
        /// <summary>
        /// 初始化
        /// </summary>
        private void InitializeBackgroundWorker()
        {
            bgWorker.WorkerReportsProgress = true;
            bgWorker.WorkerSupportsCancellation = true;
            bgWorker.DoWork += new DoWorkEventHandler(bgWorker_DoWork);
            bgWorker.ProgressChanged += new ProgressChangedEventHandler(bgWorker_ProgessChanged);
            bgWorker.RunWorkerCompleted += new RunWorkerCompletedEventHandler(bgWorker_WorkerCompleted);
        }
        /// <summary>
        /// 后台运行的程序
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void bgWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            this.Invoke((EventHandler)delegate
            {
                //状态更新
                this.Status_Label.Text = "ing...!";
                this.dateTimePicker_SearchTime.Enabled = false;
                this.comboBox_GlassIDList.Enabled = false;
                this.userButton_Refresh.Enabled = false;
            });
            //读取数据
            ProgramData.ReadGlassInfo(dateTimePicker_SearchTime.Value.ToString(ProgramData.DateFormat));
        }
        /// <summary>
        /// 进程刷新程序
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void bgWorker_ProgessChanged(object sender, ProgressChangedEventArgs e)
        {
            return;
        }
        /// <summary>
        /// 后台程序完成
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void bgWorker_WorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (e.Error != null)
            {
                MessageBox.Show(e.Error.ToString());
                return;
            }
            if (!e.Cancelled)
                this.Status_Label.Text = "Finish!";
            else
                this.Status_Label.Text = "Exit!";
            //恢复状态
            this.dateTimePicker_SearchTime.Enabled = true;
            this.comboBox_GlassIDList.Enabled = true;
            this.userButton_Refresh.Enabled = true;
            //玻璃ID信息
            CommonMethod.Bind<GlassInfo>(ref this.comboBox_GlassIDList, ProgramData.SysPara.GlassInfos, "Id", "", ProgramData.SelectTips);//comboBox_GlassIDList帮定数据
            //保存检索信息
            ProgramData.SaveGlassInfo(dateTimePicker_SearchTime.Value.ToString(ProgramData.DateFormat));
        }
        /// <summary>
        /// 保存Seal 和 Sheet 图片至指定目录
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string savePath = ProgramData.SysPara.ImgSavePath + "\\" + dateTimePicker_SearchTime.Value.ToString("yyyyMMdd") + "\\";
            //检测选择是否为空
            GlassInfo glassInfo = comboBox_GlassIDList.SelectedItem as GlassInfo;
            if (glassInfo.Id == ProgramData.SelectTips) return;
            //检测保存目录是否存在
            if (!Directory.Exists(savePath))
            {
                Directory.CreateDirectory(savePath);
            }
            //保存Seal图片
            if (!SealImgMat.IsEmpty)
            {
                string sealFileName = savePath + glassInfo.Id + "_" + ProgramData.SealStr + ProgramData.ImgSuffix;
                SealImgMat.Save(sealFileName);
            }
            //保存Sheet图片
            if (!SheetImgMat.IsEmpty)
            {
                string sealFileName = savePath + glassInfo.Id + "_" + ProgramData.SheetStr + ProgramData.ImgSuffix;
                SheetImgMat.Save(sealFileName);
            }
        }
        /// <summary>
        /// 保存SealImg至选择目录
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SaveSealPicToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //检测选择是否为空
            GlassInfo glassInfo = comboBox_GlassIDList.SelectedItem as GlassInfo;
            if (glassInfo.Id == ProgramData.SelectTips)
            {
                MessageBox.Show("Not Select Glass!");
                return;
            }
            //保存Seal图片
            if (!SealImgMat.IsEmpty)
            {
                SaveFileDialog saveFileDialog = new SaveFileDialog();
                saveFileDialog.Filter = "Picture |*.jpg;*.png;*.gif;*.jpeg;*.bmp";
                saveFileDialog.FilterIndex = 2;
                saveFileDialog.RestoreDirectory = true;
                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    SealImgMat.Save(saveFileDialog.FileName);
                }
            }
        }
        /// <summary>
        /// 保存SheetImg至选择目录
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SaveSheetPicToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //检测选择是否为空
            GlassInfo glassInfo = comboBox_GlassIDList.SelectedItem as GlassInfo;
            if (glassInfo.Id == ProgramData.SelectTips)
            {
                MessageBox.Show("Not Select Glass!");
                return;
            }
            //保存Sheet图片
            if (!SealImgMat.IsEmpty)
            {
                SaveFileDialog saveFileDialog = new SaveFileDialog();
                saveFileDialog.Filter = "Picture |*.jpg;*.png;*.gif;*.jpeg;*.bmp";
                saveFileDialog.FilterIndex = 2;
                saveFileDialog.RestoreDirectory = true;
                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    SheetImgMat.Save(saveFileDialog.FileName);
                }
            }
        }
        /// <summary>
        /// 配置页面
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ConfigToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ConfigForm configForm = new ConfigForm();
            configForm.StartPosition = FormStartPosition.CenterScreen;
            configForm.ShowDialog();
        }
        /// <summary>
        /// 刷新GlassInfo
        /// </summary>
        /// <param name="glassInfo"></param>
        private void RefreshGlassInfo(GlassInfo glassInfo)
        {
            textBox_CreateTime.Text = glassInfo.CreateTime;
            textBox_EQ00.Text = glassInfo.Equip00_ID;
            textBox_EQ01.Text = glassInfo.Equip01_ID;
            textBox_Point1X.Text = glassInfo.Point1.X.ToString();
            textBox_Point1Y.Text = glassInfo.Point1.Y.ToString();
            textBox_Point2X.Text = glassInfo.Point2.X.ToString();
            textBox_Point2Y.Text = glassInfo.Point2.Y.ToString();
            textBox_Point3X.Text = glassInfo.Point3.X.ToString();
            textBox_Point3Y.Text = glassInfo.Point3.Y.ToString();
            textBox_Point4X.Text = glassInfo.Point4.X.ToString();
            textBox_Point4Y.Text = glassInfo.Point4.Y.ToString();
        }

        
        
        /// <summary>
        /// 保存玻璃方向参数
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ComboBox_GlassDirection_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (IniFlag) return;
            BindComboxEnumType<Direction> aer = comboBox_GlassDirection.SelectedItem as BindComboxEnumType<Direction>;
            if (aer == null || string.IsNullOrEmpty(aer.Name)) return;
            Direction direction = (Direction)Enum.Parse(typeof(Direction), aer.Name);
            ProgramData.SysPara.GlassDirection = direction;
            ProgramData.SaveSysPara();
        }
        /// <summary>
        /// 生成图片
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void UserButton_Generate_Click(object sender, EventArgs e)
        {
            RefreshGlassInfo(comboBox_GlassIDList.SelectedItem as GlassInfo);
            //生成图片
            if ((comboBox_GlassIDList.SelectedItem as GlassInfo).Id == ProgramData.SelectTips) return;
            //生成Seal图片
            CommonMethod.CreateImg(ref SealImgMat, ProgramData.SysPara.SealSize, ProgramData.SysPara.TemplateData, ProgramData.SysPara.SourcePath + "\\" + dateTimePicker_SearchTime.Value.ToString(ProgramData.DateFormat) + "\\" + (comboBox_GlassIDList.SelectedItem as GlassInfo).DirName, ProgramData.SealStr, ProgramData.SysPara.GlassDirection);
            picShow_SealImg.LoadPic(SealImgMat.Bitmap);
            //生成Sheet图片
            CommonMethod.CreateImg(ref SheetImgMat, ProgramData.SysPara.SheetSize, ProgramData.SheetTemplate, ProgramData.SysPara.SourcePath + "\\" + dateTimePicker_SearchTime.Value.ToString(ProgramData.DateFormat) + "\\" + (comboBox_GlassIDList.SelectedItem as GlassInfo).DirName, ProgramData.SheetStr, ProgramData.SysPara.GlassDirection);
            picShow_SheetImg.LoadPic(SheetImgMat.Bitmap);
        }
        /// <summary>
        /// GlassIDlist SelectIndex changed 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ComboBox_GlassIDList_SelectedIndexChanged(object sender, EventArgs e)
        {
            RefreshGlassInfo(comboBox_GlassIDList.SelectedItem as GlassInfo);
            //生成图片
            if ((comboBox_GlassIDList.SelectedItem as GlassInfo).Id == ProgramData.SelectTips) return;
            //生成Seal图片
            CommonMethod.CreateImg(ref SealImgMat, ProgramData.SysPara.SealSize, ProgramData.SysPara.TemplateData, ProgramData.SysPara.SourcePath + "\\" + dateTimePicker_SearchTime.Value.ToString(ProgramData.DateFormat) + "\\" + (comboBox_GlassIDList.SelectedItem as GlassInfo).DirName, ProgramData.SealStr, ProgramData.SysPara.GlassDirection);
            picShow_SealImg.LoadPic(SealImgMat.Bitmap);
            //生成Sheet图片
            CommonMethod.CreateImg(ref SheetImgMat, ProgramData.SysPara.SheetSize, ProgramData.SheetTemplate, ProgramData.SysPara.SourcePath + "\\" + dateTimePicker_SearchTime.Value.ToString(ProgramData.DateFormat) + "\\" + (comboBox_GlassIDList.SelectedItem as GlassInfo).DirName, ProgramData.SheetStr, ProgramData.SysPara.GlassDirection);
            picShow_SheetImg.LoadPic(SheetImgMat.Bitmap);
        }

        /// <summary>
        /// 日期发生改变
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DateTimePicker_SearchTime_ValueChanged(object sender, EventArgs e)
        {
            if (IniFlag) return;
            if (bgWorker.IsBusy) return;
            bgWorker.RunWorkerAsync("Refresh GlassIDList");

            //计时
            //Stopwatch stopwatch = new Stopwatch();
            //stopwatch.Reset();
            //stopwatch.Start();
            //stopwatch.Stop();
            //TimeSpan ts = stopwatch.Elapsed;
            //MessageBox.Show(stopwatch.ElapsedMilliseconds.ToString());
        }
        /// <summary>
        /// About
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void aboutToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            AboutBox aboutBox = new AboutBox();
            aboutBox.StartPosition = FormStartPosition.CenterScreen;
            aboutBox.ShowDialog();
        }
        /// <summary>
        /// 刷新按钮
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void userButton_Refresh_Click(object sender, EventArgs e)
        {
            if (IniFlag) return;
            if (bgWorker.IsBusy) return;
            bgWorker.RunWorkerAsync("Refresh GlassIDList");
        }
    }
}
