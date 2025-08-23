namespace Messaging_Application
{
    partial class Form2
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
            this.btn_logout = new System.Windows.Forms.Label();
            this.btn_Exit = new System.Windows.Forms.Label();
            this.bt_chat = new System.Windows.Forms.Button();
            this.bt_setting = new System.Windows.Forms.Button();
            this.bt_home = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_logout
            // 
            this.btn_logout.AutoSize = true;
            this.btn_logout.BackColor = System.Drawing.Color.Gainsboro;
            this.btn_logout.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.btn_logout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_logout.Font = new System.Drawing.Font("Arial Rounded MT Bold", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_logout.Location = new System.Drawing.Point(1138, 638);
            this.btn_logout.Name = "btn_logout";
            this.btn_logout.Size = new System.Drawing.Size(114, 34);
            this.btn_logout.TabIndex = 1;
            this.btn_logout.Text = "Log out";
            this.btn_logout.Click += new System.EventHandler(this.btn_logout_Click);
            // 
            // btn_Exit
            // 
            this.btn_Exit.AutoSize = true;
            this.btn_Exit.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.btn_Exit.Font = new System.Drawing.Font("Arial Rounded MT Bold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Exit.ForeColor = System.Drawing.Color.OrangeRed;
            this.btn_Exit.Location = new System.Drawing.Point(1224, 9);
            this.btn_Exit.Name = "btn_Exit";
            this.btn_Exit.Size = new System.Drawing.Size(28, 30);
            this.btn_Exit.TabIndex = 7;
            this.btn_Exit.Text = "X";
            this.btn_Exit.Click += new System.EventHandler(this.btn_Exit_Click);
            // 
            // bt_chat
            // 
            this.bt_chat.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.bt_chat.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_chat.Location = new System.Drawing.Point(41, 135);
            this.bt_chat.Name = "bt_chat";
            this.bt_chat.Size = new System.Drawing.Size(134, 60);
            this.bt_chat.TabIndex = 8;
            this.bt_chat.Text = "Chat";
            this.bt_chat.UseVisualStyleBackColor = false;
            this.bt_chat.Click += new System.EventHandler(this.bt_chat_Click);
            // 
            // bt_setting
            // 
            this.bt_setting.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.bt_setting.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_setting.Location = new System.Drawing.Point(41, 437);
            this.bt_setting.Name = "bt_setting";
            this.bt_setting.Size = new System.Drawing.Size(134, 60);
            this.bt_setting.TabIndex = 8;
            this.bt_setting.Text = "Setting";
            this.bt_setting.UseVisualStyleBackColor = false;
            this.bt_setting.Click += new System.EventHandler(this.bt_setting_Click);
            // 
            // bt_home
            // 
            this.bt_home.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.bt_home.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_home.Location = new System.Drawing.Point(41, 286);
            this.bt_home.Name = "bt_home";
            this.bt_home.Size = new System.Drawing.Size(134, 60);
            this.bt_home.TabIndex = 8;
            this.bt_home.Text = "Home";
            this.bt_home.UseVisualStyleBackColor = false;
            this.bt_home.Click += new System.EventHandler(this.bt_home_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(484, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(278, 262);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.bt_home);
            this.Controls.Add(this.bt_setting);
            this.Controls.Add(this.bt_chat);
            this.Controls.Add(this.btn_Exit);
            this.Controls.Add(this.btn_logout);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form2";
            this.Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label btn_logout;
        private System.Windows.Forms.Label btn_Exit;
        private System.Windows.Forms.Button bt_chat;
        private System.Windows.Forms.Button bt_setting;
        private System.Windows.Forms.Button bt_home;
    }
}