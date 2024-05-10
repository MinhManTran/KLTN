using DTO;
using QLNhânSự;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.DirectoryServices.ActiveDirectory;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class frmDShoso : Form
    {
        public List<Hosotomtat> HosotomtatList { get; set; }
        public frmDShoso()
        {
            HosotomtatList = GetHosotomtatList();
            InitializeComponent();
        }

        private List<Hosotomtat> GetHosotomtatList()
        {
            var list = new List<Hosotomtat>();
            list.Add(new Hosotomtat() { Hoten = "Nguyễn Văn Thịnh", Ngaysinh = "13/1/1987", Chucvu = "Giảng viên", Mangach = "223", Sdt = "0703216815", Email = "thinh1@gmail.com" });
            list.Add(new Hosotomtat() { Hoten = "Lê Quốc Mẫn", Ngaysinh = "17/8/1990", Chucvu = "Trưởng khoa", Mangach = "236", Sdt = "0989321473", Email = "man1@gmail.com" });
            list.Add(new Hosotomtat() { Hoten = "Trần Hoàng Minh", Ngaysinh = "6/3/1973", Chucvu = "Kế Toán", Mangach = "245", Sdt = "0775613875", Email = "minh1@gmail.com" });
            return list;
        }

        private void DShoso_Load(object sender, EventArgs e)
        {
            var HosotomtatList = this.HosotomtatList;

            dtgHosott.DataSource = HosotomtatList;
        }

        private void dtgHosott_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            DataGridViewRow selectedRow = dtgHosott.Rows[index];
        }

        private void btnChitiet_Click(object sender, EventArgs e)
        {
            frm_Hosocanhan frm_Hosocanhan = new frm_Hosocanhan();
            this.Hide();
            frm_Hosocanhan.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmMain frmMain = new frmMain();
            this.Hide();
            frmMain.ShowDialog();
        }
    }
}
