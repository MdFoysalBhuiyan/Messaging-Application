using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace message // Make sure this namespace matches your project
{
    public partial class FeedbackForm : Form
    {
        private RadioButton[] ratingButtons;
        public int SelectedRating { get; private set; } = 0; // Public property to hold the rating

        public FeedbackForm()
        {
            InitializeComponent();
            this.Text = "Feedback";
            this.Size = new Size(300, 180);
            this.StartPosition = FormStartPosition.CenterParent;
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;

            InitializeControls();
        }

        private void InitializeControls()
        {
            Label promptLabel = new Label();
            promptLabel.Text = "Please rate your experience:";
            promptLabel.Location = new Point(20, 20);
            promptLabel.AutoSize = true;
            this.Controls.Add(promptLabel);

            // Group radio buttons to ensure only one can be selected
            GroupBox ratingGroup = new GroupBox();
            ratingGroup.Location = new Point(20, 50);
            ratingGroup.Size = new Size(250, 50);
            ratingGroup.Text = "Rating";
            this.Controls.Add(ratingGroup);

            ratingButtons = new RadioButton[5];
            for (int i = 0; i < 5; i++)
            {
                ratingButtons[i] = new RadioButton();
                ratingButtons[i].Text = (i + 1).ToString(); // Text: "1", "2", "3", "4", "5"
                ratingButtons[i].Location = new Point(15 + (i * 45), 20);
                ratingButtons[i].AutoSize = true;
                ratingGroup.Controls.Add(ratingButtons[i]);
            }

            Button submitButton = new Button();
            submitButton.Text = "Submit";
            submitButton.Location = new Point(100, 110);
            submitButton.Click += SubmitButton_Click;
            this.Controls.Add(submitButton);
        }

        private void SubmitButton_Click(object sender, EventArgs e)
        {
            // Find which radio button was checked and get its value
            RadioButton checkedButton = ratingButtons.FirstOrDefault(rb => rb.Checked);
            if (checkedButton != null)
            {
                SelectedRating = int.Parse(checkedButton.Text);
            }
            this.Close(); // Close the feedback form
        }
    }
}