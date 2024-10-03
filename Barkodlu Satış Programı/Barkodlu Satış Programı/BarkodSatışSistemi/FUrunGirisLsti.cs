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
    public partial class FUrunGirisLsti : Form
    {
        public FUrunGirisLsti()
        {
            InitializeComponent();
        }
        BarkodDBEntities DB = new BarkodDBEntities();
        private void tBarkod_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                string barkod = tBarkod.Text.Trim();
                if (DB.Urun.Any(a => a.Barkod == barkod))
                {
                    var urun = DB.Urun.Where(a => a.Barkod == barkod).SingleOrDefault();
                    turunadı.Text = urun.UrunAdi;
                    tacıklama.Text = urun.Acıklama;
                    cmUrunGrup.Text = urun.UrunGroup;
                    talisfiyat.Text = urun.AlisFiyat.ToString();
                    tsatisfiyat.Text = urun.SatisFiyat.ToString();
                    tmiktar.Text = urun.Miktar.ToString();
                    tkdvoran.Text = urun.Kdvorani.ToString();

                    if (urun.Birim == "Kg")
                    {
                          uruntipi.Checked = true;
                    }
                    else
                    {
                          uruntipi.Checked = false;
                    }
                }
                else
                {
                    MessageBox.Show("ürün kayıtlı değil");
                }
            }
        }

        private void bkaydet_Click(object sender, EventArgs e)
        {
            if (tBarkod.Text != "" && cmUrunGrup.Text != "" && talisfiyat.Text != "" && tsatisfiyat.Text != "" && tkdvoran.Text != "" && tmiktar.Text != "")
            {
                if (DB.Urun.Any(a => a.Barkod == tBarkod.Text))
                {
                    var guncelle = DB.Urun.Where(a => a.Barkod == tBarkod.Text).SingleOrDefault();
                    guncelle.Barkod = tBarkod.Text;
                    guncelle.UrunAdi = turunadı.Text;
                    guncelle.Acıklama = tacıklama.Text;
                    guncelle.UrunGroup = cmUrunGrup.Text;
                    guncelle.AlisFiyat = Convert.ToDouble(talisfiyat.Text);
                    guncelle.SatisFiyat = Convert.ToDouble(tsatisfiyat.Text);
                    guncelle.Kdvorani = Convert.ToInt32(tkdvoran.Text);
                    guncelle.Kdvtutari = Math.Round(islemler.DoubleYap(tsatisfiyat.Text) * Convert.ToInt32(tkdvoran.Text) / 100, 2);
                    guncelle.Miktar += Convert.ToDouble(tmiktar.Text);
                    guncelle.Onay = true;
                    if (uruntipi.Checked)
                    {
                        guncelle.Birim = "Kg";
                    }
                    else
                    {
                        guncelle.Birim = "Adet";
                    }

                    guncelle.Tarih = DateTime.Now;
                    guncelle.Kullanici = lkullanici.Text;
                    guncelle.TotalFiyat = guncelle.Miktar * guncelle.SatisFiyat;
                    DB.SaveChanges();
                    dataGridList.DataSource = DB.Urun.OrderByDescending(a => a.UrunId).Take(10).ToList();
                }
                else
                {
                    Urun urun = new Urun();
                    urun.Barkod = tBarkod.Text;
                    urun.UrunAdi = turunadı.Text;
                    urun.Acıklama = tacıklama.Text;
                    urun.UrunGroup = cmUrunGrup.Text;
                    urun.AlisFiyat = Convert.ToDouble(talisfiyat.Text);
                    urun.SatisFiyat = Convert.ToDouble(tsatisfiyat.Text);
                    urun.Kdvorani = Convert.ToInt32(tkdvoran.Text);
                    urun.Kdvtutari = Math.Round(islemler.DoubleYap(tsatisfiyat.Text) * Convert.ToInt32(tkdvoran.Text) / 100, 2);
                    urun.Miktar = Convert.ToDouble(tmiktar.Text);
                    var on=urun.Onay = false;
                    if (uruntipi.Checked)
                    {
                        urun.Birim = "Kg";
                    }
                    else
                    {
                        urun.Birim = "Adet";
                    }
                    urun.Tarih = DateTime.Now;
                    urun.Kullanici = lkullanici.Text;
                    urun.TotalFiyat = urun.Miktar * urun.SatisFiyat;
                    DB.Urun.Add(urun);
                    DB.SaveChanges();
                    
                    if (tBarkod.Text.Length == 8)
                    {
                        var ozelbarkod = DB.Barkod.First();
                        ozelbarkod.BarkodNo += 1;
                        DB.SaveChanges();
                    }
                    turunadı.Focus();

                    dataGridList.DataSource = DB.Urun.OrderByDescending(a => a.UrunId).Take(20).ToList();
                    islemler.GridDuzenle(dataGridList);
                }
                islemler.StokHareket(tBarkod.Text, turunadı.Text, "Adet", Convert.ToDouble(tmiktar.Text), cmUrunGrup.Text, lkullanici.Text);
                Temizle();
                turunsayisi.Text = DB.Urun.Count().ToString() ;
            }
            else
            {
                MessageBox.Show("Giriş bilgileri kontrol ediniz....");
                tBarkod.Focus();
            }
        }

       

        private void tÜrünara_TextChanged(object sender, EventArgs e)
        {
            if (tÜrünara.Text.Length >= 1)
            {
                string urunad = tÜrünara.Text;
                dataGridList.DataSource = DB.Urun.Where(a => a.UrunAdi.Contains(urunad)).ToList();
                islemler.GridDuzenle(dataGridList);
            }
        }

        private void burunekle_Click(object sender, EventArgs e)
        {
            FurunGrubekle f = new FurunGrubekle();
            f.ShowDialog();

        }

        private void Bbarkodolustur_Click(object sender, EventArgs e)
        {
            var barkodno = DB.Barkod.First();
            int karakter = barkodno.BarkodNo.ToString().Length;
            string sifirler = string.Empty;
            for (int i = 0; i < 8 - karakter; i++)
            {
                sifirler = sifirler + "0";
            }
            string olusanbarkod = sifirler + barkodno.BarkodNo.ToString();
            tBarkod.Text = olusanbarkod;

        }

        private void tsatisfiyat_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) == false && e.KeyChar != (char)08 && e.KeyChar != (char)44 && e.KeyChar != (char)45)
            {
                e.Handled = true;
            }
        }

        private void silToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dataGridList.Rows.Count > 0)
            {
                int urunid = Convert.ToInt32(dataGridList.CurrentRow.Cells["UrunId"].Value.ToString());
                string urunad = dataGridList.CurrentRow.Cells["UrunAdi"].Value.ToString();
                string barkod = dataGridList.CurrentRow.Cells["Barkod"].Value.ToString();
                DialogResult onay = MessageBox.Show(urunad + "ürünün silmek istiyor musunuz?", "Ürün silme işlemi", MessageBoxButtons.YesNo);
                if (onay == DialogResult.Yes)
                {
                    var urun = DB.Urun.Find(urunid);
                    DB.Urun.Remove(urun);
                    DB.SaveChanges();
                    var hizliurun = DB.HizliUrun.Where(x => x.Barkod == barkod).SingleOrDefault();
                    if (hizliurun != null)
                    {
                        hizliurun.Barkod = "-";
                        hizliurun.UrunAd = "-";
                        hizliurun.Fiyat = 0;
                        DB.SaveChanges();
                    }
                    MessageBox.Show("Ürün silinmiştir");
                    dataGridList.DataSource = DB.Urun.OrderByDescending(a => a.UrunId).Take(10).ToList();
                    islemler.GridDuzenle(dataGridList);
                    tBarkod.Focus();
                }
                turunsayisi.Text = DB.Urun.Count().ToString();
            }
        }

        private void detayToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dataGridList.Rows.Count > 0)
            {
                tBarkod.Text = dataGridList.CurrentRow.Cells["Barkod"].Value.ToString();
                turunadı.Text = dataGridList.CurrentRow.Cells["UrunAdi"].Value.ToString();
                tacıklama.Text = dataGridList.CurrentRow.Cells["Acıklama"].Value.ToString();
                cmUrunGrup.Text = dataGridList.CurrentRow.Cells["UrunGroup"].Value.ToString();
                talisfiyat.Text = dataGridList.CurrentRow.Cells["AlisFiyat"].Value.ToString();
                tsatisfiyat.Text = dataGridList.CurrentRow.Cells["SatisFiyat"].Value.ToString();
                tkdvoran.Text = dataGridList.CurrentRow.Cells["KdvOrani"].Value.ToString();
                tmiktar.Text = dataGridList.CurrentRow.Cells["Miktar"].Value.ToString();
                string birim = dataGridList.CurrentRow.Cells["Birim"].Value.ToString();
                if (birim == "kg")
                {
                    uruntipi.Checked = true;
                }
                else
                {
                    uruntipi.Checked = false;
                }
            }
        }

        private void biptal_Click(object sender, EventArgs e)
        {
            Temizle();
        }
        private void Temizle()
        {

            tBarkod.Clear();
            turunadı.Clear();
            tacıklama.Clear();
            talisfiyat.Text = "0";
            tsatisfiyat.Text = "0";
            tmiktar.Text = "0";
            tkdvoran.Text = "8";
            tBarkod.Focus();
            uruntipi.Checked = false;
        }

        private void uruntipi_CheckedChanged(object sender, EventArgs e)
        {
            if (uruntipi.Checked)
            {
                uruntipi.Text = "Gramajlı ürün işleme";
                tBarkod.Enabled = false;
            }
            else
            {
                uruntipi.Text = "Barkodlu ürün işleme";
                tBarkod.Enabled = true;
            }
        }

        private void FUrunGirisLsti_Load(object sender, EventArgs e)
        {
            
            Yenile();
            
        }
        public void Yenile()
        {
            dataGridList.DataSource = DB.Urun.ToList();
            turunsayisi.Text = DB.Urun.Count().ToString();
            cmUrunGrup.Items.Clear();
            foreach (var item in DB.UrunGrup)
            {
                cmUrunGrup.Items.Add(item.UrunGAd);
            }
        }

        private void bkullanmayanurun_Click(object sender, EventArgs e)
        {
            DialogResult onay = MessageBox.Show("!!Eğer tüm ürünlerin  fiyatlarının güncellemesini yapıldıysa EVET'e tıklayınız","kullanılmayan ürün silme işlemi",MessageBoxButtons.YesNo);
            if(onay == DialogResult.Yes)
            {
                Cursor.Current = Cursors.WaitCursor;
                DB.Urun.RemoveRange(DB.Urun.Where(x => x.Onay == false));
                DB.SaveChanges();
                dataGridList.DataSource = DB.Urun.OrderByDescending(a => a.UrunId).Take(10).ToList();
                MessageBox.Show("kullanılmayan ürün silindi");
                Cursor.Current = Cursors.Default;
            }
        }

    }
}
