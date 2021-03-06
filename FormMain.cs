﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;



namespace Arbeidskrav_1
{
    
    public partial class FormMain : Form
    {
        
        public FormMain()
        {
            InitializeComponent();
        }

        bool connected = false;
        string[] comPorts = System.IO.Ports.SerialPort.GetPortNames();
        string[] chartvalues = { };
        string indata = "";
        bool innit = false;
        bool readconf = false;
        bool writeconf = false;
        bool monitorStart = false;
        bool monitor = true;
        bool statuscheck = false;
        bool monitorRead = true;
        bool statusRead = true;
        string version = "1.0.1.3";
        
        double statusVal = 0;
        int statuscheckCounter = 0;
        int timeout = 0;
        int pointXValueRaw = 0;
        int pointXValueScaled = 0;
        public static string configPassword = "";
        public static bool cancel = false;
       

        //Disconnects serial port
        //Enables and disables bool values accordingly.
        void Disconnect(object sender, EventArgs e)
        {   
            
            serialPort1.Close();
            connected = false;
            textBoxConnection.Text = "Disconnected";          
            toolStripStatusLabelConnection.Text = "Disconnected";
            toolStripStatusLabelConnection.ForeColor = Color.Red;
            toolStripProgressBarConnection.Value = 0;
            timerConnection.Enabled = false;
            buttonRead.Enabled = false;
            buttonWrite.Enabled = false;
            buttonStart.Enabled = false;
            buttonStop.Enabled = false;
            buttonConnect.Enabled = true;
            buttonDisconnect.Enabled = false;
            timerReceive.Enabled = false;
            timerSend.Enabled = false;
            readconf = false;
            writeconf = false;
            textBoxCName.Text = "";
            textBoxCLRV.Text = "";
            textBoxCURV.Text = "";
            textBoxCAlarmL.Text = "";
            textBoxCAlarmH.Text = "";
            if (monitorStart)
                buttonStop_Click(sender,e);
        }

