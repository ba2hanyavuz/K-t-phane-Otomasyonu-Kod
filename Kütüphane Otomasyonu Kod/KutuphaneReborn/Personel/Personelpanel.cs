using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KutuphaneReborn
{
    public partial class Personelpanel : Form
    {
        public Personelpanel()
        {
            InitializeComponent();
        }

        SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB; AttachDbFilename =|DataDirectory|\kutuphane_veritabani.mdf; Initial Catalog = kutuphane_veritabani; Integrated Security=True");
        SqlDataAdapter sda;
        SqlCommand cmd;
        DataTable dt;

        private void goster()
        {
            string sqlquery = "select personel_id as 'Personel ID', personel_ad as 'Personel Adı', personel_soyad as 'Personel Soyadı', dtarihi as 'D.Tarihi', telefon as 'Tel.', email as 'E-Mail', cinsiyet as 'Cinsiyet', kullanici_adi as 'Kullanıcı Adı', sifre as 'Şifre' from personel";
            SqlCommand sqlcomm = new SqlCommand(sqlquery, conn);
            sda = new SqlDataAdapter(sqlcomm);
            dt = new DataTable();
            sda.Fill(dt);
            PersonelPaneldg.DataSource = dt;
            conn.Close();
        }

        private void Eklebutton_Click(object sender, EventArgs e)
        {
            try
            {
                if (adTextBox.Text == "" || soyadTextBox.Text == "" || telefonTextBox.Text == "" || emailTextBox.Text == "" || KadinRadButton.Text == "" || ErkekRadbutton.Text == "" || kullaniciTextBox.Text == "" || sifreTextBox.Text == "")
                {
                    MessageBox.Show("Gerekli boşlukları doldurunuz.", "Bilgi");
                }
                else if (TelefonFormatKontrol(telefonTextBox.Text) == false)
                {
                    telefonTextBox.Text = "";
                    MessageBox.Show("Geçerli bir telefon numarasi giriniz", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (Email_Format_Kontrol(emailTextBox.Text) == false)
                {
                    emailTextBox.Text = "";
                    MessageBox.Show("Geçerli bir E-Mail adresi giriniz", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    DialogResult dr = MessageBox.Show("Kayit eklemek istiyor musunuz ?", "Kayit ekle", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                    if (dr == DialogResult.Yes)
                    {
                        conn.Open();
                string code = "Insert Into personel (personel_ad , personel_soyad, dtarihi, telefon, email, cinsiyet, kullanici_adi, sifre) Values ('" + adTextBox.Text + "','" + soyadTextBox.Text + "','" + dtarihi.Value.ToShortDateString() + "','" + telefonTextBox.Text + "','" + emailTextBox.Text + "','" + Cinsiyet + "','" + kullaniciTextBox.Text + "','" + sifreTextBox.Text + "'" + ")";
                cmd = new SqlCommand(code, conn);
                cmd.ExecuteNonQuery();
                conn.Close();
                goster();
                    }
                    else
                    {
                        MessageBox.Show("Luten Tekrar Deneyin", "Kayit basarisiz", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                conn.Close();
            }
        }

        private void Guncellebutton_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                cmd = new SqlCommand();
                cmd.Connection = conn;
                cmd.CommandText = "update personel set personel_ad= '" + adTextBox.Text + "'" + ",personel_soyad= '" + soyadTextBox.Text + "', dtarihi= '" + dtarihi.Value.ToShortDateString() + "',telefon='" + telefonTextBox.Text + "',email='" + emailTextBox.Text + "',cinsiyet='" + Cinsiyet + "',kullanici_adi='" + kullaniciTextBox.Text + "',sifre='" + sifreTextBox.Text + "' where personel_id= " + label2.Text + "";
                cmd.ExecuteNonQuery();
                conn.Close();
                goster();
            }
            catch (Exception)
            {
                MessageBox.Show("personel secmediniz");
            }
        }

        private void Listelebutton_Click(object sender, EventArgs e)
        {
            goster();
        }

        private void Silbutton_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                string code = "delete From personel where personel_id =" + label2.Text + "";
                cmd = new SqlCommand(code, conn);
                cmd.ExecuteNonQuery();
                conn.Close();
                goster();
            }
            catch (Exception)
            {
                MessageBox.Show("HATA");
            }
        }

        private void Temizlebutton_Click(object sender, EventArgs e)
        {
            label2.Text = "";
            adTextBox.Text = "";
            soyadTextBox.Text = "";
            dtarihi.Value = new DateTime(1923, 10, 29);
            telefonTextBox.Text = "";
            emailTextBox.Text = "";
            kullaniciTextBox.Text = "";
            sifreTextBox.Text = "";
        }

        private void Arabutton_Click(object sender, EventArgs e)
        {
            string kod = "";
            string kod2 = "select personel_id as 'Personel ID', personel_ad as 'Personel Adı', personel_soyad as 'Personel Soyadı', dtarihi as 'D.Tarihi', telefon as 'Tel.', email as 'E-Mail', cinsiyet as 'Cinsiyet', kullanici_adi as 'Kullanıcı Adı', sifre as 'Şifre' from personel ";


                if (aramaCombo.Text == "Personel ID")
                {
                    kod = kod2 + " WHERE personel_id like '%" + aramaTextBox.Text + "%'";
                }
                else if (aramaCombo.Text == "Ad")
                {
                    kod = kod2 + " WHERE personel_ad like '%" + aramaTextBox.Text + "%'";
                }
                else if (aramaCombo.Text == "Soyad")
                {
                    kod = kod2 + " WHERE personel_soyad like '%" + aramaTextBox.Text + "%'";
                }
                else if (aramaCombo.Text == "Cinsiyet")
                {
                    kod = kod2 + " WHERE cinsiyet like '%" + cinsiyetArama.Text + "%'";
                }
                else if (aramaCombo.Text == "Kullanıcı Adı")
                {
                    kod = kod2 + " WHERE kullanici_adi like '%" + aramaTextBox.Text + "%'";
                }


                conn.Open();
                cmd = new SqlCommand(kod, conn);
                sda = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                sda.Fill(ds);
                PersonelPaneldg.DataSource = ds.Tables[0];
                conn.Close();
            
            
            
        }

        private void Personelpanel_Load(object sender, EventArgs e)
        {
            aramaCombo.Items.Add("Personel ID");
            aramaCombo.Items.Add("Ad");
            aramaCombo.Items.Add("Soyad");
            aramaCombo.Items.Add("Cinsiyet");
            aramaCombo.Items.Add("Kullanıcı Adı");
            cinsiyetArama.Items.Add("Erkek");
            cinsiyetArama.Items.Add("Kadın");
            goster();
            cinsiyetArama.Visible = false;
            aramaTextBox.Visible = false;
        }
        string Cinsiyet;
        private void KadinRadButton_CheckedChanged(object sender, EventArgs e)
        {
            Cinsiyet = "Kadın";
        }

        private void ErkekRadbutton_CheckedChanged(object sender, EventArgs e)
        {
            Cinsiyet = "Erkek";
        }
        int k;
        private void PersonelPaneldg_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                k = e.RowIndex;
                label2.Text = PersonelPaneldg.Rows[k].Cells[0].Value.ToString();
                adTextBox.Text = PersonelPaneldg.Rows[k].Cells[1].Value.ToString();
                soyadTextBox.Text = PersonelPaneldg.Rows[k].Cells[2].Value.ToString();
                dtarihi.Value = Convert.ToDateTime(PersonelPaneldg.Rows[k].Cells[3].Value);
                telefonTextBox.Text = PersonelPaneldg.Rows[k].Cells[4].Value.ToString();
                emailTextBox.Text = PersonelPaneldg.Rows[k].Cells[5].Value.ToString();
                Cinsiyet = PersonelPaneldg.Rows[k].Cells[6].Value.ToString();
                kullaniciTextBox.Text = PersonelPaneldg.Rows[k].Cells[7].Value.ToString();
                sifreTextBox.Text = PersonelPaneldg.Rows[k].Cells[8].Value.ToString();
                Guncellebutton.Enabled = true;
                Silbutton.Enabled = true;
                label1.Text = Cinsiyet;
                if (Cinsiyet == "Kadın")
                {
                    KadinRadButton.Checked = true;
                    ErkekRadbutton.Checked = false;
                }
                else
                {
                    KadinRadButton.Checked = false;
                    ErkekRadbutton.Checked = true;
                }


            }
            catch (Exception)
            {
   
            }
        }

        private void aramaCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            Arabutton.Enabled = true;

            if(aramaCombo.Text == "Cinsiyet")
            {
                aramaTextBox.Visible = false;
                cinsiyetArama.Visible = true;
            }
            else
            {
                aramaTextBox.Visible = true;
                cinsiyetArama.Visible = false;
            }
        }
        public static bool Email_Format_Kontrol(string email)
        {
            try
            {
                MailAddress m = new MailAddress(email);
                return true;
            }
            catch
            {
                return false;
            }
        }
        public static bool TelefonFormatKontrol(string Telefon)
        {
            string RegexDesen = @"^(05(\d{9}))$";
            Match Eslesme = Regex.Match(Telefon, RegexDesen, RegexOptions.IgnoreCase);
            return Eslesme.Success;
        }

    }
}
