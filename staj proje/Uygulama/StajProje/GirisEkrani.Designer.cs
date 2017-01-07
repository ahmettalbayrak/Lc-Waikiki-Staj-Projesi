namespace StajProje
{
    partial class GirisEkrani
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtKullaniciAdi = new System.Windows.Forms.TextBox();
            this.txtSifre = new System.Windows.Forms.TextBox();
            this.Kullaı = new System.Windows.Forms.Label();
            this.cmbKullaniciTipi = new System.Windows.Forms.ComboBox();
            this.btnGiris = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(76, 83);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kullanıcı Adı";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(76, 118);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Şifre";
            // 
            // txtKullaniciAdi
            // 
            this.txtKullaniciAdi.Location = new System.Drawing.Point(201, 82);
            this.txtKullaniciAdi.Name = "txtKullaniciAdi";
            this.txtKullaniciAdi.Size = new System.Drawing.Size(100, 20);
            this.txtKullaniciAdi.TabIndex = 2;
            this.txtKullaniciAdi.Text = "1122602039";
            // 
            // txtSifre
            // 
            this.txtSifre.Location = new System.Drawing.Point(201, 117);
            this.txtSifre.Name = "txtSifre";
            this.txtSifre.Size = new System.Drawing.Size(100, 20);
            this.txtSifre.TabIndex = 3;
            this.txtSifre.Text = "24982166738";
            // 
            // Kullaı
            // 
            this.Kullaı.AutoSize = true;
            this.Kullaı.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Bold);
            this.Kullaı.Location = new System.Drawing.Point(76, 153);
            this.Kullaı.Name = "Kullaı";
            this.Kullaı.Size = new System.Drawing.Size(105, 17);
            this.Kullaı.TabIndex = 4;
            this.Kullaı.Text = "Kullanıcı Tipi";
            // 
            // cmbKullaniciTipi
            // 
            this.cmbKullaniciTipi.FormattingEnabled = true;
            this.cmbKullaniciTipi.Location = new System.Drawing.Point(201, 153);
            this.cmbKullaniciTipi.Name = "cmbKullaniciTipi";
            this.cmbKullaniciTipi.Size = new System.Drawing.Size(100, 21);
            this.cmbKullaniciTipi.TabIndex = 5;
            // 
            // btnGiris
            // 
            this.btnGiris.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGiris.Location = new System.Drawing.Point(169, 201);
            this.btnGiris.Name = "btnGiris";
            this.btnGiris.Size = new System.Drawing.Size(75, 23);
            this.btnGiris.TabIndex = 6;
            this.btnGiris.Text = "Giriş";
            this.btnGiris.UseVisualStyleBackColor = true;
            this.btnGiris.Click += new System.EventHandler(this.btnGiris_Click);
            // 
            // GirisEkrani
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(462, 367);
            this.Controls.Add(this.btnGiris);
            this.Controls.Add(this.cmbKullaniciTipi);
            this.Controls.Add(this.Kullaı);
            this.Controls.Add(this.txtSifre);
            this.Controls.Add(this.txtKullaniciAdi);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "GirisEkrani";
            this.Text = "Giriş Ekranı";
            this.Load += new System.EventHandler(this.GirisEkrani_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtKullaniciAdi;
        private System.Windows.Forms.TextBox txtSifre;
        private System.Windows.Forms.Label Kullaı;
        private System.Windows.Forms.ComboBox cmbKullaniciTipi;
        private System.Windows.Forms.Button btnGiris;
    }
}

