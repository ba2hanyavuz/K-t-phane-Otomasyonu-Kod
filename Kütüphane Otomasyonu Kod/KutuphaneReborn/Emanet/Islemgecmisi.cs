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
    public partial class Islemgecmisi : Form
    {
        public Islemgecmisi()
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
            string sqlquery = "SELECT emanet_id as 'Emanet ID', kitap.kitap_id as 'Kitap ID', kitap_ad as 'Kitap Adı', uye.uye_id as 'Üye ID', uye_ad as 'Üye Adı', uye_soyad as 'Üye Soyadı', emanet_tarihi as 'Emanet Tarihi', teslim_tarihi as 'Teslim Tarihi' FROM emanet " +
                "INNER JOIN uye ON emanet.uye_id = uye.uye_id " +
                "INNER JOIN kitap on emanet.kitap_id = kitap.kitap_id " +
                "WHERE emanet_tarihi != '' AND teslim_tarihi != '' ";

            cmd = new SqlCommand(sqlquery, conn);
            sda = new SqlDataAdapter(cmd);
            dt = new DataTable();
            sda.Fill(dt);
            islemBilgi.DataSource = dt;
            conn.Close();
        }

        private void Islemgecmisi_Load(object sender, EventArgs e)
        {
            goster();
            aramaCombo.Items.Add("Emanet ID");
            aramaCombo.Items.Add("Kitap ID");
            aramaCombo.Items.Add("Kitap Adı");
            aramaCombo.Items.Add("Üye ID");
            aramaTextBox.Visible = false;
        }

        private void islemBilgi_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                emanetid.Text = islemBilgi.CurrentRow.Cells[0].Value.ToString();
                kitapno.Text = islemBilgi.CurrentRow.Cells[1].Value.ToString();
                kitapad.Text = islemBilgi.CurrentRow.Cells[2].Value.ToString();
                uyeid.Text = islemBilgi.CurrentRow.Cells[3].Value.ToString();
                uyead.Text = islemBilgi.CurrentRow.Cells[4].Value.ToString();
                uyesoyad.Text = islemBilgi.CurrentRow.Cells[5].Value.ToString();
                emanettarih.Text = islemBilgi.CurrentRow.Cells[6].Value.ToString();
                teslimtarih.Text = islemBilgi.CurrentRow.Cells[7].Value.ToString();
            }
            catch (Exception )
            {
            }
        }

        private void Arabutton_Click(object sender, EventArgs e)
        {
            string kod = "";
            string sqlquery = "SELECT emanet_id as 'Emanet ID', kitap.kitap_id as 'Kitap ID', kitap_ad as 'Kitap Adı', uye.uye_id as 'Üye ID', uye_ad as 'Üye Adı', uye_soyad as 'Üye Soyadı', emanet_tarihi as 'Emanet Tarihi', teslim_tarihi as 'Teslim Tarihi' FROM emanet " +
                "INNER JOIN uye ON emanet.uye_id = uye.uye_id " +
                "INNER JOIN kitap on emanet.kitap_id = kitap.kitap_id " +
                "WHERE emanet_tarihi != '' AND teslim_tarihi != '' AND ";
            if (aramaCombo.Text == "Emanet ID")
            {
                kod = sqlquery + " emanet_id like '%" + aramaTextBox.Text + "%'";
            }
            else if (aramaCombo.Text == "Kitap ID")
            {
                kod = sqlquery + " kitap.kitap_id like '%" + aramaTextBox.Text + "%'";
            }
            else if (aramaCombo.Text == "Kitap Adı")
            {
                kod = sqlquery + " kitap_ad like '%" + aramaTextBox.Text + "%'";
            }
            else if (aramaCombo.Text == "Üye ID")
            {
                kod = sqlquery + " uye.uye_id like '%" + aramaTextBox.Text + "%'";
            }


            conn.Open();
            cmd = new SqlCommand(kod, conn);
            sda = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            sda.Fill(ds);
            islemBilgi.DataSource = ds.Tables[0];
            conn.Close();
        }

        private void aramaCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            Arabutton.Enabled = true;
            aramaTextBox.Visible = true;
        }

        private void Listelebutton_Click(object sender, EventArgs e)
        {
            goster();
        }
    }
}
