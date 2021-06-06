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

namespace KutuphaneReborn.Kitap
{
    public partial class ekitapGecmis : Form
    {
        public ekitapGecmis()
        {
            InitializeComponent();
        }
        SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB; AttachDbFilename =|DataDirectory|\kutuphane_veritabani.mdf; Initial Catalog = kutuphane_veritabani; Integrated Security=True");
        SqlDataAdapter sda;
        SqlCommand cmd;
        DataTable dt;

        private void goster()
        {
            conn.Open();
            string sqlquery = "SELECT satis_id as 'Satış ID', ekitap.ekitap_id as 'E-Kitap ID', ekitap_ad as 'E-Kitap Adı', uye.uye_id as 'Üye ID', uye_ad as 'Üye Adı', uye_soyad as 'Üye Soyadı', islem_tarihi as 'İşlem Tarihi', ekitapsatis.fiyat as 'Fiyat' FROM ekitapsatis " +
                "INNER JOIN uye ON ekitapsatis.uye_id = uye.uye_id " +
                "INNER JOIN ekitap on ekitapsatis.ekitap_id = ekitap.ekitap_id ";

            cmd = new SqlCommand(sqlquery, conn);
            sda = new SqlDataAdapter(cmd);
            dt = new DataTable();
            sda.Fill(dt);
            gecmisBilgi.DataSource = dt;
            conn.Close();
        }

        private void ekitapGecmis_Load(object sender, EventArgs e)
        {
            goster();
            aramaCombo.Items.Add("Satış ID");
            aramaCombo.Items.Add("Kitap ID");
            aramaCombo.Items.Add("E-Kitap Adı");
            aramaCombo.Items.Add("Üye ID");
            aramaCombo.Items.Add("Üye Adı");
        }

        private void gecmisBilgi_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                satisno.Text = gecmisBilgi.CurrentRow.Cells[0].Value.ToString();
                kitapno.Text = gecmisBilgi.CurrentRow.Cells[1].Value.ToString();
                kitapad.Text = gecmisBilgi.CurrentRow.Cells[2].Value.ToString();
                uyeid.Text = gecmisBilgi.CurrentRow.Cells[3].Value.ToString();
                uyead.Text = gecmisBilgi.CurrentRow.Cells[4].Value.ToString();
                uyesoyad.Text = gecmisBilgi.CurrentRow.Cells[5].Value.ToString();
                satisTarihi.Text = gecmisBilgi.CurrentRow.Cells[6].Value.ToString();
                fiyat.Text = gecmisBilgi.CurrentRow.Cells[7].Value.ToString();
                bookCoinLogo.Visible = true;
            }
            catch (Exception)
            {
              
            }
        }

        private void Arabutton_Click(object sender, EventArgs e)
        {
            string kod = "";
            string sqlquery = "SELECT satis_id as 'Satış ID', ekitap.ekitap_id as 'E-Kitap ID', ekitap_ad as 'E-Kitap Adı', uye.uye_id as 'Üye ID', uye_ad as 'Üye Adı', uye_soyad as 'Üye Soyadı', islem_tarihi as 'İşlem Tarihi', ekitapsatis.fiyat as 'Fiyat' FROM ekitapsatis " +
                "INNER JOIN uye ON ekitapsatis.uye_id = uye.uye_id " +
                "INNER JOIN ekitap on ekitapsatis.ekitap_id = ekitap.ekitap_id ";

            if (aramaCombo.Text == "Satış ID")
            {
                kod = sqlquery + " WHERE satis_id like '%" + aramaTextBox.Text + "%'";
            }
            else if (aramaCombo.Text == "Kitap ID")
            {
                kod = sqlquery + " WHERE ekitap.ekitap_id like '%" + aramaTextBox.Text + "%'";
            }
            else if (aramaCombo.Text == "E-Kitap Adı")
            {
                kod = sqlquery + " WHERE ekitap_ad like '%" + aramaTextBox.Text + "%'";
            }
            else if (aramaCombo.Text == "Üye ID")
            {
                kod = sqlquery + " WHERE uye.uye_id like '%" + aramaTextBox.Text + "%'";
            }
            else if (aramaCombo.Text == "Üye Adı")
            {
                kod = sqlquery + " WHERE uye.uye_ad like '%" + aramaTextBox.Text + "%'";
            }


            conn.Open();
            cmd = new SqlCommand(kod, conn);
            sda = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            sda.Fill(ds);
            gecmisBilgi.DataSource = ds.Tables[0];
            conn.Close();
        }

        private void aramaCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            Arabutton.Enabled = true;
        }

        private void Listelebutton_Click(object sender, EventArgs e)
        {
            goster();
        }
    }
}
