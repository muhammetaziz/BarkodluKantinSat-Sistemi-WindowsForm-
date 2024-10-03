using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BarkodSatışSistemi
{
    public partial class Raporlama : Form
    {
        public Raporlama()
        {
            InitializeComponent();
        }

        public void bgöster_Click(object sender, EventArgs e)
        {
            goster();
        }

        public void goster()
        {
            Cursor.Current = Cursors.WaitCursor;
            DateTime baslangic = DateTime.Parse(dateBaslangic.Value.ToShortDateString());
            DateTime bitis = DateTime.Parse(dateBitis.Value.ToShortDateString());
            bitis = bitis.AddDays(1);
            using (var DB = new BarkodDBEntities())
            {
                //tümü
                islemler.GridDuzenle(dataGridView1);
                if (listBox.SelectedIndex == 0)
                {
                    DB.islemozet.Where(x => x.Tarih >= baslangic && x.Tarih <= bitis).OrderByDescending(x => x.Tarih).Load();
                    var islemozet = DB.islemozet.Local.ToBindingList();
                    var islem = DB.islemozet;
                    dataGridView1.DataSource = DB.islemozet.Select(x => new { x.Id, x.islemNo, x.Kullanici, x.odemeSekli, x.Nakit, x.Kart, x.iade, x.Gelir, x.Gider, x.AlisFiyatToplam,x.Aciklama, x.Tarih }).ToList();

                    tNakit1.Text = Convert.ToDouble(islemozet.Where(x => x.iade == false && x.Gider == false && x.Gelir == false).Sum(x => x.Nakit)).ToString("C2");
                    tKart1.Text = Convert.ToDouble(islemozet.Where(x => x.iade == false && x.Gider == false && x.Gelir == false).Sum(x => x.Kart)).ToString("C2");

                    tNakit2.Text = Convert.ToDouble(islemozet.Where(x => x.iade == true).Sum(x => x.Nakit)).ToString("C2");
                    tKart2.Text = Convert.ToDouble(islemozet.Where(x => x.iade == true).Sum(x => x.Kart)).ToString("C2");

                    tNakit3.Text = Convert.ToDouble(islemozet.Where(x => x.Gelir == true).Sum(x => x.Nakit)).ToString("C2");
                    tKart3.Text = Convert.ToDouble(islemozet.Where(x => x.Gelir == true).Sum(s => s.Kart)).ToString("C2");

                    tNakit4.Text = Convert.ToDouble(islemozet.Where(x => x.Gider == true).Sum(x => x.Nakit)).ToString("C2");
                    tKart4.Text = Convert.ToDouble(islemozet.Where(x => x.Gider == true).Sum(s => s.Kart)).ToString("C2");

                    DB.Satis.Where(x => x.Tarih >= baslangic && x.Tarih <= bitis).Load();
                    var satistablosu = DB.Satis.Local.ToBindingList();
                    double Kdvtutarisatis = islemler.DoubleYap(satistablosu.Where(x => x.Iade == false).Sum(x => x.KdvTutari).ToString());
                    double Kdvtutariiade = islemler.DoubleYap(satistablosu.Where(x => x.Iade == true).Sum(x => x.KdvTutari).ToString());
                    tkdvtoplsm.Text = (Kdvtutarisatis - Kdvtutariiade).ToString("C2");
                }
                //satışlar
                else if (listBox.SelectedIndex == 1)
                {
                    DB.islemozet.Where(x => x.Tarih >= baslangic && x.Tarih <= bitis && x.iade == false && x.Gelir == false && x.Gider == false).Load();
                    dataGridView1.DataSource = DB.islemozet.Local.ToBindingList();
                }
                //iade
                else if (listBox.SelectedIndex == 2)
                {
                    DB.islemozet.Where(x => x.Tarih >= baslangic && x.Tarih <= bitis && x.iade == true).Load();
                    dataGridView1.DataSource = DB.islemozet.Local.ToBindingList();
                }
                //gelir
                else if (listBox.SelectedIndex == 3)
                {
                    DB.islemozet.Where(x => x.Tarih >= baslangic && x.Tarih <= bitis && x.Gelir == true).Load();
                    dataGridView1.DataSource = DB.islemozet.Local.ToBindingList();

                 }
                //gider
                else if (listBox.SelectedIndex == 4)
                {
                    DB.islemozet.Where(x => x.Tarih >= baslangic && x.Tarih <= bitis && x.Gider == true).Load();
                    dataGridView1.DataSource = DB.islemozet.Local.ToBindingList();
                }
            }

            Cursor.Current = Cursors.Default;
        }

        private void Raporlama_Load(object sender, EventArgs e)
        {
            listBox.SelectedIndex = 0;
            tkartkomisyon.Text = islemler.Kartkomisyon().ToString();
            bgöster_Click(null, null);
            
        }

        private void dataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {

            if (e.ColumnIndex == 2 || e.ColumnIndex == 6 || e.ColumnIndex == 7)
            {
                if (e.Value is bool)
                {
                    bool value = (bool)e.Value;
                    e.Value = (value) ? "True" : "false";
                    e.FormattingApplied = true;
                }
            }
        }

        private void bgelirekle_Click(object sender, EventArgs e)
        {
            gelir_gider f = new gelir_gider();
            f.gelirgider = "Gelir";
            f.kullanici = lkullanici.Text;
            f.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            gelir_gider f = new gelir_gider();
            f.gelirgider = "Gider";
            f.kullanici = lkullanici.Text;
            f.ShowDialog();
        }

        private void detayToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count > 0)
            {
                int islemno = Convert.ToInt32(dataGridView1.CurrentRow.Cells["islemNo"].Value.ToString());
                if (islemno != 0)
                {
                    Fdetaygöster f = new Fdetaygöster();
                    f.islemno = islemno;
                    f.ShowDialog();
                }
            }

        }

        private void braporal_Click(object sender, EventArgs e)
        {
            raporlar.Baslik = "Genel Rapor";
            raporlar.SatisNakit = tNakit1.Text;
            raporlar.SatisKart = tKart1.Text;
            raporlar.iadeNakit = tNakit2.Text;
            raporlar.iadeKart = tKart2.Text;
            raporlar.GelirNakit = tNakit3.Text;
            raporlar.GelirKart = tKart3.Text;
            raporlar.Baslangictarih = dateBaslangic.Text;
            raporlar.Bitistarih = dateBitis.Text;
            raporlar.GiderNakit = tNakit4.Text;
            raporlar.GiderKart = tKart4.Text;
            raporlar.KartKomisyon = tkartkomisyon.Text;
            raporlar.KdvToplam = tkdvtoplsm.Text;
            raporlar.RaporSayfasiRaporu(dataGridView1);
        }

        private void silToolStripMenuItem_Click(object sender, EventArgs e)
        {

            if (dataGridView1.Rows.Count > 0)
            {
                BarkodDBEntities DB = new BarkodDBEntities();
                
                int urunid = Convert.ToInt32(dataGridView1.CurrentRow.Cells["Id"].Value.ToString());
                string aciklama = dataGridView1.CurrentRow.Cells["Aciklama"].Value.ToString();
                DialogResult onay = MessageBox.Show(aciklama + "ürünü silmek istiyor musunuz?", "Ürün silme işlemi", MessageBoxButtons.YesNo);

                if (onay == DialogResult.Yes)
                {
                    var ozet = DB.islemozet.Find(urunid);
                    DB.islemozet.Remove(ozet);
                    DB.SaveChanges();
                    MessageBox.Show("Ürün silinmiştir");
                    goster();


                }
            }
        }
    }
}
