﻿namespace MidTerm
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
            this.timer_Nhanvatchay = new System.Windows.Forms.Timer(this.components);
            this.DanBay = new System.Windows.Forms.Timer(this.components);
            this.timer_DinoDiChuyen = new System.Windows.Forms.Timer(this.components);
            this.ptb_DinoYellow = new System.Windows.Forms.PictureBox();
            this.ptb_DinoBlue = new System.Windows.Forms.PictureBox();
            this.pn_ground = new System.Windows.Forms.Panel();
            this.Main_PictureBox = new System.Windows.Forms.PictureBox();
            this.timer_Boom = new System.Windows.Forms.Timer(this.components);
            this.ptb_Boom = new System.Windows.Forms.PictureBox();
            this.ptb_Boom2 = new System.Windows.Forms.PictureBox();
            this.ptb_Boom3 = new System.Windows.Forms.PictureBox();
            this.ptb_Boom4 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.ptb_DinoYellow)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptb_DinoBlue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Main_PictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptb_Boom)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptb_Boom2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptb_Boom3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptb_Boom4)).BeginInit();
            this.SuspendLayout();
            // 
            // timer1_NhanVatNhay
            // 
            this.timer1_NhanVatNhay.Interval = 20;
            this.timer1_NhanVatNhay.Tick += new System.EventHandler(this.timer1_NhanVatNhay_Tick);
            // 
            // timer_HoatCanh
            // 
            this.timer_HoatCanh.Interval = 20;
            this.timer_HoatCanh.Tick += new System.EventHandler(this.timer_HoatCanh_Tick);
            // 
            // timer_Nhanvatchay
            // 
            this.timer_Nhanvatchay.Interval = 200;
            this.timer_Nhanvatchay.Tick += new System.EventHandler(this.timer_Nhanvatchay_Tick);
            // 
            // DanBay
            // 
            this.DanBay.Interval = 1;
            this.DanBay.Tick += new System.EventHandler(this.DanBay_Tick);
            // 
            // timer_DinoDiChuyen
            // 
            this.timer_DinoDiChuyen.Interval = 40;
            this.timer_DinoDiChuyen.Tick += new System.EventHandler(this.timer_DinoDiChuyen_Tick);
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
            this.Main_PictureBox.Location = new System.Drawing.Point(0, 23);
            this.Main_PictureBox.Name = "Main_PictureBox";
            this.Main_PictureBox.Size = new System.Drawing.Size(1602, 615);
            this.Main_PictureBox.TabIndex = 0;
            this.Main_PictureBox.TabStop = false;
            // 
            // timer_Boom
            // 
            this.timer_Boom.Tick += new System.EventHandler(this.timer_Boom_Tick);
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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1604, 713);
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
            ((System.ComponentModel.ISupportInitialize)(this.ptb_DinoYellow)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptb_DinoBlue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Main_PictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptb_Boom)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptb_Boom2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptb_Boom3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptb_Boom4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Timer timer1_NhanVatNhay;
        private System.Windows.Forms.Timer timer_HoatCanh;
        private System.Windows.Forms.PictureBox Main_PictureBox;
        private System.Windows.Forms.Panel pn_ground;
        private System.Windows.Forms.Timer timer_Nhanvatchay;
        private System.Windows.Forms.PictureBox ptb_DinoBlue;
        private System.Windows.Forms.Timer DanBay;
        private System.Windows.Forms.Timer timer_DinoDiChuyen;
        private System.Windows.Forms.PictureBox ptb_DinoYellow;
        private System.Windows.Forms.Timer timer_Boom;
        private System.Windows.Forms.PictureBox ptb_Boom;
        private System.Windows.Forms.PictureBox ptb_Boom2;
        private System.Windows.Forms.PictureBox ptb_Boom3;
        private System.Windows.Forms.PictureBox ptb_Boom4;
    }
}

