using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Runtime.InteropServices;
namespace SimplePaint
{
    public partial class Form1 : Form
    {
        bool dichuyen=false;
        bool ctrl=false;
        bool begin=false;
        bool end = false;
        bool fill = false;
        Color myColor;
        Pen myPen;
        int vtPol;
        Bitmap bitmap;
        Graphics g;
        Point Temp;
        bool zoom=false;
        bool IsZoom = false;
        bool chon = false;
        Point[] mang = new Point[20];
        public Form1()
        {
            InitializeComponent();
          

            myColor = Color.Red;
            myPen = new Pen(myColor, Convert.ToInt32(nmr.Value));
            bitmap = new Bitmap(Main_PictureBox.Width, Main_PictureBox.Height);
            g = Graphics.FromImage(bitmap);
            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            //// Create pen.
            //Pen blackPen = new Pen(Color.Black, 3);

            //// Create coordinates of rectangle to bound ellipse.
            //int x = 0;
            //int y = 0;
            //int width = 100;
            //int height = 200;

            //// Create start and sweep angles on ellipse.
            //int startAngle = 180;
            //int sweepAngle = 270;

            //// Draw arc to screen.
            //g.DrawArc(blackPen, x, y, width, height, startAngle, sweepAngle);
            //Main_PictureBox.Image = bitmap;

        }
        public struct IconInfo
        {
            public bool fIcon;
            public int xHotspot;
            public int yHotspot;
            public IntPtr hbmMask;
            public IntPtr hbmColor;
        }
        // Tạo 1 đối tưởng kiểu Bitmap => Vì con trỏ chuột của chúng ta là 1 cái hình
        Bitmap img;
        [DllImport("user32.dll")]
        public static extern IntPtr CreateIconIndirect(ref IconInfo icon);
        [DllImport("user32.dll")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool GetIconInfo(IntPtr hIcon, ref IconInfo pIconInfo);
        //
        public static Cursor CreateCursor(Bitmap bmp, int xHotSpot, int yHotSpot)
        {
            IntPtr ptr = bmp.GetHicon();
            IconInfo tmp = new IconInfo();
            GetIconInfo(ptr, ref tmp);
            tmp.xHotspot = xHotSpot;
            tmp.yHotspot = yHotSpot;
            tmp.fIcon = false;
            ptr = CreateIconIndirect(ref tmp);
            return new Cursor(ptr);
        }

        int LuaChon =3,press;      //press=1: vẽ  2: di chuyển
                                 // luachon =1: Line, 2: HCN, 3:elip
       
        List<clsDrawObject> lstObject = new List<clsDrawObject>();
        private void btn_duongthang_Click(object sender, EventArgs e)
        {
            LuaChon = 1;
        }
        private void btn_elip_Click(object sender, EventArgs e)
        {
            LuaChon = 3;
        }
        
        private void Main_PictureBox_MouseDown(object sender, MouseEventArgs e)

        {
            if (dichuyen==false&&chon==false&&fill==false)
            {
                press = 1;
                if (this.LuaChon == 1)
                {
                    clsDrawObject myobj;
                    myobj = new clsLine();
                    myobj.p1 = e.Location;
                    myobj.pen = new Pen(myColor, Convert.ToInt32(nmr.Value));
                    myobj.penTemp = new Pen(Color.Black, Convert.ToInt32(nmr.Value));
                    this.lstObject.Add(myobj);
                }
                if(this.LuaChon==2)
                {
                    clsDrawObject myobj;
                    myobj = new HCN();
                    myobj.p1 = e.Location;
                    myobj.pen = new Pen(myColor, Convert.ToInt32(nmr.Value));
                    myobj.iBrush = new SolidBrush(myColor);
                    myobj.penTemp = new Pen(Color.Black, Convert.ToInt32(nmr.Value));
                    this.lstObject.Add(myobj);
                }
                if (this.LuaChon == 3)
                {
                    clsDrawObject myObj;
                    myObj = new clsEllipse();
                    myObj.p1 = e.Location;
                    myObj.penTemp = new Pen(Color.Black, Convert.ToInt32(nmr.Value));
                    myObj.iBrush = new SolidBrush(myColor);
                    myObj.pen = new Pen(myColor, Convert.ToInt32(nmr.Value));
                    this.lstObject.Add(myObj);
                }
                if(this.LuaChon==4)
                {
                    clsDrawObject myObj;
                    myObj = new DuongCong();
                    myObj.p1 = e.Location;
                    myObj.penTemp = new Pen(Color.Black, Convert.ToInt32(nmr.Value));
                    myObj.pen = new Pen(myColor, Convert.ToInt32(nmr.Value));
                    this.lstObject.Add(myObj);
                }
                if(LuaChon==5)
                {
                    if (begin == false)
                    {
                        
                        begin = true;
                        clsDrawObject myObj;
                        myObj = new DaGiac();
                        mang = new Point[50];
                        mang[myObj.dem++]= e.Location;
                        myObj.penTemp = new Pen(Color.Black, Convert.ToInt32(nmr.Value));
                        myObj.iBrush = new SolidBrush(myColor);
                        myObj.pen = new Pen(myColor, Convert.ToInt32(nmr.Value));
                        this.lstObject.Add(myObj);
                        vtPol = this.lstObject.Count - 1;
                        clsDrawObject myobj;
                        myobj = new clsLine();
                        myobj.p1 = e.Location;
                        myobj.pen = new Pen(myColor, Convert.ToInt32(nmr.Value));
                        myobj.penTemp = new Pen(Color.Black, Convert.ToInt32(nmr.Value));
                        this.lstObject.Add(myobj);
                        end = false;
                    }
                    else if (end == true)
                    {
                        begin = false;
                        this.lstObject[vtPol].lst1 = new Point[this.lstObject[vtPol].dem];
                        for (int i = 0; i < this.lstObject[vtPol].dem; i++)
                            this.lstObject[vtPol].lst1[i] = mang[i];
                        press = 0;

                        int j = this.lstObject.Count - 1;
                        while (j > vtPol) this.lstObject.Remove(this.lstObject[j--]);
                        
                    }
                }
                
                
            }
            else if(dichuyen== true)        //phần di chuyển
            {
                for (int i = 0; i < this.lstObject.Count; i++)
                {
                    if (this.lstObject[i].Thuoc(e.Location) == 1)
                    {
                        Temp = e.Location;
                        this.lstObject[i].dichuyen = true;
                        this.lstObject[i].p1new.X = e.X - this.lstObject[i].p1.X;
                        this.lstObject[i].p1new.Y = e.Y - this.lstObject[i].p1.Y;
                        this.lstObject[i].p2new.X = e.X - this.lstObject[i].p2.X;
                        this.lstObject[i].p2new.Y = e.Y - this.lstObject[i].p2.Y;

                        this.lstObject[i].Draw(this.g, this.lstObject[i].penTemp, this.lstObject[i].iBrush);
                    }
                    else if(this.lstObject[i].p1==new Point(0,0)&&TimKhungHinh(this.lstObject[i].lst1, this.lstObject[i].dem,e.Location)==1) // nếu đó là polygon và vị trí chuột thuộc khung hình
                    {
                        Temp = e.Location;
                        int n = this.lstObject[i].dem;
                        this.lstObject[i].dichuyen = true;
                        this.lstObject[i].PointTemp = new Point[n];
                        for (int j=0;j<n;j++)
                        {
                            this.lstObject[i].PointTemp[j].X = e.X - this.lstObject[i].lst1[j].X;
                            this.lstObject[i].PointTemp[j].Y=e.Y-this.lstObject[i].lst1[j].Y;
                        }
                        this.lstObject[i].Draw(this.g, this.lstObject[i].penTemp, this.lstObject[i].iBrush);
                       
                    }
                    else
                        this.lstObject[i].Draw(this.g, this.lstObject[i].pen, this.lstObject[i].iBrush);
                }
                //Temp.X = e.X - Temp.X;
                //Temp.Y = e.Y - Temp.Y;

            }
            else if (chon == true)
            {
                g.Clear(Color.White);
                if (ctrl==false)
                    for (int i = 0; i < this.lstObject.Count; i++)
                    {
                        if ((this.lstObject[i].Thuoc(e.Location) == 1)|| (this.lstObject[i].p1 == new Point(0, 0) && TimKhungHinh(this.lstObject[i].lst1, this.lstObject[i].dem, e.Location) == 1))
                        {
                            this.lstObject[i].chon = true;
                            this.lstObject[i].Draw(this.g, this.lstObject[i].penTemp, this.lstObject[i].iBrush);
                        }
                        else
                        {
                            this.lstObject[i].chon = false;
                            this.lstObject[i].Draw(this.g, this.lstObject[i].pen, this.lstObject[i].iBrush);
                        }
                    }
               else if(ctrl==true)
                    for (int i = 0; i < this.lstObject.Count; i++)
                    {
                        if ((this.lstObject[i].Thuoc(e.Location) == 1) || (this.lstObject[i].p1 == new Point(0, 0) && TimKhungHinh(this.lstObject[i].lst1, this.lstObject[i].dem, e.Location) == 1))
                        {
                            this.lstObject[i].chon = true;
                        }
                        if (this.lstObject[i].chon == true)
                        {
                            this.lstObject[i].Draw(this.g, this.lstObject[i].penTemp, this.lstObject[i].iBrush);

                        }
                        else
                            this.lstObject[i].Draw(this.g, this.lstObject[i].pen, this.lstObject[i].iBrush);

                    }
                if(IsZoom==true)
                {
                    int i = 0;
                    zoom = true;
                    while (i<this.lstObject.Count&&this.lstObject[i].chon != true ) i++;
                    if(i<this.lstObject.Count)this.lstObject[i].p1new = this.lstObject[i].p2;
                  
                }
              
            }
            else if(fill==true)
            {
                for (int i = 0; i < this.lstObject.Count; i++)
                {
                    if ((this.lstObject[i].Thuoc(e.Location) == 1) || (this.lstObject[i].p1 == new Point(0, 0) && TimKhungHinh(this.lstObject[i].lst1, this.lstObject[i].dem, e.Location) == 1))
                        this.lstObject[i].fill = true;
                    this.lstObject[i].Draw(this.g, this.lstObject[i].pen, this.lstObject[i].iBrush);
                }
            }
            Main_PictureBox.Image = bitmap;


        }

        private void Main_PictureBox_MouseUp(object sender, MouseEventArgs e)
        {
            //Cursor cur = Cursors.Arrow;
            //this.Cursor = cur;
            zoom = false;
            if (chon == false&&fill==false)
            {
                press = 0;
                if (dichuyen == false)
                    this.lstObject[this.lstObject.Count - 1].p2 = e.Location;
                
                g.Clear(Color.White);
                for (int i = 0; i < this.lstObject.Count; i++)
                {
                    this.lstObject[i].dichuyen = false;
                    if (begin == true)
                    {
                        if (i != vtPol)
                            this.lstObject[i].Draw(this.g, this.lstObject[i].pen, this.lstObject[i].iBrush);
                    }
                    else this.lstObject[i].Draw(this.g, this.lstObject[i].pen, this.lstObject[i].iBrush);
                }
                if (LuaChon == 5&&end==false)
                {
                    press = 1;
                    mang[this.lstObject[vtPol].dem++] = e.Location;
                    clsDrawObject myobj;
                    myobj = new clsLine();
                    myobj.p1 = e.Location;
                    myobj.pen = new Pen(myColor, Convert.ToInt32(nmr.Value));
                    myobj.penTemp = new Pen(Color.Black, Convert.ToInt32(nmr.Value));
                    this.lstObject.Add(myobj);
                    
                }
                Main_PictureBox.Image = bitmap;
            }
            
        }

        private void btn_HCN_Click(object sender, EventArgs e)
        {
            LuaChon = 2;
        }

        private void btn_duongcong_Click(object sender, EventArgs e)
        {
            this.LuaChon = 4;
        }

        private void Main_PictureBox_MouseClick(object sender, MouseEventArgs e)
        {
            //for (int i = 0; i < this.lstObject.Count; i++)
            //{
            //    if (this.lstObject[i].Thuoc(e.Location) == 1)
            //    {
            //        Temp = e.Location;
            //        dichuyen = true;
            //        this.lstObject[i].dichuyen = true;
            //        this.lstObject[i].p1new.X = e.X - this.lstObject[i].p1.X;
            //        this.lstObject[i].p1new.Y = e.Y - this.lstObject[i].p1.Y;
            //        this.lstObject[i].p2new.X = e.X - this.lstObject[i].p2.X;
            //        this.lstObject[i].p2new.Y = e.Y - this.lstObject[i].p2.Y;

            //        this.lstObject[i].Draw(this.g, this.lstObject[i].penTemp);
            //    }
            //    else
            //        this.lstObject[i].Draw(this.g, this.lstObject[i].pen);

            //}
        }

        private void Chon_Click(object sender, EventArgs e)
        {
           chon =!chon;
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode==Keys.ControlKey)
               ctrl = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int i = 0;
            int n = this.lstObject.Count;
            for (i = 0; i < n; i++)
            {
                int j = 0;
                while (j < this.lstObject.Count && this.lstObject[j].chon != true) j++;
                     if(j<this.lstObject.Count)   this.lstObject.Remove(this.lstObject[j]);
            }
            g.Clear(Color.White);
            for ( i = 0; i < this.lstObject.Count; i++)
            { 
              
                    this.lstObject[i].Draw(this.g, this.lstObject[i].pen, this.lstObject[i].iBrush);
            }
            Main_PictureBox.Image = bitmap;
            Thread.Sleep(1);
            Application.DoEvents();
        }

