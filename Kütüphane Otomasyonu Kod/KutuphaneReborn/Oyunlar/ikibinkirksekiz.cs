using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KutuphaneReborn
{
    public partial class ikibinkirksekiz : Form
    {
       
        public ikibinkirksekiz()
        {
            InitializeComponent();
        }
        int n = 3;
        int rez;
        Boolean hareket = false;
        Button[,] buttonMatrix = new Button[6, 6];

        SqlConnection conn;
        SqlCommand kmt;

        private void guncelle()
        {
            conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB; AttachDbFilename =|DataDirectory|\kutuphane_veritabani.mdf; Initial Catalog = kutuphane_veritabani; Integrated Security=True");
            kmt = new SqlCommand();
            conn.Open();
            kmt.Connection = conn;
            kmt.CommandText = "update uye set bookCoin= '" + label2.Text + "' where uye_id= " + Uyegiris.uyeid + "";
            kmt.ExecuteNonQuery();
            conn.Close();
        }

        int v = 0;

        private void YeniOyun_Click(object sender, EventArgs e)
        {
            yenidenBasla();
        }
        private void oyunbitti()
        {
            int ok = 0;
            for (int i = 0; i <= n; i++)
            {
                for (int j = 0; j <= n; j++)
                {
                    if (buttonMatrix[i, j].Text == "")
                    {
                        ok = 1;
                    }
                }
            }
            if (ok == 0)
            {
                Boolean oyunbitti = true;
                for (int i = 0; i < n; i++)
                {
                    for (int j = 0; j < n; j++)
                    {
                        if (buttonMatrix[i, j].Text == buttonMatrix[i + 1, j].Text ||
                            buttonMatrix[i, j].Text == buttonMatrix[i, j + 1].Text)
                            oyunbitti = false;
                    }
                }
                if (buttonMatrix[3, 3].Text == buttonMatrix[3, 2].Text || buttonMatrix[3, 3].Text == buttonMatrix[2, 3].Text)
                {
                    oyunbitti = false;
                }

                if (oyunbitti == true)
                {

                    MessageBox.Show("5 bookcoin kazandin");
                    label2.Text = Convert.ToString(v + 5);
                    guncelle();
                    Uyearayuz.labelbookcoin.Text = label2.Text;
                    int s = Convert.ToInt32(Scor.Text);
                    string value1 = File.ReadAllText(Path.GetFullPath("Highscore.txt"));
                    if (s > Convert.ToInt32(value1))
                    {
                        File.WriteAllText(Path.GetFullPath("Highscore.txt"), String.Empty);
                        File.WriteAllText(Path.GetFullPath("Highscore.txt"), s.ToString());
                        Highscore.Text = s.ToString();
                    }
                    Scor.Text = "0";
                    yenidenBasla();

                }
            }
        }
        public void yeni()
        {

            Random rnd = new Random();
            int x, y;
            if (hareket == true)
            {
                do
                {
                    x = rnd.Next(0, 4);
                    y = rnd.Next(0, 4);
                } while (buttonMatrix[x, y].Text != "");
                int greu;
                greu = rnd.Next(0, 5);
                if (greu % 2 == 0)
                {
                    buttonMatrix[x, y].Text = "2";

                }
                else
                {
                    buttonMatrix[x, y].Text = "4";

                }
            }
            renkdegistir();
        }
        private void asagi()
        {

            for (int i = n - 1; i >= 0; i--)
            {
                int sonuc = i;


                for (int j = 0; j <= n; j++)
                {



                    for (sonuc = i; sonuc < n; sonuc++)
                    {
                        if (buttonMatrix[sonuc + 1, j].Text == "" && buttonMatrix[sonuc, j].Text != "")

                        {
                            buttonMatrix[sonuc + 1, j].Text = buttonMatrix[sonuc, j].Text;
                            buttonMatrix[sonuc, j].Text = "";
                            renkdegistir();
                            hareket = true;
                        }


                    }

                }
            }
        }
        private void yukari()
        {

            for (int i = 1; i < n; i++)
            {

                for (int j = 0; j <= n; j++)
                {
                    for (int sonuc = n; sonuc > 0; sonuc--)
                    {

                        if (buttonMatrix[sonuc - 1, j].Text == "" && buttonMatrix[sonuc, j].Text != "")
                        {
                            buttonMatrix[sonuc - 1, j].Text = buttonMatrix[sonuc, j].Text;
                            buttonMatrix[sonuc, j].Text = "";
                            hareket = true;
                            renkdegistir();
                        }

                    }

                }

            }
        }
        private void sag()
        {

            for (int i = 0; i <= n; i++)
            {
                for (int j = n - 1; j >= 0; j--)
                {

                    for (int sonuc = j; sonuc < n; sonuc++)
                    {
                        if (buttonMatrix[i, sonuc + 1].Text == "" && buttonMatrix[i, sonuc].Text != "")
                        {
                            buttonMatrix[i, sonuc + 1].Text = buttonMatrix[i, sonuc].Text;
                            buttonMatrix[i, sonuc].Text = "";
                            renkdegistir();
                            hareket = true;

                        }
                    }

                }
            }
        }
        private void sol()
        {

            for (int i = 0; i <= n; i++)
            {

                for (int j = 1; j <= n; j++)
                {

                    for (int sonuc = j; sonuc > 0; sonuc--)
                    {
                        if (buttonMatrix[i, sonuc - 1].Text == "" && buttonMatrix[i, sonuc].Text != "")
                        {
                            buttonMatrix[i, sonuc - 1].Text = buttonMatrix[i, sonuc].Text;
                            buttonMatrix[i, sonuc].Text = "";
                            renkdegistir();
                            hareket = true;
                        }
                    }

                }
            }
        }
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            switch (keyData)
            {

                case Keys.Down:
                    hareket = false;
                    asagi();
                    oyunbitti();
                    for (int i = n - 1; i >= 0; i--)
                    {
                        int sonuc = i;

                        for (int j = 0; j <= n; j++)
                        {

                            if (buttonMatrix[i + 1, j].Text == buttonMatrix[i, j].Text)
                            {


                                if (buttonMatrix[i, j].Text != "")
                                {
                                    int s = Convert.ToInt32(buttonMatrix[i + 1, j].Text);
                                    int m = Convert.ToInt32(buttonMatrix[i, j].Text);


                                    s = s + m;
                                    buttonMatrix[i + 1, j].Text = s.ToString();
                                    buttonMatrix[i, j].Text = "";
                                    renkdegistir();
                                    rez = Convert.ToInt32(Scor.Text) + Convert.ToInt32(buttonMatrix[i + 1, j].Text);
                                    Scor.Text = rez.ToString();
                                    hareket = true;
                                }

                            }

                        }
                    }
                    asagi();
                    if (hareket == true)
                        yeni();


                    break;
                case Keys.Up:
                    hareket = false;
                    yukari();
                    oyunbitti();
                    for (int i = 1; i <= n; i++)
                    {

                        for (int j = 0; j <= n; j++)
                        {


                            if (buttonMatrix[i - 1, j].Text == buttonMatrix[i, j].Text)
                            {


                                if (buttonMatrix[i, j].Text != "")
                                {
                                    int s = Convert.ToInt32(buttonMatrix[i - 1, j].Text);
                                    int m = Convert.ToInt32(buttonMatrix[i, j].Text);


                                    s = s + m;
                                    buttonMatrix[i - 1, j].Text = s.ToString();
                                    buttonMatrix[i, j].Text = "";
                                    rez = Convert.ToInt32(Scor.Text) + Convert.ToInt32(buttonMatrix[i - 1, j].Text);
                                    Scor.Text = rez.ToString();
                                    hareket = true;
                                }

                            }
                        }

                    }
                    yukari();

                    if (hareket == true)
                        yeni();
                    break;
                case Keys.Right:
                    hareket = false;
                    sag();
                    oyunbitti();
                    for (int i = 0; i <= n; i++)
                    {
                        for (int j = n - 1; j >= 0; j--)
                        {
                            if (buttonMatrix[i, j + 1].Text == buttonMatrix[i, j].Text)
                            {


                                if (buttonMatrix[i, j].Text != "")
                                {
                                    int s = Convert.ToInt32(buttonMatrix[i, j + 1].Text);
                                    int m = Convert.ToInt32(buttonMatrix[i, j].Text);


                                    s = s + m;
                                    buttonMatrix[i, j + 1].Text = s.ToString();
                                    buttonMatrix[i, j].Text = "";
                                    renkdegistir();
                                    rez = Convert.ToInt32(Scor.Text) + Convert.ToInt32(buttonMatrix[i, j + 1].Text);
                                    Scor.Text = rez.ToString();
                                    hareket = true;
                                }

                            }
                        }
                    }
                    sag();
                    yeni();
                    break;
                case Keys.Left:
                    hareket = false;
                    sol();
                    oyunbitti();
                    for (int i = 0; i <= n; i++)
                    {
                        for (int j = 1; j <= n; j++)
                        {


                            if (buttonMatrix[i, j - 1].Text == buttonMatrix[i, j].Text)
                            {
                                if (buttonMatrix[i, j].Text != "")
                                {
                                    int s = Convert.ToInt32(buttonMatrix[i, j - 1].Text);
                                    int m = Convert.ToInt32(buttonMatrix[i, j].Text);


                                    s = s + m;
                                    buttonMatrix[i, j - 1].Text = s.ToString();
                                    buttonMatrix[i, j].Text = "";
                                    renkdegistir();
                                    rez = Convert.ToInt32(Scor.Text) + Convert.ToInt32(buttonMatrix[i, j - 1].Text);
                                    Scor.Text = rez.ToString();
                                    hareket = true;
                                }

                            }
                        }
                    }

                    sol();
                    if (hareket == true)
                        yeni();

                    break;
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }
        private void renkdegistir()
        {

            for (int i = 0; i <= n; i++)
            {
                for (int j = 0; j <= n; j++)
                {
                    if (buttonMatrix[i, j].Text == "")
                    {
                        buttonMatrix[i, j].BackColor = Color.White;
                    }
                    if (buttonMatrix[i, j].Text == "2")
                    {
                        buttonMatrix[i, j].BackColor = Color.LightYellow;
                    }
                    if (buttonMatrix[i, j].Text == "4")
                    {
                        buttonMatrix[i, j].BackColor = Color.PeachPuff;
                    }
                    if (buttonMatrix[i, j].Text == "8")
                    {
                        buttonMatrix[i, j].BackColor = Color.Bisque;
                    }
                    if (buttonMatrix[i, j].Text == "16")
                    {
                        buttonMatrix[i, j].BackColor = Color.BurlyWood;
                    }
                    if (buttonMatrix[i, j].Text == "32")
                    {
                        buttonMatrix[i, j].BackColor = Color.LightPink;
                    }
                    if (buttonMatrix[i, j].Text == "64")
                    {
                        buttonMatrix[i, j].BackColor = Color.RosyBrown;
                    }
                    if (buttonMatrix[i, j].Text == "128")
                    {
                        buttonMatrix[i, j].BackColor = Color.IndianRed;
                    }
                    if (buttonMatrix[i, j].Text == "256")
                    {
                        buttonMatrix[i, j].BackColor = Color.Plum;
                    }
                    if (buttonMatrix[i, j].Text == "512")
                    {
                        buttonMatrix[i, j].BackColor = Color.SandyBrown;
                    }
                    if (buttonMatrix[i, j].Text == "1024")
                    {
                        buttonMatrix[i, j].BackColor = Color.Orange;
                    }
                    if (buttonMatrix[i, j].Text == "2048")
                    {
                        buttonMatrix[i, j].BackColor = Color.Red;
                    }
                }
            }

        }
        private void yenidenBasla()
        {
            for (int i = 0; i <= n; i++)
            {
                for (int j = 0; j <= n; j++)
                {
                    buttonMatrix[i, j].Text = "";
                    buttonMatrix[i, j].BackColor = Color.White;
                }
            }
            int s = Convert.ToInt32(Scor.Text);
            string value1 = File.ReadAllText(Path.GetFullPath("Highscore.txt"));
            if (s > Convert.ToInt32(value1))
            {
                File.WriteAllText(Path.GetFullPath("Highscore.txt"), String.Empty);
                File.WriteAllText(Path.GetFullPath("Highscore.txt"), s.ToString());
                Highscore.Text = s.ToString();
            }
            Scor.Text = "0";


            Random rnd = new Random();
            int x = rnd.Next(0, 3);
            int y = rnd.Next(0, 3);
            buttonMatrix[x, y].Text = "2";
            renkdegistir();

        }

        private void ikibinkirksekiz_Load(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB; AttachDbFilename =|DataDirectory|\kutuphane_veritabani.mdf; Initial Catalog = kutuphane_veritabani; Integrated Security=True");
            SqlCommand kmt = new SqlCommand("select bookCoin from uye where uye_id='" + Uyegiris.uyeid + "'", conn);
            conn.Open();
            v = Convert.ToInt32(kmt.ExecuteScalar());
            label1.Text = v.ToString();
            conn.Close();

            int yukari = 30, asagi = 100;
            int i, j;
            for (i = 0; i <= n; i++)
            {
                for (j = 0; j <= n; j++)
                {
                    buttonMatrix[i, j] = new Button();
                    buttonMatrix[i, j].Height = 80;
                    buttonMatrix[i, j].Width = 80;
                    buttonMatrix[i, j].Text = "";
                    buttonMatrix[i, j].FlatStyle = FlatStyle.Flat;
                    buttonMatrix[i, j].FlatAppearance.BorderColor = Color.Black;
                    buttonMatrix[i, j].FlatAppearance.BorderSize = 1;
                    buttonMatrix[i, j].Location = new Point(yukari, asagi);
                    buttonMatrix[i, j].Font = new Font("Georgia", 16);

                    yukari += 80;

                    this.Controls.Add(buttonMatrix[i, j]);
                }
                asagi += 80;
                yukari = 30;

            }
            Random rnd = new Random();
            int x = rnd.Next(0, 3);
            int y = rnd.Next(0, 3);
            buttonMatrix[x, y].Text = "2";
            renkdegistir();
            Highscore.Text = File.ReadAllText(Path.GetFullPath("Highscore.txt"));
        }
    }

}
