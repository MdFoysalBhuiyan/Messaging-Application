using System;
using System.Drawing;
using System.Drawing.Printing;
using System.Windows.Forms;

namespace Messaging_Application
{
    public partial class Token_Print : Form
    {
        Bitmap tokenBitmap; 
        public Token_Print()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            tokenBitmap = new Bitmap(panel1.Width, panel1.Height);
            panel1.DrawToBitmap(tokenBitmap, new Rectangle(0, 0, panel1.Width, panel1.Height));
            PrintPreviewDialog printPreview = new PrintPreviewDialog();
            PrintDocument printDoc = new PrintDocument();
            printDoc.PrintPage += PrintDoc_PrintPage;
            printPreview.Document = printDoc;
            printPreview.ShowDialog();
        }
        private void PrintDoc_PrintPage(object sender, PrintPageEventArgs e)
        {
            e.Graphics.DrawImage(tokenBitmap, new Point(100, 100));
        }
        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            // Example dummy data (replace later with DB values)
            Graphics g = e.Graphics;
            Font font = new Font("Arial", 12, FontStyle.Bold);
            Brush brush = Brushes.Black;

            g.DrawString("Token No: 001", font, brush, new PointF(10, 10));
            g.DrawString("Name: Md Foysal Bhuiyan", font, brush, new PointF(10, 40));
            g.DrawString("Date: " + DateTime.Now.ToString("dd/MM/yyyy HH:mm"), font, brush, new PointF(10, 70));
        }
    }
}
