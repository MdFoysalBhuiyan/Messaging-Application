namespace message
{
    partial class technician
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
            this.btnSettings = new System.Windows.Forms.Button();
            this.btnHome = new System.Windows.Forms.Button();
            this.btnChat = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnPrint = new System.Windows.Forms.Button();
            //this.comboPrint = new System.Windows.Forms.ComboBox();
            //this.Parts = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnSettings);
            this.panel1.Controls.Add(this.btnHome);
            this.panel1.Controls.Add(this.btnChat);
            this.panel1.Location = new System.Drawing.Point(2, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(169, 642);
            this.panel1.TabIndex = 0;
            // 
            // btnSettings
            // 
            this.btnSettings.Location = new System.Drawing.Point(19, 151);
            this.btnSettings.Name = "btnSettings";
            this.btnSettings.Size = new System.Drawing.Size(134, 38);
            this.btnSettings.TabIndex = 2;
            this.btnSettings.Text = "Settings";
            this.btnSettings.UseVisualStyleBackColor = true;
            // 
            // btnHome
            // 
            this.btnHome.Location = new System.Drawing.Point(19, 101);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(134, 34);
            this.btnHome.TabIndex = 1;
            this.btnHome.Text = "Home";
            this.btnHome.UseVisualStyleBackColor = true;
            // 
            // btnChat
            // 
            this.btnChat.Location = new System.Drawing.Point(19, 46);
            this.btnChat.Name = "btnChat";
            this.btnChat.Size = new System.Drawing.Size(134, 39);
            this.btnChat.TabIndex = 0;
            this.btnChat.Text = "Chat";
            this.btnChat.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnPrint);
            //this.panel2.Controls.Add(this.comboPrint);
            this.panel2.Controls.Add(this.Parts);
            this.panel2.Location = new System.Drawing.Point(177, -1);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(478, 642);
            this.panel2.TabIndex = 1;
            // 
            // btnPrint
            // 
            this.btnPrint.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnPrint.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrint.Location = new System.Drawing.Point(184, 166);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(109, 44);
            this.btnPrint.TabIndex = 8;
            this.btnPrint.Text = "Print";
            this.btnPrint.UseVisualStyleBackColor = false;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // comboPrint
            // 
            //this.comboPrint.FormattingEnabled = true;
            //this.comboPrint.Items.AddRange(new object[] {
            //"Matherboard (5000)",
            //"Mouse(1500)",
            //"Keyboard(3000)",
            //"Display(14000)",
            //"Processor(25000)"});
            //this.comboPrint.Location = new System.Drawing.Point(124, 120);
            //this.comboPrint.Name = "comboPrint";
            //this.comboPrint.Size = new System.Drawing.Size(222, 24);
            //this.comboPrint.TabIndex = 7;
            // 
            // Parts
            // 
            //this.Parts.AutoSize = true;
            //this.Parts.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            //this.Parts.Location = new System.Drawing.Point(75, 123);
            //this.Parts.Name = "Parts";
            //this.Parts.Size = new System.Drawing.Size(43, 16);
            //this.Parts.TabIndex = 6;
            //this.Parts.Text = "Parts";
            // 
            // panel3
            // 
            this.panel3.Location = new System.Drawing.Point(661, -1);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(373, 642);
            this.panel3.TabIndex = 2;
            // 
            // technician
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1036, 639);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "technician";
            this.Text = "technician";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnSettings;
        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.Button btnChat;
        private System.Windows.Forms.Button btnPrint;
        //private System.Windows.Forms.ComboBox comboPrint;
        private System.Windows.Forms.Label Parts;
    }
}