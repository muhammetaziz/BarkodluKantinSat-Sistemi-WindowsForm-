
namespace yedektenalma
{
    partial class Form1
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.byedeksec = new System.Windows.Forms.Button();
            this.byukla = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(15, 31);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(407, 38);
            this.textBox1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(199, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "en son aldığınız yedeği seçiniz";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(12, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(412, 34);
            this.label2.TabIndex = 2;
            this.label2.Text = "bu işlemi yaptığınız zaman mevcut veriler silinecek yedeğinizdeki\r\nbilgiler yükle" +
    "necektir\r\n";
            // 
            // byedeksec
            // 
            this.byedeksec.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.byedeksec.Location = new System.Drawing.Point(428, 31);
            this.byedeksec.Name = "byedeksec";
            this.byedeksec.Size = new System.Drawing.Size(121, 37);
            this.byedeksec.TabIndex = 3;
            this.byedeksec.Text = "Yedek Seç";
            this.byedeksec.UseVisualStyleBackColor = true;
            this.byedeksec.Click += new System.EventHandler(this.byedeksec_Click);
            // 
            // byukla
            // 
            this.byukla.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.byukla.Location = new System.Drawing.Point(428, 74);
            this.byukla.Name = "byukla";
            this.byukla.Size = new System.Drawing.Size(121, 37);
            this.byukla.TabIndex = 4;
            this.byukla.Text = "Yükle";
            this.byukla.UseVisualStyleBackColor = true;
            this.byukla.Click += new System.EventHandler(this.byukla_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(555, 135);
            this.Controls.Add(this.byukla);
            this.Controls.Add(this.byedeksec);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Barkod Satış Programı_Yedek Yükleme Sayfası";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button byedeksec;
        private System.Windows.Forms.Button byukla;
    }
}

