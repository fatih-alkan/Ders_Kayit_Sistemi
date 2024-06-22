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
    public partial class yoneticipanel : Form
    {
        public yoneticipanel()
        {
            InitializeComponent();
        }
        public string ykullanici;
        public string ysifre;
        public string yid;

        int id = 0;
        yoneticipanel qr;
        SqlConnection baglas = new SqlConnection("Data Source=DESKTOP-34G14LP\\SQLEXPRESS;Initial Catalog=ders_kayit_sistemi;Integrated Security=True");

        private void ensonbu()
        {
            listalinandersler.Items.Clear();

            baglas.Open();
            SqlCommand komut = new SqlCommand("Select * From onayliders ", baglas);
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
                listalinandersler.Items.Add(ekle);
            }
            baglas.Close();
        }
        private void btnyeniders_Click(object sender, EventArgs e)
        {
            yeniders bagla = new yeniders();
            bagla.Show();
            this.Hide();
        }

        private void btngeri_Click(object sender, EventArgs e)
        {
            yoneticigiris bagla = new yoneticigiris();
            bagla.Show();
            this.Hide();
        }

        private void btnekle_Click(object sender, EventArgs e)
        {
            baglas.Open();
            SqlCommand komut = new SqlCommand("insert into onayliders(dersid,dersad,derskredi,dersakts,akademisyen,ograd,ogrsoyad,ogrno) values('" + cmbdersid.Text.ToString() + "','" + cmbdersad.Text.ToString() + "','" + cmbderskredi.Text.ToString() + "','" + cmbdersakts.Text.ToString() + "','" + cmbakademisyen.Text.ToString() + "','" + txtograd.Text.ToString() + "','" + txtogrsoyad.Text.ToString() + "','" + txtogrno.Text.ToString() + "')", baglas);
            komut.ExecuteNonQuery();
            baglas.Close();
            MessageBox.Show("Başarıyla Kaydedildi.");
            cmbdersid.Text = "";
            cmbdersad.Text = "";
            cmbderskredi.Text = "";
            cmbdersakts.Text = "";
            cmbakademisyen.Text = "";
            txtograd.Text = "";
            txtogrsoyad.Text = "";
            txtogrno.Text = "";
            ensonbu();

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
                    string dersid = dr["dersid"].ToString();
                    string dersad = dr["dersad"].ToString();
                    string derskredi = dr["derskredi"].ToString();
                    string dersakts = dr["dersakts"].ToString();
                    string akademisyen = dr["akademisyen"].ToString();
                    cmbdersid.Text = dersid;
                    cmbdersad.Text = dersad;
                    cmbderskredi.Text = derskredi;
                    cmbdersakts.Text = dersakts;
                    cmbakademisyen.Text = akademisyen;

                }
                dr.Close();
                baglas.Close();
            }
        }

        private void btnlistele_Click(object sender, EventArgs e)
        {
            ensonbu();
        }

        private void listalinandersler_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listalinandersler.SelectedItems.Count > 0)
            {
                id = int.Parse(listalinandersler.SelectedItems[0].SubItems[0].Text);

                cmbdersid.Text = listalinandersler.SelectedItems[0].SubItems[0].Text;
                cmbdersad.Text = listalinandersler.SelectedItems[0].SubItems[1].Text;
                cmbderskredi.Text = listalinandersler.SelectedItems[0].SubItems[2].Text;
                cmbdersakts.Text = listalinandersler.SelectedItems[0].SubItems[3].Text;
                cmbakademisyen.Text = listalinandersler.SelectedItems[0].SubItems[4].Text;
                txtograd.Text = listalinandersler.SelectedItems[0].SubItems[5].Text;
                txtogrsoyad.Text = listalinandersler.SelectedItems[0].SubItems[6].Text;
                txtogrno.Text = listalinandersler.SelectedItems[0].SubItems[7].Text;
            }
        }

        private void btnguncelle_Click(object sender, EventArgs e)
        {
            if (listalinandersler.SelectedItems.Count > 0)
            {
                baglas.Open();
                int selectedDersId = int.Parse(listalinandersler.SelectedItems[0].SubItems[0].Text);
                SqlCommand komut = new SqlCommand("UPDATE onayliders SET dersid=@dersid, dersad=@dersad, derskredi=@derskredi, akademisyen=@akademisyen, dersakts=@dersakts, ograd=@ograd, ogrsoyad=@ogrsoyad, ogrno=@ogrno WHERE dersid=@selectedDersId", baglas);
                komut.Parameters.AddWithValue("@dersid", cmbdersid.Text);
                komut.Parameters.AddWithValue("@dersad", cmbdersad.Text);
                komut.Parameters.AddWithValue("@derskredi", cmbderskredi.Text);
                komut.Parameters.AddWithValue("@akademisyen", cmbakademisyen.Text);
                komut.Parameters.AddWithValue("@dersakts", cmbdersakts.Text);
                komut.Parameters.AddWithValue("@ograd", txtograd.Text);
                komut.Parameters.AddWithValue("@ogrsoyad", txtogrsoyad.Text);
                komut.Parameters.AddWithValue("@ogrno", txtogrno.Text);
                komut.Parameters.AddWithValue("@selectedDersId", selectedDersId);

                komut.ExecuteNonQuery();
                baglas.Close();
                ensonbu();
                cmbdersid.Text = "";
                cmbdersad.Text = "";
                cmbderskredi.Text = "";
                cmbdersakts.Text = "";
                cmbakademisyen.Text = "";
                txtograd.Text = "";
                txtogrsoyad.Text = "";
                txtogrno.Text = "";
                MessageBox.Show("Ders bilgileri güncellendi.");
            }
            else
            {
                MessageBox.Show("Lütfen güncellemek için bir ders seçin.");
            }
        }

        private void btnsil_Click(object sender, EventArgs e)
        {
            baglas.Open();
            SqlCommand komut = new SqlCommand(" Delete From onayliders where dersid = " + id + "", baglas);
            komut.ExecuteNonQuery();
            MessageBox.Show("Ders bilgileri silindi.");
            baglas.Close();
            ensonbu();
            cmbdersid.Text = "";
            cmbdersad.Text = "";
            cmbderskredi.Text = "";
            cmbdersakts.Text = "";
            cmbakademisyen.Text = "";
            txtograd.Text = "";
            txtogrsoyad.Text = "";
            txtogrno.Text = "";
        }
    }
}
