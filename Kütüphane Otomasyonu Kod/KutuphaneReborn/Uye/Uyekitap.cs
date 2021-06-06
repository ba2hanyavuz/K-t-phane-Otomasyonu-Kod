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
    public partial class Uyekitap : Form
    {
        public Uyekitap()
        {
            InitializeComponent();
        }

        SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB; AttachDbFilename =|DataDirectory|\kutuphane_veritabani.mdf; Initial Catalog = kutuphane_veritabani; Integrated Security=True");
        SqlDataAdapter sda;
        SqlCommand kmt;
        DataTable dt;


        private void goster()
        {
            conn.Open();
            string sqlquery = "select kitap_id as 'Kitap ID',kitap_ad as 'Kitap Adı',yazar_ad as 'Yazar',yayinevi_ad as 'Yayınevi',basim_yili as 'Basım Yılı'," +
                "tur_ad as 'Tür',sayfa_sayisi as 'Sayfa Sayısı',ozet as 'Ozet',resim_yolu as 'Resim Yolu',adet as 'Adet' from kitap " +
                "inner join yazar on kitap.yazar=yazar.yazar_id " +
                "inner join yayinevi on kitap.yayinevi=yayinevi.yayinevi_id " +
                "inner join tur on tur.tur_id= kitap.tur " +
                "where not adet = '" + 0 + "'";
            kmt = new SqlCommand(sqlquery, conn);
            sda = new SqlDataAdapter(kmt);
            dt = new DataTable();
            sda.Fill(dt);
            kitapBilgi.DataSource = dt;
            conn.Close();
        }

        private void kitapBilgi_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int k;
            try
            {
                k = e.RowIndex;
                kitapno.Text = kitapBilgi.Rows[k].Cells[0].Value.ToString();
                kitapad.Text = kitapBilgi.Rows[k].Cells[1].Value.ToString();
                yazar.Text = kitapBilgi.Rows[k].Cells[2].Value.ToString();
                yayinevi.Text = kitapBilgi.Rows[k].Cells[3].Value.ToString();
                basimyili.Text = kitapBilgi.Rows[k].Cells[4].Value.ToString();
                tur.Text = kitapBilgi.Rows[k].Cells[5].Value.ToString();
                sayfasayisi.Text = kitapBilgi.Rows[k].Cells[6].Value.ToString();
                konu.Text = kitapBilgi.Rows[k].Cells[7].Value.ToString();
                kapak.ImageLocation = kitapBilgi.Rows[k].Cells[8].Value.ToString();
                istekgonder.Enabled = true;


            }
            catch (Exception)
            {
              
            }
        }

        private void istekgonder_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult dr = MessageBox.Show("Emanet isteği göndermek istiyor musunuz ?", "Emanet İstek", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (dr == DialogResult.Yes)
                {
                    conn.Open();
                string code = "Insert Into emanet (uye_id , kitap_id, emanet_tarihi, teslim_tarihi ) Values ('" + Uyegiris.uyeid + "','" + kitapno.Text + "','" + null + "','" + null + "'" + ")";
                kmt = new SqlCommand(code, conn);
                kmt.ExecuteNonQuery();
                conn.Close();
                goster();
                }
                else
                {
                    MessageBox.Show("Lütfen Tekrar Deneyin", "Kayit başarısız", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

            }
            catch (Exception)
            {
                MessageBox.Show("Kitap Seçmediniz.");
                conn.Close();
            }
        }

        private void Uyekitap_Load(object sender, EventArgs e)
        {
            aramaCombo.Items.Add("Kitap Adı");
            aramaCombo.Items.Add("Yazar");
            aramaCombo.Items.Add("Yayınevi");
            aramaCombo.Items.Add("Basım Yılı");
            aramaCombo.Items.Add("Tür");
            aramaCombo.Items.Add("Sayfa");
            goster();
            veriCek();
            aramaTextBox.Visible = false;
            yazarArama.Visible = false;
            turArama.Visible = false;
            yayineviArama.Visible = false;
        }

        private void ara_Click(object sender, EventArgs e)
        {
            try
            {
                string kod = "";
                string sqlquery = "select kitap_id as 'Kitap ID',kitap_ad as 'Kitap Adı',yazar_ad as 'Yazar',yayinevi_ad as 'Yayınevi',basim_yili as 'Basım Yılı'," +
                    "tur_ad as 'Tür',sayfa_sayisi as 'Sayfa Sayısı',ozet as 'Ozet',resim_yolu as 'Resim Yolu',adet as 'Adet' from kitap " +
                    "inner join yazar on kitap.yazar=yazar.yazar_id " +
                    "inner join yayinevi on kitap.yayinevi=yayinevi.yayinevi_id " +
                    "inner join tur on tur.tur_id= kitap.tur " +
                    "where not adet = '" + 0 + "'";

                if (aramaCombo.Text == "Kitap Adı")
                {
                    kod = sqlquery + " AND kitap_ad like '%" + aramaTextBox.Text + "%'";
                }
                else if (aramaCombo.Text == "Yazar")
                {
                    kod = sqlquery + " AND yazar.yazar_ad like '%" + yazarArama.Text + "%'";
                }
                else if (aramaCombo.Text == "Yayınevi")
                {
                    kod = sqlquery + " AND yayinevi.yayinevi_ad like '%" + yayineviArama.Text + "%'";
                }
                else if (aramaCombo.Text == "Basım Yılı")
                {
                    kod = sqlquery + " AND basim_yili like '%" + aramaTextBox.Text + "%'";
                }
                else if (aramaCombo.Text == "Tür")
                {
                    kod = sqlquery + " AND tur.tur_ad like '%" + turArama.Text + "%'";
                }
                else if (aramaCombo.Text == "Sayfa")
                {
                    kod = sqlquery + " AND sayfa_sayisi like '%" + aramaTextBox.Text + "%'";
                }

                conn.Open();
                kmt = new SqlCommand(kod, conn);
                sda = new SqlDataAdapter(kmt);
                DataSet ds = new DataSet();
                sda.Fill(ds);
                kitapBilgi.DataSource = ds.Tables[0];
                conn.Close();
            }
            catch (Exception)
            {

            }
            
        }

        private void aramaCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            ara.Enabled = true;

            if(aramaCombo.Text == "Yazar")
            {
                aramaTextBox.Visible = false;
                yazarArama.Visible = true;
                yayineviArama.Visible = false;
                turArama.Visible = false;
                yazarArama.SelectedIndex = 0;
            }
            else if (aramaCombo.Text == "Yayınevi")
            {
                aramaTextBox.Visible = false;
                yazarArama.Visible = false;
                yayineviArama.Visible = true;
                turArama.Visible = false;
                yayineviArama.SelectedIndex = 0;
            }
            else if (aramaCombo.Text == "Tür")
            {
                aramaTextBox.Visible = false;
                yazarArama.Visible = false;
                yayineviArama.Visible = false;
                turArama.Visible = true;
                turArama.SelectedIndex = 0;
            }
            else
            {
                aramaTextBox.Visible = true;
                yazarArama.Visible = false;
                yayineviArama.Visible = false;
                turArama.Visible = false;
            }
        }

        public void veriCek()
        {
            yazarVeri();
            turVeri();
            yayineviVeri();
        }

        private void yazarVeri()
        {
            conn.Open();
            kmt = new SqlCommand("select yazar_ad, yazar_id from yazar", conn);
            SqlDataReader read = kmt.ExecuteReader();
            while (read.Read())
            {
                yazarArama.Items.Add(read["yazar_ad"].ToString());
                yazarArama.DisplayMember = (read["yazar_ad"].ToString());
                yazarArama.ValueMember = (read["yazar_id"].ToString());

            }
            conn.Close();
        }
        private void yayineviVeri()
        {
            conn.Open();
            kmt = new SqlCommand("select yayinevi_ad, yayinevi_id from yayinevi", conn);
            SqlDataReader read = kmt.ExecuteReader();
            while (read.Read())
            {
                yayineviArama.Items.Add(read["yayinevi_ad"].ToString());
                yayineviArama.DisplayMember = (read["yayinevi_ad"].ToString());
                yayineviArama.ValueMember = (read["yayinevi_id"].ToString());
            }
            conn.Close();
        }



        private void turVeri()
        {
            conn.Open();
            kmt = new SqlCommand("select tur_ad, tur_id from tur", conn);
            SqlDataReader read = kmt.ExecuteReader();
            while (read.Read())
            {
                turArama.Items.Add(read["tur_ad"]);
                turArama.DisplayMember = (read["tur_ad"].ToString());
                turArama.ValueMember = (read["tur_id"].ToString());
            }
            conn.Close();
        }

        private void Listelebutton_Click(object sender, EventArgs e)
        {
            goster();
        }
    }
}
