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
    public partial class Yayinevi : Form
    {
        public Yayinevi()
        {
            InitializeComponent();
        }
        SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB; AttachDbFilename =|DataDirectory|\kutuphane_veritabani.mdf; Initial Catalog = kutuphane_veritabani; Integrated Security=True");
        SqlDataAdapter sda;
        DataSet ds;
        SqlCommand cmd;

        private void goster()
        {
            try
            {
                ds = new DataSet();
                string code = "Select yayinevi_id as 'Yayınevi ID', yayinevi_ad as 'Yayınevi Adı' from yayinevi";
                conn.Open();
                sda = new SqlDataAdapter(code, conn);
                sda.Fill(ds, "yayinevi");
                Yayinevigd.DataSource = ds.Tables["yayinevi"];
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
                sda = new SqlDataAdapter("Insert INTO yayinevi(yayinevi_ad) values('" + adTextBox.Text + "')", conn);
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
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
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
                cmd.CommandText = "update yayinevi set yayinevi_ad= '" + adTextBox.Text + "' where yayinevi_id= " + label1.Text + "";
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
                string code = "delete From yayinevi where yayinevi_id =" + label1.Text + "";
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
        private void Yayinevigd_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            k = e.RowIndex;
            label1.Text = Yayinevigd.Rows[k].Cells[0].Value.ToString();
            adTextBox.Text = Yayinevigd.Rows[k].Cells[1].Value.ToString();
            sil.Visible = true;
            guncelle.Visible = true;
        }

        private void Yayinevi_Load(object sender, EventArgs e)
        {
            goster();
            label2.Text = Adminarayuz.durum.ToString();
        }

        
    }
}
