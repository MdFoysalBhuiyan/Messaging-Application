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
    public partial class UserControl1 : UserControl
    {
        public UserControl1()
        {
            InitializeComponent();
        }

        private string _text;
        public string Text1
        {
            get { return _text; }
            set 
            { 
                _text = value;
                label1.Text = value; // Update the label 
            }
        }

        private Image _image;
        public Image Image1
        {
            get { return _image; }
            set 
            { 
                _image = value;
                pictureBox_form_chat.Image = value; // Update the picture
            }
        }

        private void UserControl1_Load(object sender, EventArgs e)
        {

        }
    }
}
