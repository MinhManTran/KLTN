namespace GUI
{
    partial class frmQmk
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
            label2 = new Label();
            txtTaikhoan = new TextBox();
            label1 = new Label();
            txtEmail = new TextBox();
            lblMk = new Label();
            btnLaylaimk = new Button();
            btnDangnhaplai = new Button();
            label3 = new Label();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 12F);
            label2.Location = new Point(65, 92);
            label2.Name = "label2";
            label2.Size = new Size(80, 19);
            label2.TabIndex = 3;
            label2.Text = "Tài Khoản :";
            // 
            // txtTaikhoan
            // 
            txtTaikhoan.Location = new Point(165, 88);
            txtTaikhoan.Name = "txtTaikhoan";
            txtTaikhoan.Size = new Size(353, 23);
            txtTaikhoan.TabIndex = 11;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 12F);
            label1.Location = new Point(65, 139);
            label1.Name = "label1";
            label1.Size = new Size(49, 19);
            label1.TabIndex = 12;
            label1.Text = "Email :";
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(165, 135);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(353, 23);
            txtEmail.TabIndex = 13;
            // 
            // lblMk
            // 
            lblMk.AutoSize = true;
            lblMk.Font = new Font("Times New Roman", 12F);
            lblMk.ForeColor = Color.Red;
            lblMk.Location = new Point(12, 243);
            lblMk.Name = "lblMk";
            lblMk.Size = new Size(74, 19);
            lblMk.TabIndex = 14;
            lblMk.Text = "Mật khẩu :";
            // 
            // btnLaylaimk
            // 
            btnLaylaimk.BackColor = Color.CornflowerBlue;
            btnLaylaimk.Location = new Point(286, 177);
            btnLaylaimk.Name = "btnLaylaimk";
            btnLaylaimk.Size = new Size(113, 33);
            btnLaylaimk.TabIndex = 15;
            btnLaylaimk.Text = "Lấy lại mật khẩu";
            btnLaylaimk.UseVisualStyleBackColor = false;
            btnLaylaimk.Click += btnLaylaimk_Click;
            // 
            // btnDangnhaplai
            // 
            btnDangnhaplai.BackColor = Color.CornflowerBlue;
            btnDangnhaplai.Location = new Point(405, 177);
            btnDangnhaplai.Name = "btnDangnhaplai";
            btnDangnhaplai.Size = new Size(113, 33);
            btnDangnhaplai.TabIndex = 16;
            btnDangnhaplai.Text = "Đăng nhập lại";
            btnDangnhaplai.UseVisualStyleBackColor = false;
            btnDangnhaplai.Click += btnDangnhaplai_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(165, 9);
            label3.Name = "label3";
            label3.Size = new Size(204, 31);
            label3.TabIndex = 17;
            label3.Text = "Quên Mật Khẩu";
            // 
            // frmQmk
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightSkyBlue;
            ClientSize = new Size(552, 271);
            Controls.Add(label3);
            Controls.Add(btnDangnhaplai);
            Controls.Add(btnLaylaimk);
            Controls.Add(lblMk);
            Controls.Add(txtEmail);
            Controls.Add(label1);
            Controls.Add(txtTaikhoan);
            Controls.Add(label2);
            Name = "frmQmk";
            Text = "Quên mật khẩu";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label2;
        private TextBox txtTaikhoan;
        private Label label1;
        private TextBox txtEmail;
        private Label lblMk;
        private Button btnLaylaimk;
        private Button btnDangnhaplai;
        private Label label3;
    }
}