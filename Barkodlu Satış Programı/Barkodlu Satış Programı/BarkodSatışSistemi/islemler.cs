using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BarkodSatışSistemi
{
    static class islemler
    {
        public static double DoubleYap(string deger)
        {
            double sonuc;
            double.TryParse(deger, NumberStyles.Currency, CultureInfo.CurrentUICulture.NumberFormat, out sonuc);
            return Math.Round(sonuc,2);
        }
        public static void StokAzalt(string barkod,double miktar)
        {
            using (var DB=new BarkodDBEntities())
            {
                var urunbilgi = DB.Urun.SingleOrDefault(x => x.Barkod == barkod);
                urunbilgi.Miktar -= miktar;
                DB.SaveChanges();
            }
        }
        public static void StokArtir(string barkod, double miktar)
        {
            using (var DB = new BarkodDBEntities())
            {
                var urunbilgi = DB.Urun.SingleOrDefault(x => x.Barkod == barkod);
                urunbilgi.Miktar += miktar;
                DB.SaveChanges();
            }
        }

        internal static void GridDuzenle(DataGridView dgv)
        {
            if (dgv.Columns.Count > 0)
            {
                for (int i = 0; i < dgv.Columns.Count; i++)
                {
                    switch (dgv.Columns[i].HeaderText)
                    {
                        case "UrunAd":
                            dgv.Columns[i].HeaderText = "Ürün Ad";
                            break;
                        case "Aciklama":
                            dgv.Columns[i].HeaderText = "Açıklama";
                            break;
                        case "UrunGrup":
                            dgv.Columns[i].HeaderText = "Ürün Grubu";
                            break;
                        case "AlisFiyat":
                            dgv.Columns[i].HeaderText = "Alış Fiyat";
                            dgv.Columns[i].DefaultCellStyle.Format = "C2";
                            break;
                        case "SatisFiyat":
                            dgv.Columns[i].HeaderText = "Satış Fiyat";
                            dgv.Columns[i].DefaultCellStyle.Format = "C2";
                            break;
                        case "KdvOrani":
                            dgv.Columns[i].HeaderText = "Kdv oranı";
                            break;
                        case "Birim":
                            break;
                        case "Miktar":
                            break;
                        case "Kart":
                            dgv.Columns[i].HeaderText = "Kart"; break;
                        case "Nakit":
                            dgv.Columns[i].HeaderText = "Nakit"; break;
                        case "Gelir":
                            dgv.Columns[i].HeaderText = "Gelir"; break;
                        case "Gider":
                            dgv.Columns[i].HeaderText = "Gider"; break;
                    }
                }
            }
        }

        public static void StokHareket(string barkod,string urunad,string birim, double miktar, string urungrup , string kullanici)
        {
            using(var DB=new BarkodDBEntities())
            {
                StokHareket sh = new StokHareket();
                sh.Barkod = barkod;
                sh.UrunAd = urunad;
                sh.Birim = birim;
                sh.Miktar = miktar;
                sh.UrunGrup = urungrup;
                sh.Kullanici = kullanici;
                sh.Tarih = DateTime.Now;
                DB.StokHareket.Add(sh);
                DB.SaveChanges();
            }
        }

        
        public static int Kartkomisyon()
        {
            int sonuc = 0;
            using (var DB = new BarkodDBEntities())
            {
                if (DB.Sabit.Any())
                {
                    sonuc = Convert.ToInt16(DB.Sabit.First().KartKomisyom);
                }
                else
                {
                    sonuc = 0;
                }
            }
            return sonuc;
        }

       
        public static void SabitVarsayilan()
        {
            using (var db = new BarkodDBEntities())
            {
                if(!db.Sabit.Any())
                {
                    Sabit s = new Sabit();
                    s.KartKomisyom = 0;
                    s.AdSoyad = "admin";
                    s.Adres = "admin";
                    s.Unvan= "admin";
                    s.Telefon = "admin";
                    s.Eposta = "admin";
                    db.Sabit.Add(s);
                    db.SaveChanges();
                }
                
            }
        }



       public static void depolama()
        {
            SaveFileDialog save = new SaveFileDialog();
            save.Filter = "veri yedek dosyası | 0.bak";
            save.FileName = "barkodlu_Satis_Programi_" + DateTime.Now.ToShortDateString();
            if (save.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    Cursor.Current = Cursors.WaitCursor;
                    if (File.Exists(save.FileName))
                    {
                        File.Delete(save.FileName);

                    }
                    var dbhedef = save.FileName;
                    string dbkaynak = Application.StartupPath + @"\BarkodDB.mdf";
                    using (var db = new BarkodDBEntities())
                    {
                        var cmd = @"BACKUP DATABASE[" + dbkaynak + "] TO DISK= '" + dbhedef + "'";
                        db.Database.ExecuteSqlCommand(TransactionalBehavior.DoNotEnsureTransaction, cmd);
                    }
                    Cursor.Current = Cursors.Default;
                    MessageBox.Show("yedekleme tamamlanmıştır");

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
        }
            

    }

}
