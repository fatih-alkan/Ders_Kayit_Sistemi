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
using static System.Windows.Forms.DataFormats;

namespace Ders_kayit_sistemi
{
    public partial class ogrencipanel : Form
    {
        derskayit derskayit = new derskayit();
        public ogrencipanel()
        {
            InitializeComponent();
        }
        derskayit xr;
        dersbilgi qr;
        alinandersler cr;
        public string kullanici;
        public string sifre;
        public string ad;
        public string soyad;
        public string no;
        SqlConnection baglas = new SqlConnection("Data Source=DESKTOP-34G14LP\\SQLEXPRESS;Initial Catalog=ders_kayit_sistemi;Integrated Security=True");
        private void btndersbilgi_Click(object sender, EventArgs e)
        {
            baglas.Open();
            SqlCommand komut = new SqlCommand("SELECT * FROM ders_kayit_sistemi.dbo.ogrenciler WHERE ad = @adi AND soyad = @soyadi", baglas);
            komut.Parameters.AddWithValue("@adi", lblad.Text);
            komut.Parameters.AddWithValue("@soyadi", lblsoyad.Text);
            using (SqlDataReader dr = komut.ExecuteReader())
            {
                if (dr.Read())
                {
                    qr = new dersbilgi();
                    qr.kullanici = dr["kullanici_adi"].ToString();
                    qr.sifre = dr["sifre"].ToString();
                    qr.ad = dr["ad"].ToString();
                    qr.soyad = dr["soyad"].ToString();
                    qr.no = dr["numara"].ToString();

                    qr.Owner = this;
                    qr.Show();
                    this.Hide();
                }
                dr.Close();
                baglas.Close();
            }
            qr.lblad.Text = qr.ad;
            qr.lblsoyad.Text = qr.soyad;
            qr.lblnumara.Text = qr.no;
        }
        private void btnderskayit_Click(object sender, EventArgs e)
        {
            baglas.Open();
            SqlCommand komut = new SqlCommand("SELECT * FROM ders_kayit_sistemi.dbo.ogrenciler WHERE ad = @adi AND soyad = @soyadi", baglas);
            komut.Parameters.AddWithValue("@adi", lblad.Text);
            komut.Parameters.AddWithValue("@soyadi", lblsoyad.Text);
            using (SqlDataReader dr = komut.ExecuteReader())
            {
                if (dr.Read())
                {
                    xr = new derskayit();
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
            ders();
        }
        public void yazdir()
        {
            xr.lblad.Text = xr.ad;
            xr.lblsoyad.Text = xr.soyad;
            xr.lblnumara.Text = xr.no;
        }
        private void ders()
        {
            baglas.Open();
            SqlCommand komut = new SqlCommand("Select * From dersler", baglas);
            SqlDataReader oku = komut.ExecuteReader();

            while (oku.Read())
            {
                xr.cmbdersid.Items.Add(oku["dersid"].ToString());
            }
            baglas.Close();
        }
        private void btnalinandersler_Click(object sender, EventArgs e)
        {
            baglas.Open();
            SqlCommand komut = new SqlCommand("SELECT * FROM ders_kayit_sistemi.dbo.ogrenciler WHERE ad = @adi AND soyad = @soyadi", baglas);
            komut.Parameters.AddWithValue("@adi", lblad.Text);
            komut.Parameters.AddWithValue("@soyadi", lblsoyad.Text);
            using (SqlDataReader dr = komut.ExecuteReader())
            {
                if (dr.Read())
                {
                    cr = new alinandersler();
                    cr.kullanici = dr["kullanici_adi"].ToString();
                    cr.sifre = dr["sifre"].ToString();
                    cr.ad = dr["ad"].ToString();
                    cr.soyad = dr["soyad"].ToString();
                    cr.no = dr["numara"].ToString();

                    cr.Owner = this;
                    cr.Show();
                    this.Hide();
                }
                dr.Close();
                baglas.Close();
            }
            cr.lblad.Text = cr.ad;
            cr.lblsoyad.Text = cr.soyad;
            cr.lblnumara.Text = cr.no;
        }
        private void btngeri_Click(object sender, EventArgs e)
        {
            ogrgiris bagla = new ogrgiris();
            bagla.Show();
            this.Hide();
        }

    }
}
