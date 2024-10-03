
namespace BarkodSatışSistemi
{
    partial class FurunGrubekle
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FurunGrubekle));
            this.lUrunGrupAd = new System.Windows.Forms.Label();
            this.listUrunGrup = new System.Windows.Forms.ListBox();
            this.tUrunGroupAd = new System.Windows.Forms.TextBox();
            this.bsil = new System.Windows.Forms.Button();
            this.bekle = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lUrunGrupAd
            // 
            this.lUrunGrupAd.AutoSize = true;
            this.lUrunGrupAd.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lUrunGrupAd.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.lUrunGrupAd.Location = new System.Drawing.Point(12, 22);
            this.lUrunGrupAd.Name = "lUrunGrupAd";
            this.lUrunGrupAd.Size = new System.Drawing.Size(112, 17);
            this.lUrunGrupAd.TabIndex = 55;
            this.lUrunGrupAd.Text = "Ürün Grub Adı";
            // 
            // listUrunGrup
            // 
            this.listUrunGrup.DisplayMember = "UrunGAd";
            this.listUrunGrup.FormattingEnabled = true;
            this.listUrunGrup.Location = new System.Drawing.Point(15, 83);
            this.listUrunGrup.Name = "listUrunGrup";
            this.listUrunGrup.Size = new System.Drawing.Size(204, 160);
            this.listUrunGrup.TabIndex = 56;
            this.listUrunGrup.ValueMember = "UrubId";
            // 
            // tUrunGroupAd
            // 
            this.tUrunGroupAd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tUrunGroupAd.Location = new System.Drawing.Point(15, 51);
            this.tUrunGroupAd.Name = "tUrunGroupAd";
            this.tUrunGroupAd.Size = new System.Drawing.Size(204, 26);
            this.tUrunGroupAd.TabIndex = 57;
            // 
            // bsil
            // 
            this.bsil.BackColor = System.Drawing.Color.Maroon;
            this.bsil.FlatAppearance.BorderColor = System.Drawing.Color.Maroon;
            this.bsil.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bsil.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bsil.Image = ((System.Drawing.Image)(resources.GetObject("bsil.Image")));
            this.bsil.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.bsil.Location = new System.Drawing.Point(15, 249);
            this.bsil.Name = "bsil";
            this.bsil.Size = new System.Drawing.Size(99, 58);
            this.bsil.TabIndex = 58;
            this.bsil.Text = "Sil";
            this.bsil.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.bsil.UseVisualStyleBackColor = false;
            this.bsil.Click += new System.EventHandler(this.bsil_Click);
            // 
            // bekle
            // 
            this.bekle.BackColor = System.Drawing.Color.Green;
            this.bekle.FlatAppearance.BorderColor = System.Drawing.Color.Green;
            this.bekle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bekle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bekle.Image = ((System.Drawing.Image)(resources.GetObject("bekle.Image")));
            this.bekle.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.bekle.Location = new System.Drawing.Point(120, 249);
            this.bekle.Name = "bekle";
            this.bekle.Size = new System.Drawing.Size(99, 58);
            this.bekle.TabIndex = 59;
            this.bekle.Text = "Ekle";
            this.bekle.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.bekle.UseVisualStyleBackColor = false;
            this.bekle.Click += new System.EventHandler(this.bekle_Click);
            // 
            // FurunGrubekle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(327, 318);
            this.Controls.Add(this.bekle);
            this.Controls.Add(this.bsil);
            this.Controls.Add(this.tUrunGroupAd);
            this.Controls.Add(this.listUrunGrup);
            this.Controls.Add(this.lUrunGrupAd);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FurunGrubekle";
            this.Text = "Urun Grubu Ekleme Sayfası";
            this.Load += new System.EventHandler(this.FurunGrubekle_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lUrunGrupAd;
        private System.Windows.Forms.ListBox listUrunGrup;
        public System.Windows.Forms.TextBox tUrunGroupAd;
        private System.Windows.Forms.Button bsil;
        private System.Windows.Forms.Button bekle;
    }
}