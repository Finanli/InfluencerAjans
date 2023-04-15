namespace InfluencerAjans
{
    partial class Giris
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Giris));
            this.girisgbx = new System.Windows.Forms.GroupBox();
            this.girisb = new System.Windows.Forms.Button();
            this.sifretxt = new System.Windows.Forms.TextBox();
            this.kuladitxt = new System.Windows.Forms.TextBox();
            this.kullaniciadi = new System.Windows.Forms.Label();
            this.sifre = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.girisgbx.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // girisgbx
            // 
            this.girisgbx.Controls.Add(this.girisb);
            this.girisgbx.Controls.Add(this.sifretxt);
            this.girisgbx.Controls.Add(this.kuladitxt);
            this.girisgbx.Controls.Add(this.kullaniciadi);
            this.girisgbx.Controls.Add(this.sifre);
            this.girisgbx.ForeColor = System.Drawing.SystemColors.ControlText;
            this.girisgbx.Location = new System.Drawing.Point(241, 192);
            this.girisgbx.Name = "girisgbx";
            this.girisgbx.Size = new System.Drawing.Size(330, 208);
            this.girisgbx.TabIndex = 3;
            this.girisgbx.TabStop = false;
            this.girisgbx.Text = "Kullanıcı Girişi :";
            // 
            // girisb
            // 
            this.girisb.BackColor = System.Drawing.Color.DarkSalmon;
            this.girisb.Location = new System.Drawing.Point(116, 147);
            this.girisb.Name = "girisb";
            this.girisb.Size = new System.Drawing.Size(129, 38);
            this.girisb.TabIndex = 4;
            this.girisb.Text = "GİRİŞ";
            this.girisb.UseVisualStyleBackColor = false;
            this.girisb.Click += new System.EventHandler(this.girisb_Click);
            // 
            // sifretxt
            // 
            this.sifretxt.Location = new System.Drawing.Point(145, 91);
            this.sifretxt.Name = "sifretxt";
            this.sifretxt.PasswordChar = '*';
            this.sifretxt.Size = new System.Drawing.Size(120, 20);
            this.sifretxt.TabIndex = 3;
            // 
            // kuladitxt
            // 
            this.kuladitxt.Location = new System.Drawing.Point(145, 34);
            this.kuladitxt.Name = "kuladitxt";
            this.kuladitxt.Size = new System.Drawing.Size(120, 20);
            this.kuladitxt.TabIndex = 2;
            // 
            // kullaniciadi
            // 
            this.kullaniciadi.AutoSize = true;
            this.kullaniciadi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.kullaniciadi.Location = new System.Drawing.Point(25, 34);
            this.kullaniciadi.Name = "kullaniciadi";
            this.kullaniciadi.Size = new System.Drawing.Size(100, 16);
            this.kullaniciadi.TabIndex = 0;
            this.kullaniciadi.Text = "Kullanıcı Adı :";
            // 
            // sifre
            // 
            this.sifre.AutoSize = true;
            this.sifre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.sifre.Location = new System.Drawing.Point(25, 96);
            this.sifre.Name = "sifre";
            this.sifre.Size = new System.Drawing.Size(47, 16);
            this.sifre.TabIndex = 1;
            this.sifre.Text = "Şifre :";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(291, 49);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(237, 137);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // Giris
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.NavajoWhite;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.girisgbx);
            this.Name = "Giris";
            this.Text = "Giris";
            this.girisgbx.ResumeLayout(false);
            this.girisgbx.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox girisgbx;
        private System.Windows.Forms.Button girisb;
        private System.Windows.Forms.TextBox sifretxt;
        private System.Windows.Forms.TextBox kuladitxt;
        private System.Windows.Forms.Label kullaniciadi;
        private System.Windows.Forms.Label sifre;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}