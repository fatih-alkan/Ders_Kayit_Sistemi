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
using ListView = System.Windows.Forms.ListView;

namespace Ders_kayit_sistemi
{

    public partial class danismanpanel : Form
    {
        public danismanpanel()
        {
            InitializeComponent();
        }
        public string dkullanici;
        public string dsifre;
        public string did;

        SqlConnection bagla = new SqlConnection("Data Source=DESKTOP-34G14LP\\SQLEXPRESS;Initial Catalog=ders_kayit_sistemi;Integrated Security=True");
        private void btngeri_Click(object sender, EventArgs e)
        {
            danismangiris bagla = new danismangiris();
            bagla.Show();
            this.Hide();
        }
        private void btnlistele_Click(object sender, EventArgs e)
        {
            if (listalinandersler.SelectedItems.Count > 0)
            {
                string dersId = listalinandersler.SelectedItems[0].SubItems[0].Text;
                string dersAd = listalinandersler.SelectedItems[0].SubItems[1].Text;
                string dersKredi = listalinandersler.SelectedItems[0].SubItems[2].Text;
                string dersAkts = listalinandersler.SelectedItems[0].SubItems[3].Text;
                string akademisyen = listalinandersler.SelectedItems[0].SubItems[4].Text;

                string ogrAd = listogrenci.SelectedItems[0].SubItems[0].Text;
                string ogrSoyad = listogrenci.SelectedItems[0].SubItems[1].Text;
                string ogrNo = listogrenci.SelectedItems[0].SubItems[2].Text;


            }
            if (listogrenci.SelectedItems.Count > 0)
            {
                string ograd = listogrenci.SelectedItems[0].SubItems[0].Text;
                string ogrsoyad = listogrenci.SelectedItems[0].SubItems[1].Text;
                string ogrno = listogrenci.SelectedItems[0].SubItems[2].Text;
                bagla.Open();
                SqlCommand komut = new SqlCommand("SELECT * FROM bekleyendersler WHERE ograd = @ad AND ogrsoyad = @soyad AND ogrno = @no", bagla);
                komut.Parameters.AddWithValue("@ad", ograd);
                komut.Parameters.AddWithValue("@soyad", ogrsoyad);
                komut.Parameters.AddWithValue("@no", ogrno);

                using (SqlDataReader dr = komut.ExecuteReader())
                {
                    try
                    {
                        listalinandersler.Items.Clear();
                        while (dr.Read())
                        {
                            ListViewItem item = new ListViewItem(dr["dersid"].ToString());
                            item.SubItems.Add(dr["dersad"].ToString());
                            item.SubItems.Add(dr["derskredi"].ToString());
                            item.SubItems.Add(dr["dersakts"].ToString());
                            item.SubItems.Add(dr["akademisyen"].ToString());
                            listalinandersler.Items.Add(item);
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Veri okuma hatası: " + ex.Message);
                    }
                }
                bagla.Close();
            }
            else
            {
                MessageBox.Show("Lütfen bir öğrenci seçin!");
            }
        }

        private void btnonayla_Click(object sender, EventArgs e)
        {

            if (listalinandersler.SelectedItems.Count > 0)
            {
                string dersId = listalinandersler.SelectedItems[0].SubItems[0].Text;
                string dersAd = listalinandersler.SelectedItems[0].SubItems[1].Text;
                string dersKredi = listalinandersler.SelectedItems[0].SubItems[2].Text;
                string dersAkts = listalinandersler.SelectedItems[0].SubItems[3].Text;
                string akademisyen = listalinandersler.SelectedItems[0].SubItems[4].Text;

                string ogrAd = listogrenci.SelectedItems[0].SubItems[0].Text;
                string ogrSoyad = listogrenci.SelectedItems[0].SubItems[1].Text;
                string ogrNo = listogrenci.SelectedItems[0].SubItems[2].Text;

                string silSorgusu = "DELETE FROM bekleyendersler WHERE dersid = @dersId AND ograd = @ogrAd AND ogrsoyad = @ogrSoyad AND ogrno = @ogrNo";
                using (SqlCommand silKomut = new SqlCommand(silSorgusu, bagla))
                {
                    silKomut.Parameters.AddWithValue("@dersId", dersId);
                    silKomut.Parameters.AddWithValue("@ogrAd", ogrAd);
                    silKomut.Parameters.AddWithValue("@ogrSoyad", ogrSoyad);
                    silKomut.Parameters.AddWithValue("@ogrNo", ogrNo);

                    try
                    {
                        bagla.Open();
                        silKomut.ExecuteNonQuery();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Bekleyen ders silme hatası: " + ex.Message);
                    }
                    finally
                    {
                        bagla.Close();
                    }
                }
                string ekleSorgusu = "INSERT INTO onayliders (dersid, dersad, derskredi, dersakts, akademisyen, ograd, ogrsoyad, ogrno) " + "VALUES (@dersId, @dersAd, @dersKredi, @dersAkts, @akademisyen, @ogrAd, @ogrSoyad, @ogrNo)";
                using (SqlCommand ekleKomut = new SqlCommand(ekleSorgusu, bagla))
                {
                    ekleKomut.Parameters.AddWithValue("@dersId", dersId);
                    ekleKomut.Parameters.AddWithValue("@dersAd", dersAd);
                    ekleKomut.Parameters.AddWithValue("@dersKredi", dersKredi);
                    ekleKomut.Parameters.AddWithValue("@dersAkts", dersAkts);
                    ekleKomut.Parameters.AddWithValue("@akademisyen", akademisyen);
                    ekleKomut.Parameters.AddWithValue("@ogrAd", ogrAd);
                    ekleKomut.Parameters.AddWithValue("@ogrSoyad", ogrSoyad);
                    ekleKomut.Parameters.AddWithValue("@ogrNo", ogrNo);

                    try
                    {
                        bagla.Open();
                        ekleKomut.ExecuteNonQuery();
                        MessageBox.Show("Ders başarıyla onaylandı!");
                        listalinandersler.SelectedItems[0].Remove();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Veritabanına ekleme hatası: " + ex.Message);
                    }
                    finally
                    {
                        bagla.Close();
                    }
                }
            }
            else
            {
                MessageBox.Show("Lütfen bir ders seçin!");
            }
            if (listalinandersler.Items.Count == 0)
            {
                if (listogrenci.SelectedItems.Count > 0)
                {
                   string ogrAd = listogrenci.SelectedItems[0].SubItems[0].Text;
                   string ogrSoyad = listogrenci.SelectedItems[0].SubItems[1].Text;
                   string ogrNo = listogrenci.SelectedItems[0].SubItems[2].Text;
                    listogrenci.Items.Remove(listogrenci.SelectedItems[0]);
                }
                else
                {
                    MessageBox.Show("Lütfen bir öğrenci seçin!");
                }
            }
        }

        private void btnreddet_Click(object sender, EventArgs e)
        {
            string dersId = listalinandersler.SelectedItems[0].SubItems[0].Text;
            string dersAd = listalinandersler.SelectedItems[0].SubItems[1].Text;
            string dersKredi = listalinandersler.SelectedItems[0].SubItems[2].Text;
            string dersAkts = listalinandersler.SelectedItems[0].SubItems[3].Text;
            string akademisyen = listalinandersler.SelectedItems[0].SubItems[4].Text;

            string ogrAd = listogrenci.SelectedItems[0].SubItems[0].Text;
            string ogrSoyad = listogrenci.SelectedItems[0].SubItems[1].Text;
            string ogrNo = listogrenci.SelectedItems[0].SubItems[2].Text;

            string silSorgusu = "DELETE FROM bekleyendersler WHERE dersid = @dersId AND ograd = @ogrAd AND ogrsoyad = @ogrSoyad AND ogrno = @ogrNo";
            using (SqlCommand silKomut = new SqlCommand(silSorgusu, bagla))
            {
                silKomut.Parameters.AddWithValue("@dersId", dersId);
                silKomut.Parameters.AddWithValue("@ogrAd", ogrAd);
                silKomut.Parameters.AddWithValue("@ogrSoyad", ogrSoyad);
                silKomut.Parameters.AddWithValue("@ogrNo", ogrNo);
                try
                {
                    bagla.Open();
                    silKomut.ExecuteNonQuery();                  
                    MessageBox.Show("Ders başarıyla reddedildi!");
                    listalinandersler.SelectedItems[0].Remove();

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Bekleyen ders silme hatası: " + ex.Message);
                }
                finally
                {
                    bagla.Close();
                }
            }
            if (listalinandersler.Items.Count == 0)
            {
                if (listogrenci.SelectedItems.Count > 0)
                {
                    ogrAd = listogrenci.SelectedItems[0].SubItems[0].Text;
                    ogrSoyad = listogrenci.SelectedItems[0].SubItems[1].Text;
                    ogrNo = listogrenci.SelectedItems[0].SubItems[2].Text;
                    listogrenci.Items.Remove(listogrenci.SelectedItems[0]);
                }
                else
                {
                    MessageBox.Show("Lütfen bir öğrenci seçin!");
                }
            }


        }
    }
}
