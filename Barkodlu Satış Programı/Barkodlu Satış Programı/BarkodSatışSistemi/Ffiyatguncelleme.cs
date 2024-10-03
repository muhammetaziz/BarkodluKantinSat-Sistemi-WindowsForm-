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
    public partial class Ffiyatguncelleme : Form
    {
        public Ffiyatguncelleme()
        {
            InitializeComponent();
        }

        private void tBarkod_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                using (var db = new BarkodDBEntities())
                {
                    if (db.Urun.Any(x => x.Barkod == tBarkod.Text))
                    {
                        var getir = db.Urun.Where(x => x.Barkod == tBarkod.Text).SingleOrDefault();
                        lbarkod.Text = getir.Barkod;
                        lurunad.Text = getir.UrunAdi;
                        double mevcutfiyat = Convert.ToDouble(getir.SatisFiyat);
                        LMevcutFiyat.Text = mevcutfiyat.ToString("C2");
                    }
                    else
                    {
                        MessageBox.Show("Ürün Kayıtlı değil");
                    }
                }
            }
        }

        private void bgelirekle_Click(object sender, EventArgs e)
        {
            using (var db = new BarkodDBEntities())
            {
                if (tyenifiyat.Text != "" && lbarkod.Text != "")
                {
                    var guncelleme = db.Urun.Where(x => x.Barkod == lbarkod.Text).SingleOrDefault();
                    guncelleme.SatisFiyat = islemler.DoubleYap(tyenifiyat.Text);
                    int kdvorani = Convert.ToInt16(guncelleme.Kdvorani);
                    Math.Round(islemler.DoubleYap(tyenifiyat.Text) * Convert.ToInt32(kdvorani) / 100, 2);
                    guncelleme.TotalFiyat = guncelleme.Miktar * guncelleme.SatisFiyat;
                    db.SaveChanges();
                    MessageBox.Show("Yeni Fiyat Kaydedilmiştir");
                    lbarkod.Text = "";
                    lurunad.Text = "";
                    LMevcutFiyat.Text = "";
                    tyenifiyat.Clear();
                    tBarkod.Clear();
                    tBarkod.Focus();
                }
                else
                {
                    MessageBox.Show("ürün okutunuz");
                    tBarkod.Focus();
                }

            }
        }

    }
}
