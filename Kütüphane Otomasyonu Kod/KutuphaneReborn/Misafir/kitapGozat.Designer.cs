
namespace KutuphaneReborn.Misafir
{
    partial class kitapGozat
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(kitapGozat));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            this.ara = new Bunifu.Framework.UI.BunifuThinButton2();
            this.yazarArama = new System.Windows.Forms.ComboBox();
            this.turArama = new System.Windows.Forms.ComboBox();
            this.yayineviArama = new System.Windows.Forms.ComboBox();
            this.aramaTextBox = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.aramaCombo = new System.Windows.Forms.ComboBox();
            this.aramaLabel = new System.Windows.Forms.Label();
            this.kitapBilgi = new Guna.UI2.WinForms.Guna2DataGridView();
            this.konu = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.kapak = new System.Windows.Forms.PictureBox();
            this.sayfasayisi = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.tur = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.basimyili = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.yayinevi = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.yazar = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.kitapad = new System.Windows.Forms.Label();
            this.kitapAdiLabel = new System.Windows.Forms.Label();
            this.kitapno = new System.Windows.Forms.Label();
            this.kitapNoLabel = new System.Windows.Forms.Label();
            this.Listelebutton = new Guna.UI2.WinForms.Guna2Button();
            ((System.ComponentModel.ISupportInitialize)(this.kitapBilgi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kapak)).BeginInit();
            this.SuspendLayout();
            // 
            // ara
            // 
            this.ara.ActiveBorderThickness = 1;
            this.ara.ActiveCornerRadius = 20;
            this.ara.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(55)))), ((int)(((byte)(252)))));
            this.ara.ActiveForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(204)))), ((int)(((byte)(12)))));
            this.ara.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(55)))), ((int)(((byte)(252)))));
            this.ara.BackColor = System.Drawing.Color.Gainsboro;
            this.ara.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ara.BackgroundImage")));
            this.ara.ButtonText = "Ara";
            this.ara.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ara.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.ara.ForeColor = System.Drawing.Color.Transparent;
            this.ara.IdleBorderThickness = 2;
            this.ara.IdleCornerRadius = 20;
            this.ara.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(204)))), ((int)(((byte)(12)))));
            this.ara.IdleForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(55)))), ((int)(((byte)(252)))));
            this.ara.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(55)))), ((int)(((byte)(252)))));
            this.ara.Location = new System.Drawing.Point(547, 188);
            this.ara.Margin = new System.Windows.Forms.Padding(5);
            this.ara.Name = "ara";
            this.ara.Size = new System.Drawing.Size(125, 36);
            this.ara.TabIndex = 220;
            this.ara.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.ara.Click += new System.EventHandler(this.ara_Click);
            // 
            // yazarArama
            // 
            this.yazarArama.BackColor = System.Drawing.Color.GhostWhite;
            this.yazarArama.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.yazarArama.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.yazarArama.FormattingEnabled = true;
            this.yazarArama.Location = new System.Drawing.Point(547, 163);
            this.yazarArama.Name = "yazarArama";
            this.yazarArama.Size = new System.Drawing.Size(127, 23);
            this.yazarArama.Sorted = true;
            this.yazarArama.TabIndex = 219;
            // 
            // turArama
            // 
            this.turArama.BackColor = System.Drawing.Color.GhostWhite;
            this.turArama.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.turArama.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.turArama.FormattingEnabled = true;
            this.turArama.Location = new System.Drawing.Point(547, 163);
            this.turArama.Name = "turArama";
            this.turArama.Size = new System.Drawing.Size(127, 23);
            this.turArama.Sorted = true;
            this.turArama.TabIndex = 218;
            // 
            // yayineviArama
            // 
            this.yayineviArama.BackColor = System.Drawing.Color.GhostWhite;
            this.yayineviArama.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.yayineviArama.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.yayineviArama.FormattingEnabled = true;
            this.yayineviArama.Location = new System.Drawing.Point(547, 164);
            this.yayineviArama.Name = "yayineviArama";
            this.yayineviArama.Size = new System.Drawing.Size(127, 23);
            this.yayineviArama.Sorted = true;
            this.yayineviArama.TabIndex = 217;
            // 
            // aramaTextBox
            // 
            this.aramaTextBox.BackColor = System.Drawing.Color.Gainsboro;
            this.aramaTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.aramaTextBox.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.aramaTextBox.ForeColor = System.Drawing.Color.Black;
            this.aramaTextBox.HintForeColor = System.Drawing.Color.Black;
            this.aramaTextBox.HintText = "";
            this.aramaTextBox.isPassword = false;
            this.aramaTextBox.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(55)))), ((int)(((byte)(252)))));
            this.aramaTextBox.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(204)))), ((int)(((byte)(12)))));
            this.aramaTextBox.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(55)))), ((int)(((byte)(252)))));
            this.aramaTextBox.LineThickness = 3;
            this.aramaTextBox.Location = new System.Drawing.Point(545, 146);
            this.aramaTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.aramaTextBox.Name = "aramaTextBox";
            this.aramaTextBox.Size = new System.Drawing.Size(127, 35);
            this.aramaTextBox.TabIndex = 216;
            this.aramaTextBox.Tag = "";
            this.aramaTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // aramaCombo
            // 
            this.aramaCombo.BackColor = System.Drawing.Color.White;
            this.aramaCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.aramaCombo.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.aramaCombo.FormattingEnabled = true;
            this.aramaCombo.Location = new System.Drawing.Point(545, 122);
            this.aramaCombo.Name = "aramaCombo";
            this.aramaCombo.Size = new System.Drawing.Size(127, 23);
            this.aramaCombo.TabIndex = 215;
            this.aramaCombo.SelectedIndexChanged += new System.EventHandler(this.aramaCombo_SelectedIndexChanged);
            // 
            // aramaLabel
            // 
            this.aramaLabel.AutoSize = true;
            this.aramaLabel.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold);
            this.aramaLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(55)))), ((int)(((byte)(252)))));
            this.aramaLabel.Location = new System.Drawing.Point(470, 123);
            this.aramaLabel.Name = "aramaLabel";
            this.aramaLabel.Size = new System.Drawing.Size(58, 17);
            this.aramaLabel.TabIndex = 214;
            this.aramaLabel.Text = "Arama:";
            // 
            // kitapBilgi
            // 
            this.kitapBilgi.AllowUserToAddRows = false;
            this.kitapBilgi.AllowUserToDeleteRows = false;
            this.kitapBilgi.AllowUserToResizeColumns = false;
            this.kitapBilgi.AllowUserToResizeRows = false;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.White;
            this.kitapBilgi.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle7;
            this.kitapBilgi.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.kitapBilgi.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.kitapBilgi.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.kitapBilgi.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.kitapBilgi.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(204)))), ((int)(((byte)(12)))));
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(204)))), ((int)(((byte)(12)))));
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.kitapBilgi.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.kitapBilgi.ColumnHeadersHeight = 21;
            this.kitapBilgi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(204)))), ((int)(((byte)(12)))));
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.kitapBilgi.DefaultCellStyle = dataGridViewCellStyle9;
            this.kitapBilgi.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.kitapBilgi.EnableHeadersVisualStyles = false;
            this.kitapBilgi.GridColor = System.Drawing.Color.Gainsboro;
            this.kitapBilgi.Location = new System.Drawing.Point(0, 322);
            this.kitapBilgi.MultiSelect = false;
            this.kitapBilgi.Name = "kitapBilgi";
            this.kitapBilgi.ReadOnly = true;
            this.kitapBilgi.RowHeadersVisible = false;
            this.kitapBilgi.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.kitapBilgi.RowTemplate.ReadOnly = true;
            this.kitapBilgi.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.kitapBilgi.Size = new System.Drawing.Size(888, 261);
            this.kitapBilgi.TabIndex = 212;
            this.kitapBilgi.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Default;
            this.kitapBilgi.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.kitapBilgi.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.kitapBilgi.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.kitapBilgi.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.kitapBilgi.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.kitapBilgi.ThemeStyle.BackColor = System.Drawing.Color.Gainsboro;
            this.kitapBilgi.ThemeStyle.GridColor = System.Drawing.Color.Gainsboro;
            this.kitapBilgi.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(204)))), ((int)(((byte)(12)))));
            this.kitapBilgi.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.kitapBilgi.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.kitapBilgi.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.Black;
            this.kitapBilgi.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.kitapBilgi.ThemeStyle.HeaderStyle.Height = 21;
            this.kitapBilgi.ThemeStyle.ReadOnly = true;
            this.kitapBilgi.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.Gainsboro;
            this.kitapBilgi.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.kitapBilgi.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.kitapBilgi.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.kitapBilgi.ThemeStyle.RowsStyle.Height = 22;
            this.kitapBilgi.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(204)))), ((int)(((byte)(12)))));
            this.kitapBilgi.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.kitapBilgi.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.kitapBilgi_CellContentClick);
            // 
            // konu
            // 
            this.konu.BackColor = System.Drawing.Color.Gainsboro;
            this.konu.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.konu.Enabled = false;
            this.konu.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.konu.ForeColor = System.Drawing.Color.Black;
            this.konu.Location = new System.Drawing.Point(370, 10);
            this.konu.Multiline = true;
            this.konu.Name = "konu";
            this.konu.Size = new System.Drawing.Size(296, 105);
            this.konu.TabIndex = 211;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 13F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(55)))), ((int)(((byte)(252)))));
            this.label2.Location = new System.Drawing.Point(309, 6);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 22);
            this.label2.TabIndex = 210;
            this.label2.Text = "Konu:";
            // 
            // kapak
            // 
            this.kapak.Location = new System.Drawing.Point(680, 6);
            this.kapak.Name = "kapak";
            this.kapak.Size = new System.Drawing.Size(196, 304);
            this.kapak.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.kapak.TabIndex = 209;
            this.kapak.TabStop = false;
            // 
            // sayfasayisi
            // 
            this.sayfasayisi.AutoSize = true;
            this.sayfasayisi.Font = new System.Drawing.Font("Century Gothic", 13F, System.Drawing.FontStyle.Bold);
            this.sayfasayisi.ForeColor = System.Drawing.Color.Black;
            this.sayfasayisi.Location = new System.Drawing.Point(133, 243);
            this.sayfasayisi.Name = "sayfasayisi";
            this.sayfasayisi.Size = new System.Drawing.Size(0, 22);
            this.sayfasayisi.TabIndex = 208;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("Century Gothic", 13F, System.Drawing.FontStyle.Bold);
            this.label11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(55)))), ((int)(((byte)(252)))));
            this.label11.Location = new System.Drawing.Point(12, 243);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(115, 22);
            this.label11.TabIndex = 207;
            this.label11.Text = "Sayfa Sayısı:";
            // 
            // tur
            // 
            this.tur.AutoSize = true;
            this.tur.Font = new System.Drawing.Font("Century Gothic", 13F, System.Drawing.FontStyle.Bold);
            this.tur.ForeColor = System.Drawing.Color.Black;
            this.tur.Location = new System.Drawing.Point(133, 202);
            this.tur.Name = "tur";
            this.tur.Size = new System.Drawing.Size(0, 22);
            this.tur.TabIndex = 206;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 13F, System.Drawing.FontStyle.Bold);
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(55)))), ((int)(((byte)(252)))));
            this.label9.Location = new System.Drawing.Point(12, 202);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(40, 22);
            this.label9.TabIndex = 205;
            this.label9.Text = "Tür:";
            // 
            // basimyili
            // 
            this.basimyili.AutoSize = true;
            this.basimyili.Font = new System.Drawing.Font("Century Gothic", 13F, System.Drawing.FontStyle.Bold);
            this.basimyili.ForeColor = System.Drawing.Color.Black;
            this.basimyili.Location = new System.Drawing.Point(133, 162);
            this.basimyili.Name = "basimyili";
            this.basimyili.Size = new System.Drawing.Size(0, 22);
            this.basimyili.TabIndex = 204;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 13F, System.Drawing.FontStyle.Bold);
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(55)))), ((int)(((byte)(252)))));
            this.label7.Location = new System.Drawing.Point(12, 162);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(94, 22);
            this.label7.TabIndex = 203;
            this.label7.Text = "Basım Yılı:";
            // 
            // yayinevi
            // 
            this.yayinevi.AutoSize = true;
            this.yayinevi.Font = new System.Drawing.Font("Century Gothic", 13F, System.Drawing.FontStyle.Bold);
            this.yayinevi.ForeColor = System.Drawing.Color.Black;
            this.yayinevi.Location = new System.Drawing.Point(133, 122);
            this.yayinevi.Name = "yayinevi";
            this.yayinevi.Size = new System.Drawing.Size(0, 22);
            this.yayinevi.TabIndex = 202;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 13F, System.Drawing.FontStyle.Bold);
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(55)))), ((int)(((byte)(252)))));
            this.label5.Location = new System.Drawing.Point(12, 122);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(89, 22);
            this.label5.TabIndex = 201;
            this.label5.Text = "Yayınevi:";
            // 
            // yazar
            // 
            this.yazar.AutoSize = true;
            this.yazar.Font = new System.Drawing.Font("Century Gothic", 13F, System.Drawing.FontStyle.Bold);
            this.yazar.ForeColor = System.Drawing.Color.Black;
            this.yazar.Location = new System.Drawing.Point(133, 82);
            this.yazar.Name = "yazar";
            this.yazar.Size = new System.Drawing.Size(0, 22);
            this.yazar.TabIndex = 200;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 13F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(55)))), ((int)(((byte)(252)))));
            this.label3.Location = new System.Drawing.Point(12, 82);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 22);
            this.label3.TabIndex = 199;
            this.label3.Text = "Yazar:";
            // 
            // kitapad
            // 
            this.kitapad.AutoSize = true;
            this.kitapad.Font = new System.Drawing.Font("Century Gothic", 13F, System.Drawing.FontStyle.Bold);
            this.kitapad.ForeColor = System.Drawing.Color.Black;
            this.kitapad.Location = new System.Drawing.Point(133, 43);
            this.kitapad.Name = "kitapad";
            this.kitapad.Size = new System.Drawing.Size(0, 22);
            this.kitapad.TabIndex = 198;
            // 
            // kitapAdiLabel
            // 
            this.kitapAdiLabel.AutoSize = true;
            this.kitapAdiLabel.BackColor = System.Drawing.Color.Transparent;
            this.kitapAdiLabel.Font = new System.Drawing.Font("Century Gothic", 13F, System.Drawing.FontStyle.Bold);
            this.kitapAdiLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(55)))), ((int)(((byte)(252)))));
            this.kitapAdiLabel.Location = new System.Drawing.Point(12, 43);
            this.kitapAdiLabel.Name = "kitapAdiLabel";
            this.kitapAdiLabel.Size = new System.Drawing.Size(93, 22);
            this.kitapAdiLabel.TabIndex = 197;
            this.kitapAdiLabel.Text = "Kitap Adı:";
            // 
            // kitapno
            // 
            this.kitapno.AutoSize = true;
            this.kitapno.Font = new System.Drawing.Font("Century Gothic", 13F, System.Drawing.FontStyle.Bold);
            this.kitapno.ForeColor = System.Drawing.Color.Black;
            this.kitapno.Location = new System.Drawing.Point(133, 6);
            this.kitapno.Name = "kitapno";
            this.kitapno.Size = new System.Drawing.Size(0, 22);
            this.kitapno.TabIndex = 196;
            // 
            // kitapNoLabel
            // 
            this.kitapNoLabel.AutoSize = true;
            this.kitapNoLabel.BackColor = System.Drawing.Color.Transparent;
            this.kitapNoLabel.Font = new System.Drawing.Font("Century Gothic", 13F, System.Drawing.FontStyle.Bold);
            this.kitapNoLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(55)))), ((int)(((byte)(252)))));
            this.kitapNoLabel.Location = new System.Drawing.Point(12, 6);
            this.kitapNoLabel.Name = "kitapNoLabel";
            this.kitapNoLabel.Size = new System.Drawing.Size(89, 22);
            this.kitapNoLabel.TabIndex = 195;
            this.kitapNoLabel.Text = "Kitap No:";
            // 
            // Listelebutton
            // 
            this.Listelebutton.Animated = true;
            this.Listelebutton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(55)))), ((int)(((byte)(252)))));
            this.Listelebutton.BorderThickness = 2;
            this.Listelebutton.CheckedState.Parent = this.Listelebutton;
            this.Listelebutton.CustomImages.Parent = this.Listelebutton;
            this.Listelebutton.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(204)))), ((int)(((byte)(12)))));
            this.Listelebutton.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold);
            this.Listelebutton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(55)))), ((int)(((byte)(252)))));
            this.Listelebutton.HoverState.Parent = this.Listelebutton;
            this.Listelebutton.Location = new System.Drawing.Point(535, 270);
            this.Listelebutton.Name = "Listelebutton";
            this.Listelebutton.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(55)))), ((int)(((byte)(252)))));
            this.Listelebutton.PressedDepth = 100;
            this.Listelebutton.ShadowDecoration.Parent = this.Listelebutton;
            this.Listelebutton.Size = new System.Drawing.Size(139, 40);
            this.Listelebutton.TabIndex = 221;
            this.Listelebutton.Text = "Listele";
            this.Listelebutton.Click += new System.EventHandler(this.Listelebutton_Click);
            // 
            // kitapGozat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(888, 583);
            this.Controls.Add(this.Listelebutton);
            this.Controls.Add(this.ara);
            this.Controls.Add(this.yazarArama);
            this.Controls.Add(this.turArama);
            this.Controls.Add(this.yayineviArama);
            this.Controls.Add(this.aramaTextBox);
            this.Controls.Add(this.aramaCombo);
            this.Controls.Add(this.aramaLabel);
            this.Controls.Add(this.kitapBilgi);
            this.Controls.Add(this.konu);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.kapak);
            this.Controls.Add(this.sayfasayisi);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.tur);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.basimyili);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.yayinevi);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.yazar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.kitapad);
            this.Controls.Add(this.kitapAdiLabel);
            this.Controls.Add(this.kitapno);
            this.Controls.Add(this.kitapNoLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "kitapGozat";
            this.Text = "Kitap Gözat";
            this.Load += new System.EventHandler(this.kitapGozat_Load);
            ((System.ComponentModel.ISupportInitialize)(this.kitapBilgi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kapak)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuThinButton2 ara;
        private System.Windows.Forms.ComboBox yazarArama;
        private System.Windows.Forms.ComboBox turArama;
        private System.Windows.Forms.ComboBox yayineviArama;
        private Bunifu.Framework.UI.BunifuMaterialTextbox aramaTextBox;
        private System.Windows.Forms.ComboBox aramaCombo;
        private System.Windows.Forms.Label aramaLabel;
        private Guna.UI2.WinForms.Guna2DataGridView kitapBilgi;
        private System.Windows.Forms.TextBox konu;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox kapak;
        private System.Windows.Forms.Label sayfasayisi;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label tur;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label basimyili;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label yayinevi;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label yazar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label kitapad;
        private System.Windows.Forms.Label kitapAdiLabel;
        private System.Windows.Forms.Label kitapno;
        private System.Windows.Forms.Label kitapNoLabel;
        private Guna.UI2.WinForms.Guna2Button Listelebutton;
    }
}