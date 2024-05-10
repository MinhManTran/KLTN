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
    public partial class frm_Hosocanhan : Form
    {
        public frm_Hosocanhan()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmDShoso frmDShoso = new frmDShoso();
            this.Close();
            frmDShoso.ShowDialog();
        }
    }
}
