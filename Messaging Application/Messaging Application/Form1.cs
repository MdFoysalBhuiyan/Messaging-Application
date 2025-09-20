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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            btn_signin_1.Click += btn_signin_Click_1;
            btn_SignUp_1.Click += btn_SignUp_Click_1;
        }

        private void Form1_Load(object sender, EventArgs e)
        { 

        }
        private void btn_Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_signin_Click_1(object sender, EventArgs e)
        {
            Sign_in_form signInForm = new Sign_in_form();
            signInForm.Show();
            this.Hide();
        }

        private void btn_SignUp_Click_1(object sender, EventArgs e)
        {
            Sign_Up signUpForm = new Sign_Up();
            signUpForm.Show();
            this.Hide();
        }

    }
}
