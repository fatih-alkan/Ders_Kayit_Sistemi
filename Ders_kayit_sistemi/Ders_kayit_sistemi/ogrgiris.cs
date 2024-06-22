using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.SqlServer.Server;
using static System.Windows.Forms.DataFormats;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Ders_kayit_sistemi
{
    public partial class ogrgiris : Form
    {
        public ogrgiris()
        {
            InitializeComponent();

        }
        ogrencipanel fr;
        SqlCommand komut;
        SqlConnection bagla = new SqlConnection("Data Source=DESKTOP-34G14LP\\SQLEXPRESS;Initial Catalog=ders_kayit_sistemi;Integrated Security=True");
        public void btngiris_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtsifre.Text, out int sifre))
            {
                MessageBox.Show("Şifre alanına sadece sayısal değer girmelisiniz!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            bagla.Open();
            SqlCommand komut = new SqlCommand("SELECT * FROM ders_kayit_sistemi.dbo.ogrenciler WHERE kullanici_adi = @kullaniciAdi AND sifre = @sifre", bagla);
            komut.Parameters.AddWithValue("@kullaniciAdi", txtkullaniciadi.Text);
            komut.Parameters.AddWithValue("@sifre", txtsifre.Text);


            using (SqlDataReader dr = komut.ExecuteReader())
            {
                if (dr.Read())
                {
                    fr = new ogrencipanel();
                    fr.kullanici = dr["kullanici_adi"].ToString();
                    fr.sifre = dr["sifre"].ToString();
                    fr.ad = dr["ad"].ToString();
                    fr.soyad = dr["soyad"].ToString();
                    fr.no = dr["numara"].ToString();

                    fr.Owner = this;
                    fr.Show();
                    this.Hide();
                    yazdir();

                }
                else
                {
                    MessageBox.Show("Kullanıcı adı veya şifre yanlış!");
                }

                dr.Close();

                bagla.Close();
            }

        }
        public void yazdir()
        {      
                fr.lblad.Text = fr.ad;
                fr.lblsoyad.Text = fr.soyad;
                fr.lblnumara.Text = fr.no;
        }

        private void btnkayitsayfasi_Click(object sender, EventArgs e)
        {
            kayit bagla = new kayit();
            bagla.Show();
            this.Hide();
        }

        private void btngeri_Click(object sender, EventArgs e)
        {
            anaekran bagla = new anaekran();
            bagla.Show();
            this.Hide();
            
        }

        
    }
}
