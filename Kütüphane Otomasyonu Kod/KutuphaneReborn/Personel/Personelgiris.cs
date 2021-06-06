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
    public partial class Personelgiris : Form
    {
        public Personelgiris()
        {
            InitializeComponent();
        }
        SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB; AttachDbFilename =|DataDirectory|\kutuphane_veritabani.mdf; Initial Catalog = kutuphane_veritabani; Integrated Security=True");
        SqlCommand kmt;
        SqlDataReader dr;

        private void Geributton_Click(object sender, EventArgs e)
        {
            this.Hide();
            Giris giris = new Giris();
            giris.Show();
        }
        private void giris() 
        {
            try
            {      
                kmt = new SqlCommand("select * from personel where kullanici_adi='" + Kullanıcıtextbox.Text.Trim() + "' and sifre='" + Sifretextbox.Text.Trim() + "'", conn);
                conn.Open();
                dr = kmt.ExecuteReader();
                if (dr.Read())
                {
                    MessageBox.Show("Giriş Başarili", "Hoşgeldiniz", MessageBoxButtons.OK, MessageBoxIcon.None);
                    this.Hide();
                    aktarma();
                    Personelarayuz personel = new Personelarayuz();
                    personel.Show();
                }
                else
                {
                    MessageBox.Show("Kullanıcı adı veya Şifreyi Yanlış girdiniz", "Tekrar Deneyin", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                conn.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
        }
        public static int personelid = 0;
        public void aktarma()
        {
            try
            {
                conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB; AttachDbFilename =|DataDirectory|\kutuphane_veritabani.mdf; Initial Catalog = kutuphane_veritabani; Integrated Security=True");
                kmt = new SqlCommand("select personel_id from personel where kullanici_adi='" + Kullanıcıtextbox.Text + "'", conn);
                conn.Open();
                personelid = (int)kmt.ExecuteScalar();
                conn.Close();
                personelid = Convert.ToInt32(label1.Text);
                personelid.ToString();
            }
            catch (Exception)
            {
            }
        }

        private void Girisbutton_Click(object sender, EventArgs e)
        {
            giris();

        }

        private void Sifretextbox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                giris();
            }
        }

        private void sifremiUnuttum_Click(object sender, EventArgs e)
        {
            sifremiUnuttum sifre = new sifremiUnuttum();
            sifre.Show();
        }
    }
}
