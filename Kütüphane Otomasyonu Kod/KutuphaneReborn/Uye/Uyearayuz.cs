using KutuphaneReborn.Uye;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KutuphaneReborn
{
    public partial class Uyearayuz : Form
    {
        public Uyearayuz()
        {
            InitializeComponent();
        }
        private Form aktifForm = null;
        private void AltForm(Form altForm)
        {
            if (aktifForm != null)
                aktifForm.Close();
            aktifForm = altForm;
            altForm.TopLevel = false;
            altForm.FormBorderStyle = FormBorderStyle.None;
            altForm.Dock = DockStyle.Fill;
            Anapanel.Controls.Add(altForm);
            Anapanel.Tag = altForm;

            altForm.Show();
        }

        private void Kitapbutton_Click(object sender, EventArgs e)
        {
            Anapanel.Visible = true;
            buyukLogo.Visible = false;
            hosgeldiniz.Visible = false;
            AltForm(new Uyekitap());
        }

        private void Ekitapbutton_Click(object sender, EventArgs e)
        {
            Anapanel.Visible = true;
            buyukLogo.Visible = false;
            hosgeldiniz.Visible = false;
            AltForm(new ekitapSatınAl());
        }

        private void Gecmisbutton_Click(object sender, EventArgs e)
        {
            Anapanel.Visible = true;
            buyukLogo.Visible = false;
            hosgeldiniz.Visible = false;
            AltForm(new Uyegecmisi());
        }
        private void ekitapGecmisButton_Click(object sender, EventArgs e)
        {
            Anapanel.Visible = true;
            buyukLogo.Visible = false;
            hosgeldiniz.Visible = false;
            AltForm(new ekitapgecmisi());
        }

        private void Hesapbutton_Click(object sender, EventArgs e)
        {
            Anapanel.Visible = true;
            buyukLogo.Visible = false;
            hosgeldiniz.Visible = false;
            AltForm(new uyeAyarlari());
        }

        private void Coinbutton_Click(object sender, EventArgs e)
        {
            buyukLogo.Visible = false;
            hosgeldiniz.Visible = false;
            Random rnd = new Random();
            sayi = rnd.Next(6);

            if (sayi==1)
            {
                AltForm(new Dordunbiri());
            }
            else if (sayi == 2)
            {
                AltForm(new Hafizaoyunu());
            }
            else if (sayi == 3)
            {
                AltForm(new ikibinkirksekiz());
            }
           
            else if (sayi == 4)
            {
                MessageBox.Show("Şanssız Günündesin");
            }


        }
        DateTime dt = new DateTime(0);
        private void timer1_Tick(object sender, EventArgs e)
        {
            dt = dt.AddSeconds(1);
            sure.Text = dt.ToLongTimeString();
        }
        public static Label labelbookcoin;
        int sayi = 0;
        private void Uyearayuz_Load(object sender, EventArgs e)
        {
            label2.Text = Uyegiris.uyeid.ToString();


            SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB; AttachDbFilename =|DataDirectory|\kutuphane_veritabani.mdf; Initial Catalog = kutuphane_veritabani; Integrated Security=True");
            SqlCommand kmt = new SqlCommand("select kullanici_adi from uye where uye_id='" + label2.Text + "'", conn);
            SqlCommand kmt2 = new SqlCommand("select bookCoin from uye where uye_id='" + label2.Text + "'", conn);
            SqlCommand kmt3 = new SqlCommand("select cinsiyet from uye where uye_id='" + label2.Text + "'", conn);
            conn.Open();
            label3.Text = (string)kmt.ExecuteScalar();
            int v = Convert.ToInt32(kmt2.ExecuteScalar());
            label4.Text = v.ToString();
            Cinsiyet.Text = (string)kmt3.ExecuteScalar();
            conn.Close();
            labelbookcoin = label4;
            if (Cinsiyet.Text == "Erkek")
            {
                ErkekResmi.Visible = true;
            }
            else
            {
                KadinResmi.Visible = true;
            }
            
            
        }

        private void Cikisbutton_Click(object sender, EventArgs e)
        {
            this.Hide();
            Giris giris = new Giris();
            giris.Show();
        }

        
    }
}
