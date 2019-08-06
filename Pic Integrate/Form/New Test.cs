using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Pic_Integrate
{
    public partial class New_Test : Form
    {
        public New_Test()
        {
            InitializeComponent();
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            string path = @"D:\Extend\T2\Result\20190804";
            string sourceDir  = @"D:\Extend\T2\Result\20190804\IMG_0730000637_TB30000000";
            string sourceCsv = @"D:\Extend\T2\Result\20190804\IMG_0730000637_TB30000000.csv";
            string fileStart = "IMG_0730000637_TB3000";
            DirectoryInfo directoryInfo = new DirectoryInfo(sourceDir);
            for (int i = 1;i<= 3000;i++)
            {
                string dstdir = path + "\\" + fileStart + i.ToString().PadLeft(4, '0');
                if(!Directory.Exists(dstdir)) Directory.CreateDirectory(dstdir);
                //复制csv
                string dstCsv = path + fileStart + i.ToString().PadLeft(4, '0') + ".csv";
                File.Copy(sourceCsv, dstCsv, true);
                //复制文件夹
                foreach (var o in directoryInfo.GetFiles())
                {
                    File.Copy(o.FullName, dstdir + "\\" + o.Name, true);
                }
            }
        }
    }
}
