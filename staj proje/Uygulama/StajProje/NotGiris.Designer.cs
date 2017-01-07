namespace StajProje
{
    partial class NotGiris
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
            this.txtOgrenciNo = new System.Windows.Forms.TextBox();
            this.dgNotGiris = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgNotGiris)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(68, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 14);
            this.label1.TabIndex = 0;
            this.label1.Text = "Öğrenci No";
            // 
            // txtOgrenciNo
            // 
            this.txtOgrenciNo.Location = new System.Drawing.Point(165, 62);
            this.txtOgrenciNo.Name = "txtOgrenciNo";
            this.txtOgrenciNo.Size = new System.Drawing.Size(179, 20);
            this.txtOgrenciNo.TabIndex = 1;
            this.txtOgrenciNo.Click += new System.EventHandler(this.txtOgrenciNo_Click);
            // 
            // dgNotGiris
            // 
            this.dgNotGiris.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgNotGiris.Location = new System.Drawing.Point(71, 141);
            this.dgNotGiris.Name = "dgNotGiris";
            this.dgNotGiris.Size = new System.Drawing.Size(557, 150);
            this.dgNotGiris.TabIndex = 2;
            // 
            // NotGiris
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(692, 413);
            this.Controls.Add(this.dgNotGiris);
            this.Controls.Add(this.txtOgrenciNo);
            this.Controls.Add(this.label1);
            this.Name = "NotGiris";
            this.Text = "NotGiris";
            this.Load += new System.EventHandler(this.NotGiris_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgNotGiris)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtOgrenciNo;
        private System.Windows.Forms.DataGridView dgNotGiris;

    }
}