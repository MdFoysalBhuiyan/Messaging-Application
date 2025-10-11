using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
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

        string connectionString = DataAcess.Connection_String;

        public string LoggedInUser { get; set; }

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
            label1.Text = LoggedInUser;
            byte[] getimage = new byte[0];
            SqlConnection con = new SqlConnection(connectionString);
            con.Open();
            string q = "select * from Log_in where Email = '" + label1.Text + "'";
            SqlCommand cmd = new SqlCommand(q, con);
            SqlDataReader dr = cmd.ExecuteReader();
            dr.Read();
            if (dr.HasRows)
            {
                label1.Text = dr[0].ToString();
                byte[] images = (byte[])(dr["image"]);
                if (images == null)
                {
                    pictureBox1.Image = null;
                }
                else
                {
                    MemoryStream ms = new MemoryStream(images);
                    pictureBox1.Image = Image.FromStream(ms);
                }
            }
            con.Close();

        }


    }
}
