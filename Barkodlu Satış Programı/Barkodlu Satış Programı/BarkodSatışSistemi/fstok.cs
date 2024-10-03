using DevExpress.XtraReports.UI;
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
    public partial class fstok : Form
    {
        public fstok()
        {
            InitializeComponent();
        }
        BarkodDBEntities dbx = new BarkodDBEntities();
        private void fstok_Load(object sender, EventArgs e)
        {
            GrupDoldur();
        }

        public void GrupDoldur()
        {
            cmurungrubu.DisplayMember = "UrunGAd";
            cmurungrubu.ValueMember = "UrunId";
            cmurungrubu.DataSource = dbx.UrunGrup.ToList();
        }
        private void bAra_Click(object sender, EventArgs e)
        {
            GridList.DataSource = null;
            using (var DB = new BarkodDBEntities())
            {
                if (cmislemtur.Text != "")
                {
                    string urungrubu = cmurungrubu.Text;
                    if (cmislemtur.SelectedIndex == 0)
                    {
                        if (RTumu.Checked)
                        {
                            DB.Urun.OrderBy(x => x.Miktar).Load();
                            GridList.DataSource = DB.Urun.Local.ToBindingList();
                        }
                        else if (Rurungurbagore.Checked)
                        {
                            DB.Urun.Where(x => x.UrunGroup == urungrubu).OrderBy(x => x.Miktar).Load();
                            GridList.DataSource = DB.Urun.Local.ToList();
                            
                        }
                        else
                        {
                            MessageBox.Show("Lütfen Filtrelem türünü seçiniz");
                        }
                        islemler.GridDuzenle(GridList);
                    }
                    else if (cmislemtur.SelectedIndex == 1)
                    {
                        DateTime baslangic = DateTime.Parse(dateBaslangic.Value.ToShortDateString());
                        DateTime bitis = DateTime.Parse(dateBitis.Value.ToShortDateString());
                        bitis = bitis.AddDays(1);
                        if (RTumu.Checked)
                        {
                            DB.StokHareket.OrderByDescending(x => x.Tarih).Where(x => x.Tarih >= baslangic && x.Tarih <= bitis).Load();
                            GridList.DataSource = DB.StokHareket.Local.ToList();
                        }
                        else if (Rurungurbagore.Checked)
                        {
                            DB.StokHareket.OrderByDescending(x => x.Tarih).Where(x => x.Tarih >= baslangic && x.Tarih <= bitis && x.UrunGrup.Contains(urungrubu)).Load();
                            GridList.DataSource = DB.StokHareket.Local.ToBindingList();
                        }
                        else
                        {
                            MessageBox.Show("Lütfen Filtrelem türünü seçiniz");
                        }
                        islemler.GridDuzenle(GridList);
                    }
                }
                else
                {
                    MessageBox.Show("Lütfen işlemturunu  Seçiniz");
                }
            }
            islemler.GridDuzenle(GridList);
        }

        private void turunara_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (turunara.Text.Length >= 2)
            {
                string urunad = turunara.Text;
                using (var DB = new BarkodDBEntities())
                {
                    if (cmislemtur.SelectedIndex == 0)
                    {
                        DB.Urun.Where(x => x.UrunAdi.Contains(urunad)).Load();
                        GridList.DataSource = DB.Urun.Local.ToBindingList();
                    }
                    else if (cmislemtur.SelectedIndex == 1)
                    {
                        DB.StokHareket.Where(x => x.UrunAd.Contains(urunad)).Load();
                        GridList.DataSource = DB.StokHareket.Local.ToBindingList();
                    }
                }
                islemler.GridDuzenle(GridList);
            }
        }
        private void braporal_Click(object sender, EventArgs e)
        {
            if (cmislemtur.SelectedIndex == 0)
            {
                //raporlar.Baslik = cmislemtur.Text + " Raporu";
                //raporlar.Baslangictarih = dateBaslangic.Value.ToShortDateString();
                //raporlar.Bitistarih = dateBitis.Value.ToShortDateString();
                //raporlar.StokRaporu(GridList);
                StokDurumRPR rpr = new StokDurumRPR();
                ReportPrintTool print1 = new ReportPrintTool(rpr);
                print1.ShowPreviewDialog();
            }
            else if (cmislemtur.SelectedIndex == 1)
            {
                raporlar.Baslik = cmislemtur.Text + " Raporu";
                raporlar.Baslangictarih = dateBaslangic.Value.ToShortDateString();
                raporlar.Bitistarih = dateBitis.Value.ToShortDateString();
                raporlar.StokizlemeRaporu(GridList);
            }
        }

    }
}

       