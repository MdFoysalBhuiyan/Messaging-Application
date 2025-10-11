using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;

namespace Messaging_Application
{
    public partial class Sign_Up : Form
    {
        private string constring;

        DataAcess dataAccess;

        string connstring = DataAcess.Connection_String;

        string ConnectionString = "Data Source=DESKTOP-ECS1L4V\\SQLEXPRESS;Initial Catalog=Text;Integrated Security=True;Encrypt=True;Trust Server Certificate=True";
        public Sign_Up()
        {
            InitializeComponent();
            dataAccess = new DataAcess();
            PopulateCombobox<UserTypeEnum>(cb);
        }

        //string constring1 = DataAcess.Connection_String;

        //private string ImageLocation;

        /* public Sign_Up()
         {
             InitializeComponent();
         }
        */
        private void cb_SelectedIndexChanged(object sender, EventArgs e)
        {
            MessageBox.Show(cb.SelectedValue.ToString());
        }

        public static class EnumHelper
        {
            public static List<KeyValuePair<string, T>> GetEnumDescriptionAndValue<T>()
            {
                return Enum.GetValues(typeof(T))
                           .Cast<T>()
                           .Select(e =>
                               new KeyValuePair<string, T>(GetEnumDescription(e), e))
                           .ToList();
            }

            private static string GetEnumDescription<T>(T value)
            {
                var fieldInfo = value.GetType().GetField(value.ToString());

                var descriptionAttribute = (DescriptionAttribute[])fieldInfo
                    .GetCustomAttributes(typeof(DescriptionAttribute), false);

                return descriptionAttribute.Length > 0
                    ? descriptionAttribute[0].Description
                    : value.ToString();
            }
        }

        private void PopulateCombobox<T>(ComboBox cb)
        {
            var usertypes = EnumHelper.GetEnumDescriptionAndValue<T>();

            cb.DisplayMember = "Key";
            cb.ValueMember = "Value";

            cb.DataSource = usertypes;
        }

        //string constring = "Data Source=DESKTOP-ECS1L4V\SQLEXPRESS;Initial Catalog=Text;Integrated Security=True;Trust Server Certificate=True";
        private void btn_signUp_Click(object sender, EventArgs e)  //sign up button
        {

            /*if (pictureBox2.Image == null)
            {
                MessageBox.Show("Select Photo");
            }
            */

            if (string.IsNullOrEmpty(pictureBox2.ImageLocation))
            {
                MessageBox.Show("Please select an image first.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if (string.IsNullOrEmpty(tbFullname.Text) || string.IsNullOrEmpty(tb_password.Text) || string.IsNullOrEmpty(tb_con_pass.Text) || string.IsNullOrEmpty(tb_email.Text))
            {
                MessageBox.Show("Please fill in all fields.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else if (tb_password.Text != tb_con_pass.Text)
            {
                MessageBox.Show("Passwords do not match.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            User user1 = new User
            {
                Username = tbFullname.Text,
                Password = tb_password.Text,
                Email = tb_email.Text,
                Image = pictureBox2.ImageLocation
            };

            //database code temporary
            /* SqlConnection con = new SqlConnection(ConnectionString);
            string q = "Insert into Sign_Up(Full_Name,Email,Password,Confirm_Password,Image)values(@Full_Name,@Email,@Password,@Confirm_Passord,@Image)";
            SqlCommand cmd = new SqlCommand(q, con);
            MemoryStream ms = new MemoryStream();
            pictureBox2.Image.Save(ms, pictureBox2.Image.RawFormat);
            cmd.Parameters.AddWithValue("@Full_Name", tbFullname.Text);
            cmd.Parameters.AddWithValue("@Email", tb_email.Text);
            cmd.Parameters.AddWithValue("@Password", tb_password.Text);
            cmd.Parameters.AddWithValue("@Confirm_Passord", tb_con_pass.Text);
            //cmd.Parameters.AddWithValue("@Image", ms.ToArray());
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
            */

            string connstring = DataAcess.ConnectionString; 

            string q = "INSERT INTO Sign_Up (Full_Name, Email, Password, Confirm_Password, Image) " +
                       "VALUES (@Full_Name, @Email, @Password, @Confirm_Password, @Image)";
            SqlCommand cmd = new SqlCommand(q);
            cmd.Parameters.AddWithValue("@Full_Name", tbFullname.Text);
            cmd.Parameters.AddWithValue("@Email", tb_email.Text);
            cmd.Parameters.AddWithValue("@Password", tb_password.Text);
            cmd.Parameters.AddWithValue("@Confirm_Password", tb_con_pass.Text);
            MemoryStream ms = new MemoryStream();
            pictureBox2.Image.Save(ms, pictureBox2.Image.RawFormat);
            cmd.Parameters.AddWithValue("@Image", ms.ToArray());

            int results = dataAccess.ExecuteNonQuery(q);
            if (results > 0)
            {
                MessageBox.Show("Registration Success.");
            }

            tbFullname.Clear();
            tb_email.Clear();
            tb_password.Clear();
            tb_con_pass.Clear();
            pictureBox2.Image = null;

            tbFullname.Clear();
            Form2 form2 = new Form2();
            form2.Show();
            this.Hide();

            //MessageBox.Show("Sign up Successfully");

        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btm_picture_Click(object sender, EventArgs e)
        {
            //string ImageLocation = string.Empty;
            //string ImageLocation = "";
            try
            {
                OpenFileDialog dialog = new OpenFileDialog();

                dialog.Filter = "jpg files (*.jpg)|*.jpg|All files (*.*)|*.*";
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    pictureBox2.ImageLocation = dialog.FileName;
                    //pictureBox2.ImageLocation = ImageLocation;
                    pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        private void Sign_Up_Load(object sender, EventArgs e)
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
