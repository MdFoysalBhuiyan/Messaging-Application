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
    public partial class UserControl2 : UserControl
    {
        public UserControl2()
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
                label1.Text = value; // Update the label 
            }
        }
        void AddHeighttext()
        {
            UserControl2 user = new UserControl2();
            user.BringToFront();
            label1.Height = UiList.GeTTextHeight(label1)+10;
            user.Height = label1.Top + label1.Height;
            this.Height = user.Bottom+10;
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
