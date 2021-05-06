using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Reflection;
using System.Data.SqlClient;
using System.Configuration;



namespace SoftSensConf
{
    
    public partial class FormMain : Form
    {
        
        public FormMain()
        {
            InitializeComponent();
        }

        string connectSS_DB = ConfigurationManager.ConnectionStrings["SoftSensDB_ConnectionString"].ConnectionString;
        List<string> mesurement_ID = new List<string>();
        List<int> iD = new List<int>();
        List<string> tagName = new List<string>();
        
        List<string> mcu_ID = new List<string>();
        List<string> mcu_Description = new List<string>();
        List<string> rdc_ID = new List<string>();
        List<string> rdc_Description = new List<string>();

        List<string> dau_ID = new List<string>();
        List<string> dau_Description = new List<string>();
        List<string> com_Port = new List<string>();
        List<string> bit_Rate = new List<string>();

        List<string> name_Tag = new List<string>();
        List<string> low_Range = new List<string>();
        List<string> upper_Range = new List<string>();
        List<string> alarm_Low = new List<string>();
        List<string> alarm_High = new List<string>();
        List<string> digial_Analog = new List<string>();
        List<string> inn_Out = new List<string>();
        List<string> scan_Frequencie = new List<string>();

        string old_MCU = "";
        string old_RDC = "";
        string old_DAU = "";

        bool connected = false;
        string[] comPorts = System.IO.Ports.SerialPort.GetPortNames();
        string[] chartvalues = { };
        string indata = "";
        bool newConf = false;
        bool readconf = false;
        bool writeconf = false;
        bool monitorStart = false;
        bool monitor = true;
        bool statusCheck = false;
        bool send = true;
        string version = Assembly.GetExecutingAssembly().GetName().Version.ToString();

        double statusVal = 0;
        int statuscheckCounter = 0;
        public static string configPassword = "password";
        public static bool cancel = false;

        ///Disconnects serial port
        ///Enables and disables bool values accordingly.
        void Disconnect(object sender, EventArgs e)
        {
            serialPort1.Close();
            connected = false;
            textBoxConnection.Text = "Disconnected";
            toolStripStatusLabelConnection.Text = "Disconnected";
            toolStripStatusLabelConnection.ForeColor = Color.Red;
            toolStripProgressBarConnection.Value = 0;
            timerConnection.Enabled = false;
            timerCommunication.Enabled = false;
            timerDataBase.Enabled = false;
            buttonStart.Enabled = false;
            buttonStop.Enabled = false;
            buttonConnect.Enabled = true;
            buttonDisconnect.Enabled = false;
            readconf = false;
            writeconf = false;
            comboBoxMCU.Enabled = true;
            comboBoxRDC.Enabled = true;
            comboBoxDAU.Enabled = true;
            comboBoxBaudRate.Enabled = true;
            comboBoxComPort.Enabled = true;
            textBoxCName.Clear();
            textBoxCLRV.Clear();
            textBoxCURV.Clear();
            textBoxCAlarmL.Clear();
            textBoxCAlarmH.Clear();
            textBoxCFrequencie.Clear();
            textBoxCAnalog_Digital.Clear();
            if (monitorStart)
                buttonStop_Click(sender, e);
        }