        //Checks if entered config values are valid
        bool ConfigCheck()
        {
            double fConVal = 0;
            int iConVal = 0;
            string message = "";
            string caption = "";
            MessageBoxButtons buttons = MessageBoxButtons.OK;
            MessageBoxIcon icon = MessageBoxIcon.Warning;
            DialogResult result;
            
            if (textBoxName.Text.Length > 10 || textBoxName.Text.Length == 0)
            {
                message = "Name is to Long (Maximum 10 characters)";
                caption = "Name is to Long";
                if (textBoxName.Text.Length == 0)
                {
                    message = "Enter Name (Maximum 10 characters)";
                    caption = "No Name";

                }
                result = MessageBox.Show(this, message, caption, buttons, icon);
                textBoxName.Focus();
                return  false;
            }
            else if (textBoxLRV.Text.Length == 0)
            {
                caption = "Empty Text Field";
                message = "Enter Low Range Value";
                result = MessageBox.Show(this, message, caption, buttons, icon);
                textBoxLRV.Focus();
                return  false;
            }
            else if (textBoxURV.Text.Length == 0)
            {
                caption = "Empty Text Field";
                message = "Enter Upper Range Value";
                result = MessageBox.Show(this, message, caption, buttons, icon);
                textBoxURV.Focus();
                return false;
            }
            else if (textBoxAlarmL.Text.Length == 0)
            {
                caption = "Empty Text Field";
                message = "Enter Alarm Low";
                result = MessageBox.Show(this, message, caption, buttons, icon);
                textBoxAlarmL.Focus();
                return false;
            }

            else if (textBoxAlarmH.Text.Length == 0)
            {
                caption = "Empty Text Field";
                message = "Enter Alarm High";
                result = MessageBox.Show(this, message, caption, buttons, icon);
                textBoxAlarmH.Focus();
                return false;
            }
            

            try
            {
                fConVal = Convert.ToSingle (textBoxLRV.Text);
            }
            catch (FormatException)
            {
                
                icon = MessageBoxIcon.Error;
                caption = "Format Error";
                message = "Invalid Value \n(Unable to Format string)";
                result = MessageBox.Show(this, message, caption, buttons, icon);
                textBoxLRV.Focus();
                return false;
            }
            catch(OverflowException)
            {
                caption = "Invalid value entered";
                message = "Entered value is too Long";
                result = MessageBox.Show(this, message, caption, buttons, icon);
                textBoxLRV.Focus();
                return false;
            }
            if (fConVal > 9999 || fConVal < -9000)
            {
                caption = "Invalid value entered";
                message = "Entered value is too Big/Smal";
                result = MessageBox.Show(this, message, caption, buttons, icon);
                textBoxLRV.Focus();
                return false;
            }
            try
            {
                fConVal = Convert.ToSingle(textBoxURV.Text);
            }
            catch (FormatException)
            {
                icon = MessageBoxIcon.Error;
                caption = "Format Error";
                message = "Invalid Value \n(Unable to Format string)";
                result = MessageBox.Show(this, message, caption, buttons, icon);
                textBoxURV.Focus();
                return false;
            }
            catch(OverflowException)
            {
                caption = "Invalid value entered";
                message = "Entered value is too Long";
                result = MessageBox.Show(this, message, caption, buttons, icon);
                textBoxURV.Focus();
                return false;
            }
            if (fConVal > 9999)
            {
                caption = "Invalid value entered";
                message = "Entered value is too Big";
                result = MessageBox.Show(this, message, caption, buttons, icon);
                textBoxURV.Focus();
                return false;
            }
            try
            {
                iConVal = Convert.ToInt32(textBoxAlarmL.Text);
            }
            catch (FormatException)
            {
                icon = MessageBoxIcon.Error;
                caption = "Format Error";
                message = "Invalid Value \n(Unable to Format string)";
                result = MessageBox.Show(this, message, caption, buttons, icon);
                textBoxAlarmL.Focus();
                return false;
            }
            catch (OverflowException)
            {
                caption = "Invalid value entered";
                message = "Entered value is too Long";
                result = MessageBox.Show(this, message, caption, buttons, icon);
                textBoxAlarmL.Focus();
                return false;
            }

            if (iConVal > 9999)
            {
                icon = MessageBoxIcon.Error;
                caption = "Format Error";
                message = "Invalid Value \n(Unable to Format string)";
                result = MessageBox.Show(this, message, caption, buttons, icon);
                textBoxAlarmL.Focus();
                return false;
            }
            try
            {
                iConVal = Convert.ToInt32(textBoxAlarmH.Text);
            }
            catch (FormatException)
            {
                icon = MessageBoxIcon.Error;
                caption = "Format Error";
                message = "Invalid Value \n(Unable to Format string)";
                result = MessageBox.Show(this, message, caption, buttons, icon);
                textBoxAlarmH.Focus();
                return false;
            }
            catch (OverflowException)
            {
                caption = "Invalid value entered";
                message = "Entered value is too Long";
                result = MessageBox.Show(this, message, caption, buttons, icon);
                textBoxAlarmH.Focus();
                return false;
            }

            if (iConVal > 9999)
            {
                icon = MessageBoxIcon.Error;
                caption = "Format Error";
                message = "Invalid Value \n(Unable to Format string)";
                result = MessageBox.Show(this, message, caption, buttons, icon);
                textBoxAlarmH.Focus();
                return false;
            }
            return true;
        }

        //Combines Config text boxes to a String
        string ConfigMake()
        {
            string data = string.Format("{0};{1};{2};{3};{4}", textBoxName.Text, textBoxLRV.Text, textBoxURV.Text,
                                                                                        textBoxAlarmL.Text, textBoxAlarmH.Text);
            return data;
        }

