
namespace Arbeidskrav_1
{
    partial class FormMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItemFile = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemOpen = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemSave = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemSaveAs = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemExit = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemHelp = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemAbout = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripProgressBarConnection = new System.Windows.Forms.ToolStripProgressBar();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPageConnection = new System.Windows.Forms.TabPage();
            this.textBoxConnection = new System.Windows.Forms.TextBox();
            this.labelConnection = new System.Windows.Forms.Label();
            this.labelBaudRate = new System.Windows.Forms.Label();
            this.labelComPort = new System.Windows.Forms.Label();
            this.buttonDisconnect = new System.Windows.Forms.Button();
            this.buttonConnect = new System.Windows.Forms.Button();
            this.comboBoxBaudRate = new System.Windows.Forms.ComboBox();
            this.comboBoxComPort = new System.Windows.Forms.ComboBox();
            this.tabPageConfig = new System.Windows.Forms.TabPage();
            this.labelAlarmH = new System.Windows.Forms.Label();
            this.labelAlarmL = new System.Windows.Forms.Label();
            this.labelURV = new System.Windows.Forms.Label();
            this.labelLRV = new System.Windows.Forms.Label();
            this.labelName = new System.Windows.Forms.Label();
            this.textBoxAlarmH = new System.Windows.Forms.TextBox();
            this.textBoxAlarmL = new System.Windows.Forms.TextBox();
            this.textBoxURV = new System.Windows.Forms.TextBox();
            this.textBoxLRV = new System.Windows.Forms.TextBox();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPageConnection.SuspendLayout();
            this.tabPageConfig.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItemFile,
            this.toolStripMenuItemHelp});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItemFile
            // 
            this.toolStripMenuItemFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItemOpen,
            this.toolStripMenuItemSave,
            this.toolStripMenuItemSaveAs,
            this.toolStripMenuItemExit});
            this.toolStripMenuItemFile.Name = "toolStripMenuItemFile";
            this.toolStripMenuItemFile.Size = new System.Drawing.Size(37, 20);
            this.toolStripMenuItemFile.Text = "&File";
            // 
            // toolStripMenuItemOpen
            // 
            this.toolStripMenuItemOpen.Name = "toolStripMenuItemOpen";
            this.toolStripMenuItemOpen.Size = new System.Drawing.Size(180, 22);
            this.toolStripMenuItemOpen.Text = "&Open";
            // 
            // toolStripMenuItemSave
            // 
            this.toolStripMenuItemSave.Name = "toolStripMenuItemSave";
            this.toolStripMenuItemSave.Size = new System.Drawing.Size(180, 22);
            this.toolStripMenuItemSave.Text = "&Save";
            // 
            // toolStripMenuItemSaveAs
            // 
            this.toolStripMenuItemSaveAs.Name = "toolStripMenuItemSaveAs";
            this.toolStripMenuItemSaveAs.Size = new System.Drawing.Size(180, 22);
            this.toolStripMenuItemSaveAs.Text = "Save &As...";
            // 
            // toolStripMenuItemExit
            // 
            this.toolStripMenuItemExit.Name = "toolStripMenuItemExit";
            this.toolStripMenuItemExit.Size = new System.Drawing.Size(180, 22);
            this.toolStripMenuItemExit.Text = "E&xit";
            this.toolStripMenuItemExit.Click += new System.EventHandler(this.toolStripMenuItemExit_Click);
            // 
            // toolStripMenuItemHelp
            // 
            this.toolStripMenuItemHelp.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItemAbout});
            this.toolStripMenuItemHelp.Name = "toolStripMenuItemHelp";
            this.toolStripMenuItemHelp.Size = new System.Drawing.Size(44, 20);
            this.toolStripMenuItemHelp.Text = "&Help";
            // 
            // toolStripMenuItemAbout
            // 
            this.toolStripMenuItemAbout.Name = "toolStripMenuItemAbout";
            this.toolStripMenuItemAbout.Size = new System.Drawing.Size(180, 22);
            this.toolStripMenuItemAbout.Text = "&About";
            this.toolStripMenuItemAbout.Click += new System.EventHandler(this.toolStripMenuItemAbout_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.toolStripProgressBarConnection});
            this.statusStrip1.Location = new System.Drawing.Point(0, 428);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(800, 22);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(148, 17);
            this.toolStripStatusLabel1.Text = "COM Status: Disconnected";
            // 
            // toolStripProgressBarConnection
            // 
            this.toolStripProgressBarConnection.Name = "toolStripProgressBarConnection";
            this.toolStripProgressBarConnection.Size = new System.Drawing.Size(100, 16);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPageConnection);
            this.tabControl1.Controls.Add(this.tabPageConfig);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 24);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(800, 404);
            this.tabControl1.TabIndex = 2;
            // 
            // tabPageConnection
            // 
            this.tabPageConnection.Controls.Add(this.textBoxConnection);
            this.tabPageConnection.Controls.Add(this.labelConnection);
            this.tabPageConnection.Controls.Add(this.labelBaudRate);
            this.tabPageConnection.Controls.Add(this.labelComPort);
            this.tabPageConnection.Controls.Add(this.buttonDisconnect);
            this.tabPageConnection.Controls.Add(this.buttonConnect);
            this.tabPageConnection.Controls.Add(this.comboBoxBaudRate);
            this.tabPageConnection.Controls.Add(this.comboBoxComPort);
            this.tabPageConnection.Location = new System.Drawing.Point(4, 22);
            this.tabPageConnection.Name = "tabPageConnection";
            this.tabPageConnection.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageConnection.Size = new System.Drawing.Size(792, 378);
            this.tabPageConnection.TabIndex = 0;
            this.tabPageConnection.Text = "Connection";
            this.tabPageConnection.UseVisualStyleBackColor = true;
            // 
            // textBoxConnection
            // 
            this.textBoxConnection.Location = new System.Drawing.Point(67, 89);
            this.textBoxConnection.Name = "textBoxConnection";
            this.textBoxConnection.ReadOnly = true;
            this.textBoxConnection.Size = new System.Drawing.Size(121, 20);
            this.textBoxConnection.TabIndex = 7;
            this.textBoxConnection.TabStop = false;
            this.textBoxConnection.Text = "Disconnected";
            // 
            // labelConnection
            // 
            this.labelConnection.AutoSize = true;
            this.labelConnection.Location = new System.Drawing.Point(19, 92);
            this.labelConnection.Name = "labelConnection";
            this.labelConnection.Size = new System.Drawing.Size(43, 13);
            this.labelConnection.TabIndex = 6;
            this.labelConnection.Text = "Status :";
            // 
            // labelBaudRate
            // 
            this.labelBaudRate.AutoSize = true;
            this.labelBaudRate.Location = new System.Drawing.Point(-2, 65);
            this.labelBaudRate.Name = "labelBaudRate";
            this.labelBaudRate.Size = new System.Drawing.Size(64, 13);
            this.labelBaudRate.TabIndex = 5;
            this.labelBaudRate.Text = "Baud Rate :";
            // 
            // labelComPort
            // 
            this.labelComPort.AutoSize = true;
            this.labelComPort.Location = new System.Drawing.Point(6, 38);
            this.labelComPort.Name = "labelComPort";
            this.labelComPort.Size = new System.Drawing.Size(59, 13);
            this.labelComPort.TabIndex = 4;
            this.labelComPort.Text = "COM Port :";
            // 
            // buttonDisconnect
            // 
            this.buttonDisconnect.Location = new System.Drawing.Point(113, 164);
            this.buttonDisconnect.Name = "buttonDisconnect";
            this.buttonDisconnect.Size = new System.Drawing.Size(75, 23);
            this.buttonDisconnect.TabIndex = 3;
            this.buttonDisconnect.Text = "Disconnect";
            this.buttonDisconnect.UseVisualStyleBackColor = true;
            this.buttonDisconnect.Click += new System.EventHandler(this.buttonDisconnect_Click);
            // 
            // buttonConnect
            // 
            this.buttonConnect.Location = new System.Drawing.Point(113, 135);
            this.buttonConnect.Name = "buttonConnect";
            this.buttonConnect.Size = new System.Drawing.Size(75, 23);
            this.buttonConnect.TabIndex = 2;
            this.buttonConnect.Text = "Connect";
            this.buttonConnect.UseVisualStyleBackColor = true;
            this.buttonConnect.Click += new System.EventHandler(this.buttonConnect_Click);
            // 
            // comboBoxBaudRate
            // 
            this.comboBoxBaudRate.FormattingEnabled = true;
            this.comboBoxBaudRate.Items.AddRange(new object[] {
            "1200",
            "2400",
            "4800",
            "7200",
            "9600",
            "14400"});
            this.comboBoxBaudRate.Location = new System.Drawing.Point(67, 62);
            this.comboBoxBaudRate.Name = "comboBoxBaudRate";
            this.comboBoxBaudRate.Size = new System.Drawing.Size(121, 21);
            this.comboBoxBaudRate.TabIndex = 1;
            this.comboBoxBaudRate.Enter += new System.EventHandler(this.comboBoxBaudRate_Enter);
            // 
            // comboBoxComPort
            // 
            this.comboBoxComPort.FormattingEnabled = true;
            this.comboBoxComPort.Location = new System.Drawing.Point(67, 35);
            this.comboBoxComPort.Name = "comboBoxComPort";
            this.comboBoxComPort.Size = new System.Drawing.Size(121, 21);
            this.comboBoxComPort.TabIndex = 0;
            this.comboBoxComPort.Enter += new System.EventHandler(this.comboBoxComPort_Enter);
            // 
            // tabPageConfig
            // 
            this.tabPageConfig.Controls.Add(this.labelAlarmH);
            this.tabPageConfig.Controls.Add(this.labelAlarmL);
            this.tabPageConfig.Controls.Add(this.labelURV);
            this.tabPageConfig.Controls.Add(this.labelLRV);
            this.tabPageConfig.Controls.Add(this.labelName);
            this.tabPageConfig.Controls.Add(this.textBoxAlarmH);
            this.tabPageConfig.Controls.Add(this.textBoxAlarmL);
            this.tabPageConfig.Controls.Add(this.textBoxURV);
            this.tabPageConfig.Controls.Add(this.textBoxLRV);
            this.tabPageConfig.Controls.Add(this.textBoxName);
            this.tabPageConfig.Location = new System.Drawing.Point(4, 22);
            this.tabPageConfig.Name = "tabPageConfig";
            this.tabPageConfig.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageConfig.Size = new System.Drawing.Size(792, 378);
            this.tabPageConfig.TabIndex = 1;
            this.tabPageConfig.Text = "Config";
            this.tabPageConfig.UseVisualStyleBackColor = true;
            // 
            // labelAlarmH
            // 
            this.labelAlarmH.AutoSize = true;
            this.labelAlarmH.Location = new System.Drawing.Point(8, 139);
            this.labelAlarmH.Name = "labelAlarmH";
            this.labelAlarmH.Size = new System.Drawing.Size(58, 13);
            this.labelAlarmH.TabIndex = 9;
            this.labelAlarmH.Text = "Alarm High";
            // 
            // labelAlarmL
            // 
            this.labelAlarmL.AutoSize = true;
            this.labelAlarmL.Location = new System.Drawing.Point(8, 113);
            this.labelAlarmL.Name = "labelAlarmL";
            this.labelAlarmL.Size = new System.Drawing.Size(56, 13);
            this.labelAlarmL.TabIndex = 8;
            this.labelAlarmL.Text = "Alarm Low";
            // 
            // labelURV
            // 
            this.labelURV.AutoSize = true;
            this.labelURV.Location = new System.Drawing.Point(8, 87);
            this.labelURV.Name = "labelURV";
            this.labelURV.Size = new System.Drawing.Size(101, 13);
            this.labelURV.TabIndex = 7;
            this.labelURV.Text = "Upper Range Value";
            // 
            // labelLRV
            // 
            this.labelLRV.AutoSize = true;
            this.labelLRV.Location = new System.Drawing.Point(8, 61);
            this.labelLRV.Name = "labelLRV";
            this.labelLRV.Size = new System.Drawing.Size(95, 13);
            this.labelLRV.TabIndex = 6;
            this.labelLRV.Text = "Lower Rage Value";
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(8, 35);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(35, 13);
            this.labelName.TabIndex = 5;
            this.labelName.Text = "Name";
            // 
            // textBoxAlarmH
            // 
            this.textBoxAlarmH.Location = new System.Drawing.Point(124, 136);
            this.textBoxAlarmH.Name = "textBoxAlarmH";
            this.textBoxAlarmH.Size = new System.Drawing.Size(100, 20);
            this.textBoxAlarmH.TabIndex = 4;
            // 
            // textBoxAlarmL
            // 
            this.textBoxAlarmL.Location = new System.Drawing.Point(124, 110);
            this.textBoxAlarmL.Name = "textBoxAlarmL";
            this.textBoxAlarmL.Size = new System.Drawing.Size(100, 20);
            this.textBoxAlarmL.TabIndex = 3;
            // 
            // textBoxURV
            // 
            this.textBoxURV.Location = new System.Drawing.Point(124, 84);
            this.textBoxURV.Name = "textBoxURV";
            this.textBoxURV.Size = new System.Drawing.Size(100, 20);
            this.textBoxURV.TabIndex = 2;
            // 
            // textBoxLRV
            // 
            this.textBoxLRV.Location = new System.Drawing.Point(124, 58);
            this.textBoxLRV.Name = "textBoxLRV";
            this.textBoxLRV.Size = new System.Drawing.Size(100, 20);
            this.textBoxLRV.TabIndex = 1;
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(124, 32);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(100, 20);
            this.textBoxName.TabIndex = 0;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormMain";
            this.Text = "SoftSensConf";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPageConnection.ResumeLayout(false);
            this.tabPageConnection.PerformLayout();
            this.tabPageConfig.ResumeLayout(false);
            this.tabPageConfig.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemFile;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemOpen;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemSave;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemSaveAs;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemExit;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemHelp;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemAbout;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripProgressBar toolStripProgressBarConnection;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPageConnection;
        private System.Windows.Forms.TabPage tabPageConfig;
        private System.Windows.Forms.TextBox textBoxConnection;
        private System.Windows.Forms.Label labelConnection;
        private System.Windows.Forms.Label labelBaudRate;
        private System.Windows.Forms.Label labelComPort;
        private System.Windows.Forms.Button buttonDisconnect;
        private System.Windows.Forms.Button buttonConnect;
        private System.Windows.Forms.ComboBox comboBoxBaudRate;
        private System.Windows.Forms.ComboBox comboBoxComPort;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.Label labelAlarmH;
        private System.Windows.Forms.Label labelAlarmL;
        private System.Windows.Forms.Label labelURV;
        private System.Windows.Forms.Label labelLRV;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.TextBox textBoxAlarmH;
        private System.Windows.Forms.TextBox textBoxAlarmL;
        private System.Windows.Forms.TextBox textBoxURV;
        private System.Windows.Forms.TextBox textBoxLRV;
        private System.Windows.Forms.TextBox textBoxName;
    }
}

