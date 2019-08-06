using MyLibrary.BasicFramework;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CalculateRegisterCode
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 生成按钮
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void userButton_Generate_Click(object sender, EventArgs e)
        {
            //校验Request Code是否为空
            //if(string.IsNullOrEmpty(textBox_RequetsCode.Text))
            //{
            //    MessageBox.Show("Please input the Request Code!");
            //    return;
            //}
            ////校验Request Code是否为空
            //if (string.IsNullOrEmpty(textBox_EncryptionCode.Text))
            //{
            //    MessageBox.Show("Please input the Request Code!");
            //}
            ////生成注册码
            //textBox_RegisterCode.Text = SoftSecurity.MD5Encrypt(textBox_RequetsCode.Text, textBox_EncryptionCode.Text);

            SoftSecurity.CreatKey(@"./Key");
        }
        /// <summary>
        /// 退出按钮
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void userButton_Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        /// <summary>
        /// form初始化加载
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MainForm_Load(object sender, EventArgs e)
        {

        }
    }
}
