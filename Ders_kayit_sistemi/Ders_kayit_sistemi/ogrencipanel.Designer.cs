namespace Ders_kayit_sistemi
{
    partial class ogrencipanel
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
            btndersbilgi = new Button();
            btnderskayit = new Button();
            btnalinandersler = new Button();
            btngeri = new Button();
            lblad = new Label();
            lblsoyad = new Label();
            lblnumara = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label9 = new Label();
            panel1 = new Panel();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // btndersbilgi
            // 
            btndersbilgi.Location = new Point(116, 181);
            btndersbilgi.Name = "btndersbilgi";
            btndersbilgi.Size = new Size(172, 71);
            btndersbilgi.TabIndex = 0;
            btndersbilgi.Text = "DERS BİLGİLERİ";
            btndersbilgi.UseVisualStyleBackColor = true;
            btndersbilgi.Click += btndersbilgi_Click;
            // 
            // btnderskayit
            // 
            btnderskayit.Location = new Point(307, 181);
            btnderskayit.Name = "btnderskayit";
            btnderskayit.Size = new Size(172, 71);
            btnderskayit.TabIndex = 1;
            btnderskayit.Text = "DERS KAYIT";
            btnderskayit.UseVisualStyleBackColor = true;
            btnderskayit.Click += btnderskayit_Click;
            // 
            // btnalinandersler
            // 
            btnalinandersler.Location = new Point(502, 181);
            btnalinandersler.Name = "btnalinandersler";
            btnalinandersler.Size = new Size(172, 71);
            btnalinandersler.TabIndex = 2;
            btnalinandersler.Text = "ALINAN DERSLER";
            btnalinandersler.UseVisualStyleBackColor = true;
            btnalinandersler.Click += btnalinandersler_Click;
            // 
            // btngeri
            // 
            btngeri.Location = new Point(596, 362);
            btngeri.Name = "btngeri";
            btngeri.Size = new Size(147, 58);
            btngeri.TabIndex = 3;
            btngeri.Text = "ÇIKIŞ YAP";
            btngeri.UseVisualStyleBackColor = true;
            btngeri.Click += btngeri_Click;
            // 
            // lblad
            // 
            lblad.AutoSize = true;
            lblad.Location = new Point(96, 15);
            lblad.Name = "lblad";
            lblad.Size = new Size(50, 20);
            lblad.TabIndex = 4;
            lblad.Text = "label1";
            // 
            // lblsoyad
            // 
            lblsoyad.AutoSize = true;
            lblsoyad.Location = new Point(96, 45);
            lblsoyad.Name = "lblsoyad";
            lblsoyad.Size = new Size(50, 20);
            lblsoyad.TabIndex = 5;
            lblsoyad.Text = "label2";
            // 
            // lblnumara
            // 
            lblnumara.AutoSize = true;
            lblnumara.Location = new Point(96, 75);
            lblnumara.Name = "lblnumara";
            lblnumara.Size = new Size(50, 20);
            lblnumara.TabIndex = 6;
            lblnumara.Text = "label3";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(11, 75);
            label4.Name = "label4";
            label4.Size = new Size(75, 20);
            label4.TabIndex = 7;
            label4.Text = "NUMARA:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(27, 45);
            label5.Name = "label5";
            label5.Size = new Size(59, 20);
            label5.TabIndex = 8;
            label5.Text = "SOYAD:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(53, 15);
            label6.Name = "label6";
            label6.Size = new Size(33, 20);
            label6.TabIndex = 9;
            label6.Text = "AD:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label9.Location = new Point(285, 40);
            label9.Name = "label9";
            label9.Size = new Size(242, 38);
            label9.TabIndex = 18;
            label9.Text = "ÖĞRENCİ PANELİ";
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ControlDark;
            panel1.Controls.Add(label6);
            panel1.Controls.Add(lblad);
            panel1.Controls.Add(lblsoyad);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(lblnumara);
            panel1.Controls.Add(label4);
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(250, 125);
            panel1.TabIndex = 31;
            // 
            // ogrencipanel
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panel1);
            Controls.Add(label9);
            Controls.Add(btngeri);
            Controls.Add(btnalinandersler);
            Controls.Add(btnderskayit);
            Controls.Add(btndersbilgi);
            Name = "ogrencipanel";
            Text = "ogrencipanel";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btndersbilgi;
        private Button btnderskayit;
        private Button btnalinandersler;
        private Button btngeri;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label9;
        public Label lblad;
        public Label lblsoyad;
        public Label lblnumara;
        private Panel panel1;
    }
}