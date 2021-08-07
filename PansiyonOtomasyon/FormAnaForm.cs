using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PansiyonOtomasyon
{
    public partial class FormAnaForm : Form
    {
        public FormAnaForm()
        {
            InitializeComponent();
        }

        private void btnAdminGiris_Click(object sender, EventArgs e)
        {
            FormAdminGiris fr = new FormAdminGiris();
            fr.Show();
            this.Hide();//FormAnaForm'u gizle
        }

        private void btnYeniMusteri_Click(object sender, EventArgs e)
        {
            FormYeniMusteri fr = new FormYeniMusteri();
            fr.Show();
        }

        private void btnMusteriler_Click(object sender, EventArgs e)
        {
            FormMusteriler fr = new FormMusteriler();
            fr.Show();
        }

        private void btnHakkimizda_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Pansiyon Oda Kiralama Uygulaması");
        }

        private void btnOdalar_Click(object sender, EventArgs e)
        {
            FormOdalar fr = new FormOdalar();
            fr.Show();
        }

        private void FormAnaForm_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

            label1.Text = DateTime.Now.ToLongDateString();
            label2.Text = DateTime.Now.ToLongTimeString();
        }

        private void btnCikis_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnGelirGider_Click(object sender, EventArgs e)
        {
            FormGelirGider fr = new FormGelirGider();
            fr.Show();
        }

        private void btnStoklar_Click(object sender, EventArgs e)
        {
            FormStoklar fr = new FormStoklar();
            fr.Show();
        }

        private void btnRadyoDinle_Click(object sender, EventArgs e)
        {
            FormRAdyo fr = new FormRAdyo();
            fr.Show();
        }

        private void btnGazete_Click(object sender, EventArgs e)
        {
            FormGazete fr = new FormGazete();
            fr.Show();
        }

        private void btnSifreGuncelle_Click(object sender, EventArgs e)
        {
            FormSifreGuncelle fr = new FormSifreGuncelle();
            fr.Show();
        }

        private void btnMusteriMesajlari_Click(object sender, EventArgs e)
        {
            FormMesaj fr = new FormMesaj();
            fr.Show();
        }
    }
}
