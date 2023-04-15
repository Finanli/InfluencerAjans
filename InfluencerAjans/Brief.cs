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
    public partial class Brief : Form
    {
        public Brief()
        {
            InitializeComponent();
        }
        SqlConnection conn = new SqlConnection("Server = LAPTOP-DI6H08K1; Database=Ajans; Integrated Security =true;");

        private void Brief_Load(object sender, EventArgs e)
        {
            conn.Open();
            SqlCommand cmd = new SqlCommand("select * from marka", conn);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                markacbx.Items.Add(dr["MarkaAdi"]);
            }
            conn.Close();
        }

        private void markacbx_SelectedIndexChanged(object sender, EventArgs e)
        {
            conn.Open();
            SqlCommand cmd = new SqlCommand("select * from urunkategori", conn);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                procatcbx.Items.Add(dr["urunkatAdi"]);
            }
            conn.Close();
        }

        private void platformcbx_SelectedIndexChanged(object sender, EventArgs e)
        {
            conn.Open();
            SqlCommand cmd = new SqlCommand("select * from IcerikKategori", conn);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                infcatcbx.Items.Add(dr["kategoriadi"]);
            }
            conn.Close();
        }

        private void infcatcbx_SelectedIndexChanged(object sender, EventArgs e)
        {
            conn.Open();
            SqlCommand cmd = new SqlCommand("select * from iceriktip", conn);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                contypecbx.Items.Add(dr["iceriktipi"]);
            }
            conn.Close();
        }
        public void Listele()
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "BriefList";

            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void braddb_Click(object sender, EventArgs e)
        {
            conn.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "BriefAdd";

            cmd.Parameters.AddWithValue("MarkaNo", markacbx.SelectedIndex+1);
            cmd.Parameters.AddWithValue("UrunKat", procatcbx.SelectedIndex + 1);
            cmd.Parameters.AddWithValue("platformNo", platformcbx.SelectedIndex+1);
            cmd.Parameters.AddWithValue("kategorino", infcatcbx.SelectedIndex+1);
            cmd.Parameters.AddWithValue("iceriktip", contypecbx.SelectedIndex + 1);
            cmd.Parameters.AddWithValue("upfollower", upfolntxt.Text);
            cmd.Parameters.AddWithValue("lowfollower", lowfolntxt.Text);

            cmd.ExecuteNonQuery();
            conn.Close();
            Listele();
        }

        private void listb_Click(object sender, EventArgs e)
        {
            Listele();
        }

        private void updateb_Click(object sender, EventArgs e)
        {
            conn.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "BriefUpdate";

            cmd.Parameters.AddWithValue("BriefNo",upfolntxt.Tag);
            cmd.Parameters.AddWithValue("MarkaNo", markacbx.SelectedIndex + 1);
            cmd.Parameters.AddWithValue("UrunKat", procatcbx.SelectedIndex + 1);
            cmd.Parameters.AddWithValue("platformNo", platformcbx.SelectedIndex + 1);
            cmd.Parameters.AddWithValue("kategorino", infcatcbx.SelectedIndex + 1);
            cmd.Parameters.AddWithValue("iceriktip", contypecbx.SelectedIndex + 1);
            cmd.Parameters.AddWithValue("upfollower", upfolntxt.Text);
            cmd.Parameters.AddWithValue("lowfollower", lowfolntxt.Text);

            cmd.ExecuteNonQuery();
            conn.Close();
            Listele();
        }

        private void anasayfab_Click(object sender, EventArgs e)
        {
            AnaSayfa anaSayfa = new AnaSayfa();
            this.Hide();
            anaSayfa.Show();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow satir = dataGridView1.CurrentRow;
            upfolntxt.Tag = satir.Cells["BriefNo"].Value.ToString();
            markacbx.SelectedItem = satir.Cells["MarkaNo"].Value.ToString();
            procatcbx.SelectedItem = satir.Cells["urunkat"].Value.ToString();
            platformcbx.SelectedItem = satir.Cells["platformNo"].Value.ToString();
            infcatcbx.SelectedItem = satir.Cells["kategorino"].Value.ToString();
            contypecbx.SelectedItem = satir.Cells["iceriktip"].Value.ToString();
            upfolntxt.Text = satir.Cells["upfollower"].Value.ToString();
            lowfolntxt.Text = satir.Cells["lowfollower"].Value.ToString();
        }
    }
}
