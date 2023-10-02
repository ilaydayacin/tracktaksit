using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace track_bar_örnek
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void tbTaksit_ValueChanged(object sender, EventArgs e)
        {
            label2.Text= tbTaksit.Value.ToString(); 
        }

        private void btnHesapla_Click(object sender, EventArgs e)
        {
            int taksit, tutar;
            double sonuc;
            taksit =tbTaksit.Value;
            tutar = Convert.ToInt32(txtMiktar.Text);

            sonuc = (double)tutar / taksit;
            lblSonuc.Text ="Taksitli tutar: " +sonuc.ToString(); 
        }
    }
}
