using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DatVeTau
{
    public partial class frmXacNhan : Form
    {
        public frmXacNhan()
        {
            InitializeComponent();
        }

        private void frmXacNhan_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmThongTin frm = new frmThongTin();
            frm.ShowDialog();
        }

        private void btnTiepTheo_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmThanhCong frm = new frmThanhCong();
            frm.ShowDialog();
        }
    }
}
