using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Messaging_Application
{
    public partial class Texting_page : Form
    {
        private string constring;
        private object label1;
        public string ConnectionString = "Data Source=DESKTOP-ECS1L4V\\SQLEXPRESS;Initial Catalog=Text;Integrated Security=True;Encrypt=True;TrustServerCertificate=True";
        public string LoggedInEmail { get; set; }
        public Image UserImage { get; set; } 
        public Texting_page(string email)
        {
            InitializeComponent();
            //LoggedInEmail = email; 
            LoggedInUser = email;
            //UserImage = userImage;  
            //labelSender.Text = LoggedInUser;
            labelSender.Text = GetFullName(LoggedInUser);
            labelReceiver.Text = GetReceiverEmail(LoggedInUser);
        }

        public string LoggedInUser { get; set; }

        public Texting_page()
        {
            InitializeComponent();
        }

        private void bt_setting_Click(object sender, EventArgs e)
        {
            Setting settngform = new Setting();
            settngform.Show();
            this.Hide();
        }
        private void bt_home_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();
            this.Hide();
        }

        private void Bt_chat_Click(object sender, EventArgs e)
        {
            Chat chatform = new Chat(LoggedInUser);
            chatform.Show();
            this.Hide();
        }

        private void btn_logout_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();
        }

        private void btn_send_Click(object sender, EventArgs e)
        {

            string senderUser = labelSender.Text;
            //string senderUser = LoggedInUser;
            string receiverUser = labelReceiver.Text;
            string message = txt_box_for_type.Text;

            if (string.IsNullOrWhiteSpace(message))
                return;

            using (SqlConnection con = new SqlConnection(ConnectionString))
            {
                string q = "INSERT INTO Chat2 (Sender, Receiver, Message) VALUES (@Sender, @Receiver, @Message)";
                SqlCommand cmd = new SqlCommand(q, con);
                cmd.Parameters.AddWithValue("@Sender", senderUser);
                cmd.Parameters.AddWithValue("@Receiver", receiverUser);
                cmd.Parameters.AddWithValue("@Message", message);
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
            }

            txt_box_for_type.Clear();
            DisplayMessages(senderUser, receiverUser); 

        }
        private void DisplayMessages(string senderUser, string receiverUser)
        {
            using (SqlConnection con = new SqlConnection(ConnectionString))
            {
                string query = @"
            SELECT Sender, Message, Timestamp 
            FROM Chat2 
            WHERE (Sender = @Sender AND Receiver = @Receiver) 
               OR (Sender = @Receiver AND Receiver = @Sender)
            ORDER BY Timestamp";

                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@Sender", senderUser);
                cmd.Parameters.AddWithValue("@Receiver", receiverUser);

                con.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                listBox1.Items.Clear();

                while (reader.Read())
                {
                    string Chat2 = $"{reader["Sender"]}: {reader["Message"]} ({reader["Timestamp"]})";
                    listBox1.Items.Add(Chat2);
                }
                con.Close();
            }
        }

        private void userControl12_Load(object sender, EventArgs e)
        {

        }

        private string GetReceiverEmail(string senderEmail)
        {
            string receiverEmail = "";

            using (SqlConnection con = new SqlConnection(ConnectionString))
            {
                string query = @"
                SELECT TOP 1 
                    CASE 
                        WHEN Chat2.Sender = @Sender THEN Chat2.Receiver
                        ELSE Chat2.Sender 
                    END AS ReceiverEmail
                FROM Chat2
                WHERE (Chat2.Sender = @Sender OR Chat2.Receiver = @Sender)
                AND Chat2.Sender != @Sender
                ORDER BY Chat2.Timestamp DESC";

                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@Sender", senderEmail);

                    con.Open();
                    SqlDataReader reader = cmd.ExecuteReader();
                    if (reader.Read())
                    {
                        receiverEmail = reader["ReceiverEmail"].ToString(); 
                    }
                    con.Close();
                }
            }

            return receiverEmail;
        }

        private void Texting_page_Load(object sender, EventArgs e)
        {
            timer1.Start();

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
                        labelSender.Text = dr["Full_Name"].ToString();
                    }
                }
            }
            else
            {
                MessageBox.Show("No user is logged in.");
            }
        }
        private string GetFullName(string email)
        {
            using (SqlConnection con = new SqlConnection(ConnectionString))
            {
                string query = "SELECT Full_Name FROM Log_in WHERE Email = @Email";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@Email", email);

                con.Open();
                var result = cmd.ExecuteScalar();
                return result?.ToString() ?? email;
            }
        }


        private void timer1_Tick(object sender, EventArgs e)
        {
            DisplayMessages(labelSender.Text, labelReceiver.Text);
        }
    }
    }
