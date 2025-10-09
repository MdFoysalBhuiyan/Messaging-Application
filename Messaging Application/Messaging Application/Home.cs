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
    public partial class Form2 : Form
    {
        //private User CurrentUser;
        public Form2()
        {
            InitializeComponent();
            //CurrentUser = user;
        }

        //Here need to add datareader to show user details


        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void btn_logout_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();
        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void bt_setting_Click(object sender, EventArgs e)
        {
            Setting settngform = new Setting();
            settngform.Show();
            this.Hide();
        }

        private void bt_chat_Click(object sender, EventArgs e)
        {
            Chat chatform = new Chat();
            chatform.Show();
            this.Hide();
        }
        private void bt_home_Click(object sender, EventArgs e)
        {
           Form2 form2 = new Form2();
           form2.Show();
           this.Hide();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
    }
}
