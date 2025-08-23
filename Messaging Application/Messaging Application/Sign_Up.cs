using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Messaging_Application
{
    public partial class Sign_Up : Form
    {
        //private string ImageLocation;

        public Sign_Up()
        {
            InitializeComponent();
        }

        private void btn_signUp_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(pictureBox2.ImageLocation))
            {
                MessageBox.Show("Please select an image first.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else if (string.IsNullOrEmpty(tbFullname.Text) || string.IsNullOrEmpty(tb_password.Text) || string.IsNullOrEmpty(tb_con_pass.Text)|| string.IsNullOrEmpty(tb_email.Text) )
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
                //Password = tb_password.Text,
                Email = tb_email.Text,
                Image = pictureBox2.ImageLocation
            };

            Form2 form2 = new Form2();
            form2.Show();
            this.Hide();

        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btm_picture_Click(object sender, EventArgs e)
        {
            //string ImageLocation = string.Empty;
            string ImageLocation = "";
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
    }
}