        private void btnDagiac_Click(object sender, EventArgs e)
        {
            LuaChon = 5;
        }

        private void Main_PictureBox_MouseMove(object sender, MouseEventArgs e)
        {
            IsZoom = false;
            if (fill == false)
            {
                Cursor cur = Cursors.Arrow;
                this.Cursor = cur;
            }
            else
            {
                this.img = new Bitmap(SimplePaint.Properties.Resources.paint2);
                // Do hàm tạo con trỏ chuột là 1 hàm kiểu static nên ta dùng Form 1 gọi trực tiếp nó.
                this.Cursor = Form1.CreateCursor(img, 3, 3);
            }
            if (press==1&&fill==false)
            {
                    g.Clear(Color.White);
                    this.lstObject[this.lstObject.Count - 1].p2 = e.Location;
                    for (int i = 0; i < this.lstObject.Count; i++)
                    {
                        if (begin == true)
                        {
                            if (i != vtPol)
                                this.lstObject[i].Draw(this.g, this.lstObject[i].pen,this.lstObject[i].iBrush);
                        }
                        else this.lstObject[i].Draw(this.g, this.lstObject[i].pen,this.lstObject[i].iBrush);
                    }
                   if(LuaChon==5 &&e.X<=mang[0].X+2&&e.X>=mang[0].X-2&&e.Y>=mang[0].Y-2&&e.Y<=mang[0].Y+2)
                    {
                   
                        end = true;
                        //this.img = new Bitmap("elip.png");
                         this.img = new Bitmap(SimplePaint.Properties.Resources.elip2);
                        // Do hàm tạo con trỏ chuột là 1 hàm kiểu static nên ta dùng Form 1 gọi trực tiếp nó.
                        this.Cursor = Form1.CreateCursor(img, 3, 3);
                        //this.Cursor = CreateCursor(img, 3, 3);
                    }
                   else
                   {
                        end = false;
                    
                   }
                    Main_PictureBox.Image = bitmap;
                    Thread.Sleep(1);
                    Application.DoEvents();
            }
            else
            if(dichuyen==true)
            {
                g.Clear(Color.White);
                for (int i = 0; i < this.lstObject.Count; i++)
                {

                    if (this.lstObject[i].dichuyen == true)
                    {
                        if (this.lstObject[i].p1 != new Point(0, 0))
                        {
                            this.lstObject[i].p1.X = e.X - this.lstObject[i].p1new.X;
                            this.lstObject[i].p1.Y = e.Y - this.lstObject[i].p1new.Y;
                            this.lstObject[i].p2.X = e.X - this.lstObject[i].p2new.X;
                            this.lstObject[i].p2.Y = e.Y - this.lstObject[i].p2new.Y;
                            
                        }
                        else
                        {
                            for (int j=0;j<this.lstObject[i].dem;j++)
                            {
                                this.lstObject[i].lst1[j].X = e.X - this.lstObject[i].PointTemp[j].X;
                                this.lstObject[i].lst1[j].Y = e.Y - this.lstObject[i].PointTemp[j].Y;
                            }
                        }
                        this.lstObject[i].Draw(this.g, this.lstObject[i].penTemp, this.lstObject[i].iBrush);
                    }
                    else
                        this.lstObject[i].Draw(this.g, this.lstObject[i].pen, this.lstObject[i].iBrush);
                }
                Main_PictureBox.Image = bitmap;
                Thread.Sleep(1);
                Application.DoEvents();
            }
            else if(chon==true)
            {
                for (int i=0; i<this.lstObject.Count;i++)
                {
                    if (e.X >= this.lstObject[i].p1.X - 5 && e.X <= this.lstObject[i].p1.X + 5 && e.Y >= this.lstObject[i].p1.Y - 5 && e.Y <= this.lstObject[i].p1.Y + 5)
                    {
                        IsZoom = true;
                        if (this.lstObject[i].p1.Y > this.lstObject[i].p2.Y)
                        {
                            this.img = new Bitmap(SimplePaint.Properties.Resources.len);
                            // Do hàm tạo con trỏ chuột là 1 hàm kiểu static nên ta dùng Form 1 gọi trực tiếp nó.
                            this.Cursor = Form1.CreateCursor(img, 3, 3);
                        }
                        else
                        {
                            this.img = new Bitmap(SimplePaint.Properties.Resources.xuong);
                            // Do hàm tạo con trỏ chuột là 1 hàm kiểu static nên ta dùng Form 1 gọi trực tiếp nó.
                            this.Cursor = Form1.CreateCursor(img, 3, 3);
                        }
                    }
                    else if(e.X >= this.lstObject[i].p2.X - 5 && e.X <= this.lstObject[i].p2.X + 5 && e.Y >= this.lstObject[i].p2.Y - 5 && e.Y <= this.lstObject[i].p2.Y + 5)
                    {
                        IsZoom = true;
                        if(this.lstObject[i].p1.Y < this.lstObject[i].p2.Y)
                        {
                            this.img = new Bitmap(SimplePaint.Properties.Resources.xuong);
                            // Do hàm tạo con trỏ chuột là 1 hàm kiểu static nên ta dùng Form 1 gọi trực tiếp nó.
                            this.Cursor = Form1.CreateCursor(img, 3, 3);
                        }
                        else
                        {
                            this.img = new Bitmap(SimplePaint.Properties.Resources.len);
                            // Do hàm tạo con trỏ chuột là 1 hàm kiểu static nên ta dùng Form 1 gọi trực tiếp nó.
                            this.Cursor = Form1.CreateCursor(img, 3, 3);
                        }
                    }

                }
                if(zoom==true)
                {
                    g.Clear(Color.White);
                    for (int i = 0; i < this.lstObject.Count; i++)
                        if (this.lstObject[i].chon == true)
                        {
                            if (e.X >= this.lstObject[i].p1.X - 5 && e.X <= this.lstObject[i].p1.X + 5 && e.Y >= this.lstObject[i].p1.Y - 5 && e.Y <= this.lstObject[i].p1.Y + 5)
                            {
                                this.lstObject[i].p1 = this.lstObject[i].p1new;
                                this.lstObject[i].p2 = e.Location;
                                this.lstObject[i].Draw(this.g, this.lstObject[i].penTemp, this.lstObject[i].iBrush);
                            }
                            else if (e.X >= this.lstObject[i].p2.X - 5 && e.X <= this.lstObject[i].p2.X + 5 && e.Y >= this.lstObject[i].p2.Y - 5 && e.Y <= this.lstObject[i].p2.Y + 5)
                            {
                                this.lstObject[i].p2 = e.Location;
                                this.lstObject[i].Draw(this.g, this.lstObject[i].penTemp, this.lstObject[i].iBrush);
                            }
                        }
                    else this.lstObject[i].Draw(this.g, this.lstObject[i].pen, this.lstObject[i].iBrush);

                }
                Main_PictureBox.Image = bitmap;
            }
        }

      

