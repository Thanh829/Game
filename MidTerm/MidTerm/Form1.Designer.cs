namespace MidTerm
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.timer1_NhanVatNhay = new System.Windows.Forms.Timer(this.components);
            this.timer_HoatCanh = new System.Windows.Forms.Timer(this.components);
            this.DanBay = new System.Windows.Forms.Timer(this.components);
            this.timer_DinoDiChuyen = new System.Windows.Forms.Timer(this.components);
            this.timer_Boom = new System.Windows.Forms.Timer(this.components);
            this.timer_Boss = new System.Windows.Forms.Timer(this.components);
            this.timer_ThienThach = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lb_Score = new System.Windows.Forms.Label();
            this.ptb_FlyDraGon = new System.Windows.Forms.PictureBox();
            this.ptb_KingDino = new System.Windows.Forms.PictureBox();
            this.ptb_Boom4 = new System.Windows.Forms.PictureBox();
            this.ptb_Boom3 = new System.Windows.Forms.PictureBox();
            this.ptb_Boom2 = new System.Windows.Forms.PictureBox();
            this.ptb_Boom = new System.Windows.Forms.PictureBox();
            this.ptb_DinoYellow = new System.Windows.Forms.PictureBox();
            this.ptb_DinoBlue = new System.Windows.Forms.PictureBox();
            this.pn_ground = new System.Windows.Forms.Panel();
            this.Main_PictureBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.ptb_FlyDraGon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptb_KingDino)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptb_Boom4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptb_Boom3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptb_Boom2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptb_Boom)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptb_DinoYellow)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptb_DinoBlue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Main_PictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // timer1_NhanVatNhay
            // 
            this.timer1_NhanVatNhay.Interval = 20;
            this.timer1_NhanVatNhay.Tick += new System.EventHandler(this.timer1_NhanVatNhay_Tick);
            // 
            // timer_HoatCanh
            // 
            this.timer_HoatCanh.Enabled = true;
            this.timer_HoatCanh.Interval = 2;
            this.timer_HoatCanh.Tick += new System.EventHandler(this.timer_HoatCanh_Tick);
            // 
            // DanBay
            // 
            this.DanBay.Enabled = true;
            this.DanBay.Interval = 1;
            this.DanBay.Tick += new System.EventHandler(this.DanBay_Tick);
            // 
            // timer_DinoDiChuyen
            // 
            this.timer_DinoDiChuyen.Interval = 40;
            this.timer_DinoDiChuyen.Tick += new System.EventHandler(this.timer_DinoDiChuyen_Tick);
            // 
            // timer_Boom
            // 
            this.timer_Boom.Tick += new System.EventHandler(this.timer_Boom_Tick);
            // 
            // timer_Boss
            // 
            this.timer_Boss.Interval = 1;
            this.timer_Boss.Tick += new System.EventHandler(this.timer_Boss_Tick);
            // 
            // timer_ThienThach
            // 
            this.timer_ThienThach.Enabled = true;
            this.timer_ThienThach.Interval = 20;
            this.timer_ThienThach.Tick += new System.EventHandler(this.timer_ThienThach_Tick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI Black", 17F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(1330, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 31);
            this.label1.TabIndex = 8;
            this.label1.Text = "Score: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Black", 17F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(1146, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 31);
            this.label2.TabIndex = 9;
            // 
            // lb_Score
            // 
            this.lb_Score.AutoSize = true;
            this.lb_Score.BackColor = System.Drawing.Color.Transparent;
            this.lb_Score.Font = new System.Drawing.Font("Segoe UI Black", 17F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Score.Location = new System.Drawing.Point(1412, 9);
            this.lb_Score.Name = "lb_Score";
            this.lb_Score.Size = new System.Drawing.Size(28, 31);
            this.lb_Score.TabIndex = 10;
            this.lb_Score.Text = "0";
            // 
            // ptb_FlyDraGon
            // 
            this.ptb_FlyDraGon.BackColor = System.Drawing.Color.Transparent;
            this.ptb_FlyDraGon.Image = ((System.Drawing.Image)(resources.GetObject("ptb_FlyDraGon.Image")));
            this.ptb_FlyDraGon.Location = new System.Drawing.Point(97, 64);
            this.ptb_FlyDraGon.Name = "ptb_FlyDraGon";
            this.ptb_FlyDraGon.Size = new System.Drawing.Size(258, 184);
            this.ptb_FlyDraGon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ptb_FlyDraGon.TabIndex = 12;
            this.ptb_FlyDraGon.TabStop = false;
            // 
            // ptb_KingDino
            // 
            this.ptb_KingDino.BackColor = System.Drawing.Color.Transparent;
            this.ptb_KingDino.Enabled = false;
            this.ptb_KingDino.Image = ((System.Drawing.Image)(resources.GetObject("ptb_KingDino.Image")));
            this.ptb_KingDino.Location = new System.Drawing.Point(380, 64);
            this.ptb_KingDino.Name = "ptb_KingDino";
            this.ptb_KingDino.Size = new System.Drawing.Size(205, 184);
            this.ptb_KingDino.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ptb_KingDino.TabIndex = 11;
            this.ptb_KingDino.TabStop = false;
            // 
            // ptb_Boom4
            // 
            this.ptb_Boom4.BackColor = System.Drawing.Color.Transparent;
            this.ptb_Boom4.Image = ((System.Drawing.Image)(resources.GetObject("ptb_Boom4.Image")));
            this.ptb_Boom4.Location = new System.Drawing.Point(1212, 294);
            this.ptb_Boom4.Name = "ptb_Boom4";
            this.ptb_Boom4.Size = new System.Drawing.Size(207, 132);
            this.ptb_Boom4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.ptb_Boom4.TabIndex = 7;
            this.ptb_Boom4.TabStop = false;
            // 
            // ptb_Boom3
            // 
            this.ptb_Boom3.BackColor = System.Drawing.Color.Transparent;
            this.ptb_Boom3.Image = ((System.Drawing.Image)(resources.GetObject("ptb_Boom3.Image")));
            this.ptb_Boom3.Location = new System.Drawing.Point(931, 294);
            this.ptb_Boom3.Name = "ptb_Boom3";
            this.ptb_Boom3.Size = new System.Drawing.Size(254, 123);
            this.ptb_Boom3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.ptb_Boom3.TabIndex = 6;
            this.ptb_Boom3.TabStop = false;
            // 
            // ptb_Boom2
            // 
            this.ptb_Boom2.BackColor = System.Drawing.Color.Transparent;
            this.ptb_Boom2.Image = ((System.Drawing.Image)(resources.GetObject("ptb_Boom2.Image")));
            this.ptb_Boom2.Location = new System.Drawing.Point(721, 294);
            this.ptb_Boom2.Name = "ptb_Boom2";
            this.ptb_Boom2.Size = new System.Drawing.Size(176, 85);
            this.ptb_Boom2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ptb_Boom2.TabIndex = 5;
            this.ptb_Boom2.TabStop = false;
            // 
            // ptb_Boom
            // 
            this.ptb_Boom.BackColor = System.Drawing.Color.Transparent;
            this.ptb_Boom.Image = ((System.Drawing.Image)(resources.GetObject("ptb_Boom.Image")));
            this.ptb_Boom.Location = new System.Drawing.Point(676, 123);
            this.ptb_Boom.Name = "ptb_Boom";
            this.ptb_Boom.Size = new System.Drawing.Size(163, 125);
            this.ptb_Boom.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ptb_Boom.TabIndex = 4;
            this.ptb_Boom.TabStop = false;
            // 
            // ptb_DinoYellow
            // 
            this.ptb_DinoYellow.BackColor = System.Drawing.Color.Transparent;
            this.ptb_DinoYellow.Image = ((System.Drawing.Image)(resources.GetObject("ptb_DinoYellow.Image")));
            this.ptb_DinoYellow.Location = new System.Drawing.Point(870, 123);
            this.ptb_DinoYellow.Name = "ptb_DinoYellow";
            this.ptb_DinoYellow.Size = new System.Drawing.Size(163, 125);
            this.ptb_DinoYellow.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ptb_DinoYellow.TabIndex = 3;
            this.ptb_DinoYellow.TabStop = false;
            // 
            // ptb_DinoBlue
            // 
            this.ptb_DinoBlue.BackColor = System.Drawing.Color.Transparent;
            this.ptb_DinoBlue.Image = ((System.Drawing.Image)(resources.GetObject("ptb_DinoBlue.Image")));
            this.ptb_DinoBlue.Location = new System.Drawing.Point(1087, 123);
            this.ptb_DinoBlue.Name = "ptb_DinoBlue";
            this.ptb_DinoBlue.Size = new System.Drawing.Size(163, 125);
            this.ptb_DinoBlue.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ptb_DinoBlue.TabIndex = 2;
            this.ptb_DinoBlue.TabStop = false;
            // 
            // pn_ground
            // 
            this.pn_ground.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pn_ground.BackgroundImage")));
            this.pn_ground.Location = new System.Drawing.Point(0, 635);
            this.pn_ground.Name = "pn_ground";
            this.pn_ground.Size = new System.Drawing.Size(1602, 76);
            this.pn_ground.TabIndex = 1;
            // 
            // Main_PictureBox
            // 
            this.Main_PictureBox.BackColor = System.Drawing.Color.Transparent;
            this.Main_PictureBox.Location = new System.Drawing.Point(0, 2);
            this.Main_PictureBox.Name = "Main_PictureBox";
            this.Main_PictureBox.Size = new System.Drawing.Size(1602, 634);
            this.Main_PictureBox.TabIndex = 0;
            this.Main_PictureBox.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1604, 713);
            this.Controls.Add(this.ptb_FlyDraGon);
            this.Controls.Add(this.ptb_KingDino);
            this.Controls.Add(this.lb_Score);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ptb_Boom4);
            this.Controls.Add(this.ptb_Boom3);
            this.Controls.Add(this.ptb_Boom2);
            this.Controls.Add(this.ptb_Boom);
            this.Controls.Add(this.ptb_DinoYellow);
            this.Controls.Add(this.ptb_DinoBlue);
            this.Controls.Add(this.pn_ground);
            this.Controls.Add(this.Main_PictureBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.ptb_FlyDraGon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptb_KingDino)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptb_Boom4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptb_Boom3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptb_Boom2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptb_Boom)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptb_DinoYellow)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptb_DinoBlue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Main_PictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Timer timer1_NhanVatNhay;
        private System.Windows.Forms.Timer timer_HoatCanh;
        private System.Windows.Forms.PictureBox Main_PictureBox;
        private System.Windows.Forms.Panel pn_ground;
        private System.Windows.Forms.PictureBox ptb_DinoBlue;
        private System.Windows.Forms.Timer DanBay;
        private System.Windows.Forms.Timer timer_DinoDiChuyen;
        private System.Windows.Forms.PictureBox ptb_DinoYellow;
        private System.Windows.Forms.Timer timer_Boom;
        private System.Windows.Forms.PictureBox ptb_Boom;
        private System.Windows.Forms.PictureBox ptb_Boom2;
        private System.Windows.Forms.PictureBox ptb_Boom3;
        private System.Windows.Forms.PictureBox ptb_Boom4;
        private System.Windows.Forms.Timer timer_Boss;
        private System.Windows.Forms.Timer timer_ThienThach;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lb_Score;
        private System.Windows.Forms.PictureBox ptb_KingDino;
        private System.Windows.Forms.PictureBox ptb_FlyDraGon;
    }
}

