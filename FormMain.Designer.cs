
namespace SoftSensConf
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title2 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItemFile = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemOpen = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemSave = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemSaveAs = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemExit = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemSettings = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemDefaultConfig = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemHelp = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemAbout = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabelConnection = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripProgressBarConnection = new System.Windows.Forms.ToolStripProgressBar();
            this.toolStripStatusLabelMonitoring = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabelMStaus = new System.Windows.Forms.ToolStripStatusLabel();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPageConnection = new System.Windows.Forms.TabPage();
            this.panelConfiguration = new System.Windows.Forms.Panel();
            this.labelInput = new System.Windows.Forms.Label();
            this.labelConfPanel = new System.Windows.Forms.Label();
            this.textBoxCAlarmL = new System.Windows.Forms.TextBox();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.buttonLoad = new System.Windows.Forms.Button();
            this.textBoxLRV = new System.Windows.Forms.TextBox();
            this.textBoxCAlarmH = new System.Windows.Forms.TextBox();
            this.textBoxURV = new System.Windows.Forms.TextBox();
            this.textBoxAlarmL = new System.Windows.Forms.TextBox();
            this.textBoxCURV = new System.Windows.Forms.TextBox();
            this.textBoxAlarmH = new System.Windows.Forms.TextBox();
            this.textBoxCLRV = new System.Windows.Forms.TextBox();
            this.labelName = new System.Windows.Forms.Label();
            this.textBoxCName = new System.Windows.Forms.TextBox();
            this.labelLRV = new System.Windows.Forms.Label();
            this.labelCurrenConfig = new System.Windows.Forms.Label();
            this.labelURV = new System.Windows.Forms.Label();
            this.buttonWrite = new System.Windows.Forms.Button();
            this.labelAlarmL = new System.Windows.Forms.Label();
            this.buttonSave = new System.Windows.Forms.Button();
            this.labelAlarmH = new System.Windows.Forms.Label();
            this.buttonRead = new System.Windows.Forms.Button();
            this.panelConnection = new System.Windows.Forms.Panel();
            this.comboBoxMCU = new System.Windows.Forms.ComboBox();
            this.labelMCU = new System.Windows.Forms.Label();
            this.label_DAU = new System.Windows.Forms.Label();
            this.label_RDC = new System.Windows.Forms.Label();
            this.comboBoxDAU = new System.Windows.Forms.ComboBox();
            this.comboBoxRDC = new System.Windows.Forms.ComboBox();
            this.labelConPanel = new System.Windows.Forms.Label();
            this.textBoxConnection = new System.Windows.Forms.TextBox();
            this.comboBoxComPort = new System.Windows.Forms.ComboBox();
            this.comboBoxBaudRate = new System.Windows.Forms.ComboBox();
            this.buttonConnect = new System.Windows.Forms.Button();
            this.buttonDisconnect = new System.Windows.Forms.Button();
            this.labelComPort = new System.Windows.Forms.Label();
            this.labelBaudRate = new System.Windows.Forms.Label();
            this.labelConnection = new System.Windows.Forms.Label();
            this.tabPageMonitoring = new System.Windows.Forms.TabPage();
            this.comboBoxDAU_Monitor = new System.Windows.Forms.ComboBox();
            this.buttonSaveData = new System.Windows.Forms.Button();
            this.chartScaled = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.labelIStatus = new System.Windows.Forms.Label();
            this.textBoxIStatus = new System.Windows.Forms.TextBox();
            this.labelScaled = new System.Windows.Forms.Label();
            this.labelRaw = new System.Windows.Forms.Label();
            this.pictureBoxSignalStatus = new System.Windows.Forms.PictureBox();
            this.listBoxScaled = new System.Windows.Forms.ListBox();
            this.listBoxRaw = new System.Windows.Forms.ListBox();
            this.labelSensorData = new System.Windows.Forms.Label();
            this.textBoxSensorData = new System.Windows.Forms.TextBox();
            this.checkBoxSignalRaw = new System.Windows.Forms.CheckBox();
            this.buttonStop = new System.Windows.Forms.Button();
            this.buttonStart = new System.Windows.Forms.Button();
            this.chartRaw = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.timerConnection = new System.Windows.Forms.Timer(this.components);
            this.timerSend = new System.Windows.Forms.Timer(this.components);
            this.timerReceive = new System.Windows.Forms.Timer(this.components);
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.comboBoxName_Tag = new System.Windows.Forms.ComboBox();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPageConnection.SuspendLayout();
            this.panelConfiguration.SuspendLayout();
            this.panelConnection.SuspendLayout();
            this.tabPageMonitoring.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartScaled)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSignalStatus)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartRaw)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItemFile,
            this.toolStripMenuItemSettings,
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
            this.toolStripMenuItemOpen.Enabled = false;
            this.toolStripMenuItemOpen.Name = "toolStripMenuItemOpen";
            this.toolStripMenuItemOpen.Size = new System.Drawing.Size(162, 22);
            this.toolStripMenuItemOpen.Text = "&Load Config";
            this.toolStripMenuItemOpen.Visible = false;
            this.toolStripMenuItemOpen.Click += new System.EventHandler(this.toolStripMenuItemOpen_Click);
            // 
            // toolStripMenuItemSave
            // 
            this.toolStripMenuItemSave.Enabled = false;
            this.toolStripMenuItemSave.Name = "toolStripMenuItemSave";
            this.toolStripMenuItemSave.Size = new System.Drawing.Size(162, 22);
            this.toolStripMenuItemSave.Text = "&Save Config";
            this.toolStripMenuItemSave.Visible = false;
            this.toolStripMenuItemSave.Click += new System.EventHandler(this.toolStripMenuItemSave_Click);
            // 
            // toolStripMenuItemSaveAs
            // 
            this.toolStripMenuItemSaveAs.Enabled = false;
            this.toolStripMenuItemSaveAs.Name = "toolStripMenuItemSaveAs";
            this.toolStripMenuItemSaveAs.Size = new System.Drawing.Size(162, 22);
            this.toolStripMenuItemSaveAs.Text = "Save Config &As...";
            this.toolStripMenuItemSaveAs.Visible = false;
            this.toolStripMenuItemSaveAs.Click += new System.EventHandler(this.toolStripMenuItemSaveAs_Click);
            // 
            // toolStripMenuItemExit
            // 
            this.toolStripMenuItemExit.Name = "toolStripMenuItemExit";
            this.toolStripMenuItemExit.Size = new System.Drawing.Size(162, 22);
            this.toolStripMenuItemExit.Text = "E&xit";
            this.toolStripMenuItemExit.Click += new System.EventHandler(this.toolStripMenuItemExit_Click);
            // 
            // toolStripMenuItemSettings
            // 
            this.toolStripMenuItemSettings.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItemDefaultConfig});
            this.toolStripMenuItemSettings.Name = "toolStripMenuItemSettings";
            this.toolStripMenuItemSettings.Size = new System.Drawing.Size(61, 20);
            this.toolStripMenuItemSettings.Text = "Se&ttings";
            // 
            // toolStripMenuItemDefaultConfig
            // 
            this.toolStripMenuItemDefaultConfig.Name = "toolStripMenuItemDefaultConfig";
            this.toolStripMenuItemDefaultConfig.Size = new System.Drawing.Size(195, 22);
            this.toolStripMenuItemDefaultConfig.Text = "Change &Default Config";
            this.toolStripMenuItemDefaultConfig.Click += new System.EventHandler(this.toolStripMenuItemDefaultConfig_Click);
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
            this.toolStripMenuItemAbout.Size = new System.Drawing.Size(107, 22);
            this.toolStripMenuItemAbout.Text = "&About";
            this.toolStripMenuItemAbout.Click += new System.EventHandler(this.toolStripMenuItemAbout_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.toolStripStatusLabelConnection,
            this.toolStripProgressBarConnection,
            this.toolStripStatusLabelMonitoring,
            this.toolStripStatusLabelMStaus});
            this.statusStrip1.Location = new System.Drawing.Point(0, 431);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(800, 22);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(73, 17);
            this.toolStripStatusLabel1.Text = "COM Status:";
            // 
            // toolStripStatusLabelConnection
            // 
            this.toolStripStatusLabelConnection.Name = "toolStripStatusLabelConnection";
            this.toolStripStatusLabelConnection.Size = new System.Drawing.Size(79, 17);
            this.toolStripStatusLabelConnection.Text = "Disconnected";
            // 
            // toolStripProgressBarConnection
            // 
            this.toolStripProgressBarConnection.Name = "toolStripProgressBarConnection";
            this.toolStripProgressBarConnection.Size = new System.Drawing.Size(100, 16);
            // 
            // toolStripStatusLabelMonitoring
            // 
            this.toolStripStatusLabelMonitoring.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.toolStripStatusLabelMonitoring.Name = "toolStripStatusLabelMonitoring";
            this.toolStripStatusLabelMonitoring.Size = new System.Drawing.Size(129, 17);
            this.toolStripStatusLabelMonitoring.Text = "        Monitoring Status:";
            this.toolStripStatusLabelMonitoring.Visible = false;
            // 
            // toolStripStatusLabelMStaus
            // 
            this.toolStripStatusLabelMStaus.Name = "toolStripStatusLabelMStaus";
            this.toolStripStatusLabelMStaus.Size = new System.Drawing.Size(32, 17);
            this.toolStripStatusLabelMStaus.Text = "_____";
            this.toolStripStatusLabelMStaus.Visible = false;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPageConnection);
            this.tabControl1.Controls.Add(this.tabPageMonitoring);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 24);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(800, 407);
            this.tabControl1.TabIndex = 2;
            // 
            // tabPageConnection
            // 
            this.tabPageConnection.Controls.Add(this.panelConfiguration);
            this.tabPageConnection.Controls.Add(this.panelConnection);
            this.tabPageConnection.Location = new System.Drawing.Point(4, 22);
            this.tabPageConnection.Name = "tabPageConnection";
            this.tabPageConnection.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageConnection.Size = new System.Drawing.Size(792, 381);
            this.tabPageConnection.TabIndex = 0;
            this.tabPageConnection.Text = "Connection & Configuration";
            this.tabPageConnection.UseVisualStyleBackColor = true;
            // 
            // panelConfiguration
            // 
            this.panelConfiguration.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panelConfiguration.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelConfiguration.Controls.Add(this.comboBoxName_Tag);
            this.panelConfiguration.Controls.Add(this.labelInput);
            this.panelConfiguration.Controls.Add(this.labelConfPanel);
            this.panelConfiguration.Controls.Add(this.textBoxCAlarmL);
            this.panelConfiguration.Controls.Add(this.textBoxName);
            this.panelConfiguration.Controls.Add(this.buttonLoad);
            this.panelConfiguration.Controls.Add(this.textBoxLRV);
            this.panelConfiguration.Controls.Add(this.textBoxCAlarmH);
            this.panelConfiguration.Controls.Add(this.textBoxURV);
            this.panelConfiguration.Controls.Add(this.textBoxAlarmL);
            this.panelConfiguration.Controls.Add(this.textBoxCURV);
            this.panelConfiguration.Controls.Add(this.textBoxAlarmH);
            this.panelConfiguration.Controls.Add(this.textBoxCLRV);
            this.panelConfiguration.Controls.Add(this.labelName);
            this.panelConfiguration.Controls.Add(this.textBoxCName);
            this.panelConfiguration.Controls.Add(this.labelLRV);
            this.panelConfiguration.Controls.Add(this.labelCurrenConfig);
            this.panelConfiguration.Controls.Add(this.labelURV);
            this.panelConfiguration.Controls.Add(this.buttonWrite);
            this.panelConfiguration.Controls.Add(this.labelAlarmL);
            this.panelConfiguration.Controls.Add(this.buttonSave);
            this.panelConfiguration.Controls.Add(this.labelAlarmH);
            this.panelConfiguration.Controls.Add(this.buttonRead);
            this.panelConfiguration.Location = new System.Drawing.Point(350, 6);
            this.panelConfiguration.Name = "panelConfiguration";
            this.panelConfiguration.Size = new System.Drawing.Size(380, 363);
            this.panelConfiguration.TabIndex = 45;
            // 
            // labelInput
            // 
            this.labelInput.AutoSize = true;
            this.labelInput.Location = new System.Drawing.Point(233, 71);
            this.labelInput.Name = "labelInput";
            this.labelInput.Size = new System.Drawing.Size(67, 13);
            this.labelInput.TabIndex = 44;
            this.labelInput.Text = "Config. Input";
            // 
            // labelConfPanel
            // 
            this.labelConfPanel.AutoSize = true;
            this.labelConfPanel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelConfPanel.Location = new System.Drawing.Point(11, 20);
            this.labelConfPanel.Name = "labelConfPanel";
            this.labelConfPanel.Size = new System.Drawing.Size(121, 20);
            this.labelConfPanel.TabIndex = 8;
            this.labelConfPanel.Text = "Configuration";
            // 
            // textBoxCAlarmL
            // 
            this.textBoxCAlarmL.Location = new System.Drawing.Point(128, 165);
            this.textBoxCAlarmL.Name = "textBoxCAlarmL";
            this.textBoxCAlarmL.ReadOnly = true;
            this.textBoxCAlarmL.Size = new System.Drawing.Size(100, 20);
            this.textBoxCAlarmL.TabIndex = 42;
            this.textBoxCAlarmL.TabStop = false;
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(234, 87);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(100, 20);
            this.textBoxName.TabIndex = 24;
            this.textBoxName.Text = "C385IT001";
            this.textBoxName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxName_KeyPress);
            this.textBoxName.MouseHover += new System.EventHandler(this.textBoxName_MouseHover);
            // 
            // buttonLoad
            // 
            this.buttonLoad.Enabled = false;
            this.buttonLoad.Location = new System.Drawing.Point(234, 217);
            this.buttonLoad.Name = "buttonLoad";
            this.buttonLoad.Size = new System.Drawing.Size(100, 23);
            this.buttonLoad.TabIndex = 32;
            this.buttonLoad.Text = "&Load";
            this.buttonLoad.UseVisualStyleBackColor = true;
            this.buttonLoad.Visible = false;
            this.buttonLoad.Click += new System.EventHandler(this.toolStripMenuItemOpen_Click);
            this.buttonLoad.MouseHover += new System.EventHandler(this.buttonLoad_MouseHover);
            // 
            // textBoxLRV
            // 
            this.textBoxLRV.Location = new System.Drawing.Point(234, 113);
            this.textBoxLRV.Name = "textBoxLRV";
            this.textBoxLRV.Size = new System.Drawing.Size(100, 20);
            this.textBoxLRV.TabIndex = 25;
            this.textBoxLRV.Text = "0.0";
            this.textBoxLRV.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxLRV_KeyPress);
            this.textBoxLRV.MouseHover += new System.EventHandler(this.textBoxLRV_MouseHover);
            // 
            // textBoxCAlarmH
            // 
            this.textBoxCAlarmH.Location = new System.Drawing.Point(128, 191);
            this.textBoxCAlarmH.Name = "textBoxCAlarmH";
            this.textBoxCAlarmH.ReadOnly = true;
            this.textBoxCAlarmH.Size = new System.Drawing.Size(100, 20);
            this.textBoxCAlarmH.TabIndex = 43;
            this.textBoxCAlarmH.TabStop = false;
            // 
            // textBoxURV
            // 
            this.textBoxURV.Location = new System.Drawing.Point(234, 139);
            this.textBoxURV.Name = "textBoxURV";
            this.textBoxURV.Size = new System.Drawing.Size(100, 20);
            this.textBoxURV.TabIndex = 26;
            this.textBoxURV.Text = "500.0";
            this.textBoxURV.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxLRV_KeyPress);
            this.textBoxURV.MouseHover += new System.EventHandler(this.textBoxURV_MouseHover);
            // 
            // textBoxAlarmL
            // 
            this.textBoxAlarmL.Location = new System.Drawing.Point(234, 165);
            this.textBoxAlarmL.Name = "textBoxAlarmL";
            this.textBoxAlarmL.Size = new System.Drawing.Size(100, 20);
            this.textBoxAlarmL.TabIndex = 27;
            this.textBoxAlarmL.Text = "40";
            this.textBoxAlarmL.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxAlarmL_KeyPress);
            this.textBoxAlarmL.MouseHover += new System.EventHandler(this.textBoxAlarmL_MouseHover);
            // 
            // textBoxCURV
            // 
            this.textBoxCURV.Location = new System.Drawing.Point(128, 139);
            this.textBoxCURV.Name = "textBoxCURV";
            this.textBoxCURV.ReadOnly = true;
            this.textBoxCURV.Size = new System.Drawing.Size(100, 20);
            this.textBoxCURV.TabIndex = 41;
            this.textBoxCURV.TabStop = false;
            // 
            // textBoxAlarmH
            // 
            this.textBoxAlarmH.Location = new System.Drawing.Point(234, 191);
            this.textBoxAlarmH.Name = "textBoxAlarmH";
            this.textBoxAlarmH.Size = new System.Drawing.Size(100, 20);
            this.textBoxAlarmH.TabIndex = 28;
            this.textBoxAlarmH.Text = "440";
            this.textBoxAlarmH.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxAlarmL_KeyPress);
            this.textBoxAlarmH.MouseHover += new System.EventHandler(this.textBoxAlarmH_MouseHover);
            // 
            // textBoxCLRV
            // 
            this.textBoxCLRV.Location = new System.Drawing.Point(128, 113);
            this.textBoxCLRV.Name = "textBoxCLRV";
            this.textBoxCLRV.ReadOnly = true;
            this.textBoxCLRV.Size = new System.Drawing.Size(100, 20);
            this.textBoxCLRV.TabIndex = 40;
            this.textBoxCLRV.TabStop = false;
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(12, 90);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(35, 13);
            this.labelName.TabIndex = 29;
            this.labelName.Text = "Name";
            // 
            // textBoxCName
            // 
            this.textBoxCName.Location = new System.Drawing.Point(128, 87);
            this.textBoxCName.Name = "textBoxCName";
            this.textBoxCName.ReadOnly = true;
            this.textBoxCName.Size = new System.Drawing.Size(100, 20);
            this.textBoxCName.TabIndex = 39;
            this.textBoxCName.TabStop = false;
            // 
            // labelLRV
            // 
            this.labelLRV.AutoSize = true;
            this.labelLRV.Location = new System.Drawing.Point(12, 116);
            this.labelLRV.Name = "labelLRV";
            this.labelLRV.Size = new System.Drawing.Size(95, 13);
            this.labelLRV.TabIndex = 31;
            this.labelLRV.Text = "Lower Rage Value";
            // 
            // labelCurrenConfig
            // 
            this.labelCurrenConfig.AutoSize = true;
            this.labelCurrenConfig.Location = new System.Drawing.Point(125, 71);
            this.labelCurrenConfig.Name = "labelCurrenConfig";
            this.labelCurrenConfig.Size = new System.Drawing.Size(102, 13);
            this.labelCurrenConfig.TabIndex = 38;
            this.labelCurrenConfig.Text = "Online Configuration";
            // 
            // labelURV
            // 
            this.labelURV.AutoSize = true;
            this.labelURV.Location = new System.Drawing.Point(12, 142);
            this.labelURV.Name = "labelURV";
            this.labelURV.Size = new System.Drawing.Size(101, 13);
            this.labelURV.TabIndex = 34;
            this.labelURV.Text = "Upper Range Value";
            // 
            // buttonWrite
            // 
            this.buttonWrite.Enabled = false;
            this.buttonWrite.Location = new System.Drawing.Point(128, 246);
            this.buttonWrite.Name = "buttonWrite";
            this.buttonWrite.Size = new System.Drawing.Size(100, 23);
            this.buttonWrite.TabIndex = 33;
            this.buttonWrite.Text = "&Write";
            this.buttonWrite.UseVisualStyleBackColor = true;
            this.buttonWrite.Click += new System.EventHandler(this.buttonWrite_Click);
            this.buttonWrite.MouseHover += new System.EventHandler(this.buttonWrite_MouseHover);
            // 
            // labelAlarmL
            // 
            this.labelAlarmL.AutoSize = true;
            this.labelAlarmL.Location = new System.Drawing.Point(12, 168);
            this.labelAlarmL.Name = "labelAlarmL";
            this.labelAlarmL.Size = new System.Drawing.Size(56, 13);
            this.labelAlarmL.TabIndex = 36;
            this.labelAlarmL.Text = "Alarm Low";
            // 
            // buttonSave
            // 
            this.buttonSave.Enabled = false;
            this.buttonSave.Location = new System.Drawing.Point(234, 246);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(100, 23);
            this.buttonSave.TabIndex = 35;
            this.buttonSave.Text = "&Save";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Visible = false;
            this.buttonSave.Click += new System.EventHandler(this.toolStripMenuItemSaveAs_Click);
            this.buttonSave.MouseHover += new System.EventHandler(this.buttonSave_MouseHover);
            // 
            // labelAlarmH
            // 
            this.labelAlarmH.AutoSize = true;
            this.labelAlarmH.Location = new System.Drawing.Point(12, 194);
            this.labelAlarmH.Name = "labelAlarmH";
            this.labelAlarmH.Size = new System.Drawing.Size(58, 13);
            this.labelAlarmH.TabIndex = 37;
            this.labelAlarmH.Text = "Alarm High";
            // 
            // buttonRead
            // 
            this.buttonRead.Enabled = false;
            this.buttonRead.Location = new System.Drawing.Point(128, 217);
            this.buttonRead.Name = "buttonRead";
            this.buttonRead.Size = new System.Drawing.Size(100, 23);
            this.buttonRead.TabIndex = 30;
            this.buttonRead.Text = "&Read";
            this.buttonRead.UseVisualStyleBackColor = true;
            this.buttonRead.Click += new System.EventHandler(this.buttonRead_Click);
            this.buttonRead.MouseHover += new System.EventHandler(this.buttonRead_MouseHover);
            // 
            // panelConnection
            // 
            this.panelConnection.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panelConnection.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelConnection.Controls.Add(this.comboBoxMCU);
            this.panelConnection.Controls.Add(this.labelMCU);
            this.panelConnection.Controls.Add(this.label_DAU);
            this.panelConnection.Controls.Add(this.label_RDC);
            this.panelConnection.Controls.Add(this.comboBoxDAU);
            this.panelConnection.Controls.Add(this.comboBoxRDC);
            this.panelConnection.Controls.Add(this.labelConPanel);
            this.panelConnection.Controls.Add(this.textBoxConnection);
            this.panelConnection.Controls.Add(this.comboBoxComPort);
            this.panelConnection.Controls.Add(this.comboBoxBaudRate);
            this.panelConnection.Controls.Add(this.buttonConnect);
            this.panelConnection.Controls.Add(this.buttonDisconnect);
            this.panelConnection.Controls.Add(this.labelComPort);
            this.panelConnection.Controls.Add(this.labelBaudRate);
            this.panelConnection.Controls.Add(this.labelConnection);
            this.panelConnection.Location = new System.Drawing.Point(47, 6);
            this.panelConnection.Name = "panelConnection";
            this.panelConnection.Size = new System.Drawing.Size(236, 366);
            this.panelConnection.TabIndex = 44;
            // 
            // comboBoxMCU
            // 
            this.comboBoxMCU.FormattingEnabled = true;
            this.comboBoxMCU.Location = new System.Drawing.Point(90, 71);
            this.comboBoxMCU.Name = "comboBoxMCU";
            this.comboBoxMCU.Size = new System.Drawing.Size(121, 21);
            this.comboBoxMCU.TabIndex = 13;
            this.comboBoxMCU.SelectedIndexChanged += new System.EventHandler(this.comboBoxMCU_SelectedIndexChanged);
            this.comboBoxMCU.Enter += new System.EventHandler(this.comboBoxMCU_Enter);
            // 
            // labelMCU
            // 
            this.labelMCU.AutoSize = true;
            this.labelMCU.Location = new System.Drawing.Point(16, 74);
            this.labelMCU.Name = "labelMCU";
            this.labelMCU.Size = new System.Drawing.Size(31, 13);
            this.labelMCU.TabIndex = 12;
            this.labelMCU.Text = "MCU";
            // 
            // label_DAU
            // 
            this.label_DAU.AutoSize = true;
            this.label_DAU.Location = new System.Drawing.Point(16, 127);
            this.label_DAU.Name = "label_DAU";
            this.label_DAU.Size = new System.Drawing.Size(30, 13);
            this.label_DAU.TabIndex = 11;
            this.label_DAU.Text = "DAU";
            // 
            // label_RDC
            // 
            this.label_RDC.AutoSize = true;
            this.label_RDC.Location = new System.Drawing.Point(16, 100);
            this.label_RDC.Name = "label_RDC";
            this.label_RDC.Size = new System.Drawing.Size(33, 13);
            this.label_RDC.TabIndex = 10;
            this.label_RDC.Text = "RDC ";
            // 
            // comboBoxDAU
            // 
            this.comboBoxDAU.FormattingEnabled = true;
            this.comboBoxDAU.Location = new System.Drawing.Point(90, 124);
            this.comboBoxDAU.Name = "comboBoxDAU";
            this.comboBoxDAU.Size = new System.Drawing.Size(121, 21);
            this.comboBoxDAU.TabIndex = 9;
            this.comboBoxDAU.SelectedIndexChanged += new System.EventHandler(this.comboBoxDAU_SelectedIndexChanged);
            this.comboBoxDAU.Enter += new System.EventHandler(this.comboBoxDAU_Enter);
            // 
            // comboBoxRDC
            // 
            this.comboBoxRDC.FormattingEnabled = true;
            this.comboBoxRDC.Location = new System.Drawing.Point(90, 97);
            this.comboBoxRDC.Name = "comboBoxRDC";
            this.comboBoxRDC.Size = new System.Drawing.Size(121, 21);
            this.comboBoxRDC.TabIndex = 8;
            this.comboBoxRDC.SelectedIndexChanged += new System.EventHandler(this.comboBoxRDC_SelectedIndexChanged);
            this.comboBoxRDC.Enter += new System.EventHandler(this.comboBoxRDC_Enter);
            // 
            // labelConPanel
            // 
            this.labelConPanel.AutoSize = true;
            this.labelConPanel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelConPanel.Location = new System.Drawing.Point(7, 17);
            this.labelConPanel.Name = "labelConPanel";
            this.labelConPanel.Size = new System.Drawing.Size(103, 20);
            this.labelConPanel.TabIndex = 0;
            this.labelConPanel.Text = "Connection";
            // 
            // textBoxConnection
            // 
            this.textBoxConnection.Location = new System.Drawing.Point(90, 207);
            this.textBoxConnection.Name = "textBoxConnection";
            this.textBoxConnection.ReadOnly = true;
            this.textBoxConnection.Size = new System.Drawing.Size(121, 20);
            this.textBoxConnection.TabIndex = 7;
            this.textBoxConnection.TabStop = false;
            this.textBoxConnection.Text = "Disconnected";
            // 
            // comboBoxComPort
            // 
            this.comboBoxComPort.FormattingEnabled = true;
            this.comboBoxComPort.Location = new System.Drawing.Point(90, 153);
            this.comboBoxComPort.Name = "comboBoxComPort";
            this.comboBoxComPort.Size = new System.Drawing.Size(121, 21);
            this.comboBoxComPort.TabIndex = 0;
            this.comboBoxComPort.Enter += new System.EventHandler(this.comboBoxComPort_Enter);
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
            "14400",
            "19200",
            "38400",
            "57600",
            "128000",
            "256000"});
            this.comboBoxBaudRate.Location = new System.Drawing.Point(90, 180);
            this.comboBoxBaudRate.Name = "comboBoxBaudRate";
            this.comboBoxBaudRate.Size = new System.Drawing.Size(121, 21);
            this.comboBoxBaudRate.TabIndex = 1;
            this.comboBoxBaudRate.Text = "9600";
            this.comboBoxBaudRate.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxAlarmL_KeyPress);
            // 
            // buttonConnect
            // 
            this.buttonConnect.Location = new System.Drawing.Point(136, 233);
            this.buttonConnect.Name = "buttonConnect";
            this.buttonConnect.Size = new System.Drawing.Size(75, 23);
            this.buttonConnect.TabIndex = 2;
            this.buttonConnect.Text = "&Connect";
            this.buttonConnect.UseVisualStyleBackColor = true;
            this.buttonConnect.Click += new System.EventHandler(this.buttonConnect_Click);
            this.buttonConnect.MouseHover += new System.EventHandler(this.buttonConnect_MouseHover);
            // 
            // buttonDisconnect
            // 
            this.buttonDisconnect.Enabled = false;
            this.buttonDisconnect.Location = new System.Drawing.Point(136, 262);
            this.buttonDisconnect.Name = "buttonDisconnect";
            this.buttonDisconnect.Size = new System.Drawing.Size(75, 23);
            this.buttonDisconnect.TabIndex = 3;
            this.buttonDisconnect.Text = "&Disconnect";
            this.buttonDisconnect.UseVisualStyleBackColor = true;
            this.buttonDisconnect.Click += new System.EventHandler(this.buttonDisconnect_Click);
            this.buttonDisconnect.MouseHover += new System.EventHandler(this.buttonDisconnect_MouseHover);
            // 
            // labelComPort
            // 
            this.labelComPort.AutoSize = true;
            this.labelComPort.Location = new System.Drawing.Point(16, 156);
            this.labelComPort.Name = "labelComPort";
            this.labelComPort.Size = new System.Drawing.Size(56, 13);
            this.labelComPort.TabIndex = 4;
            this.labelComPort.Text = "COM Port ";
            // 
            // labelBaudRate
            // 
            this.labelBaudRate.AutoSize = true;
            this.labelBaudRate.Location = new System.Drawing.Point(16, 183);
            this.labelBaudRate.Name = "labelBaudRate";
            this.labelBaudRate.Size = new System.Drawing.Size(61, 13);
            this.labelBaudRate.TabIndex = 5;
            this.labelBaudRate.Text = "Baud Rate ";
            // 
            // labelConnection
            // 
            this.labelConnection.AutoSize = true;
            this.labelConnection.Location = new System.Drawing.Point(16, 210);
            this.labelConnection.Name = "labelConnection";
            this.labelConnection.Size = new System.Drawing.Size(40, 13);
            this.labelConnection.TabIndex = 6;
            this.labelConnection.Text = "Status ";
            // 
            // tabPageMonitoring
            // 
            this.tabPageMonitoring.Controls.Add(this.comboBoxDAU_Monitor);
            this.tabPageMonitoring.Controls.Add(this.buttonSaveData);
            this.tabPageMonitoring.Controls.Add(this.chartScaled);
            this.tabPageMonitoring.Controls.Add(this.labelIStatus);
            this.tabPageMonitoring.Controls.Add(this.textBoxIStatus);
            this.tabPageMonitoring.Controls.Add(this.labelScaled);
            this.tabPageMonitoring.Controls.Add(this.labelRaw);
            this.tabPageMonitoring.Controls.Add(this.pictureBoxSignalStatus);
            this.tabPageMonitoring.Controls.Add(this.listBoxScaled);
            this.tabPageMonitoring.Controls.Add(this.listBoxRaw);
            this.tabPageMonitoring.Controls.Add(this.labelSensorData);
            this.tabPageMonitoring.Controls.Add(this.textBoxSensorData);
            this.tabPageMonitoring.Controls.Add(this.checkBoxSignalRaw);
            this.tabPageMonitoring.Controls.Add(this.buttonStop);
            this.tabPageMonitoring.Controls.Add(this.buttonStart);
            this.tabPageMonitoring.Controls.Add(this.chartRaw);
            this.tabPageMonitoring.Location = new System.Drawing.Point(4, 22);
            this.tabPageMonitoring.Name = "tabPageMonitoring";
            this.tabPageMonitoring.Size = new System.Drawing.Size(792, 381);
            this.tabPageMonitoring.TabIndex = 2;
            this.tabPageMonitoring.Text = "Monitoring";
            this.tabPageMonitoring.UseVisualStyleBackColor = true;
            this.tabPageMonitoring.Enter += new System.EventHandler(this.tabPageMonitoring_Enter);
            // 
            // comboBoxDAU_Monitor
            // 
            this.comboBoxDAU_Monitor.FormattingEnabled = true;
            this.comboBoxDAU_Monitor.Location = new System.Drawing.Point(3, 17);
            this.comboBoxDAU_Monitor.Name = "comboBoxDAU_Monitor";
            this.comboBoxDAU_Monitor.Size = new System.Drawing.Size(121, 21);
            this.comboBoxDAU_Monitor.TabIndex = 18;
            // 
            // buttonSaveData
            // 
            this.buttonSaveData.Enabled = false;
            this.buttonSaveData.Location = new System.Drawing.Point(3, 354);
            this.buttonSaveData.Name = "buttonSaveData";
            this.buttonSaveData.Size = new System.Drawing.Size(121, 23);
            this.buttonSaveData.TabIndex = 17;
            this.buttonSaveData.Text = "Save";
            this.buttonSaveData.UseVisualStyleBackColor = true;
            this.buttonSaveData.Visible = false;
            this.buttonSaveData.Click += new System.EventHandler(this.buttonSaveData_Click);
            this.buttonSaveData.MouseHover += new System.EventHandler(this.buttonSaveData_MouseHover);
            // 
            // chartScaled
            // 
            chartArea1.AxisX.Title = "Time";
            chartArea1.AxisY.Title = "Lux";
            chartArea1.Name = "ChartArea1";
            this.chartScaled.ChartAreas.Add(chartArea1);
            this.chartScaled.Enabled = false;
            legend1.Name = "Legend1";
            this.chartScaled.Legends.Add(legend1);
            this.chartScaled.Location = new System.Drawing.Point(133, 44);
            this.chartScaled.Name = "chartScaled";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series1.Legend = "Legend1";
            series1.LegendText = "Scaled";
            series1.Name = "Scaled";
            this.chartScaled.Series.Add(series1);
            this.chartScaled.Size = new System.Drawing.Size(663, 337);
            this.chartScaled.TabIndex = 15;
            this.chartScaled.TabStop = false;
            this.chartScaled.Text = "chart2";
            title1.Name = "TitleScaled";
            title1.Text = "Scaled Sensor Data";
            this.chartScaled.Titles.Add(title1);
            // 
            // labelIStatus
            // 
            this.labelIStatus.AutoSize = true;
            this.labelIStatus.Location = new System.Drawing.Point(5, 119);
            this.labelIStatus.Name = "labelIStatus";
            this.labelIStatus.Size = new System.Drawing.Size(95, 13);
            this.labelIStatus.TabIndex = 14;
            this.labelIStatus.Text = "Instrument Status :";
            // 
            // textBoxIStatus
            // 
            this.textBoxIStatus.BackColor = System.Drawing.SystemColors.Window;
            this.textBoxIStatus.ForeColor = System.Drawing.SystemColors.WindowText;
            this.textBoxIStatus.Location = new System.Drawing.Point(3, 135);
            this.textBoxIStatus.Name = "textBoxIStatus";
            this.textBoxIStatus.ReadOnly = true;
            this.textBoxIStatus.Size = new System.Drawing.Size(121, 20);
            this.textBoxIStatus.TabIndex = 13;
            this.textBoxIStatus.TabStop = false;
            this.textBoxIStatus.Text = "-";
            // 
            // labelScaled
            // 
            this.labelScaled.AutoSize = true;
            this.labelScaled.Location = new System.Drawing.Point(5, 224);
            this.labelScaled.Name = "labelScaled";
            this.labelScaled.Size = new System.Drawing.Size(40, 13);
            this.labelScaled.TabIndex = 9;
            this.labelScaled.Text = "Scaled";
            // 
            // labelRaw
            // 
            this.labelRaw.AutoSize = true;
            this.labelRaw.Location = new System.Drawing.Point(5, 224);
            this.labelRaw.Name = "labelRaw";
            this.labelRaw.Size = new System.Drawing.Size(29, 13);
            this.labelRaw.TabIndex = 8;
            this.labelRaw.Text = "Raw";
            this.labelRaw.Visible = false;
            // 
            // pictureBoxSignalStatus
            // 
            this.pictureBoxSignalStatus.ErrorImage = global::SoftSensConf.Properties.Resources.StatusCriticalError_16x;
            this.pictureBoxSignalStatus.Image = global::SoftSensConf.Properties.Resources.StatusOffline_16x;
            this.pictureBoxSignalStatus.InitialImage = global::SoftSensConf.Properties.Resources.StatusOK_16x;
            this.pictureBoxSignalStatus.Location = new System.Drawing.Point(106, 119);
            this.pictureBoxSignalStatus.Name = "pictureBoxSignalStatus";
            this.pictureBoxSignalStatus.Size = new System.Drawing.Size(21, 16);
            this.pictureBoxSignalStatus.TabIndex = 16;
            this.pictureBoxSignalStatus.TabStop = false;
            // 
            // listBoxScaled
            // 
            this.listBoxScaled.FormattingEnabled = true;
            this.listBoxScaled.Location = new System.Drawing.Point(3, 240);
            this.listBoxScaled.Name = "listBoxScaled";
            this.listBoxScaled.Size = new System.Drawing.Size(121, 108);
            this.listBoxScaled.TabIndex = 7;
            this.listBoxScaled.TabStop = false;
            // 
            // listBoxRaw
            // 
            this.listBoxRaw.FormattingEnabled = true;
            this.listBoxRaw.Location = new System.Drawing.Point(3, 240);
            this.listBoxRaw.Name = "listBoxRaw";
            this.listBoxRaw.Size = new System.Drawing.Size(121, 108);
            this.listBoxRaw.TabIndex = 6;
            this.listBoxRaw.TabStop = false;
            this.listBoxRaw.Visible = false;
            // 
            // labelSensorData
            // 
            this.labelSensorData.AutoSize = true;
            this.labelSensorData.Location = new System.Drawing.Point(3, 158);
            this.labelSensorData.Name = "labelSensorData";
            this.labelSensorData.Size = new System.Drawing.Size(64, 13);
            this.labelSensorData.TabIndex = 5;
            this.labelSensorData.Text = "Sensor data";
            // 
            // textBoxSensorData
            // 
            this.textBoxSensorData.Location = new System.Drawing.Point(3, 174);
            this.textBoxSensorData.Multiline = true;
            this.textBoxSensorData.Name = "textBoxSensorData";
            this.textBoxSensorData.ReadOnly = true;
            this.textBoxSensorData.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxSensorData.Size = new System.Drawing.Size(121, 47);
            this.textBoxSensorData.TabIndex = 4;
            this.textBoxSensorData.TabStop = false;
            // 
            // checkBoxSignalRaw
            // 
            this.checkBoxSignalRaw.AutoSize = true;
            this.checkBoxSignalRaw.Location = new System.Drawing.Point(3, 102);
            this.checkBoxSignalRaw.Name = "checkBoxSignalRaw";
            this.checkBoxSignalRaw.Size = new System.Drawing.Size(116, 17);
            this.checkBoxSignalRaw.TabIndex = 3;
            this.checkBoxSignalRaw.Text = "Raw Sensor Signal";
            this.checkBoxSignalRaw.UseVisualStyleBackColor = true;
            this.checkBoxSignalRaw.CheckedChanged += new System.EventHandler(this.checkBoxSignalRaw_CheckedChanged);
            this.checkBoxSignalRaw.MouseHover += new System.EventHandler(this.checkBoxSignalRaw_MouseHover);
            // 
            // buttonStop
            // 
            this.buttonStop.Enabled = false;
            this.buttonStop.Location = new System.Drawing.Point(3, 73);
            this.buttonStop.Name = "buttonStop";
            this.buttonStop.Size = new System.Drawing.Size(121, 23);
            this.buttonStop.TabIndex = 2;
            this.buttonStop.Text = "Stop";
            this.buttonStop.UseVisualStyleBackColor = true;
            this.buttonStop.Click += new System.EventHandler(this.buttonStop_Click);
            this.buttonStop.MouseHover += new System.EventHandler(this.buttonStop_MouseHover);
            // 
            // buttonStart
            // 
            this.buttonStart.Enabled = false;
            this.buttonStart.Location = new System.Drawing.Point(3, 44);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(121, 23);
            this.buttonStart.TabIndex = 1;
            this.buttonStart.Text = "Start ";
            this.buttonStart.UseVisualStyleBackColor = true;
            this.buttonStart.Click += new System.EventHandler(this.buttonStart_Click);
            this.buttonStart.MouseHover += new System.EventHandler(this.buttonStart_MouseHover);
            // 
            // chartRaw
            // 
            chartArea2.AxisX.Title = "Time";
            chartArea2.AxisY.Title = "Raw Data";
            chartArea2.Name = "ChartArea1";
            this.chartRaw.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chartRaw.Legends.Add(legend2);
            this.chartRaw.Location = new System.Drawing.Point(133, 44);
            this.chartRaw.Name = "chartRaw";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series2.Legend = "Legend1";
            series2.Name = "Raw";
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series3.Enabled = false;
            series3.Legend = "Legend1";
            series3.Name = "Scaled";
            this.chartRaw.Series.Add(series2);
            this.chartRaw.Series.Add(series3);
            this.chartRaw.Size = new System.Drawing.Size(659, 337);
            this.chartRaw.TabIndex = 0;
            this.chartRaw.TabStop = false;
            this.chartRaw.Text = "chart1";
            title2.Name = "TitleRawData";
            title2.Text = "Raw Sensor Data";
            this.chartRaw.Titles.Add(title2);
            this.chartRaw.Visible = false;
            // 
            // timerConnection
            // 
            this.timerConnection.Interval = 1000;
            this.timerConnection.Tick += new System.EventHandler(this.timerConnection_Tick);
            // 
            // timerSend
            // 
            this.timerSend.Interval = 300;
            this.timerSend.Tick += new System.EventHandler(this.timerSend_Tick);
            // 
            // timerReceive
            // 
            this.timerReceive.Interval = 700;
            this.timerReceive.Tick += new System.EventHandler(this.timerReceive_Tick);
            // 
            // comboBoxName_Tag
            // 
            this.comboBoxName_Tag.FormattingEnabled = true;
            this.comboBoxName_Tag.Location = new System.Drawing.Point(234, 86);
            this.comboBoxName_Tag.Name = "comboBoxName_Tag";
            this.comboBoxName_Tag.Size = new System.Drawing.Size(100, 21);
            this.comboBoxName_Tag.TabIndex = 45;
            this.comboBoxName_Tag.SelectedIndexChanged += new System.EventHandler(this.comboBoxName_Tag_SelectedIndexChanged);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 453);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(816, 492);
            this.MinimumSize = new System.Drawing.Size(816, 492);
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SoftSensConf";
            this.Activated += new System.EventHandler(this.FormMain_Activated);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormMain_FormClosing);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPageConnection.ResumeLayout(false);
            this.panelConfiguration.ResumeLayout(false);
            this.panelConfiguration.PerformLayout();
            this.panelConnection.ResumeLayout(false);
            this.panelConnection.PerformLayout();
            this.tabPageMonitoring.ResumeLayout(false);
            this.tabPageMonitoring.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartScaled)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSignalStatus)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartRaw)).EndInit();
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
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.Timer timerConnection;
        private System.Windows.Forms.Timer timerSend;
        private System.Windows.Forms.Timer timerReceive;
        private System.Windows.Forms.TabPage tabPageMonitoring;
        private System.Windows.Forms.Label labelSensorData;
        private System.Windows.Forms.TextBox textBoxSensorData;
        private System.Windows.Forms.CheckBox checkBoxSignalRaw;
        private System.Windows.Forms.Button buttonStop;
        private System.Windows.Forms.Button buttonStart;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartRaw;
        private System.Windows.Forms.Label labelScaled;
        private System.Windows.Forms.Label labelRaw;
        private System.Windows.Forms.ListBox listBoxScaled;
        private System.Windows.Forms.ListBox listBoxRaw;
        private System.Windows.Forms.Label labelIStatus;
        private System.Windows.Forms.TextBox textBoxIStatus;
        private System.Windows.Forms.Panel panelConfiguration;
        private System.Windows.Forms.Label labelConfPanel;
        private System.Windows.Forms.TextBox textBoxCAlarmL;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.Button buttonLoad;
        private System.Windows.Forms.TextBox textBoxLRV;
        private System.Windows.Forms.TextBox textBoxCAlarmH;
        private System.Windows.Forms.TextBox textBoxURV;
        private System.Windows.Forms.TextBox textBoxAlarmL;
        private System.Windows.Forms.TextBox textBoxCURV;
        private System.Windows.Forms.TextBox textBoxAlarmH;
        private System.Windows.Forms.TextBox textBoxCLRV;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.TextBox textBoxCName;
        private System.Windows.Forms.Label labelLRV;
        private System.Windows.Forms.Label labelCurrenConfig;
        private System.Windows.Forms.Label labelURV;
        private System.Windows.Forms.Button buttonWrite;
        private System.Windows.Forms.Label labelAlarmL;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Label labelAlarmH;
        private System.Windows.Forms.Button buttonRead;
        private System.Windows.Forms.Panel panelConnection;
        private System.Windows.Forms.Label labelConPanel;
        private System.Windows.Forms.TextBox textBoxConnection;
        private System.Windows.Forms.ComboBox comboBoxComPort;
        private System.Windows.Forms.ComboBox comboBoxBaudRate;
        private System.Windows.Forms.Button buttonConnect;
        private System.Windows.Forms.Button buttonDisconnect;
        private System.Windows.Forms.Label labelComPort;
        private System.Windows.Forms.Label labelBaudRate;
        private System.Windows.Forms.Label labelConnection;
        private System.Windows.Forms.Label labelInput;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartScaled;
        private System.Windows.Forms.PictureBox pictureBoxSignalStatus;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Button buttonSaveData;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemSettings;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemDefaultConfig;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelMonitoring;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelMStaus;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelConnection;
        private System.Windows.Forms.ComboBox comboBoxDAU_Monitor;
        private System.Windows.Forms.Label label_DAU;
        private System.Windows.Forms.Label label_RDC;
        private System.Windows.Forms.ComboBox comboBoxDAU;
        private System.Windows.Forms.ComboBox comboBoxRDC;
        private System.Windows.Forms.Label labelMCU;
        private System.Windows.Forms.ComboBox comboBoxMCU;
        private System.Windows.Forms.ComboBox comboBoxName_Tag;
    }
}

