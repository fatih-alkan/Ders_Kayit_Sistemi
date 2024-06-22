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
    public partial class derskayit : Form
    {

        public derskayit()
        {
            InitializeComponent();
        }
        ogrencipanel xr;
        derskayit tr;
        public string kullanici;
        public string sifre;
        public string ad;
        public string soyad;
        public string no;
        public string dersid;
        public string dersad;
        public string derskredi;
        public string dersakts;
        public string akademisyen;
        

        SqlConnection baglas = new SqlConnection("Data Source=DESKTOP-34G14LP\\SQLEXPRESS;Initial Catalog=ders_kayit_sistemi;Integrated Security=True");
        public string oku;
        
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

        private void btnderskaydet_Click(object sender, EventArgs e)
        {
            baglas.Open();

            SqlCommand komut = new SqlCommand("INSERT INTO bekleyendersler(dersid, dersad, derskredi, dersakts, akademisyen, ograd, ogrsoyad, ogrno) VALUES ('" + cmbdersid.Text + "','" + cmbdersad.Text + "','" + cmbkredi.Text + "','" + cmbakts.Text + "','" + cmbakademisyen.Text + "','" + lblad.Text + "','" + lblsoyad.Text + "','" + Convert.ToInt32(lblnumara.Text) + "')", baglas);
            komut.ExecuteNonQuery();
            MessageBox.Show("Başarıyla Kaydedildi.");
            cmbdersid.Text = "";
            cmbdersad.Text = "";
            cmbkredi.Text = "";
            cmbakts.Text = "";
            cmbakademisyen.Text = "";
            baglas.Close();
        }
        private void btndoldur_Click(object sender, EventArgs e)
        {
            baglas.Open();
            SqlCommand komut = new SqlCommand("SELECT * FROM ders_kayit_sistemi.dbo.dersler WHERE dersid = @id", baglas);
            komut.Parameters.AddWithValue("@id", cmbdersid.Text);
            using (SqlDataReader dr = komut.ExecuteReader())
            {
                if (dr.Read())
                {
                    tr = new derskayit();
                    tr.dersid = dr["dersid"].ToString();
                    tr.dersad = dr["dersad"].ToString();
                    tr.derskredi = dr["derskredi"].ToString();
                    tr.dersakts = dr["dersakts"].ToString();
                    tr.akademisyen = dr["akademisyen"].ToString();
                    cmbdersid.Text = tr.dersid;
                    cmbdersad.Text = tr.dersad;
                    cmbkredi.Text = tr.derskredi;
                    cmbakts.Text = tr.dersakts;
                    cmbakademisyen.Text = tr.akademisyen;

                    tr.Owner = this;
                }
                dr.Close();
                baglas.Close();
            }
        }
    }
}
