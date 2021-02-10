using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Arbeidskrav_1
{
    public partial class FormMain : Form
    {
        bool connected = false;
        public FormMain()
        {
            InitializeComponent();
        }

        private void toolStripMenuItemExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonConnect_Click(object sender, EventArgs e)
        {
            if (comboBoxComPort.Text.Length < 3)
            {
                MessageBox.Show("No COM Port selected");
            }

            if (!connected && comboBoxComPort.Text.Length > 3 /*&& comboBoxBaudRate.Text.Length > 3*/)
            {
                serialPort1.PortName = comboBoxComPort.Text;
                if (comboBoxBaudRate.Text.Length < 2) comboBoxBaudRate.Text = "9600";
                serialPort1.BaudRate = Convert.ToInt32(comboBoxBaudRate.Text); 
                serialPort1.Open();
                connected = true;
                textBoxConnection.Text = "Connected";
                toolStripStatusLabel1.Text = "COM Status: Connected";
                toolStripProgressBarConnection.Value = 100;
                

            }
        }

        private void buttonDisconnect_Click(object sender, EventArgs e)
        {
            if (connected)
            {
                serialPort1.Close();
                connected = false;
                textBoxConnection.Text = "Disconnected";
                toolStripStatusLabel1.Text = "COM Status: Disconnected";
                toolStripProgressBarConnection.Value = 0;
            }
        }

        private void comboBoxComPort_Enter(object sender, EventArgs e)
        {
            string[] ComPorts = System.IO.Ports.SerialPort.GetPortNames();
            comboBoxComPort.Items.Clear();
            foreach (var item in ComPorts)
            {
                comboBoxComPort.Items.Add(item);
            }
            if (ComPorts.Length > 0)
            {
                comboBoxComPort.Text = comboBoxComPort.GetItemText(ComPorts[0]);
            }
        }

        private void comboBoxBaudRate_Enter(object sender, EventArgs e)
        {
            if (comboBoxBaudRate.Text.Length < 2)
            {
                comboBoxBaudRate.Text = "9600";
            }
        }

        private void toolStripMenuItemAbout_Click(object sender, EventArgs e)
        {
            AboutBoxSSC aboutWindow = new AboutBoxSSC();
            aboutWindow.ShowDialog(this);
        }
    }
}
