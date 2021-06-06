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
    public partial class Emanetistek : Form
    {
        public Emanetistek()
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
            string sqlquery = "SELECT emanet_id as 'Emanet ID', kitap.kitap_id as 'Kitap ID' , kitap_ad as 'Kitap Adı', uye.uye_id as 'Üye ID', uye_ad as 'Üye Adı', uye_soyad as 'Soyadı' FROM emanet " +
                "INNER JOIN uye ON emanet.uye_id = uye.uye_id " +
                "INNER JOIN kitap on emanet.kitap_id = kitap.kitap_id " +
                "WHERE emanet_tarihi = '' AND teslim_tarihi = '' ";
            SqlCommand sqlcomm = new SqlCommand(sqlquery, conn);
            sda = new SqlDataAdapter(sqlcomm);
            dt = new DataTable();
            sda.Fill(dt);
            istekBilgi.DataSource = dt;
            conn.Close();
        }

        public static int kitapAdet = 0;
        private void istekgonder_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult dr = MessageBox.Show("Emanet isteğini onaylıyor musunuz ?", "Onay", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (dr == DialogResult.Yes)
                {
                    conn.Open();
                string code = "UPDATE emanet SET emanet_tarihi = '" + emanettarih.Text + "' WHERE emanet_id = '" + emanetid.Text + "'";
                string code2 = "SELECT adet from kitap WHERE kitap_id = '" + Convert.ToInt32(kitapno.Text) + "'";
                cmd = new SqlCommand(code, conn);
                SqlCommand kmt = new SqlCommand(code2, conn);
                cmd.ExecuteNonQuery();
                kitapAdet = (int)kmt.ExecuteScalar();
                kitapAdet -= 1;
                string code3 = "UPDATE kitap SET adet = '" + kitapAdet + "' WHERE kitap_id = '" + Convert.ToInt32(kitapno.Text) + "'";
                SqlCommand cmd2 = new SqlCommand(code3, conn);
                cmd2.ExecuteNonQuery();
                conn.Close();
                goster();
                }
                else
                {
                    MessageBox.Show("Lütfen Tekrar Deneyin", "Onay", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                conn.Close();
            }
        }

        private void gericevir_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult dr = MessageBox.Show("İsteği geri çevirecek misiniz ?", "Geri Çevir", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (dr == DialogResult.Yes)
                {
                    conn.Open();
                string code2 = "DELETE FROM emanet WHERE emanet_id =" + emanetid.Text.ToString() + "";
                SqlCommand cmd2 = new SqlCommand(code2, conn);
                cmd2.ExecuteNonQuery();
                conn.Close();
                goster();
            }
                else
            {
                MessageBox.Show("Lütfen Tekrar Deneyin", "Geri Çevir", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void Emanetistek_Load(object sender, EventArgs e)
        {
            DateTime et = DateTime.Now;
            emanettarih.Text = Convert.ToString(et.ToShortDateString());
            aramaCombo.Items.Add("Emanet ID");
            aramaCombo.Items.Add("Kitap ID");
            aramaCombo.Items.Add("Kitap Adı");
            aramaCombo.Items.Add("Üye ID");
            aramaTextBox.Visible = false;
            goster();
        }

        private void istekBilgi_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                emanetid.Text = istekBilgi.CurrentRow.Cells[0].Value.ToString();
                kitapno.Text = istekBilgi.CurrentRow.Cells[1].Value.ToString();
                kitapad.Text = istekBilgi.CurrentRow.Cells[2].Value.ToString();
                uyeid.Text = istekBilgi.CurrentRow.Cells[3].Value.ToString();
                uyead.Text = istekBilgi.CurrentRow.Cells[4].Value.ToString();
                uyesoyad.Text = istekBilgi.CurrentRow.Cells[5].Value.ToString();
                istekonayla.Enabled = true;
                gericevir.Enabled = true;
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
                string sqlquery = "SELECT emanet_id as 'Emanet ID', kitap.kitap_id as 'Kitap ID' , kitap_ad as 'Kitap Adı', uye.uye_id as 'Üye ID', uye_ad as 'Üye Adı', uye_soyad as 'Soyadı' FROM emanet " +
                    "INNER JOIN uye ON emanet.uye_id = uye.uye_id " +
                    "INNER JOIN kitap on emanet.kitap_id = kitap.kitap_id " +
                    "WHERE emanet_tarihi = '' AND teslim_tarihi = '' AND ";
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
                istekBilgi.DataSource = ds.Tables[0];
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
