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

namespace Ders_kayit_sistemi
{
    public partial class danismangiris : Form
    {
        public danismangiris()
        {
            InitializeComponent();
        }
        SqlConnection bagla = new SqlConnection("Data Source=DESKTOP-34G14LP\\SQLEXPRESS;Initial Catalog=ders_kayit_sistemi;Integrated Security=True");

        private void btngiris_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtsifre.Text, out int dsifre))
            {
                MessageBox.Show("Şifre alanına sadece sayısal değer girmelisiniz!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            bagla.Open();
            SqlCommand komut = new SqlCommand("SELECT * FROM ders_kayit_sistemi.dbo.danisman WHERE kullanici_adi = @kullaniciadi AND sifre = @sifre", bagla);
            SqlCommand komut1 = new SqlCommand("SELECT * FROM ders_kayit_sistemi.dbo.bekleyendersler", bagla);

            komut.Parameters.AddWithValue("kullaniciadi", txtkullaniciadi.Text);
            komut.Parameters.AddWithValue("sifre", txtsifre.Text);
            using (SqlDataReader dr = komut.ExecuteReader())
            {
                if (dr.Read())
                {
                    string kullaniciAdi = dr["kullanici_adi"].ToString();
                    string sifre = dr["sifre"].ToString();
                    dr.Close();

                    danismanpanel panel = new danismanpanel();
                    panel.dkullanici = kullaniciAdi;
                    panel.dsifre = sifre;

                    using (SqlDataReader tr = komut1.ExecuteReader())
                    {
                        try
                        {
                            while (tr.Read())
                            {
                                string ad = tr["ograd"].ToString();
                                string soyad = tr["ogrsoyad"].ToString();
                                string numara = tr["ogrno"].ToString();

                                bool varMi = false;
                                foreach (ListViewItem item in panel.listogrenci.Items)
                                {
                                    if (item.SubItems[0].Text == ad && item.SubItems[1].Text == soyad && item.SubItems[2].Text == numara)
                                    {
                                        varMi = true;
                                        break;
                                    }
                                }
                                if (!varMi)
                                {
                                    ListViewItem item = new ListViewItem(ad);
                                    item.SubItems.Add(soyad);
                                    item.SubItems.Add(numara);
                                    panel.listogrenci.Items.Add(item);
                                }
                            }                     
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Veri okuma hatası: " + ex.Message);
                        }
                    }
                    panel.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Kullanıcı adı veya şifre yanlış!");
                }
            }
            bagla.Close();
        
    }
        private void btngeri_Click(object sender, EventArgs e)
        {
            anaekran bagla = new anaekran();
            bagla.Show();
            this.Hide();
        }
    }
}