        ///Checks if entered config values are valid
        public bool ConfigCheck()
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
                message = "Low Range Value Entered is too Long (Over Flow Error)";
                result = MessageBox.Show(this, message, caption, buttons, icon);
                textBoxLRV.Focus();
                return false;
            }
            if (fConVal > 9999 || fConVal < -9000)
            {
                caption = "Invalid value entered";
                message = "Low Range Value Entered is too Big/Smal";
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
                message = "Upper Range Value Invalid \n(Unable to Format string)";
                result = MessageBox.Show(this, message, caption, buttons, icon);
                textBoxURV.Focus();
                return false;
            }
            catch(OverflowException)
            {
                caption = "Invalid value entered";
                message = "Upper Range Value Entered is too Long (Over Flow Error)";
                result = MessageBox.Show(this, message, caption, buttons, icon);
                textBoxURV.Focus();
                return false;
            }
            if (fConVal > 9999)
            {
                caption = "Invalid value entered";
                message = "Upper Range value is too Big";
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
                message = "Alarm Low Value Invalid \n(Unable to Format string)";
                result = MessageBox.Show(this, message, caption, buttons, icon);
                textBoxAlarmL.Focus();
                return false;
            }
            catch (OverflowException)
            {
                caption = "Invalid value entered";
                message = "Alarm Low Value Entered is too Long (Over Flow Error)";
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
                message = "Alarm High Value Invalid \n(Unable to Format string)";
                result = MessageBox.Show(this, message, caption, buttons, icon);
                textBoxAlarmH.Focus();
                return false;
            }
            catch (OverflowException)
            {
                caption = "Invalid value entered";
                message = "Alarm High Entered value is too Long (Over Flow Error)";
                result = MessageBox.Show(this, message, caption, buttons, icon);
                textBoxAlarmH.Focus();
                return false;
            }

