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

        private void bt_chat_Click(object sender, EventArgs e)
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
            SqlConnection con = new SqlConnection(constring);
            con.Open();
            string q = "insert into chat(userone,usertow,massage)values(userone=@userone,usertwo=@usertwo,massage=@massage";
            SqlCommand cmd = new SqlCommand(q, con);
            cmd.Parameters.AddWithValue("@userone", ); //need to add something here like users details
            cmd.Parameters.AddWithValue("@usertwo",  );
            cmd.Parameters.AddWithValue("@massage", );
            con.Close();
            MessageChat();
           // textBox1.Clear();
        }

        private void MessageChat()
        {
            SqlDataAdapter adapter;
            adapter = new SqlDataAdapter("Select * from chat where userone=@userone and usertwo=@usertwo or userone=@usertwo and usertwo=@userone", constring);
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
                        if ( .Text == row["userone"].ToString() && .Text == row["usetwo"].ToString())
                        {
                            UserControl2[i] = new UserControl2();
                            UserControl2[i].Dock = DockStyle.Top;
                            UserControl2[i].BringToFront();
                            UserControl2[i].Title = row["massage"].ToString();

                            flowLayoutPanel2.Controls.Add(UserControl2[i]);
                            flowLayoutPanel2.ScrollControlIntoView(UserControl2[i]);
                        }

                        else if ( .Text == row["userone"].ToString() && .Text == row["usertwo"].ToString())
                        {
                            UserControl3[i] = new UserControl3();
                            UserControl3[i].Dock = DockStyle.Top;
                            UserControl3[i].BringToFront();
                            UserControl3[i].Title = row["massage"].ToString();
                            UserControl3[i].Icon = pictureBox2.Image; 

                            flowLayoutPanel2.Controls.Add(UserControl3[i]);
                            flowLayoutPanel2.ScrollControlIntoView(UserControl3[i]);


                        }
                    }
                }
            }

        }
        private void userControl12_Load(object sender, EventArgs e)
        {
            if(panel3.Visible == false && panel4.Visible == false && flowLayoutPanel2.Visible == false)
            {
                panel3.Visible = true;
                panel4.Visible = true;
                flowLayoutPanel2.Visible = true;
            }

            UserControl1 Control = (UserControl1)sender;

            .Text = Control.Text1;
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

