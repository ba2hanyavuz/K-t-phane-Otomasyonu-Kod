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
    public partial class Giris : Form
    {
        public Giris()
        {
            InitializeComponent();
        }

        private void Admingiris_Click(object sender, EventArgs e)
        {
            this.Hide();
            Admingiris admin = new Admingiris();
            admin.Show();
        }

        private void Personelgiris_Click(object sender, EventArgs e)
        {
            this.Hide();
            Personelgiris Personel = new Personelgiris();
            Personel.Show();
        }

        private void Uyegiris_Click(object sender, EventArgs e)
        {
            this.Hide();
            Uyegiris Uyegiris = new Uyegiris();
            Uyegiris.Show();
        }

        private void Uyekayit_Click(object sender, EventArgs e)
        {
            this.Hide();
            Uyekayit Uyekayit = new Uyekayit();
            Uyekayit.Show();
        }

        private void Misafirgiris_Click(object sender, EventArgs e)
        {
            this.Hide();
            Misafirarayuz Misafiraz = new Misafirarayuz();
            Misafiraz.Show();
        }
    }
}
