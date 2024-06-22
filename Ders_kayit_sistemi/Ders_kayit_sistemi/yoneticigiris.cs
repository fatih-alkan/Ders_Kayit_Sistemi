using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Ders_kayit_sistemi
{
    public partial class yoneticigiris : Form
    {
        public yoneticigiris()
        {
            InitializeComponent();
        }
        yoneticipanel xr;
        SqlConnection bagla = new SqlConnection("Data Source=DESKTOP-34G14LP\\SQLEXPRESS;Initial Catalog=ders_kayit_sistemi;Integrated Security=True");

        private void btngiris_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtsifre.Text, out int sifre))
            {
                MessageBox.Show("Şifre alanına sadece sayısal değer girmelisiniz!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (bagla.State == ConnectionState.Closed)
            {
                bagla.Open();
            }
            SqlCommand komut = new SqlCommand("SELECT * FROM ders_kayit_sistemi.dbo.yonetici WHERE kullanici_id = @kullaniciadi AND sifre = @sifre", bagla);
            komut.Parameters.AddWithValue("kullaniciadi", txtkullaniciadi.Text);
            komut.Parameters.AddWithValue("sifre", txtsifre.Text);

            using (SqlDataReader dr = komut.ExecuteReader())
            {
                if (dr.Read())
                {
                    xr = new yoneticipanel();
                    xr.ykullanici = dr["kullanici_id"].ToString();
                    xr.ysifre = dr["sifre"].ToString();
                    xr.Show();
                    this.Hide();
                    dr.Close();

                    bagla.Close();
                    ders();

                }
                else
                {
                    MessageBox.Show("Kullanıcı adı veya şifre yanlış!");
                }
            }
        }
        private void btngeri_Click_1(object sender, EventArgs e)
        {
            anaekran bagla = new anaekran();
            bagla.Show();
            this.Hide();
        }
        private void ders()
        {
            bagla.Open();
            SqlCommand komut = new SqlCommand("Select * From dersler", bagla);
            SqlDataReader oku = komut.ExecuteReader();

            while (oku.Read())
            {
                xr.cmbdersid.Items.Add(oku["dersid"].ToString());
                xr.cmbdersad.Items.Add(oku["dersad"].ToString());
                xr.cmbderskredi.Items.Add(oku["derskredi"].ToString());
                xr.cmbdersakts.Items.Add(oku["dersakts"].ToString());
                xr.cmbakademisyen.Items.Add(oku["akademisyen"].ToString());
            }
            bagla.Close();
        }
    }
}
