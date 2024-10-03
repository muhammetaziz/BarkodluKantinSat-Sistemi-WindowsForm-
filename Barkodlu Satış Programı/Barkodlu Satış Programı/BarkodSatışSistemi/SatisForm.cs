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
    public partial class BarkodSistemi : Form
    {
        BarkodDBEntities DB = new BarkodDBEntities();
        public BarkodSistemi()
        {
            InitializeComponent();
        }
        public string miktar { get; set; }
        private void BarkodSistemi_Load(object sender, EventArgs e)
        {
            tBbarkod.Focus();
            HizliButonDoldur();
            b5.Text = 5.ToString("C2");
            b10.Text = 10.ToString("C2");
            b20.Text = 20.ToString("C2");
            b50.Text = 50.ToString("C2");
            b100.Text = 100.ToString("C2");
            b200.Text = 200.ToString("C2");
            using (var db = new BarkodDBEntities())
            {
                var sabit = db.Sabit.FirstOrDefault();
                chYazdırmaDurumu.Checked = Convert.ToBoolean(sabit.Yazici);
            }
        }

        private void HizliButonDoldur()
        {
            var hizliUrun = DB.HizliUrun.ToList();
            foreach (var item in hizliUrun)
            {
                Button bh = this.Controls.Find("BH" + item.Id, true).FirstOrDefault() as Button;
                if (bh != null)
                {
                    double fiyat = islemler.DoubleYap(item.Fiyat.ToString());
                    bh.Text = item.UrunAd + "\n" + fiyat.ToString("C2");
                }
            }
        }

        private void HizliButonClick(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            int butonid = Convert.ToInt16(b.Name.ToString().Substring(2, b.Name.Length - 2));

            if (b.Text.ToString().StartsWith("-"))
            {
                HizliUrunEklemeButon f = new HizliUrunEklemeButon();
                f.lbutonid.Text = butonid.ToString();
                f.ShowDialog();
            }
            else
            {

                var urunbarkod = DB.HizliUrun.Where(a => a.Id == butonid).Select(a => a.Barkod).FirstOrDefault();
                var urun = DB.Urun.Where(a => a.Barkod == urunbarkod).FirstOrDefault();
                UrunGetirListeye(urun, urunbarkod, Convert.ToDouble(tBMiktar.Text));
                tBbarkod.Text = urunbarkod;
                GenelToplam();
            }

        }


        private void tBbarkod_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                string barkod = tBbarkod.Text;
                if (barkod.Length <= 2)
                {
                    tBMiktar.Text = barkod;
                    tBbarkod.Clear();
                    tBbarkod.Focus();
                }
                else
                {
                    if (DB.Urun.Any(a => a.Barkod == barkod))
                    {

                        var urun = DB.Urun.FirstOrDefault(x => x.Barkod == barkod);
                        UrunGetirListeye(urun, barkod, Convert.ToDouble(tBMiktar.Text));
                    }
                    else
                    {
                        int onek = Convert.ToInt32(barkod.Substring(0, 2));
                        if (DB.Terazi.Any(a => a.TeraziOnEk == onek))
                        {
                            string teraziurunno = barkod.Substring(2, 5);
                            if (DB.Urun.Any(a => a.Barkod == teraziurunno))
                            {
                                var urunterazi = DB.Urun.Where(a => a.Barkod == teraziurunno).FirstOrDefault();
                                double miktarkg = Convert.ToDouble(barkod.Substring(7, 5)) / 1000;
                                UrunGetirListeye(urunterazi, teraziurunno, miktarkg);
                            }

                            else
                            {
                                Console.Beep(900, 2000);
                                MessageBox.Show("kg ürün ekleme sayfası");
                            }
                        }
                        else
                        {
                            Console.Beep(900, 2000);
                            FUrunGirisLsti f = new FUrunGirisLsti();
                            f.tBarkod.Text = barkod;
                            f.ShowDialog();
                        }

                    }
                }
                dataGridList.ClearSelection();
                GenelToplam();
            }

        }

        private void UrunGetirListeye(Urun urun, string barkod, double miktar)
        {
            int satirsayisi = dataGridList.RowCount;
            bool eklenmismi = false;
            if (satirsayisi > 0)
            {
                for (int i = 0; i < satirsayisi; i++)
                {

                    if (dataGridList.Rows[i].Cells["Barkod"].Value.ToString() == barkod)
                    {
                        dataGridList.Rows[i].Cells["Miktar"].Value = miktar + Convert.ToDouble(dataGridList.Rows[i].Cells["Miktar"].Value);
                        dataGridList.Rows[i].Cells["Toplam"].Value = Math.Round(Convert.ToDouble(dataGridList.Rows[i].Cells["Miktar"].Value) * Convert.ToDouble(dataGridList.Rows[i].Cells["Fiyat"].Value), 2);
                        double dblKdvTutari = (double)urun.Kdvtutari;
                        dataGridList.Rows[i].Cells["KdvTutarı"].Value = Convert.ToDouble(dataGridList.Rows[i].Cells["Miktar"].Value) * dblKdvTutari;
                        eklenmismi = true;
                    }
                }
            }
            if (eklenmismi == false)
            {
                dataGridList.Rows.Add();
                dataGridList.Rows[satirsayisi].Cells["Barkod"].Value = barkod;
                dataGridList.Rows[satirsayisi].Cells["ÜrünAdi"].Value = urun.UrunAdi;
                dataGridList.Rows[satirsayisi].Cells["ÜrünGroup"].Value = urun.UrunGroup;
                dataGridList.Rows[satirsayisi].Cells["Birim"].Value = urun.Birim;
                dataGridList.Rows[satirsayisi].Cells["Fiyat"].Value = urun.SatisFiyat;
                dataGridList.Rows[satirsayisi].Cells["Miktar"].Value = miktar;
                dataGridList.Rows[satirsayisi].Cells["Toplam"].Value = Math.Round(miktar * (double)urun.SatisFiyat, 2);
                dataGridList.Rows[satirsayisi].Cells["AlişFiyat"].Value = urun.AlisFiyat;
                dataGridList.Rows[satirsayisi].Cells["KdvTutarı"].Value = urun.Kdvtutari;

            }

            tBbarkod.Clear();
        }
        private void GenelToplam()
        {
            double toplam = 0;
            for (int i = 0; i < dataGridList.Rows.Count; i++)
            {
                toplam += Convert.ToDouble(dataGridList.Rows[i].Cells["Toplam"].Value);
            }
            tgenelToplam.Text = toplam.ToString("c2");
            tBbarkod.Focus();
            tBbarkod.Clear();
        }

        private void dataGridList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 9)
            {
                dataGridList.Rows.Remove(dataGridList.CurrentRow);
                dataGridList.ClearSelection();
                GenelToplam();
                tBbarkod.Focus();
            }

        }

        private void BH_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                Button b = (Button)sender;
                if (!b.Text.StartsWith("-"))
                {
                    int butonid = Convert.ToInt16(b.Name.ToString().Substring(2, b.Name.Length - 2));
                    ContextMenuStrip s = new ContextMenuStrip();
                    ToolStripMenuItem sil = new ToolStripMenuItem();
                    sil.Text = "Temizle - Buton No:" + butonid.ToString();
                    sil.Click += Sil_Click;
                    s.Items.Add(sil);
                    this.ContextMenuStrip = s;
                }
            }
        }

        private void Sil_Click(object sender, EventArgs e)
        {
            int butonid = Convert.ToInt16(sender.ToString().Substring(19, sender.ToString().Length - 19));
            var guncelle = DB.HizliUrun.Find(butonid);
            guncelle.Barkod = "-";
            guncelle.UrunAd = "-";
            guncelle.Fiyat = 0;
            DB.SaveChanges();
            double fiyat = 0;
            Button b = this.Controls.Find("BH" + butonid, true).FirstOrDefault() as Button;
            b.Text = "-" + "\n" + fiyat.ToString("C2");
        }

        private void bNx_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            if (b.Text == ",")
            {
                int virgul = tNumarator.Text.Count(x => x == ',');
                if (virgul < 1)
                {
                    tNumarator.Text += b.Text;
                }
            }
            else if (b.Text == "<")
            {
                if (tNumarator.Text.Length > 0)
                {
                    tNumarator.Text = tNumarator.Text.Substring(0, tNumarator.Text.Length - 1);
                }
            }
            else
            {
                tNumarator.Text += b.Text;
            }

        }

        private void bAdet_Click(object sender, EventArgs e)
        {
            if (tNumarator.Text != "")
            {
                tBMiktar.Text = tNumarator.Text;
                tNumarator.Clear();
                tBbarkod.Clear();
                tBbarkod.Focus();
            }
        }

        private void bÖdenen_Click(object sender, EventArgs e)
        {
            if (tNumarator.Text != "")
            {
                double sonuc = islemler.DoubleYap(tNumarator.Text) - islemler.DoubleYap(tgenelToplam.Text);
                tParaüstü.Text = sonuc.ToString("C2");
                tOdenen.Text = islemler.DoubleYap(tNumarator.Text).ToString("C2");
                tNumarator.Clear();
                tBbarkod.Focus();
            }
        }

        private void bBarkod_Click(object sender, EventArgs e)
        {
            if (tNumarator.Text != "")
            {
                if (DB.Urun.Any(a => a.Barkod == tNumarator.Text))
                {
                    var urun = DB.Urun.Where(a => a.Barkod == tNumarator.Text).FirstOrDefault();
                    UrunGetirListeye(urun, tNumarator.Text, Convert.ToDouble(tBMiktar.Text));
                    tNumarator.Clear();
                    tBbarkod.Focus();
                }
                else
                {
                    MessageBox.Show("ürün ekleme sayfasını aç");
                }
            }
        }

        private void ParaUstuHesapla_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            double sonuc = islemler.DoubleYap(b.Text) - islemler.DoubleYap(tgenelToplam.Text);
            tOdenen.Text = islemler.DoubleYap(b.Text).ToString("C2");
            tParaüstü.Text = sonuc.ToString("C2");
        }

        private void bDiğerÜrün_Click(object sender, EventArgs e)
        {
            if (tNumarator.Text != "")
            {
                int satirsayisi = dataGridList.Rows.Count;
                dataGridList.Rows.Add();
                dataGridList.Rows[satirsayisi].Cells["Barkod"].Value = "00000000001";
                dataGridList.Rows[satirsayisi].Cells["ÜrünAdi"].Value = "urun adi";
                dataGridList.Rows[satirsayisi].Cells["ÜrünGroup"].Value = "Barkodsuz";
                dataGridList.Rows[satirsayisi].Cells["Birim"].Value = "Adet";
                dataGridList.Rows[satirsayisi].Cells["Fiyat"].Value = Convert.ToDouble(tNumarator.Text);
                dataGridList.Rows[satirsayisi].Cells["Miktar"].Value = 1;
                dataGridList.Rows[satirsayisi].Cells["Toplam"].Value = Convert.ToDouble(tNumarator.Text);
                dataGridList.Rows[satirsayisi].Cells["KdvTutarı"].Value = 0;
                tNumarator.Text = "";
                GenelToplam();
                tBbarkod.Focus();

            }
        }

        private void bIade_Click(object sender, EventArgs e)
        {
            if (csatisiadeyapiliyor.Checked)
            {
                csatisiadeyapiliyor.Checked = false;
                csatisiadeyapiliyor.Text = "Satış Yapılıyor";
            }
            else
            {
                csatisiadeyapiliyor.Checked = true;
                csatisiadeyapiliyor.Text = "Iade işlemi Yalılıyor";
            }
        }

        private void bTemizle_Click(object sender, EventArgs e)
        {
            Temizle();
        }

        private void Temizle()
        {
            tBMiktar.Text = "1";
            tBbarkod.Clear();
            tOdenen.Clear();
            tParaüstü.Clear();
            tgenelToplam.Text = 0.ToString("C2");
            csatisiadeyapiliyor.Checked = false;
            tNumarator.Clear();
            dataGridList.Rows.Clear();
            tBbarkod.Clear();
            tBbarkod.Focus();
        }

        public void SatisYap(string odemesekli)
        {
            int satirsayisi = dataGridList.Rows.Count;
            bool satisiade = csatisiadeyapiliyor.Checked;
            double alisfiyattoplam = 0;
            Satis satis = new Satis();
            for (int i = 0; i < satirsayisi; i++)
            {
                if (!satisiade)
                {
                    Urun un = new Urun();
                    un = DB.Urun.Where(x => x.Barkod == tBbarkod.Text).FirstOrDefault();
                    double miktar1 = islemler.DoubleYap(dataGridList.Rows[i].Cells["Miktar"].Value.ToString());

                    if (un.Miktar >= ((float)miktar1) && un.Miktar != 0)
                    {
                        islemler.StokAzalt(satis.Barkod = dataGridList.Rows[i].Cells["Barkod"].Value.ToString(), islemler.DoubleYap(dataGridList.Rows[i].Cells["Miktar"].Value.ToString()));
                        alisfiyattoplam += islemler.DoubleYap(dataGridList.Rows[i].Cells["AlişFiyat"].Value.ToString()) * islemler.DoubleYap(dataGridList.Rows[i].Cells["Miktar"].Value.ToString()); ;
                        ozet(odemesekli);

                    }
                    if (un.Miktar < miktar1 && un.Miktar != 0)
                    {
                        MessageBox.Show("bu satışa yetecek stokunuz yoktur");
                        Temizle();
                    }
                    if (un.Miktar == 0)
                    {
                        MessageBox.Show("stok=0");
                        Temizle();
                    }
                }
                else
                {
                    islemler.StokArtir(satis.Barkod = dataGridList.Rows[i].Cells["Barkod"].Value.ToString(), islemler.DoubleYap(dataGridList.Rows[i].Cells["Miktar"].Value.ToString()));
                    alisfiyattoplam += islemler.DoubleYap(dataGridList.Rows[i].Cells["AlişFiyat"].Value.ToString()) * islemler.DoubleYap(dataGridList.Rows[i].Cells["Miktar"].Value.ToString()); ;
                    ozet(odemesekli);
                }
            }



        }


        private void bNakit_Click(object sender, EventArgs e)
        {
            SatisYap("Nakit");
        }

        private void ozet(string odemesekli)
        {
            int satirsayisi = dataGridList.Rows.Count;
            bool satisiade = csatisiadeyapiliyor.Checked;
            double alisfiyattoplam = 0;

            if (satirsayisi > 0)
            {
                int? islemno = DB.islem.First().islemNo;
                Satis satis = new Satis();

                for (int i = 0; i < satirsayisi; i++)
                {
                    satis.IslemNo = islemno;
                    satis.UrunAd = dataGridList.Rows[i].Cells["ÜrünAdi"].Value.ToString();
                    satis.UrunGrup = dataGridList.Rows[i].Cells["ÜrünGroup"].Value.ToString();
                    satis.Barkod = dataGridList.Rows[i].Cells["Barkod"].Value.ToString();
                    satis.Birim = dataGridList.Rows[i].Cells["Birim"].Value.ToString();
                    satis.AlisFiyat = islemler.DoubleYap(dataGridList.Rows[i].Cells["AlişFiyat"].Value.ToString());
                    satis.SatisFiyat = islemler.DoubleYap(dataGridList.Rows[i].Cells["Fiyat"].Value.ToString());
                    satis.Miktar = islemler.DoubleYap(dataGridList.Rows[i].Cells["Miktar"].Value.ToString());
                    satis.Toplam = islemler.DoubleYap(dataGridList.Rows[i].Cells["Toplam"].Value.ToString());
                    satis.KdvTutari = islemler.DoubleYap(dataGridList.Rows[i].Cells["KdvTutarı"].Value.ToString()) * islemler.DoubleYap(dataGridList.Rows[i].Cells["Miktar"].Value.ToString());


                    satis.OdemeSekli = odemesekli;
                    satis.Iade = satisiade;
                    satis.Tarih = DateTime.Now;
                    DB.Satis.Add(satis);
                    DB.SaveChanges();

                }

                islemozet io = new islemozet();
                flogin f = new flogin();
                io.islemNo = islemno;
                io.iade = satisiade;
                io.AlisFiyatToplam = alisfiyattoplam;
                io.Gelir = false;
                io.Gider = false;
                io.Kullanici = f.lkullaniciad.Text;
                if (!satisiade)
                {
                    io.Aciklama = odemesekli + " satış";
                }
                else
                {
                    io.Aciklama = " iade işlemi(" + odemesekli + ")";
                }
                io.odemeSekli = odemesekli;
                io.Kullanici = lkullanici.Text;
                io.Tarih = DateTime.Now;
                switch (odemesekli)
                {
                    case "Nakit":
                        io.Nakit = islemler.DoubleYap(tgenelToplam.Text);
                        io.Kart = 0;
                        break;
                    case "Kart":
                        io.Nakit = 0;
                        io.Kart = islemler.DoubleYap(tgenelToplam.Text);
                        break;
                    case "Kart-Nakit":
                        io.Nakit = islemler.DoubleYap(lNakit.Text);
                        io.Kart = islemler.DoubleYap(lKart.Text);
                        break;
                }
                DB.islemozet.Add(io);
                DB.SaveChanges();

                var islemnoartir = DB.islem.First();
                islemnoartir.islemNo += 1;
                DB.SaveChanges();
                if (chYazdırmaDurumu.Checked)
                {
                    Yazdir yazdir = new Yazdir(islemno);
                    yazdir.yazdirmayabasla();
                }
                Temizle();
            }
        }
        private void bKredikart_Click(object sender, EventArgs e)
        {
            SatisYap("Kart");
        }

        private void bKartnakit_Click(object sender, EventArgs e)
        {
            Nakit_Kart_odeme f = new Nakit_Kart_odeme();
            f.ShowDialog();
        }

        private void tBbarkod_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) == false && e.KeyChar != (char)08)
            {
                e.Handled = true;
            }
        }

        private void tNumarator_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) == false && e.KeyChar != (char)08)
            {
                e.Handled = true;
            }
        }

        private void BarkodSistemi_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F1)
                SatisYap("Nakit");
            if (e.KeyCode == Keys.F2)
                SatisYap("Kart");
            if (e.KeyCode == Keys.F3)
            {
                Nakit_Kart_odeme f = new Nakit_Kart_odeme();
                f.ShowDialog();
            }
        }

        private void bislembeklet_Click(object sender, EventArgs e)
        {
            if (bislembeklet.Text == "işlem Beklet")
            {
                Bekle();
                bislembeklet.BackColor = System.Drawing.Color.OrangeRed;
                bislembeklet.Text = "işlem Bekliyor";
                dataGridList.Rows.Clear();
            }
            else
            {
                BeklamadamCik();
                bislembeklet.BackColor = System.Drawing.Color.DimGray;
                bislembeklet.Text = "işlem Beklet";
                dataGridBekle.Rows.Clear();
            }

        }
        private void Bekle()
        {
            int satir = dataGridList.Rows.Count;
            int sutun = dataGridList.Columns.Count;
            if (satir > 0)
            {
                for (int i = 0; i < satir; i++)
                {
                    dataGridBekle.Rows.Add();
                    for (int j = 0; j < sutun - 1; j++)
                    {
                        dataGridBekle.Rows[i].Cells[j].Value = dataGridList.Rows[i].Cells[j].Value;
                    }
                }
            }
        }
        private void BeklamadamCik()
        {
            int satir = dataGridBekle.Rows.Count;
            int sutun = dataGridBekle.Columns.Count;
            if (satir > 0)
            {
                for (int i = 0; i < satir; i++)
                {
                    dataGridList.Rows.Add();
                    for (int j = 0; j < sutun - 1; j++)
                    {
                        dataGridList.Rows[i].Cells[j].Value = dataGridBekle.Rows[i].Cells[j].Value;
                    }
                }
            }
        }

        private void csatisiadeyapiliyor_CheckedChanged(object sender, EventArgs e)
        {
            if (csatisiadeyapiliyor.Checked)
            {
                csatisiadeyapiliyor.Text = "Iade Yapılıyor";

            }

            else
            {
                csatisiadeyapiliyor.Text = "Satış Yapılıyor";
            }
        }

        private void dataGridBekle_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridList_ColumnAdded(object sender, DataGridViewColumnEventArgs e)
        {
            tBbarkod.Clear();
        }

        private void dataGridList_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            tBbarkod.Clear();
        }

        private void dataGridList_RowDefaultCellStyleChanged(object sender, DataGridViewRowEventArgs e)
        {
            tBbarkod.Clear();

        }
    }


}