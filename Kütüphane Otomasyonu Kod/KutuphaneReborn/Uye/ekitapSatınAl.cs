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
using System.Net;
using System.Net.Mail;

namespace KutuphaneReborn
{
    public partial class ekitapSatınAl : Form
    {
        public ekitapSatınAl()
        {
            InitializeComponent();
        }
        SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB; AttachDbFilename =|DataDirectory|\kutuphane_veritabani.mdf; Initial Catalog = kutuphane_veritabani; Integrated Security=True");
        SqlDataAdapter sda;
        SqlCommand cmd;
        DataTable dt;
        

        private void ara_Click(object sender, EventArgs e)
        {
            try
            {
                string kod = "";
                string sqlquery = "select ekitap_id as 'Kitap ID',ekitap_ad as 'Kitap Adı',yazar_ad as 'Yazar',yayinevi_ad as 'Yayınevi'," +
                    "tur_ad as 'Tür',sayfa_sayisi as 'Sayfa Sayısı',ozet as 'Ozet',resim_yolu as 'Resim Yolu',fiyat as 'Fiyat' from ekitap " +
                    "inner join yazar on ekitap.yazar=yazar.yazar_id " +
                    "inner join yayinevi on ekitap.yayinevi=yayinevi.yayinevi_id " +
                    "inner join tur on tur.tur_id= ekitap.tur";
                if (aramaCombo.Text == "E-Kitap Adı")
                {
                    kod = sqlquery + " WHERE ekitap_ad like '%" + aramaTextBox.Text + "%'";
                }
                else if (aramaCombo.Text == "Yazar")
                {
                    kod = sqlquery + " WHERE yazar.yazar_ad like '%" + yazarArama.Text + "%'";
                }
                else if (aramaCombo.Text == "Yayınevi")
                {
                    kod = sqlquery + " WHERE yayinevi.yayinevi_ad like '%" + yayineviArama.Text + "%'";
                }
              
                else if (aramaCombo.Text == "Tür")
                {
                    kod = sqlquery + " WHERE tur.tur_ad like '%" + turArama.Text + "%'";
                }


                conn.Open();
                cmd = new SqlCommand(kod, conn);
                sda = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                sda.Fill(ds);
                ekitapBilgi.DataSource = ds.Tables[0];
                conn.Close();
            }
            catch (Exception)
            {

            }
            
        }
        private void goster()
        {
            conn.Open();
            string sqlquery = "select ekitap_id as 'Kitap ID',ekitap_ad as 'Kitap Adı',yazar_ad as 'Yazar',yayinevi_ad as 'Yayınevi'," +
                "tur_ad as 'Tür',sayfa_sayisi as 'Sayfa Sayısı',ozet as 'Ozet',resim_yolu as 'Resim Yolu',fiyat as 'Fiyat' from ekitap " +
                "inner join yazar on ekitap.yazar=yazar.yazar_id " +
                "inner join yayinevi on ekitap.yayinevi=yayinevi.yayinevi_id " +
                "inner join tur on tur.tur_id= ekitap.tur";
            SqlCommand sqlcomm = new SqlCommand(sqlquery, conn);
            sda = new SqlDataAdapter(sqlcomm);
            dt = new DataTable();
            sda.Fill(dt);
            ekitapBilgi.DataSource = dt;
            conn.Close();
        }

