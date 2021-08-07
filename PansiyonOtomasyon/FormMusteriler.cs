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
    public partial class FormMusteriler : Form
    {
        public FormMusteriler()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection("Data Source=CVANAKGUL;Initial Catalog=Pansiyon;Integrated Security=True");

        private void verileriGoster()
        {
            listView1.Items.Clear(); //"müşteri göster" butonuna her tıkladığımda tekrar veri gelmesini önledim. 
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select * from Table_YeniMusteri",baglanti); 
            SqlDataReader oku = komut.ExecuteReader();
            while (oku.Read()) //listview a verileri çekiyoruz.
            {
                ListViewItem ekle = new ListViewItem();
                ekle.Text = oku["MusteriId"].ToString();
                ekle.SubItems.Add(oku["Adi"].ToString());
                ekle.SubItems.Add(oku["Soyadi"].ToString());
                ekle.SubItems.Add(oku["Cinsiyet"].ToString());
                ekle.SubItems.Add(oku["Telefon"].ToString());
                ekle.SubItems.Add(oku["Mail"].ToString());
                ekle.SubItems.Add(oku["TC"].ToString());
                ekle.SubItems.Add(oku["OdaNo"].ToString());
                ekle.SubItems.Add(oku["Ucret"].ToString());
                ekle.SubItems.Add(oku["GirisTarihi"].ToString());
                ekle.SubItems.Add(oku["CikisTarihi"].ToString());

                listView1.Items.Add(ekle);
            }
            baglanti.Close();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            verileriGoster();
        }
        int id = 0;
        private void listView1_DoubleClick(object sender, EventArgs e)
        {
            id = int.Parse(listView1.SelectedItems[0].SubItems[0].Text);
            txtAdi.Text = listView1.SelectedItems[0].SubItems[1].Text;
            txtSoyadi.Text = listView1.SelectedItems[0].SubItems[2].Text;
            comboBoxCinsiyet.Text = listView1.SelectedItems[0].SubItems[3].Text;
            maskTxtTelefon.Text = listView1.SelectedItems[0].SubItems[4].Text;
            txtMail.Text = listView1.SelectedItems[0].SubItems[5].Text;
            txtKimlik.Text = listView1.SelectedItems[0].SubItems[6].Text;
            txtOdaNo.Text = listView1.SelectedItems[0].SubItems[7].Text;
            txtUcret.Text = listView1.SelectedItems[0].SubItems[8].Text;
            dateTPGirisTarihi.Text = listView1.SelectedItems[0].SubItems[9].Text;
            dateTPCikisTarihi.Text = listView1.SelectedItems[0].SubItems[10].Text;
        }
        private void btnGuncelle_Click(object sender, EventArgs e)
        {

            baglanti.Open();
            SqlCommand komut = new SqlCommand("update Table_YeniMusteri set Adi='" + txtAdi.Text + "',Soyadi='" + txtSoyadi.Text + "',Cinsiyet='" + comboBoxCinsiyet.Text + "',Telefon='" + maskTxtTelefon.Text +"',Mail='"+txtMail.Text +"',TC='"+txtKimlik.Text+"',OdaNo='"+txtOdaNo.Text+"',Ucret='"+txtUcret.Text+"',GirisTarihi='"+dateTPGirisTarihi.Value.ToString("yyyy-MM-dd")+"',CikisTarihi='"+dateTPCikisTarihi.Value.ToString("yyyy-MM-dd")+"' where MusteriId=" + id + "", baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
            verileriGoster();
        }
        private void btnSil_Click(object sender, EventArgs e)
        {

            if (txtOdaNo.Text == "101")
            {
                  baglanti.Open();
                  SqlCommand komut = new SqlCommand("delete from Table_Oda101",baglanti);
                  komut.ExecuteNonQuery();
                  baglanti.Close();
                  verileriGoster();
            }
            if (txtOdaNo.Text == "102")
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("delete from Table_Oda102", baglanti);
                komut.ExecuteNonQuery();
                baglanti.Close();
                verileriGoster();
            }
            if (txtOdaNo.Text == "103")
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("delete from Table_Oda103", baglanti);
                komut.ExecuteNonQuery();
                baglanti.Close();
                verileriGoster();
            }
            if (txtOdaNo.Text == "104")
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("delete from Table_Oda104", baglanti);
                komut.ExecuteNonQuery();
                baglanti.Close();
                verileriGoster();
            }
            if (txtOdaNo.Text == "105")
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("delete from Table_Oda105", baglanti);
                komut.ExecuteNonQuery();
                baglanti.Close();
                verileriGoster();
            }
            if (txtOdaNo.Text == "106")
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("delete from Table_Oda106", baglanti);
                komut.ExecuteNonQuery();
                baglanti.Close();
                verileriGoster();
            }
            if (txtOdaNo.Text == "107")
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("delete from Table_Oda107", baglanti);
                komut.ExecuteNonQuery();
                baglanti.Close();
                verileriGoster();
            }
            if (txtOdaNo.Text == "108")
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("delete from Table_Oda108", baglanti);
                komut.ExecuteNonQuery();
                baglanti.Close();
                verileriGoster();
            }
            if (txtOdaNo.Text == "109")
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("delete from Table_Oda109", baglanti);
                komut.ExecuteNonQuery();
                baglanti.Close();
                verileriGoster();
            }

        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            txtAdi.Clear();
            txtSoyadi.Clear();
            comboBoxCinsiyet.Text = "";
            maskTxtTelefon.Clear();
            txtMail.Text = "";
            txtKimlik.Clear();
            txtOdaNo.Clear();
            txtUcret.Clear();
            dateTPGirisTarihi.Text = "";
            dateTPCikisTarihi.Text = "";
        }

        private void btnAra_Click(object sender, EventArgs e)
        {

            listView1.Items.Clear(); //"müşteri göster" butonuna her tıkladığımda tekrar veri gelmesini önledim. 
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select * from Table_YeniMusteri where Adi like '%"+txtAra.Text+"%'", baglanti); //txtAra daki veriye benzeyenleri getir
            SqlDataReader oku = komut.ExecuteReader();
            while (oku.Read()) //listview a verileri çekiyoruz.
            {
                ListViewItem ekle = new ListViewItem();
                ekle.Text = oku["MusteriId"].ToString();
                ekle.SubItems.Add(oku["Adi"].ToString());
                ekle.SubItems.Add(oku["Soyadi"].ToString());
                ekle.SubItems.Add(oku["Cinsiyet"].ToString());
                ekle.SubItems.Add(oku["Telefon"].ToString());
                ekle.SubItems.Add(oku["Mail"].ToString());
                ekle.SubItems.Add(oku["TC"].ToString());
                ekle.SubItems.Add(oku["OdaNo"].ToString());
                ekle.SubItems.Add(oku["Ucret"].ToString());
                ekle.SubItems.Add(oku["GirisTarihi"].ToString());
                ekle.SubItems.Add(oku["CikisTarihi"].ToString());

                listView1.Items.Add(ekle);
            }
            baglanti.Close();
        }


        //     SqlCommand komut = new SqlCommand("delete from Table_YeniMusteri where MusteriId=("+id+")",baglanti);
    }
}