        private void btn_color_Click_1(object sender, EventArgs e)
        {

            ColorDialog dlg = new ColorDialog(); //Khởi tạo đối tượng ColorDialog 
            dlg.ShowDialog(); //Hiển thị hộp thoại

            if (dlg.ShowDialog() == DialogResult.OK) //Nếu nhấp vào nút OK trên hộp thoại
            {
                string str = null; //Khai báo biến str
                str = dlg.Color.Name; //Trả lại tên của màu đã lựa chọn
                myColor = dlg.Color;
            }
        }

        private void btn_Fill_Click(object sender, EventArgs e)
        {
            fill = !fill;
           
        }

        private void Move_Click(object sender, EventArgs e)
        {
            this.dichuyen =!dichuyen;
            if (dichuyen == true) Move.BackColor = Color.Red;
            else Move.BackColor = Color.White;
        }
        public int TimKhungHinh(Point[] f,int n,Point e)
        {
            Point vtmax1=f[0];
            Point vtmax2=f[0];
            for (int i = 0; i < n; i++)
            {
                if (f[i].X < vtmax1.X) vtmax1.X = f[i].X;
                if (f[i].X > vtmax2.X) vtmax2.X = f[i].X;
                if (f[i].Y < vtmax1.Y) vtmax1.Y = f[i].Y;
                if (f[i].Y > vtmax2.Y) vtmax2.Y = f[i].Y;
            }
            if (e.X >= vtmax1.X && e.Y >= vtmax1.Y && e.X <= vtmax2.X && e.Y <= vtmax2.Y)
                return 1;
            return 0;
        }
    }
}


