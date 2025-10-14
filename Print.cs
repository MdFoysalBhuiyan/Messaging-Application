using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace message // Ensure this namespace matches your project
{
    public partial class Print : Form
    {
        // Declare controls at the class level to access them in multiple methods
        private ComboBox partsComboBox;
        private RichTextBox receiptBox;
        private Dictionary<string, int> partsData;

        public Print()
        {
            InitializeComponent();
            this.Text = "Receipt Printer";
            this.Size = new Size(400, 600);
            this.StartPosition = FormStartPosition.CenterScreen;
            this.BackColor = Color.WhiteSmoke;
            InitializeControls();
            UpdateReceiptPreview(); // Show an initial receipt
        }

        private void InitializeControls()
        {
            // --- Data for our parts ---
            partsData = new Dictionary<string, int>
            {
                { "Motherboard", 5000 },
                { "Mouse", 1500 },
                { "Keyboard", 3000 },
                { "Display", 14000 },
                { "Processor", 25000 }
            };

            // --- Label for the ComboBox ---
            Label partsLabel = new Label();
            partsLabel.Text = "Parts";
            partsLabel.Location = new Point(20, 20);
            partsLabel.AutoSize = true;
            this.Controls.Add(partsLabel);

            // --- ComboBox for Parts Selection ---
            partsComboBox = new ComboBox();
            partsComboBox.Location = new Point(70, 18);
            partsComboBox.Size = new Size(200, 25);
            partsComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            // Populate the ComboBox
            foreach (var part in partsData)
            {
                partsComboBox.Items.Add($"{part.Key} ({part.Value})");
            }
            partsComboBox.SelectedIndex = 0; // Select the first item by default
            partsComboBox.SelectedIndexChanged += (s, e) => UpdateReceiptPreview(); // Update receipt on change
            this.Controls.Add(partsComboBox);

            // --- Print Button ---
            Button printBtn = new Button();
            printBtn.Text = "Print";
            printBtn.Location = new Point(140, 50);
            printBtn.Size = new Size(100, 40);
            printBtn.Click += PrintBtn_Click;
            this.Controls.Add(printBtn);

            // --- RichTextBox for Receipt Preview ---
            receiptBox = new RichTextBox();
            receiptBox.Location = new Point(20, 100);
            receiptBox.Size = new Size(360, 450);
            receiptBox.ReadOnly = true;
            receiptBox.Font = new Font("Courier New", 10);
            receiptBox.BorderStyle = BorderStyle.FixedSingle;
            this.Controls.Add(receiptBox);
        }

        private string BuildReceipt(string partName, int partPrice)
        {
            int cashPaid = partPrice + 1000;
            int change = cashPaid - partPrice;

            string receipt = "";
            receipt += CenterText("SHOP NAME") + "\n";
            receipt += CenterText("Address: Lorem Ipsum, 23-10") + "\n";
            receipt += CenterText("Telp. 11223344") + "\n";
            receipt += CenterText("*************************") + "\n";
            receipt += CenterText("CASH RECEIPT") + "\n";
            receipt += CenterText("*************************") + "\n";
            receipt += "\n";
            receipt += "Description" + PadRight("Price", 38) + "\n";
            receipt += partName + PadRight(partPrice.ToString(), 49 - partName.Length) + "\n";
            receipt += "\n";
            receipt += CenterText("*************************") + "\n";
            receipt += "Total" + PadRight(partPrice.ToString(), 44) + "\n";
            receipt += "Cash" + PadRight(cashPaid.ToString(), 45) + "\n";
            receipt += "Change" + PadRight(change.ToString(), 42) + "\n";
            receipt += CenterText("*************************") + "\n";
            receipt += CenterText("THANK YOU!") + "\n";
            receipt += CenterText("*************************") + "\n";
            return receipt;
        }

        private void UpdateReceiptPreview()
        {
            if (partsComboBox.SelectedItem == null) return;

            string selectedKey = partsComboBox.SelectedItem.ToString().Split(' ')[0];
            int price = partsData[selectedKey];

            receiptBox.Text = BuildReceipt(selectedKey, price);
        }

        private string CenterText(string text)
        {
            int totalWidth = 50;
            int spaces = (totalWidth - text.Length) / 2;
            return new string(' ', Math.Max(0, spaces)) + text;
        }

        private string PadRight(string text, int totalWidth)
        {
            return new string(' ', Math.Max(0, totalWidth - text.Length)) + text;
        }

        // --- THIS IS THE MODIFIED METHOD ---
        // In your Print.cs file, replace the PrintBtn_Click method with this one.

        private void PrintBtn_Click(object sender, EventArgs e)
        {
            // 1. Get all the necessary info
            string currentReceipt = receiptBox.Text;
            string selectedKey = partsComboBox.SelectedItem.ToString().Split(' ')[0];
            int price = partsData[selectedKey];

            // 2. Hide the current (Print) form
            this.Hide();

            // 3. Create and show the AccDeny form, now passing product info
            AccDeny accDenyForm = new AccDeny(currentReceipt, selectedKey, price);
            DialogResult result = accDenyForm.ShowDialog();

            // 4. After AccDeny closes, check its result
            if (result == DialogResult.Retry)
            {
                Login loginForm = new Login();
                loginForm.Show();
                this.Close();
            }
            else
            {
                this.Close();
            }
        }

        // This method is no longer used by the Print button but can be kept for other purposes
        private void PrintDoc_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Font font = new Font("Courier New", 10);
            e.Graphics.DrawString(receiptBox.Text, font, Brushes.Black, new PointF(20, 20));
        }
    }
}