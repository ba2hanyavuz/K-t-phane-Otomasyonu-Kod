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
    public partial class Uyegiris : Form
    {
        public Uyegiris()
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
        private void Giris()
        {
            try
            {
                conn.Open();
                kmt = new SqlCommand("select * from uye where kullanici_adi='" + Kullanıcıtextbox.Text.Trim() + "' and sifre='" + Sifretextbox.Text.Trim() + "'", conn);   
                dr = kmt.ExecuteReader();
                if (dr.Read())
                {                   
                    MessageBox.Show("Giriş Başarili", "Hoşgeldiniz", MessageBoxButtons.OK, MessageBoxIcon.None);
                    this.Hide();
                    aktarma();
                    Uyearayuz uyeArayuz = new Uyearayuz();
                    uyeArayuz.Show();    
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
        public static int uyeid = 0;
        private void aktarma()
        {
            try
            {
                conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB; AttachDbFilename =|DataDirectory|\kutuphane_veritabani.mdf; Initial Catalog = kutuphane_veritabani; Integrated Security=True");
                kmt = new SqlCommand("select uye_id from uye where kullanici_adi='" + Kullanıcıtextbox.Text + "'", conn);
                conn.Open();
                uyeid = (int)kmt.ExecuteScalar();
                conn.Close();
                uyeid = Convert.ToInt32(label1.Text);
                uyeid.ToString();
            }
            catch (Exception)
            {
            }
        }
        private void Girisbutton_Click(object sender, EventArgs e)
        {
            Giris();
        }

        private void Sifretextbox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Giris();
            }
        }

        private void sifremiUnuttum_Click(object sender, EventArgs e)
        {
            sifremiUnuttum sifre = new sifremiUnuttum();
            sifre.Show();
        }
    }
}
