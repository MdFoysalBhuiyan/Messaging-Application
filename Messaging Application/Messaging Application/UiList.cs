using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
//using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Messaging_Application
{
    internal class UiList
    {
        public static int GeTTextHeight(Label lbl)
        {
            using (Graphics g = lbl.CreateGraphics())
            {
                SizeF size = g.MeasureString(lbl.Text, lbl.Font, 490);
                return (int)Math.Ceiling(size.Height);
            }
        }
    }
}
