using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KutuphaneReborn
{
    public partial class sifremiUnuttum : Form
    {
        public sifremiUnuttum()
        {
            InitializeComponent();
        }
        SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB; AttachDbFilename =|DataDirectory|\kutuphane_veritabani.mdf; Initial Catalog = kutuphane_veritabani; Integrated Security=True");
        SqlCommand cmd;


        private void mailgonder()
        {
            MailMessage mesaj = new MailMessage();
            mesaj.From = new MailAddress("ekutuphaneotom@gmail.com", "Kutuphaneniz");
            SmtpClient istemci = new SmtpClient();
            istemci.Port = 587;
            istemci.Host = "smtp.gmail.com";
            istemci.EnableSsl = true;
            istemci.Credentials = new NetworkCredential("ekutuphaneotom@gmail.com", "0159753*");
            mesaj.To.Add(mailtextbox.Text);
            mesaj.Subject = "Şifreniz";
            mesaj.IsBodyHtml = true;
            mesaj.Body = "Lütfen bir daha şifrenizi unutmayın. :) Şifreniz = " + label1.Text;
            istemci.Send(mesaj);
        }

   
        private void gonderButton_Click(object sender, EventArgs e)
        {
            conn.Open();
            cmd = new SqlCommand("Select sifre From uye where email='" + mailtextbox.Text + "'", conn);
            label1.Text = (string)cmd.ExecuteScalar();
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                mailgonder();
                MessageBox.Show("Şifreniz mail adresinize gönderildi.");
            }
            else
            {
                MessageBox.Show("Veritabanında böyle bir mail adresi bulunamadı.");
            }
            conn.Close();
        }
    }
}
