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
    public abstract class clsDrawObject
    {
        public Point p1;
        public Point p2;
        public Pen pen;
        public Pen penTemp;
        public SolidBrush iBrush;
        public Point[] lst1;
        public  Point[] PointTemp; // mảng lưu khoảng cách cần tịnh tiến dùng cho polygon
        public bool chon = false;
        public bool fill = false;
        public int dem = 0;
        // biến lưu khoảng cách cần tuyến tính. 
        public Point p1new;
        public Point p2new;
        public bool dichuyen = false;
        public abstract void Draw(Graphics myGp, Pen myPen,SolidBrush mBrush);

        public int XacDinh()
        {
            if (p1.X - p2.X <= 0 && p1.Y - p2.Y <= 0)
                return 1;
            if (p1.X - p2.X >= 0 && p1.Y - p2.Y <= 0)
                return 2;
            if (p1.X - p2.X >= 0 && p1.Y - p2.Y >= 0)
                return 3;
            return 4;
        }
        // Hàm xác định 1 điểm có thuộc hình
        public int Thuoc(Point p)
        {
            switch (XacDinh())
            {
                case 1:
                    if (p.X >= p1.X && p.X <= p2.X && p.Y >= p1.Y && p.Y <= p2.Y)
                        return 1;
                    break;
                case 2:
                    if (p.X <= p1.X && p.X >= p2.X && p.Y >= p1.Y && p.Y <= p2.Y)
                        return 1;
                    break;
                case 3:
                    if (p.X <= p1.X && p.X >= p2.X && p.Y <= p1.Y && p.Y >= p2.Y)
                        return 1;
                    break;
                case 4:
                    if (p.X >= p1.X && p.X <= p2.X && p.Y <= p1.Y && p.Y >= p2.Y)
                        return 1;
                    break;
            }
            return 0;
        }
    } 
}
