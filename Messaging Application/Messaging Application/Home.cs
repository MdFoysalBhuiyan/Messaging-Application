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
            if (LoggedInUser != null)
            {
                label1.Text = LoggedInUser.ToString(); 

                //string connstring = DataAcess.ConnectionString;

                string connstring = ConnectionString;
                string query = "SELECT Full_Name, Image FROM Log_in WHERE Email = @Email";

                using (SqlConnection con = new SqlConnection(connstring))
                {
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@Email", LoggedInUser.ToString()); 

                    try
                    {
                        con.Open();
                        SqlDataReader dr = cmd.ExecuteReader();
                        if (dr.Read())
                        {
                            label1.Text = dr["Full_Name"].ToString();  

                            byte[] imageBytes = dr["Image"] as byte[];
                            if (imageBytes != null)
                            {
                                MemoryStream ms = new MemoryStream(imageBytes);
                                pictureBox1.Image = Image.FromStream(ms);
                            }
                            else
                            {
                                pictureBox1.Image = null;  
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error: " + ex.Message);  
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
