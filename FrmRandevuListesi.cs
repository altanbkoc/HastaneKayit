using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace HastaneProjesi
{
    public partial class FrmRandevuListesi : Form
    {
        public FrmRandevuListesi()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;


        }
        int sayac = 0;

        SqlBaglanti bgl=new SqlBaglanti();
        private void FrmRandevuListesi_Load(object sender, EventArgs e)
        {
            timer1.Start();
            dataRandevu.Visible = false;
            string query = "Select * from Randevular";

            DataTable dt = new DataTable();
            SqlDataAdapter da= new SqlDataAdapter(query,bgl.baglanti());
            da.Fill(dt);
            dataRandevu.DataSource = dt;

           
            dataRandevu.Columns["RandevuId"].HeaderText = "ID";
            dataRandevu.Columns["RandevuTarih"].HeaderText = "Tarih";
            dataRandevu.Columns["RandevuSaat"].HeaderText = "Saat";
            dataRandevu.Columns["RandevuBrans"].HeaderText = "Branş";
            dataRandevu.Columns["RandevuDoktor"].HeaderText = "Doktor";
            dataRandevu.Columns["RandevuDurum"].HeaderText = "Durum";
            dataRandevu.Columns["HastaTc"].HeaderText = "T.C";

            bgl.baglanti().Close();

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            sayac++;
            if (sayac == 2)
            {
                timer1.Stop();
                bunifuTransition1.ShowSync(dataRandevu);
                dataRandevu.Visible=true;
            }

        }

        private void kapat_Click(object sender, EventArgs e)
        {
            sayac = 0;
        }
    }
}
