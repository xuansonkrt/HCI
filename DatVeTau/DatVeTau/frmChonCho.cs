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
    public partial class frmChonCho : Form
    {
        public frmChonCho()
        {
            InitializeComponent();
        }

        private void btnTau1_MouseHover(object sender, EventArgs e)
        {
            btnTau1.BackgroundImage = Image.FromFile(@"E:\IT_MTA\Nam 3\Ki_2\Slide_baigiang_TTNM\project\HCI\DatVeTau\DatVeTau\images\select-hover.jpg");
            lbTau1.BackColor = System.Drawing.Color.Orange;
        }

        private void btnTau1_MouseLeave(object sender, EventArgs e)
        {
            btnTau1.BackgroundImage = Image.FromFile(@"E:\IT_MTA\Nam 3\Ki_2\Slide_baigiang_TTNM\project\HCI\DatVeTau\DatVeTau\images\select.jpg");
            lbTau1.BackColor = System.Drawing.Color.White;
        }

        private void btnTau2_MouseHover(object sender, EventArgs e)
        {

            btnTau2.BackgroundImage = Image.FromFile(@"E:\IT_MTA\Nam 3\Ki_2\Slide_baigiang_TTNM\project\HCI\DatVeTau\DatVeTau\images\hover.jpg");
            lbTau2.BackColor = System.Drawing.Color.Orange;
        }

        private void btnTau2_MouseLeave(object sender, EventArgs e)
        {
            btnTau2.BackgroundImage = Image.FromFile(@"E:\IT_MTA\Nam 3\Ki_2\Slide_baigiang_TTNM\project\HCI\DatVeTau\DatVeTau\images\entity.jpg");
            lbTau2.BackColor = System.Drawing.Color.White;
        }

        private void btnTau3_MouseHover(object sender, EventArgs e)
        {
            btnTau3.BackgroundImage = Image.FromFile(@"E:\IT_MTA\Nam 3\Ki_2\Slide_baigiang_TTNM\project\HCI\DatVeTau\DatVeTau\images\hover.jpg");
            lbTau3.BackColor = System.Drawing.Color.Orange;
        }

        private void btnTau3_MouseLeave(object sender, EventArgs e)
        {
            btnTau3.BackgroundImage = Image.FromFile(@"E:\IT_MTA\Nam 3\Ki_2\Slide_baigiang_TTNM\project\HCI\DatVeTau\DatVeTau\images\entity.jpg");
            lbTau3.BackColor = System.Drawing.Color.White;
        }

        private void btnMuaVe_Click(object sender, EventArgs e)
        {
            frmThongTin frm = new frmThongTin();
            this.Hide();
            frm.ShowDialog();

        }
    }
}
