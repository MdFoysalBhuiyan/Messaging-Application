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

namespace Messaging_Application
{
    public partial class Sign_in_form : Form
    {
        private string connectionString;
        internal string LoggedInEmail;

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
            SqlConnection con = new SqlConnection(DataAcess.Connection_String);

            string query = "SELECT COUNT(1) FROM Log_in WHERE Email = @Email AND Password = @Password";

            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@Email", tb_email_login.Text);
                cmd.Parameters.AddWithValue("@Password", tb_email_pass.Text);
                int userExists = Convert.ToInt32(cmd.ExecuteScalar());
                if (userExists == 1)
                {
                    Form2 form2 = new Form2();
                    form2.Show();
                    this.Hide(); 
                }
                else
                {
                    MessageBox.Show("Invalid email or password. Please try again.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                con.Close();
            }
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
