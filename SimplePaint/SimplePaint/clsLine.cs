using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimplePaint
{
    public class clsLine:clsDrawObject
    {
            public override void Draw(Graphics myGp, Pen myPen,SolidBrush mBrush)
            {
                myGp.DrawLine(myPen, this.p1, this.p2);
            }
        
    }
}
