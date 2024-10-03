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
    public partial class BarkodSatısProgramı : Form
    {
        public BarkodSatısProgramı()
        {
            InitializeComponent();
        }
        
        private void bsatisislemi_Click(object sender, EventArgs e)
        {
                 Cursor.Current = Cursors.WaitCursor;
                 BarkodSistemi f = new BarkodSistemi();
                 f.lkullanici.Text = lkullanici.Text;
                 f.ShowDialog();
                 Cursor.Current = Cursors.Default;
        }

        private void bstoktakip_Click(object sender, EventArgs e)
        {
                Cursor.Current = Cursors.WaitCursor;
                fstok f = new fstok();
                f.lkullanici.Text = lkullanici.Text;
                f.ShowDialog();
                Cursor.Current = Cursors.Default;
            
        }

        private void burungiris_Click(object sender, EventArgs e)
        {
                Cursor.Current = Cursors.WaitCursor;
                FUrunGirisLsti f = new FUrunGirisLsti();
                f.lkullanici.Text = lkullanici.Text;
                f.ShowDialog();
                Cursor.Current = Cursors.Default;
            
        }

        private void bgenelrapor_Click(object sender, EventArgs e)
        {
                Cursor.Current = Cursors.WaitCursor;
                Raporlama f = new Raporlama();
                f.lkullanici.Text = lkullanici.Text;
                f.ShowDialog();
                Cursor.Current = Cursors.Default;
            
        }

        private void bcikis_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void bayarlar_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            Ayarlar f = new Ayarlar();
            //f.lkulani.Text = lkullanici.Text;
            f.ShowDialog();
            Cursor.Current = Cursors.Default;
            
        }

        private void byedekleme_Click(object sender, EventArgs e)
        {
            islemler.depolama();
        }

        private void bkullanicidegistir_Click(object sender, EventArgs e)
        {
            flogin login = new flogin();
            login.Show();
            this.Hide();
        }

        private void bfiyat_Click_1(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            Ffiyatguncelleme f = new Ffiyatguncelleme();
            //f.lkullanici.Text = lkullanici.Text;
            f.ShowDialog();
            Cursor.Current = Cursors.Default;
        }

        private void BarkodSatısProgramı_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void BarkodSatısProgramı_Load(object sender, EventArgs e)
        {

        }
    }
}
