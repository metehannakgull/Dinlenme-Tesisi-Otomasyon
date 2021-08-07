using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;

namespace PansiyonOtomasyon
{
    public partial class FormGelirGider : Form
    {
        public FormGelirGider()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=CVANAKGUL;Initial Catalog=Pansiyon;Integrated Security=True");

        private void button1_Click(object sender, EventArgs e)
        {
            int personel;
            personel = Convert.ToInt32(textBox1.Text);
            lblPersonelMaas.Text = (personel * 2800).ToString();
            int sonuc;
            sonuc = Convert.ToInt32(lblKasaMiktar.Text) - (Convert.ToInt32(lblPersonelMaas.Text)
                +Convert.ToInt32(lblAlinanUrunler.Text) + Convert.ToInt32(lblAlinanUrunler2.Text)
                + Convert.ToInt32(lblAlinanUrunler3.Text) + Convert.ToInt32(lblFatura.Text)
                + Convert.ToInt32(lblFaturalar2.Text) + Convert.ToInt32(lblFaturalar3.Text));
            lblSonuc.Text = sonuc.ToString();
        }

        private void FormGelirGider_Load(object sender, EventArgs e)
        {
            //kasadaki toplam tutar
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select sum(Ucret) as toplam from Table_YeniMusteri", baglanti);
            SqlDataReader oku = komut.ExecuteReader();
            while (oku.Read())
            {
                lblKasaMiktar.Text = oku["toplam"].ToString();
            }
            baglanti.Close();

            //stokların giderleri(GIDA)
            baglanti.Open();
            SqlCommand komut2 = new SqlCommand("select sum(Gida) as toplam1 from Table_Stoklar", baglanti);
            SqlDataReader oku2 = komut2.ExecuteReader();
            while (oku2.Read())
            {
                lblAlinanUrunler.Text = oku2["toplam1"].ToString();
            }
            baglanti.Close();
            //stokların giderleri(İÇECEKLER)
            baglanti.Open();
            SqlCommand komut3 = new SqlCommand("select sum(Icecek) as toplam2 from Table_Stoklar", baglanti);
            SqlDataReader oku3 = komut3.ExecuteReader();
            while (oku3.Read())
            {
                lblAlinanUrunler2.Text = oku3["toplam2"].ToString();
            }
            baglanti.Close();
            //stokların giderleri(CEREZLER)
            baglanti.Open();
            SqlCommand komut4 = new SqlCommand("select sum(Cerezler) as toplam3 from Table_Stoklar", baglanti);
            SqlDataReader oku4 = komut4.ExecuteReader();
            while (oku4.Read())
            {
                lblAlinanUrunler3.Text = oku4["toplam3"].ToString();
            }
            baglanti.Close();

            //Faturalar(ELEKTRIK)
            baglanti.Open();
            SqlCommand komut5 = new SqlCommand("select sum(Elektrik) as toplam4 from Table_Faturalar", baglanti);
            SqlDataReader oku5 = komut5.ExecuteReader();
            while (oku5.Read())
            {
                lblFatura.Text = oku5["toplam4"].ToString();
            }
            baglanti.Close();
            //Faturalar(SU)
            baglanti.Open();
            SqlCommand komut6 = new SqlCommand("select sum(Su) as toplam5 from Table_Faturalar", baglanti);
            SqlDataReader oku6 = komut6.ExecuteReader();
            while (oku6.Read())
            {
                lblFaturalar2.Text = oku6["toplam5"].ToString();
            }
            baglanti.Close();
            //Faturalar(INTERNET)
            baglanti.Open();
            SqlCommand komut7 = new SqlCommand("select sum(Internet) as toplam6 from Table_Faturalar", baglanti);
            SqlDataReader oku7 = komut7.ExecuteReader();
            while (oku7.Read())
            {
                lblFaturalar3.Text = oku7["toplam6"].ToString();
            }
            baglanti.Close();

        }
    }
}
