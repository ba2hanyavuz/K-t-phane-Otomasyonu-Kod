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
    public partial class Hafizaoyunu : Form
    {
        SqlConnection conn;
        SqlCommand kmt;

        Label firstclicked = null;
        Label secondclicked = null;
        Random random = new Random();
        List<string> icons = new List<string>()
        {
            "!","!","N","N",",",",","k","k",
            "b","b","v","v","t","t","z","z"
        };

        private void AssignIconsToSquares()
        {
            foreach (Control control in tableLayoutPanel1.Controls)
            {
                Label iconlabel = control as Label;
                if (iconlabel != null)
                {
                    int randomNumber = random.Next(icons.Count);
                    iconlabel.Text = icons[randomNumber];
                    iconlabel.ForeColor = iconlabel.BackColor;
                    icons.RemoveAt(randomNumber);
                }
            }
        }
        public Hafizaoyunu()
        {
            InitializeComponent();
            AssignIconsToSquares();
        }
        private void guncelle()
        {
            conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB; AttachDbFilename =|DataDirectory|\kutuphane_veritabani.mdf; Initial Catalog = kutuphane_veritabani; Integrated Security=True");
            kmt = new SqlCommand();
            conn.Open();
            kmt.Connection = conn;
            kmt.CommandText = "update uye set bookCoin= '" + label19.Text + "' where uye_id= " + Uyegiris.uyeid + "";
            kmt.ExecuteNonQuery();
            conn.Close();
        }
        private void winner()
        {
            foreach (Control control in tableLayoutPanel1.Controls)
            {
                Label iconlabel = control as Label;
                if (iconlabel != null)
                {
                    if (iconlabel.ForeColor == iconlabel.BackColor)
                        return;
                }
            }

            if (sayac <= 200 && sayac > 150)
            {
                MessageBox.Show("kaybettin");
                label19.Text = Convert.ToString(v + 1);
                guncelle();
            }
            else if (sayac <= 150 && sayac > 100)
            {
                MessageBox.Show("5 bookcoin kazandin");
                label19.Text = Convert.ToString(v + 5);
                guncelle();
            }
            else if (sayac <= 100 && sayac > 50)
            {
                MessageBox.Show("10 bookcoin kazandin");
                label19.Text = Convert.ToString(v + 10);
                guncelle();
            }
            else if (sayac <= 50 && sayac > 0)
            {
                MessageBox.Show("20 bookcoin kazandin");
                label19.Text = Convert.ToString(v + 20);
                guncelle();
            }
            Uyearayuz.labelbookcoin.Text = label19.Text;
            Close();
        }

        private void Baslat_Click(object sender, EventArgs e)
        {
            tableLayoutPanel1.Visible = true;
            timer2.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Stop();
            firstclicked.ForeColor = firstclicked.BackColor;
            secondclicked.ForeColor = secondclicked.BackColor;
            firstclicked = null;
            secondclicked = null;
        }

        int sayac = 0;
        private void timer2_Tick(object sender, EventArgs e)
        {
            if (sayac == 200)
            {
                timer2.Stop();
                MessageBox.Show("kaybettin");
                tableLayoutPanel1.Visible = false;
                sayac = 0;
                guna2ProgressBar1.Value = 0;
                Close();
            }
            guna2ProgressBar1.Value = sayac;
            sayac++;
            label17.Text = sayac.ToString();
        }

        private void label_Click(object sender, EventArgs e)
        {
            if (timer1.Enabled == true)
                return;
            Label clickedLabel = sender as Label;
            if (clickedLabel != null)
            {
                if (clickedLabel.ForeColor == Color.Black)
                    return;
                if (firstclicked == null)
                {
                    firstclicked = clickedLabel;
                    clickedLabel.ForeColor = Color.Black;
                    return;
                }
                secondclicked = clickedLabel;
                clickedLabel.ForeColor = Color.Black;
                winner();
                if (firstclicked.Text == secondclicked.Text)
                {
                    firstclicked = null;
                    secondclicked = null;
                    return;
                }
                timer1.Start();
            }
        }

        int v=0;
        private void Hafizaoyunu_Load(object sender, EventArgs e)
        {
            ToolTip toolTip1 = new ToolTip();
            toolTip1.AutoPopDelay = 5000;
            toolTip1.InitialDelay = 100;
            toolTip1.ReshowDelay = 500;
            toolTip1.SetToolTip(this.Baslat, "Kartları ters çevirerek doğru eşleri bulma.");
            SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB; AttachDbFilename =|DataDirectory|\kutuphane_veritabani.mdf; Initial Catalog = kutuphane_veritabani; Integrated Security=True");
            SqlCommand kmt = new SqlCommand("select bookCoin from uye where uye_id='" + Uyegiris.uyeid + "'", conn);
            conn.Open();
            v = Convert.ToInt32(kmt.ExecuteScalar());
            label18.Text = v.ToString();
            conn.Close();
        }
    }
}
