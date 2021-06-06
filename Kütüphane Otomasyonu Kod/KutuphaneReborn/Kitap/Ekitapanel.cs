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
    public partial class Ekitapanel : Form
    {
        public Ekitapanel()
        {
            InitializeComponent();
        }

        SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB; AttachDbFilename =|DataDirectory|\kutuphane_veritabani.mdf; Initial Catalog = kutuphane_veritabani; Integrated Security=True");
        SqlDataAdapter sda;
        SqlCommand cmd;
        DataTable dt;
        String yazarid, yayineviid, turid;
        public static ComboBox tur;
        public static ComboBox yazar;
        public static ComboBox yayinevi;
        public static ComboBox yazarara;
        public static ComboBox yayineviara;
        public static ComboBox turara;


        private void goster()
        {
            
            string sqlquery = "select ekitap_id as 'eKitap ID',ekitap_ad as 'eKitap Adı',yazar_ad as 'Yazar',yayinevi_ad as 'Yayınevi'," +
                "tur_ad as 'Tür',sayfa_sayisi as 'Sayfa Sayısı',ozet as 'Ozet',resim_yolu as 'Resim Yolu',url as 'URL',fiyat as 'Fiyat' from ekitap " +
                "inner join yazar on ekitap.yazar=yazar.yazar_id " +
                "inner join yayinevi on ekitap.yayinevi=yayinevi.yayinevi_id " +
                "inner join tur on tur.tur_id= ekitap.tur";
            SqlCommand sqlcomm = new SqlCommand(sqlquery, conn);
            sda = new SqlDataAdapter(sqlcomm);
            dt = new DataTable();
            sda.Fill(dt);
            EkitaPaneldg.DataSource = dt;
            conn.Close();
        }

        private void Yazarekle_Click(object sender, EventArgs e)
        {
            Yazarekle yazarekle = new Yazarekle();
            yazarekle.Show();
        }

        private void Yayineviekle_Click(object sender, EventArgs e)
        {
            Yayinevi Yayinevi = new Yayinevi();
            Yayinevi.Show();
        }

        private void Turekle_Click(object sender, EventArgs e)
        {
            Tur Tur= new Tur();
            Tur.Show();
        }

        private void Eklebutton_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult dr = MessageBox.Show("Kayıt eklemek istiyor musunuz ?", "Kayıt Ekle", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (dr == DialogResult.Yes)
                {
                    conn.Open();
                string code = "Insert Into ekitap (ekitap_ad , yazar , yayinevi , tur , sayfa_sayisi , ozet , url , fiyat ) Values ('" + kitapTextBox.Text + "','" + Convert.ToInt32(yazarid) + "','" + Convert.ToInt32(yayineviid) + "','" + Convert.ToInt32(turid) + "','" + Convert.ToString(sayfasayisiTextBox.Text) + "','" + k_Konu.Text + "','" + url.Text + "','" + fiyat.Text + "'" + ")";
                cmd = new SqlCommand(code, conn);
                cmd.ExecuteNonQuery();
                conn.Close();
                goster();
                }
                else
                {
                    MessageBox.Show("Lütfen Tekrar Deneyin", "Kayıt Başarısız", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

            }
            catch (Exception)
            {
                MessageBox.Show("Lütfen boşlukları doldurunuz");
                conn.Close();
            }
        }

        private void Silbutton_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult dr = MessageBox.Show("Kaydı silmek istiyor musunuz ?", "Kayıt Silme", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (dr == DialogResult.Yes)
                {
                    conn.Open();
                string code = "delete From ekitap where ekitap_id =" + label1.Text + "";
                cmd = new SqlCommand(code, conn);
                cmd.ExecuteNonQuery();
                conn.Close();
                temizle();
                goster();
                }
                else
                {
                    MessageBox.Show("Lütfen Tekrar Deneyin", "Kayıt Silme Başarısız", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("HATA");
            }
        }

        private void Arabutton_Click(object sender, EventArgs e)
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
                else if (aramaCombo.Text == "Sayfa")
                {
                    kod = sqlquery + " WHERE sayfa_sayisi like '%" + aramaTextBox.Text + "%'";
                }

                conn.Open();
                cmd = new SqlCommand(kod, conn);
                sda = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                sda.Fill(ds);
                EkitaPaneldg.DataSource = ds.Tables[0];
                conn.Close();
            }
            catch (Exception)
            {

            }
            
        }

        private void Guncellebutton_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult dr = MessageBox.Show("Kaydı güncellemek istiyor musunuz ?", "Kayıt Güncelleme", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (dr == DialogResult.Yes)
                {
                    cmd = new SqlCommand();
                conn.Open();
                cmd.Connection = conn;
                cmd.CommandText = "update ekitap set ekitap_ad= '" + kitapTextBox.Text + "'" + ",yazar= '" + Convert.ToInt32(yazarid) + "', yayinevi= '" + Convert.ToInt32(yayineviid) + "',tur='" + Convert.ToInt32(turid) + "',sayfa_sayisi='" + sayfasayisiTextBox.Text + "',ozet='" + k_Konu.Text + "',url='" + url.Text + "',fiyat='" + fiyat.Text + "' where ekitap_id= " + label1.Text + "";
                cmd.ExecuteNonQuery();
                conn.Close();
                goster();
                }
                else
                {
                MessageBox.Show("Lütfen Tekrar Deneyin", "Kayıt başarısız", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
        }
            catch (Exception)
            {
                MessageBox.Show("HATA");
            }
        }
        private void temizle()
        {
            label1.Text = "";
            kitapTextBox.Text = "";
            yazarCombo.SelectedIndex = 0;
            yayinCombo.SelectedIndex = 0;
            turCombo.SelectedIndex = 0;
            sayfasayisiTextBox.Text = "";
            k_Konu.Text = "";
            kapak.ImageLocation = "";
            url.Text = "";
            fiyat.Text = "";
        }
        private void Temizlebutton_Click(object sender, EventArgs e)
        {
            temizle();
        }

        private void kapakSec_Click(object sender, EventArgs e)
        {
            try
            {
                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    kapak.ImageLocation = openFileDialog1.FileName;
                }
                kapakKaydet.Enabled = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                conn.Close();
            }
        }

        private void kapakKaydet_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult dr = MessageBox.Show("Kayda resim eklemek istiyor musunuz ?", "Resim Ekleme", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (dr == DialogResult.Yes)
                {
                    conn.Open();
                kapak.Image.Save("Ekitap/" + kitapTextBox.Text.ToString() + ".jpg");
                string code = "update ekitap set resim_yolu='Ekitap/" + kitapTextBox.Text + ".jpg' where ekitap_id=" + label1.Text;
                cmd = new SqlCommand(code, conn);
                cmd.ExecuteNonQuery();
                conn.Close();
                goster();
                }
                else
                {
                    MessageBox.Show("Lütfen Tekrar Deneyin", "Kayıt Başarısız", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("HATA");
            }
        }
        private void EkitaPaneldg_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                label1.Text = EkitaPaneldg.CurrentRow.Cells[0].Value.ToString();
                kitapTextBox.Text = EkitaPaneldg.CurrentRow.Cells[1].Value.ToString();
                yazarCombo.Text = EkitaPaneldg.CurrentRow.Cells[2].Value.ToString();
                yayinCombo.Text = EkitaPaneldg.CurrentRow.Cells[3].Value.ToString();
                turCombo.Text = EkitaPaneldg.CurrentRow.Cells[4].Value.ToString();
                sayfasayisiTextBox.Text = EkitaPaneldg.CurrentRow.Cells[5].Value.ToString();
                k_Konu.Text = EkitaPaneldg.CurrentRow.Cells[6].Value.ToString();
                kapak.ImageLocation = EkitaPaneldg.CurrentRow.Cells[7].Value.ToString();
                url.Text = EkitaPaneldg.CurrentRow.Cells[8].Value.ToString();
                fiyat.Text = EkitaPaneldg.CurrentRow.Cells[9].Value.ToString();
                kapakSec.Enabled = true;
                Silbutton.Enabled = true;
                Guncellebutton.Enabled = true;
            }
            catch (Exception)
            {
            }
        }

        private void Listelebutton_Click(object sender, EventArgs e)
        {
            goster();
        }
        private void yazarVeri()
        {
            conn.Open();
            cmd= new SqlCommand("select yazar_ad, yazar_id from yazar", conn);
            SqlDataReader read = cmd.ExecuteReader();
            while (read.Read())
            {
                yazarCombo.Items.Add(read["yazar_ad"].ToString());
                yazarCombo.DisplayMember = (read["yazar_ad"].ToString());
                yazarCombo.ValueMember = (read["yazar_id"].ToString());
                yazarArama.Items.Add(read["yazar_ad"].ToString());
                yazarArama.DisplayMember = (read["yazar_ad"].ToString());
                yazarArama.ValueMember = (read["yazar_id"].ToString());

            }
            conn.Close();
        }
        private void yayineviVeri()
        {
            conn.Open();
            cmd= new SqlCommand("select yayinevi_ad, yayinevi_id from yayinevi", conn);
            SqlDataReader read = cmd.ExecuteReader();
            while (read.Read())
            {
                yayinCombo.Items.Add(read["yayinevi_ad"]);
                yayinCombo.DisplayMember = (read["yayinevi_ad"].ToString());
                yayinCombo.ValueMember = (read["yayinevi_id"].ToString());
                yayineviArama.Items.Add(read["yayinevi_ad"].ToString());
                yayineviArama.DisplayMember = (read["yayinevi_ad"].ToString());
                yayineviArama.ValueMember = (read["yayinevi_id"].ToString());
            }
            conn.Close();
        }



        private void turVeri()
        {
            conn.Open();
            cmd= new SqlCommand("select tur_ad, tur_id from tur", conn);
            SqlDataReader read = cmd.ExecuteReader();
            while (read.Read())
            {
                turCombo.Items.Add(read["tur_ad"]);
                turCombo.DisplayMember = (read["tur_ad"].ToString());
                turCombo.ValueMember = (read["tur_id"].ToString());
                turArama.Items.Add(read["tur_ad"]);
                turArama.DisplayMember = (read["tur_ad"].ToString());
                turArama.ValueMember = (read["tur_id"].ToString());
            }
            conn.Close();
        }
        
        private void yazarCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            conn.Open();
            string q = "select yazar_id from yazar where yazar_ad = '" + yazarCombo.SelectedItem + "'";
            cmd = new SqlCommand(q, conn);
            SqlDataReader read = cmd.ExecuteReader();
            while (read.Read())
            {
                yazarid = read[0].ToString();
            }
            conn.Close();
        }

        private void yayinCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            conn.Open();
            string q = "select yayinevi_id from yayinevi where yayinevi_ad = '" + yayinCombo.SelectedItem + "'";
            cmd = new SqlCommand(q, conn);
            SqlDataReader read = cmd.ExecuteReader();
            while (read.Read())
            {
                yayineviid = read[0].ToString();
            }
            conn.Close();
        }

        private void turCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            conn.Open();
            string q = "select tur_id from tur where tur_ad = '" + turCombo.SelectedItem + "'";
            cmd = new SqlCommand(q, conn);
            SqlDataReader read = cmd.ExecuteReader();
            while (read.Read())
            {
                turid = read[0].ToString();
            }
            conn.Close();
        }

        private void aramaCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            Arabutton.Enabled = true;

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

        private void sayfasayisiTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void fiyat_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        public void veriCek()
        {
            yazarVeri();
            turVeri();
            yayineviVeri();
        }

        private void Ekitapanel_Load(object sender, EventArgs e)
        {
            aramaCombo.Items.Add("E-Kitap Adı");
            aramaCombo.Items.Add("Yazar");
            aramaCombo.Items.Add("Yayınevi");
            aramaCombo.Items.Add("Tür");
            aramaCombo.Items.Add("Sayfa");
            aramaTextBox.Visible = false;
            yazarArama.Visible = false;
            yayineviArama.Visible = false;
            turArama.Visible = false;
            goster();
            veriCek();
            tur = turCombo;
            yazar = yazarCombo;
            yayinevi = yayinCombo;
            turara = turArama;
            yayineviara = yayineviArama;
            yazarara = yazarArama;
        }
    }
}
