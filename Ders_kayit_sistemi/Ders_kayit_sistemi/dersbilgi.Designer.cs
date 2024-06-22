namespace Ders_kayit_sistemi
{
    partial class dersbilgi
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
            listdersbilgi = new ListView();
            dersid = new ColumnHeader();
            dersad = new ColumnHeader();
            derskredi = new ColumnHeader();
            dersakts = new ColumnHeader();
            akademisyen = new ColumnHeader();
            btndersbilgi = new Button();
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
            // listdersbilgi
            // 
            listdersbilgi.Columns.AddRange(new ColumnHeader[] { dersid, dersad, derskredi, dersakts, akademisyen });
            listdersbilgi.Location = new Point(149, 124);
            listdersbilgi.Name = "listdersbilgi";
            listdersbilgi.Size = new Size(579, 329);
            listdersbilgi.TabIndex = 0;
            listdersbilgi.UseCompatibleStateImageBehavior = false;
            listdersbilgi.View = View.Details;
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
            // btndersbilgi
            // 
            btndersbilgi.Location = new Point(149, 472);
            btndersbilgi.Name = "btndersbilgi";
            btndersbilgi.Size = new Size(164, 54);
            btndersbilgi.TabIndex = 1;
            btndersbilgi.Text = "LİSTELE";
            btndersbilgi.UseVisualStyleBackColor = true;
            btndersbilgi.Click += btndersbilgi_Click;
            // 
            // btngeri
            // 
            btngeri.Location = new Point(574, 472);
            btngeri.Name = "btngeri";
            btngeri.Size = new Size(154, 54);
            btngeri.TabIndex = 2;
            btngeri.Text = "GERİ";
            btngeri.UseVisualStyleBackColor = true;
            btngeri.Click += btngeri_Click;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label9.Location = new Point(286, 42);
            label9.Name = "label9";
            label9.Size = new Size(281, 38);
            label9.TabIndex = 17;
            label9.Text = "DERS BİLGİ SAYFASI";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(43, 12);
            label6.Name = "label6";
            label6.Size = new Size(33, 20);
            label6.TabIndex = 23;
            label6.Text = "AD:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(17, 42);
            label5.Name = "label5";
            label5.Size = new Size(59, 20);
            label5.TabIndex = 22;
            label5.Text = "SOYAD:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(1, 72);
            label4.Name = "label4";
            label4.Size = new Size(75, 20);
            label4.TabIndex = 21;
            label4.Text = "NUMARA:";
            // 
            // lblnumara
            // 
            lblnumara.AutoSize = true;
            lblnumara.Location = new Point(86, 72);
            lblnumara.Name = "lblnumara";
            lblnumara.Size = new Size(50, 20);
            lblnumara.TabIndex = 20;
            lblnumara.Text = "label3";
            // 
            // lblsoyad
            // 
            lblsoyad.AutoSize = true;
            lblsoyad.Location = new Point(86, 42);
            lblsoyad.Name = "lblsoyad";
            lblsoyad.Size = new Size(50, 20);
            lblsoyad.TabIndex = 19;
            lblsoyad.Text = "label2";
            // 
            // lblad
            // 
            lblad.AutoSize = true;
            lblad.Location = new Point(86, 12);
            lblad.Name = "lblad";
            lblad.Size = new Size(50, 20);
            lblad.TabIndex = 18;
            lblad.Text = "label1";
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ControlDark;
            panel1.Controls.Add(label6);
            panel1.Controls.Add(lblad);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(lblsoyad);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(lblnumara);
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(231, 106);
            panel1.TabIndex = 31;
            // 
            // dersbilgi
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(813, 555);
            Controls.Add(panel1);
            Controls.Add(label9);
            Controls.Add(btngeri);
            Controls.Add(btndersbilgi);
            Controls.Add(listdersbilgi);
            Name = "dersbilgi";
            Text = "dersbilgi";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListView listdersbilgi;
        public ColumnHeader dersid;
        private ColumnHeader dersad;
        private ColumnHeader derskredi;
        private ColumnHeader dersakts;
        private ColumnHeader akademisyen;
        private Button btndersbilgi;
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