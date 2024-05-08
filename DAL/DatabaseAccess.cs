using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using DTO;

namespace DAL
{
    public class SqlConnectionData
    {
        // Tạo chuỗi kết nối csdl

        public static SqlConnection Connect()
        {
            string strcon = @"Data Source=21AK22-COM\MAYAO;Initial Catalog=QLNS;Integrated Security=True";
            SqlConnection conn = new SqlConnection(strcon);
            return conn;
        }
    }
    public class DatabaseAccess
    {
        public static string CheckLoginDTO(Taikhoan taikhoan)
        {
            string user = null;
            // Hàm connect toiws CSDL
            SqlConnection conn = SqlConnectionData.Connect();
            conn.Open();
            SqlCommand command = new SqlCommand("proc_login", conn);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddWithValue("@user", taikhoan.TenTK);
            command.Parameters.AddWithValue("@pass", taikhoan.Matkhau);
            //command.Parameters.AddWithValue("@LoaiTK", taikhoan.LoaiTK);

            command.Connection = conn;
            SqlDataReader reader = command.ExecuteReader();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    user = reader.GetString(0);
                    return user;
                }
                reader.Close();
                conn.Close();
            }
            else
            {
                return "Tài khoản hoặc mật khẩu không chính xác!";
            }
            return user;
        }

        public static string GetLoaiTKDTO(Taikhoan taikhoan)
        {
            string LoaiTK = null;
            // Hàm connect toiws CSDL
            SqlConnection conn = SqlConnectionData.Connect();
            conn.Open();
            SqlCommand command = new SqlCommand("proc_LoaiTK", conn);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddWithValue("@user", taikhoan.TenTK);
            command.Parameters.AddWithValue("@pass", taikhoan.Matkhau);
            //command.Parameters.AddWithValue("@LoaiTK", taikhoan.LoaiTK);

            command.Connection = conn;
            SqlDataReader reader = command.ExecuteReader();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    LoaiTK = reader.GetString(0);
                    return LoaiTK;
                }
                reader.Close();
                conn.Close();
            }
            else
            {
                return "Lỗi";
            }
            return LoaiTK;
        }

        public static string GetEmailDTO(Taikhoan taikhoan)
        {
            string Email = null;
            // Hàm connect toiws CSDL
            SqlConnection conn = SqlConnectionData.Connect();
            conn.Open();
            SqlCommand command = new SqlCommand("proc_Email", conn);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddWithValue("@user", taikhoan.TenTK);
            //command.Parameters.AddWithValue("@pass", taikhoan.Matkhau);
            //command.Parameters.AddWithValue("@LoaiTK", taikhoan.LoaiTK);

            command.Connection = conn;
            SqlDataReader reader = command.ExecuteReader();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    Email = reader.GetString(0);
                    return Email;
                }
                reader.Close();
                conn.Close();
            }
            else
            {
                return "Lỗi";
            }
            return Email;
        }
    }
}
