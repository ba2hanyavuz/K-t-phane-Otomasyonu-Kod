
namespace KutuphaneReborn.Uye
{
    partial class uyeAyarlari
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(uyeAyarlari));
            this.guncelle = new Guna.UI2.WinForms.Guna2Button();
            this.uyenolabel = new System.Windows.Forms.Label();
            this.sifreTextBox = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.sifreLabel = new System.Windows.Forms.Label();
            this.kullaniciTextBox = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.kullaniciLabel = new System.Windows.Forms.Label();
            this.persNo = new System.Windows.Forms.Label();
            this.emailTextBox = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.emailLabel = new System.Windows.Forms.Label();
            this.telefonTextBox = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.telefonLabel = new System.Windows.Forms.Label();
            this.soyadTextBox = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.soyadLabel = new System.Windows.Forms.Label();
            this.adTextBox = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.adLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // guncelle
            // 
            this.guncelle.Animated = true;
            this.guncelle.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(55)))), ((int)(((byte)(252)))));
            this.guncelle.BorderThickness = 2;
            this.guncelle.CheckedState.Parent = this.guncelle;
            this.guncelle.CustomImages.Parent = this.guncelle;
            this.guncelle.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(204)))), ((int)(((byte)(12)))));
            this.guncelle.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold);
            this.guncelle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(55)))), ((int)(((byte)(252)))));
            this.guncelle.HoverState.Parent = this.guncelle;
            this.guncelle.Location = new System.Drawing.Point(366, 391);
            this.guncelle.Name = "guncelle";
            this.guncelle.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(55)))), ((int)(((byte)(252)))));
            this.guncelle.PressedDepth = 100;
            this.guncelle.ShadowDecoration.Parent = this.guncelle;
            this.guncelle.Size = new System.Drawing.Size(189, 59);
            this.guncelle.TabIndex = 158;
            this.guncelle.Text = "Güncelle";
            this.guncelle.Click += new System.EventHandler(this.guncelle_Click);
            // 
            // uyenolabel
            // 
            this.uyenolabel.AutoSize = true;
            this.uyenolabel.BackColor = System.Drawing.Color.Transparent;
            this.uyenolabel.Font = new System.Drawing.Font("Century Gothic", 13F, System.Drawing.FontStyle.Bold);
            this.uyenolabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(55)))), ((int)(((byte)(252)))));
            this.uyenolabel.Location = new System.Drawing.Point(337, 12);
            this.uyenolabel.Name = "uyenolabel";
            this.uyenolabel.Size = new System.Drawing.Size(0, 22);
            this.uyenolabel.TabIndex = 157;
            // 
            // sifreTextBox
            // 
            this.sifreTextBox.AllowDrop = true;
            this.sifreTextBox.BackColor = System.Drawing.Color.Gainsboro;
            this.sifreTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.sifreTextBox.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.sifreTextBox.ForeColor = System.Drawing.Color.Black;
            this.sifreTextBox.HintForeColor = System.Drawing.Color.Empty;
            this.sifreTextBox.HintText = "";
            this.sifreTextBox.isPassword = false;
            this.sifreTextBox.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(55)))), ((int)(((byte)(252)))));
            this.sifreTextBox.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(204)))), ((int)(((byte)(12)))));
            this.sifreTextBox.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(55)))), ((int)(((byte)(252)))));
            this.sifreTextBox.LineThickness = 3;
            this.sifreTextBox.Location = new System.Drawing.Point(598, 289);
            this.sifreTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.sifreTextBox.Name = "sifreTextBox";
            this.sifreTextBox.Size = new System.Drawing.Size(187, 30);
            this.sifreTextBox.TabIndex = 156;
            this.sifreTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // sifreLabel
            // 
            this.sifreLabel.AutoSize = true;
            this.sifreLabel.BackColor = System.Drawing.Color.Transparent;
            this.sifreLabel.Font = new System.Drawing.Font("Century Gothic", 13F, System.Drawing.FontStyle.Bold);
            this.sifreLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(55)))), ((int)(((byte)(252)))));
            this.sifreLabel.Location = new System.Drawing.Point(594, 258);
            this.sifreLabel.Name = "sifreLabel";
            this.sifreLabel.Size = new System.Drawing.Size(51, 22);
            this.sifreLabel.TabIndex = 155;
            this.sifreLabel.Text = "Şifre:";
            // 
            // kullaniciTextBox
            // 
            this.kullaniciTextBox.AllowDrop = true;
            this.kullaniciTextBox.BackColor = System.Drawing.Color.Gainsboro;
            this.kullaniciTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.kullaniciTextBox.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.kullaniciTextBox.ForeColor = System.Drawing.Color.Black;
            this.kullaniciTextBox.HintForeColor = System.Drawing.Color.Empty;
            this.kullaniciTextBox.HintText = "";
            this.kullaniciTextBox.isPassword = false;
            this.kullaniciTextBox.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(55)))), ((int)(((byte)(252)))));
            this.kullaniciTextBox.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(204)))), ((int)(((byte)(12)))));
            this.kullaniciTextBox.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(55)))), ((int)(((byte)(252)))));
            this.kullaniciTextBox.LineThickness = 3;
            this.kullaniciTextBox.Location = new System.Drawing.Point(598, 205);
            this.kullaniciTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.kullaniciTextBox.Name = "kullaniciTextBox";
            this.kullaniciTextBox.Size = new System.Drawing.Size(187, 30);
            this.kullaniciTextBox.TabIndex = 154;
            this.kullaniciTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // kullaniciLabel
            // 
            this.kullaniciLabel.AutoSize = true;
            this.kullaniciLabel.BackColor = System.Drawing.Color.Transparent;
            this.kullaniciLabel.Font = new System.Drawing.Font("Century Gothic", 13F, System.Drawing.FontStyle.Bold);
            this.kullaniciLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(55)))), ((int)(((byte)(252)))));
            this.kullaniciLabel.Location = new System.Drawing.Point(594, 163);
            this.kullaniciLabel.Name = "kullaniciLabel";
            this.kullaniciLabel.Size = new System.Drawing.Size(122, 22);
            this.kullaniciLabel.TabIndex = 153;
            this.kullaniciLabel.Text = "Kullanıcı Adı:";
            // 
            // persNo
            // 
            this.persNo.AutoSize = true;
            this.persNo.BackColor = System.Drawing.Color.Transparent;
            this.persNo.Font = new System.Drawing.Font("Century Gothic", 13F, System.Drawing.FontStyle.Bold);
            this.persNo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(55)))), ((int)(((byte)(252)))));
            this.persNo.Location = new System.Drawing.Point(226, 12);
            this.persNo.Name = "persNo";
            this.persNo.Size = new System.Drawing.Size(79, 22);
            this.persNo.TabIndex = 152;
            this.persNo.Text = "Üye No:";
            // 
            // emailTextBox
            // 
            this.emailTextBox.AllowDrop = true;
            this.emailTextBox.BackColor = System.Drawing.Color.Gainsboro;
            this.emailTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.emailTextBox.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.emailTextBox.ForeColor = System.Drawing.Color.Black;
            this.emailTextBox.HintForeColor = System.Drawing.Color.Empty;
            this.emailTextBox.HintText = "";
            this.emailTextBox.isPassword = false;
            this.emailTextBox.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(55)))), ((int)(((byte)(252)))));
            this.emailTextBox.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(204)))), ((int)(((byte)(12)))));
            this.emailTextBox.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(55)))), ((int)(((byte)(252)))));
            this.emailTextBox.LineThickness = 3;
            this.emailTextBox.Location = new System.Drawing.Point(99, 211);
            this.emailTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.Size = new System.Drawing.Size(247, 30);
            this.emailTextBox.TabIndex = 151;
            this.emailTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // emailLabel
            // 
            this.emailLabel.AutoSize = true;
            this.emailLabel.BackColor = System.Drawing.Color.Transparent;
            this.emailLabel.Font = new System.Drawing.Font("Century Gothic", 13F, System.Drawing.FontStyle.Bold);
            this.emailLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(55)))), ((int)(((byte)(252)))));
            this.emailLabel.Location = new System.Drawing.Point(25, 219);
            this.emailLabel.Name = "emailLabel";
            this.emailLabel.Size = new System.Drawing.Size(68, 22);
            this.emailLabel.TabIndex = 150;
            this.emailLabel.Text = "E-Mail:";
            // 
            // telefonTextBox
            // 
            this.telefonTextBox.AllowDrop = true;
            this.telefonTextBox.BackColor = System.Drawing.Color.Gainsboro;
            this.telefonTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.telefonTextBox.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.telefonTextBox.ForeColor = System.Drawing.Color.Black;
            this.telefonTextBox.HintForeColor = System.Drawing.Color.Empty;
            this.telefonTextBox.HintText = "";
            this.telefonTextBox.isPassword = false;
            this.telefonTextBox.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(55)))), ((int)(((byte)(252)))));
            this.telefonTextBox.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(204)))), ((int)(((byte)(12)))));
            this.telefonTextBox.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(55)))), ((int)(((byte)(252)))));
            this.telefonTextBox.LineThickness = 3;
            this.telefonTextBox.Location = new System.Drawing.Point(101, 289);
            this.telefonTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.telefonTextBox.Name = "telefonTextBox";
            this.telefonTextBox.Size = new System.Drawing.Size(245, 30);
            this.telefonTextBox.TabIndex = 149;
            this.telefonTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // telefonLabel
            // 
            this.telefonLabel.AutoSize = true;
            this.telefonLabel.BackColor = System.Drawing.Color.Transparent;
            this.telefonLabel.Font = new System.Drawing.Font("Century Gothic", 13F, System.Drawing.FontStyle.Bold);
            this.telefonLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(55)))), ((int)(((byte)(252)))));
            this.telefonLabel.Location = new System.Drawing.Point(14, 297);
            this.telefonLabel.Name = "telefonLabel";
            this.telefonLabel.Size = new System.Drawing.Size(79, 22);
            this.telefonLabel.TabIndex = 148;
            this.telefonLabel.Text = "Telefon:";
            // 
            // soyadTextBox
            // 
            this.soyadTextBox.AllowDrop = true;
            this.soyadTextBox.BackColor = System.Drawing.Color.Gainsboro;
            this.soyadTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.soyadTextBox.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.soyadTextBox.ForeColor = System.Drawing.Color.Black;
            this.soyadTextBox.HintForeColor = System.Drawing.Color.Empty;
            this.soyadTextBox.HintText = "";
            this.soyadTextBox.isPassword = false;
            this.soyadTextBox.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(55)))), ((int)(((byte)(252)))));
            this.soyadTextBox.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(204)))), ((int)(((byte)(12)))));
            this.soyadTextBox.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(55)))), ((int)(((byte)(252)))));
            this.soyadTextBox.LineThickness = 3;
            this.soyadTextBox.Location = new System.Drawing.Point(99, 141);
            this.soyadTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.soyadTextBox.Name = "soyadTextBox";
            this.soyadTextBox.Size = new System.Drawing.Size(247, 30);
            this.soyadTextBox.TabIndex = 147;
            this.soyadTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // soyadLabel
            // 
            this.soyadLabel.AutoSize = true;
            this.soyadLabel.BackColor = System.Drawing.Color.Transparent;
            this.soyadLabel.Font = new System.Drawing.Font("Century Gothic", 13F, System.Drawing.FontStyle.Bold);
            this.soyadLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(55)))), ((int)(((byte)(252)))));
            this.soyadLabel.Location = new System.Drawing.Point(25, 149);
            this.soyadLabel.Name = "soyadLabel";
            this.soyadLabel.Size = new System.Drawing.Size(70, 22);
            this.soyadLabel.TabIndex = 146;
            this.soyadLabel.Text = "Soyad:";
            // 
            // adTextBox
            // 
            this.adTextBox.AllowDrop = true;
            this.adTextBox.BackColor = System.Drawing.Color.Gainsboro;
            this.adTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.adTextBox.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.adTextBox.ForeColor = System.Drawing.Color.Black;
            this.adTextBox.HintForeColor = System.Drawing.Color.Empty;
            this.adTextBox.HintText = "";
            this.adTextBox.isPassword = false;
            this.adTextBox.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(55)))), ((int)(((byte)(252)))));
            this.adTextBox.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(204)))), ((int)(((byte)(12)))));
            this.adTextBox.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(55)))), ((int)(((byte)(252)))));
            this.adTextBox.LineThickness = 3;
            this.adTextBox.Location = new System.Drawing.Point(99, 73);
            this.adTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.adTextBox.Name = "adTextBox";
            this.adTextBox.Size = new System.Drawing.Size(245, 30);
            this.adTextBox.TabIndex = 145;
            this.adTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // adLabel
            // 
            this.adLabel.AutoSize = true;
            this.adLabel.BackColor = System.Drawing.Color.Transparent;
            this.adLabel.Font = new System.Drawing.Font("Century Gothic", 13F, System.Drawing.FontStyle.Bold);
            this.adLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(55)))), ((int)(((byte)(252)))));
            this.adLabel.Location = new System.Drawing.Point(53, 81);
            this.adLabel.Name = "adLabel";
            this.adLabel.Size = new System.Drawing.Size(40, 22);
            this.adLabel.TabIndex = 144;
            this.adLabel.Text = "Ad:";
            // 
            // uyeAyarlari
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(872, 544);
            this.Controls.Add(this.guncelle);
            this.Controls.Add(this.uyenolabel);
            this.Controls.Add(this.sifreTextBox);
            this.Controls.Add(this.sifreLabel);
            this.Controls.Add(this.kullaniciTextBox);
            this.Controls.Add(this.kullaniciLabel);
            this.Controls.Add(this.persNo);
            this.Controls.Add(this.emailTextBox);
            this.Controls.Add(this.emailLabel);
            this.Controls.Add(this.telefonTextBox);
            this.Controls.Add(this.telefonLabel);
            this.Controls.Add(this.soyadTextBox);
            this.Controls.Add(this.soyadLabel);
            this.Controls.Add(this.adTextBox);
            this.Controls.Add(this.adLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "uyeAyarlari";
            this.Text = "Üye Ayarları";
            this.Load += new System.EventHandler(this.uyeAyarlari_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Button guncelle;
        private System.Windows.Forms.Label uyenolabel;
        private Bunifu.Framework.UI.BunifuMaterialTextbox sifreTextBox;
        private System.Windows.Forms.Label sifreLabel;
        private Bunifu.Framework.UI.BunifuMaterialTextbox kullaniciTextBox;
        private System.Windows.Forms.Label kullaniciLabel;
        private System.Windows.Forms.Label persNo;
        private Bunifu.Framework.UI.BunifuMaterialTextbox emailTextBox;
        private System.Windows.Forms.Label emailLabel;
        private Bunifu.Framework.UI.BunifuMaterialTextbox telefonTextBox;
        private System.Windows.Forms.Label telefonLabel;
        private Bunifu.Framework.UI.BunifuMaterialTextbox soyadTextBox;
        private System.Windows.Forms.Label soyadLabel;
        private Bunifu.Framework.UI.BunifuMaterialTextbox adTextBox;
        private System.Windows.Forms.Label adLabel;
    }
}