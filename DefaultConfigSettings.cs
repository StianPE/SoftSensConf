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

namespace Arbeidskrav_1
{
    public partial class DefaultConfigSettings : Form
    {
        public DefaultConfigSettings()
        {
            InitializeComponent();
        }

        bool configCheck()
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
                return false;
            }
            else if (textBoxLRV.Text.Length == 0)
            {
                caption = "Empty Text Field";
                message = "Enter Low Range Value";
                result = MessageBox.Show(this, message, caption, buttons, icon);
                textBoxLRV.Focus();
                return false;
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
                fConVal = Convert.ToSingle(textBoxLRV.Text);
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
            catch (OverflowException)
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
            catch (OverflowException)
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
        string configMake()
        {
            string data = string.Format("{0};{1};{2};{3};{4}", textBoxName.Text, textBoxLRV.Text, textBoxURV.Text,
                                                                                        textBoxAlarmL.Text, textBoxAlarmH.Text);
            return data;
        }
        private void buttonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormDefaultConfigSettings_Load(object sender, EventArgs e)
        {
            string configtxt = File.ReadAllText("Default_Config.ssc");
            string[] config = configtxt.Split(';');
            textBoxCName.Text = config[0];
            textBoxCLRV.Text = config[1];
            textBoxCURV.Text = config[2];
            textBoxCAlarmL.Text = config[3];
            textBoxCAlarmH.Text = config[4];
        }

        private void buttonSaveDefaultConfig_Click(object sender, EventArgs e)
        {
            if (configCheck())
            {
                File.WriteAllText("Default_Config.ssc", configMake());
                
                textBoxCName.Text = textBoxName.Text;
                textBoxCLRV.Text = textBoxLRV.Text;
                textBoxCURV.Text = textBoxURV.Text;
                textBoxCAlarmL.Text = textBoxAlarmL.Text;
                textBoxCAlarmH.Text = textBoxAlarmH.Text;
            }
        }

        private void buttonLoadDefaultConfig_Click(object sender, EventArgs e)
        {
            var fileName = string.Empty;
            string configtxt = "";
            string[] config = { };

            openFileDialog1.InitialDirectory = @"";
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
    }
}
