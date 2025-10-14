using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace message // Make sure this namespace matches your project
{
    public partial class AccDeny : Form
    {
        // Private fields to store the order details
        private readonly string productName;
        private readonly int productPrice;

        public AccDeny(string receiptText, string productName, int productPrice)
        {
            InitializeComponent();

            // Store product info passed from the Print form
            this.productName = productName;
            this.productPrice = productPrice;

            // ... (The rest of your constructor code for displaying the receipt)
            RichTextBox receiptDisplayBox = new RichTextBox();
            receiptDisplayBox.Dock = DockStyle.Fill;
            receiptDisplayBox.Font = new System.Drawing.Font("Courier New", 10);
            receiptDisplayBox.ReadOnly = true;
            receiptDisplayBox.Text = receiptText;
            panel1.Controls.Add(receiptDisplayBox);
        }

        private void btnAccept_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Transaction Accepted!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

            FeedbackForm feedbackForm = new FeedbackForm();
            feedbackForm.ShowDialog();

            int userRating = feedbackForm.SelectedRating;
            if (userRating > 0)
            {
                MessageBox.Show($"Thank you for your {userRating}-star rating!", "Feedback Received");
            }

            // *** SAVE TO DATABASE ***
            SaveOrderDetails(this.productName, this.productPrice, userRating);

            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btnDeny_Click(object sender, EventArgs e)
        {
            // ... (Your btnDeny_Click code remains the same)
            DialogResult result = MessageBox.Show("Transaction Denied.", "Denied", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            if (result == DialogResult.OK)
            {
                this.DialogResult = DialogResult.Retry;
                this.Close();
            }
        }

        // --- NEW METHOD TO SAVE DATA ---
        private void SaveOrderDetails(string pName, int pPrice, int pRating)
        {
            // IMPORTANT: Replace with your actual connection string
            string connectionString = @"Data Source=RATUL;Initial Catalog=messaging-app;Integrated Security=True;Encrypt=True;TrustServerCertificate=True";

            // Use parameterized query to prevent SQL Injection
            string query = "INSERT INTO OrderDetails (ProductName, ProductPrice, Rating, OrderDate) VALUES (@ProductName, @ProductPrice, @Rating, @OrderDate)";

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    // Add parameters and their values
                    cmd.Parameters.AddWithValue("@ProductName", pName);
                    cmd.Parameters.AddWithValue("@ProductPrice", pPrice);

                    // Handle case where user gives no rating
                    if (pRating > 0)
                    {
                        cmd.Parameters.AddWithValue("@Rating", pRating);
                    }
                    else
                    {
                        cmd.Parameters.AddWithValue("@Rating", DBNull.Value); // Store as NULL if no rating
                    }

                    cmd.Parameters.AddWithValue("@OrderDate", DateTime.Now);

                    try
                    {
                        con.Open();
                        cmd.ExecuteNonQuery(); // Execute the insert command
                        MessageBox.Show("Order details saved successfully!");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Failed to save order details. Error: " + ex.Message);
                    }
                }
            }
        }
    }
}