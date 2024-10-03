using System;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Windows.Forms;
namespace BarkodSatışSistemi
{
    public partial class Ayarlar : Form
    {
        public Ayarlar()
        {
            InitializeComponent();
        }
        BarkodDBEntities DB = new BarkodDBEntities();
        private void bkaydet_Click(object sender, EventArgs e)
        {
            if (bkaydet.Text == "Kaydet")
            {
                if (tadsoyad.Text != "" && ttelefon.Text != "" && tkullanici.Text != "" && tsifretekrar.Text != "" && tsifretekrar.Text != "")
                {
                    if (tsıfre.Text == tsifretekrar.Text)
                    {
                        try
                        {
                            using (var db = new BarkodDBEntities())
                            {
                               
                                if (!db.Kullanici.Any(x => x.KullaniciAd == tkullanici.Text))
                                {
                                    Kullanici k = new Kullanici();
                                    k.adSoyad = tadsoyad.Text;
                                    k.Telefon = ttelefon.Text;
                                    k.Eposta = teposta.Text;
                                    k.KullaniciAd = tkullanici.Text.Trim();
                                    k.Sifre = tsıfre.Text;
                                    k.Satis = chsatisekrani.Checked;
                                    k.Rapor = chraporekrani.Checked;
                                    k.Stok = chStok.Checked;
                                    k.UrunGiris = churungiris.Checked;
                                    k.ayarlar = cayarlar.Checked;
                                    k.Fiyatguncelleme = chfiyatguncelle.Checked;
                                    k.Yedekleme = chyedekleme.Checked;
                                    db.Kullanici.Add(k);
                                    db.SaveChanges();
                                    Doldur();
                                    temizle();
                                }
                                else
                                {
                                    MessageBox.Show("Bu Kullanıcı Zaten Kayıtlı");
                                }
                            }

                        }
                        catch (Exception)
                        {

                            MessageBox.Show("hata oluştu");
                        }
                    }
                    else
                    {
                        MessageBox.Show("şifreler uyuşmuyor");
                    }
                }
                else
                {
                    MessageBox.Show("Lütfen zorunlu  girişleri doldurunuz " + " \n Ad Sayad \n Telefon \n Kullanıcı \n Şifre \n Şifre Tekrarı");
                }
            }
            else if (bkaydet.Text == "Düzenle/Kaydet")
            {
                if (tadsoyad.Text != "" && ttelefon.Text != "" && tkullanici.Text != "" && tsifretekrar.Text != "" && tsifretekrar.Text != "")
                {
                    if (tsıfre.Text == tsifretekrar.Text)
                    {
                        
                        using (var db = new BarkodDBEntities())
                        {

                            int id = Convert.ToInt32(dataGridkullanici.CurrentRow.Cells["Id"].Value.ToString());
                            var guncelle = db.Kullanici.Where(x => x.Id == id).FirstOrDefault();
                            guncelle.adSoyad = tadsoyad.Text;
                            guncelle.Telefon = ttelefon.Text;
                            guncelle.Eposta = teposta.Text;
                            guncelle.KullaniciAd = tkullanici.Text.Trim();
                            guncelle.Sifre = tsıfre.Text;
                            guncelle.Satis = chsatisekrani.Checked;
                            guncelle.Rapor = chraporekrani.Checked;
                            guncelle.Stok = chStok.Checked;
                            guncelle.UrunGiris = churungiris.Checked;
                            guncelle.ayarlar = cayarlar.Checked;
                            guncelle.Fiyatguncelleme = chfiyatguncelle.Checked;
                            guncelle.Yedekleme = chyedekleme.Checked;
                            db.Kullanici.Add(guncelle);
                            db.SaveChanges();
                            MessageBox.Show("Güncelleme yapılıyor");
                            bkaydet.Text = "Kaydet";
                            temizle();
                             Doldur();
                        }
                    }
                    else
                    {
                        MessageBox.Show("şifre uyuşmuyor");
                    }
                }
                MessageBox.Show("Lütfen zorunlu  girişleri doldurunuz " + " \n Ad Sayad \n TElefon \n Kullanıcı \n Şifre  \n Şifre Tekrarı");

            }

        }

