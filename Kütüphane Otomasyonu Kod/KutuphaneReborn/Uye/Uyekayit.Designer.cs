
namespace KutuphaneReborn
{
    partial class Uyekayit
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Uyekayit));
            this.guna2ControlBox1 = new Guna.UI2.WinForms.Guna2ControlBox();
            this.Geributton = new Bunifu.Framework.UI.BunifuImageButton();
            this.Tarihlabel = new MaterialSkin.Controls.MaterialLabel();
            this.ErkekRadbutton = new MaterialSkin.Controls.MaterialRadioButton();
            this.KadinRadButton = new MaterialSkin.Controls.MaterialRadioButton();
            this.sifreLabel = new System.Windows.Forms.Label();
            this.sifreTextBox = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.kullaniciTextBox = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.kullaniciLabel = new System.Windows.Forms.Label();
            this.emailLabel = new System.Windows.Forms.Label();
            this.emailTextBox = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.telefonTextBox = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.telefonLabel = new System.Windows.Forms.Label();
            this.cinsiyetLabel = new System.Windows.Forms.Label();
            this.soyadTextBox = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.dtarihLabel = new System.Windows.Forms.Label();
            this.soyadLabel = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.adTexBox = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.adLabel = new System.Windows.Forms.Label();
            this.dtarihi = new Bunifu.Framework.UI.BunifuDatepicker();
            this.Kayitbutton = new Bunifu.Framework.UI.BunifuThinButton2();
            this.Temizlebutton = new Bunifu.Framework.UI.BunifuThinButton2();
            ((System.ComponentModel.ISupportInitialize)(this.Geributton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2ControlBox1
            // 
            this.guna2ControlBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2ControlBox1.FillColor = System.Drawing.Color.DarkSlateBlue;
            this.guna2ControlBox1.HoverState.Parent = this.guna2ControlBox1;
            this.guna2ControlBox1.IconColor = System.Drawing.Color.White;
            this.guna2ControlBox1.Location = new System.Drawing.Point(1100, 0);
            this.guna2ControlBox1.Name = "guna2ControlBox1";
            this.guna2ControlBox1.ShadowDecoration.Parent = this.guna2ControlBox1;
            this.guna2ControlBox1.Size = new System.Drawing.Size(20, 20);
            this.guna2ControlBox1.TabIndex = 1;
            // 
            // Geributton
            // 
            this.Geributton.BackColor = System.Drawing.Color.Transparent;
            this.Geributton.Image = ((System.Drawing.Image)(resources.GetObject("Geributton.Image")));
            this.Geributton.ImageActive = null;
            this.Geributton.Location = new System.Drawing.Point(1058, 514);
            this.Geributton.Name = "Geributton";
            this.Geributton.Size = new System.Drawing.Size(50, 50);
            this.Geributton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Geributton.TabIndex = 30;
            this.Geributton.TabStop = false;
            this.Geributton.Zoom = 10;
            this.Geributton.Click += new System.EventHandler(this.Geributton_Click);
            // 
            // Tarihlabel
            // 
            this.Tarihlabel.AutoSize = true;
            this.Tarihlabel.Depth = 0;
            this.Tarihlabel.Font = new System.Drawing.Font("Roboto", 11F);
            this.Tarihlabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Tarihlabel.Location = new System.Drawing.Point(890, 419);
            this.Tarihlabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.Tarihlabel.Name = "Tarihlabel";
            this.Tarihlabel.Size = new System.Drawing.Size(75, 19);
            this.Tarihlabel.TabIndex = 71;
            this.Tarihlabel.Text = "tarihLabel";
            this.Tarihlabel.Visible = false;
            // 
            // ErkekRadbutton
            // 
            this.ErkekRadbutton.AutoSize = true;
            this.ErkekRadbutton.Depth = 0;
            this.ErkekRadbutton.Font = new System.Drawing.Font("Roboto", 10F);
            this.ErkekRadbutton.Location = new System.Drawing.Point(389, 202);
            this.ErkekRadbutton.Margin = new System.Windows.Forms.Padding(0);
            this.ErkekRadbutton.MouseLocation = new System.Drawing.Point(-1, -1);
            this.ErkekRadbutton.MouseState = MaterialSkin.MouseState.HOVER;
            this.ErkekRadbutton.Name = "ErkekRadbutton";
            this.ErkekRadbutton.Ripple = true;
            this.ErkekRadbutton.Size = new System.Drawing.Size(63, 30);
            this.ErkekRadbutton.TabIndex = 70;
            this.ErkekRadbutton.TabStop = true;
            this.ErkekRadbutton.Text = "Erkek";
            this.ErkekRadbutton.UseVisualStyleBackColor = true;
            this.ErkekRadbutton.CheckedChanged += new System.EventHandler(this.ErkekRadbutton_CheckedChanged);
            // 
            // KadinRadButton
            // 
            this.KadinRadButton.AutoSize = true;
            this.KadinRadButton.Depth = 0;
            this.KadinRadButton.Font = new System.Drawing.Font("Roboto", 10F);
            this.KadinRadButton.Location = new System.Drawing.Point(261, 202);
            this.KadinRadButton.Margin = new System.Windows.Forms.Padding(0);
            this.KadinRadButton.MouseLocation = new System.Drawing.Point(-1, -1);
            this.KadinRadButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.KadinRadButton.Name = "KadinRadButton";
            this.KadinRadButton.Ripple = true;
            this.KadinRadButton.Size = new System.Drawing.Size(64, 30);
            this.KadinRadButton.TabIndex = 69;
            this.KadinRadButton.TabStop = true;
            this.KadinRadButton.Text = "Kadın";
            this.KadinRadButton.UseVisualStyleBackColor = true;
            this.KadinRadButton.CheckedChanged += new System.EventHandler(this.KadinRadButton_CheckedChanged);
            // 
            // sifreLabel
            // 
            this.sifreLabel.AutoSize = true;
            this.sifreLabel.BackColor = System.Drawing.Color.Transparent;
            this.sifreLabel.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.sifreLabel.ForeColor = System.Drawing.Color.Black;
            this.sifreLabel.Location = new System.Drawing.Point(659, 276);
            this.sifreLabel.Name = "sifreLabel";
            this.sifreLabel.Size = new System.Drawing.Size(53, 23);
            this.sifreLabel.TabIndex = 68;
            this.sifreLabel.Text = "Şifre:";
            // 
            // sifreTextBox
            // 
            this.sifreTextBox.BackColor = System.Drawing.Color.Gainsboro;
            this.sifreTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.sifreTextBox.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold);
            this.sifreTextBox.ForeColor = System.Drawing.Color.Black;
            this.sifreTextBox.HintForeColor = System.Drawing.Color.Empty;
            this.sifreTextBox.HintText = "";
            this.sifreTextBox.isPassword = false;
            this.sifreTextBox.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(204)))), ((int)(((byte)(12)))));
            this.sifreTextBox.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(55)))), ((int)(((byte)(252)))));
            this.sifreTextBox.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(204)))), ((int)(((byte)(12)))));
            this.sifreTextBox.LineThickness = 3;
            this.sifreTextBox.Location = new System.Drawing.Point(742, 269);
            this.sifreTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.sifreTextBox.Name = "sifreTextBox";
            this.sifreTextBox.Size = new System.Drawing.Size(300, 30);
            this.sifreTextBox.TabIndex = 67;
            this.sifreTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.sifreTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.SifreTextBox_KeyDown);
            // 
            // kullaniciTextBox
            // 
            this.kullaniciTextBox.BackColor = System.Drawing.Color.Gainsboro;
            this.kullaniciTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.kullaniciTextBox.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold);
            this.kullaniciTextBox.ForeColor = System.Drawing.Color.Black;
            this.kullaniciTextBox.HintForeColor = System.Drawing.Color.Empty;
            this.kullaniciTextBox.HintText = "";
            this.kullaniciTextBox.isPassword = false;
            this.kullaniciTextBox.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(204)))), ((int)(((byte)(12)))));
            this.kullaniciTextBox.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(55)))), ((int)(((byte)(252)))));
            this.kullaniciTextBox.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(204)))), ((int)(((byte)(12)))));
            this.kullaniciTextBox.LineThickness = 3;
            this.kullaniciTextBox.Location = new System.Drawing.Point(742, 195);
            this.kullaniciTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.kullaniciTextBox.Name = "kullaniciTextBox";
            this.kullaniciTextBox.Size = new System.Drawing.Size(300, 30);
            this.kullaniciTextBox.TabIndex = 66;
            this.kullaniciTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // kullaniciLabel
            // 
            this.kullaniciLabel.AutoSize = true;
            this.kullaniciLabel.BackColor = System.Drawing.Color.Transparent;
            this.kullaniciLabel.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.kullaniciLabel.ForeColor = System.Drawing.Color.Black;
            this.kullaniciLabel.Location = new System.Drawing.Point(581, 202);
            this.kullaniciLabel.Name = "kullaniciLabel";
            this.kullaniciLabel.Size = new System.Drawing.Size(131, 23);
            this.kullaniciLabel.TabIndex = 65;
            this.kullaniciLabel.Text = "Kullanıcı Adı:";
            // 
            // emailLabel
            // 
            this.emailLabel.AutoSize = true;
            this.emailLabel.BackColor = System.Drawing.Color.Transparent;
            this.emailLabel.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.emailLabel.ForeColor = System.Drawing.Color.Black;
            this.emailLabel.Location = new System.Drawing.Point(639, 132);
            this.emailLabel.Name = "emailLabel";
            this.emailLabel.Size = new System.Drawing.Size(73, 23);
            this.emailLabel.TabIndex = 64;
            this.emailLabel.Text = "E-Mail:";
            // 
            // emailTextBox
            // 
            this.emailTextBox.BackColor = System.Drawing.Color.Gainsboro;
            this.emailTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.emailTextBox.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold);
            this.emailTextBox.ForeColor = System.Drawing.Color.Black;
            this.emailTextBox.HintForeColor = System.Drawing.Color.Empty;
            this.emailTextBox.HintText = "";
            this.emailTextBox.isPassword = false;
            this.emailTextBox.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(204)))), ((int)(((byte)(12)))));
            this.emailTextBox.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(55)))), ((int)(((byte)(252)))));
            this.emailTextBox.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(204)))), ((int)(((byte)(12)))));
            this.emailTextBox.LineThickness = 3;
            this.emailTextBox.Location = new System.Drawing.Point(742, 125);
            this.emailTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.Size = new System.Drawing.Size(300, 30);
            this.emailTextBox.TabIndex = 63;
            this.emailTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // telefonTextBox
            // 
            this.telefonTextBox.BackColor = System.Drawing.Color.Gainsboro;
            this.telefonTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.telefonTextBox.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold);
            this.telefonTextBox.ForeColor = System.Drawing.Color.Black;
            this.telefonTextBox.HintForeColor = System.Drawing.Color.Empty;
            this.telefonTextBox.HintText = "";
            this.telefonTextBox.isPassword = false;
            this.telefonTextBox.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(204)))), ((int)(((byte)(12)))));
            this.telefonTextBox.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(55)))), ((int)(((byte)(252)))));
            this.telefonTextBox.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(204)))), ((int)(((byte)(12)))));
            this.telefonTextBox.LineThickness = 3;
            this.telefonTextBox.Location = new System.Drawing.Point(742, 58);
            this.telefonTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.telefonTextBox.Name = "telefonTextBox";
            this.telefonTextBox.Size = new System.Drawing.Size(300, 30);
            this.telefonTextBox.TabIndex = 62;
            this.telefonTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // telefonLabel
            // 
            this.telefonLabel.AutoSize = true;
            this.telefonLabel.BackColor = System.Drawing.Color.Transparent;
            this.telefonLabel.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.telefonLabel.ForeColor = System.Drawing.Color.Black;
            this.telefonLabel.Location = new System.Drawing.Point(632, 65);
            this.telefonLabel.Name = "telefonLabel";
            this.telefonLabel.Size = new System.Drawing.Size(80, 23);
            this.telefonLabel.TabIndex = 61;
            this.telefonLabel.Text = "Telefon:";
            // 
            // cinsiyetLabel
            // 
            this.cinsiyetLabel.AutoSize = true;
            this.cinsiyetLabel.BackColor = System.Drawing.Color.Transparent;
            this.cinsiyetLabel.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cinsiyetLabel.ForeColor = System.Drawing.Color.Black;
            this.cinsiyetLabel.Location = new System.Drawing.Point(103, 202);
            this.cinsiyetLabel.Name = "cinsiyetLabel";
            this.cinsiyetLabel.Size = new System.Drawing.Size(88, 23);
            this.cinsiyetLabel.TabIndex = 60;
            this.cinsiyetLabel.Text = "Cinsiyet:";
            // 
            // soyadTextBox
            // 
            this.soyadTextBox.BackColor = System.Drawing.Color.Gainsboro;
            this.soyadTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.soyadTextBox.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold);
            this.soyadTextBox.ForeColor = System.Drawing.Color.Black;
            this.soyadTextBox.HintForeColor = System.Drawing.Color.Empty;
            this.soyadTextBox.HintText = "";
            this.soyadTextBox.isPassword = false;
            this.soyadTextBox.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(204)))), ((int)(((byte)(12)))));
            this.soyadTextBox.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(55)))), ((int)(((byte)(252)))));
            this.soyadTextBox.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(204)))), ((int)(((byte)(12)))));
            this.soyadTextBox.LineThickness = 3;
            this.soyadTextBox.Location = new System.Drawing.Point(221, 125);
            this.soyadTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.soyadTextBox.Name = "soyadTextBox";
            this.soyadTextBox.Size = new System.Drawing.Size(300, 30);
            this.soyadTextBox.TabIndex = 59;
            this.soyadTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // dtarihLabel
            // 
            this.dtarihLabel.AutoSize = true;
            this.dtarihLabel.BackColor = System.Drawing.Color.Transparent;
            this.dtarihLabel.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dtarihLabel.ForeColor = System.Drawing.Color.Black;
            this.dtarihLabel.Location = new System.Drawing.Point(105, 276);
            this.dtarihLabel.Name = "dtarihLabel";
            this.dtarihLabel.Size = new System.Drawing.Size(86, 23);
            this.dtarihLabel.TabIndex = 58;
            this.dtarihLabel.Text = "D. Tarihi:";
            // 
            // soyadLabel
            // 
            this.soyadLabel.AutoSize = true;
            this.soyadLabel.BackColor = System.Drawing.Color.Transparent;
            this.soyadLabel.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.soyadLabel.ForeColor = System.Drawing.Color.Black;
            this.soyadLabel.Location = new System.Drawing.Point(117, 132);
            this.soyadLabel.Name = "soyadLabel";
            this.soyadLabel.Size = new System.Drawing.Size(74, 23);
            this.soyadLabel.TabIndex = 57;
            this.soyadLabel.Text = "Soyad:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 487);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(111, 77);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 55;
            this.pictureBox1.TabStop = false;
            // 
            // adTexBox
            // 
            this.adTexBox.AllowDrop = true;
            this.adTexBox.BackColor = System.Drawing.Color.Gainsboro;
            this.adTexBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.adTexBox.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.adTexBox.ForeColor = System.Drawing.Color.Black;
            this.adTexBox.HintForeColor = System.Drawing.Color.Empty;
            this.adTexBox.HintText = "";
            this.adTexBox.isPassword = false;
            this.adTexBox.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(204)))), ((int)(((byte)(12)))));
            this.adTexBox.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(55)))), ((int)(((byte)(252)))));
            this.adTexBox.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(204)))), ((int)(((byte)(12)))));
            this.adTexBox.LineThickness = 3;
            this.adTexBox.Location = new System.Drawing.Point(221, 51);
            this.adTexBox.Margin = new System.Windows.Forms.Padding(4);
            this.adTexBox.Name = "adTexBox";
            this.adTexBox.Size = new System.Drawing.Size(300, 30);
            this.adTexBox.TabIndex = 54;
            this.adTexBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // adLabel
            // 
            this.adLabel.AutoSize = true;
            this.adLabel.BackColor = System.Drawing.Color.Transparent;
            this.adLabel.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.adLabel.ForeColor = System.Drawing.Color.Black;
            this.adLabel.Location = new System.Drawing.Point(149, 58);
            this.adLabel.Name = "adLabel";
            this.adLabel.Size = new System.Drawing.Size(42, 23);
            this.adLabel.TabIndex = 53;
            this.adLabel.Text = "Ad:";
            // 
            // dtarihi
            // 
            this.dtarihi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(55)))), ((int)(((byte)(252)))));
            this.dtarihi.BorderRadius = 0;
            this.dtarihi.ForeColor = System.Drawing.Color.White;
            this.dtarihi.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.dtarihi.FormatCustom = null;
            this.dtarihi.Location = new System.Drawing.Point(221, 269);
            this.dtarihi.Name = "dtarihi";
            this.dtarihi.Size = new System.Drawing.Size(300, 36);
            this.dtarihi.TabIndex = 145;
            this.dtarihi.Value = new System.DateTime(2021, 4, 27, 15, 57, 21, 216);
            // 
            // Kayitbutton
            // 
            this.Kayitbutton.ActiveBorderThickness = 1;
            this.Kayitbutton.ActiveCornerRadius = 20;
            this.Kayitbutton.ActiveFillColor = System.Drawing.Color.Gainsboro;
            this.Kayitbutton.ActiveForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(55)))), ((int)(((byte)(252)))));
            this.Kayitbutton.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(55)))), ((int)(((byte)(252)))));
            this.Kayitbutton.BackColor = System.Drawing.Color.Gainsboro;
            this.Kayitbutton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Kayitbutton.BackgroundImage")));
            this.Kayitbutton.ButtonText = "Kayıt Ol";
            this.Kayitbutton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Kayitbutton.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.Kayitbutton.ForeColor = System.Drawing.Color.Transparent;
            this.Kayitbutton.IdleBorderThickness = 1;
            this.Kayitbutton.IdleCornerRadius = 20;
            this.Kayitbutton.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(55)))), ((int)(((byte)(252)))));
            this.Kayitbutton.IdleForecolor = System.Drawing.Color.Gainsboro;
            this.Kayitbutton.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(55)))), ((int)(((byte)(252)))));
            this.Kayitbutton.Location = new System.Drawing.Point(475, 353);
            this.Kayitbutton.Margin = new System.Windows.Forms.Padding(5);
            this.Kayitbutton.Name = "Kayitbutton";
            this.Kayitbutton.Size = new System.Drawing.Size(199, 58);
            this.Kayitbutton.TabIndex = 174;
            this.Kayitbutton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Kayitbutton.Click += new System.EventHandler(this.Kayitbutton_Click);
            // 
            // Temizlebutton
            // 
            this.Temizlebutton.ActiveBorderThickness = 1;
            this.Temizlebutton.ActiveCornerRadius = 20;
            this.Temizlebutton.ActiveFillColor = System.Drawing.Color.Gainsboro;
            this.Temizlebutton.ActiveForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(55)))), ((int)(((byte)(252)))));
            this.Temizlebutton.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(55)))), ((int)(((byte)(252)))));
            this.Temizlebutton.BackColor = System.Drawing.Color.Gainsboro;
            this.Temizlebutton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Temizlebutton.BackgroundImage")));
            this.Temizlebutton.ButtonText = "Temizle";
            this.Temizlebutton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Temizlebutton.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.Temizlebutton.ForeColor = System.Drawing.Color.Transparent;
            this.Temizlebutton.IdleBorderThickness = 1;
            this.Temizlebutton.IdleCornerRadius = 20;
            this.Temizlebutton.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(55)))), ((int)(((byte)(252)))));
            this.Temizlebutton.IdleForecolor = System.Drawing.Color.Gainsboro;
            this.Temizlebutton.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(55)))), ((int)(((byte)(252)))));
            this.Temizlebutton.Location = new System.Drawing.Point(507, 436);
            this.Temizlebutton.Margin = new System.Windows.Forms.Padding(5);
            this.Temizlebutton.Name = "Temizlebutton";
            this.Temizlebutton.Size = new System.Drawing.Size(144, 53);
            this.Temizlebutton.TabIndex = 175;
            this.Temizlebutton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Temizlebutton.Click += new System.EventHandler(this.Temizlebutton_Click);
            // 
            // Uyekayit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(1120, 576);
            this.Controls.Add(this.Temizlebutton);
            this.Controls.Add(this.Kayitbutton);
            this.Controls.Add(this.dtarihi);
            this.Controls.Add(this.Tarihlabel);
            this.Controls.Add(this.ErkekRadbutton);
            this.Controls.Add(this.KadinRadButton);
            this.Controls.Add(this.sifreLabel);
            this.Controls.Add(this.sifreTextBox);
            this.Controls.Add(this.kullaniciTextBox);
            this.Controls.Add(this.kullaniciLabel);
            this.Controls.Add(this.emailLabel);
            this.Controls.Add(this.emailTextBox);
            this.Controls.Add(this.telefonTextBox);
            this.Controls.Add(this.telefonLabel);
            this.Controls.Add(this.cinsiyetLabel);
            this.Controls.Add(this.soyadTextBox);
            this.Controls.Add(this.dtarihLabel);
            this.Controls.Add(this.soyadLabel);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.adTexBox);
            this.Controls.Add(this.adLabel);
            this.Controls.Add(this.Geributton);
            this.Controls.Add(this.guna2ControlBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Uyekayit";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Üye Kayıt Ekranı";
            this.Load += new System.EventHandler(this.Uyekayit_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Geributton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox1;
        private Bunifu.Framework.UI.BunifuImageButton Geributton;
        private MaterialSkin.Controls.MaterialLabel Tarihlabel;
        private MaterialSkin.Controls.MaterialRadioButton ErkekRadbutton;
        private MaterialSkin.Controls.MaterialRadioButton KadinRadButton;
        private System.Windows.Forms.Label sifreLabel;
        private Bunifu.Framework.UI.BunifuMaterialTextbox sifreTextBox;
        private Bunifu.Framework.UI.BunifuMaterialTextbox kullaniciTextBox;
        private System.Windows.Forms.Label kullaniciLabel;
        private System.Windows.Forms.Label emailLabel;
        private Bunifu.Framework.UI.BunifuMaterialTextbox emailTextBox;
        private Bunifu.Framework.UI.BunifuMaterialTextbox telefonTextBox;
        private System.Windows.Forms.Label telefonLabel;
        private System.Windows.Forms.Label cinsiyetLabel;
        private Bunifu.Framework.UI.BunifuMaterialTextbox soyadTextBox;
        private System.Windows.Forms.Label dtarihLabel;
        private System.Windows.Forms.Label soyadLabel;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Bunifu.Framework.UI.BunifuMaterialTextbox adTexBox;
        private System.Windows.Forms.Label adLabel;
        private Bunifu.Framework.UI.BunifuDatepicker dtarihi;
        private Bunifu.Framework.UI.BunifuThinButton2 Kayitbutton;
        private Bunifu.Framework.UI.BunifuThinButton2 Temizlebutton;
    }
}