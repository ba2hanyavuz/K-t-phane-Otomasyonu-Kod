
namespace KutuphaneReborn
{
    partial class ikibinkirksekiz
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ikibinkirksekiz));
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Highscore = new System.Windows.Forms.Button();
            this.Scor = new System.Windows.Forms.Button();
            this.Baslat = new Guna.UI2.WinForms.Guna2Button();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(452, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "label2";
            this.label2.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(411, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "label1";
            this.label1.Visible = false;
            // 
            // Highscore
            // 
            this.Highscore.BackColor = System.Drawing.Color.PeachPuff;
            this.Highscore.Font = new System.Drawing.Font("Microsoft YaHei UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Highscore.Location = new System.Drawing.Point(42, 11);
            this.Highscore.Name = "Highscore";
            this.Highscore.Size = new System.Drawing.Size(130, 59);
            this.Highscore.TabIndex = 9;
            this.Highscore.Text = "0";
            this.Highscore.UseVisualStyleBackColor = false;
            // 
            // Scor
            // 
            this.Scor.BackColor = System.Drawing.Color.PeachPuff;
            this.Scor.Font = new System.Drawing.Font("Microsoft YaHei UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Scor.Location = new System.Drawing.Point(227, 12);
            this.Scor.Name = "Scor";
            this.Scor.Size = new System.Drawing.Size(130, 59);
            this.Scor.TabIndex = 8;
            this.Scor.Text = "0";
            this.Scor.UseVisualStyleBackColor = false;
            // 
            // Baslat
            // 
            this.Baslat.Animated = true;
            this.Baslat.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(55)))), ((int)(((byte)(252)))));
            this.Baslat.BorderThickness = 2;
            this.Baslat.CheckedState.Parent = this.Baslat;
            this.Baslat.CustomImages.Parent = this.Baslat;
            this.Baslat.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(204)))), ((int)(((byte)(12)))));
            this.Baslat.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold);
            this.Baslat.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(55)))), ((int)(((byte)(252)))));
            this.Baslat.HoverState.Parent = this.Baslat;
            this.Baslat.Location = new System.Drawing.Point(414, 241);
            this.Baslat.Name = "Baslat";
            this.Baslat.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(55)))), ((int)(((byte)(252)))));
            this.Baslat.PressedDepth = 100;
            this.Baslat.ShadowDecoration.Parent = this.Baslat;
            this.Baslat.Size = new System.Drawing.Size(168, 59);
            this.Baslat.TabIndex = 190;
            this.Baslat.Text = "YeniOyun";
            this.Baslat.Click += new System.EventHandler(this.YeniOyun_Click);
            // 
            // ikibinkirksekiz
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(591, 540);
            this.Controls.Add(this.Baslat);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Highscore);
            this.Controls.Add(this.Scor);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ikibinkirksekiz";
            this.Text = "2048";
            this.Load += new System.EventHandler(this.ikibinkirksekiz_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Highscore;
        private System.Windows.Forms.Button Scor;
        private Guna.UI2.WinForms.Guna2Button Baslat;
    }
}