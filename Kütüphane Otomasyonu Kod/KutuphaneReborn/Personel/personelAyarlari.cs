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
    public partial class personelAyarlari : Form
    {
        public personelAyarlari()
        {
            InitializeComponent();
        }
        SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB; AttachDbFilename =|DataDirectory|\kutuphane_veritabani.mdf; Initial Catalog = kutuphane_veritabani; Integrated Security=True");
        SqlCommand cmd;

        private void personelAyarlari_Load(object sender, EventArgs e)
        {
            persnolabel.Text = Personelgiris.personelid.ToString();
            conn.Open();
            SqlCommand kmt = new SqlCommand("Select * from personel where personel_id = '" + persnolabel.Text + "'", conn);
            SqlDataReader read = kmt.ExecuteReader();
            while (read.Read())
            {
                adTextBox.Text = read[1].ToString();
                soyadTextBox.Text = read[2].ToString();
                telefonTextBox.Text = read[4].ToString();
                emailTextBox.Text = read[5].ToString();
                kullaniciTextBox.Text = read[7].ToString();
                sifreTextBox.Text = read[8].ToString();

            }
            conn.Close();
        }

        private void guncelle_Click(object sender, EventArgs e)
        {
            try
            {
                if (adTextBox.Text == "" || soyadTextBox.Text == "" || telefonTextBox.Text == "" || emailTextBox.Text == "" || kullaniciTextBox.Text == "" || sifreTextBox.Text == "")
                {
                    MessageBox.Show("Gerekli boşlukları doldurunuz.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else if (TelefonFormatKontrol(telefonTextBox.Text) == false)
                {
                    
                    MessageBox.Show("Geçerli bir telefon numarasi giriniz", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (Email_Format_Kontrol(emailTextBox.Text) == false)
                {
                    
                    MessageBox.Show("Geçerli bir E-Mail adresi giriniz", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                cmd = new SqlCommand();
                conn.Open();
                cmd.Connection = conn;
                cmd.CommandText = "update personel set personel_ad= '" + adTextBox.Text + "'" + ",personel_soyad= '" + soyadTextBox.Text + "', telefon='" + telefonTextBox.Text + "',email='" + emailTextBox.Text + "',kullanici_adi='" + kullaniciTextBox.Text + "',sifre='" + sifreTextBox.Text + "' where personel_id= " + Personelgiris.personelid + "";
                cmd.ExecuteNonQuery();
                conn.Close();
                

            }
            catch (Exception)
            {
                MessageBox.Show("hatacık");

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
