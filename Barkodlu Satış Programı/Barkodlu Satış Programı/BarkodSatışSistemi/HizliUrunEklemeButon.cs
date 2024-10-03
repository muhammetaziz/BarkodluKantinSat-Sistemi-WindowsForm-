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
    public partial class HizliUrunEklemeButon : Form
    {
        public HizliUrunEklemeButon()
        {
            InitializeComponent();
        }
        BarkodDBEntities DB = new BarkodDBEntities();

        private void tUrunara_TextChanged(object sender, EventArgs e)
        {
            if (tUrunara.Text != "")
            {
                string urunad = tUrunara.Text;
                var urunler = DB.Urun.Where(a => a.UrunAdi.Contains(urunad)).ToList();
                dataGridUrunler.DataSource = urunler;
            }
        }

        private void dataGridUrunler_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridUrunler.Rows.Count > 0)
            {
                string barkod = dataGridUrunler.CurrentRow.Cells["Barkod"].Value.ToString();
                string urunad = dataGridUrunler.CurrentRow.Cells["UrunAdi"].Value.ToString();
                double fiyat = Convert.ToDouble(dataGridUrunler.CurrentRow.Cells["SatisFiyat"].Value.ToString());
                int id = Convert.ToInt16(lbutonid.Text);
                var guncellenecek = DB.HizliUrun.Find(id);
                guncellenecek.Barkod = barkod;
                guncellenecek.UrunAd = urunad;
                guncellenecek.Fiyat = fiyat;
                DB.SaveChanges();
                MessageBox.Show("Buton Tanımlanmıştır");
                BarkodSistemi f = (BarkodSistemi)Application.OpenForms["BarkodSistemi"];
                if (f != null)
                {
                    Button b = f.Controls.Find("BH" + id, true).FirstOrDefault() as Button;
                    b.Text = urunad + "\n" + fiyat.ToString("C2");
                }
            }
        }

        private void chtumugoster_CheckedChanged(object sender, EventArgs e)
        {
            if (chtumugoster.Checked)
            {
                dataGridUrunler.DataSource = DB.Urun.ToList();
                dataGridUrunler.Columns["AlisFiyat"].Visible = false;
                dataGridUrunler.Columns["SatisFiyat"].Visible = false;
                dataGridUrunler.Columns["KdvOrani"].Visible = false;
                dataGridUrunler.Columns["KdvTutari"].Visible = false;
                islemler.GridDuzenle(dataGridUrunler);

            }
            else
            {
                dataGridUrunler.DataSource = null;
            }
            
        }
    }
}
