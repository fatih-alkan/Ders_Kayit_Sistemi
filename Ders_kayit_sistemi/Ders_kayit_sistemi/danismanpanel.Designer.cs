namespace Ders_kayit_sistemi
{
    partial class danismanpanel
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
            listogrenci = new ListView();
            ograd = new ColumnHeader();
            ogrsoyad = new ColumnHeader();
            ogrno = new ColumnHeader();
            listalinandersler = new ListView();
            dersid = new ColumnHeader();
            dersad = new ColumnHeader();
            derskredi = new ColumnHeader();
            dersakts = new ColumnHeader();
            akademisyen = new ColumnHeader();
            btnonayla = new Button();
            btnreddet = new Button();
            txtredmsj = new RichTextBox();
            btnlistele = new Button();
            label9 = new Label();
            btngeri = new Button();
            SuspendLayout();
            // 
            // listogrenci
            // 
            listogrenci.Columns.AddRange(new ColumnHeader[] { ograd, ogrsoyad, ogrno });
            listogrenci.Location = new Point(35, 136);
            listogrenci.Name = "listogrenci";
            listogrenci.Size = new Size(381, 329);
            listogrenci.TabIndex = 2;
            listogrenci.UseCompatibleStateImageBehavior = false;
            listogrenci.View = View.Details;
            // 
            // ograd
            // 
            ograd.Text = "ÖĞRENCİ AD";
            ograd.Width = 120;
            // 
            // ogrsoyad
            // 
            ogrsoyad.Text = "ÖĞRENCİ SOYAD";
            ogrsoyad.Width = 130;
            // 
            // ogrno
            // 
            ogrno.Text = "ÖĞRENCİ NO";
            ogrno.Width = 100;
            // 
            // listalinandersler
            // 
            listalinandersler.Columns.AddRange(new ColumnHeader[] { dersid, dersad, derskredi, dersakts, akademisyen });
            listalinandersler.Location = new Point(448, 136);
            listalinandersler.Name = "listalinandersler";
            listalinandersler.Size = new Size(587, 329);
            listalinandersler.TabIndex = 3;
            listalinandersler.UseCompatibleStateImageBehavior = false;
            listalinandersler.View = View.Details;
            // 
            // dersid
            // 
            dersid.Text = "DERS ID";
            dersid.Width = 70;
            // 
            // dersad
            // 
            dersad.Text = "DERS ADI";
            dersad.TextAlign = HorizontalAlignment.Center;
            dersad.Width = 140;
            // 
            // derskredi
            // 
            derskredi.Text = "DERS KREDİ";
            derskredi.TextAlign = HorizontalAlignment.Center;
            derskredi.Width = 95;
            // 
            // dersakts
            // 
            dersakts.Text = "DERS AKTS";
            dersakts.TextAlign = HorizontalAlignment.Center;
            dersakts.Width = 90;
            // 
            // akademisyen
            // 
            akademisyen.Text = "AKADEMİSYEN";
            akademisyen.TextAlign = HorizontalAlignment.Center;
            akademisyen.Width = 180;
            // 
            // btnonayla
            // 
            btnonayla.Location = new Point(1052, 183);
            btnonayla.Name = "btnonayla";
            btnonayla.Size = new Size(164, 56);
            btnonayla.TabIndex = 4;
            btnonayla.Text = "ONAYLA";
            btnonayla.UseVisualStyleBackColor = true;
            btnonayla.Click += btnonayla_Click;
            // 
            // btnreddet
            // 
            btnreddet.Location = new Point(1052, 399);
            btnreddet.Name = "btnreddet";
            btnreddet.Size = new Size(164, 56);
            btnreddet.TabIndex = 5;
            btnreddet.Text = "REDDET";
            btnreddet.UseVisualStyleBackColor = true;
            btnreddet.Click += btnreddet_Click;
            // 
            // txtredmsj
            // 
            txtredmsj.Location = new Point(1061, 332);
            txtredmsj.Name = "txtredmsj";
            txtredmsj.Size = new Size(145, 52);
            txtredmsj.TabIndex = 6;
            txtredmsj.Text = "";
            // 
            // btnlistele
            // 
            btnlistele.Location = new Point(139, 472);
            btnlistele.Name = "btnlistele";
            btnlistele.Size = new Size(164, 56);
            btnlistele.TabIndex = 7;
            btnlistele.Text = "LİSTELE";
            btnlistele.UseVisualStyleBackColor = true;
            btnlistele.Click += btnlistele_Click;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label9.Location = new Point(448, 46);
            label9.Name = "label9";
            label9.Size = new Size(277, 38);
            label9.TabIndex = 19;
            label9.Text = "DANIŞMAN PANELİ";
            // 
            // btngeri
            // 
            btngeri.Location = new Point(871, 476);
            btngeri.Name = "btngeri";
            btngeri.Size = new Size(164, 56);
            btngeri.TabIndex = 24;
            btngeri.Text = "ÇIKIŞ YAP";
            btngeri.UseVisualStyleBackColor = true;
            btngeri.Click += btngeri_Click;
            // 
            // danismanpanel
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1233, 544);
            Controls.Add(btngeri);
            Controls.Add(label9);
            Controls.Add(btnlistele);
            Controls.Add(txtredmsj);
            Controls.Add(btnreddet);
            Controls.Add(btnonayla);
            Controls.Add(listalinandersler);
            Controls.Add(listogrenci);
            Name = "danismanpanel";
            Text = "danismanpanel";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private ColumnHeader ograd;
        private ColumnHeader ogrsoyad;
        private ColumnHeader ogrno;
        private ListView listalinandersler;
        public ColumnHeader dersid;
        private ColumnHeader dersad;
        private ColumnHeader derskredi;
        private ColumnHeader dersakts;
        private ColumnHeader akademisyen;
        private Button btnonayla;
        private Button btnreddet;
        private RichTextBox txtredmsj;
        private Button btnlistele;
        private Label label9;
        private Button btngeri;
        public ListView listogrenci;
    }
}