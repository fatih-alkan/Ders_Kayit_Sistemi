namespace Ders_kayit_sistemi
{
    partial class yeniders
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
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            btnekle = new Button();
            label9 = new Label();
            btngeri = new Button();
            txtdersad = new TextBox();
            txtderskredi = new TextBox();
            txtdersakts = new TextBox();
            txtakademisyen = new TextBox();
            SuspendLayout();
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(37, 217);
            label5.Name = "label5";
            label5.Size = new Size(112, 20);
            label5.TabIndex = 23;
            label5.Text = "AKADEMİSYEN:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(37, 176);
            label4.Name = "label4";
            label4.Size = new Size(87, 20);
            label4.TabIndex = 22;
            label4.Text = "DERS AKTS:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(37, 136);
            label3.Name = "label3";
            label3.Size = new Size(93, 20);
            label3.TabIndex = 21;
            label3.Text = "DERS KREDİ:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(37, 99);
            label2.Name = "label2";
            label2.Size = new Size(77, 20);
            label2.TabIndex = 20;
            label2.Text = "DERS ADI:";
            // 
            // btnekle
            // 
            btnekle.Location = new Point(184, 263);
            btnekle.Name = "btnekle";
            btnekle.Size = new Size(151, 45);
            btnekle.TabIndex = 29;
            btnekle.Text = "EKLE";
            btnekle.UseVisualStyleBackColor = true;
            btnekle.Click += btnekle_Click;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label9.Location = new Point(56, 20);
            label9.Name = "label9";
            label9.Size = new Size(302, 38);
            label9.TabIndex = 30;
            label9.Text = "DERS EKLEME PANELİ";
            // 
            // btngeri
            // 
            btngeri.Location = new Point(315, 369);
            btngeri.Name = "btngeri";
            btngeri.Size = new Size(110, 40);
            btngeri.TabIndex = 31;
            btngeri.Text = "GERİ";
            btngeri.UseVisualStyleBackColor = true;
            btngeri.Click += btngeri_Click;
            // 
            // txtdersad
            // 
            txtdersad.Location = new Point(184, 96);
            txtdersad.Name = "txtdersad";
            txtdersad.Size = new Size(151, 27);
            txtdersad.TabIndex = 33;
            // 
            // txtderskredi
            // 
            txtderskredi.Location = new Point(184, 133);
            txtderskredi.Name = "txtderskredi";
            txtderskredi.Size = new Size(151, 27);
            txtderskredi.TabIndex = 34;
            // 
            // txtdersakts
            // 
            txtdersakts.Location = new Point(184, 173);
            txtdersakts.Name = "txtdersakts";
            txtdersakts.Size = new Size(151, 27);
            txtdersakts.TabIndex = 35;
            // 
            // txtakademisyen
            // 
            txtakademisyen.Location = new Point(184, 214);
            txtakademisyen.Name = "txtakademisyen";
            txtakademisyen.Size = new Size(151, 27);
            txtakademisyen.TabIndex = 36;
            // 
            // yeniders
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(437, 421);
            Controls.Add(txtakademisyen);
            Controls.Add(txtdersakts);
            Controls.Add(txtderskredi);
            Controls.Add(txtdersad);
            Controls.Add(btngeri);
            Controls.Add(label9);
            Controls.Add(btnekle);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Name = "yeniders";
            Text = "yeniders";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Button btnekle;
        private Label label9;
        private Button btngeri;
        public TextBox txtdersad;
        public TextBox txtderskredi;
        public TextBox txtdersakts;
        public TextBox txtakademisyen;
    }
}