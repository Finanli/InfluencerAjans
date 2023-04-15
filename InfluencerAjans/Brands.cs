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
    public partial class Brands : Form
    {
        public Brands()
        {
            InitializeComponent();
        }

        SqlConnection conn = new SqlConnection("Data Source = LAPTOP-DI6H08K1; Initial Catalog=Ajans; Integrated Security =true;");

        public void Listele()
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "MarkaListele";

            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable(); 
            adapter.Fill(dt);
            dataGridView1.DataSource = dt;
        }
        private void listb_Click(object sender, EventArgs e)
        {
            Listele();
        }

        private void markakayitb_Click(object sender, EventArgs e)
        {
            conn.Open();

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "MarkaEkle";

            cmd.Parameters.AddWithValue("MarkaAdi", markatxt.Text);
            cmd.Parameters.AddWithValue("UrunKat", markakatcbx.SelectedIndex+1);
            cmd.Parameters.AddWithValue("Mail", markamailtxt.Text);
            cmd.Parameters.AddWithValue("iletisimAd", markaadsoyadtxt.Text);
            

            cmd.ExecuteNonQuery();
            conn.Close();
            Listele();
        }

        private void updateb_Click(object sender, EventArgs e)
        {
            conn.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "MarkaGuncelle";

            cmd.Parameters.AddWithValue("MarkaNo", markatxt.Tag);
            cmd.Parameters.AddWithValue("iletisimAd", markaadsoyadtxt.Text);
            cmd.Parameters.AddWithValue("mail", markamailtxt.Text);

            cmd.ExecuteNonQuery();
            conn.Close();
            Listele();
        }

        private void deleteb_Click(object sender, EventArgs e)
        {
            conn.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "MarkaSil";

            cmd.Parameters.AddWithValue("MarkaNo", markatxt.Tag);

            cmd.ExecuteNonQuery();
            conn.Close();
            Listele();

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow satir = dataGridView1.CurrentRow;
            markatxt.Tag = satir.Cells["MarkaNo"].Value.ToString();
            markatxt.Text = satir.Cells["MarkaAdi"].Value.ToString();
            markaadsoyadtxt.Text = satir.Cells["iletisimAd"].Value.ToString();
            markamailtxt.Text = satir.Cells["Mail"].Value.ToString();



        }

        private void anasayfab_Click(object sender, EventArgs e)
        {
            AnaSayfa asayfa = new AnaSayfa();
            this.Hide();
            asayfa.Show();
        }

        private void markaarab_Click(object sender, EventArgs e)
        {
            conn.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "MarkaAra";

            cmd.Parameters.AddWithValue("markaAdi", markaaratxt.Text);

            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            dataGridView1.DataSource = dt;

            conn.Close();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Brief brief  = new Brief();
            this.Hide();
            brief.Show();   
        }
    }
}
