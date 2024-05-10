using BLL;
using DTO;
using GUI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Mail;
using System.Security.Cryptography;


namespace QLNhânSự
{
    public partial class frmLogin : Form
    {
        Taikhoan taikhoan = new Taikhoan();
        TaikhoanBLL TkBLL = new TaikhoanBLL();
        
        static string LoaiTK;
        
        public frmLogin()
        {
            InitializeComponent();
            lblTrangthai.Text = "";
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            taikhoan.TenTK = txtTaikhoan.Text;
            taikhoan.Matkhau = txtMatkhau.Text;
            LoaiTK = TkBLL.GetLoaiTK(taikhoan);
            string getuser = TkBLL.CheckLogin(taikhoan);


            switch (getuser)
            {
                // kết quả nếu nghiệp vụ sai
                case "Taikhoan_Empty":
                    MessageBox.Show("Chưa nhập thông tin tài khoản", "Thông báo");
                    txtTaikhoan.Focus();
                    return;

                case "Matkhau_Empty":
                    MessageBox.Show("Chưa nhập thông tin mật khẩu", "Thông báo");
                    txtMatkhau.Focus();
                    return;
                case "Tài khoản hoặc mật khẩu không chính xác!":
                    lblTrangthai.Text = "Tài khoản hoặc mật khẩu không chính xác.";
                    return;
            }
           
                
                    frmMain frmMain = new frmMain(LoaiTK);
                    this.Hide();
                    frmMain.Show();
                    
              
            
        }

        

        private void btnQmk_Click(object sender, EventArgs e)
        {
            frmQmk frmQmk = new frmQmk();
            this.Hide(); frmQmk.Show();
        }
    }
}