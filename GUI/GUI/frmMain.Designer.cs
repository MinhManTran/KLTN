namespace QLNhânSự
{
    partial class frmMain
    {
        public frmMain(String LoaiTK)
        {
            InitializeComponent();
            if(LoaiTK == "1")
            {
                //Principal
                mnuPheduyet.Enabled = true;
                mnuDanhsach.Enabled = true;
                mnuDieudong.Enabled = false;
                mnuThuyenchuyen.Enabled = false;
                mnuKiemnhiem.Enabled = false;
                mnuBietphai.Enabled = false;
                mnuDaotao.Enabled = false;
                mnuCudihoc.Enabled = false;
                mnuKhenthuong.Enabled = false;
                mnuBHXH.Enabled = false;
                mnuBienche.Enabled = false;
            }
            if (LoaiTK == "2")
            {
                //HR
                mnuDanhsach.Enabled = true;
                mnuDieudong.Enabled = true;
                mnuThuyenchuyen.Enabled = true;
                mnuKiemnhiem.Enabled = true;
                mnuBietphai.Enabled = true;
                mnuDaotao.Enabled = true;
                mnuCudihoc.Enabled = true;
                mnuKhenthuong.Enabled = true;
                mnuBHXH.Enabled = true;
                mnuBienche.Enabled = true;
                mnuPheduyet.Enabled = false;
                
                
            }
            if (LoaiTK == "3")
            {
                //Lecturers
                mnuDanhsach.Enabled = true;
                mnuDieudong.Enabled = false;
                mnuThuyenchuyen.Enabled = false;
                mnuKiemnhiem.Enabled = false;
                mnuBietphai.Enabled = false;
                mnuDaotao.Enabled = false;
                mnuCudihoc.Enabled = false;
                mnuKhenthuong.Enabled = false;
                mnuBHXH.Enabled = false;
                mnuBienche.Enabled = false;
                mnuPheduyet.Enabled = false;
            }
        }
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            menuStrip1 = new MenuStrip();
            mnuDanhsach = new ToolStripMenuItem();
            mnuDieudong = new ToolStripMenuItem();
            mnuThuyenchuyen = new ToolStripMenuItem();
            mnuKiemnhiem = new ToolStripMenuItem();
            mnuBietphai = new ToolStripMenuItem();
            mnuDaotao = new ToolStripMenuItem();
            mnuCudihoc = new ToolStripMenuItem();
            mnuKhenthuong = new ToolStripMenuItem();
            mnuBHXH = new ToolStripMenuItem();
            mnuBienche = new ToolStripMenuItem();
            mnuPheduyet = new ToolStripMenuItem();
            lblDangxuat = new LinkLabel();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { mnuDanhsach, mnuDieudong, mnuThuyenchuyen, mnuKiemnhiem, mnuBietphai, mnuDaotao, mnuCudihoc, mnuKhenthuong, mnuBHXH, mnuBienche, mnuPheduyet });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1266, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // mnuDanhsach
            // 
            mnuDanhsach.BackColor = Color.Lavender;
            mnuDanhsach.Name = "mnuDanhsach";
            mnuDanhsach.Size = new Size(132, 20);
            mnuDanhsach.Text = "Danh sách giảng viên";
            mnuDanhsach.Click += mnuDanhsach_Click;
            // 
            // mnuDieudong
            // 
            mnuDieudong.BackColor = Color.Lavender;
            mnuDieudong.Name = "mnuDieudong";
            mnuDieudong.Size = new Size(74, 20);
            mnuDieudong.Text = "Điều động";
            // 
            // mnuThuyenchuyen
            // 
            mnuThuyenchuyen.BackColor = Color.Lavender;
            mnuThuyenchuyen.Name = "mnuThuyenchuyen";
            mnuThuyenchuyen.Size = new Size(100, 20);
            mnuThuyenchuyen.Text = "Thuyên chuyển";
            // 
            // mnuKiemnhiem
            // 
            mnuKiemnhiem.BackColor = Color.Lavender;
            mnuKiemnhiem.Name = "mnuKiemnhiem";
            mnuKiemnhiem.Size = new Size(83, 20);
            mnuKiemnhiem.Text = "Kiêm nhiệm";
            // 
            // mnuBietphai
            // 
            mnuBietphai.BackColor = Color.Lavender;
            mnuBietphai.Name = "mnuBietphai";
            mnuBietphai.Size = new Size(65, 20);
            mnuBietphai.Text = "Biệt phái";
            mnuBietphai.Click += mnuBietphai_Click;
            // 
            // mnuDaotao
            // 
            mnuDaotao.BackColor = Color.Lavender;
            mnuDaotao.Name = "mnuDaotao";
            mnuDaotao.Size = new Size(118, 20);
            mnuDaotao.Text = "Đào tạo bồi dưỡng";
            // 
            // mnuCudihoc
            // 
            mnuCudihoc.BackColor = Color.Lavender;
            mnuCudihoc.Name = "mnuCudihoc";
            mnuCudihoc.Size = new Size(70, 20);
            mnuCudihoc.Text = "Cử đi học";
            mnuCudihoc.Click += mnuCudihoc_Click;
            // 
            // mnuKhenthuong
            // 
            mnuKhenthuong.BackColor = Color.Lavender;
            mnuKhenthuong.Name = "mnuKhenthuong";
            mnuKhenthuong.Size = new Size(135, 20);
            mnuKhenthuong.Text = "Khen thưởng / Kỷ luật";
            // 
            // mnuBHXH
            // 
            mnuBHXH.BackColor = Color.Lavender;
            mnuBHXH.Name = "mnuBHXH";
            mnuBHXH.Size = new Size(93, 20);
            mnuBHXH.Text = "BHXH / BHTN";
            // 
            // mnuBienche
            // 
            mnuBienche.BackColor = Color.Lavender;
            mnuBienche.Name = "mnuBienche";
            mnuBienche.Size = new Size(119, 20);
            mnuBienche.Text = "Biên chế hợp đồng";
            // 
            // mnuPheduyet
            // 
            mnuPheduyet.BackColor = Color.Lavender;
            mnuPheduyet.Name = "mnuPheduyet";
            mnuPheduyet.Size = new Size(104, 20);
            mnuPheduyet.Text = "Phê duyệt hồ sơ";
            // 
            // lblDangxuat
            // 
            lblDangxuat.AutoSize = true;
            lblDangxuat.Location = new Point(0, 24);
            lblDangxuat.Name = "lblDangxuat";
            lblDangxuat.Size = new Size(61, 15);
            lblDangxuat.TabIndex = 1;
            lblDangxuat.TabStop = true;
            lblDangxuat.Text = "Đăng xuất";
            lblDangxuat.LinkClicked += lblDangxuat_LinkClicked;
            // 
            // frmMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightSkyBlue;
            ClientSize = new Size(1266, 450);
            Controls.Add(lblDangxuat);
            Controls.Add(menuStrip1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MainMenuStrip = menuStrip1;
            Name = "frmMain";
            Text = "Quản Lý Nhân Sự";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }



        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem mnuDanhsach;
        private ToolStripMenuItem mnuDieudong;
        private ToolStripMenuItem mnuThuyenchuyen;
        private ToolStripMenuItem mnuKiemnhiem;
        private ToolStripMenuItem mnuBietphai;
        private ToolStripMenuItem mnuDaotao;
        private ToolStripMenuItem mnuCudihoc;
        private ToolStripMenuItem mnuKhenthuong;
        private ToolStripMenuItem mnuBHXH;
        private ToolStripMenuItem mnuBienche;
        private ToolStripMenuItem mnuPheduyet;
        private LinkLabel lblDangxuat;
    }
}