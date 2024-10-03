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
    public partial class Fdetaygöster : Form
    {
       // internal int islemNo;

        public Fdetaygöster()
        {
            InitializeComponent();
        }
        public int islemno { get; set; }
        private void Fdetaygöster_Load(object sender, EventArgs e)
        {
            lislemno.Text = " Işlem No : " + islemno.ToString();
            using (var DB = new BarkodDBEntities())
            {
                GridList.DataSource = DB.Satis.Select(s => new { s.IslemNo, s.UrunAd, s.UrunGrup, s.Miktar, s.Toplam }).Where(x => x.IslemNo == islemno).ToList();
                islemler.GridDuzenle(GridList);
            }
        }
    }
}
