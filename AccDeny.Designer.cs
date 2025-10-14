namespace message
{
    partial class AccDeny
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
            this.btnAccept = new System.Windows.Forms.Button();
            this.btnDeny = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // btnAccept
            // 
            this.btnAccept.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnAccept.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAccept.Location = new System.Drawing.Point(238, 622);
            this.btnAccept.Name = "btnAccept";
            this.btnAccept.Size = new System.Drawing.Size(81, 30);
            this.btnAccept.TabIndex = 0;
            this.btnAccept.Text = "Accept";
            this.btnAccept.UseVisualStyleBackColor = false;
            this.btnAccept.Click += new System.EventHandler(this.btnAccept_Click);
            // 
            // btnDeny
            // 
            this.btnDeny.BackColor = System.Drawing.Color.Black;
            this.btnDeny.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeny.ForeColor = System.Drawing.Color.White;
            this.btnDeny.Location = new System.Drawing.Point(418, 622);
            this.btnDeny.Name = "btnDeny";
            this.btnDeny.Size = new System.Drawing.Size(79, 30);
            this.btnDeny.TabIndex = 1;
            this.btnDeny.Text = "Deny";
            this.btnDeny.UseVisualStyleBackColor = false;
            this.btnDeny.Click += new System.EventHandler(this.btnDeny_Click);
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(91, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(594, 606);
            this.panel1.TabIndex = 2;
            //this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // AccDeny
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(763, 681);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnDeny);
            this.Controls.Add(this.btnAccept);
            this.Name = "AccDeny";
            this.Text = "AccDeny";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAccept;
        private System.Windows.Forms.Button btnDeny;
        private System.Windows.Forms.Panel panel1;
    }
}