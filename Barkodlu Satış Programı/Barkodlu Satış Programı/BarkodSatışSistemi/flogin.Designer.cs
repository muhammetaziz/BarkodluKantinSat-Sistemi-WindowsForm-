
namespace BarkodSatışSistemi
{
    partial class flogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(flogin));
            this.lkullaniciad = new System.Windows.Forms.Label();
            this.tkullaniciadi = new System.Windows.Forms.TextBox();
            this.tsifre = new System.Windows.Forms.TextBox();
            this.lsifre = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.bgiris = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lkullaniciad
            // 
            this.lkullaniciad.AutoSize = true;
            this.lkullaniciad.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lkullaniciad.ForeColor = System.Drawing.Color.White;
            this.lkullaniciad.Location = new System.Drawing.Point(19, 144);
            this.lkullaniciad.Name = "lkullaniciad";
            this.lkullaniciad.Size = new System.Drawing.Size(132, 25);
            this.lkullaniciad.TabIndex = 1;
            this.lkullaniciad.Text = "Kullanıcı Adı";
            // 
            // tkullaniciadi
            // 
            this.tkullaniciadi.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tkullaniciadi.Location = new System.Drawing.Point(147, 139);
            this.tkullaniciadi.Name = "tkullaniciadi";
            this.tkullaniciadi.Size = new System.Drawing.Size(185, 30);
            this.tkullaniciadi.TabIndex = 2;
            this.tkullaniciadi.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tkullaniciadi.TextChanged += new System.EventHandler(this.tkullaniciadi_TextChanged);
            // 
            // tsifre
            // 
            this.tsifre.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsifre.Location = new System.Drawing.Point(147, 180);
            this.tsifre.Name = "tsifre";
            this.tsifre.PasswordChar = '*';
            this.tsifre.Size = new System.Drawing.Size(185, 30);
            this.tsifre.TabIndex = 4;
            this.tsifre.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lsifre
            // 
            this.lsifre.AutoSize = true;
            this.lsifre.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lsifre.ForeColor = System.Drawing.Color.White;
            this.lsifre.Location = new System.Drawing.Point(94, 180);
            this.lsifre.Name = "lsifre";
            this.lsifre.Size = new System.Drawing.Size(57, 25);
            this.lsifre.TabIndex = 3;
            this.lsifre.Text = "Şifre";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label1.Location = new System.Drawing.Point(141, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(293, 32);
            this.label1.TabIndex = 5;
            this.label1.Text = "Barkodlu Satış Sistemi\r\n";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(142, 105);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(133, 25);
            this.label3.TabIndex = 6;
            this.label3.Text = "Giriş Yapınız";
            // 
            // bgiris
            // 
            this.bgiris.BackColor = System.Drawing.Color.Gray;
            this.bgiris.Cursor = System.Windows.Forms.Cursors.Default;
            this.bgiris.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.bgiris.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bgiris.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bgiris.ForeColor = System.Drawing.Color.White;
            this.bgiris.Location = new System.Drawing.Point(338, 139);
            this.bgiris.Name = "bgiris";
            this.bgiris.Size = new System.Drawing.Size(111, 71);
            this.bgiris.TabIndex = 7;
            this.bgiris.Text = "Giriş";
            this.bgiris.UseVisualStyleBackColor = false;
            this.bgiris.Click += new System.EventHandler(this.bgiris_Click);
            // 
            // flogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(523, 345);
            this.Controls.Add(this.bgiris);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tsifre);
            this.Controls.Add(this.lsifre);
            this.Controls.Add(this.tkullaniciadi);
            this.Controls.Add(this.lkullaniciad);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Name = "flogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Giriş Sayfası";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.bgiris_KeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button bgiris;
        public System.Windows.Forms.Label lkullaniciad;
        public System.Windows.Forms.TextBox tkullaniciadi;
        public System.Windows.Forms.TextBox tsifre;
        public System.Windows.Forms.Label lsifre;
    }
}