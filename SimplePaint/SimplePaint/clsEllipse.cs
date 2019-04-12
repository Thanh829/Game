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
    class clsEllipse:clsDrawObject
    {
        public override void Draw(Graphics myGp, Pen myPen,SolidBrush mBrush)
        {
            if (fill == false)
                myGp.DrawEllipse(myPen, this.p1.X, this.p1.Y, this.p2.X - this.p1.X, this.p2.Y - this.p1.Y);
            else if(fill==true&&chon==false)
                myGp.FillEllipse(mBrush, this.p1.X, this.p1.Y, this.p2.X - this.p1.X, this.p2.Y - this.p1.Y);
            else if(fill==true&&chon==true)
            {
                myGp.FillEllipse(mBrush, this.p1.X, this.p1.Y, this.p2.X - this.p1.X, this.p2.Y - this.p1.Y);
                myGp.DrawEllipse(penTemp, this.p1.X, this.p1.Y, this.p2.X - this.p1.X, this.p2.Y - this.p1.Y);
            }
        }
    }
}
