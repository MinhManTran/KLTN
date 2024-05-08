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
        static string from = "qlnssgu@gmail.com";
        static string pass = "tmm17062002";
        static Random rd = new Random();
        static string LoaiTK;
        static int content;
        static TextBox textBox;
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
            String Email = TkBLL.GetEmail(taikhoan);
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
            SendConfirmationEmail(Email);
            static void SendConfirmationEmail(string toEmail)
            {
                content = rd.Next(1000, 9999);
                string contentString = content.ToString();

                MailMessage mail = new MailMessage();
                mail.To.Add(toEmail);
                mail.From = new MailAddress(from);
                mail.Subject = "Mã xác nhận của bạn là";
                mail.Body = contentString;

                SmtpClient smtp = new SmtpClient("smtp.gmail.com");
                smtp.EnableSsl = true;
                smtp.Port = 587;
                smtp.DeliveryMethod = SmtpDeliveryMethod.Network;
                smtp.Credentials = new NetworkCredential(from, pass);
                smtp.Send(mail);

                // Tạo một Form với TextBox và Button
                var messageBox = new Form();
                textBox = new TextBox();
                var button = new Button();

                // Cấu hình TextBox và Button
                textBox.Location = new System.Drawing.Point(10, 10);
                textBox.Size = new System.Drawing.Size(200, 20);

                button.Text = "OK";
                button.Location = new System.Drawing.Point(10, 40);
                button.Click += Button_Click;

                // Thêm TextBox và Button vào Form
                messageBox.Controls.Add(textBox);
                messageBox.Controls.Add(button);

                // Hiển thị Form
                
                messageBox.ShowDialog();
            }

            static void Button_Click(object sender, EventArgs e)
            {
                string userInput = textBox.Text;
                if (userInput == content.ToString())
                {
                    frmMain frmMain = new frmMain(LoaiTK);
                    frmMain.Show();
                }
                else
                {
                    MessageBox.Show("Mã xác nhận không đúng", "THÔNG BÁO");
                }
            }
            // MessageBox.Show("Xin chúc mừng bạn đã đăng nhập thành công", "Thông báo");
            /*string from, to, pass;
            from = "qlnssgu@gmail.com";
            to = Email;
            pass = "tmm17062002";
            Random rd = new Random();
            int content = rd.Next(1000,9999);
            string contentString = content.ToString();
            
            MailMessage mail = new MailMessage();
            mail.To.Add(to);
            mail.From = new MailAddress(from);
            mail.Subject = "Mã xác nhận của bạn là";
            mail.Body = contentString;

            SmtpClient smtp = new SmtpClient("smtp.gmail.com");
            smtp.EnableSsl = true;
            smtp.Port = 587;
            smtp.DeliveryMethod = SmtpDeliveryMethod.Network;
            smtp.Credentials = new NetworkCredential(from, pass);
            smtp.Send(mail);
            // Tạo một Message Box với một TextBox
            var messageBox = new Form();
            var textBox = new TextBox();
            var button = new Button();

            // Cấu hình TextBox
            textBox.Location = new System.Drawing.Point(10, 10);
            textBox.Size = new System.Drawing.Size(200, 20);

            // Cấu hình Button
            button.Text = "OK";
            button.Location = new System.Drawing.Point(10, 40);
            button.Click += (sender, e) => messageBox.Close();

            // Thêm TextBox và Button vào Message Box
            messageBox.Controls.Add(textBox);
            messageBox.Controls.Add(button);

            // Hiển thị Message Box
            messageBox.ShowDialog();
            
            // Lấy giá trị từ TextBox sau khi Message Box đã đóng
            string userInput = textBox.Text;
            if(userInput == contentString)
            {
                frmMain frmMain = new frmMain(LoaiTK);
                frmMain.Show();
                this.Hide();
            }
            MessageBox.Show("Mã xác nhận không đúng", "THÔNG BÁO");*/
            
        }

        

        private void btnQmk_Click(object sender, EventArgs e)
        {

        }
    }
}