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
namespace MidTerm
{
    public partial class Form1 : Form
    {
        Bitmap bitmap;
        Graphics g;
        Player player;
        int act=0,BossAct=0;
        List<Dan> BangDan = new List<Dan>();
        List<Dan> DanBoss = new List<Dan>();
        bool clickUp = false, right, left,BoomBegin=false,BossAppr=false,EggAppr=false,Boss1Appr=false;
        Point vtBoom;
        int step = 0;
        Random r = new Random();
        Boss iBoss,Boss1;
        int Score,speed=5;
        List<Dan> ThienThach = new List<Dan>();
        public Form1()
        {
            InitializeComponent();

            bitmap = new Bitmap(Main_PictureBox.Width, Main_PictureBox.Height);
            g = Graphics.FromImage(bitmap);
            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;

            iBoss = new Boss();
            iBoss.location.X = 1104;
            iBoss.location.Y = Main_PictureBox.Height - MidTerm.Properties.Resources._1.Height;
            for (int i=0;i<6;i++)
            {
                Dan tt = new Dan();
                tt.location.X = r.Next(Main_PictureBox.Width / 3,Main_PictureBox.Width) ;
                tt.location.Y = r.Next(-1000, -50);
                tt.type = r.Next(2);
                tt.locationOld = tt.location;
                ThienThach.Add(tt);
               
            }
            Dan dan = new Dan();
            dan.location.X = iBoss.location.X - 8;
            dan.location.Y = Main_PictureBox.Height - 60;
            DanBoss.Add(dan);

        }
        int force, index = 0, y_nv=0;
        double ThoiGian=0,dem;
        int vt = 16;
        private void Form1_Load(object sender, EventArgs e)
        {
            player = new Player();
            player.location.Y = Main_PictureBox.Height - MidTerm.Properties.Resources.r1.Height;
            player.location.X = 10;
            Random r = new Random();
            // làm trong suốt và đặt vị trí ban đầu.
            label1.Parent = Main_PictureBox;
            lb_Score.Parent = Main_PictureBox;
            ptb_DinoBlue.Parent = Main_PictureBox;
            ptb_DinoYellow.Parent = Main_PictureBox;
            ptb_Boom.Parent = Main_PictureBox;
            ptb_Boom2.Parent = Main_PictureBox;
            ptb_Boom3.Parent = Main_PictureBox;
            ptb_Boom4.Parent = Main_PictureBox;
            ptb_KingDino.Parent = Main_PictureBox;
            ptb_FlyDraGon.Parent = Main_PictureBox;
            ptb_FlyDraGon.Visible = false;
            ptb_KingDino.Visible = false;
            ptb_DinoBlue.Visible = false;
            ptb_DinoYellow.Visible = false;
            ptb_Boom.Visible = false;
            ptb_Boom2.Visible = false;
            ptb_Boom3.Visible = false;
            ptb_Boom4.Visible = false;
            //ptb_boss.Visible = false;
            //ptb_boss.Parent = Main_PictureBox;
            ptb_DinoBlue.Left = Main_PictureBox.Width + 50 + r.Next(50);
            ptb_DinoBlue.Top = Main_PictureBox.Height - ptb_DinoBlue.Height+vt;
            ptb_DinoYellow.Left = Main_PictureBox.Width + 50 + r.Next(50);
            ptb_DinoYellow.Top = Main_PictureBox.Height - ptb_DinoYellow.Height+vt;
            Dan dan = new Dan();
            BangDan.Add(dan);
            timer_HoatCanh.Start();

        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Right) { right = false; }
            if (e.KeyCode == Keys.Left) { left = false; }
        }

