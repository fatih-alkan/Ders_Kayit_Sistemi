namespace Ders_kayit_sistemi
{
    partial class ogrgiris
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            txtkullaniciadi = new TextBox();
            txtsifre = new TextBox();
            label1 = new Label();
            label2 = new Label();
            btngiris = new Button();
            label9 = new Label();
            btnkayitsayfasi = new Button();
            btngeri = new Button();
            SuspendLayout();
            // 
            // txtkullaniciadi
            // 
            txtkullaniciadi.Location = new Point(189, 104);
            txtkullaniciadi.Name = "txtkullaniciadi";
            txtkullaniciadi.Size = new Size(208, 27);
            txtkullaniciadi.TabIndex = 0;
            // 
            // txtsifre
            // 
            txtsifre.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 162);
            txtsifre.Location = new Point(189, 155);
            txtsifre.Name = "txtsifre";
            txtsifre.PasswordChar = '*';
            txtsifre.Size = new Size(208, 30);
            txtsifre.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(58, 107);
            label1.Name = "label1";
            label1.Size = new Size(112, 20);
            label1.TabIndex = 2;
            label1.Text = "KULLANICI ADI:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(122, 158);
            label2.Name = "label2";
            label2.Size = new Size(48, 20);
            label2.TabIndex = 3;
            label2.Text = "ŞİFRE:";
            // 
            // btngiris
            // 
            btngiris.Location = new Point(225, 203);
            btngiris.Name = "btngiris";
            btngiris.Size = new Size(142, 50);
            btngiris.TabIndex = 4;
            btngiris.Text = "GİRİŞ";
            btngiris.UseVisualStyleBackColor = true;
            btngiris.Click += btngiris_Click;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label9.Location = new Point(103, 26);
            label9.Name = "label9";
            label9.Size = new Size(336, 38);
            label9.TabIndex = 19;
            label9.Text = "ÖĞRENCİ GİRİŞ SAYFASI";
            // 
            // btnkayitsayfasi
            // 
            btnkayitsayfasi.Location = new Point(30, 292);
            btnkayitsayfasi.Name = "btnkayitsayfasi";
            btnkayitsayfasi.Size = new Size(140, 38);
            btnkayitsayfasi.TabIndex = 20;
            btnkayitsayfasi.Text = "KAYIT OL";
            btnkayitsayfasi.UseVisualStyleBackColor = true;
            btnkayitsayfasi.Click += btnkayitsayfasi_Click;
            // 
            // btngeri
            // 
            btngeri.Location = new Point(394, 293);
            btngeri.Name = "btngeri";
            btngeri.Size = new Size(118, 36);
            btngeri.TabIndex = 21;
            btngeri.Text = "ANA SAYFA";
            btngeri.UseVisualStyleBackColor = true;
            btngeri.Click += btngeri_Click;
            // 
            // ogrgiris
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(535, 343);
            Controls.Add(btngeri);
            Controls.Add(btnkayitsayfasi);
            Controls.Add(label9);
            Controls.Add(btngiris);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtsifre);
            Controls.Add(txtkullaniciadi);
            Name = "ogrgiris";
            Text = "ogrgiris";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private Label label2;
        private Button btngiris;
        private Label label9;
        private Button btnkayitsayfasi;
        private Button btngeri;
        public TextBox txtkullaniciadi;
        public TextBox txtsifre;
    }
}