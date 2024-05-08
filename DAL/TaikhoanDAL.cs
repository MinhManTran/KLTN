using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace DAL
{
    public class TaikhoanDAL:DatabaseAccess
    {
        public string CheckLogin(Taikhoan taikhoan)
        {
            string info = CheckLoginDTO(taikhoan);
            return info;
        }

        public string GetLoaiTK(Taikhoan taikhoan)
        {
            string info = GetLoaiTKDTO(taikhoan);
            return info;
        }

        public string GetEmail(Taikhoan taikhoan)
        {
            string info = GetEmailDTO(taikhoan);
            return info;
        }
    }
}
