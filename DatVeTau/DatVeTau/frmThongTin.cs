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
    public partial class frmThongTin : Form
    {
        public frmThongTin()
        {
            InitializeComponent();
        }

        private void frmThongTin_Load(object sender, EventArgs e)
        {

        }

        private void btnTiepTheo_Click(object sender, EventArgs e)
        {
            frmXacNhan frm = new frmXacNhan();
            this.Hide();
            frm.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            frmChonCho frm = new frmChonCho();
            this.Hide();
            frm.ShowDialog();
        }

        private void txtVCMND1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
                
            }
            
        }

        private void txtVCMND1_TextChanged(object sender, EventArgs e)
        {
            txtDVCMND.Text = txtVCMND1.Text;
        }

        private void txtVTen1_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Back || e.KeyChar == (char)Keys.Space);
        }

        private void txtVTen1_TextChanged(object sender, EventArgs e)
        {
            txtDVTen.Text = txtVTen1.Text;
        }
    }
}
