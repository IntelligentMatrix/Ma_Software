using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Pic_Integrate
{
    public delegate bool AddTemplate(string name,int cols,int rows);
    public partial class NewTemplateFile : Form
    {
        public event AddTemplate GetResult;
        public NewTemplateFile()
        {
            InitializeComponent();
        }
        /// <summary>
        /// 确认按钮
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void userButton_Confirm_Click(object sender, EventArgs e)
        {

            if (!(bool)GetResult?.Invoke(textBox_Name.Text, (int)numericUpDown_Cols.Value, (int)numericUpDown_Rows.Value))
            {
                MessageBox.Show("Template file already exist!Please recheck");
                return;
            }
            this.Close();
        }
        /// <summary>
        /// 取消按钮
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void userButton_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