        private void timer_HoatCanh_Tick(object sender, EventArgs e)
        {

            if (ThoiGian % 5 == 0)
            {
                act++;
                if (act == 4)
                    act = 0;
            }
            if (ThoiGian % 3 == 0)
            {
                BossAct++;
                if (BossAct == 36)
                    BossAct = 1;
            }
            ThoiGian += 1;
            // Điều khiển thiên thạch
            for (int i = 0; i < this.ThienThach.Count; i++)
            {
                if (ThienThach[i].location.X < -20 && ThienThach[i].location.Y > Main_PictureBox.Height)
                {
                    ThienThach[i].location.Y = r.Next(-1000, -50);
                    ThienThach[i].location.X = r.Next(Main_PictureBox.Width / 3, Main_PictureBox.Width);
                    ThienThach[i].locationOld = ThienThach[i].location;
                }
                else
                {

                    ThienThach[i].location.X -= 1;
                    ThienThach[i].location.Y = ThienThach[i].locationOld.Y - 0.7751f * (ThienThach[i].location.X - ThienThach[i].locationOld.X);

                }
            }
            // Boss cuối cùng xuất hiện
            if (Convert.ToInt32(lb_Score.Text) == 2)
            {
                BossAppr = true;
                timer_DinoDiChuyen.Stop();
                SetVT();
            }
            //Boss thứ nhất xuất hiện.
            if (Convert.ToInt32(lb_Score.Text) == 10)
            {
                lb_Score.Text = "4";
                EggAppr = true;
                Boss1 = new Boss();
                ptb_FlyDraGon.Visible = true;
                ptb_FlyDraGon.Left = Main_PictureBox.Width + 50 + r.Next(50);
                ptb_FlyDraGon.Top = ptb_FlyDraGon.Height + vt;
                Boss1.location.X = ptb_FlyDraGon.Left+90;
                Boss1.location.Y = ptb_FlyDraGon.Top + ptb_FlyDraGon.Height - 80;

                Boss1Appr = true;
            }
            //Đạn của player bay
            if (BangDan[0].shoot == false)
            {
                BangDan[0].shoot = true;
                BangDan[0].location.X = player.location.X + MidTerm.Properties.Resources.r1.Width;
                BangDan[0].location.Y = player.location.Y + MidTerm.Properties.Resources.r1.Height / 2;
            }
            for (int i = 0; i < BangDan.Count; i++)
            {
                if (BangDan[i].location.X + MidTerm.Properties.Resources.dan.Width >= Main_PictureBox.Width - 5)
                {
                    BangDan[i].location.X = player.location.X + MidTerm.Properties.Resources.r1.Width;
                    BangDan[i].shoot = false;

                }
                else
                    BangDan[i].location.X += 20;
                // so sánh khủng long trúng đạn
                if ((BangDan[i].location.X >= ptb_DinoBlue.Left - 13 && BangDan[i].location.Y >= ptb_DinoBlue.Top + 10))
                {
                    Marking();
                    vtBoom = new Point(ptb_DinoBlue.Left - 5, ptb_DinoBlue.Top - 20);
                    BoomBegin = true;
                    timer_Boom.Start();
                    BangDan[i].location.X = player.location.X + MidTerm.Properties.Resources.r1.Width;
                    BangDan[i].shoot = false;
                    ptb_DinoBlue.Visible = false;
                }
                else if (BangDan[i].location.X >= ptb_DinoYellow.Left - 13 && BangDan[i].location.Y >= ptb_DinoYellow.Top + 10)
                {
                    Marking();
                    BoomBegin = true;
                    vtBoom = new Point(ptb_DinoYellow.Left - 5, ptb_DinoYellow.Top - 20);
                    timer_Boom.Start();
                    BangDan[i].location.X = player.location.X + MidTerm.Properties.Resources.r1.Width;
                    BangDan[i].shoot = false;
                    ptb_DinoYellow.Visible = false;
                }
            }
            // Điều khiển đạn của boss cuối
            if(BossAppr==true)
            {
                if ((DanBoss[index].location.X <= player.location.X + MidTerm.Properties.Resources.r1.Width && DanBoss[index].location.X > player.location.X &&
                        DanBoss[index].location.Y <= player.location.Y + MidTerm.Properties.Resources.r1.Height) || DanBoss[index].location.X <= 0)
                {
                    DanBoss[index].location.X = iBoss.location.X - 8;
                    DanBoss[index].shoot = false;
                }
                else if(DanBoss[index].shoot==true)
                    DanBoss[index].location.X -= 20;
                  
            }
            //điều khiển khủng long di chuyển
            if (ptb_KingDino.Visible == false&&EggAppr==false)
            {
                if (ptb_DinoYellow.Visible == false && ptb_DinoBlue.Visible == false)
                {
                    Random r = new Random();
                    int temp = r.Next(2);
                    if (temp == 1)
                    {
                        ptb_DinoBlue.Visible = true;
                        ptb_DinoYellow.Visible = false;

                    }
                    else if (temp == 0)
                    {
                        ptb_DinoYellow.Visible = true;
                        ptb_DinoBlue.Visible = false;

                    }
                    SetVT();
                }
                if (ptb_DinoYellow.Visible == true)
                {
                    // kiểm tra khủng long qua khỏi map và đụng player
                    if ((ptb_DinoYellow.Left <= player.location.X + MidTerm.Properties.Resources.r1.Width && ptb_DinoYellow.Left > player.location.X &&
                        ptb_DinoYellow.Top <= player.location.Y + MidTerm.Properties.Resources.r1.Height))  //va chạm player
                    {
                        Marking();
                        BoomBegin = true;
                        vtBoom = new Point(ptb_DinoYellow.Left - 5, ptb_DinoYellow.Top - 20);
                        timer_Boom.Start();
                        ptb_DinoYellow.Visible = false;
                    }
                    else if (ptb_DinoYellow.Left <= 2)       //qua khỏi map
                        ptb_DinoYellow.Visible = false;
                    else
                        ptb_DinoYellow.Left -= 5;
                }
                else if (ptb_DinoBlue.Visible == true)
                {
                    
                    if ((ptb_DinoBlue.Left <= player.location.X + MidTerm.Properties.Resources.r1.Width && ptb_DinoBlue.Left > player.location.X &&
                        ptb_DinoBlue.Top <= player.location.Y + MidTerm.Properties.Resources.r1.Height))  //va chạm player
                    {
                        Marking();
                        vtBoom = new Point(ptb_DinoBlue.Left - 5, ptb_DinoBlue.Top - 20);
                        BoomBegin = true;
                        timer_Boom.Start();
                        ptb_DinoBlue.Visible = false;
                    }
                    else if (ptb_DinoBlue.Left <= 2) //qua khỏi map
                    {
                        ptb_DinoBlue.Visible = false;
                    }
                    else ptb_DinoBlue.Left -= 5;
                }
            }
            else
            if (ptb_KingDino.Visible == true)
            {
                if ((ptb_KingDino.Left <= player.location.X + MidTerm.Properties.Resources.r1.Width && ptb_KingDino.Left > player.location.X &&
                   ptb_KingDino.Top <= player.location.Y + MidTerm.Properties.Resources.r1.Height))  //va chạm player
                {
                    Marking();
                    ptb_DinoYellow.Visible = false;
                    ptb_DinoBlue.Visible = false;
                    SetVT();
                    BoomBegin = true;
                    ptb_KingDino.Visible = false;
                    vtBoom = new Point(ptb_KingDino.Left - 10, ptb_KingDino.Top - 20);
                    timer_Boom.Start();
                }
                else if (ptb_KingDino.Left <= 2) //qua khỏi map
                {
                    ptb_KingDino.Visible = false;
                    ptb_KingDino.Enabled = false;
                }
                else
                {
                    ptb_KingDino.Left -= 5;

                }
            }
            // Boss thứ nhất xuất hiện.
            if(Boss1Appr==true)
            {
                ptb_FlyDraGon.Left -= 5;
                if (Boss1.location.X >= Main_PictureBox.Width - ptb_FlyDraGon.Width)
                    Boss1.location.X -= 5;
                else if (Boss1.location.Y <= Main_PictureBox.Height)
                    Boss1.location.Y += 5;
                else if (Boss1.location.Y+500 >= Main_PictureBox.Height)
                {
                    if (ptb_KingDino.Enabled == false)
                    {

                        EggAppr = false;
                        ptb_KingDino.Enabled = true;
                        ptb_KingDino.Visible = true;
                        ptb_KingDino.Left = Convert.ToInt32(Boss1.location.X);
                        ptb_KingDino.Top = Main_PictureBox.Height - ptb_KingDino.Height + 30;
                    }

                }
                else if (ptb_FlyDraGon.Left + ptb_FlyDraGon.Width <= 0)
                {
                    Boss1Appr = false;
                   
                }
            }
            draw(act);
           
        }

