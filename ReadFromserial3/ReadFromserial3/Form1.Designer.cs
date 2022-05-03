namespace ReadFromserial3
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.chBoxRTSEnable = new System.Windows.Forms.CheckBox();
            this.chBoxDTREnable = new System.Windows.Forms.CheckBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.CBoxPARITYBITS = new System.Windows.Forms.ComboBox();
            this.CBoxSTOPBITS = new System.Windows.Forms.ComboBox();
            this.CBoxDATABITS = new System.Windows.Forms.ComboBox();
            this.CBoxBAUDRATE = new System.Windows.Forms.ComboBox();
            this.CBoxCOMPORT = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.labelCOMportstatus = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.btnSENDDATA = new System.Windows.Forms.Button();
            this.tboxDATAOUT = new System.Windows.Forms.TextBox();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.chboxUsingenter = new System.Windows.Forms.CheckBox();
            this.chboxUsingbutton = new System.Windows.Forms.CheckBox();
            this.groupBox8 = new System.Windows.Forms.GroupBox();
            this.labelDataOutLength = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.chboxWrite = new System.Windows.Forms.CheckBox();
            this.chboxWriteLine = new System.Windows.Forms.CheckBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.groupBox10 = new System.Windows.Forms.GroupBox();
            this.btnDemo = new System.Windows.Forms.Button();
            this.groupBox13 = new System.Windows.Forms.GroupBox();
            this.chBoxAddTodata = new System.Windows.Forms.CheckBox();
            this.chBoxAlwaysUpdate = new System.Windows.Forms.CheckBox();
            this.groupBox11 = new System.Windows.Forms.GroupBox();
            this.lbDataInLength = new System.Windows.Forms.Label();
            this.groupBox12 = new System.Windows.Forms.GroupBox();
            this.datainlabel = new System.Windows.Forms.Label();
            this.tBoxDataIN = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripComboBox_appendOrOverwrite = new System.Windows.Forms.ToolStripComboBox();
            this.toolStripComboBox_writelineOrWritetext = new System.Windows.Forms.ToolStripComboBox();
            this.btnSaveFile = new System.Windows.Forms.ToolStripMenuItem();
            this.btnOpenFile = new System.Windows.Forms.ToolStripMenuItem();
            this.btnExit = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.btnOPEN = new System.Windows.Forms.ToolStripMenuItem();
            this.btnCLOSE = new System.Windows.Forms.ToolStripMenuItem();
            this.transmitterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnCleardataout = new System.Windows.Forms.ToolStripMenuItem();
            this.endLineToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripComboBox2 = new System.Windows.Forms.ToolStripComboBox();
            this.dataFormatToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripComboBox4_TxData = new System.Windows.Forms.ToolStripComboBox();
            this.receiverToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnClearDataInReceiver = new System.Windows.Forms.ToolStripMenuItem();
            this.showDataWithToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripComboBox1 = new System.Windows.Forms.ToolStripComboBox();
            this.dataFormatToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripComboBox3 = new System.Windows.Forms.ToolStripComboBox();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contactToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.groupBox9 = new System.Windows.Forms.GroupBox();
            this.richTextBox2 = new System.Windows.Forms.RichTextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox8.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox10.SuspendLayout();
            this.groupBox13.SuspendLayout();
            this.groupBox11.SuspendLayout();
            this.groupBox12.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.groupBox9.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.groupBox1.Controls.Add(this.chBoxRTSEnable);
            this.groupBox1.Controls.Add(this.chBoxDTREnable);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.CBoxPARITYBITS);
            this.groupBox1.Controls.Add(this.CBoxSTOPBITS);
            this.groupBox1.Controls.Add(this.CBoxDATABITS);
            this.groupBox1.Controls.Add(this.CBoxBAUDRATE);
            this.groupBox1.Controls.Add(this.CBoxCOMPORT);
            this.groupBox1.Location = new System.Drawing.Point(12, 45);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(343, 344);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "COM port control";
            // 
            // chBoxRTSEnable
            // 
            this.chBoxRTSEnable.AutoSize = true;
            this.chBoxRTSEnable.Location = new System.Drawing.Point(171, 294);
            this.chBoxRTSEnable.Name = "chBoxRTSEnable";
            this.chBoxRTSEnable.Size = new System.Drawing.Size(135, 24);
            this.chBoxRTSEnable.TabIndex = 11;
            this.chBoxRTSEnable.Text = "RTS ENABLE";
            this.chBoxRTSEnable.UseVisualStyleBackColor = true;
            this.chBoxRTSEnable.CheckedChanged += new System.EventHandler(this.chBoxRTSEnable_CheckedChanged);
            // 
            // chBoxDTREnable
            // 
            this.chBoxDTREnable.AutoSize = true;
            this.chBoxDTREnable.Location = new System.Drawing.Point(12, 294);
            this.chBoxDTREnable.Name = "chBoxDTREnable";
            this.chBoxDTREnable.Size = new System.Drawing.Size(136, 24);
            this.chBoxDTREnable.TabIndex = 10;
            this.chBoxDTREnable.Text = "DTR ENABLE";
            this.chBoxDTREnable.UseVisualStyleBackColor = true;
            this.chBoxDTREnable.CheckedChanged += new System.EventHandler(this.chBoxDTREnable_CheckedChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(8, 252);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 20);
            this.label5.TabIndex = 9;
            this.label5.Text = "ParityBits";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 200);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 20);
            this.label4.TabIndex = 8;
            this.label4.Text = "StopBits";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 151);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "Databits";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "BaudRate";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "Com port";
            // 
            // CBoxPARITYBITS
            // 
            this.CBoxPARITYBITS.AllowDrop = true;
            this.CBoxPARITYBITS.FormattingEnabled = true;
            this.CBoxPARITYBITS.Items.AddRange(new object[] {
            "None",
            "Odd",
            "Even"});
            this.CBoxPARITYBITS.Location = new System.Drawing.Point(129, 252);
            this.CBoxPARITYBITS.Name = "CBoxPARITYBITS";
            this.CBoxPARITYBITS.Size = new System.Drawing.Size(178, 28);
            this.CBoxPARITYBITS.TabIndex = 4;
            this.CBoxPARITYBITS.Text = "None";
            // 
            // CBoxSTOPBITS
            // 
            this.CBoxSTOPBITS.FormattingEnabled = true;
            this.CBoxSTOPBITS.Items.AddRange(new object[] {
            "One",
            "Two"});
            this.CBoxSTOPBITS.Location = new System.Drawing.Point(129, 197);
            this.CBoxSTOPBITS.Name = "CBoxSTOPBITS";
            this.CBoxSTOPBITS.Size = new System.Drawing.Size(180, 28);
            this.CBoxSTOPBITS.TabIndex = 3;
            this.CBoxSTOPBITS.Text = "One";
            // 
            // CBoxDATABITS
            // 
            this.CBoxDATABITS.FormattingEnabled = true;
            this.CBoxDATABITS.Items.AddRange(new object[] {
            "5",
            "6",
            "7",
            "8"});
            this.CBoxDATABITS.Location = new System.Drawing.Point(129, 143);
            this.CBoxDATABITS.Name = "CBoxDATABITS";
            this.CBoxDATABITS.Size = new System.Drawing.Size(180, 28);
            this.CBoxDATABITS.TabIndex = 2;
            this.CBoxDATABITS.Text = "8";
            // 
            // CBoxBAUDRATE
            // 
            this.CBoxBAUDRATE.FormattingEnabled = true;
            this.CBoxBAUDRATE.Items.AddRange(new object[] {
            "110",
            "300",
            "600",
            "1200",
            "2400",
            "4800",
            "9600",
            "14400",
            "38400"});
            this.CBoxBAUDRATE.Location = new System.Drawing.Point(129, 88);
            this.CBoxBAUDRATE.Name = "CBoxBAUDRATE";
            this.CBoxBAUDRATE.Size = new System.Drawing.Size(180, 28);
            this.CBoxBAUDRATE.TabIndex = 1;
            // 
            // CBoxCOMPORT
            // 
            this.CBoxCOMPORT.FormattingEnabled = true;
            this.CBoxCOMPORT.Location = new System.Drawing.Point(129, 30);
            this.CBoxCOMPORT.Name = "CBoxCOMPORT";
            this.CBoxCOMPORT.Size = new System.Drawing.Size(183, 28);
            this.CBoxCOMPORT.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.groupBox2.Controls.Add(this.groupBox7);
            this.groupBox2.Controls.Add(this.progressBar1);
            this.groupBox2.Location = new System.Drawing.Point(12, 395);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(343, 165);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.labelCOMportstatus);
            this.groupBox7.Location = new System.Drawing.Point(95, 16);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(152, 87);
            this.groupBox7.TabIndex = 3;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "COM Port Status";
            // 
            // labelCOMportstatus
            // 
            this.labelCOMportstatus.AutoSize = true;
            this.labelCOMportstatus.Font = new System.Drawing.Font("Impact", 16F);
            this.labelCOMportstatus.Location = new System.Drawing.Point(50, 37);
            this.labelCOMportstatus.Name = "labelCOMportstatus";
            this.labelCOMportstatus.Size = new System.Drawing.Size(60, 39);
            this.labelCOMportstatus.TabIndex = 0;
            this.labelCOMportstatus.Text = "OFF";
            this.labelCOMportstatus.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.labelCOMportstatus.Click += new System.EventHandler(this.labelCOMportstatus_Click);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(6, 109);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(325, 39);
            this.progressBar1.TabIndex = 2;
            // 
            // btnSENDDATA
            // 
            this.btnSENDDATA.Location = new System.Drawing.Point(8, 20);
            this.btnSENDDATA.Name = "btnSENDDATA";
            this.btnSENDDATA.Size = new System.Drawing.Size(105, 49);
            this.btnSENDDATA.TabIndex = 2;
            this.btnSENDDATA.Text = "Send Data";
            this.btnSENDDATA.UseVisualStyleBackColor = true;
            this.btnSENDDATA.Click += new System.EventHandler(this.btnSENDDATA_Click);
            // 
            // tboxDATAOUT
            // 
            this.tboxDATAOUT.Location = new System.Drawing.Point(6, 25);
            this.tboxDATAOUT.Multiline = true;
            this.tboxDATAOUT.Name = "tboxDATAOUT";
            this.tboxDATAOUT.Size = new System.Drawing.Size(331, 64);
            this.tboxDATAOUT.TabIndex = 3;
            this.tboxDATAOUT.TextChanged += new System.EventHandler(this.tboxDATAOUT_TextChanged);
            this.tboxDATAOUT.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tboxDATAOUT_KeyDown);
            // 
            // serialPort1
            // 
            this.serialPort1.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.serialPort1_DataReceived);
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.groupBox3.Controls.Add(this.groupBox5);
            this.groupBox3.Controls.Add(this.groupBox8);
            this.groupBox3.Controls.Add(this.groupBox6);
            this.groupBox3.Controls.Add(this.groupBox4);
            this.groupBox3.Controls.Add(this.tboxDATAOUT);
            this.groupBox3.Location = new System.Drawing.Point(12, 566);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(343, 281);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Transmitter Control";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.chboxUsingenter);
            this.groupBox5.Controls.Add(this.chboxUsingbutton);
            this.groupBox5.Location = new System.Drawing.Point(8, 138);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(140, 90);
            this.groupBox5.TabIndex = 6;
            this.groupBox5.TabStop = false;
            // 
            // chboxUsingenter
            // 
            this.chboxUsingenter.AutoSize = true;
            this.chboxUsingenter.Location = new System.Drawing.Point(6, 45);
            this.chboxUsingenter.Name = "chboxUsingenter";
            this.chboxUsingenter.Size = new System.Drawing.Size(114, 24);
            this.chboxUsingenter.TabIndex = 1;
            this.chboxUsingenter.Text = "using enter";
            this.chboxUsingenter.UseVisualStyleBackColor = true;
            this.chboxUsingenter.CheckedChanged += new System.EventHandler(this.chboxUsingenter_CheckedChanged);
            // 
            // chboxUsingbutton
            // 
            this.chboxUsingbutton.AutoSize = true;
            this.chboxUsingbutton.Location = new System.Drawing.Point(6, 15);
            this.chboxUsingbutton.Name = "chboxUsingbutton";
            this.chboxUsingbutton.Size = new System.Drawing.Size(123, 24);
            this.chboxUsingbutton.TabIndex = 0;
            this.chboxUsingbutton.Text = "using button";
            this.chboxUsingbutton.UseVisualStyleBackColor = true;
            this.chboxUsingbutton.CheckedChanged += new System.EventHandler(this.chboxUsingbutton_CheckedChanged);
            // 
            // groupBox8
            // 
            this.groupBox8.Controls.Add(this.labelDataOutLength);
            this.groupBox8.Controls.Add(this.label6);
            this.groupBox8.Location = new System.Drawing.Point(6, 95);
            this.groupBox8.Name = "groupBox8";
            this.groupBox8.Size = new System.Drawing.Size(168, 48);
            this.groupBox8.TabIndex = 8;
            this.groupBox8.TabStop = false;
            // 
            // labelDataOutLength
            // 
            this.labelDataOutLength.AutoSize = true;
            this.labelDataOutLength.Location = new System.Drawing.Point(140, 25);
            this.labelDataOutLength.Name = "labelDataOutLength";
            this.labelDataOutLength.Size = new System.Drawing.Size(27, 20);
            this.labelDataOutLength.TabIndex = 0;
            this.labelDataOutLength.Text = "00";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(5, 25);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(137, 20);
            this.label6.TabIndex = 0;
            this.label6.Text = "Data OUT length :";
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.chboxWrite);
            this.groupBox6.Controls.Add(this.chboxWriteLine);
            this.groupBox6.Location = new System.Drawing.Point(194, 161);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(112, 83);
            this.groupBox6.TabIndex = 7;
            this.groupBox6.TabStop = false;
            // 
            // chboxWrite
            // 
            this.chboxWrite.AutoSize = true;
            this.chboxWrite.Location = new System.Drawing.Point(6, 55);
            this.chboxWrite.Name = "chboxWrite";
            this.chboxWrite.Size = new System.Drawing.Size(68, 24);
            this.chboxWrite.TabIndex = 1;
            this.chboxWrite.Text = "write";
            this.chboxWrite.UseVisualStyleBackColor = true;
            this.chboxWrite.CheckedChanged += new System.EventHandler(this.chboxwrite_CheckedChanged);
            // 
            // chboxWriteLine
            // 
            this.chboxWriteLine.AutoSize = true;
            this.chboxWriteLine.Location = new System.Drawing.Point(6, 25);
            this.chboxWriteLine.Name = "chboxWriteLine";
            this.chboxWriteLine.Size = new System.Drawing.Size(92, 24);
            this.chboxWriteLine.TabIndex = 0;
            this.chboxWriteLine.Text = "writeline";
            this.chboxWriteLine.UseVisualStyleBackColor = true;
            this.chboxWriteLine.CheckedChanged += new System.EventHandler(this.chboxWriteLine_CheckedChanged);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.btnSENDDATA);
            this.groupBox4.Location = new System.Drawing.Point(193, 95);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(119, 71);
            this.groupBox4.TabIndex = 5;
            this.groupBox4.TabStop = false;
            // 
            // groupBox10
            // 
            this.groupBox10.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.groupBox10.Controls.Add(this.btnDemo);
            this.groupBox10.Controls.Add(this.groupBox13);
            this.groupBox10.Controls.Add(this.groupBox11);
            this.groupBox10.Controls.Add(this.groupBox12);
            this.groupBox10.Controls.Add(this.tBoxDataIN);
            this.groupBox10.Location = new System.Drawing.Point(373, 45);
            this.groupBox10.Name = "groupBox10";
            this.groupBox10.Size = new System.Drawing.Size(522, 802);
            this.groupBox10.TabIndex = 5;
            this.groupBox10.TabStop = false;
            this.groupBox10.Text = "Receiver Control";
            // 
            // btnDemo
            // 
            this.btnDemo.Location = new System.Drawing.Point(398, 679);
            this.btnDemo.Name = "btnDemo";
            this.btnDemo.Size = new System.Drawing.Size(104, 49);
            this.btnDemo.TabIndex = 14;
            this.btnDemo.Text = "Demo Plot";
            this.btnDemo.UseVisualStyleBackColor = true;
            this.btnDemo.Click += new System.EventHandler(this.btnDemo_Click);
            // 
            // groupBox13
            // 
            this.groupBox13.Controls.Add(this.chBoxAddTodata);
            this.groupBox13.Controls.Add(this.chBoxAlwaysUpdate);
            this.groupBox13.Location = new System.Drawing.Point(25, 674);
            this.groupBox13.Name = "groupBox13";
            this.groupBox13.Size = new System.Drawing.Size(354, 63);
            this.groupBox13.TabIndex = 13;
            this.groupBox13.TabStop = false;
            // 
            // chBoxAddTodata
            // 
            this.chBoxAddTodata.AutoSize = true;
            this.chBoxAddTodata.Location = new System.Drawing.Point(177, 25);
            this.chBoxAddTodata.Name = "chBoxAddTodata";
            this.chBoxAddTodata.Size = new System.Drawing.Size(161, 24);
            this.chBoxAddTodata.TabIndex = 1;
            this.chBoxAddTodata.Text = "Add To Old DATA";
            this.chBoxAddTodata.UseVisualStyleBackColor = true;
            this.chBoxAddTodata.CheckedChanged += new System.EventHandler(this.chBoxAddTodata_CheckedChanged);
            // 
            // chBoxAlwaysUpdate
            // 
            this.chBoxAlwaysUpdate.AutoSize = true;
            this.chBoxAlwaysUpdate.Location = new System.Drawing.Point(6, 25);
            this.chBoxAlwaysUpdate.Name = "chBoxAlwaysUpdate";
            this.chBoxAlwaysUpdate.Size = new System.Drawing.Size(141, 24);
            this.chBoxAlwaysUpdate.TabIndex = 0;
            this.chBoxAlwaysUpdate.Text = "Always Update";
            this.chBoxAlwaysUpdate.UseVisualStyleBackColor = true;
            this.chBoxAlwaysUpdate.CheckedChanged += new System.EventHandler(this.chBoxAlwaysUpdate_CheckedChanged);
            // 
            // groupBox11
            // 
            this.groupBox11.Controls.Add(this.lbDataInLength);
            this.groupBox11.Location = new System.Drawing.Point(261, 737);
            this.groupBox11.Name = "groupBox11";
            this.groupBox11.Size = new System.Drawing.Size(72, 53);
            this.groupBox11.TabIndex = 11;
            this.groupBox11.TabStop = false;
            // 
            // lbDataInLength
            // 
            this.lbDataInLength.AutoSize = true;
            this.lbDataInLength.Location = new System.Drawing.Point(17, 21);
            this.lbDataInLength.Name = "lbDataInLength";
            this.lbDataInLength.Size = new System.Drawing.Size(27, 20);
            this.lbDataInLength.TabIndex = 0;
            this.lbDataInLength.Text = "00";
            // 
            // groupBox12
            // 
            this.groupBox12.Controls.Add(this.datainlabel);
            this.groupBox12.Location = new System.Drawing.Point(110, 737);
            this.groupBox12.Name = "groupBox12";
            this.groupBox12.Size = new System.Drawing.Size(145, 52);
            this.groupBox12.TabIndex = 10;
            this.groupBox12.TabStop = false;
            // 
            // datainlabel
            // 
            this.datainlabel.AutoSize = true;
            this.datainlabel.Location = new System.Drawing.Point(8, 22);
            this.datainlabel.Name = "datainlabel";
            this.datainlabel.Size = new System.Drawing.Size(120, 20);
            this.datainlabel.TabIndex = 0;
            this.datainlabel.Text = "Data IN length :";
            this.datainlabel.Click += new System.EventHandler(this.ta_Click);
            // 
            // tBoxDataIN
            // 
            this.tBoxDataIN.Location = new System.Drawing.Point(12, 26);
            this.tBoxDataIN.Multiline = true;
            this.tBoxDataIN.Name = "tBoxDataIN";
            this.tBoxDataIN.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.tBoxDataIN.Size = new System.Drawing.Size(490, 642);
            this.tBoxDataIN.TabIndex = 4;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("Bahnschrift", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem2,
            this.toolStripMenuItem1,
            this.transmitterToolStripMenuItem,
            this.receiverToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1728, 54);
            this.menuStrip1.TabIndex = 6;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem1,
            this.btnSaveFile,
            this.btnOpenFile,
            this.btnExit});
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(59, 28);
            this.toolStripMenuItem2.Text = "File";
            // 
            // openToolStripMenuItem1
            // 
            this.openToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripComboBox_appendOrOverwrite,
            this.toolStripComboBox_writelineOrWritetext});
            this.openToolStripMenuItem1.Name = "openToolStripMenuItem1";
            this.openToolStripMenuItem1.Size = new System.Drawing.Size(249, 34);
            this.openToolStripMenuItem1.Text = "Save To Txt File";
            // 
            // toolStripComboBox_appendOrOverwrite
            // 
            this.toolStripComboBox_appendOrOverwrite.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.toolStripComboBox_appendOrOverwrite.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.toolStripComboBox_appendOrOverwrite.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.toolStripComboBox_appendOrOverwrite.Items.AddRange(new object[] {
            "Append Text",
            "Overwrite Text"});
            this.toolStripComboBox_appendOrOverwrite.Name = "toolStripComboBox_appendOrOverwrite";
            this.toolStripComboBox_appendOrOverwrite.Size = new System.Drawing.Size(121, 33);
            this.toolStripComboBox_appendOrOverwrite.DropDownClosed += new System.EventHandler(this.toolStripComboBox_appendOrOverwrite_DropDownClosed);
            // 
            // toolStripComboBox_writelineOrWritetext
            // 
            this.toolStripComboBox_writelineOrWritetext.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.toolStripComboBox_writelineOrWritetext.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.toolStripComboBox_writelineOrWritetext.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.toolStripComboBox_writelineOrWritetext.Items.AddRange(new object[] {
            "WriteLine",
            "Write"});
            this.toolStripComboBox_writelineOrWritetext.Name = "toolStripComboBox_writelineOrWritetext";
            this.toolStripComboBox_writelineOrWritetext.Size = new System.Drawing.Size(121, 33);
            // 
            // btnSaveFile
            // 
            this.btnSaveFile.Name = "btnSaveFile";
            this.btnSaveFile.Size = new System.Drawing.Size(249, 34);
            this.btnSaveFile.Text = "Save File";
            this.btnSaveFile.Click += new System.EventHandler(this.btnSaveFile_Click);
            // 
            // btnOpenFile
            // 
            this.btnOpenFile.Name = "btnOpenFile";
            this.btnOpenFile.Size = new System.Drawing.Size(249, 34);
            this.btnOpenFile.Text = "Open File";
            this.btnOpenFile.Click += new System.EventHandler(this.btnOpenFile_Click);
            // 
            // btnExit
            // 
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(249, 34);
            this.btnExit.Text = "Exit";
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnOPEN,
            this.btnCLOSE});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(139, 28);
            this.toolStripMenuItem1.Text = "COM Control";
            // 
            // btnOPEN
            // 
            this.btnOPEN.Name = "btnOPEN";
            this.btnOPEN.Size = new System.Drawing.Size(160, 34);
            this.btnOPEN.Text = "Open";
            this.btnOPEN.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // btnCLOSE
            // 
            this.btnCLOSE.Name = "btnCLOSE";
            this.btnCLOSE.Size = new System.Drawing.Size(160, 34);
            this.btnCLOSE.Text = "Close";
            this.btnCLOSE.Click += new System.EventHandler(this.closeToolStripMenuItem_Click);
            // 
            // transmitterToolStripMenuItem
            // 
            this.transmitterToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnCleardataout,
            this.endLineToolStripMenuItem,
            this.dataFormatToolStripMenuItem1});
            this.transmitterToolStripMenuItem.Name = "transmitterToolStripMenuItem";
            this.transmitterToolStripMenuItem.Size = new System.Drawing.Size(132, 28);
            this.transmitterToolStripMenuItem.Text = "Transmitter";
            // 
            // btnCleardataout
            // 
            this.btnCleardataout.Name = "btnCleardataout";
            this.btnCleardataout.Size = new System.Drawing.Size(223, 34);
            this.btnCleardataout.Text = "Clear";
            this.btnCleardataout.Click += new System.EventHandler(this.btnCleardataout_Click);
            // 
            // endLineToolStripMenuItem
            // 
            this.endLineToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripComboBox2});
            this.endLineToolStripMenuItem.Name = "endLineToolStripMenuItem";
            this.endLineToolStripMenuItem.Size = new System.Drawing.Size(223, 34);
            this.endLineToolStripMenuItem.Text = "End Line";
            this.endLineToolStripMenuItem.Click += new System.EventHandler(this.endLineToolStripMenuItem_Click);
            // 
            // toolStripComboBox2
            // 
            this.toolStripComboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.toolStripComboBox2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.toolStripComboBox2.Items.AddRange(new object[] {
            "None ",
            "Both(\\r,\\n)",
            "New Line (\\n)",
            "Carriage Return (\\r)"});
            this.toolStripComboBox2.Name = "toolStripComboBox2";
            this.toolStripComboBox2.Size = new System.Drawing.Size(121, 33);
            // 
            // dataFormatToolStripMenuItem1
            // 
            this.dataFormatToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripComboBox4_TxData});
            this.dataFormatToolStripMenuItem1.Name = "dataFormatToolStripMenuItem1";
            this.dataFormatToolStripMenuItem1.Size = new System.Drawing.Size(223, 34);
            this.dataFormatToolStripMenuItem1.Text = "Data Format";
            this.dataFormatToolStripMenuItem1.Click += new System.EventHandler(this.dataFormatToolStripMenuItem1_Click);
            // 
            // toolStripComboBox4_TxData
            // 
            this.toolStripComboBox4_TxData.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.toolStripComboBox4_TxData.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.toolStripComboBox4_TxData.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.toolStripComboBox4_TxData.Items.AddRange(new object[] {
            "Binary",
            "Hex",
            "Decimal",
            "Char"});
            this.toolStripComboBox4_TxData.Name = "toolStripComboBox4_TxData";
            this.toolStripComboBox4_TxData.Size = new System.Drawing.Size(121, 33);
            // 
            // receiverToolStripMenuItem
            // 
            this.receiverToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnClearDataInReceiver,
            this.showDataWithToolStripMenuItem,
            this.dataFormatToolStripMenuItem});
            this.receiverToolStripMenuItem.Name = "receiverToolStripMenuItem";
            this.receiverToolStripMenuItem.Size = new System.Drawing.Size(106, 28);
            this.receiverToolStripMenuItem.Text = "Receiver";
            // 
            // btnClearDataInReceiver
            // 
            this.btnClearDataInReceiver.Name = "btnClearDataInReceiver";
            this.btnClearDataInReceiver.Size = new System.Drawing.Size(251, 34);
            this.btnClearDataInReceiver.Text = "Clear";
            this.btnClearDataInReceiver.Click += new System.EventHandler(this.btnClearDataInReceiver_Click);
            // 
            // showDataWithToolStripMenuItem
            // 
            this.showDataWithToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripComboBox1});
            this.showDataWithToolStripMenuItem.Name = "showDataWithToolStripMenuItem";
            this.showDataWithToolStripMenuItem.Size = new System.Drawing.Size(251, 34);
            this.showDataWithToolStripMenuItem.Text = "Show Data With";
            // 
            // toolStripComboBox1
            // 
            this.toolStripComboBox1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.toolStripComboBox1.Items.AddRange(new object[] {
            "Always Update",
            "Add to Old Data"});
            this.toolStripComboBox1.Name = "toolStripComboBox1";
            this.toolStripComboBox1.Size = new System.Drawing.Size(121, 33);
            // 
            // dataFormatToolStripMenuItem
            // 
            this.dataFormatToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripComboBox3});
            this.dataFormatToolStripMenuItem.Name = "dataFormatToolStripMenuItem";
            this.dataFormatToolStripMenuItem.Size = new System.Drawing.Size(251, 34);
            this.dataFormatToolStripMenuItem.Text = "Data Format";
            // 
            // toolStripComboBox3
            // 
            this.toolStripComboBox3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.toolStripComboBox3.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.toolStripComboBox3.Items.AddRange(new object[] {
            "char",
            "Hex",
            "Binary",
            "Decimal"});
            this.toolStripComboBox3.Name = "toolStripComboBox3";
            this.toolStripComboBox3.Size = new System.Drawing.Size(121, 33);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.contactToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(79, 28);
            this.aboutToolStripMenuItem.Text = "About";
            // 
            // contactToolStripMenuItem
            // 
            this.contactToolStripMenuItem.Name = "contactToolStripMenuItem";
            this.contactToolStripMenuItem.Size = new System.Drawing.Size(179, 34);
            this.contactToolStripMenuItem.Text = "Contact";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(179, 34);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(24, 33);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.ForcedVertical;
            this.richTextBox1.Size = new System.Drawing.Size(90, 755);
            this.richTextBox1.TabIndex = 7;
            this.richTextBox1.Text = "";
            // 
            // groupBox9
            // 
            this.groupBox9.Controls.Add(this.richTextBox2);
            this.groupBox9.Controls.Add(this.richTextBox1);
            this.groupBox9.Location = new System.Drawing.Point(915, 45);
            this.groupBox9.Name = "groupBox9";
            this.groupBox9.Size = new System.Drawing.Size(225, 794);
            this.groupBox9.TabIndex = 8;
            this.groupBox9.TabStop = false;
            this.groupBox9.Text = "  s1mwerT1    S2mwerT1";
            // 
            // richTextBox2
            // 
            this.richTextBox2.Location = new System.Drawing.Point(131, 33);
            this.richTextBox2.Name = "richTextBox2";
            this.richTextBox2.Size = new System.Drawing.Size(68, 752);
            this.richTextBox2.TabIndex = 8;
            this.richTextBox2.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(1152, 856);
            this.Controls.Add(this.groupBox9);
            this.Controls.Add(this.groupBox10);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Monitor SerialPort";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox7.ResumeLayout(false);
            this.groupBox7.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox8.ResumeLayout(false);
            this.groupBox8.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox10.ResumeLayout(false);
            this.groupBox10.PerformLayout();
            this.groupBox13.ResumeLayout(false);
            this.groupBox13.PerformLayout();
            this.groupBox11.ResumeLayout(false);
            this.groupBox11.PerformLayout();
            this.groupBox12.ResumeLayout(false);
            this.groupBox12.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox9.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox CBoxCOMPORT;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox CBoxPARITYBITS;
        private System.Windows.Forms.ComboBox CBoxSTOPBITS;
        private System.Windows.Forms.ComboBox CBoxDATABITS;
        private System.Windows.Forms.ComboBox CBoxBAUDRATE;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Button btnSENDDATA;
        private System.Windows.Forms.TextBox tboxDATAOUT;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.CheckBox chBoxRTSEnable;
        private System.Windows.Forms.CheckBox chBoxDTREnable;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.CheckBox chboxWrite;
        private System.Windows.Forms.CheckBox chboxWriteLine;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.CheckBox chboxUsingenter;
        private System.Windows.Forms.CheckBox chboxUsingbutton;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.Label labelCOMportstatus;
        private System.Windows.Forms.Label labelDataOutLength;
        private System.Windows.Forms.GroupBox groupBox8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox10;
        private System.Windows.Forms.GroupBox groupBox13;
        private System.Windows.Forms.CheckBox chBoxAddTodata;
        private System.Windows.Forms.CheckBox chBoxAlwaysUpdate;
        private System.Windows.Forms.GroupBox groupBox11;
        private System.Windows.Forms.Label lbDataInLength;
        private System.Windows.Forms.GroupBox groupBox12;
        private System.Windows.Forms.Label datainlabel;
        private System.Windows.Forms.TextBox tBoxDataIN;
        private System.Windows.Forms.Button btnDemo;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem transmitterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem receiverToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem btnExit;
        private System.Windows.Forms.ToolStripMenuItem btnOPEN;
        private System.Windows.Forms.ToolStripMenuItem btnCLOSE;
        private System.Windows.Forms.ToolStripMenuItem btnCleardataout;
        private System.Windows.Forms.ToolStripMenuItem btnClearDataInReceiver;
        private System.Windows.Forms.ToolStripMenuItem contactToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem endLineToolStripMenuItem;
        private System.Windows.Forms.ToolStripComboBox toolStripComboBox2;
        private System.Windows.Forms.ToolStripMenuItem showDataWithToolStripMenuItem;
        private System.Windows.Forms.ToolStripComboBox toolStripComboBox1;
        private System.Windows.Forms.ToolStripMenuItem dataFormatToolStripMenuItem;
        private System.Windows.Forms.ToolStripComboBox toolStripComboBox3;
        private System.Windows.Forms.ToolStripMenuItem dataFormatToolStripMenuItem1;
        private System.Windows.Forms.ToolStripComboBox toolStripComboBox4_TxData;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem btnSaveFile;
        private System.Windows.Forms.ToolStripComboBox toolStripComboBox_appendOrOverwrite;
        private System.Windows.Forms.ToolStripComboBox toolStripComboBox_writelineOrWritetext;
        private System.Windows.Forms.ToolStripMenuItem btnOpenFile;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.GroupBox groupBox9;
        private System.Windows.Forms.RichTextBox richTextBox2;
    }
}

