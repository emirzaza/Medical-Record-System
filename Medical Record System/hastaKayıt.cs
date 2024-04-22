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
    public partial class hastaKayıt : Form
    {
        public hastaKayıt()
        {
            InitializeComponent();
        }

        private void btnkayıtet_Click(object sender, EventArgs e)
        {
            NpgsqlConnection baglantı = new NpgsqlConnection("Server=localhost; Port=5432;Database=hasta;User Id=postgres;Password=1234;Database=postgres");

            baglantı.Open();
            NpgsqlCommand komut_ekle = new NpgsqlCommand();
            komut_ekle.Connection = baglantı;

            komut_ekle.Parameters.AddWithValue("@NO", Convert.ToInt64(txttcno.Text));
            komut_ekle.Parameters.AddWithValue("@AD", txtad.Text);
            komut_ekle.Parameters.AddWithValue("@SOYAD",txtsoyad.Text);
            komut_ekle.Parameters.AddWithValue("@DOGUMYERI", txtdogumyeri.Text);
            komut_ekle.Parameters.AddWithValue("@DOGUMTARIHI", txtdogumtarihi.Text);
            komut_ekle.Parameters.AddWithValue("@MEDENIDURUM", txtmedenidurum.Text);
            komut_ekle.Parameters.AddWithValue("@ADRES", txtadres.Text);
            komut_ekle.Parameters.AddWithValue("@TELNO", Convert.ToInt64(txttelno.Text));
            komut_ekle.Parameters.AddWithValue("@KAYITTARIHI", DateTime.Now);

            komut_ekle.CommandType = CommandType.Text;
            komut_ekle.CommandText = "insert into hasta (tcno, ad, soyad, dogumyeri, dogumtarihi, medenidurumu, adres, telefonnumarası, kayıttarihi) values (@NO, @AD, @SOYAD, @DOGUMYERI, @DOGUMTARIHI, @MEDENIDURUM, @ADRES, @TELNO, @KAYITTARIHI)";
            _ = komut_ekle.ExecuteReader();

            komut_ekle.Dispose();
            baglantı.Close();

            MessageBox.Show("Hasta kayıt edildi." +DateTime.Now);
            this.Close();



        }
    }
}
