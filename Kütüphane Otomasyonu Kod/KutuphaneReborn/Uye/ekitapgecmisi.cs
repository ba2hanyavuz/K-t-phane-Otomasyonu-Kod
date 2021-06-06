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

namespace KutuphaneReborn.Uye
{
    public partial class ekitapgecmisi : Form
    {
        public ekitapgecmisi()
        {
            InitializeComponent();
        }
        SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB; AttachDbFilename =|DataDirectory|\kutuphane_veritabani.mdf; Initial Catalog = kutuphane_veritabani; Integrated Security=True");
        SqlDataAdapter sda;
        DataTable dt;

        private void goster()
        {
            string sqlquery = "SELECT satis_id as 'Satış ID', ekitap.ekitap_id as 'E-Kitap ID', ekitap_ad as 'E-Kitap Adı', islem_tarihi as 'İşlem Tarihi', ekitapsatis.fiyat as 'Fiyat' FROM ekitapsatis " +
                "INNER JOIN uye ON ekitapsatis.uye_id = uye.uye_id " +
                "INNER JOIN ekitap on ekitapsatis.ekitap_id = ekitap.ekitap_id " +
                "WHERE uye.uye_id = '" + Uyegiris.uyeid + "'";

            SqlCommand sqlcomm = new SqlCommand(sqlquery, conn);
            sda = new SqlDataAdapter(sqlcomm);
            dt = new DataTable();
            sda.Fill(dt);
            gecmisBilgi.DataSource = dt;
            conn.Close();
        }

        private void ekitapgecmisi_Load(object sender, EventArgs e)
        {
            goster();
        }
    }
}
