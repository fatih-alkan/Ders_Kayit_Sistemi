namespace Ders_kayit_sistemi
{
    partial class yoneticipanel
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
            listalinandersler = new ListView();
            dersid = new ColumnHeader();
            dersad = new ColumnHeader();
            derskredi = new ColumnHeader();
            dersakts = new ColumnHeader();
            akademisyen = new ColumnHeader();
            ograd = new ColumnHeader();
            ogrsoyad = new ColumnHeader();
            ogrno = new ColumnHeader();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            cmbdersad = new ComboBox();
            cmbderskredi = new ComboBox();
            cmbdersakts = new ComboBox();
            cmbakademisyen = new ComboBox();
            txtograd = new TextBox();
            txtogrsoyad = new TextBox();
            txtogrno = new TextBox();
            btnsil = new Button();
            btngeri = new Button();
            btnekle = new Button();
            btnlistele = new Button();
            btnguncelle = new Button();
            btnyeniders = new Button();
            btndoldur = new Button();
            label9 = new Label();
            cmbdersid = new ComboBox();
            SuspendLayout();
            // 
            // listalinandersler
            // 
            listalinandersler.Columns.AddRange(new ColumnHeader[] { dersid, dersad, derskredi, dersakts, akademisyen, ograd, ogrsoyad, ogrno });
            listalinandersler.Location = new Point(30, 101);
            listalinandersler.Name = "listalinandersler";
            listalinandersler.Size = new Size(952, 201);
            listalinandersler.TabIndex = 2;
            listalinandersler.UseCompatibleStateImageBehavior = false;
            listalinandersler.View = View.Details;
            listalinandersler.SelectedIndexChanged += listalinandersler_SelectedIndexChanged;
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
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(38, 332);
            label1.Name = "label1";
            label1.Size = new Size(67, 20);
            label1.TabIndex = 6;
            label1.Text = "DERS ID:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(38, 370);
            label2.Name = "label2";
            label2.Size = new Size(77, 20);
            label2.TabIndex = 7;
            label2.Text = "DERS ADI:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(38, 407);
            label3.Name = "label3";
            label3.Size = new Size(93, 20);
            label3.TabIndex = 8;
            label3.Text = "DERS KREDİ:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(38, 447);
            label4.Name = "label4";
            label4.Size = new Size(87, 20);
            label4.TabIndex = 9;
            label4.Text = "DERS AKTS:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(38, 488);
            label5.Name = "label5";
            label5.Size = new Size(112, 20);
            label5.TabIndex = 10;
            label5.Text = "AKADEMİSYEN:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(38, 529);
            label6.Name = "label6";
            label6.Size = new Size(103, 20);
            label6.TabIndex = 11;
            label6.Text = "ÖĞRENCİ ADI:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(38, 570);
            label7.Name = "label7";
            label7.Size = new Size(129, 20);
            label7.TabIndex = 12;
            label7.Text = "ÖĞRENCİ SOYADI:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(38, 613);
            label8.Name = "label8";
            label8.Size = new Size(141, 20);
            label8.TabIndex = 13;
            label8.Text = "ÖĞRENCİ NUMARA:";
            // 
            // cmbdersad
            // 
            cmbdersad.FormattingEnabled = true;
            cmbdersad.Location = new Point(185, 367);
            cmbdersad.Name = "cmbdersad";
            cmbdersad.Size = new Size(151, 28);
            cmbdersad.TabIndex = 15;
            // 
            // cmbderskredi
            // 
            cmbderskredi.FormattingEnabled = true;
            cmbderskredi.Location = new Point(185, 404);
            cmbderskredi.Name = "cmbderskredi";
            cmbderskredi.Size = new Size(151, 28);
            cmbderskredi.TabIndex = 16;
            // 
            // cmbdersakts
            // 
            cmbdersakts.FormattingEnabled = true;
            cmbdersakts.Location = new Point(185, 444);
            cmbdersakts.Name = "cmbdersakts";
            cmbdersakts.Size = new Size(151, 28);
            cmbdersakts.TabIndex = 17;
            // 
            // cmbakademisyen
            // 
            cmbakademisyen.FormattingEnabled = true;
            cmbakademisyen.Location = new Point(185, 485);
            cmbakademisyen.Name = "cmbakademisyen";
            cmbakademisyen.Size = new Size(151, 28);
            cmbakademisyen.TabIndex = 18;
            // 
            // txtograd
            // 
            txtograd.Location = new Point(185, 526);
            txtograd.Name = "txtograd";
            txtograd.Size = new Size(151, 27);
            txtograd.TabIndex = 19;
            // 
            // txtogrsoyad
            // 
            txtogrsoyad.Location = new Point(185, 567);
            txtogrsoyad.Name = "txtogrsoyad";
            txtogrsoyad.Size = new Size(151, 27);
            txtogrsoyad.TabIndex = 20;
            // 
            // txtogrno
            // 
            txtogrno.Location = new Point(185, 610);
            txtogrno.Name = "txtogrno";
            txtogrno.Size = new Size(151, 27);
            txtogrno.TabIndex = 21;
            // 
            // btnsil
            // 
            btnsil.Location = new Point(796, 407);
            btnsil.Name = "btnsil";
            btnsil.Size = new Size(164, 56);
            btnsil.TabIndex = 22;
            btnsil.Text = "SİL";
            btnsil.UseVisualStyleBackColor = true;
            btnsil.Click += btnsil_Click;
            // 
            // btngeri
            // 
            btngeri.Location = new Point(796, 581);
            btngeri.Name = "btngeri";
            btngeri.Size = new Size(164, 56);
            btngeri.TabIndex = 23;
            btngeri.Text = "ÇIKIŞ YAP";
            btngeri.UseVisualStyleBackColor = true;
            btngeri.Click += btngeri_Click;
            // 
            // btnekle
            // 
            btnekle.Location = new Point(415, 407);
            btnekle.Name = "btnekle";
            btnekle.Size = new Size(164, 56);
            btnekle.TabIndex = 24;
            btnekle.Text = "EKLE";
            btnekle.UseVisualStyleBackColor = true;
            btnekle.Click += btnekle_Click;
            // 
            // btnlistele
            // 
            btnlistele.Location = new Point(605, 314);
            btnlistele.Name = "btnlistele";
            btnlistele.Size = new Size(164, 56);
            btnlistele.TabIndex = 25;
            btnlistele.Text = "LİSTELE";
            btnlistele.UseVisualStyleBackColor = true;
            btnlistele.Click += btnlistele_Click;
            // 
            // btnguncelle
            // 
            btnguncelle.Location = new Point(605, 407);
            btnguncelle.Name = "btnguncelle";
            btnguncelle.Size = new Size(164, 56);
            btnguncelle.TabIndex = 26;
            btnguncelle.Text = "GÜNCELLE";
            btnguncelle.UseVisualStyleBackColor = true;
            btnguncelle.Click += btnguncelle_Click;
            // 
            // btnyeniders
            // 
            btnyeniders.Location = new Point(605, 581);
            btnyeniders.Name = "btnyeniders";
            btnyeniders.Size = new Size(164, 56);
            btnyeniders.TabIndex = 27;
            btnyeniders.Text = "YENİ DERS EKLE";
            btnyeniders.UseVisualStyleBackColor = true;
            btnyeniders.Click += btnyeniders_Click;
            // 
            // btndoldur
            // 
            btndoldur.Location = new Point(342, 322);
            btndoldur.Name = "btndoldur";
            btndoldur.Size = new Size(81, 41);
            btndoldur.TabIndex = 28;
            btndoldur.Text = "DOLDUR";
            btndoldur.UseVisualStyleBackColor = true;
            btndoldur.Click += btndoldur_Click;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label9.Location = new Point(385, 25);
            label9.Name = "label9";
            label9.Size = new Size(245, 38);
            label9.TabIndex = 29;
            label9.Text = "YÖNETİCİ PANELİ";
            // 
            // cmbdersid
            // 
            cmbdersid.FormattingEnabled = true;
            cmbdersid.Location = new Point(185, 329);
            cmbdersid.Name = "cmbdersid";
            cmbdersid.Size = new Size(151, 28);
            cmbdersid.TabIndex = 30;
            // 
            // yoneticipanel
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1011, 655);
            Controls.Add(cmbdersid);
            Controls.Add(label9);
            Controls.Add(btndoldur);
            Controls.Add(btnyeniders);
            Controls.Add(btnguncelle);
            Controls.Add(btnlistele);
            Controls.Add(btnekle);
            Controls.Add(btngeri);
            Controls.Add(btnsil);
            Controls.Add(txtogrno);
            Controls.Add(txtogrsoyad);
            Controls.Add(txtograd);
            Controls.Add(cmbakademisyen);
            Controls.Add(cmbdersakts);
            Controls.Add(cmbderskredi);
            Controls.Add(cmbdersad);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(listalinandersler);
            Name = "yoneticipanel";
            Text = "yoneticipanel";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListView listalinandersler;
        public ColumnHeader dersid;
        private ColumnHeader dersad;
        private ColumnHeader derskredi;
        private ColumnHeader dersakts;
        private ColumnHeader akademisyen;
        private ColumnHeader ograd;
        private ColumnHeader ogrsoyad;
        private ColumnHeader ogrno;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private TextBox txtograd;
        private TextBox txtogrsoyad;
        private TextBox txtogrno;
        private Button btnsil;
        private Button btngeri;
        private Button btnekle;
        private Button btnlistele;
        private Button btnguncelle;
        private Button btnyeniders;
        private Button btndoldur;
        private Label label9;
        public ComboBox cmbdersad;
        public ComboBox cmbderskredi;
        public ComboBox cmbdersakts;
        public ComboBox cmbakademisyen;
        public ComboBox cmbdersid;
    }
}