        private void btemizle_Click(object sender, EventArgs e)
        {
            tadsoyad.Clear();
            ttelefon.Clear();
            teposta.Clear();
            tkullanici.Clear();
            tsıfre.Clear();
            tsifretekrar.Clear();
            chsatisekrani.Checked = false;
            chraporekrani.Checked = false;
            chStok.Checked = false;
            churungiris.Checked = false;
            cayarlar.Checked = false;
            chfiyatguncelle.Checked = false;
            chyedekleme.Checked = false;
        }
        void temizle()
        {
            tadsoyad.Clear();
            ttelefon.Clear();
            teposta.Clear();
            tkullanici.Clear();
            tsıfre.Clear();
            chsatisekrani.Checked = false;
            chfiyatguncelle.Checked = false;
            chraporekrani.Checked = false;
            chStok.Checked = false;
            churungiris.Checked = false;
            cayarlar.Checked = false;
            chyedekleme.Checked = false;
            tsifretekrar.Clear();
        }

        private void düzenleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dataGridkullanici.Rows.Count > 0)
            {
                int id = Convert.ToInt32(dataGridkullanici.CurrentRow.Cells["Id"].Value.ToString());
                lkuyllaniciid.Text = id.ToString();
                using (var db = new BarkodDBEntities())
                {
                    var getir = db.Kullanici.Where(x => x.Id == id).FirstOrDefault();
                    tadsoyad.Text = getir.adSoyad;
                    ttelefon.Text = getir.Telefon;
                    teposta.Text = getir.Eposta;
                    tkullanici.Text = getir.KullaniciAd;
                    tsıfre.Text = getir.Sifre;
                    tsifretekrar.Text = getir.Sifre;
                    chsatisekrani.Checked = (bool)getir.Satis;
                    chraporekrani.Checked = (bool)getir.Rapor;
                    chStok.Checked = (bool)getir.Stok;
                    churungiris.Checked = (bool)getir.UrunGiris;
                    cayarlar.Checked = (bool)getir.ayarlar;
                    chfiyatguncelle.Checked = (bool)getir.Fiyatguncelleme;
                    chyedekleme.Checked = (bool)getir.Yedekleme;
                    bkaydet.Text = "Düzenle/Kaydet";
                    Doldur();

                }
            }

