namespace QLNhânSự
{
    partial class frmDanhsach
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
            label1 = new Label();
            dtgMain = new DataGridView();
            label2 = new Label();
            txtMagv = new TextBox();
            label3 = new Label();
            txtHoten = new TextBox();
            label4 = new Label();
            txtMangach = new TextBox();
            label5 = new Label();
            txtSdt = new TextBox();
            label6 = new Label();
            txtEmail = new TextBox();
            label7 = new Label();
            txtQue = new TextBox();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            label11 = new Label();
            label12 = new Label();
            label13 = new Label();
            txtHamhoc = new TextBox();
            txtNgachvc = new TextBox();
            txtChucvucq = new TextBox();
            txtChuyennganh = new TextBox();
            txtChucvukn = new TextBox();
            txtChucvudang = new TextBox();
            label14 = new Label();
            textBox13 = new TextBox();
            button1 = new Button();
            btnThem = new Button();
            btnSua = new Button();
            btnXoa = new Button();
            btnLuu = new Button();
            btnThoat = new Button();
            btnBack = new Button();
            ((System.ComponentModel.ISupportInitialize)dtgMain).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 15.75F, FontStyle.Bold);
            label1.Location = new Point(445, 9);
            label1.Name = "label1";
            label1.Size = new Size(199, 24);
            label1.TabIndex = 0;
            label1.Text = "Danh sách giảng viên";
            // 
            // dtgMain
            // 
            dtgMain.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgMain.Location = new Point(30, 139);
            dtgMain.Name = "dtgMain";
            dtgMain.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dtgMain.Size = new Size(496, 434);
            dtgMain.TabIndex = 1;
            dtgMain.CellClick += dtgMain_CellClick;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 12F);
            label2.Location = new Point(562, 139);
            label2.Name = "label2";
            label2.Size = new Size(93, 19);
            label2.TabIndex = 2;
            label2.Text = "Mã giảng viên";
            // 
            // txtMagv
            // 
            txtMagv.Location = new Point(661, 135);
            txtMagv.Name = "txtMagv";
            txtMagv.Size = new Size(120, 23);
            txtMagv.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 12F);
            label3.Location = new Point(562, 194);
            label3.Name = "label3";
            label3.Size = new Size(68, 19);
            label3.TabIndex = 4;
            label3.Text = "Họ và tên";
            // 
            // txtHoten
            // 
            txtHoten.Location = new Point(661, 190);
            txtHoten.Name = "txtHoten";
            txtHoten.Size = new Size(120, 23);
            txtHoten.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Times New Roman", 12F);
            label4.Location = new Point(561, 251);
            label4.Name = "label4";
            label4.Size = new Size(69, 19);
            label4.TabIndex = 6;
            label4.Text = "Mã ngạch";
            // 
            // txtMangach
            // 
            txtMangach.Location = new Point(661, 247);
            txtMangach.Name = "txtMangach";
            txtMangach.Size = new Size(120, 23);
            txtMangach.TabIndex = 7;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Times New Roman", 12F);
            label5.Location = new Point(562, 305);
            label5.Name = "label5";
            label5.Size = new Size(88, 19);
            label5.TabIndex = 8;
            label5.Text = "Số điện thoại";
            // 
            // txtSdt
            // 
            txtSdt.Location = new Point(661, 301);
            txtSdt.Name = "txtSdt";
            txtSdt.Size = new Size(120, 23);
            txtSdt.TabIndex = 9;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Times New Roman", 12F);
            label6.Location = new Point(562, 357);
            label6.Name = "label6";
            label6.Size = new Size(42, 19);
            label6.TabIndex = 10;
            label6.Text = "Email";
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(661, 353);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(120, 23);
            txtEmail.TabIndex = 11;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Times New Roman", 12F);
            label7.Location = new Point(562, 408);
            label7.Name = "label7";
            label7.Size = new Size(68, 19);
            label7.TabIndex = 12;
            label7.Text = "Quê quán";
            // 
            // txtQue
            // 
            txtQue.Location = new Point(661, 404);
            txtQue.Name = "txtQue";
            txtQue.Size = new Size(120, 23);
            txtQue.TabIndex = 13;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Times New Roman", 12F);
            label8.Location = new Point(818, 139);
            label8.Name = "label8";
            label8.Size = new Size(78, 19);
            label8.TabIndex = 14;
            label8.Text = "Hàm học vị";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Times New Roman", 12F);
            label9.Location = new Point(818, 194);
            label9.Name = "label9";
            label9.Size = new Size(111, 19);
            label9.TabIndex = 15;
            label9.Text = "Ngạch viên chức";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Times New Roman", 12F);
            label10.Location = new Point(818, 251);
            label10.Name = "label10";
            label10.Size = new Size(113, 19);
            label10.TabIndex = 16;
            label10.Text = "Chức vụ cơ quan";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Times New Roman", 12F);
            label11.Location = new Point(818, 357);
            label11.Name = "label11";
            label11.Size = new Size(133, 19);
            label11.TabIndex = 17;
            label11.Text = "Chức vụ kiêm nhiệm";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Times New Roman", 12F);
            label12.Location = new Point(818, 305);
            label12.Name = "label12";
            label12.Size = new Size(94, 19);
            label12.TabIndex = 18;
            label12.Text = "Chuyên ngành";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Times New Roman", 12F);
            label13.Location = new Point(818, 408);
            label13.Name = "label13";
            label13.Size = new Size(97, 19);
            label13.TabIndex = 19;
            label13.Text = "Chức vụ Đảng";
            // 
            // txtHamhoc
            // 
            txtHamhoc.Location = new Point(955, 135);
            txtHamhoc.Name = "txtHamhoc";
            txtHamhoc.Size = new Size(120, 23);
            txtHamhoc.TabIndex = 20;
            // 
            // txtNgachvc
            // 
            txtNgachvc.Location = new Point(955, 190);
            txtNgachvc.Name = "txtNgachvc";
            txtNgachvc.Size = new Size(120, 23);
            txtNgachvc.TabIndex = 21;
            // 
            // txtChucvucq
            // 
            txtChucvucq.Location = new Point(955, 247);
            txtChucvucq.Name = "txtChucvucq";
            txtChucvucq.Size = new Size(120, 23);
            txtChucvucq.TabIndex = 22;
            // 
            // txtChuyennganh
            // 
            txtChuyennganh.Location = new Point(955, 305);
            txtChuyennganh.Name = "txtChuyennganh";
            txtChuyennganh.Size = new Size(120, 23);
            txtChuyennganh.TabIndex = 23;
            // 
            // txtChucvukn
            // 
            txtChucvukn.Location = new Point(955, 353);
            txtChucvukn.Name = "txtChucvukn";
            txtChucvukn.Size = new Size(120, 23);
            txtChucvukn.TabIndex = 24;
            // 
            // txtChucvudang
            // 
            txtChucvudang.Location = new Point(955, 404);
            txtChucvudang.Name = "txtChucvudang";
            txtChucvudang.Size = new Size(120, 23);
            txtChucvudang.TabIndex = 25;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Times New Roman", 12F);
            label14.Location = new Point(30, 102);
            label14.Name = "label14";
            label14.Size = new Size(65, 19);
            label14.TabIndex = 26;
            label14.Text = "Tìm kiếm";
            // 
            // textBox13
            // 
            textBox13.Location = new Point(101, 98);
            textBox13.Name = "textBox13";
            textBox13.Size = new Size(237, 23);
            textBox13.TabIndex = 27;
            // 
            // button1
            // 
            button1.BackColor = Color.Tan;
            button1.Location = new Point(353, 97);
            button1.Name = "button1";
            button1.Size = new Size(88, 24);
            button1.TabIndex = 28;
            button1.Text = "Tìm";
            button1.UseVisualStyleBackColor = false;
            // 
            // btnThem
            // 
            btnThem.BackColor = Color.Tan;
            btnThem.Location = new Point(567, 461);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(88, 24);
            btnThem.TabIndex = 29;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = false;
            btnThem.Click += btnThem_Click;
            // 
            // btnSua
            // 
            btnSua.BackColor = Color.Tan;
            btnSua.Location = new Point(675, 461);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(88, 24);
            btnSua.TabIndex = 30;
            btnSua.Text = "Sửa";
            btnSua.UseVisualStyleBackColor = false;
            btnSua.Click += btnSua_Click;
            // 
            // btnXoa
            // 
            btnXoa.BackColor = Color.Tan;
            btnXoa.Location = new Point(788, 461);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(88, 24);
            btnXoa.TabIndex = 31;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = false;
            btnXoa.Click += btnXoa_Click;
            // 
            // btnLuu
            // 
            btnLuu.BackColor = Color.Tan;
            btnLuu.Location = new Point(908, 461);
            btnLuu.Name = "btnLuu";
            btnLuu.Size = new Size(88, 24);
            btnLuu.TabIndex = 32;
            btnLuu.Text = "Lưu";
            btnLuu.UseVisualStyleBackColor = false;
            btnLuu.Click += btnLuu_Click;
            // 
            // btnThoat
            // 
            btnThoat.BackColor = Color.Tan;
            btnThoat.Location = new Point(1022, 461);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(88, 24);
            btnThoat.TabIndex = 33;
            btnThoat.Text = "Thoát";
            btnThoat.UseVisualStyleBackColor = false;
            btnThoat.Click += btnThoat_Click;
            // 
            // btnBack
            // 
            btnBack.BackColor = Color.Tan;
            btnBack.Location = new Point(1022, 594);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(88, 24);
            btnBack.TabIndex = 34;
            btnBack.Text = "Quay lại";
            btnBack.UseVisualStyleBackColor = false;
            btnBack.Click += btnBack_Click;
            // 
            // frmDanhsach
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightSkyBlue;
            ClientSize = new Size(1122, 630);
            Controls.Add(btnBack);
            Controls.Add(btnThoat);
            Controls.Add(btnLuu);
            Controls.Add(btnXoa);
            Controls.Add(btnSua);
            Controls.Add(btnThem);
            Controls.Add(button1);
            Controls.Add(textBox13);
            Controls.Add(label14);
            Controls.Add(txtChucvudang);
            Controls.Add(txtChucvukn);
            Controls.Add(txtChuyennganh);
            Controls.Add(txtChucvucq);
            Controls.Add(txtNgachvc);
            Controls.Add(txtHamhoc);
            Controls.Add(label13);
            Controls.Add(label12);
            Controls.Add(label11);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(txtQue);
            Controls.Add(label7);
            Controls.Add(txtEmail);
            Controls.Add(label6);
            Controls.Add(txtSdt);
            Controls.Add(label5);
            Controls.Add(txtMangach);
            Controls.Add(label4);
            Controls.Add(txtHoten);
            Controls.Add(label3);
            Controls.Add(txtMagv);
            Controls.Add(label2);
            Controls.Add(dtgMain);
            Controls.Add(label1);
            Name = "frmDanhsach";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Danh sách giảng viên";
            ((System.ComponentModel.ISupportInitialize)dtgMain).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private DataGridView dtgMain;
        private Label label2;
        private TextBox txtMagv;
        private Label label3;
        private TextBox txtHoten;
        private Label label4;
        private TextBox txtMangach;
        private Label label5;
        private TextBox txtSdt;
        private Label label6;
        private TextBox txtEmail;
        private Label label7;
        private TextBox txtQue;
        private Label label8;
        private Label label9;
        private Label label10;
        private Label label11;
        private Label label12;
        private Label label13;
        private TextBox txtHamhoc;
        private TextBox txtNgachvc;
        private TextBox txtChucvucq;
        private TextBox txtChuyennganh;
        private TextBox txtChucvukn;
        private TextBox txtChucvudang;
        private Label label14;
        private TextBox textBox13;
        private Button button1;
        private Button btnThem;
        private Button btnSua;
        private Button btnXoa;
        private Button btnLuu;
        private Button btnThoat;
        private Button btnBack;
    }
}