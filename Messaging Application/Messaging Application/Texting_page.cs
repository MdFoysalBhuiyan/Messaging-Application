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
        public Texting_page(string email, Image userImage)
        {
            InitializeComponent();
            LoggedInEmail = email; 
            UserImage = userImage;  
        }

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
            Chat chatform = new Chat();
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
            string receiverUser = labelReceiver.Text;
            string message = txt_box_for_type.Text;

            if (string.IsNullOrWhiteSpace(message))
                return;

            using (SqlConnection con = new SqlConnection(ConnectionString))
            {
                string query = "INSERT INTO Chat2 (Sender, Receiver, Message) VALUES (@Sender, @Receiver, @Message)";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@Sender", senderUser);
                cmd.Parameters.AddWithValue("@Receiver", receiverUser);
                cmd.Parameters.AddWithValue("@Message", message);
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
            }

            txt_box_for_type.Clear();
            DisplayMessages(senderUser, receiverUser); 


            /*
            SqlConnection con = new SqlConnection(ConnectionString);
            string q = "insert into Chat(userone,usertow,massage)values(@userone,@usertwo,@massage)";
            SqlCommand cmd = new SqlCommand(q, con);
            cmd.Parameters.AddWithValue("@userone", labelSender.Text);
            cmd.Parameters.AddWithValue("@usertwo", labelReceiver.Text);
            cmd.Parameters.AddWithValue("@massage", labelSender.Text);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
            MessageChat();
            //UserImage.Clear();
            // textBox1.Clear();
            */

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


        private void MessageChat()
        {
            SqlDataAdapter adapter;
            adapter = new SqlDataAdapter("select * from Chat2", ConnectionString);
            DataTable table = new DataTable();
            adapter.Fill(table);

            if (table != null)
            {
                UserControl2[] userControl2s = new UserControl2[table.Rows.Count];
                UserControl3[] userControl3s = new UserControl3[table.Rows.Count];

                for (int i = 0; i < 1; i++)
                {
                    foreach (DataRow row in table.Rows)
                    {
                        if (labelSender.Text == row["userone"].ToString() && labelReceiver.Text == row["usetwo"].ToString())
                        {
                            userControl2s[i] = new UserControl2();
                            userControl2s[i].Dock = DockStyle.Top;
                            userControl2s[i].BringToFront();
                            userControl2s[i].Title = row["Message"].ToString();

                            flowLayoutPanel2.Controls.Add(userControl2s[i]);
                            flowLayoutPanel2.ScrollControlIntoView(userControl2s[i]);
                        }

                        else if (labelSender.Text == row["userone"].ToString() && labelReceiver.Text == row["usertwo"].ToString())
                        {
                            userControl3s[i] = new UserControl3();
                            userControl3s[i].Dock = DockStyle.Top;
                            userControl3s[i].BringToFront();
                            userControl3s[i].Title = row["Message"].ToString();
                            userControl3s[i].Icon = pictureBox2.Image; 

                            flowLayoutPanel2.Controls.Add(userControl3s[i]);
                            flowLayoutPanel2.ScrollControlIntoView(userControl3s[i]);


                        }
                    }
                }
            }

        } 

      /*  private void MessageChat()
        {
            SqlDataAdapter adapter;
            adapter = new SqlDataAdapter("select * from Chat", ConnectionString);
            DataTable table = new DataTable();

            if (table.Rows.Count > 0)
            {
                List<UserControl2> userControl2s = new List<UserControl2>();
                List<UserControl3> userControl3s = new List<UserControl3>();

                foreach (DataRow row in table.Rows)
                {
                    if (LoggedInEmail == row["userone"].ToString() && label2.Text == row["usertwo"].ToString() ||
                        LoggedInEmail == row["usertwo"].ToString() && label2.Text == row["userone"].ToString())
                    {
                        if (LoggedInEmail == row["userone"].ToString())
                        {
                            UserControl2 userControl2 = new UserControl2();
                            userControl2.Dock = DockStyle.Top;
                            userControl2.BringToFront();
                            userControl2.Title = row["message"].ToString();

                            userControl2s.Add(userControl2);
                            flowLayoutPanel2.Controls.Add(userControl2);
                            flowLayoutPanel2.ScrollControlIntoView(userControl2);
                        }
                        else if (LoggedInEmail == row["usertwo"].ToString())
                        {
                            UserControl3 userControl3 = new UserControl3();
                            userControl3.Dock = DockStyle.Top;
                            userControl3.BringToFront();
                            userControl3.Title = row["message"].ToString();
                            userControl3.Icon = pictureBox2.Image;

                            userControl3s.Add(userControl3);
                            flowLayoutPanel2.Controls.Add(userControl3);
                            flowLayoutPanel2.ScrollControlIntoView(userControl3);
                        }
                    }
                }
            }
        } */

        private void userControl12_Load(object sender, EventArgs e)
        {
            if(panel3.Visible == false && panel4.Visible == false && flowLayoutPanel2.Visible == false)
            {
                panel3.Visible = true;
                panel4.Visible = true;
                flowLayoutPanel2.Visible = true;
            }

            UserControl1 Control = (UserControl1)sender;
            labelReceiver.Text = Control.Text1;
            pictureBox2.Image = Control.Image1;
            MessageChat();
        }


        /*private void UserItem(Usercontrol1[] userControl, Usercontrol1[] userControls)
        {
            flowLayoutPanel1.Controls.Clear();
            SqlDataAdapter adapter;
            adapter = new SqlDataAdapter("Select * form Sign In", constring);
            DataTable table = new DataTable();
            adapter.Fill(table);
            if(table!= null)
            {
                if (table.Rows.Count > 0)
                {
                    Usercontrol1[] userControls = new Usercontrol1[table.Rows.Count];
                    for (int i = 0; i < 1; i++)
                    {
                        foreach (DataRow row in table.Rows)
                        {
                            userControls[i] = new Usercontrol1();
                            MemoryStream stream = new MemoryStream((byte[])row["Image"]);
                            userControls[i].Image1 = Image.FromStream(stream);
                            userControls[i].Title = row["FullName"].ToString();

                            if (userControl[i].Title == label1.Text)
                            {
                                flowLayoutPanel1.Controls.Remove(userControls[i]);
                            }
                            else
                            {
                                flowLayoutPanel1.Controls.Add(userControls[i]);
                            }
                            userControls[i].Click += new System.EventHandler(this.bt_chat_Click);
                        }
                    }
                }
            } */

    }
    }
