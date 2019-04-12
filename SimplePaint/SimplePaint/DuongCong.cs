using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimplePaint
{
    class DuongCong:clsDrawObject
    {
        public override void Draw(Graphics myGp, Pen myPen,SolidBrush mBrush)
        {
            Point[] curvePoints = { p1, p2 };
            myGp.DrawCurve(myPen, curvePoints);
        }
    }
}
