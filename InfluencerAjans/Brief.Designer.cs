namespace InfluencerAjans
{
    partial class Brief
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
            this.begenisayi = new System.Windows.Forms.Label();
            this.upfolntxt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.kategori = new System.Windows.Forms.Label();
            this.platformcbx = new System.Windows.Forms.ComboBox();
            this.takipci = new System.Windows.Forms.Label();
            this.platform = new System.Windows.Forms.Label();
            this.infadsoyad = new System.Windows.Forms.Label();
            this.email = new System.Windows.Forms.Label();
            this.markacbx = new System.Windows.Forms.ComboBox();
            this.procatcbx = new System.Windows.Forms.ComboBox();
            this.infcatcbx = new System.Windows.Forms.ComboBox();
            this.contypecbx = new System.Windows.Forms.ComboBox();
            this.lowfolntxt = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.deleteb = new System.Windows.Forms.Button();
            this.listb = new System.Windows.Forms.Button();
            this.updateb = new System.Windows.Forms.Button();
            this.braddb = new System.Windows.Forms.Button();
            this.anasayfab = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // begenisayi
            // 
            this.begenisayi.AutoSize = true;
            this.begenisayi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.begenisayi.Location = new System.Drawing.Point(48, 232);
            this.begenisayi.Name = "begenisayi";
            this.begenisayi.Size = new System.Drawing.Size(179, 16);
            this.begenisayi.TabIndex = 32;
            this.begenisayi.Text = "Upper Follower Number :";
            // 
            // upfolntxt
            // 
            this.upfolntxt.Location = new System.Drawing.Point(237, 228);
            this.upfolntxt.Name = "upfolntxt";
            this.upfolntxt.Size = new System.Drawing.Size(134, 20);
            this.upfolntxt.TabIndex = 31;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(78, 165);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(149, 16);
            this.label3.TabIndex = 29;
            this.label3.Text = "Influencer Category :";
            // 
            // kategori
            // 
            this.kategori.AutoSize = true;
            this.kategori.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.kategori.Location = new System.Drawing.Point(50, 265);
            this.kategori.Name = "kategori";
            this.kategori.Size = new System.Drawing.Size(177, 16);
            this.kategori.TabIndex = 27;
            this.kategori.Text = "Lower Follewer Number :";
            // 
            // platformcbx
            // 
            this.platformcbx.FormattingEnabled = true;
            this.platformcbx.Items.AddRange(new object[] {
            "Instagram",
            "Tiktok",
            "Youtube"});
            this.platformcbx.Location = new System.Drawing.Point(237, 128);
            this.platformcbx.Name = "platformcbx";
            this.platformcbx.Size = new System.Drawing.Size(134, 21);
            this.platformcbx.TabIndex = 25;
            this.platformcbx.Text = "Platform Seçiniz";
            this.platformcbx.SelectedIndexChanged += new System.EventHandler(this.platformcbx_SelectedIndexChanged);
            // 
            // takipci
            // 
            this.takipci.AutoSize = true;
            this.takipci.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.takipci.Location = new System.Drawing.Point(78, 199);
            this.takipci.Name = "takipci";
            this.takipci.Size = new System.Drawing.Size(107, 16);
            this.takipci.TabIndex = 22;
            this.takipci.Text = "Content Type :";
            // 
            // platform
            // 
            this.platform.AutoSize = true;
            this.platform.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.platform.Location = new System.Drawing.Point(78, 134);
            this.platform.Name = "platform";
            this.platform.Size = new System.Drawing.Size(72, 16);
            this.platform.TabIndex = 21;
            this.platform.Text = "Platform :";
            // 
            // infadsoyad
            // 
            this.infadsoyad.AutoSize = true;
            this.infadsoyad.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.infadsoyad.Location = new System.Drawing.Point(78, 67);
            this.infadsoyad.Name = "infadsoyad";
            this.infadsoyad.Size = new System.Drawing.Size(58, 16);
            this.infadsoyad.TabIndex = 20;
            this.infadsoyad.Text = "Marka :";
            // 
            // email
            // 
            this.email.AutoSize = true;
            this.email.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.email.Location = new System.Drawing.Point(78, 98);
            this.email.Name = "email";
            this.email.Size = new System.Drawing.Size(68, 16);
            this.email.TabIndex = 19;
            this.email.Text = "Product :";
            // 
            // markacbx
            // 
            this.markacbx.FormattingEnabled = true;
            this.markacbx.Location = new System.Drawing.Point(237, 61);
            this.markacbx.Name = "markacbx";
            this.markacbx.Size = new System.Drawing.Size(134, 21);
            this.markacbx.TabIndex = 33;
            this.markacbx.SelectedIndexChanged += new System.EventHandler(this.markacbx_SelectedIndexChanged);
            // 
            // procatcbx
            // 
            this.procatcbx.FormattingEnabled = true;
            this.procatcbx.Location = new System.Drawing.Point(237, 97);
            this.procatcbx.Name = "procatcbx";
            this.procatcbx.Size = new System.Drawing.Size(134, 21);
            this.procatcbx.TabIndex = 34;
            // 
            // infcatcbx
            // 
            this.infcatcbx.FormattingEnabled = true;
            this.infcatcbx.Location = new System.Drawing.Point(237, 164);
            this.infcatcbx.Name = "infcatcbx";
            this.infcatcbx.Size = new System.Drawing.Size(134, 21);
            this.infcatcbx.TabIndex = 35;
            this.infcatcbx.SelectedIndexChanged += new System.EventHandler(this.infcatcbx_SelectedIndexChanged);
            // 
            // contypecbx
            // 
            this.contypecbx.FormattingEnabled = true;
            this.contypecbx.Location = new System.Drawing.Point(237, 198);
            this.contypecbx.Name = "contypecbx";
            this.contypecbx.Size = new System.Drawing.Size(134, 21);
            this.contypecbx.TabIndex = 36;
            // 
            // lowfolntxt
            // 
            this.lowfolntxt.Location = new System.Drawing.Point(237, 260);
            this.lowfolntxt.Name = "lowfolntxt";
            this.lowfolntxt.Size = new System.Drawing.Size(134, 20);
            this.lowfolntxt.TabIndex = 37;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(408, 52);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(365, 270);
            this.dataGridView1.TabIndex = 38;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // deleteb
            // 
            this.deleteb.BackColor = System.Drawing.Color.Brown;
            this.deleteb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.deleteb.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.deleteb.Location = new System.Drawing.Point(213, 353);
            this.deleteb.Name = "deleteb";
            this.deleteb.Size = new System.Drawing.Size(126, 50);
            this.deleteb.TabIndex = 42;
            this.deleteb.Text = "Delete Brand";
            this.deleteb.UseVisualStyleBackColor = false;
            // 
            // listb
            // 
            this.listb.BackColor = System.Drawing.Color.SandyBrown;
            this.listb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.listb.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.listb.Location = new System.Drawing.Point(81, 353);
            this.listb.Name = "listb";
            this.listb.Size = new System.Drawing.Size(113, 50);
            this.listb.TabIndex = 41;
            this.listb.Text = "List Brands";
            this.listb.UseVisualStyleBackColor = false;
            this.listb.Click += new System.EventHandler(this.listb_Click);
            // 
            // updateb
            // 
            this.updateb.BackColor = System.Drawing.Color.RosyBrown;
            this.updateb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.updateb.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.updateb.Location = new System.Drawing.Point(213, 298);
            this.updateb.Name = "updateb";
            this.updateb.Size = new System.Drawing.Size(126, 49);
            this.updateb.TabIndex = 40;
            this.updateb.Text = "Update Brands";
            this.updateb.UseVisualStyleBackColor = false;
            this.updateb.Click += new System.EventHandler(this.updateb_Click);
            // 
            // braddb
            // 
            this.braddb.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.braddb.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.braddb.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.braddb.Location = new System.Drawing.Point(81, 298);
            this.braddb.Name = "braddb";
            this.braddb.Size = new System.Drawing.Size(115, 49);
            this.braddb.TabIndex = 39;
            this.braddb.Text = "ADD";
            this.braddb.UseVisualStyleBackColor = false;
            this.braddb.Click += new System.EventHandler(this.braddb_Click);
            // 
            // anasayfab
            // 
            this.anasayfab.BackColor = System.Drawing.Color.IndianRed;
            this.anasayfab.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.anasayfab.Location = new System.Drawing.Point(705, 12);
            this.anasayfab.Name = "anasayfab";
            this.anasayfab.Size = new System.Drawing.Size(68, 34);
            this.anasayfab.TabIndex = 43;
            this.anasayfab.Text = "Anasayfa";
            this.anasayfab.UseVisualStyleBackColor = false;
            this.anasayfab.Click += new System.EventHandler(this.anasayfab_Click);
            // 
            // Brief
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.anasayfab);
            this.Controls.Add(this.deleteb);
            this.Controls.Add(this.listb);
            this.Controls.Add(this.updateb);
            this.Controls.Add(this.braddb);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.lowfolntxt);
            this.Controls.Add(this.contypecbx);
            this.Controls.Add(this.infcatcbx);
            this.Controls.Add(this.procatcbx);
            this.Controls.Add(this.markacbx);
            this.Controls.Add(this.begenisayi);
            this.Controls.Add(this.upfolntxt);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.kategori);
            this.Controls.Add(this.platformcbx);
            this.Controls.Add(this.takipci);
            this.Controls.Add(this.platform);
            this.Controls.Add(this.infadsoyad);
            this.Controls.Add(this.email);
            this.Name = "Brief";
            this.Text = "Brief";
            this.Load += new System.EventHandler(this.Brief_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label begenisayi;
        private System.Windows.Forms.TextBox upfolntxt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label kategori;
        private System.Windows.Forms.ComboBox platformcbx;
        private System.Windows.Forms.Label takipci;
        private System.Windows.Forms.Label platform;
        private System.Windows.Forms.Label infadsoyad;
        private System.Windows.Forms.Label email;
        private System.Windows.Forms.ComboBox markacbx;
        private System.Windows.Forms.ComboBox procatcbx;
        private System.Windows.Forms.ComboBox infcatcbx;
        private System.Windows.Forms.ComboBox contypecbx;
        private System.Windows.Forms.TextBox lowfolntxt;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button deleteb;
        private System.Windows.Forms.Button listb;
        private System.Windows.Forms.Button updateb;
        private System.Windows.Forms.Button braddb;
        private System.Windows.Forms.Button anasayfab;
    }
}