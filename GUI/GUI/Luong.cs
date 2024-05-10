using DTO;
using QLNhânSự;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class frmLuongthuongphucap : Form
    {
        public List<Luongthuong> LuongList { get; set; }
        public frmLuongthuongphucap()
        {
            LuongList = GetLuongList();
            InitializeComponent();
        }

        private List<Luongthuong> GetLuongList()
        {
            var list = new List<Luongthuong>();
            list.Add(new Luongthuong() { Hoten = "Nguyễn Văn Thinh", Chucvu = "Giảng viên", Phongban = "Khoa CNTT", Tongheso = "8", PCTNVK = "5%", Ngaynhan = "10/11/2024" });
            list.Add(new Luongthuong() { Hoten = "Lê Quốc Mẫn", Chucvu = "Trưởng khoa", Phongban = "Khoa QTKD", Tongheso = "10", PCTNVK = "5%", Ngaynhan = "23/11/2024" });
            list.Add(new Luongthuong() { Hoten = "Trần Hoàng Minh", Chucvu = "Kế toán", Phongban = "Tài chính", Tongheso = "6", PCTNVK = "5%", Ngaynhan = "12/10/2024" });
            return list;
        }

        private void dtgHosott_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            DataGridViewRow selectedRow = dtgLuong.Rows[index];
        }

        private void frmLuongthuongphucap_Load(object sender, EventArgs e)
        {
            var LuongList = this.LuongList;

            dtgLuong.DataSource = LuongList;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmMain frmMain = new frmMain();
            this.Close();
            frmMain.ShowDialog();
        }

        private void btnChitiet_Click(object sender, EventArgs e)
        {
            frmChitietluong frmChitietluong = new frmChitietluong();
            this.Close();
            frmChitietluong.ShowDialog();
        }
    }
}
