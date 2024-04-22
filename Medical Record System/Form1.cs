using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Npgsql;

namespace saglıkOcagıOtomasyonu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnhastakayıt_Click(object sender, EventArgs e)
        {

         hastaKayıt kaydol = new hastaKayıt();
            kaydol.Show();

        }

        private void btnilackayit_Click(object sender, EventArgs e)
        {
            ilacKayıt ilacKay = new ilacKayıt();
            ilacKay.Show();
        }

        private void btnhastabak_Click(object sender, EventArgs e)
        {
            hastaBak hastaBak=new hastaBak();
            hastaBak.Show();
        }

        private void btnmuayanedefteri_Click(object sender, EventArgs e)
        {
            muayaneDefteri muayaneDefteri = new muayaneDefteri();
            muayaneDefteri.Show();
        }

        private void btnrecetelistele_Click(object sender, EventArgs e)
        {
            receteListele receteListele = new receteListele();
            receteListele.Show();
        }

        private void btnilaclistele_Click(object sender, EventArgs e)
        {
            ilacListele ilacListele=new ilacListele();
            ilacListele.Show();
        }
    }
}
