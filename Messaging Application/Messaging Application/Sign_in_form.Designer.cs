namespace Messaging_Application
{
    partial class Sign_in_form
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btn_Exit = new System.Windows.Forms.Label();
            this.btn_login = new System.Windows.Forms.Label();
            this.mail = new System.Windows.Forms.Label();
            this.pass = new System.Windows.Forms.Label();
            this.tb_email_login = new System.Windows.Forms.TextBox();
            this.tb_email_pass = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(514, 720);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Messaging_Application.Properties.Resources.chat;
            this.pictureBox1.Location = new System.Drawing.Point(-1, 96);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(512, 512);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // btn_Exit
            // 
            this.btn_Exit.AutoSize = true;
            this.btn_Exit.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.btn_Exit.Font = new System.Drawing.Font("Arial Rounded MT Bold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Exit.ForeColor = System.Drawing.Color.OrangeRed;
            this.btn_Exit.Location = new System.Drawing.Point(1240, 9);
            this.btn_Exit.Name = "btn_Exit";
            this.btn_Exit.Size = new System.Drawing.Size(28, 30);
            this.btn_Exit.TabIndex = 6;
            this.btn_Exit.Text = "X";
            this.btn_Exit.Click += new System.EventHandler(this.btn_Exit_Click);
            // 
            // btn_login
            // 
            this.btn_login.AutoSize = true;
            this.btn_login.BackColor = System.Drawing.Color.Gainsboro;
            this.btn_login.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.btn_login.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_login.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_login.Location = new System.Drawing.Point(771, 574);
            this.btn_login.Name = "btn_login";
            this.btn_login.Size = new System.Drawing.Size(119, 34);
            this.btn_login.TabIndex = 5;
            this.btn_login.Text = "SIGN IN";
            this.btn_login.Click += new System.EventHandler(this.btn_login_Click);
            // 
            // mail
            // 
            this.mail.AutoSize = true;
            this.mail.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mail.Location = new System.Drawing.Point(584, 359);
            this.mail.Name = "mail";
            this.mail.Size = new System.Drawing.Size(67, 22);
            this.mail.TabIndex = 7;
            this.mail.Text = "Email:";
            // 
            // pass
            // 
            this.pass.AutoSize = true;
            this.pass.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pass.Location = new System.Drawing.Point(584, 438);
            this.pass.Name = "pass";
            this.pass.Size = new System.Drawing.Size(106, 22);
            this.pass.TabIndex = 7;
            this.pass.Text = "Password:";
            // 
            // tb_email_login
            // 
            this.tb_email_login.Location = new System.Drawing.Point(588, 400);
            this.tb_email_login.Name = "tb_email_login";
            this.tb_email_login.Size = new System.Drawing.Size(488, 20);
            this.tb_email_login.TabIndex = 1;
            this.tb_email_login.TextChanged += new System.EventHandler(this.tb_email_login_TextChanged);
            // 
            // tb_email_pass
            // 
            this.tb_email_pass.Location = new System.Drawing.Point(588, 480);
            this.tb_email_pass.Name = "tb_email_pass";
            this.tb_email_pass.PasswordChar = '*';
            this.tb_email_pass.Size = new System.Drawing.Size(488, 20);
            this.tb_email_pass.TabIndex = 2;
            this.tb_email_pass.TextChanged += new System.EventHandler(this.tb_email_pass_TextChanged);
            // 
            // Sign_in_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1280, 720);
            this.Controls.Add(this.tb_email_pass);
            this.Controls.Add(this.tb_email_login);
            this.Controls.Add(this.pass);
            this.Controls.Add(this.mail);
            this.Controls.Add(this.btn_login);
            this.Controls.Add(this.btn_Exit);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Sign_in_form";
            this.Text = "Sign_in_form";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label btn_Exit;
        private System.Windows.Forms.Label btn_login;
        private System.Windows.Forms.Label mail;
        private System.Windows.Forms.Label pass;
        private System.Windows.Forms.TextBox tb_email_login;
        private System.Windows.Forms.TextBox tb_email_pass;
    }
}