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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar;

namespace saglıkOcagıOtomasyonu
{

          public partial class receteYaz : Form
        {

        string number = hastaBak.Data;
        public receteYaz()
            {
                InitializeComponent();
            }

       

        public static string veri;
        private void btnrecetekaydet_Click(object sender, EventArgs e)
        {

            string textBox1Value = txtilac1.Text;
            string textBox2Value = txtilac2.Text;
            string textBox3Value = txtilac3.Text;
            string textBox4Value = txtilac4.Text;
            string textBox5Value = txtilac5.Text;

            NpgsqlConnection bireyselbaglantı = new NpgsqlConnection("Server=localhost; Port=5432;Database=recete;User Id=postgres;Password=1234;Database=postgres");



                List<int> nolar = new List<int>();
                Random rst = new Random();
                int rstsayi = rst.Next();
                if (!nolar.Contains(rstsayi))
                    nolar.Add(rstsayi);

                
                string recetekod= rstsayi.ToString();

            veri = recetekod;
            hastaBak hastaBak = new hastaBak();

                bireyselbaglantı.Open();
                NpgsqlCommand komut_ekle = new NpgsqlCommand();
                komut_ekle.Connection = bireyselbaglantı;


            if (textBox1Value != textBox2Value && textBox1Value != textBox3Value && textBox1Value != textBox4Value && textBox1Value != textBox5Value
                 && textBox2Value != textBox3Value && textBox2Value != textBox4Value && textBox2Value != textBox5Value
                 && textBox3Value != textBox4Value && textBox3Value != textBox5Value
                 && textBox4Value != textBox5Value)
            {
                komut_ekle.Parameters.AddWithValue("@RECETEKOD", Convert.ToInt64(recetekod));
                komut_ekle.Parameters.AddWithValue("@TCNO", Convert.ToInt64(number));
                komut_ekle.Parameters.AddWithValue("@ILAC1", txtilac1.Text);
                komut_ekle.Parameters.AddWithValue("@ILAC2", txtilac2.Text);
                komut_ekle.Parameters.AddWithValue("@ILAC3", txtilac3.Text);
                komut_ekle.Parameters.AddWithValue("@ILAC4", txtilac4.Text);
                komut_ekle.Parameters.AddWithValue("@ILAC5", txtilac5.Text);
                komut_ekle.Parameters.AddWithValue("@TARIH", DateTime.Now);
                komut_ekle.Parameters.AddWithValue("@ADET1", cb1.Text);
                komut_ekle.Parameters.AddWithValue("@ADET2", cb2.Text);
                komut_ekle.Parameters.AddWithValue("@ADET3", cb3.Text);
                komut_ekle.Parameters.AddWithValue("@ADET4", cb4.Text);
                komut_ekle.Parameters.AddWithValue("@ADET5",cb5.Text);
                receteYaz rct = new receteYaz();



                komut_ekle.CommandType = CommandType.Text;
                komut_ekle.CommandText = "insert into recete (recetekodu, hastatc, ilac1, ilac1adet, ilac2, ilac2adet, ilac3, ilac3adet, ilac4, ilac4adet, ilac5, ilac5adet,tarih) values (@RECETEKOD, @TCNO, @ILAC1, @ADET1, @ILAC2, @ADET2, @ILAC3, @ADET3, @ILAC4, @ADET4, @ILAC5, @ADET5, @TARIH)";
                _ = komut_ekle.ExecuteReader();
            }
            else
                MessageBox.Show("Bir ilacı sadace bir kez yazabilirsiniz ve maksimum 3 kutu yazabilirsiniz! ");

            

                komut_ekle.Dispose();
                bireyselbaglantı.Close();

                this.Close();




            }

        private void receteYaz_Load(object sender, EventArgs e)
        {
            cb1.SelectedIndex = 0;
            cb2.SelectedIndex = 0;
            cb3.SelectedIndex = 0;
            cb4.SelectedIndex = 0;
            cb5.SelectedIndex = 0;



        }
        NpgsqlConnection baglantı = new NpgsqlConnection("Server=localhost; Port=5432;Database=ilac;User Id=postgres;Password=1234;Database=postgres");
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
                gridilaclistele.DataSource = dt;
            }
            komut.Dispose();
            baglantı.Close();
        }

        private void btnilacgöster_Click(object sender, EventArgs e)
        {
            tablogoster(" SELECT * FROM ilac ");
        }
    }
}