        //Save Monitord data function
        //Saves data currentley shown in "Monitoring" Tab
        void DataSave()
        {
            string dataType = "Scaled Values";
            string[] rawValues = { };
            string[] scaledValues = { };
            string valuesText = "";
           
            if (checkBoxSignalRaw.Checked)
            {
                dataType = "Raw Values";
                int n = listBoxRaw.Items.Count;
                valuesText = System.DateTime.Now + ",Raw\n";

                for (int i = 0; i < n; i++)
                {
                    valuesText += String.Format("{0},{1}\n", i, listBoxRaw.Items[listBoxRaw.Items.Count - n + i]);
                }

            }
            else
            {

                int m = listBoxScaled.Items.Count;
                scaledValues = new string[m + 1];
                valuesText = System.DateTime.Now + ",Scaled\n";

                for (int i = 0; i < m; i++)
                {
                    valuesText += String.Format("{0},{1}\n", i, listBoxScaled.Items[listBoxScaled.Items.Count - m + i]);
                }

            }

            string fileName = string.Empty;

            saveFileDialog1.InitialDirectory = @"C:";
            saveFileDialog1.Filter = "cvs files (*.csv)|*.csv";
            saveFileDialog1.FilterIndex = 0;
            saveFileDialog1.RestoreDirectory = true;
            saveFileDialog1.FileName = dataType;
            

            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                fileName = saveFileDialog1.FileName;
                //File.WriteAllText(fileName, valuesText);
                
                try
                { 
                     File.WriteAllText(fileName, valuesText); 
                }
                catch(IOException)
                {
                    MessageBox.Show(this, "File:" + fileName + "\nIs open in another program. \nCan't write to File.","Error",
                                                                                        MessageBoxButtons.OK,MessageBoxIcon.Error);
                }
                
            }
        }

        //Closes program from strip menu 
        private void toolStripMenuItemExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //Connects selected serial port
        private void buttonConnect_Click(object sender, EventArgs e)
        {

            comPorts = System.IO.Ports.SerialPort.GetPortNames();
            comboBoxComPort_Enter(sender, e);
            if (comPorts.Length == 0 || comboBoxComPort.SelectedIndex < 0)
            {
                string message = "";
                string caption = "Connection unsuccessful";
                MessageBoxButtons buttons = MessageBoxButtons.OK;
                MessageBoxIcon icon = MessageBoxIcon.Warning;
                DialogResult result;

                if (comPorts.Length == 0)
                {
                    message = "No COM Ports detected\nCheck Connection";  
                }
                else if (comboBoxComPort.Text.Length < 3 || comboBoxComPort.SelectedIndex < 0)
                {
                    message = "No COM Port selected";
                    comboBoxComPort.Focus();
                }
                result = MessageBox.Show(this, message, caption, buttons, icon);
            }

            else if (!serialPort1.IsOpen)
            {
                string message = "Connection established";
                string caption = "Success";
                bool error = false;
                MessageBoxButtons buttons = MessageBoxButtons.OK;
                MessageBoxIcon icon = MessageBoxIcon.Information;
                DialogResult result;

                serialPort1.PortName = comboBoxComPort.SelectedItem.ToString();
                serialPort1.BaudRate = Convert.ToInt32(comboBoxBaudRate.Text);
                try
                { serialPort1.Open(); }
                catch(UnauthorizedAccessException)
                {
                    icon = MessageBoxIcon.Error;
                    message = "Unable to open connetction to "+ serialPort1.PortName+ "\n(Unauthorized Access)"; 
                    caption = "Connection Error";
                    error = true;
                }
                
                
                if (!error)
                {
                    connected = true;
                    textBoxConnection.Text = "Connected";     
                    toolStripStatusLabelConnection.Text = "Connected";
                    toolStripStatusLabelConnection.ForeColor = Color.Green;
                    toolStripProgressBarConnection.Value = 100;
                    timerConnection.Enabled = true;
                    buttonRead.Enabled = true;
                    buttonWrite.Enabled = true;
                    buttonConnect.Enabled = false;
                    buttonDisconnect.Enabled = true;
                    timerSend.Enabled = true;
                    buttonStart.Enabled = true;
                    
                }
                
                result = MessageBox.Show(this, message, caption, buttons, icon);
                if (connected)
                buttonRead_Click(this, e);
            }
        }

        //Cals disconnect funcsion when disconnect button is clicked
        private void buttonDisconnect_Click(object sender, EventArgs e)
        {
            if (connected)
            {
                Disconnect(sender,e);
            }
        }

        //Cals Save function for currently showing data in "Monitoring" Tab
        private void buttonSaveData_Click(object sender, EventArgs e)
        {
            DataSave();
        }

