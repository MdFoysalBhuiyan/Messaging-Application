using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Messaging_Application
{
    public partial class Sign_in_form : Form
    {
        public Sign_in_form()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(tb_email_login.Text) || string.IsNullOrEmpty(tb_email_pass.Text))
            {
                MessageBox.Show("Please enter both username and password.");
                return;
            }
            Form2 form2 = new Form2();
            form2.Show();
            this.Hide();
        }
    }
}
