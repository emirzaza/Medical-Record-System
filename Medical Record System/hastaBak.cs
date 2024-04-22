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
    public partial class hastaBak : Form
    {

        
        public hastaBak()
        {
            InitializeComponent();
        }

        public static string Data;
        
        private void btnreceteyaz_Click_2(object sender, EventArgs e)
        {
            Data = txttcno.Text;
            receteYaz form2 = new receteYaz();
            form2.Show();
            btnreceteyaz.Enabled = false;    
        }
       
        private void btnhastabak_Click(object sender, EventArgs e)
        {
            bool primaryKeyExists = false;
            string number = receteYaz.veri;


            NpgsqlConnection bireyselbaglantı = new NpgsqlConnection("Server=localhost; Port=5432;Database=muayanedefteri;User Id=postgres;Password=1234;Database=postgres");
            bireyselbaglantı.Open();

            
            NpgsqlCommand komut_oku = new NpgsqlCommand("SELECT * FROM muayanedefteri", bireyselbaglantı);

            using (NpgsqlDataReader reader = komut_oku.ExecuteReader())
            {
                while (reader.Read())
                {
                    
                    long hastatc = reader.GetInt64(0);
                    if (hastatc == Convert.ToInt64(txttcno.Text))
                    {
                        primaryKeyExists = true;
                        break;
                    }
                }
            }

          
            if (primaryKeyExists)
            {
                MessageBox.Show("BU MÜŞTERİNİN ZATEN BUGÜNE RANDEVUSU VAR ");
                this.Close();
            }
            else
            {
             

                NpgsqlCommand komut_ekle = new NpgsqlCommand();
                komut_ekle.Connection = bireyselbaglantı;

                if (number == null)
                {
                    komut_ekle.Parameters.AddWithValue("@RECETE", "ReceteYazılmadı");
                }
                else
                {
                    komut_ekle.Parameters.AddWithValue("@RECETE",number);
                  }

                komut_ekle.Parameters.AddWithValue("@TCNO", Convert.ToInt64(txttcno.Text));
                komut_ekle.Parameters.AddWithValue("@SIKAYET", txtsikayet.Text);
                komut_ekle.Parameters.AddWithValue("@TANI", txttani.Text);
              ;
                komut_ekle.Parameters.AddWithValue("@TARIH", DateTime.Now.ToShortDateString());

                komut_ekle.CommandType = CommandType.Text;
                komut_ekle.CommandText = "insert into muayanedefteri (hastatc, sikayet, tanı, recetekodu, tarih) values (@TCNO, @SIKAYET, @TANI, @RECETE, @TARIH)";
                _ = komut_ekle.ExecuteReader();
                komut_ekle.Dispose();
            }

         
            bireyselbaglantı.Close();
            this.Close();


        }

      
    }


}

