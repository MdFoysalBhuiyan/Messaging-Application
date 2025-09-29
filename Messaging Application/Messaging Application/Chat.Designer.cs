namespace Messaging_Application
{
    partial class Chat
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
            this.btn_logout = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.bt_Token = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // bt_home
            // 
            this.bt_home.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.bt_home.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_home.Location = new System.Drawing.Point(36, 301);
            this.bt_home.Name = "bt_home";
            this.bt_home.Size = new System.Drawing.Size(134, 60);
            this.bt_home.TabIndex = 15;
            this.bt_home.Text = "Home";
            this.bt_home.UseVisualStyleBackColor = false;
            // 
            // bt_setting
            // 
            this.bt_setting.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.bt_setting.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_setting.Location = new System.Drawing.Point(36, 452);
            this.bt_setting.Name = "bt_setting";
            this.bt_setting.Size = new System.Drawing.Size(134, 60);
            this.bt_setting.TabIndex = 16;
            this.bt_setting.Text = "Setting";
            this.bt_setting.UseVisualStyleBackColor = false;
            this.bt_setting.Click += new System.EventHandler(this.bt_setting_Click);
            // 
            // bt_chat
            // 
            this.bt_chat.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.bt_chat.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_chat.Location = new System.Drawing.Point(36, 150);
            this.bt_chat.Name = "bt_chat";
            this.bt_chat.Size = new System.Drawing.Size(134, 60);
            this.bt_chat.TabIndex = 17;
            this.bt_chat.Text = "Chat";
            this.bt_chat.UseVisualStyleBackColor = false;
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
            this.btn_logout.TabIndex = 18;
            this.btn_logout.Text = "Log out";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(502, 301);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(518, 60);
            this.button1.TabIndex = 19;
            this.button1.Text = "Support";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(502, 452);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(518, 60);
            this.button2.TabIndex = 20;
            this.button2.Text = "Technician";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button3.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(502, 150);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(518, 60);
            this.button3.TabIndex = 21;
            this.button3.Text = "Customer Care";
            this.button3.UseVisualStyleBackColor = false;
            // 
            // bt_Token
            // 
            this.bt_Token.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.bt_Token.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_Token.Location = new System.Drawing.Point(696, 593);
            this.bt_Token.Name = "bt_Token";
            this.bt_Token.Size = new System.Drawing.Size(128, 33);
            this.bt_Token.TabIndex = 22;
            this.bt_Token.Text = "Get Token";
            this.bt_Token.UseVisualStyleBackColor = false;
            this.bt_Token.Click += new System.EventHandler(this.bt_Token_Click);
            // 
            // Chat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.bt_Token);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.btn_logout);
            this.Controls.Add(this.bt_home);
            this.Controls.Add(this.bt_setting);
            this.Controls.Add(this.bt_chat);
            this.Name = "Chat";
            this.Text = "Chat";
            this.Load += new System.EventHandler(this.Chat_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bt_home;
        private System.Windows.Forms.Button bt_setting;
        private System.Windows.Forms.Button bt_chat;
        private System.Windows.Forms.Label btn_logout;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button bt_Token;
    }
}