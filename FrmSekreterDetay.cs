using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace HastaneProjesi
{
    public partial class FrmSekreterDetay : Form
    {
        public FrmSekreterDetay()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;


        }

        SqlBaglanti bgl=new SqlBaglanti();

        public string tc, adSoyad;
        private void FrmSekreterDetay_Load_1(object sender, EventArgs e)
        {
           
            this.Size = new Size(730, 539);
            myPanel.Visible = false;
            lbAdSoyad.Text = adSoyad;
            lbTc.Text = tc;

            //Brans cmb doldurma

            string query = "Select BransAd From Brans";
            SqlCommand komut = new SqlCommand(query, bgl.baglanti());
            SqlDataReader reader = komut.ExecuteReader();
            while (reader.Read())
            {
                cmbBrans.Items.Add(reader[0]);
            }
            bgl.baglanti().Close();

        }
        




        private void textBox6_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true; // Eğer sayı değilse, karakteri kabul etme
            }
        }

        int sayac = 0;
        

        private void guna2GradientCircleButton1_Click(object sender, EventArgs e)
        {
            if(sayac%2==0)
            {
                this.Size = new Size(1300, 539);
                guna2GradientCircleButton1.Text = "Verileri Gizle";
                guna2GradientCircleButton1.FillColor2 = Color.MidnightBlue;
                guna2GradientCircleButton1.FillColor = Color.DarkCyan;
                guna2Transition1.ShowSync(myPanel);

                //Branş Data doldurma.
                DataTable dt = new DataTable();
                string query = "Select * from Brans";
                SqlDataAdapter da=new SqlDataAdapter(query,bgl.baglanti());
                da.Fill(dt);
                dataBrans.DataSource = dt;

                dataBrans.Columns["BransId"].HeaderText = "ID";
                dataBrans.Columns["BransAd"].HeaderText = "Branş";



                //Doktor Data Doldurma

                DataTable dt2 = new DataTable();
                string query2 = "Select DoktorId,DoktorAd,DoktorSoyad,DoktorTc,DoktorBrans from Doktor";
                SqlDataAdapter da2=new SqlDataAdapter( query2,bgl.baglanti());
                da2.Fill(dt2);
                dataDoktor.DataSource = dt2;
                dataDoktor.Columns["DoktorId"].HeaderText = "ID";
                dataDoktor.Columns["DoktorAd"].HeaderText = "Ad";
                dataDoktor.Columns["DoktorSoyad"].HeaderText = "Soyad";
                dataDoktor.Columns["DoktorTc"].HeaderText = "T.C.";
                dataDoktor.Columns["DoktorBrans"].HeaderText = "Branş";

                bgl.baglanti().Close();

            }
            else
            {
                this.Size = new Size(730, 539);
                guna2GradientCircleButton1.Text = "Verileri Göster";
                guna2GradientCircleButton1.FillColor = Color.MidnightBlue;
                guna2GradientCircleButton1.FillColor2 = Color.DarkCyan;
                guna2Transition1.HideSync(myPanel);

            }
            sayac++;

        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrWhiteSpace(txtTarih.Text) ||
                string.IsNullOrWhiteSpace(txtSaat.Text) ||
                string.IsNullOrWhiteSpace(cmbBrans.Text))
            {
                MessageBox.Show("Lütfen tüm alanları doldurun.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            
            string query = "Insert into Randevular" +
                " (RandevuTarih,RandevuSaat,RandevuBrans,RandevuDoktor)" +
                " values(@p1,@p2,@p3,@p4)";

            SqlCommand komutKaydet = new SqlCommand(query,bgl.baglanti());

            komutKaydet.Parameters.AddWithValue("@p1", txtTarih.Text);
            komutKaydet.Parameters.AddWithValue("@p2", txtSaat.Text);
            komutKaydet.Parameters.AddWithValue("@p3", cmbBrans.Text);
            komutKaydet.Parameters.AddWithValue("@p4", cmbDoktor.Text);

            komutKaydet.ExecuteNonQuery();

            MessageBox.Show("Randevu başarıyla oluşturuldu.","Randevu",MessageBoxButtons.OK,MessageBoxIcon.Information);

            bgl.baglanti().Close();

            txtTarih.Text = "";
            txtSaat.Text = "";
            cmbBrans.Text = "";
            cmbDoktor.Text = "";
        }

        private void cbDurum_Click(object sender, EventArgs e)
        {
            if (cbDurum.Checked)
                lbDurum.Text = "1";
            else
                lbDurum.Text = "0";
        }



        private void cmbBrans_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            cmbDoktor.Items.Clear();
            cmbDoktor.Text = "";
            //Doktor cmb dolruma
            string query2 = "Select DoktorAd,DoktorSoyad From Doktor where DoktorBrans=@p1";

            SqlCommand komut2 = new SqlCommand(query2, bgl.baglanti());
            komut2.Parameters.AddWithValue("@p1", cmbBrans.Text);
            SqlDataReader reader2 = komut2.ExecuteReader();
            while (reader2.Read())
            {
                string doktorAd = reader2[0] + " " + reader2[1];
                cmbDoktor.Items.Add(doktorAd);
            }
            bgl.baglanti().Close();
        }

        private void btnDoktorPaneli_Click(object sender, EventArgs e)
        {
            FrmDoktorPaneli frm=new FrmDoktorPaneli();
            frm.Show();

        }

        private void btnBransPaneli_Click(object sender, EventArgs e)
        {
            BransPaneli b = new BransPaneli();
            b.Show();
        }

        private void btnRandevuListe_Click(object sender, EventArgs e)
        {
            FrmRandevuListesi frm=new FrmRandevuListesi();
            frm.Show();
        }

        private void kapat_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmGirisler frm= new FrmGirisler();
            frm.Show();
        }
    }
}
