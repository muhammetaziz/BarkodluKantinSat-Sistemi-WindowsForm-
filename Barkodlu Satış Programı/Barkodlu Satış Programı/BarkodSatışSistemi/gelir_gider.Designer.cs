
namespace BarkodSatışSistemi
{
    partial class gelir_gider
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(gelir_gider));
            this.todemetur = new System.Windows.Forms.ComboBox();
            this.bEkle = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.datetarih = new System.Windows.Forms.DateTimePicker();
            this.tAçıklama = new System.Windows.Forms.TextBox();
            this.tKart = new System.Windows.Forms.TextBox();
            this.tNakit = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lgelirgide = new System.Windows.Forms.Label();
            this.kglrigid = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // todemetur
            // 
            this.todemetur.FormattingEnabled = true;
            this.todemetur.Items.AddRange(new object[] {
            "Nakit",
            "Kart",
            "Natit-Kart"});
            this.todemetur.Location = new System.Drawing.Point(25, 82);
            this.todemetur.Name = "todemetur";
            this.todemetur.Size = new System.Drawing.Size(201, 21);
            this.todemetur.TabIndex = 94;
            this.todemetur.SelectedIndexChanged += new System.EventHandler(this.todemetur_SelectedIndexChanged);
            // 
            // bEkle
            // 
            this.bEkle.BackColor = System.Drawing.Color.Brown;
            this.bEkle.FlatAppearance.BorderColor = System.Drawing.Color.Brown;
            this.bEkle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bEkle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bEkle.Image = ((System.Drawing.Image)(resources.GetObject("bEkle.Image")));
            this.bEkle.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.bEkle.Location = new System.Drawing.Point(116, 377);
            this.bEkle.Margin = new System.Windows.Forms.Padding(0);
            this.bEkle.Name = "bEkle";
            this.bEkle.Size = new System.Drawing.Size(99, 60);
            this.bEkle.TabIndex = 93;
            this.bEkle.Text = "Ekle";
            this.bEkle.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.bEkle.UseVisualStyleBackColor = false;
            this.bEkle.Click += new System.EventHandler(this.bEkle_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.label5.Location = new System.Drawing.Point(22, 324);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 17);
            this.label5.TabIndex = 92;
            this.label5.Text = "Tarih";
            // 
            // datetarih
            // 
            this.datetarih.Location = new System.Drawing.Point(25, 354);
            this.datetarih.Name = "datetarih";
            this.datetarih.Size = new System.Drawing.Size(190, 20);
            this.datetarih.TabIndex = 91;
            // 
            // tAçıklama
            // 
            this.tAçıklama.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tAçıklama.Location = new System.Drawing.Point(25, 201);
            this.tAçıklama.Multiline = true;
            this.tAçıklama.Name = "tAçıklama";
            this.tAçıklama.Size = new System.Drawing.Size(201, 109);
            this.tAçıklama.TabIndex = 90;
            // 
            // tKart
            // 
            this.tKart.Enabled = false;
            this.tKart.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tKart.Location = new System.Drawing.Point(136, 137);
            this.tKart.Multiline = true;
            this.tKart.Name = "tKart";
            this.tKart.Size = new System.Drawing.Size(90, 25);
            this.tKart.TabIndex = 89;
            this.tKart.Text = "0";
            this.tKart.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tNakit
            // 
            this.tNakit.Enabled = false;
            this.tNakit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tNakit.Location = new System.Drawing.Point(25, 137);
            this.tNakit.Multiline = true;
            this.tNakit.Name = "tNakit";
            this.tNakit.Size = new System.Drawing.Size(85, 25);
            this.tNakit.TabIndex = 88;
            this.tNakit.Text = "0";
            this.tNakit.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.label4.Location = new System.Drawing.Point(22, 181);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 17);
            this.label4.TabIndex = 87;
            this.label4.Text = "Açıklama";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.label3.Location = new System.Drawing.Point(131, 117);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 17);
            this.label3.TabIndex = 86;
            this.label3.Text = "Kart";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.label2.Location = new System.Drawing.Point(22, 117);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 17);
            this.label2.TabIndex = 85;
            this.label2.Text = "Nakit";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.label1.Location = new System.Drawing.Point(22, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 17);
            this.label1.TabIndex = 84;
            this.label1.Text = "Ödeme Türü";
            // 
            // lgelirgide
            // 
            this.lgelirgide.AutoSize = true;
            this.lgelirgide.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lgelirgide.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.lgelirgide.Location = new System.Drawing.Point(108, -17);
            this.lgelirgide.Name = "lgelirgide";
            this.lgelirgide.Size = new System.Drawing.Size(82, 17);
            this.lgelirgide.TabIndex = 83;
            this.lgelirgide.Text = "gelir gider";
            // 
            // kglrigid
            // 
            this.kglrigid.AutoSize = true;
            this.kglrigid.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kglrigid.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.kglrigid.Location = new System.Drawing.Point(22, 27);
            this.kglrigid.Name = "kglrigid";
            this.kglrigid.Size = new System.Drawing.Size(82, 17);
            this.kglrigid.TabIndex = 95;
            this.kglrigid.Text = "gelir gider";
            // 
            // gelir_gider
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(303, 468);
            this.Controls.Add(this.kglrigid);
            this.Controls.Add(this.todemetur);
            this.Controls.Add(this.bEkle);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.datetarih);
            this.Controls.Add(this.tAçıklama);
            this.Controls.Add(this.tKart);
            this.Controls.Add(this.tNakit);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lgelirgide);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "gelir_gider";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "gelir_gider";
            this.Load += new System.EventHandler(this.gelir_gider_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox todemetur;
        private System.Windows.Forms.Button bEkle;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker datetarih;
        public System.Windows.Forms.TextBox tAçıklama;
        public System.Windows.Forms.TextBox tKart;
        public System.Windows.Forms.TextBox tNakit;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lgelirgide;
        private System.Windows.Forms.Label kglrigid;
    }
}