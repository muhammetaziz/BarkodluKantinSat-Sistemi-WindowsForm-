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
    public partial class FurunGrubekle : Form
    {
        BarkodDBEntities DB = new BarkodDBEntities();
        public FurunGrubekle()
        {
            InitializeComponent();
        }

        private void FurunGrubekle_Load(object sender, EventArgs e)
        {
            GrupDoldur();
        }

        private void bekle_Click(object sender, EventArgs e)
        {
            if (tUrunGroupAd.Text != "")
            {
                UrunGrup ug = new UrunGrup();
                ug.UrunGAd = tUrunGroupAd.Text;
                DB.UrunGrup.Add(ug);
                DB.SaveChanges();
                listUrunGrup.DataSource=null;
                GrupDoldur();
                tUrunGroupAd.Clear();
                MessageBox.Show("ürün grubu eklenmiştir");
                var mrfm = (FUrunGirisLsti)Application.OpenForms["FUrunGirisLsti"];
                if (mrfm != null)
                {
                    mrfm.Yenile();
                }
             
            }
            else
            {
                MessageBox.Show("grub bilgileri ekleyiniz");
            }
        }
        public  void GrupDoldur()
        {
            listUrunGrup.DisplayMember = "UrunGAd";
            listUrunGrup.DataSource =DB.UrunGrup.OrderBy(a => a.UrunGAd).ToList();
        }

        private void bsil_Click(object sender, EventArgs e)
        {
            

            int grupid = Convert.ToInt32(listUrunGrup.SelectedValue);
            string grupad = listUrunGrup.Text;
            DialogResult onay = MessageBox.Show(grupad +" grubunu silmek istiyor musunuz?", "silme işlemi", MessageBoxButtons.YesNo);
            if (onay == DialogResult.Yes)
            {
                var grup = DB.UrunGrup.FirstOrDefault(a => a.UrubId == grupid);
                DB.UrunGrup.Remove(grup);
                DB.SaveChanges();
                
                tUrunGroupAd.Focus();
                MessageBox.Show(grupad + " ürün grubu silindi");
                listUrunGrup.DataSource=null;
                GrupDoldur();
                tUrunGroupAd.Focus();
                
            }
            var mfrm = (FUrunGirisLsti)Application.OpenForms["FUrunGirisLsti"];
            if (mfrm != null)
            {
                mfrm.Yenile();
            }
        }

    }
}
