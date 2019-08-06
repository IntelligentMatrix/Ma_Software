namespace Pic_Integrate
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.FileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SaveSealPicToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SaveSheetPicToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ConfigToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.HelpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.Status_Label = new System.Windows.Forms.Label();
            this.comboBox_GlassDirection = new System.Windows.Forms.ComboBox();
            this.dateTimePicker_SearchTime = new System.Windows.Forms.DateTimePicker();
            this.comboBox_GlassIDList = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox_CreateTime = new System.Windows.Forms.TextBox();
            this.textBox_Point4Y = new System.Windows.Forms.TextBox();
            this.textBox_Point4X = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.textBox_EQ01 = new System.Windows.Forms.TextBox();
            this.textBox_EQ00 = new System.Windows.Forms.TextBox();
            this.textBox_Point3Y = new System.Windows.Forms.TextBox();
            this.textBox_Point3X = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.textBox_Point2Y = new System.Windows.Forms.TextBox();
            this.textBox_Point2X = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.textBox_Point1Y = new System.Windows.Forms.TextBox();
            this.textBox_Point1X = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.picShow_SealImg = new MyLibrary.MyControl.PicShow();
            this.userButton_Generate = new MyLibrary.MyControl.UserButton();
            this.picShow_SheetImg = new MyLibrary.MyControl.PicShow();
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.FileToolStripMenuItem,
            this.ConfigToolStripMenuItem,
            this.HelpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(896, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // FileToolStripMenuItem
            // 
            this.FileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveToolStripMenuItem,
            this.SaveSealPicToolStripMenuItem,
            this.SaveSheetPicToolStripMenuItem});
            this.FileToolStripMenuItem.Name = "FileToolStripMenuItem";
            this.FileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.FileToolStripMenuItem.Text = "File";
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(149, 22);
            this.saveToolStripMenuItem.Text = "Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // SaveSealPicToolStripMenuItem
            // 
            this.SaveSealPicToolStripMenuItem.Name = "SaveSealPicToolStripMenuItem";
            this.SaveSealPicToolStripMenuItem.Size = new System.Drawing.Size(149, 22);
            this.SaveSealPicToolStripMenuItem.Text = "Save Seal Pic";
            this.SaveSealPicToolStripMenuItem.Click += new System.EventHandler(this.SaveSealPicToolStripMenuItem_Click);
            // 
            // SaveSheetPicToolStripMenuItem
            // 
            this.SaveSheetPicToolStripMenuItem.Name = "SaveSheetPicToolStripMenuItem";
            this.SaveSheetPicToolStripMenuItem.Size = new System.Drawing.Size(149, 22);
            this.SaveSheetPicToolStripMenuItem.Text = "Save Sheet Pic";
            this.SaveSheetPicToolStripMenuItem.Click += new System.EventHandler(this.SaveSheetPicToolStripMenuItem_Click);
            // 
            // ConfigToolStripMenuItem
            // 
            this.ConfigToolStripMenuItem.Name = "ConfigToolStripMenuItem";
            this.ConfigToolStripMenuItem.Size = new System.Drawing.Size(55, 20);
            this.ConfigToolStripMenuItem.Text = "Config";
            this.ConfigToolStripMenuItem.Click += new System.EventHandler(this.ConfigToolStripMenuItem_Click);
            // 
            // HelpToolStripMenuItem
            // 
            this.HelpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.HelpToolStripMenuItem.Name = "HelpToolStripMenuItem";
            this.HelpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.HelpToolStripMenuItem.Text = "Help";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.picShow_SealImg);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 24);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(563, 451);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "SealImg";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.groupBox3);
            this.groupBox2.Controls.Add(this.groupBox4);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Right;
            this.groupBox2.Location = new System.Drawing.Point(563, 24);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(333, 451);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Control Panel";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.Status_Label);
            this.groupBox3.Controls.Add(this.comboBox_GlassDirection);
            this.groupBox3.Controls.Add(this.userButton_Generate);
            this.groupBox3.Controls.Add(this.dateTimePicker_SearchTime);
            this.groupBox3.Controls.Add(this.comboBox_GlassIDList);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.textBox_CreateTime);
            this.groupBox3.Controls.Add(this.textBox_Point4Y);
            this.groupBox3.Controls.Add(this.textBox_Point4X);
            this.groupBox3.Controls.Add(this.label12);
            this.groupBox3.Controls.Add(this.textBox_EQ01);
            this.groupBox3.Controls.Add(this.textBox_EQ00);
            this.groupBox3.Controls.Add(this.textBox_Point3Y);
            this.groupBox3.Controls.Add(this.textBox_Point3X);
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Controls.Add(this.textBox_Point2Y);
            this.groupBox3.Controls.Add(this.textBox_Point2X);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.textBox_Point1Y);
            this.groupBox3.Controls.Add(this.textBox_Point1X);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox3.Location = new System.Drawing.Point(3, 17);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox3.Size = new System.Drawing.Size(327, 233);
            this.groupBox3.TabIndex = 30;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Operate";
            // 
            // Status_Label
            // 
            this.Status_Label.AutoSize = true;
            this.Status_Label.Location = new System.Drawing.Point(279, 39);
            this.Status_Label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Status_Label.Name = "Status_Label";
            this.Status_Label.Size = new System.Drawing.Size(41, 12);
            this.Status_Label.TabIndex = 30;
            this.Status_Label.Text = "Status";
            // 
            // comboBox_GlassDirection
            // 
            this.comboBox_GlassDirection.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_GlassDirection.FormattingEnabled = true;
            this.comboBox_GlassDirection.Location = new System.Drawing.Point(80, 206);
            this.comboBox_GlassDirection.Margin = new System.Windows.Forms.Padding(2);
            this.comboBox_GlassDirection.Name = "comboBox_GlassDirection";
            this.comboBox_GlassDirection.Size = new System.Drawing.Size(90, 20);
            this.comboBox_GlassDirection.TabIndex = 6;
            this.comboBox_GlassDirection.SelectedIndexChanged += new System.EventHandler(this.ComboBox_GlassDirection_SelectedIndexChanged);
            // 
            // dateTimePicker_SearchTime
            // 
            this.dateTimePicker_SearchTime.CustomFormat = "yyyyMMdd";
            this.dateTimePicker_SearchTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker_SearchTime.Location = new System.Drawing.Point(80, 13);
            this.dateTimePicker_SearchTime.Margin = new System.Windows.Forms.Padding(2);
            this.dateTimePicker_SearchTime.Name = "dateTimePicker_SearchTime";
            this.dateTimePicker_SearchTime.Size = new System.Drawing.Size(196, 21);
            this.dateTimePicker_SearchTime.TabIndex = 29;
            this.dateTimePicker_SearchTime.ValueChanged += new System.EventHandler(this.DateTimePicker_SearchTime_ValueChanged);
            // 
            // comboBox_GlassIDList
            // 
            this.comboBox_GlassIDList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_GlassIDList.FormattingEnabled = true;
            this.comboBox_GlassIDList.Location = new System.Drawing.Point(80, 35);
            this.comboBox_GlassIDList.Margin = new System.Windows.Forms.Padding(2);
            this.comboBox_GlassIDList.Name = "comboBox_GlassIDList";
            this.comboBox_GlassIDList.Size = new System.Drawing.Size(196, 20);
            this.comboBox_GlassIDList.TabIndex = 28;
            this.comboBox_GlassIDList.SelectedIndexChanged += new System.EventHandler(this.ComboBox_GlassIDList_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 207);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 12);
            this.label3.TabIndex = 4;
            this.label3.Text = "Direction";
            // 
            // textBox_CreateTime
            // 
            this.textBox_CreateTime.Location = new System.Drawing.Point(80, 55);
            this.textBox_CreateTime.Margin = new System.Windows.Forms.Padding(2);
            this.textBox_CreateTime.Name = "textBox_CreateTime";
            this.textBox_CreateTime.ReadOnly = true;
            this.textBox_CreateTime.Size = new System.Drawing.Size(196, 21);
            this.textBox_CreateTime.TabIndex = 27;
            // 
            // textBox_Point4Y
            // 
            this.textBox_Point4Y.Location = new System.Drawing.Point(186, 183);
            this.textBox_Point4Y.Margin = new System.Windows.Forms.Padding(2);
            this.textBox_Point4Y.Name = "textBox_Point4Y";
            this.textBox_Point4Y.ReadOnly = true;
            this.textBox_Point4Y.Size = new System.Drawing.Size(90, 21);
            this.textBox_Point4Y.TabIndex = 26;
            // 
            // textBox_Point4X
            // 
            this.textBox_Point4X.Location = new System.Drawing.Point(80, 183);
            this.textBox_Point4X.Margin = new System.Windows.Forms.Padding(2);
            this.textBox_Point4X.Name = "textBox_Point4X";
            this.textBox_Point4X.ReadOnly = true;
            this.textBox_Point4X.Size = new System.Drawing.Size(90, 21);
            this.textBox_Point4X.TabIndex = 25;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(6, 185);
            this.label12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(41, 12);
            this.label12.TabIndex = 24;
            this.label12.Text = "Point4";
            // 
            // textBox_EQ01
            // 
            this.textBox_EQ01.Location = new System.Drawing.Point(186, 77);
            this.textBox_EQ01.Margin = new System.Windows.Forms.Padding(2);
            this.textBox_EQ01.Name = "textBox_EQ01";
            this.textBox_EQ01.ReadOnly = true;
            this.textBox_EQ01.Size = new System.Drawing.Size(90, 21);
            this.textBox_EQ01.TabIndex = 23;
            // 
            // textBox_EQ00
            // 
            this.textBox_EQ00.Location = new System.Drawing.Point(80, 77);
            this.textBox_EQ00.Margin = new System.Windows.Forms.Padding(2);
            this.textBox_EQ00.Name = "textBox_EQ00";
            this.textBox_EQ00.ReadOnly = true;
            this.textBox_EQ00.Size = new System.Drawing.Size(90, 21);
            this.textBox_EQ00.TabIndex = 22;
            // 
            // textBox_Point3Y
            // 
            this.textBox_Point3Y.Location = new System.Drawing.Point(186, 161);
            this.textBox_Point3Y.Margin = new System.Windows.Forms.Padding(2);
            this.textBox_Point3Y.Name = "textBox_Point3Y";
            this.textBox_Point3Y.ReadOnly = true;
            this.textBox_Point3Y.Size = new System.Drawing.Size(90, 21);
            this.textBox_Point3Y.TabIndex = 21;
            // 
            // textBox_Point3X
            // 
            this.textBox_Point3X.Location = new System.Drawing.Point(80, 161);
            this.textBox_Point3X.Margin = new System.Windows.Forms.Padding(2);
            this.textBox_Point3X.Name = "textBox_Point3X";
            this.textBox_Point3X.ReadOnly = true;
            this.textBox_Point3X.Size = new System.Drawing.Size(90, 21);
            this.textBox_Point3X.TabIndex = 20;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(6, 163);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(41, 12);
            this.label11.TabIndex = 19;
            this.label11.Text = "Point3";
            // 
            // textBox_Point2Y
            // 
            this.textBox_Point2Y.Location = new System.Drawing.Point(186, 138);
            this.textBox_Point2Y.Margin = new System.Windows.Forms.Padding(2);
            this.textBox_Point2Y.Name = "textBox_Point2Y";
            this.textBox_Point2Y.ReadOnly = true;
            this.textBox_Point2Y.Size = new System.Drawing.Size(90, 21);
            this.textBox_Point2Y.TabIndex = 18;
            // 
            // textBox_Point2X
            // 
            this.textBox_Point2X.Location = new System.Drawing.Point(80, 138);
            this.textBox_Point2X.Margin = new System.Windows.Forms.Padding(2);
            this.textBox_Point2X.Name = "textBox_Point2X";
            this.textBox_Point2X.ReadOnly = true;
            this.textBox_Point2X.Size = new System.Drawing.Size(90, 21);
            this.textBox_Point2X.TabIndex = 17;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 141);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(41, 12);
            this.label8.TabIndex = 16;
            this.label8.Text = "Point2";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(225, 100);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(11, 12);
            this.label10.TabIndex = 15;
            this.label10.Text = "Y";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(119, 100);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(11, 12);
            this.label9.TabIndex = 14;
            this.label9.Text = "X";
            // 
            // textBox_Point1Y
            // 
            this.textBox_Point1Y.Location = new System.Drawing.Point(186, 115);
            this.textBox_Point1Y.Margin = new System.Windows.Forms.Padding(2);
            this.textBox_Point1Y.Name = "textBox_Point1Y";
            this.textBox_Point1Y.ReadOnly = true;
            this.textBox_Point1Y.Size = new System.Drawing.Size(90, 21);
            this.textBox_Point1Y.TabIndex = 13;
            // 
            // textBox_Point1X
            // 
            this.textBox_Point1X.Location = new System.Drawing.Point(80, 115);
            this.textBox_Point1X.Margin = new System.Windows.Forms.Padding(2);
            this.textBox_Point1X.Name = "textBox_Point1X";
            this.textBox_Point1X.ReadOnly = true;
            this.textBox_Point1X.Size = new System.Drawing.Size(90, 21);
            this.textBox_Point1X.TabIndex = 12;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 119);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(41, 12);
            this.label7.TabIndex = 10;
            this.label7.Text = "Point1";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 80);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 12);
            this.label5.TabIndex = 8;
            this.label5.Text = "EQ_ID";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 59);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 12);
            this.label4.TabIndex = 7;
            this.label4.Text = "CreateTime";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 37);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 12);
            this.label2.TabIndex = 3;
            this.label2.Text = "GlassIDList";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 16);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 12);
            this.label1.TabIndex = 2;
            this.label1.Text = "Date";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.picShow_SheetImg);
            this.groupBox4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox4.Location = new System.Drawing.Point(3, 252);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox4.Size = new System.Drawing.Size(327, 196);
            this.groupBox4.TabIndex = 31;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "SheetImg";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem1_Click);
            // 
            // picShow_SealImg
            // 
            this.picShow_SealImg.Dock = System.Windows.Forms.DockStyle.Fill;
            this.picShow_SealImg.Location = new System.Drawing.Point(3, 17);
            this.picShow_SealImg.Margin = new System.Windows.Forms.Padding(4);
            this.picShow_SealImg.Name = "picShow_SealImg";
            this.picShow_SealImg.Size = new System.Drawing.Size(557, 431);
            this.picShow_SealImg.TabIndex = 0;
            // 
            // userButton_Generate
            // 
            this.userButton_Generate.BackColor = System.Drawing.Color.Transparent;
            this.userButton_Generate.CustomerInformation = "";
            this.userButton_Generate.EnableColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(190)))), ((int)(((byte)(190)))));
            this.userButton_Generate.Font = new System.Drawing.Font("Microsoft YaHei", 9F);
            this.userButton_Generate.Location = new System.Drawing.Point(186, 207);
            this.userButton_Generate.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.userButton_Generate.Name = "userButton_Generate";
            this.userButton_Generate.Size = new System.Drawing.Size(89, 17);
            this.userButton_Generate.TabIndex = 1;
            this.userButton_Generate.UIText = "Generate";
            this.userButton_Generate.Click += new System.EventHandler(this.UserButton_Generate_Click);
            // 
            // picShow_SheetImg
            // 
            this.picShow_SheetImg.Dock = System.Windows.Forms.DockStyle.Fill;
            this.picShow_SheetImg.Location = new System.Drawing.Point(2, 16);
            this.picShow_SheetImg.Name = "picShow_SheetImg";
            this.picShow_SheetImg.Size = new System.Drawing.Size(323, 178);
            this.picShow_SheetImg.TabIndex = 5;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(896, 475);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MyLibrary.MyControl.PicShow picShow_SealImg;
        private MyLibrary.MyControl.UserButton userButton_Generate;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem FileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ConfigToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem HelpToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ToolStripMenuItem SaveSealPicToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem SaveSheetPicToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private MyLibrary.MyControl.PicShow picShow_SheetImg;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox_GlassDirection;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DateTimePicker dateTimePicker_SearchTime;
        private System.Windows.Forms.ComboBox comboBox_GlassIDList;
        private System.Windows.Forms.TextBox textBox_CreateTime;
        private System.Windows.Forms.TextBox textBox_Point4Y;
        private System.Windows.Forms.TextBox textBox_Point4X;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox textBox_EQ01;
        private System.Windows.Forms.TextBox textBox_EQ00;
        private System.Windows.Forms.TextBox textBox_Point3Y;
        private System.Windows.Forms.TextBox textBox_Point3X;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox textBox_Point2Y;
        private System.Windows.Forms.TextBox textBox_Point2X;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBox_Point1Y;
        private System.Windows.Forms.TextBox textBox_Point1X;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label Status_Label;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
    }
}