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
    public partial class FormAdminGiris : Form
    {
        public FormAdminGiris()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection("Data Source=CVANAKGUL;Initial Catalog=Pansiyon;Integrated Security=True");

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnGirisYap_Click(object sender, EventArgs e)
        {
            if(1>0)
            {
                baglanti.Open();
                string sql = "select * from Table_Admin where KullaniciAdi=@KullaniciAdi AND Sifre=@Sifresi";
                SqlParameter prm1 = new SqlParameter("KullaniciAdi", txtKullaniciAdi.Text.Trim()); //Trim parametre olarak girilen değerlerin başındaki ve sonundaki BOŞLUKLARI kaldırır.
                SqlParameter prm2 = new SqlParameter("Sifresi", txtSifre.Text.Trim());
                SqlCommand komut = new SqlCommand(sql, baglanti);
                komut.Parameters.Add(prm1);
                komut.Parameters.Add(prm2);

                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(komut);
                da.Fill(dt);
                if (dt.Rows.Count > 0)
                {
                    FormAnaForm fr = new FormAnaForm();
                    fr.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("hatali giriş");
                }
                baglanti.Close();
               
            }
            
        }
    }
}
