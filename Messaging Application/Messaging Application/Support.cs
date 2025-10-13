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
    public partial class Support : Form
    {
        public string LoggedInUser { get; set; }
        public Support(string email)
        {
            InitializeComponent();
            LoggedInUser = email;
        }
        public string ConnectionString = "Data Source=DESKTOP-ECS1L4V\\SQLEXPRESS;Initial Catalog=Text;Integrated Security=True;Encrypt=True;TrustServerCertificate=True";
        private void btn_logout_Click(object sender, EventArgs e)
        {

        }

        private void btn_send_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(ConnectionString);
            con.Open();
            string q = "INSERT INTO Chat(userone, usertwo, massage) VALUES (@userone, @usertwo, @massage)";
            SqlCommand cmd = new SqlCommand(q, con);
            
            cmd.Parameters.AddWithValue("@userone", LoggedInUser);
            cmd.Parameters.AddWithValue("@usertwo", labelReceiver.Text);
            cmd.Parameters.AddWithValue("@massage", txt_box_for_type);
            con.Close();
            MessageChat();
            txt_box_for_type.Clear();
        }
        private void MessageChat()
        {
            SqlDataAdapter adapter;
            adapter = new SqlDataAdapter("select * from Chat", ConnectionString);
            DataTable table = new DataTable();
            adapter.Fill(table);

            if (table!= null)
            {
                UserControl2[] userControl2s = new UserControl2[table.Rows.Count];
                UserControl3[] userControl3s = new UserControl3[table.Rows.Count];

                for(int i =0; i<1; i++)
                {

                foreach (DataRow row in table.Rows)
                {
                    if (LoggedInUser == row["userone"].ToString() && labelReceiver.Text == row["usertwo"].ToString()) 
                    {
                            userControl2s[i] = new UserControl2();
                            userControl2s[i].Dock = DockStyle.Top;
                            userControl2s[i].BringToFront();
                            userControl2s[i].Title = row["message"].ToString();

                            flowLayoutPanel2.Controls.Add(userControl2s[i]);
                            flowLayoutPanel2.ScrollControlIntoView(userControl2s[i]);
                    }
                    else if (labelReceiver.Text == row["userone"].ToString() && LoggedInUser == row["usertwo"].ToString())
                        {
                            userControl3s[i] = new UserControl3();
                            userControl3s[i].Dock = DockStyle.Top;
                            userControl3s[i].BringToFront();
                            userControl3s[i].Title = row["message"].ToString();
                            userControl3s[i].Icon = pictureBox2.Image;

                            flowLayoutPanel2.Controls.Add(userControl3s[i]);
                            flowLayoutPanel2.ScrollControlIntoView(userControl3s[i]);
                        }
                    }
                }
            }
        }

        private void UserItem()
        {
            flowLayoutPanel1.Controls.Clear();
            SqlDataAdapter adapter;
            adapter = new SqlDataAdapter("select * from Log_in", ConnectionString);
            DataTable table = new DataTable();
            adapter.Fill(table);

            if (table != null)
            {
                if (table.Rows.Count > 0)
                {
                    Usercontrol1[] userControls = new Usercontrol1[table.Rows.Count];
                    for (int i = 0; i < 1; i++)
                    {
                        foreach (DataRow row in table.Rows)
                        {
                            userControls[i] = new Usercontrol1();
                            MemoryStream ms = new MemoryStream((byte[])row["Image"]);
                            //userControls[i].Icon = new Bitmap(ms);
                            userControls[i].Title = row["Full_Name"].ToString();
                        }
                    }
                }
            }
        }

        private void userControl31_Load(object sender, EventArgs e)
        {

        }

        private void bt_chat_Click(object sender, EventArgs e)
        {
            Chat chatfrom = new Chat(LoggedInUser);
            chatfrom.Show();
            this.Hide();
        }

        private void bt_home_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();
            this.Hide();
        }

        private void bt_setting_Click(object sender, EventArgs e)
        {
            Setting settngform = new Setting();
            settngform.Show();
            this.Hide();
        }
    }
}
