using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace yedektenalma
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void byedeksec_Click(object sender, EventArgs e)
        {
            OpenFileDialog f = new OpenFileDialog();
            f.Filter= "veri dosyasını seçiniz |*.bak";
            f.ShowDialog();
            textBox1.Text = f.FileName;
        }

        private void byukla_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                try
                {
                    string strSql = @"data source=(LocalDB)\MSSQLLocalDB;attachdbfilename=|DataDirectory|\BarkodDB.mdf;integrated security=True;connect timeout=30;MultipleActiveResultSets=True;App=EntityFramework";
                    Cursor.Current = Cursors.WaitCursor;
                    string yedekyolu = textBox1.Text;
                    Application.DoEvents();
                    string str = Application.StartupPath + @"\BarkodDB.mdf";
                    using(SqlConnection connection=new SqlConnection(strSql))
                    {
                        connection.Open();
                        SqlCommand isle = new SqlCommand(@"USE Master;If Exists(Select * From sys.databases where name='BarkodDB')Drop Database["+str+"];RESTORE DATABASE["+str+"] FROM DISK=N'" + textBox1.Text+"'",connection);
                        isle.ExecuteNonQuery();
                        connection.Close();
                    }
                    MessageBox.Show("veriler yüklanmiştir");
                    Process.Start(Application.StartupPath + @"\BarkodSatışSistemi.exe");
                    Cursor.Current = Cursors.Default;
                    Application.Exit();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
        }
    }
}
