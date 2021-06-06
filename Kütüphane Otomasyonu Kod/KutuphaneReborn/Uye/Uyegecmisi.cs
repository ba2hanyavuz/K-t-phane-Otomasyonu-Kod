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
    public partial class Uyegecmisi : Form
    {
        public Uyegecmisi()
        {
            InitializeComponent();
        }
        SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB; AttachDbFilename =|DataDirectory|\kutuphane_veritabani.mdf; Initial Catalog = kutuphane_veritabani; Integrated Security=True");
        SqlDataAdapter sda;
        DataTable dt;

        private void goster()
        {
            conn.Open();
            string sqlquery = "SELECT emanet_id as 'Emanet ID', kitap.kitap_id as 'Kitap ID', kitap_ad as 'Kitap Adı', emanet_tarihi as 'Emanet Tarihi', teslim_tarihi as 'Teslim Tarihi' FROM emanet " +
                "INNER JOIN uye ON emanet.uye_id = uye.uye_id " +
                "INNER JOIN kitap on emanet.kitap_id = kitap.kitap_id " +
                "WHERE uye.uye_id = '" + Uyegiris.uyeid + "'";

            SqlCommand sqlcomm = new SqlCommand(sqlquery, conn);
            sda = new SqlDataAdapter(sqlcomm);
            dt = new DataTable();
            sda.Fill(dt);
            gecmisBilgi.DataSource = dt;
            conn.Close();
        }

        private void Uyegecmisi_Load(object sender, EventArgs e)
        {
            goster();
        }
    }
}
