using GUI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLNhânSự
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void mnuDanhsach_Click(object sender, EventArgs e)
        {
            frmDShoso frmDShoso = new frmDShoso();
            frmDShoso.Show();
            this.Hide();
        }

        private void mnuBietphai_Click(object sender, EventArgs e)
        {
            frmBietphai frmBietphai = new frmBietphai();
            frmBietphai.Show();
            this.Hide();
        }

        private void mnuCudihoc_Click(object sender, EventArgs e)
        {
            frmCudihoc frmCudihoc = new frmCudihoc();
            frmCudihoc.Show();
            this.Hide();
        }

        private void lblDangxuat_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmLogin frmLogin = new frmLogin();
            frmLogin.Show();
            this.Close();
        }

        private void mnuLuongthuong_Click(object sender, EventArgs e)
        {
            frmLuongthuongphucap frmLuongthuongphucap = new frmLuongthuongphucap();
            frmLuongthuongphucap.Show();
            this.Close();
        }
    }
}
