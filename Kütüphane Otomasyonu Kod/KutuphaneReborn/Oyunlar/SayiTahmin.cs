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
    public partial class SayiTahmin : Form
    {
        public SayiTahmin()
        {
            InitializeComponent();
        }
        SqlConnection conn;
        SqlCommand kmt;
        private void guncelle()
        {
            conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB; AttachDbFilename =|DataDirectory|\kutuphane_veritabani.mdf; Initial Catalog = kutuphane_veritabani; Integrated Security=True");
            kmt = new SqlCommand();
            conn.Open();
            kmt.Connection = conn;
            kmt.CommandText = "update uye set bookCoin= '" + label9.Text + "' where uye_id= " + Uyegiris.uyeid + "";
            kmt.ExecuteNonQuery();
            conn.Close();
        }

        int sayi = 0, tahmin_deneme = 0, bookcoin = 10,v;

        private void SayiTahmin_Load(object sender, EventArgs e)
        {
            Random rnd = new Random();
            sayi = rnd.Next(100);
            label8.Text = sayi.ToString();
            SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB; AttachDbFilename =|DataDirectory|\kutuphane_veritabani.mdf; Initial Catalog = kutuphane_veritabani; Integrated Security=True");
            SqlCommand kmt = new SqlCommand("select bookCoin from uye where uye_id='" + Uyegiris.uyeid + "'", conn);
            conn.Open();
            v = Convert.ToInt32(kmt.ExecuteScalar());
            label10.Text = v.ToString();
            conn.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int tahmin;
            tahmin_deneme++;
            if (tahmin_deneme <= 10)
            {
                tahmin = int.Parse(textBox1.Text);
                label6.Text = tahmin_deneme.ToString();
                if (tahmin < sayi)
                {
                    label5.Text = "yukari";
                    bookcoin--;
                    label7.Text = bookcoin.ToString();
                }
                else if (tahmin > sayi)
                {
                    label5.Text = "asagi";
                    bookcoin--;
                    label7.Text = Convert.ToString(bookcoin);
                }
                else
                {
                    MessageBox.Show("Tebrikler " + bookcoin + " bookcoin kazandin");
                    label9.Text = Convert.ToString(v + bookcoin);
                    guncelle();
                    button1.Enabled = false;
                    Uyearayuz.labelbookcoin.Text = label9.Text;
                }

            }
            else
            {
                MessageBox.Show("Tahmin hakkiniz kalmadi");
            }
        }
    }
}
