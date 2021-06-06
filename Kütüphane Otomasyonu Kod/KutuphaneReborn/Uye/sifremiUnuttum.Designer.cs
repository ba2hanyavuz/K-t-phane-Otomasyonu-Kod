
namespace KutuphaneReborn
{
    partial class sifremiUnuttum
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
            this.label1 = new System.Windows.Forms.Label();
            this.gonderButton = new Guna.UI2.WinForms.Guna2Button();
            this.mailtextbox = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.guna2ControlBox1 = new Guna.UI2.WinForms.Guna2ControlBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(398, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "label1";
            this.label1.Visible = false;
            // 
            // gonderButton
            // 
            this.gonderButton.CheckedState.Parent = this.gonderButton;
            this.gonderButton.CustomImages.Parent = this.gonderButton;
            this.gonderButton.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(55)))), ((int)(((byte)(252)))));
            this.gonderButton.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.gonderButton.ForeColor = System.Drawing.Color.Gainsboro;
            this.gonderButton.HoverState.Parent = this.gonderButton;
            this.gonderButton.Location = new System.Drawing.Point(156, 117);
            this.gonderButton.Name = "gonderButton";
            this.gonderButton.ShadowDecoration.Parent = this.gonderButton;
            this.gonderButton.Size = new System.Drawing.Size(180, 45);
            this.gonderButton.TabIndex = 36;
            this.gonderButton.Text = "Şifremi Mailime Gönder";
            this.gonderButton.Click += new System.EventHandler(this.gonderButton_Click);
            // 
            // mailtextbox
            // 
            this.mailtextbox.BorderColorFocused = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(204)))), ((int)(((byte)(12)))));
            this.mailtextbox.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(55)))), ((int)(((byte)(252)))));
            this.mailtextbox.BorderColorMouseHover = System.Drawing.Color.Gainsboro;
            this.mailtextbox.BorderThickness = 3;
            this.mailtextbox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.mailtextbox.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.mailtextbox.ForeColor = System.Drawing.Color.Black;
            this.mailtextbox.isPassword = false;
            this.mailtextbox.Location = new System.Drawing.Point(63, 53);
            this.mailtextbox.Margin = new System.Windows.Forms.Padding(4);
            this.mailtextbox.Name = "mailtextbox";
            this.mailtextbox.Size = new System.Drawing.Size(370, 44);
            this.mailtextbox.TabIndex = 37;
            this.mailtextbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // guna2ControlBox1
            // 
            this.guna2ControlBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2ControlBox1.FillColor = System.Drawing.Color.Black;
            this.guna2ControlBox1.HoverState.Parent = this.guna2ControlBox1;
            this.guna2ControlBox1.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(204)))), ((int)(((byte)(12)))));
            this.guna2ControlBox1.Location = new System.Drawing.Point(496, 0);
            this.guna2ControlBox1.Name = "guna2ControlBox1";
            this.guna2ControlBox1.ShadowDecoration.Parent = this.guna2ControlBox1;
            this.guna2ControlBox1.Size = new System.Drawing.Size(20, 20);
            this.guna2ControlBox1.TabIndex = 38;
            // 
            // sifremiUnuttum
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(516, 233);
            this.Controls.Add(this.guna2ControlBox1);
            this.Controls.Add(this.mailtextbox);
            this.Controls.Add(this.gonderButton);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "sifremiUnuttum";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "sifremiUnuttum";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2Button gonderButton;
        private Bunifu.Framework.UI.BunifuMetroTextbox mailtextbox;
        private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox1;
    }
}