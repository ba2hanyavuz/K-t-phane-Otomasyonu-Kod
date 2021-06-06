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
    public partial class Dordunbiri : Form
    {
        public Dordunbiri()
        {
            InitializeComponent();
        }
        SqlConnection conn;
        SqlCommand kmt;

        Random r = new Random();
        string[] kirmizilar = new string[10];
        int sira = 1;
        int yanlisSayisi = 0;

        void renkleriDagit()
        {
            int altSinir = 1;
            int ustSinir = 4;
            for (int i = 0; i < 10; i++)
            {
                string buttonName = "btn" + r.Next(altSinir, ustSinir + 1);
                kirmizilar[i] = buttonName;
                altSinir += 4;
                ustSinir += 4;
            }
        }

        void butonSifirla()
        {
            for (int i = 1; i <= 40; i++)
            {
                this.Controls.Find("btn" + i.ToString(), true)[0].BackColor = Color.White;
            }
        }

        void oyunSifirla()
        {
            renkleriDagit();
            butonSifirla();
            sira = 1;
            yanlisSayisi = 0;
        }
        private void guncelle()
        {
            conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB; AttachDbFilename =|DataDirectory|\kutuphane_veritabani.mdf; Initial Catalog = kutuphane_veritabani; Integrated Security=True");
            kmt = new SqlCommand();
            conn.Open();
            kmt.Connection = conn;
            kmt.CommandText = "update uye set bookCoin= '" + label2.Text + "' where uye_id= " + Uyegiris.uyeid + "";
            kmt.ExecuteNonQuery();
            conn.Close();
        }

        private void btnNewGame_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;
            oyunSifirla();
        }

        int v;

        private void Dordunbiri_Load(object sender, EventArgs e)
        {
            ToolTip toolTip1 = new ToolTip();
            toolTip1.AutoPopDelay = 5000;
            toolTip1.InitialDelay = 100;
            toolTip1.ReshowDelay = 500;
            toolTip1.SetToolTip(this.btnNewGame, "Soldan sağa kullanıcı her sutunda bir kutu seçer en sona kadar 2 kırmızı seçmeden ulaşmaya çalışır.");
            toolTip1.ShowAlways = true;
            SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB; AttachDbFilename =|DataDirectory|\kutuphane_veritabani.mdf; Initial Catalog = kutuphane_veritabani; Integrated Security=True");
            SqlCommand kmt = new SqlCommand("select bookCoin from uye where uye_id='" + Uyegiris.uyeid + "'", conn);
            conn.Open();
            v = Convert.ToInt32(kmt.ExecuteScalar());
            label1.Text = v.ToString();
            conn.Close();
            oyunSifirla();
        }

        private void btns_Click(object sender, EventArgs e)
        {
            int btnNo = Convert.ToInt32(((Button)sender).Name.Remove(0, 3));
            if (btnNo >= ((sira * 4) - 3) && btnNo <= (sira * 4))
            {
                if (Array.IndexOf(kirmizilar, ((Button)sender).Name) != -1) // kırmızı ise
                {
                    ((Button)sender).BackColor = Color.Red;
                    yanlisSayisi++;
                }
                else
                {
                    ((Button)sender).BackColor = Color.Green;
                }
                sira++;
                if (sira == 11 && yanlisSayisi <= 1)
                {
                    MessageBox.Show("Tebrikler , 5 bookcoin kazandin.", "Tebrikler", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    label2.Text = Convert.ToString(v + 5);
                    guncelle();
                    oyunSifirla();
                    Uyearayuz.labelbookcoin.Text = label2.Text;
                    Close();
                }
                else if (yanlisSayisi >= 2)
                {
                    MessageBox.Show("Üzgünüm , Oyunu kaybettiniz.", "Üzgünüm");
                    oyunSifirla();
                }
            }
            else
            {
                MessageBox.Show("Sirali bir şekilde gidin veya aynı satırdan tek seçenek seçin.", "Tekrar Deneyiniz");
            }
        }
    }
}
