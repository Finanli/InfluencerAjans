using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InfluencerAjans
{
    public partial class AnaSayfa : Form
    {
        public AnaSayfa()
        {
            InitializeComponent();
        }

        private void brandb_Click(object sender, EventArgs e)
        {
            Brands brand = new Brands();
            this.Hide();
            brand.Show();
        }

        private void infb_Click(object sender, EventArgs e)
        {
            uyeolform uye = new uyeolform();
            this.Hide();
            uye.Show();
        }

        private void raporb_Click(object sender, EventArgs e)
        {
            Rapor rapor = new Rapor();
            this.Hide();
            rapor.Show();
        }
    }
}