        //Gets available serial ports
        private void comboBoxComPort_Enter(object sender, EventArgs e)
        {
            comPorts = System.IO.Ports.SerialPort.GetPortNames();
            comboBoxComPort.Items.Clear();
            foreach (var item in comPorts)
            {
                comboBoxComPort.Items.Add(item);
            }
            if (comPorts.Length > 0 && comboBoxComPort.SelectedIndex < 0)
            {
                comboBoxComPort.Text = comboBoxComPort.GetItemText(comPorts[0]);
            }
        }

        //Opens About Window
        private void toolStripMenuItemAbout_Click(object sender, EventArgs e)
        {
            AboutBoxSSC aboutWindow = new AboutBoxSSC();
            aboutWindow.ShowDialog(this);
        }

        //Saves Config to default location
        private void toolStripMenuItemSave_Click(object sender, EventArgs e)
        {
            if (ConfigCheck())
            {
                string fileName = string.Format("{0}_Config_V{1}.ssc", textBoxName.Text, version);
                try
                {
                    File.WriteAllText(fileName, ConfigMake());
                }
                catch (IOException)
                {
                    MessageBox.Show(this, "File:" + fileName + "\nIs open in another program. \nCan't write to File.", "Error",
                                                                                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        //Loads Config from file
        private void toolStripMenuItemOpen_Click(object sender, EventArgs e)
        {
            var fileName = string.Empty;
            string configtxt = "";
            string[] config = { };

            openFileDialog1.InitialDirectory = "";
            openFileDialog1.Filter = "ssc files (*.ssc)|*.ssc|All files (*.*)|*.*";
            openFileDialog1.FilterIndex = 0;
            openFileDialog1.RestoreDirectory = true;
            openFileDialog1.FileName = "";

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                fileName = openFileDialog1.FileName;
                configtxt = File.ReadAllText(fileName);
                config = configtxt.Split(';');
                textBoxName.Text = config[0];
                textBoxLRV.Text = config[1];
                textBoxURV.Text = config[2];
                textBoxAlarmL.Text = config[3];
                textBoxAlarmH.Text = config[4];
            }
                      
        }

        //Saves Config to chosen location
        private void toolStripMenuItemSaveAs_Click(object sender, EventArgs e)
        {
            if (ConfigCheck())
            {
                saveFileDialog1.InitialDirectory = "";
                saveFileDialog1.Filter = "ssc files (*.ssc)|*.ssc|All files (*.*)|*.*";
                saveFileDialog1.FilterIndex = 0;
                saveFileDialog1.RestoreDirectory = true;
                saveFileDialog1.FileName = textBoxName.Text + "_Config_V"+version;

                if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    string fileName = saveFileDialog1.FileName;

                    try
                    {
                        File.WriteAllText(fileName, ConfigMake());
                    }
                    catch (IOException)
                    {
                        MessageBox.Show(this, "File:" + fileName + "\nIs open in another program. \nCan't write to File.", "Error",
                                                                                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        //Timer to check if connection to serial port is lost
        private void timerConnection_Tick(object sender, EventArgs e)
        {
            if (!serialPort1.IsOpen)
            {
                Disconnect(sender,e);
                string message = "Connection Lost!\nCheck Connection";
                string caption = "Connection Error";
                MessageBoxButtons buttons = MessageBoxButtons.OK;
                MessageBoxIcon icon = MessageBoxIcon.Error;
                MessageBox.Show(this, message, caption, buttons, icon);
                
            }
        }
        
        //Sends Monitoirng and Status Requests to serial port
        private void timerSend_Tick(object sender, EventArgs e)
        {
            
            if (serialPort1.IsOpen && serialPort1.BytesToRead == 0)
            {
                
                if (monitorStart)
                {
                    if (statuscheck && statusRead)
                    {
                        monitor = false;
                        monitorRead = true;
                        statusRead = false;
                        serialPort1.Write("readstatus");

                    }
                    else if (monitor && monitorRead)
                    {
                        if (checkBoxSignalRaw.Checked)
                        {
                            serialPort1.Write("readraw");
                        }
                        else
                        {
                            serialPort1.Write("readscaled");
                        }
                        monitorRead = false;
                    }
                    
                }  
            }
            timerSend.Enabled = false;
            timerReceive.Enabled = true;
        }

        //Recives data from Serial port
        private void timerReceive_Tick(object sender, EventArgs e)
        {
            
            if (serialPort1.IsOpen && serialPort1.BytesToRead > 0)
            {
                indata = serialPort1.ReadExisting();
                //System.Console.Write(indata+"");
           
                if (readconf)
                {
                    chartvalues = indata.Split(';');

                    if (chartvalues.Length == 5)
                    {
                        textBoxCName.Text = chartvalues[0];
                        textBoxCLRV.Text = chartvalues[1];
                        textBoxCURV.Text = chartvalues[2];
                        textBoxCAlarmL.Text = chartvalues[3];
                        textBoxCAlarmH.Text = chartvalues[4];
                    }
                    else
                    {
                        MessageBox.Show(this, "Unable to Read received Config", "Read Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    readconf = false;
                }
                else if (writeconf)
                {
                    string message = "Connection Lost!\nCheck Connection";
                    string caption = "";
                    MessageBoxButtons buttons = MessageBoxButtons.OK;
                    MessageBoxIcon icon = MessageBoxIcon.Error;
                    DialogResult result;

                    int succsess = Convert.ToInt32(indata);

                    if (succsess == 1)
                    {
                        caption = "Configuration Successful";
                        message = "Successe Configuration updated";
                        icon = MessageBoxIcon.Information;
                        textBoxCName.Text = textBoxName.Text;
                        textBoxCLRV.Text = textBoxLRV.Text;
                        textBoxCURV.Text = textBoxURV.Text;
                        textBoxCAlarmL.Text = textBoxAlarmL.Text;
                        textBoxCAlarmH.Text = textBoxAlarmH.Text;
                    }
                    else
                    {
                        caption = "Configuration Failed";
                        message = "Configuration Failed (Incorrect Password?)";
                        icon = MessageBoxIcon.Error;
                    }
                    
                    result = MessageBox.Show(this, message, caption, buttons, icon);
                    writeconf = false;
                }
                else if (monitorStart)
                {
                    if (statuscheck)
                    {
                        monitor = true;
                        statusVal = Convert.ToInt32(indata);

                        if (statusVal == 0)
                        {
                            textBoxIStatus.Text = "OK";
                            textBoxIStatus.ForeColor = Color.Green;
                            pictureBoxSignalStatus.Image = Arbeidskrav_1.Properties.Resources.StatusOK_16x;
                            toolStripStatusLabelMStaus.ForeColor = Color.Green;
                        }
                        else if (statusVal == 1)
                        {
                            textBoxIStatus.Text = "Fail";
                            textBoxIStatus.ForeColor = Color.Red;
                            pictureBoxSignalStatus.Image = Arbeidskrav_1.Properties.Resources.StatusCriticalError_16x;
                            toolStripStatusLabelMStaus.ForeColor = Color.Red;
                        }
                        else if (statusVal == 2)
                        {                            
                            textBoxIStatus.Text = "Alarm Low";
                            textBoxIStatus.ForeColor = Color.Orange;
                            pictureBoxSignalStatus.Image = Arbeidskrav_1.Properties.Resources.StatusWarning_16x;
                            toolStripStatusLabelMStaus.ForeColor = Color.Orange;
                        }
                        else if (statusVal == 3)
                        {
                            textBoxIStatus.Text = "Alarm High";
                            textBoxIStatus.ForeColor = Color.Orange;
                            pictureBoxSignalStatus.Image = Arbeidskrav_1.Properties.Resources.StatusWarning_16x;
                            toolStripStatusLabelMStaus.ForeColor = Color.Orange;
                        }
                        toolStripStatusLabelMStaus.Text = textBoxIStatus.Text;
                        if (statusVal <= 3)
                        {
                            statuscheckCounter = 0;
                            statuscheck = false;
                        }
                        statusRead = true;

                    }
                    else if (monitor)
                    {
                        string timeNow = DateTime.Now.Hour.ToString() + ":" + DateTime.Now.Minute.ToString() + ":" + DateTime.Now.Second.ToString();

                        if (checkBoxSignalRaw.Checked)
                        { 
                            chartRaw.Series[0].Points.AddXY( timeNow , Convert.ToInt32(indata));
                            listBoxRaw.Items.Add(indata);
                            if (!indata.Contains("\r\n"))
                                indata = indata + "\r\n";
                            textBoxSensorData.AppendText(indata);
                            pointXValueRaw += 1;
                        }
                        else
                        {
                            chartScaled.Series[0].Points.AddXY(timeNow, Convert.ToDouble(indata));
                            listBoxScaled.Items.Add(indata);
                            if (!indata.Contains("\r\n"))
                                indata = indata + "\r\n";
                            textBoxSensorData.AppendText(indata);
                            pointXValueScaled += 1;
                        }

                        statuscheckCounter += 1;
                        monitorRead = true;

                        if (statuscheckCounter == 5)
                        {
                            statuscheck = true;
                        }
                    }
                }    
            }
            if (writeconf || readconf)
                timeout += 1;
            if (timeout >= 4)
            {
                writeconf = false;
                readconf = false;
                timeout = 0;
            }
            timerSend.Enabled = true;
            timerReceive.Enabled = false;

        }

        //Sends Read Config Request via the serial port
        private void buttonRead_Click(object sender, EventArgs e)
        {
            if (!readconf && !writeconf)
            {
                serialPort1.Write("readconf");
                timeout = 0;
                readconf = true;
            }
        }

        //Writes Config values to Serial port and saves a backup
        private void buttonWrite_Click(object sender, EventArgs e)
        {
            if (!writeconf && !readconf)
            {
                if (ConfigCheck())
                {
                    string data = ConfigMake();
                    FormPassword passwordwindow = new FormPassword();
                    passwordwindow.ShowDialog(this);
                    if (!cancel)
                    {
                        string fileName = string.Format("Backup_Config_{0}_{1}.ssc", textBoxName.Text, version);
                        try
                        {
                            File.WriteAllText(fileName, data);
                        }
                        catch (IOException)
                        {
                            MessageBox.Show(this, "File:" + fileName + "\nIs open in another program. \nCan't write to File.", "Error",
                                                                                                MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        serialPort1.Write(String.Format("writeconf>{0}>{1}", configPassword, data));
                        writeconf = true;
                        timeout = 0;
                    }

                }
            }
            
        }

        //Starts Monitoring
        private void buttonStart_Click(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen && !writeconf && !readconf)
            {
                monitorStart = true;
                statuscheck = true;
                statusRead = true;
                checkBoxSignalRaw.Enabled = false;
                buttonWrite.Enabled = false;
                buttonRead.Enabled = false;
                buttonStart.Enabled = false;
                buttonStop.Enabled = true;
                buttonSaveData.Enabled = false;
                toolStripStatusLabelMonitoring.Visible = true;
                toolStripStatusLabelMStaus.Visible = true;
            }
        }

        //Stops Monitoring
        private void buttonStop_Click(object sender, EventArgs e)
        {
            monitorStart = false;
            statuscheck = false;
            checkBoxSignalRaw.Enabled = true;
            buttonWrite.Enabled = true;
            buttonRead.Enabled = true;
            buttonStop.Enabled = false;
            buttonSaveData.Enabled = true;
            toolStripStatusLabelMonitoring.Visible = false;
            toolStripStatusLabelMStaus.Visible = false;

            string dataType = "Scaled Values";

            if (serialPort1.IsOpen)
            {
                buttonStart.Enabled = true;
            }

            if (checkBoxSignalRaw.Checked)
            {
                dataType = "Raw Values";   
            }
            string message = String.Format("Do you want to Save {0} to file?", dataType);
            string caption = "Save Values?";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            MessageBoxIcon icon = MessageBoxIcon.Question;
            DialogResult result;
            if (!connected)
            {
                message = String.Format("Connection Lost!\nDo you want to Save {0} to file?", dataType);
            }
            result = MessageBox.Show(this, message, caption, buttons, icon);
            
            if (result == DialogResult.Yes)
            {
                DataSave();
            }
            
        }   

        //Changes data Type monitored
        private void checkBoxSignalRaw_CheckedChanged(object sender, EventArgs e)
        {
            if (!checkBoxSignalRaw.Checked)
            {

                chartRaw.Visible = false;
                chartScaled.Visible = true;
                chartRaw.Enabled = false;
                chartScaled.Enabled = true;
                chartRaw.Series[0].Enabled = false;
                chartScaled.Series[0].Enabled = true;
                labelScaled.Visible = true;
                labelRaw.Visible = false;
                listBoxScaled.Visible = true;
                listBoxRaw.Visible = false;
            }
            else
            {
                
                chartRaw.Visible = true;
                chartScaled.Visible = false;
                chartRaw.Enabled = true;
                chartScaled.Enabled = false;
                chartRaw.Series[0].Enabled = true;
                chartScaled.Series[0].Enabled = false;
                labelScaled.Visible = false;
                labelRaw.Visible = true;
                listBoxScaled.Visible = false;
                listBoxRaw.Visible = true;
            }
            
        }

        //Loads default Config or makes one if none exists
        private void FormMain_Activated(object sender, EventArgs e)
        {
            if (!serialPort1.IsOpen)
            {
                comboBoxComPort.Focus();
            }
            if (!innit)
            {
                if (!File.Exists("Default_Config.ssc"))
                {
                    string line = "C385IT001;0.0;500.0;40;440";
                    File.WriteAllText("Default_Config.ssc", line);
                }
                else
                {
                    string configtxt = File.ReadAllText("Default_Config.ssc");
                    string[] config = configtxt.Split(';');
                    textBoxName.Text = config[0];
                    textBoxLRV.Text = config[1];
                    textBoxURV.Text = config[2];
                    textBoxAlarmL.Text = config[3];
                    textBoxAlarmH.Text = config[4];
                }
                innit = true;
            }


        }

        //Prevents user from entering invalid characters
        private void textBoxLRV_KeyPress(object sender, KeyPressEventArgs e)
        {
            switch (e.KeyChar)
            {
                
                case '0':
                case '1':
                case '2':
                case '3':
                case '4':
                case '5':
                case '6':
                case '7':
                case '8':
                case '9':
                case '-':
                case '.':
                case '\b':
                    break;
                default:
                    e.Handled = true;
                    break;
            }
        }

        //Prevents user from entering invalid characters
        private void textBoxAlarmL_KeyPress(object sender, KeyPressEventArgs e)
        {
            switch (e.KeyChar)
            {

                case '0':
                case '1':
                case '2':
                case '3':
                case '4':
                case '5':
                case '6':
                case '7':
                case '8':
                case '9':
                case '-':
                case '\b':
                    break;
                default:
                    e.Handled = true;
                    break;
            }    
        }

        //Prevents user from entering invalid characters
        private void textBoxName_KeyPress(object sender, KeyPressEventArgs e)
        {
            switch (e.KeyChar)
            {

                case ';':
                case '>':
                    e.Handled = true;
                    break;
                default:
                  
                    break;
            }
        }

        //Prevents user from closing program by accident
        private void FormMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (monitorStart)
            {
                string message = "You are monitoring do you want to Save and Exit?";
                string caption = "Exit Confirmation";

                DialogResult result = MessageBox.Show(this, message, caption, MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);

                if (result == DialogResult.Cancel)
                {
                    e.Cancel = true;
                }
                else if (result == DialogResult.Yes)
                {
                    DataSave();
                    e.Cancel = false;
                }
            }
        }

        //Tooltip Read online Config
        private void buttonRead_MouseHover(object sender, EventArgs e)
        {
            toolTip1.AutoPopDelay = 200;
            toolTip1.AutoPopDelay = 10000;
            toolTip1.SetToolTip(buttonRead, "Read Config from microcontroller");
        }

        //Tooltip write Config to Device 
        private void buttonWrite_MouseHover(object sender, EventArgs e)
        {
            toolTip1.AutoPopDelay = 200;
            toolTip1.AutoPopDelay = 10000;
            toolTip1.SetToolTip(buttonWrite, "Write Config to microcontroller");
        }

        //Tooltip Load Config from File
        private void buttonLoad_MouseHover(object sender, EventArgs e)
        {
            toolTip1.AutoPopDelay = 200;
            toolTip1.AutoPopDelay = 10000;
            toolTip1.SetToolTip(buttonLoad, "Load config from File");
        }

        //Tooltips
        private void buttonSave_MouseHover(object sender, EventArgs e)
        {
            toolTip1.AutoPopDelay = 200;
            toolTip1.AutoPopDelay = 10000;
            toolTip1.SetToolTip(buttonSave, "Save config to File");
        }

        //Tooltips Connect
        private void buttonConnect_MouseHover(object sender, EventArgs e)
        {
            toolTip1.AutoPopDelay = 200;
            toolTip1.AutoPopDelay = 10000;
            toolTip1.SetToolTip(buttonConnect, "Connect to Serial Port");
        }

        //Tooltips Disconnect button
        private void buttonDisconnect_MouseHover(object sender, EventArgs e)
        {
            toolTip1.AutoPopDelay = 200;
            toolTip1.AutoPopDelay = 10000;
            toolTip1.SetToolTip(buttonDisconnect, "Disconnect from microcontroller");
        }

        //Tooltips Start monitoring button
        private void buttonStart_MouseHover(object sender, EventArgs e)
        {
            toolTip1.AutoPopDelay = 200;
            toolTip1.AutoPopDelay = 10000;
            toolTip1.SetToolTip(buttonStart, "Start monitoring of Data");
        }

        //Tooltips Stop monitoring
        private void buttonStop_MouseHover(object sender, EventArgs e)
        {
            toolTip1.AutoPopDelay = 200;
            toolTip1.AutoPopDelay = 10000;
            toolTip1.SetToolTip(buttonStop, "Stop monitoring of Data");
        }

        //Tooltips Change monitoring data type
        private void checkBoxSignalRaw_MouseHover(object sender, EventArgs e)
        {
            toolTip1.AutoPopDelay = 200;
            toolTip1.AutoPopDelay = 10000;
            toolTip1.SetToolTip(checkBoxSignalRaw, "Check to recive Raw values");
        }

        //Tooltips Save monitord data button
        private void buttonSaveData_MouseHover(object sender, EventArgs e)
        {
            toolTip1.AutoPopDelay = 200;
            toolTip1.AutoPopDelay = 10000;
            string dataType = "Scaled";
            if (checkBoxSignalRaw.Checked) dataType = "Raw";
            toolTip1.SetToolTip(buttonSaveData, "Save " + dataType + " Data");
        }

        private void toolStripMenuItemDefaultConfig_Click(object sender, EventArgs e)
        {
            DefaultConfigSettings defaultConfigWindow = new DefaultConfigSettings();
            defaultConfigWindow.Show(this);
        }

        private void textBoxName_MouseHover(object sender, EventArgs e)
        {
            toolTip1.AutoPopDelay = 200;
            toolTip1.AutoPopDelay = 10000;
            toolTip1.SetToolTip(textBoxName, "Enter Name of Device (Maximun 10 Characters)\n Not:(\' > \'),(\' ; \')");
        }

        private void textBoxLRV_MouseHover(object sender, EventArgs e)
        {
            toolTip1.AutoPopDelay = 200;
            toolTip1.AutoPopDelay = 10000;
            toolTip1.SetToolTip(textBoxLRV, "Enter Low Range Value (decimal numbers allowed)");
        }

        private void textBoxURV_MouseHover(object sender, EventArgs e)
        {
            toolTip1.AutoPopDelay = 200;
            toolTip1.AutoPopDelay = 10000;
            toolTip1.SetToolTip(textBoxURV, "Enter Upper Range Value (decimal numbers allowed)");
        }

        private void textBoxAlarmL_MouseHover(object sender, EventArgs e)
        {
            toolTip1.AutoPopDelay = 200;
            toolTip1.AutoPopDelay = 10000;
            toolTip1.SetToolTip(textBoxAlarmL, "Enter Alarm Low Value (Only Integers)");
        }

        private void textBoxAlarmH_MouseHover(object sender, EventArgs e)
        {
            toolTip1.AutoPopDelay = 200;
            toolTip1.AutoPopDelay = 10000;
            toolTip1.SetToolTip(textBoxAlarmH, "Enter Alarm High Value (Only Integers)");
        }
    }      
}
