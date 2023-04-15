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
    public partial class Rapor : Form
    {
        public Rapor()
        {
            InitializeComponent();
        }

        SqlConnection conn = new SqlConnection("Data Source = LAPTOP-DI6H08K1; Initial Catalog=Ajans; Integrated Security =true;");

        private void Rapor_Load(object sender, EventArgs e)
        {
            isimaratxt.Visible = false;
            arab.Visible = false;
            textBox1.Visible = false;
        }

        private void infbegenib_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection= conn;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "InfBegeniSırala";

            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dt  = new DataTable();
            adapter.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void inftakipcib_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "InfTakipciSırala";

            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void arab_Click(object sender, EventArgs e)
        {

            if (filtecbx.SelectedIndex == 0)
            {
                
                conn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "InfIsmeGoreAra";
                cmd.Parameters.AddWithValue("adsoyad", isimaratxt.Text);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                dataGridView1.DataSource = dt;

                conn.Close();
            }
            else if (filtecbx.SelectedIndex == 1)
            {
                
                conn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "MarkaAra";
                cmd.Parameters.AddWithValue("markaAdi", isimaratxt.Text);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                dataGridView1.DataSource = dt;

                conn.Close();
            }

            else if (filtecbx.SelectedIndex == 2)
            {
                
                conn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "InfCatAra";
                cmd.Parameters.AddWithValue("category", isimaratxt.Text);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                dataGridView1.DataSource = dt;

                conn.Close();
            }
            else if (filtecbx.SelectedIndex == 3)
            {
                
                conn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "EngRateAralik";
                cmd.Parameters.AddWithValue("lowrate", isimaratxt.Text);
                cmd.Parameters.AddWithValue("highrate", textBox1.Text);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                dataGridView1.DataSource = dt;

                conn.Close();
            }
            else if (filtecbx.SelectedIndex == 4)
            {
                
                conn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "TakipciSayiAralik";
                cmd.Parameters.AddWithValue("low", isimaratxt.Text);
                cmd.Parameters.AddWithValue("high", textBox1.Text);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                dataGridView1.DataSource = dt;

                conn.Close();

            }

        }

        private void filtecbx_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (filtecbx.SelectedIndex == 0 || filtecbx.SelectedIndex == 1 || filtecbx.SelectedIndex == 2)
            {

                isimaratxt.Visible = true;
                arab.Visible = true;
            }
            else if (filtecbx.SelectedIndex == 3 || filtecbx.SelectedIndex == 4)
            {
                isimaratxt.Visible = true;
                arab.Visible = true;
                textBox1.Visible = true;
            }
            

            //if (filtecbx.SelectedIndex == 0)
            //{
            //    isimaratxt.Visible = true;
            //    arab.Visible = true;
            //}
            //else if (filtecbx.SelectedIndex == 1)
            //{
            //    isimaratxt.Visible = true;
            //    arab.Visible = true;
            //}
            //else if (filtecbx.SelectedIndex == 2)
            //{
            //    isimaratxt.Visible = true;
            //    arab.Visible = true;
            //}
        }

        private void anasayfab_Click(object sender, EventArgs e)
        {
            AnaSayfa asayfa = new AnaSayfa();
            this.Hide();
            asayfa.Show();
        }
    }
}
