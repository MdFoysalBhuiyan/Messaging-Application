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
    public partial class UserControl3 : UserControl
    {
        public UserControl3()
        {
            InitializeComponent();
        }

        private string _title;
        public string Title
        {
            get { return _title; }
            set
            {
                _title = value;
                label1.Text = value;
            }
        }
        private Image _icon;
        public Image Icon
        {
            get { return _icon; }
            set
            {
                _icon = value;
                pictureBox1.Image = value;
                AddHeighttext();
            }
        }
        void AddHeighttext()
        {
            UserControl3 user = new UserControl3();
            user.BringToFront();
            label1.Height = UiList.GeTTextHeight(label1) + 10;
            user.Height = label1.Top + label1.Height;
            this.Height = user.Bottom + 10;
        }

        private void UserControl3_Load(object sender, EventArgs e)
        {
            AddHeighttext();
        }
    }
}
