namespace Messaging_Application
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.btn_signin = new System.Windows.Forms.Label();
            this.btn_SignUp = new System.Windows.Forms.Label();
            this.btn_Exit = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // btn_signin
            // 
            this.btn_signin.AutoSize = true;
            this.btn_signin.BackColor = System.Drawing.Color.Gainsboro;
            this.btn_signin.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.btn_signin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_signin.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_signin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(42)))), ((int)(((byte)(68)))));
            this.btn_signin.Location = new System.Drawing.Point(414, 452);
            this.btn_signin.Name = "btn_signin";
            this.btn_signin.Size = new System.Drawing.Size(109, 34);
            this.btn_signin.TabIndex = 3;
            this.btn_signin.Text = "Sign In";
            this.btn_signin.Click += new System.EventHandler(this.btn_signin_Click);
            // 
            // btn_SignUp
            // 
            this.btn_SignUp.AutoSize = true;
            this.btn_SignUp.BackColor = System.Drawing.Color.Gainsboro;
            this.btn_SignUp.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.btn_SignUp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_SignUp.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_SignUp.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(42)))), ((int)(((byte)(68)))));
            this.btn_SignUp.Location = new System.Drawing.Point(698, 452);
            this.btn_SignUp.Name = "btn_SignUp";
            this.btn_SignUp.Size = new System.Drawing.Size(121, 34);
            this.btn_SignUp.TabIndex = 3;
            this.btn_SignUp.Text = "Sign Up";
            this.btn_SignUp.Click += new System.EventHandler(this.btn_SignUp_Click);
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
            this.btn_Exit.TabIndex = 5;
            this.btn_Exit.Text = "X";
            this.btn_Exit.Click += new System.EventHandler(this.btn_Exit_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Messaging_Application.Properties.Resources.Purple_Black_Minimalist_Chat_Logo_Design;
            this.pictureBox1.Location = new System.Drawing.Point(366, 9);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(490, 336);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1280, 720);
            this.Controls.Add(this.btn_Exit);
            this.Controls.Add(this.btn_SignUp);
            this.Controls.Add(this.btn_signin);
            this.Controls.Add(this.pictureBox1);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label btn_signin;
        private System.Windows.Forms.Label btn_SignUp;
        private System.Windows.Forms.Label btn_Exit;
    }
}

