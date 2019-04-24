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
            rdb3.Checked = true;

        }

        private void frmThongTin_Load(object sender, EventArgs e)
        {

        }

        private void btnTiepTheo_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtVTen1.Text))
            {
                MessageBox.Show("Chưa nhập Họ và tên vé 1");
                txtVTen1.Focus();
                return;
            }

            int cboIndex = cbVDT1.SelectedIndex;
            if (cboIndex==-1)
            {
                MessageBox.Show("Chưa đối tượng cho vé 1");
                cbVDT1.Focus();
                return;
            }

            if (String.IsNullOrEmpty(txtVCMND1.Text))
            {
                MessageBox.Show("Chưa nhập số CMND vé 1");
                txtVCMND1.Focus();
                return;
            }

            if (String.IsNullOrEmpty(txtVTen2.Text))
            {
                MessageBox.Show("Chưa nhập Họ và tên vé 2");
                txtVTen2.Focus();
                return;
            }

            cboIndex = cbVDT2.SelectedIndex;
            if (cboIndex == -1)
            {
                MessageBox.Show("Chưa đối tượng cho vé 2");
                cbVDT2.Focus();
                return;
            }

            if (String.IsNullOrEmpty(txtVCMND2.Text))
            {
                MessageBox.Show("Chưa nhập số CMND vé 2");
                txtVCMND2.Focus();
                return;
            }
            if (String.IsNullOrEmpty(txtDVTen.Text))
            {
                MessageBox.Show("Chưa nhập Họ và tên người đặt vé");
                txtDVTen.Focus();
                return;
            }

            if (String.IsNullOrEmpty(txtDVCMND.Text))
            {
                MessageBox.Show("Chưa nhập số CMND người đặt vé");
                txtDVCMND.Focus();
                return;
            }

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

        private void txtVCMND2_KeyPress(object sender, KeyPressEventArgs e)
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
        private void txtVTen2_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Back || e.KeyChar == (char)Keys.Space);
        }

        private void txtVTen1_TextChanged(object sender, EventArgs e)
        {
            txtDVTen.Text = txtVTen1.Text;
        }
    }
}
