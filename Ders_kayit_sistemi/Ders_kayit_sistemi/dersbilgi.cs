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
    public partial class dersbilgi : Form
    {
        public dersbilgi()
        {
            InitializeComponent();
        }
        public string kullanici;
        public string sifre;
        public string ad;
        public string soyad;
        public string no;
        ogrencipanel xr;
        SqlConnection bagla = new SqlConnection("Data Source=DESKTOP-34G14LP\\SQLEXPRESS;Initial Catalog=ders_kayit_sistemi;Integrated Security=True");
        SqlConnection baglas = new SqlConnection("Data Source=DESKTOP-34G14LP\\SQLEXPRESS;Initial Catalog=ders_kayit_sistemi;Integrated Security=True");

        private void ders()
        {
            listdersbilgi.Items.Clear();
            bagla.Open();
            SqlCommand komut = new SqlCommand("Select * From dersler", bagla);
            SqlDataReader oku = komut.ExecuteReader();


            while (oku.Read())
            {
                ListViewItem ekle = new ListViewItem();
                ekle.Text = oku["dersid"].ToString();
                ekle.SubItems.Add(oku["dersad"].ToString());
                ekle.SubItems.Add(oku["derskredi"].ToString());
                ekle.SubItems.Add(oku["dersakts"].ToString());
                ekle.SubItems.Add(oku["akademisyen"].ToString());             
                listdersbilgi.Items.Add(ekle);
            }
            bagla.Close();
        }

        private void btngeri_Click(object sender, EventArgs e)
        {
            baglas.Open();
            SqlCommand komut = new SqlCommand("SELECT * FROM ders_kayit_sistemi.dbo.ogrenciler WHERE ad = @adi AND soyad = @soyadi", baglas);
            komut.Parameters.AddWithValue("@adi", lblad.Text);
            komut.Parameters.AddWithValue("@soyadi", lblsoyad.Text);


            using (SqlDataReader dr = komut.ExecuteReader())
            {
                if (dr.Read())
                {

                    xr = new ogrencipanel();


                    xr.kullanici = dr["kullanici_adi"].ToString();
                    xr.sifre = dr["sifre"].ToString();
                    xr.ad = dr["ad"].ToString();
                    xr.soyad = dr["soyad"].ToString();
                    xr.no = dr["numara"].ToString();


                    xr.Owner = this;
                    xr.Show();

                    this.Hide();

                }

                dr.Close();
                baglas.Close();
            }
            yazdir();

        }
        public void yazdir()
        {
            xr.lblad.Text = xr.ad;
            xr.lblsoyad.Text = xr.soyad;
            xr.lblnumara.Text = xr.no;
        }

        private void btndersbilgi_Click(object sender, EventArgs e)
        {
            ders();
        }
    }
}
