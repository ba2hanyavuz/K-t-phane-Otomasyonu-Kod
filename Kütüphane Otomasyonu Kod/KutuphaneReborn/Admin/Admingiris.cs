using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace KutuphaneReborn
{
    public partial class Admingiris : Form
    {
        public Admingiris()
        {
            InitializeComponent();
        }

        readonly SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB; AttachDbFilename =|DataDirectory|\kutuphane_veritabani.mdf; Initial Catalog = kutuphane_veritabani; Integrated Security=True");
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
                kmt = new SqlCommand("select * from admin where kullanici_adi='" + Kullanıcıtextbox.Text.Trim() + "' and sifre='" + Sifretextbox.Text.Trim() + "'", conn);
                conn.Open();
                dr = kmt.ExecuteReader();

                if (dr.Read())
                {
                    MessageBox.Show("Giriş Başarili", "Hoşgeldiniz", MessageBoxButtons.OK, MessageBoxIcon.None);
                    this.Hide();
                    Adminarayuz adminArayuz = new Adminarayuz();
                    adminArayuz.Show();
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
        private void GirisButton_Click(object sender, EventArgs e)
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
    }
}