        private void timer_Nhanvatchay_Tick(object sender, EventArgs e)
        {

        }

        void SetVT()
        {
            ptb_DinoBlue.Left = Main_PictureBox.Width + 50 + r.Next(50);
            ptb_DinoBlue.Top = Main_PictureBox.Height - ptb_DinoBlue.Height + vt;
            ptb_DinoYellow.Left = Main_PictureBox.Width + 50 + r.Next(50);
            ptb_DinoYellow.Top = Main_PictureBox.Height - ptb_DinoYellow.Height + vt;
        }
      
        // timer điều khiển đạn
        private void DanBay_Tick(object sender, EventArgs e)
        {
           
        }
        void Marking()
        {
            Score += 2;
            lb_Score.Text = Convert.ToString(Score);
        }
        private void timer_DinoDiChuyen_Tick(object sender, EventArgs e)
        {
        }
        // Boss thứ nhất xuất hiện
        private void timer_Boss_Tick(object sender, EventArgs e)
        {
           
            
        }

        private void timer_ThienThach_Tick(object sender, EventArgs e)
        {
           

        }

        private void timer_Boom_Tick(object sender, EventArgs e)
        {
            
            if (BoomBegin == true)
            {
                step++;
                if (step == 1)
                {   ptb_Boom.Top = vtBoom.Y+24;
                    ptb_Boom.Left = vtBoom.X;
                    ptb_Boom.Visible = true;
                    ptb_Boom2.Visible = false;
                    ptb_Boom3.Visible = false;
                    ptb_Boom4.Visible = false;
                }
                else if (step == 2)
                {
                    ptb_Boom2.Top = vtBoom.Y + 24;
                    ptb_Boom2.Left = vtBoom.X;
                    ptb_Boom.Visible = false;
                    ptb_Boom2.Visible =true;
                    ptb_Boom3.Visible = false;
                    ptb_Boom4.Visible = false;
                }
                else if (step == 3)
                {
                    ptb_Boom3.Location = vtBoom;

                    ptb_Boom.Visible = false;
                    ptb_Boom2.Visible = false;
                    ptb_Boom3.Visible = true;
                    ptb_Boom4.Visible = false;
                }
                else if (step == 4)
                {
                    ptb_Boom4.Location = vtBoom;
                    ptb_Boom.Visible = false;
                    ptb_Boom2.Visible = false;
                    ptb_Boom3.Visible = false;
                    ptb_Boom4.Visible = true;
                    BoomBegin = false;
                    step = 0;
                }
            }
            else
            {
                ptb_Boom4.Visible = false;
                timer_Boom.Stop();
            }
        }

