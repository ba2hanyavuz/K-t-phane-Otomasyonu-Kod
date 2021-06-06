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
    public partial class Kitappanel : Form
    {
        public Kitappanel()
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
            string sqlquery = "select kitap_id as 'Kitap ID',kitap_ad as 'Kitap Adı',yazar_ad as 'Yazar',yayinevi_ad as 'Yayınevi',basim_yili as 'Basım Yılı'," +
                "tur_ad as 'Tür',sayfa_sayisi as 'Sayfa Sayısı',ozet as 'Ozet',resim_yolu as 'Resim Yolu',adet as 'Adet' from kitap " +
                "inner join yazar on kitap.yazar=yazar.yazar_id " +
                "inner join yayinevi on kitap.yayinevi=yayinevi.yayinevi_id " +
                "inner join tur on tur.tur_id= kitap.tur";
            SqlCommand sqlcomm = new SqlCommand(sqlquery, conn);
            sda = new SqlDataAdapter(sqlcomm);
            dt = new DataTable();
            sda.Fill(dt);
            Kitap_Panel.DataSource = dt;
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
            Tur Tur = new Tur();
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
                string code = "Insert Into kitap (kitap_ad , yazar , yayinevi , basim_yili, tur , sayfa_sayisi , ozet , adet ) Values ('" + kitapTextBox.Text + "','" + Convert.ToInt32(yazarid) + "','" + Convert.ToInt32(yayineviid) + "','" + Convert.ToString(basimyiliTextBox.Text) + "','" + Convert.ToInt32(turid) + "','" + Convert.ToString(sayfasayisiTextBox.Text) + "','" + Konutextbox.Text + "','" + Convert.ToString(adetTextBox.Text) + "'" + ")";
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
                DialogResult dr = MessageBox.Show("Kaydı silmek istiyor musunuz ?", "Kayit silme", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (dr == DialogResult.Yes)
                {
                    conn.Open();
                string code = "delete From kitap where kitap_id =" + label1.Text + "";
                cmd = new SqlCommand(code, conn);
                cmd.ExecuteNonQuery();
                conn.Close();
                goster();
            }
                else
            {
                MessageBox.Show("Lütfen Tekrar Deneyin", "Kayıt Silme Başarısız", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
            catch (Exception)
            {
                MessageBox.Show("Bu kitap Bır emanet işleminde bulunmakta");
            }
        }

        private void Arabutton_Click(object sender, EventArgs e)
        {

            string kod = "";
            string sqlquery = "select kitap_id as 'Kitap ID',kitap_ad as 'Kitap Adı',yazar_ad as 'Yazar',yayinevi_ad as 'Yayınevi',basim_yili as 'Basım Yılı'," +
                "tur_ad as 'Tür',sayfa_sayisi as 'Sayfa Sayısı',ozet as 'Ozet',resim_yolu as 'Resim Yolu',adet as 'Adet' from kitap " +
                "inner join yazar on kitap.yazar=yazar.yazar_id " +
                "inner join yayinevi on kitap.yayinevi=yayinevi.yayinevi_id " +
                "inner join tur on tur.tur_id= kitap.tur";
            if (aramaCombo.Text == "Kitap Adı")
            {
                kod = sqlquery + " WHERE kitap_ad like '%" + aramaTextBox.Text + "%'";
            }
            else if (aramaCombo.Text == "Yazar")
            {
                kod = sqlquery + " WHERE yazar.yazar_ad like '%" + yazarArama.Text + "%'";
            }
            else if (aramaCombo.Text == "Yayınevi")
            {
                kod = sqlquery + " WHERE yayinevi.yayinevi_ad like '%" + yayineviArama.Text + "%'";
            }
            else if (aramaCombo.Text == "Basım Yılı")
            {
                kod = sqlquery + " WHERE basim_yili like '%" + aramaTextBox.Text + "%'";
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
            Kitap_Panel.DataSource = ds.Tables[0];
            conn.Close();
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
                cmd.CommandText = "update kitap set kitap_ad= '" + kitapTextBox.Text + "'" + ",yazar= '" + Convert.ToInt32(yazarid) + "', yayinevi= '" + Convert.ToInt32(yayineviid) + "',basim_yili='" + Convert.ToString(basimyiliTextBox.Text) + "',tur='" + Convert.ToInt32(turid) + "',sayfa_sayisi='" + sayfasayisiTextBox.Text + "',ozet='" + Konutextbox.Text + "',adet='" + adetTextBox.Text + "' where kitap_id= " + label1.Text + "";
                cmd.ExecuteNonQuery();
                conn.Close();
                goster();
            }
                else
            {
                MessageBox.Show("Lütfen Tekrar Deneyin", "Kaydı Güncelleme Başarısız", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
            catch (Exception)
            {
                MessageBox.Show("HATA");
            }
        }

        private void Temizlebutton_Click(object sender, EventArgs e)
        {
            label1.Text = "";
            kitapTextBox.Text = "";
            yazarCombo.SelectedIndex = 0;
            yayineviCombo.SelectedIndex = 0;
            turCombo.SelectedIndex = 0;
            basimyiliTextBox.Text = "";
 
            sayfasayisiTextBox.Text = "";
            Konutextbox.Text = "";
            kapak.ImageLocation = "";
            adetTextBox.Text = "";
        }

        private void Listelebutton_Click(object sender, EventArgs e)
        {
            goster();
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
                MessageBox.Show(ex.Message, "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
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
                kapak.Image.Save("Kitap/" + kitapTextBox.Text.ToString() + ".jpg");
                string code = "update kitap set resim_yolu='Kitap/" + kitapTextBox.Text + ".jpg' where kitap_id=" + label1.Text;
                cmd = new SqlCommand(code, conn);
                cmd.ExecuteNonQuery();
                conn.Close();
                goster();
                }
                else
                {
                    MessageBox.Show("Lütfen Tekrar Deneyin", "Resim Ekleme Başarısız", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("HATA.");
            }
        }

        private void Kitappanel_Load(object sender, EventArgs e)
        {
            aramaCombo.Items.Add("Kitap Adı");
            aramaCombo.Items.Add("Yazar");
            aramaCombo.Items.Add("Yayınevi");
            aramaCombo.Items.Add("Basım Yılı");
            aramaCombo.Items.Add("Tür");
            aramaCombo.Items.Add("Sayfa");
            aramaTextBox.Visible = false;
            yazarArama.Visible = false;
            yayineviArama.Visible = false;
            turArama.Visible = false;
            tur = turCombo;
            yazar = yazarCombo;
            yayinevi = yayineviCombo;
            turara = turArama;
            yayineviara = yayineviArama;
            yazarara = yazarArama;

            goster();
            veriCek();
        }
        public void yazarVeri()
        {
            conn.Open();
            cmd = new SqlCommand("select yazar_ad, yazar_id from yazar", conn);
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
        public void yayineviVeri()
        {
            conn.Open();
            cmd = new SqlCommand("select yayinevi_ad, yayinevi_id from yayinevi", conn);
            SqlDataReader read = cmd.ExecuteReader();
            while (read.Read())
            {
                yayineviCombo.Items.Add(read["yayinevi_ad"]);
                yayineviCombo.DisplayMember = (read["yayinevi_ad"].ToString());
                yayineviCombo.ValueMember = (read["yayinevi_id"].ToString());
                yayineviArama.Items.Add(read["yayinevi_ad"].ToString());
                yayineviArama.DisplayMember = (read["yayinevi_ad"].ToString());
                yayineviArama.ValueMember = (read["yayinevi_id"].ToString());
            }
            conn.Close();
        }
        public void turVeri()
        {
            conn.Open();
            cmd = new SqlCommand("select tur_ad, tur_id from tur", conn);
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

        public void veriCek()
        {
            yazarVeri();
            turVeri();
            yayineviVeri();
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

        private void yayineviCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            conn.Open();
            string q = "select yayinevi_id from yayinevi where yayinevi_ad = '" + yayineviCombo.SelectedItem + "'";
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
            
            if (aramaCombo.Text == "Yazar")
            {
                aramaTextBox.Visible = false;
                yazarArama.Visible = true;
                yayineviArama.Visible = false;
                turArama.Visible = false;
                yazarArama.SelectedIndex = 0;
                Arabutton.Enabled = true;
            }
            else if (aramaCombo.Text == "Yayınevi")
            {
                aramaTextBox.Visible = false;
                yazarArama.Visible = false;
                yayineviArama.Visible = true;
                turArama.Visible = false;
                yayineviArama.SelectedIndex = 0;
                Arabutton.Enabled = true;
            }
            else if (aramaCombo.Text == "Tür")
            {
                aramaTextBox.Visible = false;
                yazarArama.Visible = false;
                yayineviArama.Visible = false;
                turArama.Visible = true;
                turArama.SelectedIndex = 0;
                Arabutton.Enabled = true;
            }
            else
            {
                aramaTextBox.Visible = true;
                yazarArama.Visible = false;
                yayineviArama.Visible = false;
                turArama.Visible = false;
                Arabutton.Enabled = true;
            }
            

        }

        private void sayfasayisiTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void adetTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void basimyiliTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        int k;
        private void Kitap_Panel_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                k = e.RowIndex;
                label1.Text = Kitap_Panel.Rows[k].Cells[0].Value.ToString();
                kitapTextBox.Text = Kitap_Panel.Rows[k].Cells[1].Value.ToString();
                yazarCombo.Text = Kitap_Panel.Rows[k].Cells[2].Value.ToString();
                yayineviCombo.Text = Kitap_Panel.Rows[k].Cells[3].Value.ToString();
                basimyiliTextBox.Text = Kitap_Panel.Rows[k].Cells[4].Value.ToString();
                turCombo.Text = Kitap_Panel.Rows[k].Cells[5].Value.ToString();
                sayfasayisiTextBox.Text = Kitap_Panel.Rows[k].Cells[6].Value.ToString();
                Konutextbox.Text = Kitap_Panel.Rows[k].Cells[7].Value.ToString();
                kapak.ImageLocation = Kitap_Panel.Rows[k].Cells[8].Value.ToString();
                adetTextBox.Text = Kitap_Panel.Rows[k].Cells[9].Value.ToString();
                kapakSec.Enabled = true;
                Guncellebutton.Enabled = true;
                Silbutton.Enabled = true;

            }
            catch (Exception)
            {
            }
        }
    }
}
