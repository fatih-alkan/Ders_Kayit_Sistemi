namespace Ders_kayit_sistemi
{
    partial class alinandersler
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
            onaydurumu = new ColumnHeader();
            btnlistele = new Button();
            btngeri = new Button();
            label9 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            lblnumara = new Label();
            lblsoyad = new Label();
            lblad = new Label();
            panel1 = new Panel();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // listalinandersler
            // 
            listalinandersler.Columns.AddRange(new ColumnHeader[] { dersid, dersad, derskredi, dersakts, akademisyen, ograd, ogrsoyad, ogrno, onaydurumu });
            listalinandersler.Location = new Point(28, 143);
            listalinandersler.Name = "listalinandersler";
            listalinandersler.Size = new Size(1099, 329);
            listalinandersler.TabIndex = 1;
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
            dersad.Width = 170;
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
            akademisyen.Width = 200;
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
            // onaydurumu
            // 
            onaydurumu.Text = "ONAY DURUMU";
            onaydurumu.Width = 120;
            // 
            // btnlistele
            // 
            btnlistele.Location = new Point(433, 487);
            btnlistele.Name = "btnlistele";
            btnlistele.Size = new Size(252, 85);
            btnlistele.TabIndex = 2;
            btnlistele.Text = "ALINAN DERSLERİ GÖSTER";
            btnlistele.UseVisualStyleBackColor = true;
            btnlistele.Click += btnlistele_Click;
            // 
            // btngeri
            // 
            btngeri.Location = new Point(924, 500);
            btngeri.Name = "btngeri";
            btngeri.Size = new Size(178, 58);
            btngeri.TabIndex = 3;
            btngeri.Text = "GERİ";
            btngeri.UseVisualStyleBackColor = true;
            btngeri.Click += btngeri_Click;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label9.Location = new Point(433, 43);
            label9.Name = "label9";
            label9.Size = new Size(249, 38);
            label9.TabIndex = 19;
            label9.Text = "ALINAN DERSLER";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(49, 20);
            label6.Name = "label6";
            label6.Size = new Size(33, 20);
            label6.TabIndex = 29;
            label6.Text = "AD:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(23, 50);
            label5.Name = "label5";
            label5.Size = new Size(59, 20);
            label5.TabIndex = 28;
            label5.Text = "SOYAD:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(7, 80);
            label4.Name = "label4";
            label4.Size = new Size(75, 20);
            label4.TabIndex = 27;
            label4.Text = "NUMARA:";
            // 
            // lblnumara
            // 
            lblnumara.AutoSize = true;
            lblnumara.Location = new Point(92, 80);
            lblnumara.Name = "lblnumara";
            lblnumara.Size = new Size(50, 20);
            lblnumara.TabIndex = 26;
            lblnumara.Text = "label3";
            // 
            // lblsoyad
            // 
            lblsoyad.AutoSize = true;
            lblsoyad.Location = new Point(92, 50);
            lblsoyad.Name = "lblsoyad";
            lblsoyad.Size = new Size(50, 20);
            lblsoyad.TabIndex = 25;
            lblsoyad.Text = "label2";
            // 
            // lblad
            // 
            lblad.AutoSize = true;
            lblad.Location = new Point(92, 20);
            lblad.Name = "lblad";
            lblad.Size = new Size(50, 20);
            lblad.TabIndex = 24;
            lblad.Text = "label1";
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ControlDark;
            panel1.Controls.Add(lblad);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(lblnumara);
            panel1.Controls.Add(lblsoyad);
            panel1.Controls.Add(label5);
            panel1.Location = new Point(28, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(250, 125);
            panel1.TabIndex = 30;
            // 
            // alinandersler
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1151, 577);
            Controls.Add(panel1);
            Controls.Add(label9);
            Controls.Add(btngeri);
            Controls.Add(btnlistele);
            Controls.Add(listalinandersler);
            Name = "alinandersler";
            Text = "alinandersler";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
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
        private ColumnHeader onaydurumu;
        private Button btnlistele;
        private Button btngeri;
        private Label label9;
        private Label label6;
        private Label label5;
        private Label label4;
        public Label lblnumara;
        public Label lblsoyad;
        public Label lblad;
        private Panel panel1;
    }
}