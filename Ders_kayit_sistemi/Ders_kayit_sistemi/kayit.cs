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
    public partial class kayit : Form
    {
        public kayit()
        {
            InitializeComponent();
        }
        SqlConnection bagla = new SqlConnection("Data Source=DESKTOP-34G14LP\\SQLEXPRESS;Initial Catalog=ders_kayit_sistemi;Integrated Security=True");
        private void btngeri_Click(object sender, EventArgs e)
        {
            anaekran bagla = new anaekran();
            bagla.Show();
            this.Hide();
        }

        private void btngiris_Click(object sender, EventArgs e)
        {
            ogrgiris bagla = new ogrgiris();
            bagla.Show();
            this.Hide();
        }

        private void btnkayitol_Click(object sender, EventArgs e)
        {
            bagla.Open();
            SqlCommand komut = new SqlCommand("insert into ogrenciler(ad,soyad,numara,kullanici_adi,sifre) values('" + txtad.Text.ToString() + "','" + txtsoyad.Text.ToString() + "','" + txtno.Text.ToString() + "','" + txtkullanici_adi.Text.ToString() + "' ,'" + txtsifre.Text.ToString() + "')", bagla);
            komut.ExecuteNonQuery();
            bagla.Close();
            txtad.Text = "";
            txtsoyad.Text = "";
            txtkullanici_adi.Text = "";
            txtno.Text = "";
            txtsifre.Text = "";
            MessageBox.Show("Başarıyla Kaydedildi.");
        }
    }
}
