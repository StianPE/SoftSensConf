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
    public partial class FormPassword : Form
    {
        public FormPassword()
        {
            InitializeComponent();
        }
        
        private void textBoxPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                FormMain.cancel = false;
                e.Handled = true;
                FormMain.configPassword = textBoxPassword.Text;
                this.Close();
                
            }
        }

        private void buttonPassword_Click(object sender, EventArgs e)
        {
            FormMain.cancel = false;
            FormMain.configPassword = textBoxPassword.Text;
            this.Close();
            
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            FormMain.cancel = true;
        }
    }
}
