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
    public partial class FRaporGoster : Form
    {
        public FRaporGoster()
        {
            InitializeComponent();
        }

        private void FRaporGoster_Load(object sender, EventArgs e)
        {

            this.reportViewer1.RefreshReport();
        }
    }
}
