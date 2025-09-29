namespace Messaging_Application
{
    partial class Token_Print
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
            this.bt_Print = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(156, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(999, 513);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // bt_Print
            // 
            this.bt_Print.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.bt_Print.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_Print.Location = new System.Drawing.Point(597, 562);
            this.bt_Print.Name = "bt_Print";
            this.bt_Print.Size = new System.Drawing.Size(125, 43);
            this.bt_Print.TabIndex = 1;
            this.bt_Print.Text = "Print";
            this.bt_Print.UseVisualStyleBackColor = false;
            this.bt_Print.Click += new System.EventHandler(this.button1_Click);
            // 
            // Token_Print
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1248, 642);
            this.Controls.Add(this.bt_Print);
            this.Controls.Add(this.panel1);
            this.Name = "Token_Print";
            this.Text = "Token_Print";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button bt_Print;
    }
}