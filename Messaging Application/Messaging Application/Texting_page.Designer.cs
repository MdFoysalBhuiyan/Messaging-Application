namespace Messaging_Application
{
    partial class Texting_page
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
            this.bt_chat = new System.Windows.Forms.Button();
            this.bt_setting = new System.Windows.Forms.Button();
            this.bt_home = new System.Windows.Forms.Button();
            this.btn_logout = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.labelSender = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.labelReceiver = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.txt_box_for_type = new System.Windows.Forms.TextBox();
            this.btn_send = new System.Windows.Forms.Button();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.userControl21 = new Messaging_Application.UserControl2();
            this.userControl31 = new Messaging_Application.UserControl3();
            this.userControl12 = new Messaging_Application.UserControl1();
            this.userControl11 = new Messaging_Application.UserControl1();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.timer3 = new System.Windows.Forms.Timer(this.components);
            this.flowLayoutPanel1.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel4.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // bt_chat
            // 
            this.bt_chat.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.bt_chat.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_chat.Location = new System.Drawing.Point(16, 59);
            this.bt_chat.Name = "bt_chat";
            this.bt_chat.Size = new System.Drawing.Size(134, 60);
            this.bt_chat.TabIndex = 24;
            this.bt_chat.Text = "Chat";
            this.bt_chat.UseVisualStyleBackColor = false;
            // 
            // bt_setting
            // 
            this.bt_setting.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.bt_setting.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_setting.Location = new System.Drawing.Point(16, 361);
            this.bt_setting.Name = "bt_setting";
            this.bt_setting.Size = new System.Drawing.Size(134, 60);
            this.bt_setting.TabIndex = 23;
            this.bt_setting.Text = "Setting";
            this.bt_setting.UseVisualStyleBackColor = false;
            this.bt_setting.Click += new System.EventHandler(this.bt_setting_Click);
            // 
            // bt_home
            // 
            this.bt_home.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.bt_home.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_home.Location = new System.Drawing.Point(16, 210);
            this.bt_home.Name = "bt_home";
            this.bt_home.Size = new System.Drawing.Size(134, 60);
            this.bt_home.TabIndex = 22;
            this.bt_home.Text = "Home";
            this.bt_home.UseVisualStyleBackColor = false;
            this.bt_home.Click += new System.EventHandler(this.bt_home_Click);
            // 
            // btn_logout
            // 
            this.btn_logout.AutoSize = true;
            this.btn_logout.BackColor = System.Drawing.Color.Gainsboro;
            this.btn_logout.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.btn_logout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_logout.Font = new System.Drawing.Font("Arial Rounded MT Bold", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_logout.Location = new System.Drawing.Point(1122, 598);
            this.btn_logout.Name = "btn_logout";
            this.btn_logout.Size = new System.Drawing.Size(114, 34);
            this.btn_logout.TabIndex = 25;
            this.btn_logout.Text = "Log out";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.userControl12);
            this.flowLayoutPanel1.Controls.Add(this.panel5);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(864, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(384, 641);
            this.flowLayoutPanel1.TabIndex = 26;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panel5.Controls.Add(this.labelSender);
            this.panel5.Location = new System.Drawing.Point(3, 125);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(381, 114);
            this.panel5.TabIndex = 1;
            // 
            // labelSender
            // 
            this.labelSender.AutoSize = true;
            this.labelSender.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSender.Location = new System.Drawing.Point(139, 47);
            this.labelSender.Name = "labelSender";
            this.labelSender.Size = new System.Drawing.Size(60, 24);
            this.labelSender.TabIndex = 0;
            this.labelSender.Text = "label3";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(156, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(705, 650);
            this.panel1.TabIndex = 27;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(705, 106);
            this.panel2.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.labelReceiver);
            this.panel3.Controls.Add(this.pictureBox2);
            this.panel3.Location = new System.Drawing.Point(156, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(705, 116);
            this.panel3.TabIndex = 2;
            // 
            // labelReceiver
            // 
            this.labelReceiver.AutoSize = true;
            this.labelReceiver.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelReceiver.Location = new System.Drawing.Point(162, 44);
            this.labelReceiver.Name = "labelReceiver";
            this.labelReceiver.Size = new System.Drawing.Size(76, 25);
            this.labelReceiver.TabIndex = 3;
            this.labelReceiver.Text = "label2";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(19, 31);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(100, 50);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            // 
            // panel4
            // 
            this.panel4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel4.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.panel4.Controls.Add(this.txt_box_for_type);
            this.panel4.Controls.Add(this.btn_send);
            this.panel4.Location = new System.Drawing.Point(156, 577);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(705, 70);
            this.panel4.TabIndex = 2;
            // 
            // txt_box_for_type
            // 
            this.txt_box_for_type.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.txt_box_for_type.Location = new System.Drawing.Point(19, 6);
            this.txt_box_for_type.Multiline = true;
            this.txt_box_for_type.Name = "txt_box_for_type";
            this.txt_box_for_type.Size = new System.Drawing.Size(585, 61);
            this.txt_box_for_type.TabIndex = 1;
            // 
            // btn_send
            // 
            this.btn_send.Location = new System.Drawing.Point(610, 22);
            this.btn_send.Name = "btn_send";
            this.btn_send.Size = new System.Drawing.Size(85, 33);
            this.btn_send.TabIndex = 0;
            this.btn_send.Text = "SEND";
            this.btn_send.UseVisualStyleBackColor = true;
            this.btn_send.Click += new System.EventHandler(this.btn_send_Click);
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Controls.Add(this.listBox1);
            this.flowLayoutPanel2.Controls.Add(this.userControl21);
            this.flowLayoutPanel2.Controls.Add(this.userControl31);
            this.flowLayoutPanel2.Location = new System.Drawing.Point(156, 119);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(705, 458);
            this.flowLayoutPanel2.TabIndex = 1;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.HorizontalScrollbar = true;
            this.listBox1.Location = new System.Drawing.Point(3, 3);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(723, 680);
            this.listBox1.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(274, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(311, 31);
            this.label2.TabIndex = 4;
            this.label2.Text = "Customer Care Person";
            // 
            // userControl21
            // 
            this.userControl21.AutoSize = true;
            this.userControl21.Dock = System.Windows.Forms.DockStyle.Top;
            this.userControl21.Location = new System.Drawing.Point(3, 689);
            this.userControl21.Name = "userControl21";
            this.userControl21.Size = new System.Drawing.Size(404, 58);
            this.userControl21.TabIndex = 0;
            this.userControl21.Title = null;
            // 
            // userControl31
            // 
            this.userControl31.BackColor = System.Drawing.SystemColors.ControlLight;
            this.userControl31.Dock = System.Windows.Forms.DockStyle.Top;
            this.userControl31.Icon = null;
            this.userControl31.Location = new System.Drawing.Point(3, 753);
            this.userControl31.Name = "userControl31";
            this.userControl31.Size = new System.Drawing.Size(390, 20);
            this.userControl31.TabIndex = 1;
            this.userControl31.Title = null;
            // 
            // userControl12
            // 
            this.userControl12.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.userControl12.Image1 = null;
            this.userControl12.Location = new System.Drawing.Point(3, 3);
            this.userControl12.Name = "userControl12";
            this.userControl12.Size = new System.Drawing.Size(381, 116);
            this.userControl12.TabIndex = 0;
            this.userControl12.Text1 = null;
            this.userControl12.Load += new System.EventHandler(this.userControl12_Load);
            // 
            // userControl11
            // 
            this.userControl11.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.userControl11.Image1 = null;
            this.userControl11.Location = new System.Drawing.Point(3, 3);
            this.userControl11.Name = "userControl11";
            this.userControl11.Size = new System.Drawing.Size(8, 8);
            this.userControl11.TabIndex = 0;
            this.userControl11.Text1 = null;
            // 
            // timer2
            // 
            this.timer2.Interval = 2000;
            // 
            // timer3
            // 
            this.timer3.Interval = 3000;
            // 
            // Texting_page
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1248, 641);
            this.Controls.Add(this.flowLayoutPanel2);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.btn_logout);
            this.Controls.Add(this.bt_home);
            this.Controls.Add(this.bt_setting);
            this.Controls.Add(this.bt_chat);
            this.Name = "Texting_page";
            this.Text = "Texting_page";
            this.Load += new System.EventHandler(this.Texting_page_Load);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.flowLayoutPanel2.ResumeLayout(false);
            this.flowLayoutPanel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bt_chat;
        private System.Windows.Forms.Button bt_setting;
        private System.Windows.Forms.Button bt_home;
        private System.Windows.Forms.Label btn_logout;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private UserControl1 userControl11;
        private UserControl1 userControl12;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button btn_send;
        private System.Windows.Forms.TextBox txt_box_for_type;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private UserControl2 userControl21;
        private UserControl3 userControl31;
        private System.Windows.Forms.Label labelReceiver;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label labelSender;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Timer timer3;
    }
}