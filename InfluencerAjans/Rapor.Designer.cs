namespace InfluencerAjans
{
    partial class Rapor
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
            this.infbegenib = new System.Windows.Forms.Button();
            this.inftakipcib = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.isimaratxt = new System.Windows.Forms.TextBox();
            this.isimara = new System.Windows.Forms.Label();
            this.arab = new System.Windows.Forms.Button();
            this.filtecbx = new System.Windows.Forms.ComboBox();
            this.anasayfab = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // infbegenib
            // 
            this.infbegenib.BackColor = System.Drawing.Color.BurlyWood;
            this.infbegenib.ForeColor = System.Drawing.SystemColors.InfoText;
            this.infbegenib.Location = new System.Drawing.Point(43, 73);
            this.infbegenib.Name = "infbegenib";
            this.infbegenib.Size = new System.Drawing.Size(138, 46);
            this.infbegenib.TabIndex = 0;
            this.infbegenib.Text = "Inflencer Beğeniye Göre (büyükten küçüğe)";
            this.infbegenib.UseVisualStyleBackColor = false;
            this.infbegenib.Click += new System.EventHandler(this.infbegenib_Click);
            // 
            // inftakipcib
            // 
            this.inftakipcib.BackColor = System.Drawing.Color.BurlyWood;
            this.inftakipcib.ForeColor = System.Drawing.SystemColors.InfoText;
            this.inftakipcib.Location = new System.Drawing.Point(187, 73);
            this.inftakipcib.Name = "inftakipcib";
            this.inftakipcib.Size = new System.Drawing.Size(138, 46);
            this.inftakipcib.TabIndex = 1;
            this.inftakipcib.Text = "Influencer Takipçiye Göre (büyükten küçüğe)";
            this.inftakipcib.UseVisualStyleBackColor = false;
            this.inftakipcib.Click += new System.EventHandler(this.inftakipcib_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.Tan;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(43, 144);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(727, 275);
            this.dataGridView1.TabIndex = 2;
            // 
            // isimaratxt
            // 
            this.isimaratxt.Location = new System.Drawing.Point(593, 64);
            this.isimaratxt.Name = "isimaratxt";
            this.isimaratxt.Size = new System.Drawing.Size(121, 20);
            this.isimaratxt.TabIndex = 3;
            // 
            // isimara
            // 
            this.isimara.AutoSize = true;
            this.isimara.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.isimara.Location = new System.Drawing.Point(487, 38);
            this.isimara.Name = "isimara";
            this.isimara.Size = new System.Drawing.Size(100, 16);
            this.isimara.TabIndex = 4;
            this.isimara.Text = "AramaFiltrele";
            // 
            // arab
            // 
            this.arab.BackColor = System.Drawing.Color.OliveDrab;
            this.arab.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.arab.Location = new System.Drawing.Point(722, 74);
            this.arab.Name = "arab";
            this.arab.Size = new System.Drawing.Size(47, 29);
            this.arab.TabIndex = 5;
            this.arab.Text = "ARA";
            this.arab.UseVisualStyleBackColor = false;
            this.arab.Click += new System.EventHandler(this.arab_Click);
            // 
            // filtecbx
            // 
            this.filtecbx.FormattingEnabled = true;
            this.filtecbx.Items.AddRange(new object[] {
            "Influencer Ad",
            "Marka Ad",
            "Influencer Kategori",
            "Engagement Rate Aralık",
            "Takipçi Aralık"});
            this.filtecbx.Location = new System.Drawing.Point(593, 37);
            this.filtecbx.Name = "filtecbx";
            this.filtecbx.Size = new System.Drawing.Size(121, 21);
            this.filtecbx.TabIndex = 6;
            this.filtecbx.SelectedIndexChanged += new System.EventHandler(this.filtecbx_SelectedIndexChanged);
            // 
            // anasayfab
            // 
            this.anasayfab.BackColor = System.Drawing.Color.IndianRed;
            this.anasayfab.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.anasayfab.Location = new System.Drawing.Point(43, 13);
            this.anasayfab.Name = "anasayfab";
            this.anasayfab.Size = new System.Drawing.Size(68, 34);
            this.anasayfab.TabIndex = 7;
            this.anasayfab.Text = "Anasayfa";
            this.anasayfab.UseVisualStyleBackColor = false;
            this.anasayfab.Click += new System.EventHandler(this.anasayfab_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(593, 90);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(121, 20);
            this.textBox1.TabIndex = 8;
            // 
            // Rapor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightYellow;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.anasayfab);
            this.Controls.Add(this.filtecbx);
            this.Controls.Add(this.arab);
            this.Controls.Add(this.isimara);
            this.Controls.Add(this.isimaratxt);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.inftakipcib);
            this.Controls.Add(this.infbegenib);
            this.Name = "Rapor";
            this.Text = "Rapor";
            this.Load += new System.EventHandler(this.Rapor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button infbegenib;
        private System.Windows.Forms.Button inftakipcib;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox isimaratxt;
        private System.Windows.Forms.Label isimara;
        private System.Windows.Forms.Button arab;
        private System.Windows.Forms.ComboBox filtecbx;
        private System.Windows.Forms.Button anasayfab;
        private System.Windows.Forms.TextBox textBox1;
    }
}