namespace Messaging_Application
{
    partial class Setting
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
            this.bt_home = new System.Windows.Forms.Button();
            this.bt_setting = new System.Windows.Forms.Button();
            this.bt_chat = new System.Windows.Forms.Button();
            this.btn_Exit = new System.Windows.Forms.Label();
            this.btn_logout = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btn_update_pic = new System.Windows.Forms.Button();
            this.tb_up_pass = new System.Windows.Forms.TextBox();
            this.tb_email_update = new System.Windows.Forms.TextBox();
            this.Updated_pass = new System.Windows.Forms.Label();
            this.Updated_name = new System.Windows.Forms.Label();
            this.btn_Save = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // bt_home
            // 
            this.bt_home.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.bt_home.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_home.Location = new System.Drawing.Point(35, 306);
            this.bt_home.Name = "bt_home";
            this.bt_home.Size = new System.Drawing.Size(134, 60);
            this.bt_home.TabIndex = 12;
            this.bt_home.Text = "Home";
            this.bt_home.UseVisualStyleBackColor = false;
            this.bt_home.Click += new System.EventHandler(this.bt_home_Click);
            // 
            // bt_setting
            // 
            this.bt_setting.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.bt_setting.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_setting.Location = new System.Drawing.Point(35, 457);
            this.bt_setting.Name = "bt_setting";
            this.bt_setting.Size = new System.Drawing.Size(134, 60);
            this.bt_setting.TabIndex = 13;
            this.bt_setting.Text = "Setting";
            this.bt_setting.UseVisualStyleBackColor = false;
            // 
            // bt_chat
            // 
            this.bt_chat.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.bt_chat.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_chat.Location = new System.Drawing.Point(35, 155);
            this.bt_chat.Name = "bt_chat";
            this.bt_chat.Size = new System.Drawing.Size(134, 60);
            this.bt_chat.TabIndex = 14;
            this.bt_chat.Text = "Chat";
            this.bt_chat.UseVisualStyleBackColor = false;
            // 
            // btn_Exit
            // 
            this.btn_Exit.AutoSize = true;
            this.btn_Exit.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.btn_Exit.Font = new System.Drawing.Font("Arial Rounded MT Bold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Exit.ForeColor = System.Drawing.Color.OrangeRed;
            this.btn_Exit.Location = new System.Drawing.Point(1218, 29);
            this.btn_Exit.Name = "btn_Exit";
            this.btn_Exit.Size = new System.Drawing.Size(28, 30);
            this.btn_Exit.TabIndex = 11;
            this.btn_Exit.Text = "X";
            this.btn_Exit.Click += new System.EventHandler(this.btn_Exit_Click);
            // 
            // btn_logout
            // 
            this.btn_logout.AutoSize = true;
            this.btn_logout.BackColor = System.Drawing.Color.Gainsboro;
            this.btn_logout.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.btn_logout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_logout.Font = new System.Drawing.Font("Arial Rounded MT Bold", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_logout.Location = new System.Drawing.Point(1132, 658);
            this.btn_logout.Name = "btn_logout";
            this.btn_logout.Size = new System.Drawing.Size(114, 34);
            this.btn_logout.TabIndex = 10;
            this.btn_logout.Text = "Log out";
            this.btn_logout.Click += new System.EventHandler(this.btn_logout_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(478, 32);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(278, 262);
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // btn_update_pic
            // 
            this.btn_update_pic.BackColor = System.Drawing.Color.Gainsboro;
            this.btn_update_pic.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_update_pic.Location = new System.Drawing.Point(554, 306);
            this.btn_update_pic.Name = "btn_update_pic";
            this.btn_update_pic.Size = new System.Drawing.Size(123, 39);
            this.btn_update_pic.TabIndex = 14;
            this.btn_update_pic.Text = "Update Photo";
            this.btn_update_pic.UseVisualStyleBackColor = false;
            this.btn_update_pic.Click += new System.EventHandler(this.btn_update_pic_Click);
            // 
            // tb_up_pass
            // 
            this.tb_up_pass.Location = new System.Drawing.Point(478, 579);
            this.tb_up_pass.Name = "tb_up_pass";
            this.tb_up_pass.PasswordChar = '*';
            this.tb_up_pass.Size = new System.Drawing.Size(404, 20);
            this.tb_up_pass.TabIndex = 16;
            // 
            // tb_email_update
            // 
            this.tb_email_update.Location = new System.Drawing.Point(478, 405);
            this.tb_email_update.Name = "tb_email_update";
            this.tb_email_update.Size = new System.Drawing.Size(404, 20);
            this.tb_email_update.TabIndex = 15;
            // 
            // Updated_pass
            // 
            this.Updated_pass.AutoSize = true;
            this.Updated_pass.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Updated_pass.Location = new System.Drawing.Point(474, 537);
            this.Updated_pass.Name = "Updated_pass";
            this.Updated_pass.Size = new System.Drawing.Size(106, 22);
            this.Updated_pass.TabIndex = 17;
            this.Updated_pass.Text = "Password:";
            // 
            // Updated_name
            // 
            this.Updated_name.AutoSize = true;
            this.Updated_name.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Updated_name.Location = new System.Drawing.Point(474, 364);
            this.Updated_name.Name = "Updated_name";
            this.Updated_name.Size = new System.Drawing.Size(69, 22);
            this.Updated_name.TabIndex = 18;
            this.Updated_name.Text = "Name:";
            // 
            // btn_Save
            // 
            this.btn_Save.BackColor = System.Drawing.Color.Gainsboro;
            this.btn_Save.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Save.Location = new System.Drawing.Point(554, 623);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(135, 46);
            this.btn_Save.TabIndex = 14;
            this.btn_Save.Text = "SAVE";
            this.btn_Save.UseVisualStyleBackColor = false;
            this.btn_Save.Click += new System.EventHandler(this.btn_update_pic_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(474, 456);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 22);
            this.label1.TabIndex = 18;
            this.label1.Text = "Email:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(478, 497);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(404, 20);
            this.textBox1.TabIndex = 15;
            // 
            // Setting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1280, 720);
            this.Controls.Add(this.tb_up_pass);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.tb_email_update);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Updated_pass);
            this.Controls.Add(this.Updated_name);
            this.Controls.Add(this.bt_home);
            this.Controls.Add(this.bt_setting);
            this.Controls.Add(this.btn_Save);
            this.Controls.Add(this.btn_update_pic);
            this.Controls.Add(this.bt_chat);
            this.Controls.Add(this.btn_Exit);
            this.Controls.Add(this.btn_logout);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Setting";
            this.Text = "Setting";
            this.Load += new System.EventHandler(this.Setting_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bt_home;
        private System.Windows.Forms.Button bt_setting;
        private System.Windows.Forms.Button bt_chat;
        private System.Windows.Forms.Label btn_Exit;
        private System.Windows.Forms.Label btn_logout;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btn_update_pic;
        private System.Windows.Forms.TextBox tb_up_pass;
        private System.Windows.Forms.TextBox tb_email_update;
        private System.Windows.Forms.Label Updated_pass;
        private System.Windows.Forms.Label Updated_name;
        private System.Windows.Forms.Button btn_Save;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
    }
}