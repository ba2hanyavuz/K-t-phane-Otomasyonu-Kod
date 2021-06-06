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
    public partial class Beklenenkitap : Form
    {
        public Beklenenkitap()
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
            string sqlquery = "SELECT emanet_id as 'Emanet ID', kitap.kitap_id as 'Kitap ID', kitap_ad as 'Kitap Adı', uye.uye_id as 'Üye ID', uye_ad as 'Üye Adı', uye_soyad as 'Üye Soyadı', emanet_tarihi as 'Emanet Tarihi' FROM emanet " +
                "INNER JOIN uye ON emanet.uye_id = uye.uye_id " +
                "INNER JOIN kitap on emanet.kitap_id = kitap.kitap_id " +
                "WHERE teslim_tarihi = '' AND emanet_tarihi != '' ";

            SqlCommand sqlcomm = new SqlCommand(sqlquery, conn);
            sda = new SqlDataAdapter(sqlcomm);
            dt = new DataTable();
            sda.Fill(dt);
            teslimBilgi.DataSource = dt;
            conn.Close();
        }

        private void Beklenenkitap_Load(object sender, EventArgs e)
        {
            aramaCombo.Items.Add("Emanet ID");
            aramaCombo.Items.Add("Kitap ID");
            aramaCombo.Items.Add("Kitap Adı");
            aramaCombo.Items.Add("Üye ID");
            aramaTextBox.Visible = false;
            goster();
            DateTime dt = DateTime.Now;
            tarih.Text = Convert.ToString(dt.ToShortDateString());
        }
        public static int bookC = 0;
        public static int uyeBookCoin = 25;
        public static int kitapAdet = 0;
        private void teslimal_Click(object sender, EventArgs e)
        {  
            try
            {
                DialogResult dr = MessageBox.Show("Kitabı teslim alıcak mısınız ?", "Kitap Teslim", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (dr == DialogResult.Yes)
                {
                    conn.Open();
                string code = "UPDATE emanet SET teslim_tarihi = '" + tarih.Text + "' WHERE emanet_id = '" + emanetid.Text + "'";
                string code2 = "SELECT bookCoin from uye WHERE uye_id = '" + Convert.ToInt32(uyeid.Text) + "'";
                string code3 = "SELECT adet from kitap WHERE kitap_id = '" + Convert.ToInt32(kitapno.Text) + "'";
                cmd = new SqlCommand(code, conn);
                SqlCommand kmt = new SqlCommand(code2, conn);
                SqlCommand kmt2 = new SqlCommand(code3, conn);
                cmd.ExecuteNonQuery();
                bookC = (int)kmt.ExecuteScalar();
                bookC += uyeBookCoin;
                kitapAdet = (int)kmt2.ExecuteScalar();
                kitapAdet += 1;
                string code4 = "UPDATE uye SET bookCoin = '" + bookC + "' WHERE uye_id = '" + Convert.ToInt32(uyeid.Text) + "'";
                SqlCommand cmd2 = new SqlCommand(code4, conn);
                cmd2.ExecuteNonQuery();
                string code5 = "UPDATE kitap SET adet = '" + kitapAdet + "' WHERE kitap_id = '" + Convert.ToInt32(kitapno.Text) + "'";
                SqlCommand cmd3 = new SqlCommand(code5, conn);
                cmd3.ExecuteNonQuery();
                conn.Close();
                goster();
                }
                else
                {
                    MessageBox.Show("Lütfen Tekrar Deneyin", "Kitap Teslim", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                conn.Close();
            }
        }

        private void teslimBilgi_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                emanetid.Text = teslimBilgi.CurrentRow.Cells[0].Value.ToString();
                kitapno.Text = teslimBilgi.CurrentRow.Cells[1].Value.ToString();
                kitapad.Text = teslimBilgi.CurrentRow.Cells[2].Value.ToString();
                uyeid.Text = teslimBilgi.CurrentRow.Cells[3].Value.ToString();
                uyead.Text = teslimBilgi.CurrentRow.Cells[4].Value.ToString();
                uyesoyad.Text = teslimBilgi.CurrentRow.Cells[5].Value.ToString();
                emanettarih.Text = teslimBilgi.CurrentRow.Cells[6].Value.ToString();
                teslimal.Enabled = true;
            }
            catch (Exception)
            {
            }
        }

        private void Arabutton_Click(object sender, EventArgs e)
        {
            try
            {
                string kod = "";
                string sqlquery = "SELECT emanet_id as 'Emanet ID', kitap.kitap_id as 'Kitap ID', kitap_ad as 'Kitap Adı', uye.uye_id as 'Üye ID', uye_ad as 'Üye Adı', uye_soyad as 'Üye Soyadı', emanet_tarihi as 'Emanet Tarihi' FROM emanet " +
                    "INNER JOIN uye ON emanet.uye_id = uye.uye_id " +
                    "INNER JOIN kitap on emanet.kitap_id = kitap.kitap_id " +
                    "WHERE teslim_tarihi = '' AND emanet_tarihi != '' AND ";
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
                teslimBilgi.DataSource = ds.Tables[0];
                conn.Close();

            }
            catch (Exception)
            {

            }
            
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
