using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace saglıkOcagıOtomasyonu
{
    public partial class ilacKayıt : Form
    {
        public ilacKayıt()
        {
            InitializeComponent();
        }

        private void btnilackayit_Click(object sender, EventArgs e)
        {

            NpgsqlConnection baglantı = new NpgsqlConnection("Server=localhost; Port=5432;Database=ilac;User Id=postgres;Password=1234;Database=postgres");

            baglantı.Open();
            NpgsqlCommand komut_ekle = new NpgsqlCommand();
            komut_ekle.Connection = baglantı;

            komut_ekle.Parameters.AddWithValue("@NO", Convert.ToInt64(txtilackodu.Text));
            komut_ekle.Parameters.AddWithValue("@AD", txtilacadi.Text);
            komut_ekle.Parameters.AddWithValue("@TIP", txtilactipi.Text);
            

            komut_ekle.CommandType = CommandType.Text;
            komut_ekle.CommandText = "insert into ilac (ilackod, ilacadi, ilactipi) values (@NO, @AD, @TIP)";
            _ = komut_ekle.ExecuteReader();

            komut_ekle.Dispose();
            baglantı.Close();

            MessageBox.Show("İlaç kayıt edildi." + DateTime.Now.ToShortDateString());
            this.Close();
        }
    }
}
