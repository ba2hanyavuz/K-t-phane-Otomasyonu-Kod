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
    public partial class Uyepanel : Form
    {
        public Uyepanel()
        {
            InitializeComponent();
        }
        SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB; AttachDbFilename =|DataDirectory|\kutuphane_veritabani.mdf; Initial Catalog = kutuphane_veritabani; Integrated Security=True");
        SqlDataAdapter sda;
        SqlCommand cmd;
        DataTable dt;

        private void goster()
        {
            
            string sqlquery = "select uye_id as 'Üye ID', uye_ad as 'Üye Adı', uye_soyad as 'Üye Soyadı', dtarihi as 'D.Tarihi', telefon as 'Tel.', email as 'E-Mail', cinsiyet as 'Cinsiyet', kullanici_adi as 'Kullanıcı Adı', sifre as 'Şifre', uyelik_tarihi as 'Üyelik Tarihi' from uye";
            SqlCommand sqlcomm = new SqlCommand(sqlquery, conn);
            sda = new SqlDataAdapter(sqlcomm);
            dt = new DataTable();
            sda.Fill(dt);
            UyePaneldg.DataSource = dt;
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
                    MessageBox.Show("Geçerli bir telefon numarası giriniz", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (Email_Format_Kontrol(emailTextBox.Text) == false)
                {
                    emailTextBox.Text = "";
                    MessageBox.Show("Geçerli bir E-Mail adresi giriniz", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    DialogResult dr = MessageBox.Show("Kayıt eklemek istiyor musunuz ?", "Kayıt ekle", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                    if (dr == DialogResult.Yes)
                    {

                        DataSet ds = new DataSet();
                        ds.Clear();
                        SqlDataAdapter sda = new SqlDataAdapter("Insert INTO uye(uye_ad,uye_soyad,dtarihi,telefon,email,cinsiyet,kullanici_adi,sifre,uyelik_tarihi) values('" + adTextBox.Text + "','" + soyadTextBox.Text + "','" + dtarihi.Value.ToShortDateString() + "','" + telefonTextBox.Text + "','" + emailTextBox.Text + "','" + Cinsiyet + "','" + kullaniciTextBox.Text + "','" + sifreTextBox.Text + "','" + tarih.Text + "')", conn);
                        sda.Fill(ds);
                        conn.Close();
                        goster();
                    }
                    else
                    {
                        MessageBox.Show("Lütfen Tekrar Deneyin", "Kayıt Başarısız", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Üye Seçmediniz");
            }
        }

        private void Guncellebutton_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult dr = MessageBox.Show("Kaydı güncellemek istiyor musunuz ?", "Kayıt güncelleme", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (dr == DialogResult.Yes)
                {
                    conn.Open();
                cmd = new SqlCommand();
                cmd.Connection = conn;
                cmd.CommandText = "update uye set uye_ad= '" + adTextBox.Text + "'" + ",uye_soyad= '" + soyadTextBox.Text + "', dtarihi= '" + dtarihi.Value.ToShortDateString() + "',telefon='" + telefonTextBox.Text + "',email='" + emailTextBox.Text + "',cinsiyet='" + Cinsiyet + "',kullanici_adi='" + kullaniciTextBox.Text + "',sifre='" + sifreTextBox.Text + "' where uye_id= " + uyeNo.Text + "";
                cmd.ExecuteNonQuery();
                conn.Close();
                goster();
                }
                else
                {
                    MessageBox.Show("Lütfen Tekrar Deneyin", "Kayıt Başarısız", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

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
                DialogResult dr = MessageBox.Show("Kaydı silmek istiyor musunuz ?", "Kayıt Silme", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (dr == DialogResult.Yes)
                {
                    conn.Open();
                string code = "delete from uye where uye_id =" + Convert.ToInt32(uyeNo.Text) + "";
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

        private void Temizlebutton_Click(object sender, EventArgs e)
        {
            uyeNo.Text = "";
            uyelikTarih.Text = "";
            adTextBox.Text = "";
            soyadTextBox.Text = "";
            dtarihi.Value = new DateTime(1923, 10, 29);
            telefonTextBox.Text = "";
            emailTextBox.Text = "";
            kullaniciTextBox.Text = "";
            sifreTextBox.Text = "";
            tarih.Text = "";
        }

        private void Uyepanel_Load(object sender, EventArgs e)
        {
            aramaCombo.Items.Add("Üye ID");
            aramaCombo.Items.Add("Ad");
            aramaCombo.Items.Add("Soyad");
            aramaCombo.Items.Add("Cinsiyet");
            aramaCombo.Items.Add("Kullanıcı Adı");
            
            cinsiyetArama.Items.Add("Erkek");
            cinsiyetArama.Items.Add("Kadın");
            uyelikTarih.Text = Convert.ToString(DateTime.Now.ToShortDateString());
            goster();
            cinsiyetArama.Visible = false;
            aramaTextBox.Visible = false;
            DateTime dt = DateTime.Now;
            uyelikTarih.Text = Convert.ToString(dt.ToShortDateString());
        }

        private void Arabutton_Click(object sender, EventArgs e)
        {
            
                string kod = "";
                string sqlquery = "select uye_id as 'Üye ID', uye_ad as 'Üye Adı', uye_soyad as 'Üye Soyadı', dtarihi as 'D.Tarihi', telefon as 'Tel.', email as 'E-Mail', cinsiyet as 'Cinsiyet', kullanici_adi as 'Kullanıcı Adı', sifre as 'Şifre', uyelik_tarihi as 'Üyelik Tarihi' from uye ";
            try
            {
                if (aramaCombo.Text == "Üye ID")
                {
                    kod = sqlquery + " WHERE uye_id like '%" + aramaTextBox.Text + "%'";
                }
                else if (aramaCombo.Text == "Ad")
                {
                    kod = sqlquery + " WHERE uye_ad like '%" + aramaTextBox.Text + "%'";
                }
                else if (aramaCombo.Text == "Soyad")
                {
                    kod = sqlquery + " WHERE uye_soyad like '%" + aramaTextBox.Text + "%'";
                }
                else if (aramaCombo.Text == "Cinsiyet")
                {
                    kod = sqlquery + " WHERE cinsiyet like '%" + cinsiyetArama.Text + "%'";
                }
                else if (aramaCombo.Text == "Kullanıcı Adı")
                {
                    kod = sqlquery + " WHERE kullanici_adi like '%" + aramaTextBox.Text + "%'";
                }

            }
            catch (Exception)
            {

                
            }
                conn.Open();
                cmd = new SqlCommand(kod, conn);
                sda = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                sda.Fill(ds);
                UyePaneldg.DataSource = ds.Tables[0];
                conn.Close();
            
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
        private void UyePaneldg_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                k = e.RowIndex;
                uyeNo.Text = UyePaneldg.Rows[k].Cells[0].Value.ToString();
                adTextBox.Text = UyePaneldg.Rows[k].Cells[1].Value.ToString();
                soyadTextBox.Text = UyePaneldg.Rows[k].Cells[2].Value.ToString();
                dtarihi.Value = Convert.ToDateTime(UyePaneldg.Rows[k].Cells[3].Value);
                telefonTextBox.Text = UyePaneldg.Rows[k].Cells[4].Value.ToString();
                emailTextBox.Text = UyePaneldg.Rows[k].Cells[5].Value.ToString();
                Cinsiyet = UyePaneldg.Rows[k].Cells[6].Value.ToString();
                kullaniciTextBox.Text = UyePaneldg.Rows[k].Cells[7].Value.ToString();
                sifreTextBox.Text = UyePaneldg.Rows[k].Cells[8].Value.ToString();
                uyelikTarih.Text = UyePaneldg.Rows[k].Cells[9].Value.ToString();
                Silbutton.Enabled = true;
                Guncellebutton.Enabled = true;

                tarih.Text = Cinsiyet;
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
            if(aramaCombo.SelectedIndex == 3)
            {
                cinsiyetArama.Visible = true;
                aramaTextBox.Visible = false;
                cinsiyetArama.SelectedIndex = 0;
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
