namespace QLNhânSự
{
    partial class frmLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLogin));
            pictureBox1 = new PictureBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            btnLogin = new Button();
            lblTrangthai = new Label();
            label4 = new Label();
            txtTaikhoan = new TextBox();
            txtMatkhau = new TextBox();
            btnQmk = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(271, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(125, 128);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 14.25F, FontStyle.Bold);
            label1.Location = new Point(233, 154);
            label1.Name = "label1";
            label1.Size = new Size(217, 22);
            label1.TabIndex = 1;
            label1.Text = "Hệ thống quản lý nhân sự";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 12F);
            label2.Location = new Point(141, 243);
            label2.Name = "label2";
            label2.Size = new Size(80, 19);
            label2.TabIndex = 2;
            label2.Text = "Tài Khoản :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 12F);
            label3.Location = new Point(141, 297);
            label3.Name = "label3";
            label3.Size = new Size(78, 19);
            label3.TabIndex = 3;
            label3.Text = "Mật Khẩu :";
            // 
            // btnLogin
            // 
            btnLogin.BackColor = Color.CornflowerBlue;
            btnLogin.Location = new Point(236, 338);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(113, 33);
            btnLogin.TabIndex = 6;
            btnLogin.Text = "Đăng nhập";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnLogin_Click;
            // 
            // lblTrangthai
            // 
            lblTrangthai.AutoSize = true;
            lblTrangthai.Font = new Font("Times New Roman", 12F);
            lblTrangthai.ForeColor = Color.IndianRed;
            lblTrangthai.Location = new Point(36, 408);
            lblTrangthai.Name = "lblTrangthai";
            lblTrangthai.Size = new Size(80, 19);
            lblTrangthai.TabIndex = 7;
            lblTrangthai.Text = "Trạng Thái :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Times New Roman", 12F);
            label4.Location = new Point(470, 338);
            label4.Name = "label4";
            label4.Size = new Size(0, 19);
            label4.TabIndex = 9;
            // 
            // txtTaikhoan
            // 
            txtTaikhoan.Location = new Point(236, 239);
            txtTaikhoan.Name = "txtTaikhoan";
            txtTaikhoan.Size = new Size(353, 23);
            txtTaikhoan.TabIndex = 10;
            // 
            // txtMatkhau
            // 
            txtMatkhau.Location = new Point(236, 293);
            txtMatkhau.Name = "txtMatkhau";
            txtMatkhau.Size = new Size(353, 23);
            txtMatkhau.TabIndex = 11;
            txtMatkhau.UseSystemPasswordChar = true;
            // 
            // btnQmk
            // 
            btnQmk.BackColor = Color.CornflowerBlue;
            btnQmk.Location = new Point(476, 338);
            btnQmk.Name = "btnQmk";
            btnQmk.Size = new Size(113, 33);
            btnQmk.TabIndex = 13;
            btnQmk.Text = "Quên mật khẩu";
            btnQmk.UseVisualStyleBackColor = false;
            btnQmk.Click += btnQmk_Click;
            // 
            // frmLogin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Aqua;
            ClientSize = new Size(678, 450);
            Controls.Add(btnQmk);
            Controls.Add(txtMatkhau);
            Controls.Add(txtTaikhoan);
            Controls.Add(label4);
            Controls.Add(lblTrangthai);
            Controls.Add(btnLogin);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Name = "frmLogin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Đăng Nhập";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Button btnLogin;
        private Label lblTrangthai;
        private Label label4;
        private TextBox txtTaikhoan;
        private TextBox txtMatkhau;
        private Button btnQmk;
    }
}