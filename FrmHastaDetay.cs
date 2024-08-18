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
    public partial class FrmHastaDetay : Form
    {
        public FrmHastaDetay()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;

        }

        SqlBaglanti bgl=new SqlBaglanti();
        public string tc;
        private void FrmHastaDetay_Load(object sender, EventArgs e)
        {

            //Ad Soyad Gösterimi
            guna2Panel1.Visible = false;
            lbTc.Text = tc;

            string query = "Select HastaAd,HastaSoyad,HastaCinsiyet From Hasta where HastaTc=@p1";

            SqlCommand komut = new SqlCommand(query,bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", lbTc.Text);

            SqlDataReader reader = komut.ExecuteReader();

            while (reader.Read())
            {
                lbAdSoyad.Text = reader[0] + " " + reader[1];
                lbCinsiyet.Text = reader[2].ToString();
                
            }

             bgl.baglanti().Close();

            //Randevu Geçmişi
            DataTable dt = new DataTable();
            string query2 = "Select RandevuId,RandevuTarih,RandevuSaat,RandevuBrans,RandevuDoktor,RandevuDurum" +
                " from Randevular Where HastaTC="+lbTc.Text;
            
            SqlDataAdapter da = new SqlDataAdapter(query2, bgl.baglanti());
            da.Fill(dt);
            dataRandevuGecmisi.DataSource = dt;

            dataRandevuGecmisi.Columns["RandevuId"].HeaderText = "ID";
            dataRandevuGecmisi.Columns["RandevuTarih"].HeaderText = "Tarih";
            dataRandevuGecmisi.Columns["RandevuSaat"].HeaderText = "Saat";
            dataRandevuGecmisi.Columns["RandevuBrans"].HeaderText = "Brans";
            dataRandevuGecmisi.Columns["RandevuDoktor"].HeaderText = "Doktor";
            dataRandevuGecmisi.Columns["RandevuDurum"].HeaderText = "Durum";


            //Branş Çekme
            string query3 = "Select BransAd from Brans";
            SqlCommand komut2=new SqlCommand(query3,bgl.baglanti());
            SqlDataReader reader2 = komut2.ExecuteReader();
            while (reader2.Read())
            {
                cmbBrans.Items.Add(reader2[0]);
            }
            bgl.baglanti().Close();

        }

        private void btnHastaGuncelle_Click(object sender, EventArgs e)
        {
           
            //Bilgileri güncelleme
            if(string.IsNullOrWhiteSpace(txtHastaGuncelAd.Text) ||
                string.IsNullOrWhiteSpace(txtHastaGuncelSoyad.Text) ||
                string.IsNullOrWhiteSpace(txtHastaGuncelTc.Text) ||
                string.IsNullOrWhiteSpace(txtHastaGuncelSifre.Text))
            {
                MessageBox.Show("Lütfen boş alan bırakmayın.");
                return;
            }
            if (txtHastaGuncelTc.Text.Length !=11)
            {
                MessageBox.Show("Lütfen geçerli bir kimlik numarası giriniz.");
                return;
            }


            string query = "UPDATE Hasta SET " +
                       "HastaAd = @p1, " +
                       "HastaSoyad = @p2, " +
                       "HastaTc = @p3, " +
                       "HastaSifre = @p4 " +
                       "WHERE HastaTc = @p5";

            SqlCommand komut = new SqlCommand( query,bgl.baglanti());

            komut.Parameters.AddWithValue("@p1", txtHastaGuncelAd.Text);
            komut.Parameters.AddWithValue("@p2", txtHastaGuncelSoyad.Text);
            komut.Parameters.AddWithValue("@p3", txtHastaGuncelTc.Text);
            komut.Parameters.AddWithValue("@p4", txtHastaGuncelSifre.Text);
            komut.Parameters.AddWithValue("@p5", lbTc.Text);
            komut.ExecuteNonQuery();


            MessageBox.Show("Bilgiler başarıyla güncellendi.");

            bgl.baglanti().Close();

            guna2Transition1.HideSync(guna2Panel1);
            guna2Panel1.Visible = false;

            lbAdSoyad.Text = txtHastaGuncelAd.Text + " " + txtHastaGuncelSoyad.Text;
            lbTc.Text = txtHastaGuncelTc.Text;

        }

        private void cmbBrans_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Doktor Çekme
            cmbDoktor.Items.Clear();
            cmbDoktor.Text = "";
            string query = "Select DoktorAd, DoktorSoyad From Doktor Where DoktorBrans=@p1";
            SqlCommand komut=new SqlCommand(query,bgl.baglanti());
            komut.Parameters.AddWithValue("@p1",cmbBrans.Text);
            SqlDataReader reader = komut.ExecuteReader();
            while (reader.Read())
            {            
                cmbDoktor.Items.Add(reader[0] + " " + reader[1]);
            }

            bgl.baglanti().Close();

            string query2 = "Select RandevuId,RandevuTarih,RandevuSaat,RandevuDoktor,RandevuDurum" +
            " From Randevular Where RandevuBrans='" + cmbBrans.Text + "'";
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(query2, bgl.baglanti());
            da.Fill(dt);
            dataAktifRandevu.DataSource = dt;
            dataAktifRandevu.Columns["RandevuId"].HeaderText = "ID";
            dataAktifRandevu.Columns["RandevuTarih"].HeaderText = "Tarih";
            dataAktifRandevu.Columns["RandevuSaat"].HeaderText = "Saat";
            dataAktifRandevu.Columns["RandevuDoktor"].HeaderText = "Doktor";
            dataAktifRandevu.Columns["RandevuDurum"].HeaderText = "Durum";

            bgl.baglanti().Close();

        }

        private void txtHastaGuncelAd_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar) && e.KeyChar != ' ')
            {
                e.Handled = true; 
            }
        }

        private void txtHastaGuncelSoyad_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar) && e.KeyChar != ' ')
            {
                e.Handled = true; 
            }
        }

        private void txtHastaGuncelTc_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true; 
            }
        }

        private void guna2ImageButton1_Click(object sender, EventArgs e)
        {
            guna2Transition1.HideSync(guna2Panel1);
            guna2Panel1.Visible = false;
        }

        private void linkBilgiDuzenle_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            
            guna2Transition1.ShowSync(guna2Panel1);
            //Bilgi güncelleme textlerini doldur
            txtHastaGuncelSifre.PasswordChar = ' ';
            string[] tamAd = lbAdSoyad.Text.Split(' ');
            txtHastaGuncelAd.PlaceholderText = tamAd[0];
            txtHastaGuncelSoyad.PlaceholderText = tamAd[1];
            txtHastaGuncelTc.PlaceholderText = lbTc.Text;
            string sorgu = "Select HastaSifre from Hasta where HastaTc=@p1";

            SqlCommand cmd = new SqlCommand(sorgu, bgl.baglanti());
            cmd.Parameters.AddWithValue("@p1", lbTc.Text);

            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                txtHastaGuncelSifre.PlaceholderText = dr[0].ToString();

            }

            bgl.baglanti().Close();
        }

        private void kapat_Click(object sender, EventArgs e)
        {
            this.Close();
            FrmGirisler frm= new FrmGirisler();
            frm.Show();
        }

        private void cmbDoktor_SelectedIndexChanged(object sender, EventArgs e)
        {


        }

        private void txtHastaGuncelSifre_TextChanged(object sender, EventArgs e)
        {
            txtHastaGuncelSifre.PasswordChar = '*';
        }
    }
}