        private void satınAl_Click(object sender, EventArgs e)
        {
            
            if (Convert.ToInt32(Uyearayuz.labelbookcoin.Text) >= Convert.ToInt32(fiyat.Text))
            {
                try
                {
                    DialogResult dr = MessageBox.Show("Satın almak istiyor musunuz ?", "Satın Alma", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                    if (dr == DialogResult.Yes)
                    {
                        conn.Open();
                    string code = "Insert Into ekitapsatis (uye_id , ekitap_id, islem_tarihi, fiyat ) Values ('" + Uyegiris.uyeid + "','" + ekitapno.Text + "','" + DateTime.Now.ToShortDateString() + "','" + fiyat.Text + "'" + ")";
                    cmd = new SqlCommand(code, conn);
                    cmd.ExecuteNonQuery();
                    int v = (Convert.ToInt32(Uyearayuz.labelbookcoin.Text) - Convert.ToInt32(fiyat.Text));
                    Uyearayuz.labelbookcoin.Text = v.ToString();
                    Uyearayuz.labelbookcoin.Refresh();
                    mailgonder();
                    string code2 = "update uye set bookCoin='" + Uyearayuz.labelbookcoin.Text + "' where uye_id='" + Uyegiris.uyeid + "'";
                    cmd = new SqlCommand(code2, conn);
                    cmd.ExecuteNonQuery();
                    conn.Close();
                        MessageBox.Show("E-Kitabınız mail adresinize gönderlidi.");
                    goster();
                    }
                    else
                    {
                        MessageBox.Show("Lütfen Tekrar Deneyin", "Satın Alma Başarısız", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    conn.Close();
                }
            }
            else
            {
                MessageBox.Show("YETERLİ MİKTARDA BOOKCOIN'E SAHİP DEĞİLSİNİZ");
                conn.Close();
            }
        }

        private void mailgonder() 
        {
            MailMessage mesaj = new MailMessage();
            mesaj.From = new MailAddress("ekutuphaneotom@gmail.com", "Kutuphaneniz");
            SmtpClient istemci = new SmtpClient();
            istemci.Port = 587;
            istemci.Host = "smtp.gmail.com";
            istemci.EnableSsl = true;
            istemci.Credentials = new NetworkCredential("ekutuphaneotom@gmail.com", "0159753*");
            mesaj.To.Add(maillabel.Text.ToString());
            mesaj.Subject = "E-kitap satin aldiniz";
            mesaj.IsBodyHtml = true;
            mesaj.Body = "E-Kitap satın alma işleminiz onaylanmıştır. E-Kitap için " + fiyat.Text + " bookCoin ödediniz. \n" + label6.Text+"\n İyi Günler Dileriz.";
            istemci.Send(mesaj);
            
        }

        private void EkitaPaneldg_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int k;
            try
            {     
                k = e.RowIndex;
                ekitapno.Text = ekitapBilgi.Rows[k].Cells[0].Value.ToString();
                ekitapad.Text = ekitapBilgi.Rows[k].Cells[1].Value.ToString();
                yazar.Text = ekitapBilgi.Rows[k].Cells[2].Value.ToString();
                yayinevi.Text = ekitapBilgi.Rows[k].Cells[3].Value.ToString();
                tur.Text = ekitapBilgi.Rows[k].Cells[4].Value.ToString();
                sayfasayisi.Text = ekitapBilgi.Rows[k].Cells[5].Value.ToString();
                konu.Text = ekitapBilgi.Rows[k].Cells[6].Value.ToString();
                kapak.ImageLocation = ekitapBilgi.Rows[k].Cells[7].Value.ToString();
                fiyat.Text = ekitapBilgi.Rows[k].Cells[8].Value.ToString();
                label6.Refresh();
                SatinAl.Enabled = true;
                bookCoinLogo.Visible = true;
            }
            catch (Exception)
            {
               
            }

            SqlCommand cmd2 = new SqlCommand("Select url from ekitap where ekitap_id='" + ekitapno.Text + "'", conn);
            conn.Open();
            label6.Text = (string)cmd2.ExecuteScalar();
            label6.Refresh();
            conn.Close();

        }

        private void ekitapSatınAl_Load(object sender, EventArgs e)
        {
            label4.Text = Uyegiris.uyeid.ToString();
            aramaCombo.Items.Add("E-Kitap Adı");
            aramaCombo.Items.Add("Yazar");
            aramaCombo.Items.Add("Yayınevi");
            aramaCombo.Items.Add("Tür");
            aramaTextBox.Visible = false;
            yazarArama.Visible = false;
            yayineviArama.Visible = false;
            turArama.Visible = false;
            goster();
            veriCek();
            
            conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB; AttachDbFilename =|DataDirectory|\kutuphane_veritabani.mdf; Initial Catalog = kutuphane_veritabani; Integrated Security=True");
            cmd = new SqlCommand("Select email from uye where uye_id = '" + label4.Text + "'", conn);
            SqlCommand cmd2 = new SqlCommand("Select url from ekitap where ekitap_id='"+ekitapno.Text+"'",conn);
            conn.Open();
            maillabel.Text = (string)cmd.ExecuteScalar();
            label6.Text = (string)cmd2.ExecuteScalar();
            conn.Close();
        }

        private void aramaCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            ara.Enabled = true;

            if (aramaCombo.Text == "Yazar")
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
            cmd = new SqlCommand("select yazar_ad, yazar_id from yazar", conn);
            SqlDataReader read = cmd.ExecuteReader();
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
            cmd = new SqlCommand("select yayinevi_ad, yayinevi_id from yayinevi", conn);
            SqlDataReader read = cmd.ExecuteReader();
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
            cmd = new SqlCommand("select tur_ad, tur_id from tur", conn);
            SqlDataReader read = cmd.ExecuteReader();
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
