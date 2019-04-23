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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnTau1_MouseHover(object sender, EventArgs e)
        {
            btnTau1.BackgroundImage= Image.FromFile(@"E:\IT_MTA\Nam 3\Ki_2\Slide_baigiang_TTNM\project\HCI\DatVeTau\DatVeTau\images\select-hover.jpg");
        }

        private void btnTau1_MouseLeave(object sender, EventArgs e)
        {
            btnTau1.BackgroundImage = Image.FromFile(@"E:\IT_MTA\Nam 3\Ki_2\Slide_baigiang_TTNM\project\HCI\DatVeTau\DatVeTau\images\select.jpg");

        }
    }
}
