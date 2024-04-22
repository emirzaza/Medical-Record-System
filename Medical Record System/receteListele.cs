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
    public partial class receteListele : Form
    {
        public receteListele()
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
            NpgsqlDataReader dr = komut.ExecuteReader();

            if (dr.HasRows)
            {
                DataTable dt = new DataTable();
                dt.Load(dr);
                gridlistelerecete.DataSource = dt;
            }
            komut.Dispose();
            baglantı.Close();
        }
        private void btnlistelerecete_Click(object sender, EventArgs e)
        {
            tablogoster(" SELECT * FROM recete ORDER BY tarih");
           
        }
    }
}
