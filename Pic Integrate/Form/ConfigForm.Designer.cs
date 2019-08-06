namespace Pic_Integrate
{
    partial class ConfigForm
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
            this.tabControl_Template = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.groupBox_Fill = new System.Windows.Forms.GroupBox();
            this.dataGridView_Template = new System.Windows.Forms.DataGridView();
            this.groupBox_Top = new System.Windows.Forms.GroupBox();
            this.userButton_Refresh = new MyLibrary.MyControl.UserButton();
            this.userButton_Delete = new MyLibrary.MyControl.UserButton();
            this.userButton_Create = new MyLibrary.MyControl.UserButton();
            this.numericUpDown_Cols = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.numericUpDown_Row = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox_ConfigFileList = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.checkBox_IsSaveSearchHistory = new System.Windows.Forms.CheckBox();
            this.userButton_ImgSavePath = new MyLibrary.MyControl.UserButton();
            this.textBox_ImgSavePath = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.userButton_Set = new MyLibrary.MyControl.UserButton();
            this.textBox_SourcePath = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.numericUpDown_SheetHeight = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown_SheetWidth = new System.Windows.Forms.NumericUpDown();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.numericUpDown_SealHeight = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown_SealWidth = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.comboBox_CurrentTemplateFile = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tabControl_Template.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox_Fill.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Template)).BeginInit();
            this.groupBox_Top.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_Cols)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_Row)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_SheetHeight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_SheetWidth)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_SealHeight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_SealWidth)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl_Template
            // 
            this.tabControl_Template.Controls.Add(this.tabPage1);
            this.tabControl_Template.Controls.Add(this.tabPage2);
            this.tabControl_Template.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl_Template.Location = new System.Drawing.Point(0, 0);
            this.tabControl_Template.Name = "tabControl_Template";
            this.tabControl_Template.SelectedIndex = 0;
            this.tabControl_Template.Size = new System.Drawing.Size(517, 499);
            this.tabControl_Template.TabIndex = 0;
            this.tabControl_Template.SelectedIndexChanged += new System.EventHandler(this.tabControl_Template_SelectedIndexChanged);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.groupBox_Fill);
            this.tabPage1.Controls.Add(this.groupBox_Top);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(509, 473);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Template";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // groupBox_Fill
            // 
            this.groupBox_Fill.Controls.Add(this.dataGridView_Template);
            this.groupBox_Fill.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox_Fill.Location = new System.Drawing.Point(3, 82);
            this.groupBox_Fill.Name = "groupBox_Fill";
            this.groupBox_Fill.Size = new System.Drawing.Size(503, 388);
            this.groupBox_Fill.TabIndex = 1;
            this.groupBox_Fill.TabStop = false;
            // 
            // dataGridView_Template
            // 
            this.dataGridView_Template.AllowUserToAddRows = false;
            this.dataGridView_Template.AllowUserToDeleteRows = false;
            this.dataGridView_Template.AllowUserToResizeColumns = false;
            this.dataGridView_Template.AllowUserToResizeRows = false;
            this.dataGridView_Template.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dataGridView_Template.ColumnHeadersHeight = 40;
            this.dataGridView_Template.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridView_Template.ColumnHeadersVisible = false;
            this.dataGridView_Template.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView_Template.Location = new System.Drawing.Point(3, 17);
            this.dataGridView_Template.MultiSelect = false;
            this.dataGridView_Template.Name = "dataGridView_Template";
            this.dataGridView_Template.RowHeadersVisible = false;
            this.dataGridView_Template.RowHeadersWidth = 62;
            this.dataGridView_Template.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataGridView_Template.RowTemplate.DefaultCellStyle.NullValue = null;
            this.dataGridView_Template.RowTemplate.Height = 40;
            this.dataGridView_Template.ShowEditingIcon = false;
            this.dataGridView_Template.Size = new System.Drawing.Size(497, 368);
            this.dataGridView_Template.TabIndex = 0;
            this.dataGridView_Template.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_Template_CellValueChanged);
            // 
            // groupBox_Top
            // 
            this.groupBox_Top.Controls.Add(this.userButton_Refresh);
            this.groupBox_Top.Controls.Add(this.userButton_Delete);
            this.groupBox_Top.Controls.Add(this.userButton_Create);
            this.groupBox_Top.Controls.Add(this.numericUpDown_Cols);
            this.groupBox_Top.Controls.Add(this.label3);
            this.groupBox_Top.Controls.Add(this.numericUpDown_Row);
            this.groupBox_Top.Controls.Add(this.label2);
            this.groupBox_Top.Controls.Add(this.comboBox_ConfigFileList);
            this.groupBox_Top.Controls.Add(this.label1);
            this.groupBox_Top.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox_Top.Location = new System.Drawing.Point(3, 3);
            this.groupBox_Top.Name = "groupBox_Top";
            this.groupBox_Top.Size = new System.Drawing.Size(503, 79);
            this.groupBox_Top.TabIndex = 0;
            this.groupBox_Top.TabStop = false;
            // 
            // userButton_Refresh
            // 
            this.userButton_Refresh.BackColor = System.Drawing.Color.Transparent;
            this.userButton_Refresh.CustomerInformation = "";
            this.userButton_Refresh.EnableColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(190)))), ((int)(((byte)(190)))));
            this.userButton_Refresh.Font = new System.Drawing.Font("Microsoft YaHei", 9F);
            this.userButton_Refresh.Location = new System.Drawing.Point(167, 45);
            this.userButton_Refresh.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.userButton_Refresh.Name = "userButton_Refresh";
            this.userButton_Refresh.Size = new System.Drawing.Size(78, 25);
            this.userButton_Refresh.TabIndex = 8;
            this.userButton_Refresh.UIText = "Refresh";
            this.userButton_Refresh.Click += new System.EventHandler(this.userButton_Refresh_Click);
            // 
            // userButton_Delete
            // 
            this.userButton_Delete.BackColor = System.Drawing.Color.Transparent;
            this.userButton_Delete.CustomerInformation = "";
            this.userButton_Delete.EnableColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(190)))), ((int)(((byte)(190)))));
            this.userButton_Delete.Font = new System.Drawing.Font("Microsoft YaHei", 9F);
            this.userButton_Delete.Location = new System.Drawing.Point(415, 45);
            this.userButton_Delete.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.userButton_Delete.Name = "userButton_Delete";
            this.userButton_Delete.Size = new System.Drawing.Size(78, 25);
            this.userButton_Delete.TabIndex = 7;
            this.userButton_Delete.UIText = "Delete";
            this.userButton_Delete.Click += new System.EventHandler(this.userButton_Delete_Click);
            // 
            // userButton_Create
            // 
            this.userButton_Create.BackColor = System.Drawing.Color.Transparent;
            this.userButton_Create.CustomerInformation = "";
            this.userButton_Create.EnableColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(190)))), ((int)(((byte)(190)))));
            this.userButton_Create.Font = new System.Drawing.Font("Microsoft YaHei", 9F);
            this.userButton_Create.Location = new System.Drawing.Point(415, 11);
            this.userButton_Create.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.userButton_Create.Name = "userButton_Create";
            this.userButton_Create.Size = new System.Drawing.Size(78, 25);
            this.userButton_Create.TabIndex = 6;
            this.userButton_Create.UIText = "Create";
            this.userButton_Create.Click += new System.EventHandler(this.userButton_Create_Click);
            // 
            // numericUpDown_Cols
            // 
            this.numericUpDown_Cols.Location = new System.Drawing.Point(305, 49);
            this.numericUpDown_Cols.Name = "numericUpDown_Cols";
            this.numericUpDown_Cols.Size = new System.Drawing.Size(87, 21);
            this.numericUpDown_Cols.TabIndex = 5;
            this.numericUpDown_Cols.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numericUpDown_Cols.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown_Cols.ValueChanged += new System.EventHandler(this.numericUpDown_Cols_ValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(258, 52);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 12);
            this.label3.TabIndex = 4;
            this.label3.Text = "Cols：";
            // 
            // numericUpDown_Row
            // 
            this.numericUpDown_Row.Location = new System.Drawing.Point(305, 15);
            this.numericUpDown_Row.Name = "numericUpDown_Row";
            this.numericUpDown_Row.Size = new System.Drawing.Size(87, 21);
            this.numericUpDown_Row.TabIndex = 3;
            this.numericUpDown_Row.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numericUpDown_Row.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown_Row.ValueChanged += new System.EventHandler(this.numericUpDown_Row_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(258, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 12);
            this.label2.TabIndex = 2;
            this.label2.Text = "Rows：";
            // 
            // comboBox_ConfigFileList
            // 
            this.comboBox_ConfigFileList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_ConfigFileList.FormattingEnabled = true;
            this.comboBox_ConfigFileList.Location = new System.Drawing.Point(9, 49);
            this.comboBox_ConfigFileList.Name = "comboBox_ConfigFileList";
            this.comboBox_ConfigFileList.Size = new System.Drawing.Size(146, 20);
            this.comboBox_ConfigFileList.TabIndex = 1;
            this.comboBox_ConfigFileList.SelectedIndexChanged += new System.EventHandler(this.comboBox_ConfigFileList_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "ConfigFileList";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.checkBox_IsSaveSearchHistory);
            this.tabPage2.Controls.Add(this.userButton_ImgSavePath);
            this.tabPage2.Controls.Add(this.textBox_ImgSavePath);
            this.tabPage2.Controls.Add(this.label10);
            this.tabPage2.Controls.Add(this.userButton_Set);
            this.tabPage2.Controls.Add(this.textBox_SourcePath);
            this.tabPage2.Controls.Add(this.label9);
            this.tabPage2.Controls.Add(this.groupBox2);
            this.tabPage2.Controls.Add(this.groupBox1);
            this.tabPage2.Controls.Add(this.comboBox_CurrentTemplateFile);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(509, 473);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Para";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // checkBox_IsSaveSearchHistory
            // 
            this.checkBox_IsSaveSearchHistory.AutoSize = true;
            this.checkBox_IsSaveSearchHistory.Location = new System.Drawing.Point(267, 36);
            this.checkBox_IsSaveSearchHistory.Name = "checkBox_IsSaveSearchHistory";
            this.checkBox_IsSaveSearchHistory.Size = new System.Drawing.Size(138, 16);
            this.checkBox_IsSaveSearchHistory.TabIndex = 18;
            this.checkBox_IsSaveSearchHistory.Text = "IsSaveSearchHistory";
            this.checkBox_IsSaveSearchHistory.UseVisualStyleBackColor = true;
            // 
            // userButton_ImgSavePath
            // 
            this.userButton_ImgSavePath.BackColor = System.Drawing.Color.Transparent;
            this.userButton_ImgSavePath.CustomerInformation = "";
            this.userButton_ImgSavePath.EnableColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(190)))), ((int)(((byte)(190)))));
            this.userButton_ImgSavePath.Font = new System.Drawing.Font("Microsoft YaHei", 9F);
            this.userButton_ImgSavePath.Location = new System.Drawing.Point(267, 111);
            this.userButton_ImgSavePath.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.userButton_ImgSavePath.Name = "userButton_ImgSavePath";
            this.userButton_ImgSavePath.Size = new System.Drawing.Size(78, 25);
            this.userButton_ImgSavePath.TabIndex = 17;
            this.userButton_ImgSavePath.UIText = "Set";
            this.userButton_ImgSavePath.Click += new System.EventHandler(this.UserButtonImg_SavePath_Click);
            // 
            // textBox_ImgSavePath
            // 
            this.textBox_ImgSavePath.Location = new System.Drawing.Point(105, 113);
            this.textBox_ImgSavePath.Name = "textBox_ImgSavePath";
            this.textBox_ImgSavePath.ReadOnly = true;
            this.textBox_ImgSavePath.Size = new System.Drawing.Size(146, 21);
            this.textBox_ImgSavePath.TabIndex = 16;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(24, 117);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(83, 12);
            this.label10.TabIndex = 15;
            this.label10.Text = "ImgSavePath：";
            // 
            // userButton_Set
            // 
            this.userButton_Set.BackColor = System.Drawing.Color.Transparent;
            this.userButton_Set.CustomerInformation = "";
            this.userButton_Set.EnableColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(190)))), ((int)(((byte)(190)))));
            this.userButton_Set.Font = new System.Drawing.Font("Microsoft YaHei", 9F);
            this.userButton_Set.Location = new System.Drawing.Point(267, 71);
            this.userButton_Set.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.userButton_Set.Name = "userButton_Set";
            this.userButton_Set.Size = new System.Drawing.Size(78, 25);
            this.userButton_Set.TabIndex = 14;
            this.userButton_Set.UIText = "Set";
            this.userButton_Set.Click += new System.EventHandler(this.userButton_Set_Click);
            // 
            // textBox_SourcePath
            // 
            this.textBox_SourcePath.Location = new System.Drawing.Point(106, 73);
            this.textBox_SourcePath.Name = "textBox_SourcePath";
            this.textBox_SourcePath.ReadOnly = true;
            this.textBox_SourcePath.Size = new System.Drawing.Size(146, 21);
            this.textBox_SourcePath.TabIndex = 13;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(25, 77);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(77, 12);
            this.label9.TabIndex = 12;
            this.label9.Text = "SourcePath：";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.numericUpDown_SheetHeight);
            this.groupBox2.Controls.Add(this.numericUpDown_SheetWidth);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Location = new System.Drawing.Point(24, 275);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(243, 100);
            this.groupBox2.TabIndex = 11;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Sheet Picture Size";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(20, 37);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(47, 12);
            this.label7.TabIndex = 6;
            this.label7.Text = "Width：";
            // 
            // numericUpDown_SheetHeight
            // 
            this.numericUpDown_SheetHeight.Location = new System.Drawing.Point(79, 61);
            this.numericUpDown_SheetHeight.Maximum = new decimal(new int[] {
            2000,
            0,
            0,
            0});
            this.numericUpDown_SheetHeight.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown_SheetHeight.Name = "numericUpDown_SheetHeight";
            this.numericUpDown_SheetHeight.Size = new System.Drawing.Size(146, 21);
            this.numericUpDown_SheetHeight.TabIndex = 9;
            this.numericUpDown_SheetHeight.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numericUpDown_SheetHeight.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // numericUpDown_SheetWidth
            // 
            this.numericUpDown_SheetWidth.Location = new System.Drawing.Point(79, 34);
            this.numericUpDown_SheetWidth.Maximum = new decimal(new int[] {
            2000,
            0,
            0,
            0});
            this.numericUpDown_SheetWidth.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown_SheetWidth.Name = "numericUpDown_SheetWidth";
            this.numericUpDown_SheetWidth.Size = new System.Drawing.Size(146, 21);
            this.numericUpDown_SheetWidth.TabIndex = 7;
            this.numericUpDown_SheetWidth.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numericUpDown_SheetWidth.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(20, 65);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(53, 12);
            this.label8.TabIndex = 8;
            this.label8.Text = "Height：";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.numericUpDown_SealHeight);
            this.groupBox1.Controls.Add(this.numericUpDown_SealWidth);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Location = new System.Drawing.Point(24, 152);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(243, 100);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Seal Picture Size";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(20, 37);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(47, 12);
            this.label6.TabIndex = 6;
            this.label6.Text = "Width：";
            // 
            // numericUpDown_SealHeight
            // 
            this.numericUpDown_SealHeight.Location = new System.Drawing.Point(79, 61);
            this.numericUpDown_SealHeight.Maximum = new decimal(new int[] {
            2000,
            0,
            0,
            0});
            this.numericUpDown_SealHeight.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown_SealHeight.Name = "numericUpDown_SealHeight";
            this.numericUpDown_SealHeight.Size = new System.Drawing.Size(146, 21);
            this.numericUpDown_SealHeight.TabIndex = 9;
            this.numericUpDown_SealHeight.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numericUpDown_SealHeight.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // numericUpDown_SealWidth
            // 
            this.numericUpDown_SealWidth.Location = new System.Drawing.Point(79, 34);
            this.numericUpDown_SealWidth.Maximum = new decimal(new int[] {
            2000,
            0,
            0,
            0});
            this.numericUpDown_SealWidth.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown_SealWidth.Name = "numericUpDown_SealWidth";
            this.numericUpDown_SealWidth.Size = new System.Drawing.Size(146, 21);
            this.numericUpDown_SealWidth.TabIndex = 7;
            this.numericUpDown_SealWidth.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numericUpDown_SealWidth.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(20, 65);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 12);
            this.label5.TabIndex = 8;
            this.label5.Text = "Height：";
            // 
            // comboBox_CurrentTemplateFile
            // 
            this.comboBox_CurrentTemplateFile.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_CurrentTemplateFile.FormattingEnabled = true;
            this.comboBox_CurrentTemplateFile.Location = new System.Drawing.Point(105, 34);
            this.comboBox_CurrentTemplateFile.Name = "comboBox_CurrentTemplateFile";
            this.comboBox_CurrentTemplateFile.Size = new System.Drawing.Size(146, 20);
            this.comboBox_CurrentTemplateFile.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(25, 38);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 12);
            this.label4.TabIndex = 2;
            this.label4.Text = "ConfigFile：";
            // 
            // ConfigForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(517, 499);
            this.Controls.Add(this.tabControl_Template);
            this.Name = "ConfigForm";
            this.Text = "ConfigForm";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ConfigForm_FormClosed);
            this.Load += new System.EventHandler(this.ConfigForm_Load);
            this.tabControl_Template.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.groupBox_Fill.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Template)).EndInit();
            this.groupBox_Top.ResumeLayout(false);
            this.groupBox_Top.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_Cols)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_Row)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_SheetHeight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_SheetWidth)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_SealHeight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_SealWidth)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl_Template;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.GroupBox groupBox_Fill;
        private System.Windows.Forms.DataGridView dataGridView_Template;
        private System.Windows.Forms.GroupBox groupBox_Top;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.NumericUpDown numericUpDown_Cols;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown numericUpDown_Row;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBox_ConfigFileList;
        private System.Windows.Forms.Label label1;
        private MyLibrary.MyControl.UserButton userButton_Delete;
        private MyLibrary.MyControl.UserButton userButton_Create;
        private MyLibrary.MyControl.UserButton userButton_Set;
        private System.Windows.Forms.TextBox textBox_SourcePath;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown numericUpDown_SheetHeight;
        private System.Windows.Forms.NumericUpDown numericUpDown_SheetWidth;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown numericUpDown_SealHeight;
        private System.Windows.Forms.NumericUpDown numericUpDown_SealWidth;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboBox_CurrentTemplateFile;
        private System.Windows.Forms.Label label4;
        private MyLibrary.MyControl.UserButton userButton_Refresh;
        private MyLibrary.MyControl.UserButton userButton_ImgSavePath;
        private System.Windows.Forms.TextBox textBox_ImgSavePath;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.CheckBox checkBox_IsSaveSearchHistory;
    }
}