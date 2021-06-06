using KutuphaneReborn.Kitap;
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
    public partial class Personelarayuz : Form
    {
        public Personelarayuz()
        {
            InitializeComponent();
        }
        SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB; AttachDbFilename =|DataDirectory|\kutuphane_veritabani.mdf; Initial Catalog = kutuphane_veritabani; Integrated Security=True");
        SqlCommand cmd;

        private Form aktifForm = null;
        private void altForm(Form altForm)
        {
            if (aktifForm != null)
                aktifForm.Close();
            aktifForm = altForm;
            altForm.TopLevel = false;
            altForm.FormBorderStyle = FormBorderStyle.None;
            altForm.Dock = DockStyle.Fill;
            Anapanel.Controls.Add(altForm);
            Anapanel.Tag = altForm;

            altForm.Show();
        }

        DateTime dt = new DateTime(0);
        private void timer1_Tick(object sender, EventArgs e)
        {
            dt = dt.AddSeconds(1);
            sure.Text = dt.ToLongTimeString();
        }

        private void Kitapbutton_Click(object sender, EventArgs e)
        {
            buyukLogo.Visible = false;
            hosgeldiniz.Visible = false;
            altForm(new Kitappanel());
        }

        private void Ekitapbutton_Click(object sender, EventArgs e)
        {
            buyukLogo.Visible = false;
            hosgeldiniz.Visible = false;
            altForm(new Ekitapanel());
        }

        private void Uyebilgibutton_Click(object sender, EventArgs e)
        {
            buyukLogo.Visible = false;
            hosgeldiniz.Visible = false;
            altForm(new Uyepanel());
        }

        private void emanetButton_Click(object sender, EventArgs e)
        {
            buyukLogo.Visible = false;
            hosgeldiniz.Visible = false;
            altForm(new Emanetistek());
        }

        private void beklenenButton_Click(object sender, EventArgs e)
        {
            buyukLogo.Visible = false;
            hosgeldiniz.Visible = false;
            altForm(new Beklenenkitap ());
        }

        private void gecmisButton_Click(object sender, EventArgs e)
        {
            buyukLogo.Visible = false;
            hosgeldiniz.Visible = false;
            altForm(new Islemgecmisi());
        }

        private void ekitapGecmisButton_Click(object sender, EventArgs e)
        {
            buyukLogo.Visible = false;
            hosgeldiniz.Visible = false;
            altForm(new ekitapGecmis());
        }
        private void ayarButton_Click(object sender, EventArgs e)
        {
            buyukLogo.Visible = false;
            hosgeldiniz.Visible = false;
            altForm(new personelAyarlari());
        }

        
        private void Cikisbutton_Click(object sender, EventArgs e)
        {
            this.Hide();
            Giris giris = new Giris();
            giris.Show();
        }


       
        private void Personelarayuz_Load(object sender, EventArgs e)
        {
            personelid.Text = Personelgiris.personelid.ToString();
            
            conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB; AttachDbFilename =|DataDirectory|\kutuphane_veritabani.mdf; Initial Catalog = kutuphane_veritabani; Integrated Security=True");
            cmd = new SqlCommand("Select personel_ad from personel where personel_id = '" + personelid.Text + "'", conn);
            conn.Open();
            personeladi.Text = (string)cmd.ExecuteScalar();
            conn.Close();

        }

        
    }
}
