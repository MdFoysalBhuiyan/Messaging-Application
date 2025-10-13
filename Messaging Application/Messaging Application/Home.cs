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
        public string LabelText
       //string LoggedInUser 
        {
            get { return label1.Text; }
        }
    
        public Form2()
        {
            InitializeComponent();
            //CurrentUser = user;
        }
        public Form2(string email)
        {
            InitializeComponent();
            LoggedInUser = email; 
        }

        public string ConnectionString = "Data Source=DESKTOP-ECS1L4V\\SQLEXPRESS;Initial Catalog=Text;Integrated Security=True;Encrypt=True;TrustServerCertificate=True";
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
            Chat chatform = new Chat(LoggedInUser);
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
            if (LoggedInUser != null)
            {
                string connstring = ConnectionString;
                string query = "SELECT Full_Name, Image FROM Log_in WHERE Email = @Email";

                using (SqlConnection con = new SqlConnection(connstring))
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@Email", LoggedInUser.ToString());

                    con.Open();
                    SqlDataReader dr = cmd.ExecuteReader();
                    if (dr.Read())
                    {
                        label1.Text = dr["Full_Name"].ToString();

                        string imagePath = dr["Image"].ToString();
                        if (File.Exists(imagePath))
                        {
                            pictureBox1.Image = Image.FromFile(imagePath);
                        } 
                        else
                        {
                            pictureBox1.Image = null;
                        } 
                    }
                }
            }
            else
            {
                MessageBox.Show("No user is logged in.");
            }
        }

    }
}
