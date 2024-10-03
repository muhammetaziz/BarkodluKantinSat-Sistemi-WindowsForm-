
namespace BarkodSatışSistemi
{
    partial class BarkodSatısProgramı
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BarkodSatısProgramı));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.bcikis = new System.Windows.Forms.Button();
            this.bkullanicidegistir = new System.Windows.Forms.Button();
            this.byedekleme = new System.Windows.Forms.Button();
            this.bayarlar = new System.Windows.Forms.Button();
            this.burungiris = new System.Windows.Forms.Button();
            this.bstoktakip = new System.Windows.Forms.Button();
            this.bgenelrapor = new System.Windows.Forms.Button();
            this.bsatisislemi = new System.Windows.Forms.Button();
            this.bfiyat = new System.Windows.Forms.Button();
            this.lkullanici = new System.Windows.Forms.Label();
            this.lisyeri = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tableLayoutPanel1.Controls.Add(this.bcikis, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.bkullanicidegistir, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.byedekleme, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.bayarlar, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.burungiris, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.bstoktakip, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.bgenelrapor, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.bsatisislemi, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.bfiyat, 2, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(31, 61);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(421, 259);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // bcikis
            // 
            this.bcikis.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.bcikis.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bcikis.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption;
            this.bcikis.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bcikis.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bcikis.Image = ((System.Drawing.Image)(resources.GetObject("bcikis.Image")));
            this.bcikis.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bcikis.Location = new System.Drawing.Point(283, 175);
            this.bcikis.Name = "bcikis";
            this.bcikis.Size = new System.Drawing.Size(135, 81);
            this.bcikis.TabIndex = 8;
            this.bcikis.Text = "Çıkış";
            this.bcikis.UseVisualStyleBackColor = false;
            this.bcikis.Click += new System.EventHandler(this.bcikis_Click);
            // 
            // bkullanicidegistir
            // 
            this.bkullanicidegistir.BackColor = System.Drawing.Color.Green;
            this.bkullanicidegistir.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bkullanicidegistir.FlatAppearance.BorderColor = System.Drawing.Color.Green;
            this.bkullanicidegistir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bkullanicidegistir.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bkullanicidegistir.Image = ((System.Drawing.Image)(resources.GetObject("bkullanicidegistir.Image")));
            this.bkullanicidegistir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bkullanicidegistir.Location = new System.Drawing.Point(143, 175);
            this.bkullanicidegistir.Name = "bkullanicidegistir";
            this.bkullanicidegistir.Size = new System.Drawing.Size(134, 81);
            this.bkullanicidegistir.TabIndex = 7;
            this.bkullanicidegistir.Text = "Kullanıcı \r\nDeğiştir";
            this.bkullanicidegistir.UseVisualStyleBackColor = false;
            this.bkullanicidegistir.Click += new System.EventHandler(this.bkullanicidegistir_Click);
            // 
            // byedekleme
            // 
            this.byedekleme.BackColor = System.Drawing.Color.RosyBrown;
            this.byedekleme.Dock = System.Windows.Forms.DockStyle.Fill;
            this.byedekleme.FlatAppearance.BorderColor = System.Drawing.Color.RosyBrown;
            this.byedekleme.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.byedekleme.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.byedekleme.Image = ((System.Drawing.Image)(resources.GetObject("byedekleme.Image")));
            this.byedekleme.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.byedekleme.Location = new System.Drawing.Point(3, 175);
            this.byedekleme.Name = "byedekleme";
            this.byedekleme.Size = new System.Drawing.Size(134, 81);
            this.byedekleme.TabIndex = 6;
            this.byedekleme.Text = "Yedekleme";
            this.byedekleme.UseVisualStyleBackColor = false;
            this.byedekleme.Click += new System.EventHandler(this.byedekleme_Click);
            // 
            // bayarlar
            // 
            this.bayarlar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.bayarlar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bayarlar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.bayarlar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bayarlar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bayarlar.Image = ((System.Drawing.Image)(resources.GetObject("bayarlar.Image")));
            this.bayarlar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bayarlar.Location = new System.Drawing.Point(143, 89);
            this.bayarlar.Name = "bayarlar";
            this.bayarlar.Size = new System.Drawing.Size(134, 80);
            this.bayarlar.TabIndex = 4;
            this.bayarlar.Text = "Ayarlar";
            this.bayarlar.UseVisualStyleBackColor = false;
            this.bayarlar.Click += new System.EventHandler(this.bayarlar_Click);
            // 
            // burungiris
            // 
            this.burungiris.BackColor = System.Drawing.SystemColors.Highlight;
            this.burungiris.Dock = System.Windows.Forms.DockStyle.Fill;
            this.burungiris.FlatAppearance.BorderColor = System.Drawing.SystemColors.Highlight;
            this.burungiris.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.burungiris.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.burungiris.Image = ((System.Drawing.Image)(resources.GetObject("burungiris.Image")));
            this.burungiris.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.burungiris.Location = new System.Drawing.Point(3, 89);
            this.burungiris.Name = "burungiris";
            this.burungiris.Size = new System.Drawing.Size(134, 80);
            this.burungiris.TabIndex = 3;
            this.burungiris.Text = "Ürün \r\nGiriş";
            this.burungiris.UseVisualStyleBackColor = false;
            this.burungiris.Click += new System.EventHandler(this.burungiris_Click);
            // 
            // bstoktakip
            // 
            this.bstoktakip.BackColor = System.Drawing.Color.Gray;
            this.bstoktakip.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bstoktakip.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.bstoktakip.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bstoktakip.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bstoktakip.Image = ((System.Drawing.Image)(resources.GetObject("bstoktakip.Image")));
            this.bstoktakip.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bstoktakip.Location = new System.Drawing.Point(283, 3);
            this.bstoktakip.Name = "bstoktakip";
            this.bstoktakip.Size = new System.Drawing.Size(135, 80);
            this.bstoktakip.TabIndex = 2;
            this.bstoktakip.Text = "Stok \r\nTakibi";
            this.bstoktakip.UseVisualStyleBackColor = false;
            this.bstoktakip.Click += new System.EventHandler(this.bstoktakip_Click);
            // 
            // bgenelrapor
            // 
            this.bgenelrapor.BackColor = System.Drawing.Color.IndianRed;
            this.bgenelrapor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bgenelrapor.FlatAppearance.BorderColor = System.Drawing.Color.IndianRed;
            this.bgenelrapor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bgenelrapor.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bgenelrapor.Image = ((System.Drawing.Image)(resources.GetObject("bgenelrapor.Image")));
            this.bgenelrapor.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bgenelrapor.Location = new System.Drawing.Point(143, 3);
            this.bgenelrapor.Name = "bgenelrapor";
            this.bgenelrapor.Size = new System.Drawing.Size(134, 80);
            this.bgenelrapor.TabIndex = 1;
            this.bgenelrapor.Text = "Genel\r\n Rapor";
            this.bgenelrapor.UseVisualStyleBackColor = false;
            this.bgenelrapor.Click += new System.EventHandler(this.bgenelrapor_Click);
            // 
            // bsatisislemi
            // 
            this.bsatisislemi.BackColor = System.Drawing.Color.OrangeRed;
            this.bsatisislemi.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bsatisislemi.FlatAppearance.BorderColor = System.Drawing.Color.OrangeRed;
            this.bsatisislemi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bsatisislemi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bsatisislemi.Image = ((System.Drawing.Image)(resources.GetObject("bsatisislemi.Image")));
            this.bsatisislemi.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bsatisislemi.Location = new System.Drawing.Point(3, 3);
            this.bsatisislemi.Name = "bsatisislemi";
            this.bsatisislemi.Size = new System.Drawing.Size(134, 80);
            this.bsatisislemi.TabIndex = 0;
            this.bsatisislemi.Text = "Satış \r\nIşlemi";
            this.bsatisislemi.UseVisualStyleBackColor = false;
            this.bsatisislemi.Click += new System.EventHandler(this.bsatisislemi_Click);
            // 
            // bfiyat
            // 
            this.bfiyat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bfiyat.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bfiyat.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bfiyat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bfiyat.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bfiyat.Image = ((System.Drawing.Image)(resources.GetObject("bfiyat.Image")));
            this.bfiyat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bfiyat.Location = new System.Drawing.Point(283, 89);
            this.bfiyat.Name = "bfiyat";
            this.bfiyat.Size = new System.Drawing.Size(135, 80);
            this.bfiyat.TabIndex = 10;
            this.bfiyat.Text = "Fiyat\r\nGücelle";
            this.bfiyat.UseVisualStyleBackColor = false;
            this.bfiyat.Click += new System.EventHandler(this.bfiyat_Click_1);
            // 
            // lkullanici
            // 
            this.lkullanici.AutoSize = true;
            this.lkullanici.BackColor = System.Drawing.Color.Black;
            this.lkullanici.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lkullanici.ForeColor = System.Drawing.Color.White;
            this.lkullanici.Location = new System.Drawing.Point(126, 337);
            this.lkullanici.Name = "lkullanici";
            this.lkullanici.Size = new System.Drawing.Size(67, 17);
            this.lkullanici.TabIndex = 1;
            this.lkullanici.Text = "kullanıcı";
            // 
            // lisyeri
            // 
            this.lisyeri.AutoSize = true;
            this.lisyeri.BackColor = System.Drawing.Color.Black;
            this.lisyeri.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lisyeri.ForeColor = System.Drawing.Color.White;
            this.lisyeri.Location = new System.Drawing.Point(31, 19);
            this.lisyeri.Name = "lisyeri";
            this.lisyeri.Size = new System.Drawing.Size(72, 17);
            this.lisyeri.TabIndex = 2;
            this.lisyeri.Text = "kullanıcı ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(28, 337);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Kullanıcı Adı:";
            // 
            // BarkodSatısProgramı
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(525, 385);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lisyeri);
            this.Controls.Add(this.lkullanici);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "BarkodSatısProgramı";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Barkodlu Satıs Programı";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.BarkodSatısProgramı_FormClosed);
            this.Load += new System.EventHandler(this.BarkodSatısProgramı_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        public System.Windows.Forms.Button bcikis;
        public System.Windows.Forms.Button bkullanicidegistir;
        public System.Windows.Forms.Button byedekleme;
        public System.Windows.Forms.Button bayarlar;
        public System.Windows.Forms.Button burungiris;
        public System.Windows.Forms.Button bstoktakip;
        public System.Windows.Forms.Button bgenelrapor;
        public System.Windows.Forms.Button bsatisislemi;
        public System.Windows.Forms.Label lkullanici;
        public System.Windows.Forms.Label lisyeri;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.Button bfiyat;
    }
}