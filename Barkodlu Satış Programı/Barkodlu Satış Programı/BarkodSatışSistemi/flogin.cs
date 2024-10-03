using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace BarkodSatışSistemi
{
    public partial class flogin : Form
    {
        public flogin()
        {
            InitializeComponent();
        }

        private void bgiris_Click(object sender, EventArgs e)
        {
            girisyap();
        }

        private void girisyap()
        {
            if (tkullaniciadi.Text != "" && tsifre.Text != "")
            {
                try
                {
                    using (var db = new BarkodDBEntities())
                    {
                        if (db.Kullanici.Any())
                        {
                            var bar = db.Kullanici.Where(x => x.KullaniciAd == tkullaniciadi.Text && x.Sifre == tsifre.Text).FirstOrDefault();
                            if (bar != null)
                            {
                                Cursor.Current = Cursors.WaitCursor;

                                BarkodSatısProgramı f = new BarkodSatısProgramı();
                                f.bsatisislemi.Enabled = (bool)bar.Satis;
                                f.bgenelrapor.Enabled = (bool)bar.Rapor;
                                f.bstoktakip.Enabled = (bool)bar.Stok;
                                f.burungiris.Enabled = (bool)bar.UrunGiris;
                                f.bayarlar.Enabled = (bool)bar.ayarlar;
                                f.bfiyat.Enabled = (bool)bar.Fiyatguncelleme;
                                f.byedekleme.Enabled = (bool)bar.Yedekleme;
                                f.lkullanici.Text = bar.KullaniciAd;
                                var isyeri = db.Sabit.FirstOrDefault();
                                f.lisyeri.Text = isyeri.Unvan;
                                f.Show();
                                this.Hide();

                                Cursor.Current = Cursors.Default;
                            }
                            else
                            {
                                MessageBox.Show("hatalı giriş ");
                            }
                        }
                        else
                        {
                            var bar = db.Kullanici.Where(x => x.KullaniciAd == tkullaniciadi.Text && x.Sifre == tsifre.Text).FirstOrDefault();


                            Cursor.Current = Cursors.WaitCursor;
                            Kullanici k = new Kullanici();
                            k.adSoyad = "admin";
                            k.ayarlar = true;
                            k.Eposta = "eposta";
                            k.Fiyatguncelleme = true;
                            k.KullaniciAd = "admin";
                            k.Rapor = true;
                            k.Satis = true;
                            k.Sifre = "admin";
                            k.Stok = true;
                            k.Telefon = "Telefon";
                            k.UrunGiris = true;
                            k.Yedekleme = true;
                            db.Kullanici.Add(k);
                            db.SaveChanges();
                            BarkodSatısProgramı f = new BarkodSatısProgramı();
                            f.bsatisislemi.Enabled = (bool)bar.Satis;
                            f.bgenelrapor.Enabled = (bool)bar.Rapor;
                            f.bstoktakip.Enabled = (bool)bar.Stok;
                            f.burungiris.Enabled = (bool)bar.UrunGiris;
                            f.bayarlar.Enabled = (bool)bar.ayarlar;
                            f.byedekleme.Enabled = (bool)bar.Yedekleme;
                            f.lkullanici.Text = bar.KullaniciAd;
                            var isyeri = db.Sabit.FirstOrDefault();
                            f.lisyeri.Text = isyeri.Unvan;
                            f.Show();
                            this.Hide();
                            Cursor.Current = Cursors.Default;
                        }
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
        }
        private void bgiris_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                girisyap();
            }

        }

        private void tkullaniciadi_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
