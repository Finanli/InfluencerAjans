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
    public partial class Giris : Form
    {
        public Giris()
        {
            InitializeComponent();
        }
        SqlConnection conn = new SqlConnection("Data Source = LAPTOP-DI6H08K1; Initial Catalog=Ajans; Integrated Security =true;");

        

        private void girisb_Click(object sender, EventArgs e)
        {
            
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "Giris";
            cmd.Parameters.AddWithValue("kullaniciAd", kuladitxt.Text);
            cmd.Parameters.AddWithValue("Sifre", sifretxt.Text);

            conn.Open();
            SqlDataReader dr;
            dr= cmd.ExecuteReader();

            if (dr.Read())
            {
                MessageBox.Show("Tebrikler Hoşgeldiniz");
                AnaSayfa anaSayfa = new AnaSayfa();
                anaSayfa.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Hatalı tekrar dene");
                kuladitxt.Clear();
                sifretxt.Clear();
            }
            conn.Close();
        }
    }
}
