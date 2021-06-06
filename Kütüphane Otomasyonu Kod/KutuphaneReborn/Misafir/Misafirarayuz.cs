using KutuphaneReborn.Misafir;
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
    public partial class Misafirarayuz : Form
    {
        public Misafirarayuz()
        {
            InitializeComponent();
        }

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
        private void Cikisbutton_Click(object sender, EventArgs e)
        {
            this.Hide();
            Giris giris = new Giris();
            giris.Show();
        }

        DateTime dt = new DateTime(0);
        private void Timer1_Tick(object sender, EventArgs e)
        {
            dt = dt.AddSeconds(1);
            label1.Text = dt.ToLongTimeString();
        }

        private void kitapGozat_Click(object sender, EventArgs e)
        {
            buyukLogo.Visible = false;
            hosgeldiniz.Visible = false;
            altForm(new kitapGozat());
        }

        private void ekitapGozat_Click(object sender, EventArgs e)
        {
            buyukLogo.Visible = false;
            hosgeldiniz.Visible = false;
            altForm(new ekitapGozat());
        }
    }
}
