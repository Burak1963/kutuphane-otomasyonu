namespace kütüphane
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.AdGiris = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SifreGiris = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.PersonelGirisButon = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // AdGiris
            // 
            this.AdGiris.Location = new System.Drawing.Point(135, 192);
            this.AdGiris.Name = "AdGiris";
            this.AdGiris.Size = new System.Drawing.Size(243, 22);
            this.AdGiris.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.label1.Location = new System.Drawing.Point(45, 198);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Personel Adı";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // SifreGiris
            // 
            this.SifreGiris.Location = new System.Drawing.Point(135, 235);
            this.SifreGiris.Name = "SifreGiris";
            this.SifreGiris.Size = new System.Drawing.Size(243, 22);
            this.SifreGiris.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.label3.Location = new System.Drawing.Point(45, 235);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "Şifre";
            // 
            // PersonelGirisButon
            // 
            this.PersonelGirisButon.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.PersonelGirisButon.Location = new System.Drawing.Point(135, 281);
            this.PersonelGirisButon.Name = "PersonelGirisButon";
            this.PersonelGirisButon.Size = new System.Drawing.Size(243, 44);
            this.PersonelGirisButon.TabIndex = 6;
            this.PersonelGirisButon.Text = "Giriş";
            this.PersonelGirisButon.UseVisualStyleBackColor = false;
            this.PersonelGirisButon.Click += new System.EventHandler(this.PersonelGirisButon_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(179, 50);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(74, 76);
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(463, 458);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.PersonelGirisButon);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.SifreGiris);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.AdGiris);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox AdGiris;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox SifreGiris;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button PersonelGirisButon;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

