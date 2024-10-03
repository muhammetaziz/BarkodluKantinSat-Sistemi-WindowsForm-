using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace BarkodSatışSistemi
{
    public partial class gelir_gider : Form
    {
        public string gelirgider { get; set; }

        public string kullanici { get; set; }
        public gelir_gider()
        {
            InitializeComponent();
        }


        private void todemetur_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (todemetur.SelectedIndex == 0)
            {
                tNakit.Enabled = true;
                tKart.Enabled = false;
            }
            else if (todemetur.SelectedIndex == 1)
            {
                tNakit.Enabled = false;
                tKart.Enabled = true;
            }
            else if (todemetur.SelectedIndex == 2)
            {
                tNakit.Enabled = true;
                tKart.Enabled = true;
            }
            tNakit.Text = "0";
            tKart.Text = "0";
        }

        private void bEkle_Click(object sender, EventArgs e)
        {
            if (todemetur.Text != "")
            {
                if (tNakit.Text != "" && tKart.Text != "")
                {
                    using (var DB = new BarkodDBEntities())
                    {
                        islemozet io = new islemozet();
                        io.islemNo = 0;
                        io.iade = false;
                        io.odemeSekli = todemetur.Text;
                        io.Nakit = islemler.DoubleYap(tNakit.Text);
                        io.Kart = islemler.DoubleYap(tKart.Text);
                        if (gelirgider == "Gelir")
                        {
                            io.Gelir = true;
                            io.Gider = false;
                        }
                        else
                        {
                            io.Gelir = false;
                            io.Gider = true;
                        }
                        io.AlisFiyatToplam = 0;
                        io.Aciklama =tAçıklama.Text+" "+ gelirgider+" işlemi";
                        io.Tarih = datetarih.Value;
                        io.Kullanici =gelirgider;
                        DB.islemozet.Add(io);
                        DB.SaveChanges();
                        MessageBox.Show(gelirgider+ " işlem kaydedildi");
                        tNakit.Text = "0";
                        tKart.Text = "0";
                        tAçıklama.Clear();
                        todemetur.Text = "";
                        Raporlama f = (Raporlama)Application.OpenForms["raporlama"];
                        if (f != null)
                        {
                            f.bgöster_Click(null, null);
                        }
                        this.Hide();
                    }
                }
            }
            else
            {
                MessageBox.Show("lütfen ödeme türünü belirleyiniz");
            }
        }

        private void gelir_gider_Load(object sender, EventArgs e)
        {
            kglrigid.Text = gelirgider + " işlemi Yapılıyor";
        }

        
    }
}
