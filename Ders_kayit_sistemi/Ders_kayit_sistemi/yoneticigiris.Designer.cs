namespace Ders_kayit_sistemi
{
    partial class yoneticigiris
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
            btngeri = new Button();
            label9 = new Label();
            btngiris = new Button();
            label2 = new Label();
            label1 = new Label();
            txtsifre = new TextBox();
            txtkullaniciadi = new TextBox();
            SuspendLayout();
            // 
            // btngeri
            // 
            btngeri.Location = new Point(356, 292);
            btngeri.Name = "btngeri";
            btngeri.Size = new Size(118, 36);
            btngeri.TabIndex = 36;
            btngeri.Text = "ANA SAYFA";
            btngeri.UseVisualStyleBackColor = true;
            btngeri.Click += btngeri_Click_1;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label9.Location = new Point(67, 29);
            label9.Name = "label9";
            label9.Size = new Size(339, 38);
            label9.TabIndex = 35;
            label9.Text = "YÖNETİCİ GİRİŞ SAYFASI";
            // 
            // btngiris
            // 
            btngiris.Location = new Point(187, 202);
            btngiris.Name = "btngiris";
            btngiris.Size = new Size(142, 50);
            btngiris.TabIndex = 34;
            btngiris.Text = "GİRİŞ";
            btngiris.UseVisualStyleBackColor = true;
            btngiris.Click += btngiris_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(84, 157);
            label2.Name = "label2";
            label2.Size = new Size(48, 20);
            label2.TabIndex = 33;
            label2.Text = "ŞİFRE:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(20, 106);
            label1.Name = "label1";
            label1.Size = new Size(112, 20);
            label1.TabIndex = 32;
            label1.Text = "KULLANICI ADI:";
            // 
            // txtsifre
            // 
            txtsifre.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 162);
            txtsifre.Location = new Point(151, 154);
            txtsifre.Name = "txtsifre";
            txtsifre.PasswordChar = '*';
            txtsifre.Size = new Size(208, 30);
            txtsifre.TabIndex = 31;
            // 
            // txtkullaniciadi
            // 
            txtkullaniciadi.Location = new Point(151, 103);
            txtkullaniciadi.Name = "txtkullaniciadi";
            txtkullaniciadi.Size = new Size(208, 27);
            txtkullaniciadi.TabIndex = 30;
            // 
            // yoneticigiris
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(506, 366);
            Controls.Add(btngeri);
            Controls.Add(label9);
            Controls.Add(btngiris);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtsifre);
            Controls.Add(txtkullaniciadi);
            Name = "yoneticigiris";
            Text = "yoneticigiris";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btngeri;
        private Label label9;
        private Button btngiris;
        private Label label2;
        private Label label1;
        private TextBox txtsifre;
        private TextBox txtkullaniciadi;
    }
}