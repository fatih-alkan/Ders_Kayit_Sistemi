namespace Ders_kayit_sistemi
{
    partial class anaekran
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnogrenci = new Button();
            btndanisman = new Button();
            btnyonetici = new Button();
            btnkayitsayfasi = new Button();
            label9 = new Label();
            SuspendLayout();
            // 
            // btnogrenci
            // 
            btnogrenci.Location = new Point(116, 141);
            btnogrenci.Name = "btnogrenci";
            btnogrenci.Size = new Size(140, 56);
            btnogrenci.TabIndex = 0;
            btnogrenci.Text = "ÖĞRENCİ";
            btnogrenci.UseVisualStyleBackColor = true;
            btnogrenci.Click += btnogrenci_Click;
            // 
            // btndanisman
            // 
            btndanisman.Location = new Point(297, 141);
            btndanisman.Name = "btndanisman";
            btndanisman.Size = new Size(140, 56);
            btndanisman.TabIndex = 1;
            btndanisman.Text = "DANIŞMAN";
            btndanisman.UseVisualStyleBackColor = true;
            btndanisman.Click += btndanisman_Click;
            // 
            // btnyonetici
            // 
            btnyonetici.Location = new Point(482, 141);
            btnyonetici.Name = "btnyonetici";
            btnyonetici.Size = new Size(140, 56);
            btnyonetici.TabIndex = 2;
            btnyonetici.Text = "YÖNETİCİ";
            btnyonetici.UseVisualStyleBackColor = true;
            btnyonetici.Click += btnyonetici_Click;
            // 
            // btnkayitsayfasi
            // 
            btnkayitsayfasi.Location = new Point(482, 294);
            btnkayitsayfasi.Name = "btnkayitsayfasi";
            btnkayitsayfasi.Size = new Size(140, 38);
            btnkayitsayfasi.TabIndex = 3;
            btnkayitsayfasi.Text = "KAYIT OL";
            btnkayitsayfasi.UseVisualStyleBackColor = true;
            btnkayitsayfasi.Click += btnkayitsayfasi_Click;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label9.Location = new Point(214, 41);
            label9.Name = "label9";
            label9.Size = new Size(289, 38);
            label9.TabIndex = 19;
            label9.Text = "DERS KAYIT SİSTEMİ";
            // 
            // anaekran
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(724, 378);
            Controls.Add(label9);
            Controls.Add(btnkayitsayfasi);
            Controls.Add(btnyonetici);
            Controls.Add(btndanisman);
            Controls.Add(btnogrenci);
            Name = "anaekran";
            Text = "anaekran";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnogrenci;
        private Button btndanisman;
        private Button btnyonetici;
        private Button btnkayitsayfasi;
        private Label label9;
    }
}
