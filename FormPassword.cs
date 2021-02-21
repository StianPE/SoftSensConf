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
                e.Handled = true;
                buttonPassword_Click(sender, e);
            }
        }

        private void buttonPassword_Click(object sender, EventArgs e)
        {
           
            FormMain.cancel = false;
            FormMain.configPassword = textBoxPassword.Text;
            if (textBoxPassword.Text.Length >= 8)
                this.Close();
            else
                MessageBox.Show(this,"Password Too Short (Minimum 8 characters)","Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {   
            FormMain.cancel = true;
        }
    }
}
