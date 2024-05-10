using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAL;

namespace BLL
{
    public class TaikhoanBLL
    {
        TaikhoanDAL tkDAL = new TaikhoanDAL();
        public string CheckLogin(Taikhoan taikhoan)
        {
            //Kiểm tra nghiệp vụ
            if(taikhoan.TenTK =="")
            {
                return "Taikhoan_Empty";
            }
            if (taikhoan.Matkhau == "")
            {
                return "Matkhau_Empty";
            }
            string info = tkDAL.CheckLogin(taikhoan);
            return info;
        }

        public string GetLoaiTK(Taikhoan taikhoan)
        {
            string info = tkDAL.GetLoaiTK(taikhoan);
            return info;
        }

        

        public string CheckMK(Taikhoan taikhoan)
        {
            //Kiểm tra nghiệp vụ
            if (taikhoan.TenTK == "")
            {
                return "Taikhoan_Empty";
            }
            if (taikhoan.Email == "")
            {
                return "Email_Empty";
            }
            string info = tkDAL.CheckMK(taikhoan);
            return info;
        }
    }
    
}
