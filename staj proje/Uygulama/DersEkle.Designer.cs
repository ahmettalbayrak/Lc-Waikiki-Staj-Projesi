namespace StajProje
{
    partial class DersEkle
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
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.cmbFakulte = new System.Windows.Forms.ComboBox();
            this.cmbBolum = new System.Windows.Forms.ComboBox();
            this.cmbSinif = new System.Windows.Forms.ComboBox();
            this.cmbDonem = new System.Windows.Forms.ComboBox();
            this.cmbOgretmen = new System.Windows.Forms.ComboBox();
            this.txtDersKodu = new System.Windows.Forms.TextBox();
            this.txtDersAdi = new System.Windows.Forms.TextBox();
            this.Label6 = new System.Windows.Forms.Label();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(44, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 14);
            this.label1.TabIndex = 0;
            this.label1.Text = "Fakülte";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(44, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 14);
            this.label2.TabIndex = 1;
            this.label2.Text = "Bölüm";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(44, 101);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 14);
            this.label3.TabIndex = 2;
            this.label3.Text = "Ders Kodu";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(44, 134);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 14);
            this.label4.TabIndex = 3;
            this.label4.Text = "Ders Adi";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(44, 167);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(33, 14);
            this.label5.TabIndex = 4;
            this.label5.Text = "Sınıf";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(44, 233);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(70, 14);
            this.label7.TabIndex = 6;
            this.label7.Text = "Öğretmen";
            // 
            // cmbFakulte
            // 
            this.cmbFakulte.FormattingEnabled = true;
            this.cmbFakulte.Location = new System.Drawing.Point(149, 33);
            this.cmbFakulte.Name = "cmbFakulte";
            this.cmbFakulte.Size = new System.Drawing.Size(121, 21);
            this.cmbFakulte.TabIndex = 7;
            this.cmbFakulte.SelectedIndexChanged += new System.EventHandler(this.cmbFakulte_SelectedIndexChanged);
            // 
            // cmbBolum
            // 
            this.cmbBolum.FormattingEnabled = true;
            this.cmbBolum.Location = new System.Drawing.Point(149, 66);
            this.cmbBolum.Name = "cmbBolum";
            this.cmbBolum.Size = new System.Drawing.Size(121, 21);
            this.cmbBolum.TabIndex = 8;
            // 
            // cmbSinif
            // 
            this.cmbSinif.FormattingEnabled = true;
            this.cmbSinif.Location = new System.Drawing.Point(149, 165);
            this.cmbSinif.Name = "cmbSinif";
            this.cmbSinif.Size = new System.Drawing.Size(121, 21);
            this.cmbSinif.TabIndex = 9;
            // 
            // cmbDonem
            // 
            this.cmbDonem.FormattingEnabled = true;
            this.cmbDonem.Location = new System.Drawing.Point(149, 198);
            this.cmbDonem.Name = "cmbDonem";
            this.cmbDonem.Size = new System.Drawing.Size(121, 21);
            this.cmbDonem.TabIndex = 10;
            // 
            // cmbOgretmen
            // 
            this.cmbOgretmen.FormattingEnabled = true;
            this.cmbOgretmen.Location = new System.Drawing.Point(149, 231);
            this.cmbOgretmen.Name = "cmbOgretmen";
            this.cmbOgretmen.Size = new System.Drawing.Size(121, 21);
            this.cmbOgretmen.TabIndex = 11;
            // 
            // txtDersKodu
            // 
            this.txtDersKodu.Location = new System.Drawing.Point(149, 101);
            this.txtDersKodu.Name = "txtDersKodu";
            this.txtDersKodu.Size = new System.Drawing.Size(121, 20);
            this.txtDersKodu.TabIndex = 12;
            // 
            // txtDersAdi
            // 
            this.txtDersAdi.Location = new System.Drawing.Point(149, 132);
            this.txtDersAdi.Name = "txtDersAdi";
            this.txtDersAdi.Size = new System.Drawing.Size(121, 20);
            this.txtDersAdi.TabIndex = 13;
            // 
            // Label6
            // 
            this.Label6.AutoSize = true;
            this.Label6.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label6.Location = new System.Drawing.Point(44, 200);
            this.Label6.Name = "Label6";
            this.Label6.Size = new System.Drawing.Size(51, 14);
            this.Label6.TabIndex = 14;
            this.Label6.Text = "Dönem";
            // 
            // btnKaydet
            // 
            this.btnKaydet.Location = new System.Drawing.Point(94, 283);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(104, 32);
            this.btnKaydet.TabIndex = 15;
            this.btnKaydet.Text = "KAYDET";
            this.btnKaydet.UseVisualStyleBackColor = true;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // DersEkle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(328, 402);
            this.Controls.Add(this.btnKaydet);
            this.Controls.Add(this.Label6);
            this.Controls.Add(this.txtDersAdi);
            this.Controls.Add(this.txtDersKodu);
            this.Controls.Add(this.cmbOgretmen);
            this.Controls.Add(this.cmbDonem);
            this.Controls.Add(this.cmbSinif);
            this.Controls.Add(this.cmbBolum);
            this.Controls.Add(this.cmbFakulte);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "DersEkle";
            this.Text = "DersEkle";
            this.Load += new System.EventHandler(this.DersEkle_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cmbFakulte;
        private System.Windows.Forms.ComboBox cmbBolum;
        private System.Windows.Forms.ComboBox cmbSinif;
        private System.Windows.Forms.ComboBox cmbDonem;
        private System.Windows.Forms.ComboBox cmbOgretmen;
        private System.Windows.Forms.TextBox txtDersKodu;
        private System.Windows.Forms.TextBox txtDersAdi;
        private System.Windows.Forms.Label Label6;
        private System.Windows.Forms.Button btnKaydet;
    }
}