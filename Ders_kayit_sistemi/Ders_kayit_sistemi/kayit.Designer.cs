namespace Ders_kayit_sistemi
{
    partial class kayit
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            txtad = new TextBox();
            txtsoyad = new TextBox();
            txtno = new TextBox();
            txtkullanici_adi = new TextBox();
            txtsifre = new TextBox();
            btnkayitol = new Button();
            btngeri = new Button();
            label9 = new Label();
            btngiris = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(135, 104);
            label1.Name = "label1";
            label1.Size = new Size(33, 20);
            label1.TabIndex = 0;
            label1.Text = "AD:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(109, 145);
            label2.Name = "label2";
            label2.Size = new Size(59, 20);
            label2.TabIndex = 1;
            label2.Text = "SOYAD:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(93, 189);
            label3.Name = "label3";
            label3.Size = new Size(75, 20);
            label3.TabIndex = 2;
            label3.Text = "NUMARA:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(56, 236);
            label4.Name = "label4";
            label4.Size = new Size(112, 20);
            label4.TabIndex = 3;
            label4.Text = "KULLANICI ADI:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(120, 281);
            label5.Name = "label5";
            label5.Size = new Size(48, 20);
            label5.TabIndex = 4;
            label5.Text = "ŞİFRE:";
            // 
            // txtad
            // 
            txtad.Location = new Point(186, 101);
            txtad.Name = "txtad";
            txtad.Size = new Size(155, 27);
            txtad.TabIndex = 5;
            // 
            // txtsoyad
            // 
            txtsoyad.Location = new Point(186, 145);
            txtsoyad.Name = "txtsoyad";
            txtsoyad.Size = new Size(155, 27);
            txtsoyad.TabIndex = 6;
            // 
            // txtno
            // 
            txtno.Location = new Point(186, 189);
            txtno.Name = "txtno";
            txtno.Size = new Size(155, 27);
            txtno.TabIndex = 7;
            // 
            // txtkullanici_adi
            // 
            txtkullanici_adi.Location = new Point(186, 233);
            txtkullanici_adi.Name = "txtkullanici_adi";
            txtkullanici_adi.Size = new Size(155, 27);
            txtkullanici_adi.TabIndex = 8;
            // 
            // txtsifre
            // 
            txtsifre.Location = new Point(186, 278);
            txtsifre.Name = "txtsifre";
            txtsifre.Size = new Size(155, 27);
            txtsifre.TabIndex = 9;
            // 
            // btnkayitol
            // 
            btnkayitol.Location = new Point(199, 326);
            btnkayitol.Name = "btnkayitol";
            btnkayitol.Size = new Size(120, 38);
            btnkayitol.TabIndex = 10;
            btnkayitol.Text = "KAYIT OL";
            btnkayitol.UseVisualStyleBackColor = true;
            btnkayitol.Click += btnkayitol_Click;
            // 
            // btngeri
            // 
            btngeri.Location = new Point(357, 387);
            btngeri.Name = "btngeri";
            btngeri.Size = new Size(101, 36);
            btngeri.TabIndex = 11;
            btngeri.Text = "ANA SAYFA";
            btngeri.UseVisualStyleBackColor = true;
            btngeri.Click += btngeri_Click;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label9.Location = new Point(84, 24);
            label9.Name = "label9";
            label9.Size = new Size(335, 38);
            label9.TabIndex = 19;
            label9.Text = "ÖĞRENCİ KAYIT EKRANI";
            // 
            // btngiris
            // 
            btngiris.Location = new Point(36, 387);
            btngiris.Name = "btngiris";
            btngiris.Size = new Size(112, 36);
            btngiris.TabIndex = 20;
            btngiris.Text = "GİRİŞ YAP";
            btngiris.UseVisualStyleBackColor = true;
            btngiris.Click += btngiris_Click;
            // 
            // kayit
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(488, 447);
            Controls.Add(btngiris);
            Controls.Add(label9);
            Controls.Add(btngeri);
            Controls.Add(btnkayitol);
            Controls.Add(txtsifre);
            Controls.Add(txtkullanici_adi);
            Controls.Add(txtno);
            Controls.Add(txtsoyad);
            Controls.Add(txtad);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "kayit";
            Text = "kayit";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox txtad;
        private TextBox txtsoyad;
        private TextBox txtno;
        private TextBox txtkullanici_adi;
        private TextBox txtsifre;
        private Button btnkayitol;
        private Button btngeri;
        private Label label9;
        private Button btngiris;
    }
}