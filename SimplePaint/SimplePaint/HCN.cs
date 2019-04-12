using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimplePaint
{
    class HCN:clsDrawObject
    {
        public override void Draw(Graphics myGp, Pen myPen,SolidBrush mBrush)
        {
            if (this.fill == false)
                myGp.DrawRectangle(myPen, this.p1.X, this.p1.Y, this.p2.X - this.p1.X, this.p2.Y - this.p1.Y);
            else if (fill == true && chon == false)
                myGp.FillRectangle(mBrush, this.p1.X, this.p1.Y, this.p2.X - this.p1.X, this.p2.Y - this.p1.Y);
        else if(fill==true&&chon==true)
            {
                myGp.FillRectangle(mBrush, this.p1.X, this.p1.Y, this.p2.X - this.p1.X, this.p2.Y - this.p1.Y);
                myGp.DrawRectangle(penTemp, this.p1.X, this.p1.Y, this.p2.X - this.p1.X, this.p2.Y - this.p1.Y);
            }

        }
    }
}
