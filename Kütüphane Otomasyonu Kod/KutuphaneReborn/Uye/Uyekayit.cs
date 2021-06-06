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
using System.Net.Mail;
using System.Text.RegularExpressions;

namespace KutuphaneReborn
{
    public partial class Uyekayit : Form
    {
        public Uyekayit()
        {
            InitializeComponent();
        }

        readonly SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB; AttachDbFilename =|DataDirectory|\kutuphane_veritabani.mdf; Initial Catalog = kutuphane_veritabani; Integrated Security=True");
        SqlDataAdapter sda;

        private void Geributton_Click(object sender, EventArgs e)
        {
            this.Hide();
            Giris giris = new Giris();
            giris.Show();
        }
        private void Temizle()
        {
            adTexBox.Text = "";
            soyadTextBox.Text = "";
            ErkekRadbutton.Checked = false;
            KadinRadButton.Checked = false;
            telefonTextBox.Text = "";
            emailTextBox.Text = "";
            kullaniciTextBox.Text = "";
            sifreTextBox.Text = "";
        }
        private void Temizlebutton_Click(object sender, EventArgs e)
        {
            Temizle();
        }

        private void Kayitbutton_Click(object sender, EventArgs e)
        {
            Kayit();
        }
        private void Uyekayit_Load(object sender, EventArgs e)
        {
            DateTime dt = DateTime.Now;

            Tarihlabel.Text = Convert.ToString(dt.ToShortDateString());
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
        private void Kayit() 
        {
            if (adTexBox.Text == "" || soyadTextBox.Text == "" || telefonTextBox.Text == "" || emailTextBox.Text == "" || KadinRadButton.Text == "" || ErkekRadbutton.Text == "" || kullaniciTextBox.Text == "" || sifreTextBox.Text == "")
            {
                MessageBox.Show("Gerekli boşlukları doldurunuz.", "Bilgi",MessageBoxButtons.OK,MessageBoxIcon.Information);
                
            }
            else if (TelefonFormatKontrol(telefonTextBox.Text)== false )
            {
                telefonTextBox.Text = "";
                MessageBox.Show("Geçerli bir telefon numarasi giriniz", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (Email_Format_Kontrol(emailTextBox.Text) == false)
                {
                    emailTextBox.Text = "";
                    MessageBox.Show("Geçerli bir E-Mail adresi giriniz", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
                else
                {
                    try
                    {
                        conn.Open();
                        SqlCommand tekrar = new SqlCommand("select count(*) from uye where email='" + emailTextBox.Text + "'", conn);
                        int sonuc = (int)tekrar.ExecuteScalar();
                        if (sonuc == 0)
                        {
                            
                            DataSet ds = new DataSet();

                            ds.Clear();
                            sda = new SqlDataAdapter("Insert INTO uye(uye_ad,uye_soyad,dtarihi,telefon,email,cinsiyet,kullanici_adi,sifre,uyelik_tarihi) values('" + adTexBox.Text + "','" + soyadTextBox.Text + "','" + dtarihi.Value.Date + "','" + telefonTextBox.Text + "','" + emailTextBox.Text + "','" + Cinsiyet + "','" + kullaniciTextBox.Text + "','" + sifreTextBox.Text + "','" + Tarihlabel.Text + "')", conn);
                            sda.Fill(ds);

                            MessageBox.Show("Kayıt başarılı");
                            Temizle();
                        }
                        if (sonuc > 0)
                        {
                            MessageBox.Show("Bu E-Mail adresi zaten kayıtlı", "Bilgi");
                        }
                        conn.Close();


                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
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

        private void SifreTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Kayit();
            }
        }
    }
}
