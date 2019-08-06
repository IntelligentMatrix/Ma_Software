namespace CalculateRegisterCode
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.userButton_Generate = new MyLibrary.MyControl.UserButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox_RequetsCode = new System.Windows.Forms.TextBox();
            this.textBox_EncryptionCode = new System.Windows.Forms.TextBox();
            this.textBox_RegisterCode = new System.Windows.Forms.TextBox();
            this.userButton_Exit = new MyLibrary.MyControl.UserButton();
            this.SuspendLayout();
            // 
            // userButton_Generate
            // 
            this.userButton_Generate.BackColor = System.Drawing.Color.Transparent;
            this.userButton_Generate.CustomerInformation = "";
            this.userButton_Generate.EnableColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(190)))), ((int)(((byte)(190)))));
            this.userButton_Generate.Font = new System.Drawing.Font("Microsoft YaHei", 9F);
            this.userButton_Generate.Location = new System.Drawing.Point(135, 147);
            this.userButton_Generate.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.userButton_Generate.Name = "userButton_Generate";
            this.userButton_Generate.Size = new System.Drawing.Size(78, 25);
            this.userButton_Generate.TabIndex = 0;
            this.userButton_Generate.UIText = "Generate";
            this.userButton_Generate.Click += new System.EventHandler(this.userButton_Generate_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 19);
            this.label1.TabIndex = 1;
            this.label1.Text = "Request Code";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 103);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 19);
            this.label2.TabIndex = 2;
            this.label2.Text = "Register Code";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 65);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(112, 19);
            this.label3.TabIndex = 3;
            this.label3.Text = "Encryption Code";
            // 
            // textBox_RequetsCode
            // 
            this.textBox_RequetsCode.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBox_RequetsCode.Location = new System.Drawing.Point(135, 23);
            this.textBox_RequetsCode.Name = "textBox_RequetsCode";
            this.textBox_RequetsCode.Size = new System.Drawing.Size(209, 26);
            this.textBox_RequetsCode.TabIndex = 4;
            // 
            // textBox_EncryptionCode
            // 
            this.textBox_EncryptionCode.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBox_EncryptionCode.Location = new System.Drawing.Point(135, 61);
            this.textBox_EncryptionCode.Name = "textBox_EncryptionCode";
            this.textBox_EncryptionCode.Size = new System.Drawing.Size(209, 26);
            this.textBox_EncryptionCode.TabIndex = 5;
            // 
            // textBox_RegisterCode
            // 
            this.textBox_RegisterCode.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBox_RegisterCode.Location = new System.Drawing.Point(135, 99);
            this.textBox_RegisterCode.Name = "textBox_RegisterCode";
            this.textBox_RegisterCode.Size = new System.Drawing.Size(209, 26);
            this.textBox_RegisterCode.TabIndex = 6;
            // 
            // userButton_Exit
            // 
            this.userButton_Exit.BackColor = System.Drawing.Color.Transparent;
            this.userButton_Exit.CustomerInformation = "";
            this.userButton_Exit.EnableColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(190)))), ((int)(((byte)(190)))));
            this.userButton_Exit.Font = new System.Drawing.Font("Microsoft YaHei", 9F);
            this.userButton_Exit.Location = new System.Drawing.Point(266, 147);
            this.userButton_Exit.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.userButton_Exit.Name = "userButton_Exit";
            this.userButton_Exit.Size = new System.Drawing.Size(78, 25);
            this.userButton_Exit.TabIndex = 7;
            this.userButton_Exit.UIText = "Exit";
            this.userButton_Exit.Click += new System.EventHandler(this.userButton_Exit_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(376, 185);
            this.Controls.Add(this.userButton_Exit);
            this.Controls.Add(this.textBox_RegisterCode);
            this.Controls.Add(this.textBox_EncryptionCode);
            this.Controls.Add(this.textBox_RequetsCode);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.userButton_Generate);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainForm";
            this.Text = "Main";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MyLibrary.MyControl.UserButton userButton_Generate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox_RequetsCode;
        private System.Windows.Forms.TextBox textBox_EncryptionCode;
        private System.Windows.Forms.TextBox textBox_RegisterCode;
        private MyLibrary.MyControl.UserButton userButton_Exit;
    }
}