            if (iConVal > 9999)
            {
                icon = MessageBoxIcon.Error;
                caption = "Format Error";
                message = "Alarm High VAlue Invalid \n(Unable to Format string)";
                result = MessageBox.Show(this, message, caption, buttons, icon);
                textBoxAlarmH.Focus();
                return false;
            }
            return true;
        }
        
        ///Combines Config text boxes to a String
        public string ConfigMake()
        {
            string data = string.Format("{0};{1};{2};{3};{4}", textBoxName.Text, textBoxLRV.Text, textBoxURV.Text,
                                                                                        textBoxAlarmL.Text, textBoxAlarmH.Text);
            return data;
        }

        public bool ConfigOld_New()
        {
            if (low_Range[0] != textBoxCLRV.Text) return false;
            else if (upper_Range[0] != textBoxCURV.Text) return false;
            else if (alarm_Low[0] != textBoxCAlarmL.Text) return false;
            else if (alarm_High[0] != textBoxCAlarmH.Text) return false;
            else if (scan_Frequencie[0] != textBoxCFrequencie.Text) return false;

            return true;
        }
        public bool COM_Check()
        {
            comPorts = System.IO.Ports.SerialPort.GetPortNames();

            foreach (string port in comPorts)
            {
                if (port == comboBoxComPort.Text) return true;
            }

            return false;
        }

        ///Save Monitord data function
        ///Saves data currentley shown in "Monitoring" Tab
        public void DataSave()
        {
            string dataType = "Scaled Values";
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

        public void SQL_Sensor_Data(string table, string column, string value)
        {
            string sqlQuery = string.Format("INSERT INTO {0} ({1}) VALUES ({2})", table, column, value);
            SqlConnection connection = new SqlConnection(connectSS_DB);
            SqlCommand command = new SqlCommand(sqlQuery, connection);
            try
            {
                command.Parameters.AddWithValue(column, value);
                connection.Open();
                command.ExecuteNonQuery();
                connection.Close();
            }
            catch (Exception er)
            {
                MessageBox.Show("Error in SQL_Sensor_Data: " + er);
            }
        }

        public void SQL_INSERT_DATA(string table, string value)
        {
            string sqlQuery = string.Format("EXEC Insert{0} {1}", table, value);
            
            try
            {
                SqlConnection connection = new SqlConnection(connectSS_DB);
                SqlCommand command = new SqlCommand(sqlQuery, connection);
                connection.Open();
                command.ExecuteNonQuery();
                connection.Close();
            }
            catch (Exception er)
            {
                MessageBox.Show("Error in SQL_INSERT_DATA: " + er);
            }
        }

        public int SQL_M_ID(string table, string column, string order)
        {
            int i_ID = 0;
            try
            {
                SqlConnection connection = new SqlConnection(connectSS_DB);
                string sqlQuery = string.Format("SELECT {0} FROM {1} ORDER BY {2} ASC",column,table,order);
                System.Console.WriteLine("SQL_M_ID: "+sqlQuery);
                SqlCommand command = new SqlCommand(sqlQuery, connection);
                connection.Open();
                SqlDataReader dataReader = command.ExecuteReader();
                int i = 0;
                while (dataReader.Read())
                {
                    mesurement_ID.Add(dataReader[0].ToString());
                    tagName.Add(dataReader[1].ToString());
                    iD.Add(i+1);
                    i += 1;                   
                }
                connection.Close();
                int n = 0;
                foreach (int iD in iD)
                {
                    if (iD > i_ID && tagName[n] == textBoxCName.Text)
                    {
                        i_ID = iD;
                    }
                    n += 1;
                }
            }
            catch (Exception error)
            {
                MessageBox.Show("Error in SQL_M_ID: " + error);
            }

            mesurement_ID.Clear();
            tagName.Clear();
            iD.Clear();

            return i_ID;
        }

        public void SQL_Read_Config()
        {
            low_Range.Clear();
            upper_Range.Clear();
            alarm_Low.Clear();
            alarm_High.Clear();
            digial_Analog.Clear();
            inn_Out.Clear();
            scan_Frequencie.Clear();

            try
            {
                
                string sqlQuery = "SELECT Low_Range_Value, Upper_Range_Value, Alarm_Low, Alarm_High, Digital_Analog, Scan_frequencie, Inn_Out FROM INSTRUMENT " +
                             $"WHERE Instrument_Tag = '{name_Tag[0]}' ORDER BY Instrument_Tag ASC";
                SqlConnection connection = new SqlConnection(connectSS_DB);
                Console.WriteLine(sqlQuery);
                SqlCommand command = new SqlCommand(sqlQuery, connection);
                connection.Open();
                SqlDataReader dataReader = command.ExecuteReader();
                while(dataReader.Read())
                {
                    low_Range.Add(dataReader[0].ToString());
                    upper_Range.Add(dataReader[1].ToString());
                    alarm_Low.Add(dataReader[2].ToString());
                    alarm_High.Add(dataReader[3].ToString());
                    digial_Analog.Add(dataReader[4].ToString());
                    scan_Frequencie.Add(dataReader[5].ToString());
                    inn_Out.Add(dataReader[6].ToString());
                }
                connection.Close();
                textBoxLRV.Text = low_Range[0];
                textBoxURV.Text = upper_Range[0];
                textBoxAlarmL.Text = alarm_Low[0];
                textBoxAlarmH.Text = alarm_High[0];
                textBoxFrequencie.Text = scan_Frequencie[0];
                textBoxAnalog_Digital.Text = digial_Analog[0];
                if (scan_Frequencie[0] == "0")
                {
                    timerCommunication.Enabled = false;
                    textBoxCFrequencie.Text = "OFF";
                    textBoxFrequencie.Text = "OFF";
                }
                else
                {
                    timerCommunication.Enabled = true;
                }

            }
            catch (Exception  error)
            {

                MessageBox.Show("Error in SQL_RED_Config: " + error);
            }
            
        }

        //Writes Config values to Serial port
        private void Write_To_DAU()
        {
            if (!writeconf && !readconf)
            {
                if (ConfigCheck())
                {
                    string data = ConfigMake();
                    try
                    {
                        serialPort1.Write(String.Format("writeconf>{0}>{1}", configPassword, data));
                    }
                    catch (Exception error)
                    {
                        MessageBox.Show("Write Conf Error:" + error, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                    writeconf = true;
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
            if (comPorts.Length == 0 || comboBoxComPort.Text.Length < 4 || !COM_Check() )
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
                else if (comboBoxDAU.SelectedIndex < 0)
                {
                    message = "No DAU Selected";
                }
                else if (!COM_Check())
                {
                    message = string.Format("{0} is not a valid Port", comboBoxComPort.Text);
                }
                result = MessageBox.Show(this, message, caption, buttons, icon);
            }

            else if (!serialPort1.IsOpen && comboBoxDAU.SelectedIndex > -1)
            {
                string message = "Connection established";
                string caption = "Success";
                bool error = false;
                MessageBoxButtons buttons = MessageBoxButtons.OK;
                MessageBoxIcon icon = MessageBoxIcon.Information;
                DialogResult result;

                serialPort1.PortName = comboBoxComPort.Text;
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
                    buttonConnect.Enabled = false;
                    buttonDisconnect.Enabled = true;
                    timerCommunication.Enabled = true;
                    buttonStart.Enabled = true;
                    comboBoxMCU.Enabled = false;
                    comboBoxRDC.Enabled = false;
                    comboBoxDAU.Enabled = false;
                    comboBoxBaudRate.Enabled = false;
                    comboBoxComPort.Enabled = false;
                    timerDataBase.Enabled = true;
                }                
                result = MessageBox.Show(this, message, caption, buttons, icon);
                timerDataBase_Tick(sender, e);
                
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
            if (comPorts.Length > 0 && comboBoxComPort.SelectedIndex < 0 && comboBoxComPort.Text.Length < 4)
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
        //Timer to check if config is updated
        private void timerDataBase_Tick(object sender, EventArgs e)
        {
            SQL_Read_Config();

            if (!ConfigOld_New())
            {
                if (!monitorStart)
                { Write_To_DAU(); }
                else
                { newConf = true; }
            }
        }

        ///Sends Monitoirng and Status Requests to serial port
        ///Recives data from Serial port       
        private void timerCommunication_Tick(object sender, EventArgs e)
        {
            if (send && serialPort1.IsOpen)
            {
                if (readconf)
                {
                    serialPort1.Write("readconf");
                    send = false;
                }
                if (monitorStart)
                {
                    if (statusCheck)
                    {
                        serialPort1.Write("readstatus");
                        send = false;
                    }
                    else if (newConf)
                    {
                        Write_To_DAU();
                        newConf = false;
                        send = false;
                    }
                    else if (monitor)
                    {
                        serialPort1.Write("readraw");
                        send = false;
                    }

                }
            
            }
            if (serialPort1.IsOpen && serialPort1.BytesToRead > 0)
            {
                indata = serialPort1.ReadExisting();

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
                    send = true;
                }
                if (monitorStart && !writeconf)
                {
                    if (statusCheck)
                    {
                        statusVal = Convert.ToInt32(indata);

                        if (statusVal == 0)
                        {
                            textBoxIStatus.Text = "OK";
                            textBoxIStatus.ForeColor = Color.Green;
                            pictureBoxSignalStatus.Image = SoftSensConf.Properties.Resources.StatusOK_16x;
                            toolStripStatusLabelMStaus.ForeColor = Color.Green;
                        }
                        else if (statusVal == 1)
                        {
                            textBoxIStatus.Text = "Fail";
                            textBoxIStatus.ForeColor = Color.Red;
                            pictureBoxSignalStatus.Image = SoftSensConf.Properties.Resources.StatusCriticalError_16x;
                            toolStripStatusLabelMStaus.ForeColor = Color.Red;
                        }
                        else if (statusVal == 2)
                        {
                            textBoxIStatus.Text = "Alarm Low";
                            textBoxIStatus.ForeColor = Color.Orange;
                            pictureBoxSignalStatus.Image = SoftSensConf.Properties.Resources.StatusWarning_16x;
                            toolStripStatusLabelMStaus.ForeColor = Color.Orange;
                        }
                        else if (statusVal == 3)
                        {
                            textBoxIStatus.Text = "Alarm High";
                            textBoxIStatus.ForeColor = Color.Orange;
                            pictureBoxSignalStatus.Image = SoftSensConf.Properties.Resources.StatusWarning_16x;
                            toolStripStatusLabelMStaus.ForeColor = Color.Orange;
                        }
                        toolStripStatusLabelMStaus.Text = textBoxIStatus.Text;
                        if (statusVal <= 3)
                        {
                            statuscheckCounter = 0;
                            statusCheck = false;
                        }
                        send = true; 
                    }
                    else if (monitor)
                    {
                        string timeNow = DateTime.Now.Hour.ToString("##") + ":" + DateTime.Now.Minute.ToString("00") + ":" + DateTime.Now.Second.ToString("##");

                        chartRaw.Series[0].Points.AddXY(timeNow, Convert.ToInt32(indata));
                        listBoxRaw.Items.Add(indata);

                        float scaled = (float.Parse(indata) * float.Parse(textBoxCURV.Text) / 1023);
                        string i_indata = scaled.ToString("0.00");
                        SQL_Sensor_Data("SENSOR_DATA", "Instrument_Tag", "'" + textBoxCName.Text + "'");
                        int iD = SQL_M_ID("SENSOR_DATA", "Measurement_ID, Instrument_Tag", "Measurement_ID");
                        if (textBoxCAnalog_Digital.Text == "Analog")
                        {
                            SQL_INSERT_DATA("ANALOG_INPUT", string.Format("{0}, {1}", iD, i_indata));
                        }
                        else
                        {
                            SQL_INSERT_DATA("DIGITAL_INPUT", string.Format("{0}, {1}", iD, i_indata));
                        }
                        chartScaled.Series[0].Points.AddXY(timeNow, i_indata);
                        listBoxScaled.Items.Add(i_indata);

                        if (!indata.Contains("\r\n"))
                            indata = indata + "\r\n";
                        textBoxSensorData.AppendText(indata);

                        statuscheckCounter += 1;

                        if (statuscheckCounter == 5)
                        {
                            statusCheck = true;
                        }
                        send = true;
                    }
                }
                else if (writeconf)
                {
                    int succsess = Convert.ToInt32(indata);

                    if (succsess == 1)
                    {
                        textBoxCName.Text = name_Tag[0];
                        textBoxCLRV.Text = low_Range[0];
                        textBoxCURV.Text = upper_Range[0];
                        textBoxCAlarmL.Text = alarm_Low[0];
                        textBoxCAlarmH.Text = alarm_High[0];
                        textBoxCFrequencie.Text = scan_Frequencie[0];
                        textBoxCAnalog_Digital.Text = digial_Analog[0];
                        labelConfigTime.Text = "Config Updated: " + DateTime.Now.ToString();
                        toolStripStatusLabelUpdateTime.Text = labelConfigTime.Text;
                        if (int.Parse(textBoxCFrequencie.Text) <= 1000 && int.Parse(textBoxCFrequencie.Text) > 0)
                        timerCommunication.Interval = Convert.ToInt32(1000/int.Parse(textBoxCFrequencie.Text));
                        else timerCommunication.Interval = 1000;
                    }
                    else MessageBox.Show(this, "Configuration Failed", "Configuration Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    
                    writeconf = false;
                    send = true;
                }
            }
        }

        private void tabPageConnection_Enter(object sender, EventArgs e)
        {
            mcu_ID.Clear();
            mcu_Description.Clear();

            try
            {
                SqlConnection connection = new SqlConnection(connectSS_DB);
                string sqlQuery = "SELECT MCU_ID,Description FROM MCU ORDER BY MCU_ID ASC";
                SqlCommand command = new SqlCommand(sqlQuery, connection);
                connection.Open();
                SqlDataReader dataReader = command.ExecuteReader();
                while (dataReader.Read())
                {
                    mcu_ID.Add(dataReader[0].ToString());
                    mcu_Description.Add(dataReader[1].ToString());
                }
                connection.Close();
                comboBoxMCU.Items.Clear();

                foreach (string id in mcu_Description)
                {
                    comboBoxMCU.Items.Add(id);
                }
                if (comboBoxMCU.Text.Length == 0 && comboBoxMCU.Items.Count > 0) { comboBoxMCU.SelectedIndex = 0; }


            }
            catch (Exception error)
            {
                MessageBox.Show("Error in MCU enter: " + error);
            }
        }

        private void comboBoxMCU_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (old_MCU != comboBoxMCU.Text)
            {
                old_MCU = comboBoxMCU.Text;
                rdc_ID.Clear();
                rdc_Description.Clear();

                if (comboBoxMCU.SelectedIndex >= 0 && mcu_ID.Count > 0)
                {

                    try
                    {
                        SqlConnection connection = new SqlConnection(connectSS_DB);
                        string sqlQuery = "SELECT RDC_ID,Description FROM RDC WHERE MCU_ID ='" + mcu_ID[comboBoxMCU.SelectedIndex] + "' ORDER BY MCU_ID ASC";
                        System.Console.WriteLine(sqlQuery);
                        SqlCommand command = new SqlCommand(sqlQuery, connection);
                        connection.Open();
                        SqlDataReader dataReader = command.ExecuteReader();
                        while (dataReader.Read())
                        {
                            rdc_ID.Add(dataReader[0].ToString());
                            rdc_Description.Add(dataReader[1].ToString());
                        }
                        connection.Close();
                        comboBoxRDC.Items.Clear();

                        foreach (string id in rdc_Description)
                        {
                            comboBoxRDC.Items.Add(id);
                        }

                    }
                    catch (Exception error)
                    {
                        MessageBox.Show("Error in RDC enter: " + error);
                    }
                    if (comboBoxRDC.SelectedIndex == -1 && comboBoxRDC.Items.Count > 0) { comboBoxRDC.SelectedIndex = 0; }
                }
                if (rdc_Description.Count == 0)
                {
                    comboBoxRDC.Text = "";
                    comboBoxRDC.SelectedIndex = -1;
                    comboBoxDAU.SelectedIndex = -1;
                    comboBoxRDC_SelectedIndexChanged(sender, e);
                    
                }
            }
                
        }

        private void comboBoxRDC_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (old_RDC != comboBoxRDC.Text)
            {
                old_RDC = comboBoxRDC.Text;
                dau_ID.Clear();
                dau_Description.Clear();

                if (comboBoxRDC.SelectedIndex >= 0 && rdc_ID.Count > 0 && comboBoxRDC.Text.Length > 0)
                {
                    try
                    {
                        SqlConnection connection = new SqlConnection(connectSS_DB);


                        string sqlQuery = "SELECT DAU_ID,Description FROM DAU WHERE RDC_ID = '" + rdc_ID[comboBoxRDC.SelectedIndex] + "' ORDER BY DAU_ID ASC";
                        SqlCommand command = new SqlCommand(sqlQuery, connection);

                        connection.Open();
                        SqlDataReader dataReader = command.ExecuteReader();
                        while (dataReader.Read())
                        {
                            dau_ID.Add(dataReader[0].ToString());
                            dau_Description.Add(dataReader[1].ToString());
                        }

                        connection.Close();
                        comboBoxDAU.Items.Clear();

                        foreach (string id in dau_Description)
                        {
                            comboBoxDAU.Items.Add(id);
                        }

                    }
                    catch (Exception error)
                    {
                        MessageBox.Show("Error in DAU enter: " + error);
                    }
                    if (comboBoxDAU.SelectedIndex == -1 && comboBoxDAU.Items.Count > 0) { comboBoxDAU.SelectedIndex = 0; }
                }
                if (dau_Description.Count == 0)
                    comboBoxDAU.Text = "";
                if (dau_ID.Count == 0)
                {
                    comboBoxDAU.Items.Clear();
                    textBoxName.Clear();
                    comboBoxDAU_SelectedIndexChanged(sender, e);
                }
            }
        }

        private void comboBoxDAU_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (old_DAU != comboBoxDAU.Text)
            {
                if (comboBoxDAU.SelectedIndex >= 0 && comboBoxDAU.SelectedIndex <= dau_ID.Count && dau_ID.Count != 0)
                {
                    try
                    {
                        com_Port.Clear();
                        bit_Rate.Clear();

                        SqlConnection connection = new SqlConnection(connectSS_DB);
                        string sqlQuery = $"SELECT COM_Port, Bit_Rate FROM DAU WHERE DAU_ID = {dau_ID[comboBoxDAU.SelectedIndex]} ORDER BY COM_Port ASC";
                        SqlCommand command = new SqlCommand(sqlQuery, connection);
                        connection.Open();
                        SqlDataReader dataReader = command.ExecuteReader();

                        while (dataReader.Read())
                        {
                            com_Port.Add(dataReader[0].ToString());
                            bit_Rate.Add(dataReader[1].ToString());
                        }

                        connection.Close();
                        if (com_Port.Count > 0 && bit_Rate.Count > 0)
                        {
                            comboBoxComPort.Text = com_Port[0];
                            comboBoxBaudRate.Text = bit_Rate[0];
                        }

                    }
                    catch (Exception error)
                    {
                        MessageBox.Show("Error in SQL_DAU_SELECT: " + error);
                    }

                }
                if (comboBoxDAU.SelectedIndex <= comboBoxDAU.Items.Count && dau_ID.Count > 0 && comboBoxDAU.SelectedIndex != -1)
                {
                    try
                    {
                        name_Tag.Clear();
                        

                        SqlConnection connection = new SqlConnection(connectSS_DB);
                        string sqlQuery = $"SELECT Instrument_Tag FROM INSTRUMENT WHERE DAU_ID = {dau_ID[comboBoxDAU.SelectedIndex]} ORDER BY Instrument_Tag ASC";
                        SqlCommand command = new SqlCommand(sqlQuery, connection);
                        connection.Open();
                        SqlDataReader dataReader = command.ExecuteReader();

                        while (dataReader.Read())
                        {
                            name_Tag.Add(dataReader[0].ToString());
                        }

                        connection.Close();

                        textBoxName.Text = name_Tag[0];
                        
                    }
                    catch (Exception er)
                    {
                        MessageBox.Show("Error in SQL_INSTRUMENT_SELECT: " + er);
                    }
                    
                }
                old_DAU = comboBoxDAU.Text;
            }
            if (comboBoxDAU.SelectedIndex == -1)
            {
                comboBoxComPort.Text = "";
                comboBoxBaudRate.Text = "";
                textBoxName.Clear();
            }
        }

        private void textBoxName_TextChanged(object sender, EventArgs e)
        {
            if (textBoxName.Text.Length > 0)
            { 
                SQL_Read_Config(); 
            }
            else
            {
                textBoxLRV.Clear();
                textBoxURV.Clear();
                textBoxAlarmL.Clear();
                textBoxAlarmH.Clear();
                textBoxFrequencie.Clear();
                textBoxAnalog_Digital.Clear();
            }
        }

        //Starts Monitoring
        private void buttonStart_Click(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen && !writeconf && !readconf)
            {
                monitorStart = true;
                statusCheck = true;
                buttonStart.Enabled = false;
                buttonStop.Enabled = true;
                toolStripStatusLabelMonitoring.Visible = true;
                toolStripStatusLabelMStaus.Visible = true;
                send = true;
            }
        }

        //Stops Monitoring
        private void buttonStop_Click(object sender, EventArgs e)
        {
            monitorStart = false;
            statusCheck = false;
            buttonStop.Enabled = false;
            toolStripStatusLabelMonitoring.Visible = false;
            toolStripStatusLabelMStaus.Visible = false;

            if (serialPort1.IsOpen)
            {
                buttonStart.Enabled = true;
            }
        }   

        //Changes view of Data Raw/Scaled
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

        private void FormMain_Activated(object sender, EventArgs e)
        {
            if (!serialPort1.IsOpen)
            {
                comboBoxMCU.Focus();
            }
        }

        //Prevents user from closing program by accident
        private void FormMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (monitorStart)
            {
                string message = "You are monitoring do you want Exit?";
                string caption = "Exit Confirmation";

                DialogResult result = MessageBox.Show(this, message, caption, MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    e.Cancel = false;
                }
            }
        }
    }      
}
