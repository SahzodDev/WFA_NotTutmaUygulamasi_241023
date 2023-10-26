namespace WFA_NotTutmaUygulamasi_241023
{
    partial class Form3
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
            lstNotlar = new ListBox();
            btnNotEkle = new Button();
            btnNotSil = new Button();
            txtBaslik = new TextBox();
            txtGovde = new TextBox();
            btnKaydet = new Button();
            btnGuncelle = new Button();
            SuspendLayout();
            // 
            // lstNotlar
            // 
            lstNotlar.FormattingEnabled = true;
            lstNotlar.ItemHeight = 15;
            lstNotlar.Location = new Point(12, 12);
            lstNotlar.Name = "lstNotlar";
            lstNotlar.Size = new Size(150, 394);
            lstNotlar.TabIndex = 0;
            lstNotlar.DoubleClick += lstNotlar_DoubleClick;
            // 
            // btnNotEkle
            // 
            btnNotEkle.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnNotEkle.Location = new Point(188, 12);
            btnNotEkle.Name = "btnNotEkle";
            btnNotEkle.Size = new Size(133, 53);
            btnNotEkle.TabIndex = 1;
            btnNotEkle.Text = "Not Ekle";
            btnNotEkle.UseVisualStyleBackColor = true;
            btnNotEkle.Click += btnNotEkle_Click;
            // 
            // btnNotSil
            // 
            btnNotSil.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnNotSil.Location = new Point(536, 12);
            btnNotSil.Name = "btnNotSil";
            btnNotSil.Size = new Size(133, 53);
            btnNotSil.TabIndex = 2;
            btnNotSil.Text = "Not Sil";
            btnNotSil.UseVisualStyleBackColor = true;
            btnNotSil.Click += btnNotSil_Click;
            // 
            // txtBaslik
            // 
            txtBaslik.Location = new Point(188, 90);
            txtBaslik.Name = "txtBaslik";
            txtBaslik.Size = new Size(481, 23);
            txtBaslik.TabIndex = 3;
            // 
            // txtGovde
            // 
            txtGovde.Location = new Point(188, 119);
            txtGovde.Multiline = true;
            txtGovde.Name = "txtGovde";
            txtGovde.Size = new Size(481, 214);
            txtGovde.TabIndex = 4;
            // 
            // btnKaydet
            // 
            btnKaydet.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnKaydet.Location = new Point(536, 348);
            btnKaydet.Name = "btnKaydet";
            btnKaydet.Size = new Size(133, 53);
            btnKaydet.TabIndex = 5;
            btnKaydet.Text = "Kaydet";
            btnKaydet.UseVisualStyleBackColor = true;
            btnKaydet.Click += btnKaydet_Click;
            // 
            // btnGuncelle
            // 
            btnGuncelle.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnGuncelle.Location = new Point(359, 12);
            btnGuncelle.Name = "btnGuncelle";
            btnGuncelle.Size = new Size(136, 53);
            btnGuncelle.TabIndex = 6;
            btnGuncelle.Text = "Notu Güncelle";
            btnGuncelle.UseVisualStyleBackColor = true;
            btnGuncelle.Click += btnGuncelle_Click;
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(696, 413);
            Controls.Add(btnGuncelle);
            Controls.Add(btnKaydet);
            Controls.Add(txtGovde);
            Controls.Add(txtBaslik);
            Controls.Add(btnNotSil);
            Controls.Add(btnNotEkle);
            Controls.Add(lstNotlar);
            Name = "Form3";
            Text = "Form3";
            Load += Form3_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox lstNotlar;
        private Button btnNotEkle;
        private Button btnNotSil;
        private TextBox txtBaslik;
        private TextBox txtGovde;
        private Button btnKaydet;
        private Button btnGuncelle;
    }
}