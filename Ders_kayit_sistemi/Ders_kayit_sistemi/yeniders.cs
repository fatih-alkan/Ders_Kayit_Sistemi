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
    public partial class yeniders : Form
    {
        public yeniders()
        {
            InitializeComponent();
        }
        yoneticipanel xr;
        SqlConnection bagla = new SqlConnection("Data Source=DESKTOP-34G14LP\\SQLEXPRESS;Initial Catalog=ders_kayit_sistemi;Integrated Security=True");

        private void btngeri_Click(object sender, EventArgs e)
        {
            xr = new yoneticipanel();
            xr.Show();
            this.Hide();
            ders();
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
        private void btnekle_Click(object sender, EventArgs e)
        {
            bagla.Open();
            SqlCommand komut = new SqlCommand("insert into dersler(dersad,derskredi,dersakts,akademisyen) values('" + txtdersad.Text.ToString() + "','" + txtderskredi.Text.ToString() + "','" + txtdersakts.Text.ToString() + "' ,'" + txtakademisyen.Text.ToString() + "')", bagla);
            komut.ExecuteNonQuery();
            bagla.Close();
            
            txtdersad.Text = "";
            txtderskredi.Text = "";
            txtdersakts.Text = "";
            txtakademisyen.Text = "";
            MessageBox.Show("Başarıyla Kaydedildi.");
        }
    }
}
