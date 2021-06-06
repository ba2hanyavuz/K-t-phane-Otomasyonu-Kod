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
    public partial class Tur : Form
    {
        public Tur()
        {
            InitializeComponent();
        }
        SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB; AttachDbFilename =|DataDirectory|\kutuphane_veritabani.mdf; Initial Catalog = kutuphane_veritabani; Integrated Security=True");

        DataSet ds;
        SqlDataAdapter sda;
        SqlCommand cmd;

        private void goster()
        {
            try
            {
                ds = new DataSet();
                string code = "Select tur_id as 'Tür ID', tur_ad as 'Tür Adı' from tur";
                conn.Open();
                sda = new SqlDataAdapter(code, conn);
                sda.Fill(ds, "tur");
                Turgd.DataSource = ds.Tables["tur"];
                sda.Dispose();
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button2);
                conn.Close();
            }
        }
        private void kitappaneltemizlik() 
        {
            Kitappanel.tur.Items.Clear();
            Kitappanel.yayinevi.Items.Clear();
            Kitappanel.yazar.Items.Clear();
            Kitappanel.yazarara.Items.Clear();
            Kitappanel.yayineviara.Items.Clear();
            Kitappanel.turara.Items.Clear();

        }
        private void ekitappaneltemizlik()
        {
            Ekitapanel.tur.Items.Clear();
            Ekitapanel.yayinevi.Items.Clear();
            Ekitapanel.yazar.Items.Clear();
            Ekitapanel.yazarara.Items.Clear();
            Ekitapanel.yayineviara.Items.Clear();
            Ekitapanel.turara.Items.Clear();
        }
        private void ekle_Click(object sender, EventArgs e)
        {
            try
            {
                if (adTextBox.Text == "")
                {
                    MessageBox.Show("Gerekli boşlukları doldurunuz.", "Bilgi");
                }
                ds = new DataSet();
                conn.Open();
                ds.Clear();
                sda = new SqlDataAdapter("Insert INTO tur(tur_ad) values('" + adTextBox.Text + "')", conn);
                sda.Fill(ds);
                conn.Close();
                MessageBox.Show("kayıt başarılı");
                adTextBox.Text = "";
                goster();
                if (label2.Text == "2")
                {
                    ekitappaneltemizlik();

                    var mfrm = (Ekitapanel)Application.OpenForms["Ekitapanel"];
                    if (mfrm != null)
                        mfrm.veriCek();
                }

                if (label2.Text == "1")
                {
                    kitappaneltemizlik();

                    var mfrm = (Kitappanel)Application.OpenForms["Kitappanel"];
                    if (mfrm != null)
                        mfrm.veriCek();

                }



            }
            catch (Exception)
            {
                MessageBox.Show("HATA");
            }
        }

        private void listele_Click(object sender, EventArgs e)
        {
            goster();
        }

        private void guncelle_Click(object sender, EventArgs e)
        {
            try
            {
                cmd = new SqlCommand();
                conn.Open();
                cmd.Connection = conn;
                cmd.CommandText = "update tur set tur_ad= '" + adTextBox.Text + "' where tur_id= " + label1.Text + "";
                cmd.ExecuteNonQuery();
                conn.Close();
                goster();
                if (label2.Text == "2")
                {
                    ekitappaneltemizlik();

                    var mfrm = (Ekitapanel)Application.OpenForms["Ekitapanel"];
                    if (mfrm != null)
                        mfrm.veriCek();
                }

                if (label2.Text == "1")
                {
                    kitappaneltemizlik();

                    var mfrm = (Kitappanel)Application.OpenForms["Kitappanel"];
                    if (mfrm != null)
                        mfrm.veriCek();

                }
            }
            catch (Exception)
            {
                MessageBox.Show("HATA");
            }
        }

        private void sil_Click(object sender, EventArgs e)
        {
            try
            {
                ds.Clear();
                conn.Open();
                string code = "delete From tur where tur_id =" + label1.Text + "";
                cmd = new SqlCommand(code, conn);
                cmd.ExecuteNonQuery();
                conn.Close();
                goster();
                if (label2.Text == "2")
                {

                    ekitappaneltemizlik();

                    var mfrm = (Ekitapanel)Application.OpenForms["Ekitapanel"];
                    if (mfrm != null)
                        mfrm.veriCek();
                }

                if (label2.Text == "1")
                {
                    kitappaneltemizlik();

                    var mfrm = (Kitappanel)Application.OpenForms["Kitappanel"];
                    if (mfrm != null)
                        mfrm.veriCek();

                }
            }
            catch (Exception)
            {
                MessageBox.Show("HATA");
            }
        }

        int k;
        private void Turgd_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            k = e.RowIndex;
            label1.Text = Turgd.Rows[k].Cells[0].Value.ToString();
            adTextBox.Text = Turgd.Rows[k].Cells[1].Value.ToString();
            sil.Visible = true;
            guncelle.Visible = true;
        }

        private void Tur_Load(object sender, EventArgs e)
        {
            goster();
            label2.Text = Adminarayuz.durum.ToString();
        }
    }
}
