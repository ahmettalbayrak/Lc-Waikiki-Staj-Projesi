namespace StajProje
{
    partial class DersSecim
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
            this.lsbTumDersler = new System.Windows.Forms.ListBox();
            this.lsbSecilenDersler = new System.Windows.Forms.ListBox();
            this.btnEkle = new System.Windows.Forms.Button();
            this.btnCikar = new System.Windows.Forms.Button();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lsbTumDersler
            // 
            this.lsbTumDersler.FormattingEnabled = true;
            this.lsbTumDersler.Location = new System.Drawing.Point(61, 52);
            this.lsbTumDersler.Name = "lsbTumDersler";
            this.lsbTumDersler.Size = new System.Drawing.Size(271, 303);
            this.lsbTumDersler.TabIndex = 0;
            // 
            // lsbSecilenDersler
            // 
            this.lsbSecilenDersler.FormattingEnabled = true;
            this.lsbSecilenDersler.Location = new System.Drawing.Point(440, 52);
            this.lsbSecilenDersler.Name = "lsbSecilenDersler";
            this.lsbSecilenDersler.Size = new System.Drawing.Size(271, 303);
            this.lsbSecilenDersler.TabIndex = 1;
            // 
            // btnEkle
            // 
            this.btnEkle.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEkle.Location = new System.Drawing.Point(348, 104);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(75, 23);
            this.btnEkle.TabIndex = 2;
            this.btnEkle.Text = "EKLE";
            this.btnEkle.UseVisualStyleBackColor = true;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // btnCikar
            // 
            this.btnCikar.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCikar.Location = new System.Drawing.Point(348, 169);
            this.btnCikar.Name = "btnCikar";
            this.btnCikar.Size = new System.Drawing.Size(75, 23);
            this.btnCikar.TabIndex = 3;
            this.btnCikar.Text = "ÇIKAR";
            this.btnCikar.UseVisualStyleBackColor = true;
            this.btnCikar.Click += new System.EventHandler(this.btnCikar_Click);
            // 
            // btnKaydet
            // 
            this.btnKaydet.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnKaydet.Location = new System.Drawing.Point(348, 227);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(75, 23);
            this.btnKaydet.TabIndex = 4;
            this.btnKaydet.Text = "KAYDET";
            this.btnKaydet.UseVisualStyleBackColor = true;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // DersSecim
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(786, 456);
            this.Controls.Add(this.btnKaydet);
            this.Controls.Add(this.btnCikar);
            this.Controls.Add(this.btnEkle);
            this.Controls.Add(this.lsbSecilenDersler);
            this.Controls.Add(this.lsbTumDersler);
            this.Name = "DersSecim";
            this.Text = "DersSecim";
            this.Load += new System.EventHandler(this.DersSecim_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lsbTumDersler;
        private System.Windows.Forms.ListBox lsbSecilenDersler;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.Button btnCikar;
        private System.Windows.Forms.Button btnKaydet;
    }
}