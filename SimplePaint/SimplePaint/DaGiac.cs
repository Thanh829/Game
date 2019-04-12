using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimplePaint
{
    class DaGiac:clsDrawObject
    {
      
        public override void Draw(Graphics myGp, Pen myPen,SolidBrush mBrush)
        {
            if (fill == false)
                myGp.DrawPolygon(myPen, this.lst1);
            else if(fill==true&&chon==false)
                myGp.FillPolygon(mBrush, this.lst1);
             else if (fill == true && chon == true)
            {
                myGp.FillPolygon(mBrush, this.lst1);
                myGp.DrawPolygon(penTemp, this.lst1);
            }
        }
    }
}