            else
            {
                MessageBox.Show("kullanıcı seçin");
            }
        }

        private void Ayarlar_Load(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            Doldur();
            Cursor.Current = Cursors.Default;
        }
        private void Doldur()
        {
            using (var db = new BarkodDBEntities())
            {
                if (db.Kullanici.Any())
                {
                    dataGridkullanici.DataSource = db.Kullanici.Select(x => new { x.Id, x.adSoyad, x.KullaniciAd, x.Telefon }).ToList();
                    
                }

                islemler.SabitVarsayilan();
                var yazici = db.Sabit.FirstOrDefault();
                chyazıdurumu.Checked =(bool)yazici.Yazici;

                var sabitler = db.Sabit.FirstOrDefault();
                tkomisyon.Text = sabitler.KartKomisyom.ToString();

                var terazionek = db.Terazi.ToList();
                cmterazionek.DisplayMember = "TeraziOnEk";
                cmterazionek.ValueMember = "";
                cmterazionek.DataSource = terazionek;


                tisyeriadsoyad.Text = sabitler.AdSoyad;
                tisyeriunvan.Text = sabitler.Unvan;
                tisyeriadres.Text = sabitler.Adres;
                tisyertelefon.Text = sabitler.Telefon;
                tisyereposta.Text = sabitler.Eposta;
            }
        }


        private void chyazıdurumu_CheckedChanged(object sender, EventArgs e)
        {
                using (var db = new BarkodDBEntities())
                {
                    if (chyazıdurumu.Checked)
                    {
                        islemler.SabitVarsayilan();
                        var ayarla = db.Sabit.FirstOrDefault();
                        ayarla.Yazici = false;
                        db.SaveChanges();
                        chyazıdurumu.Text = "Yazma Durumu pasif";
                    }
                    
                    else
                    {
                        islemler.SabitVarsayilan();
                        var ayarla = db.Sabit.FirstOrDefault();
                        ayarla.Yazici = true;
                        db.SaveChanges();
                        chyazıdurumu.Text = "Yazma Durumu Aktif";
                    }

                }

        }
        private void bgelirekle_Click(object sender, EventArgs e)
        {
            if(tkomisyon.Text != "")
            {
                using(var db=new BarkodDBEntities())
                {
                    var sabit = db.Sabit.FirstOrDefault();
                    sabit.KartKomisyom = Convert.ToInt16(tkomisyon.Text);
                    db.SaveChanges();
                    MessageBox.Show("Kart komisyonu ayarlandı");
                }
            }
            else
            {
                MessageBox.Show("kart komisyon bilgisini giriniz");
            }
        }

        private void bterazionek_Click(object sender, EventArgs e)
        {
            if(tteraziOnEk.Text!=""){
                int onek = Convert.ToInt16(tteraziOnEk.Text);
                using(var db=new BarkodDBEntities())
                {
                    if(db.Terazi.Any(x => x.TeraziOnEk == onek))
                    {
                        MessageBox.Show(onek.ToString() + " zaten kayıtlı");
                    }
                    else
                    {
                        Terazi t = new Terazi();
                        t.TeraziOnEk = onek;
                        db.Terazi.Add(t);
                        db.SaveChanges();
                        MessageBox.Show("Bilgiler kaydedilmiştir");
                        cmterazionek.DisplayMember = "teraziOnEk";
                        cmterazionek.ValueMember = "Id";
                        cmterazionek.DataSource = db.Terazi.ToList();
                        tteraziOnEk.Clear();
                    }
                }
            }
            else
            {
                MessageBox.Show("Terazi ön ek bilgisini giriniz");
            }
        }

        private void boneksil_Click(object sender, EventArgs e)
        {
            if (cmterazionek.Text != "")
            {
                int onekid = Convert.ToInt16(cmterazionek.SelectedValue);
                DialogResult onay = MessageBox.Show(cmterazionek.Text + " ön ek silmek istiyor musunuz? ", " Terazi ön ek silme işlemi ", MessageBoxButtons.YesNo);
                if(onay == DialogResult.Yes)
                {
                    using (var db=new BarkodDBEntities())
                    {
                        var onek = db.Terazi.Find(onekid);
                        db.Terazi.Remove(onek);
                        db.SaveChanges();
                        cmterazionek.DisplayMember = "teraziOnEk";
                        cmterazionek.ValueMember = "Id";
                        cmterazionek.DataSource = db.Terazi.ToList();
                        MessageBox.Show("ön ek silinmiştir");
                    }
                }
            }
            else
            {
                MessageBox.Show("ön ek seçiniz");
            }
        }

        private void bisyeriKaydet_Click(object sender, EventArgs e)
        {
            if(tisyeriadsoyad.Text!= "" && tisyeriunvan.Text!= "" && tisyeriadres.Text !=""  &&  tisyertelefon.Text!= "")
            {
                using(var db = new BarkodDBEntities())
                {
                    var isyeri = db.Sabit.FirstOrDefault();
                    isyeri.AdSoyad = tisyeriadsoyad.Text;
                    isyeri.Unvan = tisyeriunvan.Text;
                    isyeri.Adres = tisyeriadres.Text;
                    isyeri.Telefon = tisyertelefon.Text;
                    isyeri.Eposta = tisyereposta.Text;
                    db.SaveChanges();
                    MessageBox.Show("işyeri bilgileri kaydedilmiştir");
                    var yeni = db.Sabit.FirstOrDefault();
                    tisyeriadsoyad.Text = yeni.AdSoyad;
                    tisyeriunvan.Text = yeni.Unvan;
                    tisyeriadres.Text = yeni.Adres;
                    tisyertelefon.Text = yeni.Telefon;
                    tisyereposta.Text = yeni.Eposta;
                }
            }
        }

        private void byedekten_Click(object sender, EventArgs e)
        {
            Process.Start(Application.StartupPath + @"\yedektenalma.exe");
            Application.Exit();
        }

        private void silToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dataGridkullanici.Rows.Count > 0)
            {
                int urunid = Convert.ToInt32(dataGridkullanici.CurrentRow.Cells["Id"].Value.ToString());
                string adsoyad = dataGridkullanici.CurrentRow.Cells["adSoyad"].Value.ToString();
                string telefonNo = dataGridkullanici.CurrentRow.Cells["Telefon"].Value.ToString();
                string kullaniciAd = dataGridkullanici.CurrentRow.Cells["KullaniciAd"].Value.ToString();
                DialogResult onay = MessageBox.Show(adsoyad + " ürününü silmek istiyor musunuz? ", "Ürün silme işlemi", MessageBoxButtons.YesNo);
                if (onay == DialogResult.Yes)
                {
                    var kullanici = DB.Kullanici.Find(urunid);
                    DB.Kullanici.Remove(kullanici);
                    DB.SaveChanges();
                    MessageBox.Show("kullanıcı silinmiştir");
                    dataGridkullanici.DataSource = DB.Kullanici.OrderByDescending(a => a.adSoyad).Take(10).ToList();
                    Doldur();
                    tadsoyad.Focus();
                }
            }
        }

        
    }
}
