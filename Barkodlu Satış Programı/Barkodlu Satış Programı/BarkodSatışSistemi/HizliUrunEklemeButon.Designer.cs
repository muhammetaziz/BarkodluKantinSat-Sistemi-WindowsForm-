
namespace BarkodSatışSistemi
{
    partial class HizliUrunEklemeButon
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HizliUrunEklemeButon));
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.butonnumarasi = new System.Windows.Forms.Label();
            this.lbutonid = new System.Windows.Forms.Label();
            this.chtumugoster = new System.Windows.Forms.CheckBox();
            this.tUrunara = new System.Windows.Forms.TextBox();
            this.lBarkod = new System.Windows.Forms.Label();
            this.dataGridUrunler = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridUrunler)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.butonnumarasi);
            this.splitContainer1.Panel1.Controls.Add(this.lbutonid);
            this.splitContainer1.Panel1.Controls.Add(this.chtumugoster);
            this.splitContainer1.Panel1.Controls.Add(this.tUrunara);
            this.splitContainer1.Panel1.Controls.Add(this.lBarkod);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.dataGridUrunler);
            this.splitContainer1.Size = new System.Drawing.Size(800, 450);
            this.splitContainer1.SplitterDistance = 107;
            this.splitContainer1.TabIndex = 0;
            // 
            // butonnumarasi
            // 
            this.butonnumarasi.AutoSize = true;
            this.butonnumarasi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butonnumarasi.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.butonnumarasi.Location = new System.Drawing.Point(11, 28);
            this.butonnumarasi.Name = "butonnumarasi";
            this.butonnumarasi.Size = new System.Drawing.Size(128, 17);
            this.butonnumarasi.TabIndex = 8;
            this.butonnumarasi.Text = "Buton Numarası:";
            // 
            // lbutonid
            // 
            this.lbutonid.AutoSize = true;
            this.lbutonid.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbutonid.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.lbutonid.Location = new System.Drawing.Point(145, 28);
            this.lbutonid.Name = "lbutonid";
            this.lbutonid.Size = new System.Drawing.Size(78, 17);
            this.lbutonid.TabIndex = 7;
            this.lbutonid.Text = "Buton NO";
            // 
            // chtumugoster
            // 
            this.chtumugoster.AutoSize = true;
            this.chtumugoster.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chtumugoster.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.chtumugoster.Location = new System.Drawing.Point(263, 65);
            this.chtumugoster.Name = "chtumugoster";
            this.chtumugoster.Size = new System.Drawing.Size(165, 21);
            this.chtumugoster.TabIndex = 6;
            this.chtumugoster.Text = "tüm ünürleri göster";
            this.chtumugoster.UseVisualStyleBackColor = true;
            this.chtumugoster.CheckedChanged += new System.EventHandler(this.chtumugoster_CheckedChanged);
            // 
            // tUrunara
            // 
            this.tUrunara.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tUrunara.Location = new System.Drawing.Point(24, 67);
            this.tUrunara.Name = "tUrunara";
            this.tUrunara.Size = new System.Drawing.Size(201, 26);
            this.tUrunara.TabIndex = 5;
            this.tUrunara.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tUrunara.TextChanged += new System.EventHandler(this.tUrunara_TextChanged);
            // 
            // lBarkod
            // 
            this.lBarkod.AutoSize = true;
            this.lBarkod.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lBarkod.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.lBarkod.Location = new System.Drawing.Point(21, 47);
            this.lBarkod.Name = "lBarkod";
            this.lBarkod.Size = new System.Drawing.Size(73, 17);
            this.lBarkod.TabIndex = 4;
            this.lBarkod.Text = "Ürün Ara";
            // 
            // dataGridUrunler
            // 
            this.dataGridUrunler.AllowUserToAddRows = false;
            this.dataGridUrunler.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridUrunler.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridUrunler.BackgroundColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.dataGridUrunler.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridUrunler.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridUrunler.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridUrunler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridUrunler.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridUrunler.EnableHeadersVisualStyles = false;
            this.dataGridUrunler.Location = new System.Drawing.Point(0, 0);
            this.dataGridUrunler.Margin = new System.Windows.Forms.Padding(0);
            this.dataGridUrunler.Name = "dataGridUrunler";
            this.dataGridUrunler.RowHeadersVisible = false;
            this.dataGridUrunler.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dataGridUrunler.RowTemplate.ReadOnly = true;
            this.dataGridUrunler.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridUrunler.Size = new System.Drawing.Size(800, 339);
            this.dataGridUrunler.TabIndex = 4;
            this.dataGridUrunler.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridUrunler_CellContentDoubleClick);
            // 
            // HizliUrunEklemeButon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.splitContainer1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "HizliUrunEklemeButon";
            this.Text = "Hızlı Buton Ürün Ekleme";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridUrunler)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.DataGridView dataGridUrunler;
        private System.Windows.Forms.CheckBox chtumugoster;
        private System.Windows.Forms.TextBox tUrunara;
        private System.Windows.Forms.Label lBarkod;
        private System.Windows.Forms.Label butonnumarasi;
        public System.Windows.Forms.Label lbutonid;
    }
}