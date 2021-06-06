using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KutuphaneReborn
{
    public partial class Adminarayuz : Form
    {
        public Adminarayuz()
        {
            InitializeComponent();
        }
        private Form aktifForm = null;
        private void AltForm(Form altForm)
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
        private void Timer1_Tick(object sender, EventArgs e)
        {
            dt = dt.AddSeconds(1);
            sure.Text = dt.ToLongTimeString();
        }

        public static int durum = 0;
   
        private void Kitapbutton_Click(object sender, EventArgs e)
        {
            durum = 1;
            
            buyukLogo.Visible = false;
            hosgeldiniz.Visible = false;
            AltForm(new Kitappanel());
        }

        private void Ekitapbutton_Click(object sender, EventArgs e)
        {
            durum = 2;
            
            buyukLogo.Visible = false;
            hosgeldiniz.Visible = false;
            AltForm(new Ekitapanel());
        }

        private void Uyebilgibutton_Click(object sender, EventArgs e)
        {
            buyukLogo.Visible = false;
            hosgeldiniz.Visible = false;
            AltForm(new Uyepanel());
        }

        private void Personelbutton_Click(object sender, EventArgs e)
        {
            buyukLogo.Visible = false;
            hosgeldiniz.Visible = false;
            AltForm(new Personelpanel());
        }
        private void Cikisbutton_Click(object sender, EventArgs e)
        {
            this.Hide();
            Giris giris = new Giris();
            giris.Show();
        }
    }
}
