namespace SimplePaint
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pn = new System.Windows.Forms.Panel();
            this.Main_PictureBox = new System.Windows.Forms.PictureBox();
            this.btn_duongthang = new System.Windows.Forms.Button();
            this.btn_HCN = new System.Windows.Forms.Button();
            this.btn_elip = new System.Windows.Forms.Button();
            this.nmr = new System.Windows.Forms.NumericUpDown();
            this.Move = new System.Windows.Forms.Button();
            this.btn_duongcong = new System.Windows.Forms.Button();
            this.Chon = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btnDagiac = new System.Windows.Forms.Button();
            this.btn_Fill = new System.Windows.Forms.Button();
            this.btn_color = new System.Windows.Forms.Button();
            this.btn_zoom = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Main_PictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmr)).BeginInit();
            this.SuspendLayout();
            // 
            // pn
            // 
            this.pn.Location = new System.Drawing.Point(210, 34);
            this.pn.Name = "pn";
            this.pn.Size = new System.Drawing.Size(1126, 583);
            this.pn.TabIndex = 0;
            // 
            // Main_PictureBox
            // 
            this.Main_PictureBox.BackColor = System.Drawing.Color.White;
            this.Main_PictureBox.Location = new System.Drawing.Point(224, 34);
            this.Main_PictureBox.Name = "Main_PictureBox";
            this.Main_PictureBox.Size = new System.Drawing.Size(1103, 605);
            this.Main_PictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Main_PictureBox.TabIndex = 10;
            this.Main_PictureBox.TabStop = false;
            this.Main_PictureBox.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Main_PictureBox_MouseClick);
            this.Main_PictureBox.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Main_PictureBox_MouseDown);
            this.Main_PictureBox.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Main_PictureBox_MouseMove);
            this.Main_PictureBox.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Main_PictureBox_MouseUp);
            // 
            // btn_duongthang
            // 
            this.btn_duongthang.Location = new System.Drawing.Point(29, 13);
            this.btn_duongthang.Name = "btn_duongthang";
            this.btn_duongthang.Size = new System.Drawing.Size(134, 20);
            this.btn_duongthang.TabIndex = 0;
            this.btn_duongthang.Text = "Đường thẳng";
            this.btn_duongthang.UseVisualStyleBackColor = true;
            this.btn_duongthang.Click += new System.EventHandler(this.btn_duongthang_Click);
            // 
            // btn_HCN
            // 
            this.btn_HCN.Location = new System.Drawing.Point(29, 48);
            this.btn_HCN.Name = "btn_HCN";
            this.btn_HCN.Size = new System.Drawing.Size(134, 20);
            this.btn_HCN.TabIndex = 1;
            this.btn_HCN.Text = "HÌnh chữ Nhật";
            this.btn_HCN.UseVisualStyleBackColor = true;
            this.btn_HCN.Click += new System.EventHandler(this.btn_HCN_Click);
            // 
            // btn_elip
            // 
            this.btn_elip.Location = new System.Drawing.Point(29, 84);
            this.btn_elip.Name = "btn_elip";
            this.btn_elip.Size = new System.Drawing.Size(134, 20);
            this.btn_elip.TabIndex = 2;
            this.btn_elip.Text = "Elip";
            this.btn_elip.UseVisualStyleBackColor = true;
            this.btn_elip.Click += new System.EventHandler(this.btn_elip_Click);
            // 
            // nmr
            // 
            this.nmr.Location = new System.Drawing.Point(29, 330);
            this.nmr.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.nmr.Name = "nmr";
            this.nmr.Size = new System.Drawing.Size(120, 20);
            this.nmr.TabIndex = 3;
            this.nmr.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // Move
            // 
            this.Move.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Move.Location = new System.Drawing.Point(29, 215);
            this.Move.Name = "Move";
            this.Move.Size = new System.Drawing.Size(134, 46);
            this.Move.TabIndex = 4;
            this.Move.Text = "Di chuyển";
            this.Move.UseVisualStyleBackColor = true;
            this.Move.Click += new System.EventHandler(this.Move_Click);
            // 
            // btn_duongcong
            // 
            this.btn_duongcong.Location = new System.Drawing.Point(29, 125);
            this.btn_duongcong.Name = "btn_duongcong";
            this.btn_duongcong.Size = new System.Drawing.Size(134, 37);
            this.btn_duongcong.TabIndex = 5;
            this.btn_duongcong.Text = "Đường Cong";
            this.btn_duongcong.UseVisualStyleBackColor = true;
            this.btn_duongcong.Click += new System.EventHandler(this.btn_duongcong_Click);
            // 
            // Chon
            // 
            this.Chon.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Chon.Location = new System.Drawing.Point(29, 267);
            this.Chon.Name = "Chon";
            this.Chon.Size = new System.Drawing.Size(107, 46);
            this.Chon.TabIndex = 6;
            this.Chon.Text = "Chọn";
            this.Chon.UseVisualStyleBackColor = true;
            this.Chon.Click += new System.EventHandler(this.Chon_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(29, 376);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(107, 46);
            this.button1.TabIndex = 7;
            this.button1.Text = "xóa";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnDagiac
            // 
            this.btnDagiac.Location = new System.Drawing.Point(29, 177);
            this.btnDagiac.Name = "btnDagiac";
            this.btnDagiac.Size = new System.Drawing.Size(134, 20);
            this.btnDagiac.TabIndex = 8;
            this.btnDagiac.Text = "Hình đa giác";
            this.btnDagiac.UseVisualStyleBackColor = true;
            this.btnDagiac.Click += new System.EventHandler(this.btnDagiac_Click);
            // 
            // btn_Fill
            // 
            this.btn_Fill.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Fill.Location = new System.Drawing.Point(29, 428);
            this.btn_Fill.Name = "btn_Fill";
            this.btn_Fill.Size = new System.Drawing.Size(107, 46);
            this.btn_Fill.TabIndex = 11;
            this.btn_Fill.Text = "Fill";
            this.btn_Fill.UseVisualStyleBackColor = true;
            this.btn_Fill.Click += new System.EventHandler(this.btn_Fill_Click);
            // 
            // btn_color
            // 
            this.btn_color.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_color.Location = new System.Drawing.Point(29, 480);
            this.btn_color.Name = "btn_color";
            this.btn_color.Size = new System.Drawing.Size(107, 46);
            this.btn_color.TabIndex = 12;
            this.btn_color.Text = "Color";
            this.btn_color.UseVisualStyleBackColor = true;
            this.btn_color.Click += new System.EventHandler(this.btn_color_Click_1);
            // 
            // btn_zoom
            // 
            this.btn_zoom.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_zoom.Image = ((System.Drawing.Image)(resources.GetObject("btn_zoom.Image")));
            this.btn_zoom.Location = new System.Drawing.Point(44, 532);
            this.btn_zoom.Name = "btn_zoom";
            this.btn_zoom.Size = new System.Drawing.Size(71, 72);
            this.btn_zoom.TabIndex = 13;
            this.btn_zoom.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1339, 651);
            this.Controls.Add(this.btn_zoom);
            this.Controls.Add(this.btn_color);
            this.Controls.Add(this.btn_Fill);
            this.Controls.Add(this.Main_PictureBox);
            this.Controls.Add(this.btnDagiac);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Chon);
            this.Controls.Add(this.btn_duongcong);
            this.Controls.Add(this.Move);
            this.Controls.Add(this.nmr);
            this.Controls.Add(this.btn_elip);
            this.Controls.Add(this.btn_HCN);
            this.Controls.Add(this.btn_duongthang);
            this.Controls.Add(this.pn);
            this.KeyPreview = true;
            this.Name = "Form1";
            this.Text = "Form1";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.Main_PictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmr)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pn;
        private System.Windows.Forms.Button btn_duongthang;
        private System.Windows.Forms.Button btn_HCN;
        private System.Windows.Forms.Button btn_elip;
        private System.Windows.Forms.NumericUpDown nmr;
        private System.Windows.Forms.PictureBox Main_PictureBox;
        private System.Windows.Forms.Button Move;
        private System.Windows.Forms.Button btn_duongcong;
        private System.Windows.Forms.Button Chon;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnDagiac;
        private System.Windows.Forms.Button btn_Fill;
        private System.Windows.Forms.Button btn_color;
        private System.Windows.Forms.Button btn_zoom;
    }
}

