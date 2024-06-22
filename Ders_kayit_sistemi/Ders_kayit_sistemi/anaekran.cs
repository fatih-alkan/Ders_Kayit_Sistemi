namespace Ders_kayit_sistemi
{
    public partial class anaekran : Form
    {
        public anaekran()
        {
            InitializeComponent();
        }

        private void btnkayitsayfasi_Click(object sender, EventArgs e)
        {
            kayit bagla = new kayit();
            bagla.Show();
            this.Hide();
        }

        private void btnyonetici_Click(object sender, EventArgs e)
        {
            yoneticigiris bagla = new yoneticigiris();
            bagla.Show();
            this.Hide();
        }

        private void btndanisman_Click(object sender, EventArgs e)
        {
            danismangiris bagla = new danismangiris();
            bagla.Show();
            this.Hide();
        }

        private void btnogrenci_Click(object sender, EventArgs e)
        {
            ogrgiris bagla = new ogrgiris();
            bagla.Show();
            this.Hide();
        }
    }
}
