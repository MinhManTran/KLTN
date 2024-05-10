using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;
using DTO;
using GUI;
using QLNhânSự;

namespace GUI
{
    public partial class frmQmk : Form
    {
        Taikhoan taikhoan = new Taikhoan();
        TaikhoanBLL TkBLL = new TaikhoanBLL();
        public frmQmk()
        {
            InitializeComponent();
        }

        private void btnLaylaimk_Click(object sender, EventArgs e)
        {
            taikhoan.TenTK = txtTaikhoan.Text;
            taikhoan.Email = txtEmail.Text;
            string getMK = TkBLL.CheckMK(taikhoan);
            switch (getMK)
            {
                // kết quả nếu nghiệp vụ sai
                case "Taikhoan_Empty":
                    MessageBox.Show("Chưa nhập thông tin tài khoản", "Thông báo");
                    txtTaikhoan.Focus();
                    return;

                case "Email_Empty":
                    MessageBox.Show("Chưa nhập thông tin Email", "Thông báo");
                    txtEmail.Focus();
                    return;
                case "Tài khoản hoặc mật khẩu không chính xác!":
                    MessageBox.Show("Tài khoản hoặc mật khẩu không chính xác.", "Thông báo");
                    return;
            }
            lblMk.Text = "Mật khẩu là " + getMK;
        }

        private void btnDangnhaplai_Click(object sender, EventArgs e)
        {
            frmLogin frmLogin = new frmLogin();
            this.Hide();
            frmLogin.ShowDialog();
        }
    }
}
