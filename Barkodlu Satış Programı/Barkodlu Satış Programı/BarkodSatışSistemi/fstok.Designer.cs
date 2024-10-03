
namespace BarkodSatışSistemi
{
    partial class fstok
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fstok));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.bAra = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.cmurungrubu = new System.Windows.Forms.ComboBox();
            this.lURUNGRUP = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.baslangic = new System.Windows.Forms.Label();
            this.dateBaslangic = new System.Windows.Forms.DateTimePicker();
            this.dateBitis = new System.Windows.Forms.DateTimePicker();
            this.bitis = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lfiltrelem = new System.Windows.Forms.Label();
            this.Rurungurbagore = new System.Windows.Forms.RadioButton();
            this.RTumu = new System.Windows.Forms.RadioButton();
            this.cmislemtur = new System.Windows.Forms.ComboBox();
            this.lislemturu = new System.Windows.Forms.Label();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.braporal = new System.Windows.Forms.Button();
            this.lkullanici = new System.Windows.Forms.Label();
            this.turunara = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.GridList = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridList)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.bAra);
            this.splitContainer1.Panel1.Controls.Add(this.panel3);
            this.splitContainer1.Panel1.Controls.Add(this.panel2);
            this.splitContainer1.Panel1.Controls.Add(this.panel1);
            this.splitContainer1.Panel1.Controls.Add(this.cmislemtur);
            this.splitContainer1.Panel1.Controls.Add(this.lislemturu);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.splitContainer2);
            this.splitContainer1.Size = new System.Drawing.Size(800, 491);
            this.splitContainer1.SplitterDistance = 261;
            this.splitContainer1.TabIndex = 0;
            // 
            // bAra
            // 
            this.bAra.BackColor = System.Drawing.Color.Brown;
            this.bAra.FlatAppearance.BorderColor = System.Drawing.Color.Brown;
            this.bAra.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bAra.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bAra.Image = ((System.Drawing.Image)(resources.GetObject("bAra.Image")));
            this.bAra.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.bAra.Location = new System.Drawing.Point(119, 391);
            this.bAra.Margin = new System.Windows.Forms.Padding(0);
            this.bAra.Name = "bAra";
            this.bAra.Size = new System.Drawing.Size(99, 60);
            this.bAra.TabIndex = 49;
            this.bAra.Text = "Ara";
            this.bAra.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.bAra.UseVisualStyleBackColor = false;
            this.bAra.Click += new System.EventHandler(this.bAra_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.cmurungrubu);
            this.panel3.Controls.Add(this.lURUNGRUP);
            this.panel3.Location = new System.Drawing.Point(15, 170);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(203, 72);
            this.panel3.TabIndex = 46;
            // 
            // cmurungrubu
            // 
            this.cmurungrubu.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmurungrubu.FormattingEnabled = true;
            this.cmurungrubu.Location = new System.Drawing.Point(6, 39);
            this.cmurungrubu.Name = "cmurungrubu";
            this.cmurungrubu.Size = new System.Drawing.Size(193, 21);
            this.cmurungrubu.TabIndex = 41;
            // 
            // lURUNGRUP
            // 
            this.lURUNGRUP.AutoSize = true;
            this.lURUNGRUP.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lURUNGRUP.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.lURUNGRUP.Location = new System.Drawing.Point(3, 9);
            this.lURUNGRUP.Name = "lURUNGRUP";
            this.lURUNGRUP.Size = new System.Drawing.Size(93, 17);
            this.lURUNGRUP.TabIndex = 40;
            this.lURUNGRUP.Text = "Ürün Grubu";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.baslangic);
            this.panel2.Controls.Add(this.dateBaslangic);
            this.panel2.Controls.Add(this.dateBitis);
            this.panel2.Controls.Add(this.bitis);
            this.panel2.Location = new System.Drawing.Point(15, 248);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(203, 140);
            this.panel2.TabIndex = 45;
            // 
            // baslangic
            // 
            this.baslangic.AutoSize = true;
            this.baslangic.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.baslangic.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.baslangic.Location = new System.Drawing.Point(10, 20);
            this.baslangic.Name = "baslangic";
            this.baslangic.Size = new System.Drawing.Size(125, 17);
            this.baslangic.TabIndex = 37;
            this.baslangic.Text = "Başlangıç Tarihi";
            // 
            // dateBaslangic
            // 
            this.dateBaslangic.Location = new System.Drawing.Point(9, 49);
            this.dateBaslangic.Name = "dateBaslangic";
            this.dateBaslangic.Size = new System.Drawing.Size(190, 20);
            this.dateBaslangic.TabIndex = 40;
            // 
            // dateBitis
            // 
            this.dateBitis.Location = new System.Drawing.Point(10, 104);
            this.dateBitis.Name = "dateBitis";
            this.dateBitis.Size = new System.Drawing.Size(189, 20);
            this.dateBitis.TabIndex = 41;
            // 
            // bitis
            // 
            this.bitis.AutoSize = true;
            this.bitis.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bitis.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.bitis.Location = new System.Drawing.Point(10, 84);
            this.bitis.Name = "bitis";
            this.bitis.Size = new System.Drawing.Size(86, 17);
            this.bitis.TabIndex = 38;
            this.bitis.Text = "Bitiş Tarihi";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lfiltrelem);
            this.panel1.Controls.Add(this.Rurungurbagore);
            this.panel1.Controls.Add(this.RTumu);
            this.panel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(15, 72);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(203, 92);
            this.panel1.TabIndex = 44;
            // 
            // lfiltrelem
            // 
            this.lfiltrelem.AutoSize = true;
            this.lfiltrelem.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lfiltrelem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.lfiltrelem.Location = new System.Drawing.Point(3, 14);
            this.lfiltrelem.Name = "lfiltrelem";
            this.lfiltrelem.Size = new System.Drawing.Size(118, 17);
            this.lfiltrelem.TabIndex = 36;
            this.lfiltrelem.Text = "Filtreleme Türü";
            // 
            // Rurungurbagore
            // 
            this.Rurungurbagore.AutoSize = true;
            this.Rurungurbagore.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Rurungurbagore.Location = new System.Drawing.Point(6, 57);
            this.Rurungurbagore.Name = "Rurungurbagore";
            this.Rurungurbagore.Size = new System.Drawing.Size(153, 21);
            this.Rurungurbagore.TabIndex = 43;
            this.Rurungurbagore.TabStop = true;
            this.Rurungurbagore.Text = "Ürün Grubuna Göre";
            this.Rurungurbagore.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Rurungurbagore.UseVisualStyleBackColor = true;
            // 
            // RTumu
            // 
            this.RTumu.AutoSize = true;
            this.RTumu.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RTumu.Location = new System.Drawing.Point(6, 34);
            this.RTumu.Name = "RTumu";
            this.RTumu.Size = new System.Drawing.Size(62, 21);
            this.RTumu.TabIndex = 42;
            this.RTumu.TabStop = true;
            this.RTumu.Text = "Tümü";
            this.RTumu.UseVisualStyleBackColor = true;
            // 
            // cmislemtur
            // 
            this.cmislemtur.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmislemtur.FormattingEnabled = true;
            this.cmislemtur.Items.AddRange(new object[] {
            "Stok Durumu",
            "Stok Giriş izleme"});
            this.cmislemtur.Location = new System.Drawing.Point(15, 45);
            this.cmislemtur.Name = "cmislemtur";
            this.cmislemtur.Size = new System.Drawing.Size(203, 21);
            this.cmislemtur.TabIndex = 39;
            // 
            // lislemturu
            // 
            this.lislemturu.AutoSize = true;
            this.lislemturu.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lislemturu.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.lislemturu.Location = new System.Drawing.Point(12, 25);
            this.lislemturu.Name = "lislemturu";
            this.lislemturu.Size = new System.Drawing.Size(84, 17);
            this.lislemturu.TabIndex = 35;
            this.lislemturu.Text = "Işlem Türü";
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            this.splitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.braporal);
            this.splitContainer2.Panel1.Controls.Add(this.lkullanici);
            this.splitContainer2.Panel1.Controls.Add(this.turunara);
            this.splitContainer2.Panel1.Controls.Add(this.label1);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.GridList);
            this.splitContainer2.Size = new System.Drawing.Size(535, 491);
            this.splitContainer2.SplitterDistance = 146;
            this.splitContainer2.TabIndex = 0;
            // 
            // braporal
            // 
            this.braporal.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.braporal.FlatAppearance.BorderColor = System.Drawing.Color.DarkSeaGreen;
            this.braporal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.braporal.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.braporal.Image = ((System.Drawing.Image)(resources.GetObject("braporal.Image")));
            this.braporal.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.braporal.Location = new System.Drawing.Point(395, 45);
            this.braporal.Margin = new System.Windows.Forms.Padding(0);
            this.braporal.Name = "braporal";
            this.braporal.Size = new System.Drawing.Size(100, 80);
            this.braporal.TabIndex = 54;
            this.braporal.Text = "Rapo AL";
            this.braporal.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.braporal.UseVisualStyleBackColor = false;
            this.braporal.Click += new System.EventHandler(this.braporal_Click);
            // 
            // lkullanici
            // 
            this.lkullanici.AutoSize = true;
            this.lkullanici.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lkullanici.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.lkullanici.Location = new System.Drawing.Point(392, 25);
            this.lkullanici.Name = "lkullanici";
            this.lkullanici.Size = new System.Drawing.Size(67, 17);
            this.lkullanici.TabIndex = 55;
            this.lkullanici.Text = "kullanıcı";
            // 
            // turunara
            // 
            this.turunara.FormattingEnabled = true;
            this.turunara.Location = new System.Drawing.Point(113, 62);
            this.turunara.Name = "turunara";
            this.turunara.Size = new System.Drawing.Size(203, 21);
            this.turunara.TabIndex = 41;
            this.turunara.SelectedIndexChanged += new System.EventHandler(this.turunara_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.label1.Location = new System.Drawing.Point(34, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 17);
            this.label1.TabIndex = 40;
            this.label1.Text = "Ürün Ara";
            // 
            // GridList
            // 
            this.GridList.AllowUserToAddRows = false;
            this.GridList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.GridList.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.GridList.BackgroundColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.GridList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.GridList.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.GridList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.GridList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GridList.EnableHeadersVisualStyles = false;
            this.GridList.Location = new System.Drawing.Point(0, 0);
            this.GridList.Margin = new System.Windows.Forms.Padding(0);
            this.GridList.Name = "GridList";
            this.GridList.RowHeadersVisible = false;
            this.GridList.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.GridList.RowTemplate.ReadOnly = true;
            this.GridList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.GridList.Size = new System.Drawing.Size(535, 341);
            this.GridList.TabIndex = 6;
            // 
            // fstok
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 491);
            this.Controls.Add(this.splitContainer1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "fstok";
            this.Text = "Stok İzleme Sayfası";
            this.Load += new System.EventHandler(this.fstok_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel1.PerformLayout();
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.GridList)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Label bitis;
        private System.Windows.Forms.Label baslangic;
        private System.Windows.Forms.Label lfiltrelem;
        private System.Windows.Forms.Label lislemturu;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DateTimePicker dateBaslangic;
        private System.Windows.Forms.DateTimePicker dateBitis;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton Rurungurbagore;
        private System.Windows.Forms.RadioButton RTumu;
        private System.Windows.Forms.ComboBox cmislemtur;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.ComboBox cmurungrubu;
        private System.Windows.Forms.Label lURUNGRUP;
        private System.Windows.Forms.Button bAra;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.ComboBox turunara;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView GridList;
        private System.Windows.Forms.Button braporal;
        public System.Windows.Forms.Label lkullanici;
    }
}