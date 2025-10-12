using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Messaging_Application.Form2;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace Messaging_Application
{
    public partial class Sign_in_form : Form
    {
        //private string connectionString;
        internal string LoggedInEmail;
        public string ConnectionString = "Data Source=DESKTOP-ECS1L4V\\SQLEXPRESS;Initial Catalog=Text;Integrated Security=True;Encrypt=True;TrustServerCertificate=True";
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
            if (string.IsNullOrEmpty(tb_email_login.Text) || string.IsNullOrEmpty(tb_email_pass.Text))
            { MessageBox.Show("Please enter both username and password.");
                return;
            }
            SqlConnection con = new SqlConnection(ConnectionString);
            string query = "SELECT * FROM Log_in WHERE email = @Email AND password = @Password";

            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@Email", tb_email_login.Text);
            cmd.Parameters.AddWithValue("@Password", tb_email_pass.Text);

            con.Open();
            SqlDataReader reader = cmd.ExecuteReader();

            if (reader.HasRows)
            {
                MessageBox.Show("Login successful!");
            }
            else
            {
                MessageBox.Show("Invalid email or password.");
            }
            string email = tb_email_login.Text;
            //LoggedInUser.Email = email;
            //Form2 form2 = new Form2();
            Form2 form2 = new Form2(tb_email_login.Text.Trim());
            form2.Show();
            this.Hide();
        }

        private void tb_email_login_TextChanged(object sender, EventArgs e)
        {

        }

        private void tb_email_pass_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_logout_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();
        }
    }
}
