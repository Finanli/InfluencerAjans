namespace InfluencerAjans
{
    partial class uyeolform
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
            this.kisiselbgbx = new System.Windows.Forms.GroupBox();
            this.button3 = new System.Windows.Forms.Button();
            this.begenisayi = new System.Windows.Forms.Label();
            this.begenisayitxt = new System.Windows.Forms.TextBox();
            this.pkuladitxt = new System.Windows.Forms.TextBox();
            this.updateb = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.infkayitb = new System.Windows.Forms.Button();
            this.listb = new System.Windows.Forms.Button();
            this.kategoricbx = new System.Windows.Forms.ComboBox();
            this.kategori = new System.Windows.Forms.Label();
            this.takipcitxt = new System.Windows.Forms.TextBox();
            this.platformcbx = new System.Windows.Forms.ComboBox();
            this.infmailtxt = new System.Windows.Forms.TextBox();
            this.infadsoyadtxt = new System.Windows.Forms.TextBox();
            this.takipci = new System.Windows.Forms.Label();
            this.platform = new System.Windows.Forms.Label();
            this.infadsoyad = new System.Windows.Forms.Label();
            this.email = new System.Windows.Forms.Label();
            this.anasayfab = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.kisiselbgbx.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // kisiselbgbx
            // 
            this.kisiselbgbx.Controls.Add(this.button3);
            this.kisiselbgbx.Controls.Add(this.begenisayi);
            this.kisiselbgbx.Controls.Add(this.begenisayitxt);
            this.kisiselbgbx.Controls.Add(this.pkuladitxt);
            this.kisiselbgbx.Controls.Add(this.updateb);
            this.kisiselbgbx.Controls.Add(this.label3);
            this.kisiselbgbx.Controls.Add(this.infkayitb);
            this.kisiselbgbx.Controls.Add(this.listb);
            this.kisiselbgbx.Controls.Add(this.kategoricbx);
            this.kisiselbgbx.Controls.Add(this.kategori);
            this.kisiselbgbx.Controls.Add(this.takipcitxt);
            this.kisiselbgbx.Controls.Add(this.platformcbx);
            this.kisiselbgbx.Controls.Add(this.infmailtxt);
            this.kisiselbgbx.Controls.Add(this.infadsoyadtxt);
            this.kisiselbgbx.Controls.Add(this.takipci);
            this.kisiselbgbx.Controls.Add(this.platform);
            this.kisiselbgbx.Controls.Add(this.infadsoyad);
            this.kisiselbgbx.Controls.Add(this.email);
            this.kisiselbgbx.Location = new System.Drawing.Point(33, 69);
            this.kisiselbgbx.Name = "kisiselbgbx";
            this.kisiselbgbx.Size = new System.Drawing.Size(336, 430);
            this.kisiselbgbx.TabIndex = 5;
            this.kisiselbgbx.TabStop = false;
            this.kisiselbgbx.Text = "Kişisel Bilgiler :";
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Brown;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button3.Location = new System.Drawing.Point(162, 356);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(148, 44);
            this.button3.TabIndex = 9;
            this.button3.Text = "Delete Member";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // begenisayi
            // 
            this.begenisayi.AutoSize = true;
            this.begenisayi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.begenisayi.Location = new System.Drawing.Point(19, 196);
            this.begenisayi.Name = "begenisayi";
            this.begenisayi.Size = new System.Drawing.Size(99, 16);
            this.begenisayi.TabIndex = 18;
            this.begenisayi.Text = "Begeni Sayı :";
            // 
            // begenisayitxt
            // 
            this.begenisayitxt.Location = new System.Drawing.Point(176, 192);
            this.begenisayitxt.Name = "begenisayitxt";
            this.begenisayitxt.Size = new System.Drawing.Size(134, 20);
            this.begenisayitxt.TabIndex = 17;
            this.begenisayitxt.Text = "Son 6 gönderi ortalaması";
            this.begenisayitxt.TextChanged += new System.EventHandler(this.begenisayitxt_TextChanged);
            // 
            // pkuladitxt
            // 
            this.pkuladitxt.Location = new System.Drawing.Point(176, 128);
            this.pkuladitxt.Name = "pkuladitxt";
            this.pkuladitxt.Size = new System.Drawing.Size(134, 20);
            this.pkuladitxt.TabIndex = 15;
            // 
            // updateb
            // 
            this.updateb.BackColor = System.Drawing.Color.RosyBrown;
            this.updateb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.updateb.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.updateb.Location = new System.Drawing.Point(162, 296);
            this.updateb.Name = "updateb";
            this.updateb.Size = new System.Drawing.Size(148, 54);
            this.updateb.TabIndex = 8;
            this.updateb.Text = "Update Members";
            this.updateb.UseVisualStyleBackColor = false;
            this.updateb.Click += new System.EventHandler(this.updateb_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(17, 129);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(157, 16);
            this.label3.TabIndex = 14;
            this.label3.Text = "Platform Kullanıcı Ad :";
            // 
            // infkayitb
            // 
            this.infkayitb.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.infkayitb.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.infkayitb.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.infkayitb.Location = new System.Drawing.Point(22, 296);
            this.infkayitb.Name = "infkayitb";
            this.infkayitb.Size = new System.Drawing.Size(129, 54);
            this.infkayitb.TabIndex = 4;
            this.infkayitb.Text = "ADD Member";
            this.infkayitb.UseVisualStyleBackColor = false;
            this.infkayitb.Click += new System.EventHandler(this.infkayitb_Click);
            // 
            // listb
            // 
            this.listb.BackColor = System.Drawing.Color.SandyBrown;
            this.listb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.listb.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.listb.Location = new System.Drawing.Point(20, 356);
            this.listb.Name = "listb";
            this.listb.Size = new System.Drawing.Size(131, 44);
            this.listb.TabIndex = 7;
            this.listb.Text = "List Members";
            this.listb.UseVisualStyleBackColor = false;
            this.listb.Click += new System.EventHandler(this.listb_Click);
            // 
            // kategoricbx
            // 
            this.kategoricbx.FormattingEnabled = true;
            this.kategoricbx.Items.AddRange(new object[] {
            "Lifestyle",
            "Güzellik / Makyaj",
            "Eğlence"});
            this.kategoricbx.Location = new System.Drawing.Point(176, 228);
            this.kategoricbx.Name = "kategoricbx";
            this.kategoricbx.Size = new System.Drawing.Size(134, 21);
            this.kategoricbx.TabIndex = 13;
            this.kategoricbx.Text = "Kategori Seçiniz";
            this.kategoricbx.SelectedIndexChanged += new System.EventHandler(this.kategoricbx_SelectedIndexChanged);
            // 
            // kategori
            // 
            this.kategori.AutoSize = true;
            this.kategori.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.kategori.Location = new System.Drawing.Point(19, 229);
            this.kategori.Name = "kategori";
            this.kategori.Size = new System.Drawing.Size(73, 16);
            this.kategori.TabIndex = 12;
            this.kategori.Text = "Kategori :";
            // 
            // takipcitxt
            // 
            this.takipcitxt.Location = new System.Drawing.Point(176, 162);
            this.takipcitxt.Name = "takipcitxt";
            this.takipcitxt.Size = new System.Drawing.Size(134, 20);
            this.takipcitxt.TabIndex = 11;
            this.takipcitxt.TextChanged += new System.EventHandler(this.takipcitxt_TextChanged);
            // 
            // platformcbx
            // 
            this.platformcbx.FormattingEnabled = true;
            this.platformcbx.Items.AddRange(new object[] {
            "Instagram",
            "Tiktok",
            "Youtube"});
            this.platformcbx.Location = new System.Drawing.Point(176, 92);
            this.platformcbx.Name = "platformcbx";
            this.platformcbx.Size = new System.Drawing.Size(134, 21);
            this.platformcbx.TabIndex = 10;
            this.platformcbx.Text = "Platform Seçiniz";
            this.platformcbx.SelectedIndexChanged += new System.EventHandler(this.platformcbx_SelectedIndexChanged);
            // 
            // infmailtxt
            // 
            this.infmailtxt.Location = new System.Drawing.Point(176, 62);
            this.infmailtxt.Name = "infmailtxt";
            this.infmailtxt.Size = new System.Drawing.Size(134, 20);
            this.infmailtxt.TabIndex = 9;
            // 
            // infadsoyadtxt
            // 
            this.infadsoyadtxt.Location = new System.Drawing.Point(176, 31);
            this.infadsoyadtxt.Name = "infadsoyadtxt";
            this.infadsoyadtxt.Size = new System.Drawing.Size(134, 20);
            this.infadsoyadtxt.TabIndex = 8;
            // 
            // takipci
            // 
            this.takipci.AutoSize = true;
            this.takipci.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.takipci.Location = new System.Drawing.Point(17, 163);
            this.takipci.Name = "takipci";
            this.takipci.Size = new System.Drawing.Size(102, 16);
            this.takipci.TabIndex = 7;
            this.takipci.Text = "Takipçi Sayı :";
            // 
            // platform
            // 
            this.platform.AutoSize = true;
            this.platform.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.platform.Location = new System.Drawing.Point(17, 98);
            this.platform.Name = "platform";
            this.platform.Size = new System.Drawing.Size(72, 16);
            this.platform.TabIndex = 6;
            this.platform.Text = "Platform :";
            // 
            // infadsoyad
            // 
            this.infadsoyad.AutoSize = true;
            this.infadsoyad.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.infadsoyad.Location = new System.Drawing.Point(17, 31);
            this.infadsoyad.Name = "infadsoyad";
            this.infadsoyad.Size = new System.Drawing.Size(87, 16);
            this.infadsoyad.TabIndex = 5;
            this.infadsoyad.Text = "Adı Soyad :";
            // 
            // email
            // 
            this.email.AutoSize = true;
            this.email.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.email.Location = new System.Drawing.Point(17, 62);
            this.email.Name = "email";
            this.email.Size = new System.Drawing.Size(54, 16);
            this.email.TabIndex = 3;
            this.email.Text = "Email :";
            // 
            // anasayfab
            // 
            this.anasayfab.BackColor = System.Drawing.Color.SaddleBrown;
            this.anasayfab.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.anasayfab.ForeColor = System.Drawing.SystemColors.Control;
            this.anasayfab.Location = new System.Drawing.Point(666, 8);
            this.anasayfab.Name = "anasayfab";
            this.anasayfab.Size = new System.Drawing.Size(122, 39);
            this.anasayfab.TabIndex = 6;
            this.anasayfab.Text = "AnaSayfa";
            this.anasayfab.UseVisualStyleBackColor = false;
            this.anasayfab.Click += new System.EventHandler(this.anasayfab_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(387, 69);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(401, 430);
            this.dataGridView1.TabIndex = 7;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // uyeolform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.BurlyWood;
            this.ClientSize = new System.Drawing.Size(800, 581);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.kisiselbgbx);
            this.Controls.Add(this.anasayfab);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "uyeolform";
            this.Text = "Influencer";
            this.Load += new System.EventHandler(this.uyeolform_Load);
            this.kisiselbgbx.ResumeLayout(false);
            this.kisiselbgbx.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox kisiselbgbx;
        private System.Windows.Forms.Button infkayitb;
        private System.Windows.Forms.Label email;
        private System.Windows.Forms.Label infadsoyad;
        private System.Windows.Forms.Label takipci;
        private System.Windows.Forms.Label platform;
        private System.Windows.Forms.ComboBox kategoricbx;
        private System.Windows.Forms.Label kategori;
        private System.Windows.Forms.TextBox takipcitxt;
        private System.Windows.Forms.ComboBox platformcbx;
        private System.Windows.Forms.TextBox infmailtxt;
        private System.Windows.Forms.TextBox infadsoyadtxt;
        private System.Windows.Forms.TextBox pkuladitxt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button anasayfab;
        private System.Windows.Forms.TextBox begenisayitxt;
        private System.Windows.Forms.Label begenisayi;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button updateb;
        private System.Windows.Forms.Button listb;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}

