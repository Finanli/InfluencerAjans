using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace InfluencerAjans
{
    public partial class uyeolform : Form
    {
        public uyeolform()
        {
            InitializeComponent();
        }

        SqlConnection conn = new SqlConnection("Data Source = LAPTOP-DI6H08K1; Initial Catalog=Ajans; Integrated Security =true;");

        private void uyeolform_Load(object sender, EventArgs e)
        {


        }

        public void Listele()
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "InfluencerListele";

            SqlDataAdapter dr = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            dr.Fill(dt);
            dataGridView1.DataSource = dt;  
        }

        

        private void anasayfab_Click(object sender, EventArgs e)
        {
            AnaSayfa asayfa = new AnaSayfa();
            this.Hide();
            asayfa.Show();
        }

        private void listb_Click(object sender, EventArgs e)
        {
            Listele();
        }

        private void infkayitb_Click(object sender, EventArgs e)
        {
            conn.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "InfluencerEkle";

            cmd.Parameters.AddWithValue("AdSoyad",infadsoyadtxt.Text);
            cmd.Parameters.AddWithValue("KullaniciAdi", pkuladitxt.Text);
            cmd.Parameters.AddWithValue("Email", infmailtxt.Text);
            cmd.Parameters.AddWithValue("TakipciSayi", takipcitxt.Text);
            cmd.Parameters.AddWithValue("BegeniSayi", begenisayitxt.Text);
            cmd.Parameters.AddWithValue("PlatformNo", platformcbx.SelectedIndex+1);
            cmd.Parameters.AddWithValue("KategoriNo", kategoricbx.SelectedIndex+1);
            
            


            cmd.ExecuteNonQuery();
            conn.Close();
            Listele();
        }

        private void platformcbx_SelectedIndexChanged(object sender, EventArgs e)
        {
            //int platform = platformcbx.SelectedIndex + 1;
            //platformcbx.Tag = platform;
            //platformcbx.Text = Convert.ToString(platform);
            //platformcbx.Text = platform.ToString;

            //if (platform == 1)
            //{
            //    platformcbx.Text = Convert.ToString(platform);
            //}
            //else if (platform == 2)
            //{
            //    platformcbx.Text = "2";
            //}
            //else if (platform == 3)
            //{
            //    platformcbx.Text = "3";
            //}


        }

        private void kategoricbx_SelectedIndexChanged(object sender, EventArgs e)
        {
            //int kategori = kategoricbx.SelectedIndex + 1;
            //kategoricbx.Tag = kategori;
            //kategoricbx.Text = Convert.ToString(kategori);

            //if (kategori == 1)
            //{
            //    kategoricbx.Text = "1";
            //}
            //else if (kategori == 2)
            //{
            //    kategoricbx.Text = "2";
            //}
            //else if (kategori == 3)
            //{
            //    kategoricbx.Text = "3";
            //}

        }

        private void takipcitxt_TextChanged(object sender, EventArgs e)
        {
            float takipci = float.Parse(takipcitxt.Text);
            takipcitxt.Tag = takipci;



        }

        private void begenisayitxt_TextChanged(object sender, EventArgs e)
        {

            float begeni = float.Parse(begenisayitxt.Text);
            begenisayitxt.Tag = begeni;
            //begenisayitxt.Text = begeni.ToString();
        }

        private void updateb_Click(object sender, EventArgs e)
        {
            conn.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "InfluencerGuncelle";

            cmd.Parameters.AddWithValue("infNo", infadsoyadtxt.Tag);
            cmd.Parameters.AddWithValue("AdSoyad", infadsoyadtxt.Text);
            cmd.Parameters.AddWithValue("KullaniciAdi", pkuladitxt.Text);
            cmd.Parameters.AddWithValue("Email", infmailtxt.Text);
            cmd.Parameters.AddWithValue("TakipciSayi", takipcitxt.Text);
            cmd.Parameters.AddWithValue("BegeniSayi", begenisayitxt.Text);
            cmd.Parameters.AddWithValue("PlatformNo", platformcbx.SelectedIndex + 1);
            cmd.Parameters.AddWithValue("KategoriNo", kategoricbx.SelectedIndex+1);
            

            cmd.ExecuteNonQuery();
            conn.Close();
            Listele();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            conn.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "InfSil";

            cmd.Parameters.AddWithValue("infNo", infmailtxt.Tag);

            cmd.ExecuteNonQuery();
            conn.Close();

            Listele();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow satir = dataGridView1.CurrentRow;
            infadsoyadtxt.Tag = satir.Cells["infNo"].Value.ToString();
            infadsoyadtxt.Text = satir.Cells["AdSoyad"].Value.ToString();
            infmailtxt.Text = satir.Cells["EMail"].Value.ToString();
            pkuladitxt.Text = satir.Cells["KullanıcıAdi"].Value.ToString();
            takipcitxt.Text = satir.Cells["TakipciSayi"].Value.ToString();
            begenisayitxt.Text = satir.Cells["BegeniSayi"].Value.ToString();
            platformcbx.SelectedItem = satir.Cells["PlatformNo"].Value.ToString();
            kategoricbx.SelectedItem = satir.Cells["KategoriNo"].Value.ToString();
            



        }
    }
}
