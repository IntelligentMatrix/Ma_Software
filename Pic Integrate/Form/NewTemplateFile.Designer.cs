namespace Pic_Integrate
{
    partial class NewTemplateFile
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Label1 = new System.Windows.Forms.Label();
            this.textBox_Name = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.numericUpDown_Cols = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown_Rows = new System.Windows.Forms.NumericUpDown();
            this.userButton_Confirm = new MyLibrary.MyControl.UserButton();
            this.userButton_Cancel = new MyLibrary.MyControl.UserButton();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_Cols)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_Rows)).BeginInit();
            this.SuspendLayout();
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Location = new System.Drawing.Point(42, 45);
            this.Label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(80, 18);
            this.Label1.TabIndex = 0;
            this.Label1.Text = "FileName";
            // 
            // textBox_Name
            // 
            this.textBox_Name.Location = new System.Drawing.Point(150, 39);
            this.textBox_Name.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox_Name.Name = "textBox_Name";
            this.textBox_Name.Size = new System.Drawing.Size(214, 28);
            this.textBox_Name.TabIndex = 1;
            this.textBox_Name.Text = "New Template";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(46, 117);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 18);
            this.label2.TabIndex = 2;
            this.label2.Text = "Columns";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(60, 189);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 18);
            this.label3.TabIndex = 3;
            this.label3.Text = "Rows";
            // 
            // numericUpDown_Cols
            // 
            this.numericUpDown_Cols.Location = new System.Drawing.Point(150, 111);
            this.numericUpDown_Cols.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.numericUpDown_Cols.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown_Cols.Name = "numericUpDown_Cols";
            this.numericUpDown_Cols.Size = new System.Drawing.Size(216, 28);
            this.numericUpDown_Cols.TabIndex = 4;
            this.numericUpDown_Cols.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numericUpDown_Cols.Value = new decimal(new int[] {
            9,
            0,
            0,
            0});
            // 
            // numericUpDown_Rows
            // 
            this.numericUpDown_Rows.Location = new System.Drawing.Point(150, 183);
            this.numericUpDown_Rows.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.numericUpDown_Rows.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown_Rows.Name = "numericUpDown_Rows";
            this.numericUpDown_Rows.Size = new System.Drawing.Size(216, 28);
            this.numericUpDown_Rows.TabIndex = 5;
            this.numericUpDown_Rows.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numericUpDown_Rows.Value = new decimal(new int[] {
            9,
            0,
            0,
            0});
            // 
            // userButton_Confirm
            // 
            this.userButton_Confirm.BackColor = System.Drawing.Color.Transparent;
            this.userButton_Confirm.CustomerInformation = "";
            this.userButton_Confirm.EnableColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(190)))), ((int)(((byte)(190)))));
            this.userButton_Confirm.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.userButton_Confirm.Location = new System.Drawing.Point(430, 108);
            this.userButton_Confirm.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.userButton_Confirm.Name = "userButton_Confirm";
            this.userButton_Confirm.Size = new System.Drawing.Size(117, 38);
            this.userButton_Confirm.TabIndex = 6;
            this.userButton_Confirm.UIText = "Confirm";
            this.userButton_Confirm.Click += new System.EventHandler(this.userButton_Confirm_Click);
            // 
            // userButton_Cancel
            // 
            this.userButton_Cancel.BackColor = System.Drawing.Color.Transparent;
            this.userButton_Cancel.CustomerInformation = "";
            this.userButton_Cancel.EnableColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(190)))), ((int)(((byte)(190)))));
            this.userButton_Cancel.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.userButton_Cancel.Location = new System.Drawing.Point(430, 180);
            this.userButton_Cancel.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.userButton_Cancel.Name = "userButton_Cancel";
            this.userButton_Cancel.Size = new System.Drawing.Size(117, 38);
            this.userButton_Cancel.TabIndex = 7;
            this.userButton_Cancel.UIText = "Cancel";
            this.userButton_Cancel.Click += new System.EventHandler(this.userButton_Cancel_Click);
            // 
            // NewTemplateFile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(566, 248);
            this.Controls.Add(this.userButton_Cancel);
            this.Controls.Add(this.userButton_Confirm);
            this.Controls.Add(this.numericUpDown_Rows);
            this.Controls.Add(this.numericUpDown_Cols);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox_Name);
            this.Controls.Add(this.Label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "NewTemplateFile";
            this.Text = "NewTemplateFile";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_Cols)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_Rows)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Label1;
        private System.Windows.Forms.TextBox textBox_Name;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown numericUpDown_Cols;
        private System.Windows.Forms.NumericUpDown numericUpDown_Rows;
        private MyLibrary.MyControl.UserButton userButton_Confirm;
        private MyLibrary.MyControl.UserButton userButton_Cancel;
    }
}