        //private void timer_Nhanvatchay_Tick(object sender, EventArgs e)
        //{
        //    act++;
        //    if (act == 4)
        //        act = 0;
        //    BossAct++;
        //        if (BossAct == 36)
        //        BossAct = 1;
        //}

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Right) { right = true; }
            if (e.KeyCode == Keys.Left) { left = true; }
            if (e.KeyData == Keys.Up)      // khi ấn nút mũi tên lên nhân vật sẽ nhảy
            {
                if (clickUp == false)
                {
                    y_nv = 0;
                    clickUp = true;
                    force = 50;
                    timer1_NhanVatNhay.Start();
                   
                }
            }
           
        }

        int x_tien;
        private void timer1_NhanVatNhay_Tick(object sender, EventArgs e)
        {
            if (right == true) { player.location.X += 5; }
            if (left == true) { player.location.X -= 5; }
            this.SetStyle(ControlStyles.AllPaintingInWmPaint | ControlStyles.UserPaint | ControlStyles.DoubleBuffer, true);


            if (y_nv >= 300)
            {
                player.location.Y += 30;

            }
            else
            {
                // xác định nhân vật đã nhảy cao bao nhiêu            
                player.location.Y -= force;
                y_nv += force;
                force -= 2;

            }
            if ((player.location.Y+ MidTerm.Properties.Resources.r4.Height) >= pn_ground.Top)
            {
                timer1_NhanVatNhay.Stop();
                player.location.Y = Main_PictureBox.Height - MidTerm.Properties.Resources.r1.Height;
                clickUp = false;
                // còn nếu = true tức nhân vật đang thực hiện nhảy. sẽ đợi nhân vật đáp đất mới cho t đc phép nhảy tiếp
            }
            Thread.Sleep(1);
            Application.DoEvents();
        }
        public void draw(int act)
        {
            g.Clear(Color.White);

            g.DrawImage(MidTerm.Properties.Resources.background, new Point(0, 0));
            for (int i = 0; i < this.ThienThach.Count; i++)
                if (ThienThach[i].type == 0)
                    g.DrawImage(MidTerm.Properties.Resources.t1, ThienThach[i].location);
                else if (ThienThach[i].type == 1)
                    g.DrawImage(MidTerm.Properties.Resources.t2, ThienThach[i].location);
            if (act == 1)
                g.DrawImage(MidTerm.Properties.Resources.r1, player.location);
            else if (act == 2)
                g.DrawImage(MidTerm.Properties.Resources.r2, player.location);
            else if (act == 3)
                g.DrawImage(MidTerm.Properties.Resources.r3, player.location);
            else
                g.DrawImage(MidTerm.Properties.Resources.r4, player.location);
            for (int j = 0; j < BangDan.Count; j++)
                if (BangDan[j].shoot == true)
                    g.DrawImage(MidTerm.Properties.Resources.dan, BangDan[j].location);
            if(BossAppr==true)
            {
                switch(BossAct)
                {
                    case 1:
                        g.DrawImage(MidTerm.Properties.Resources._1,iBoss.location);
                        break;
                    case 2:
                        g.DrawImage(MidTerm.Properties.Resources._2,iBoss.location);
                        break;
                    case 3:
                        g.DrawImage(MidTerm.Properties.Resources._3,iBoss.location);
                        break;
                    case 4:
                        g.DrawImage(MidTerm.Properties.Resources._4,iBoss.location);
                        break;
                    case 5:
                        g.DrawImage(MidTerm.Properties.Resources._5,iBoss.location);
                        break;
                    case 6:
                        g.DrawImage(MidTerm.Properties.Resources._6,iBoss.location);
                        break;
                    case 7:
                        g.DrawImage(MidTerm.Properties.Resources._7,iBoss.location);
                        break;
                    case 8:
                        g.DrawImage(MidTerm.Properties.Resources._8,iBoss.location);
                        break;
                    case 9:
                        g.DrawImage(MidTerm.Properties.Resources._9,iBoss.location);
                        break;
                    case 10:
                        g.DrawImage(MidTerm.Properties.Resources._10,iBoss.location);
                        break;
                    case 11:
                        g.DrawImage(MidTerm.Properties.Resources._11,iBoss.location);
                        break;
                    case 12:
                        g.DrawImage(MidTerm.Properties.Resources._12,iBoss.location);
                        break;
                    case 13:
                        g.DrawImage(MidTerm.Properties.Resources._13,iBoss.location);
                        break;
                    case 14:
                        g.DrawImage(MidTerm.Properties.Resources._14,iBoss.location);
                        break;
                    case 15:
                        g.DrawImage(MidTerm.Properties.Resources._15,iBoss.location);
                        break;
                    case 16:
                        g.DrawImage(MidTerm.Properties.Resources._16,iBoss.location);
                        break;
                    case 17:
                        g.DrawImage(MidTerm.Properties.Resources._17,iBoss.location);
                        break;
                    case 18:
                        g.DrawImage(MidTerm.Properties.Resources._18,iBoss.location);
                        break;
                    case 19:
                        g.DrawImage(MidTerm.Properties.Resources._19,iBoss.location);
                        break;
                    case 20:
                        g.DrawImage(MidTerm.Properties.Resources._20,iBoss.location);
                        break;
                    case 21:
                        g.DrawImage(MidTerm.Properties.Resources._21,iBoss.location);
                        index++;
                        if (index == DanBoss.Count)
                            index = 0;
                        DanBoss[index].shoot = true;
                        break;
                    case 22:
                        g.DrawImage(MidTerm.Properties.Resources._22,iBoss.location);
                        break;
                    case 23:
                        g.DrawImage(MidTerm.Properties.Resources._23,iBoss.location);
                        break;
                    case 24:
                        g.DrawImage(MidTerm.Properties.Resources._24,iBoss.location);
                        break;
                    case 25:
                        g.DrawImage(MidTerm.Properties.Resources._25,iBoss.location);
                        break;
                    case 26:
                        g.DrawImage(MidTerm.Properties.Resources._26,iBoss.location);
                        break;
                    case 27:
                        g.DrawImage(MidTerm.Properties.Resources._27,iBoss.location);
                        break;
                    case 28:
                        g.DrawImage(MidTerm.Properties.Resources._28,iBoss.location);
                        break;
                    case 29:
                        g.DrawImage(MidTerm.Properties.Resources._29,iBoss.location);
                        break;
                    case 30:
                        g.DrawImage(MidTerm.Properties.Resources._30,iBoss.location);
                        break;
                    case 31:
                        g.DrawImage(MidTerm.Properties.Resources._31, iBoss.location);
                        break;
                    case 32:
                        g.DrawImage(MidTerm.Properties.Resources._32, iBoss.location);
                        break;
                    case 33:
                        g.DrawImage(MidTerm.Properties.Resources._33, iBoss.location);
                        break;
                    case 34:
                        g.DrawImage(MidTerm.Properties.Resources._34, iBoss.location);
                        break;
                    case 35:
                        g.DrawImage(MidTerm.Properties.Resources._35, iBoss.location);
                        break;
                    case 36:
                        g.DrawImage(MidTerm.Properties.Resources._36, iBoss.location);
                        break;
                }
            }
            if(DanBoss[index].shoot==true)
            { 
                    g.DrawImage(MidTerm.Properties.Resources.fire, DanBoss[index].location);
            }
            if (EggAppr == true)
                g.DrawImage(MidTerm.Properties.Resources.egg, Boss1.location);
            Main_PictureBox.Image = bitmap;
        }
       

    }
}
