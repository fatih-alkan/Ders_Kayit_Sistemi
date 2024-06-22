using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Ders_kayit_sistemi
{
    public partial class alinandersler : Form
    {
        public alinandersler()
        {
            InitializeComponent();
        }
        ogrencipanel xr;
        public string kullanici;
        public string sifre;
        public string ad;
        public string soyad;
        public string no;

        public System.Windows.Forms.ListView GetListView()
        {
            return listalinandersler;
        }

        SqlConnection baglas = new SqlConnection("Data Source=DESKTOP-34G14LP\\SQLEXPRESS;Initial Catalog=ders_kayit_sistemi;Integrated Security=True");
        private void ensonbu()
        {
            listalinandersler.Items.Clear();
            baglas.Open();
            SqlCommand komut = new SqlCommand("SELECT * FROM ders_kayit_sistemi.dbo.bekleyendersler WHERE ograd = @adi AND ogrsoyad = @soyadi", baglas);
            komut.Parameters.AddWithValue("@adi", lblad.Text);
            komut.Parameters.AddWithValue("@soyadi", lblsoyad.Text);
            SqlDataReader oku = komut.ExecuteReader();


            while (oku.Read())
            {
                ListViewItem ekle = new ListViewItem();
                ekle.Text = oku["dersid"].ToString();
                ekle.SubItems.Add(oku["dersad"].ToString());
                ekle.SubItems.Add(oku["derskredi"].ToString());
                ekle.SubItems.Add(oku["dersakts"].ToString());
                ekle.SubItems.Add(oku["akademisyen"].ToString());
                ekle.SubItems.Add(oku["ograd"].ToString());
                ekle.SubItems.Add(oku["ogrsoyad"].ToString());
                ekle.SubItems.Add(oku["ogrno"].ToString());
                ekle.SubItems.Add("Onay Bekliyor");
                listalinandersler.Items.Add(ekle);
            }
            baglas.Close();
            baglas.Open();
            SqlCommand komut2 = new SqlCommand("Select * From onayliders WHERE ograd = @Adi AND ogrsoyad = @Soyadi", baglas);
            komut2.Parameters.AddWithValue("@Adi", lblad.Text);
            komut2.Parameters.AddWithValue("@Soyadi", lblsoyad.Text);
            SqlDataReader oku1 = komut2.ExecuteReader();


            while (oku1.Read())
            {
                ListViewItem ekle = new ListViewItem();
                ekle.Text = oku1["dersid"].ToString();
                ekle.SubItems.Add(oku1["dersad"].ToString());
                ekle.SubItems.Add(oku1["derskredi"].ToString());
                ekle.SubItems.Add(oku1["dersakts"].ToString());
                ekle.SubItems.Add(oku1["akademisyen"].ToString());
                ekle.SubItems.Add(oku1["ograd"].ToString());
                ekle.SubItems.Add(oku1["ogrsoyad"].ToString());
                ekle.SubItems.Add(oku1["ogrno"].ToString());
                ekle.SubItems.Add("Onaylandı");
                listalinandersler.Items.Add(ekle);
            }
            baglas.Close();
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

        private void btnlistele_Click(object sender, EventArgs e)
        {
            ensonbu();
        }
    }
}
