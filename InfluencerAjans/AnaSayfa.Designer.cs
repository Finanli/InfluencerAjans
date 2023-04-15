namespace InfluencerAjans
{
    partial class AnaSayfa
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AnaSayfa));
            this.brandb = new System.Windows.Forms.Button();
            this.infb = new System.Windows.Forms.Button();
            this.raporb = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // brandb
            // 
            this.brandb.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.brandb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.brandb.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.brandb.Location = new System.Drawing.Point(481, 301);
            this.brandb.Name = "brandb";
            this.brandb.Size = new System.Drawing.Size(130, 52);
            this.brandb.TabIndex = 2;
            this.brandb.Text = "Brand";
            this.brandb.UseVisualStyleBackColor = false;
            this.brandb.Click += new System.EventHandler(this.brandb_Click);
            // 
            // infb
            // 
            this.infb.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.infb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.infb.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.infb.Location = new System.Drawing.Point(263, 301);
            this.infb.Name = "infb";
            this.infb.Size = new System.Drawing.Size(130, 52);
            this.infb.TabIndex = 3;
            this.infb.Text = "Infleuncer";
            this.infb.UseVisualStyleBackColor = false;
            this.infb.Click += new System.EventHandler(this.infb_Click);
            // 
            // raporb
            // 
            this.raporb.BackColor = System.Drawing.Color.SandyBrown;
            this.raporb.Location = new System.Drawing.Point(394, 371);
            this.raporb.Name = "raporb";
            this.raporb.Size = new System.Drawing.Size(87, 36);
            this.raporb.TabIndex = 8;
            this.raporb.Text = "Raporlar";
            this.raporb.UseVisualStyleBackColor = false;
            this.raporb.Click += new System.EventHandler(this.raporb_Click);
            // 
            // AnaSayfa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(860, 444);
            this.Controls.Add(this.raporb);
            this.Controls.Add(this.infb);
            this.Controls.Add(this.brandb);
            this.DoubleBuffered = true;
            this.Name = "AnaSayfa";
            this.Text = "AnaSayfa";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button brandb;
        private System.Windows.Forms.Button infb;
        private System.Windows.Forms.Button raporb;
    }
}