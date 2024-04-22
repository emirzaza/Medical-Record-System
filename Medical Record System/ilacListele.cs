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
    public partial class ilacListele : Form
    {
        public ilacListele()
        {
            InitializeComponent();
        }
        NpgsqlConnection baglantı = new NpgsqlConnection("Server=localhost; Port=5432;Database=recete;User Id=postgres;Password=1234;Database=postgres");
        public void tablogoster(string txt)
        {


            baglantı.Open();

            NpgsqlCommand komut = new NpgsqlCommand();

            komut.Connection = baglantı;

            komut.CommandType = CommandType.Text;

            komut.CommandText = txt;
            komut.Parameters.AddWithValue("@hangi_no", Convert.ToInt64(txttchasta.Text));
            NpgsqlDataReader dr = komut.ExecuteReader();

            if (dr.HasRows)
            {
                DataTable dt = new DataTable();
                dt.Load(dr);
                gridhastanınilacları.DataSource = dt;
            }
            komut.Dispose();
            baglantı.Close();
        }

        public void tablogoster2(string txt)
        {


            baglantı.Open();

            NpgsqlCommand komut = new NpgsqlCommand();

            komut.Connection = baglantı;

            komut.CommandType = CommandType.Text;

            komut.CommandText = txt;
            komut.Parameters.AddWithValue("@hangi_no", txtilacno.Text);
            NpgsqlDataReader dr = komut.ExecuteReader();

            if (dr.HasRows)
            {
                DataTable dt = new DataTable();
                dt.Load(dr);
                gridilacınhastaları.DataSource = dt;
            }
            komut.Dispose();
            baglantı.Close();
        }
        private void btngösterhastanınilacları_Click(object sender, EventArgs e)
        {
            tablogoster("select ilac1, ilac1adet, ilac2, ilac2adet, ilac3, ilac3adet, ilac4, ilac4adet, ilac5, ilac5adet from recete where hastatc=@hangi_no ");
        }

        private void btngösterilacrecetesi_Click(object sender, EventArgs e)
        {
            tablogoster2("select hastatc, tarih from recete where ilac1=@hangi_no or ilac2=@hangi_no or ilac3=@hangi_no or ilac4=@hangi_no or ilac5=@hangi_no order by tarih ");

        }
    }
}
