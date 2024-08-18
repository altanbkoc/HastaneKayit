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
    public partial class FrmHastaKayit : Form
    {
        public FrmHastaKayit()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;

        }
        SqlBaglanti bgl=new SqlBaglanti();



        private void btnHastaGiris_Click(object sender, EventArgs e)
        {
            // Kullanıcı girdilerini kontrol et
            if (string.IsNullOrWhiteSpace(txtHastaKayitAd.Text) ||
                string.IsNullOrWhiteSpace(txtHastaKayitSoyad.Text) ||
                string.IsNullOrWhiteSpace(txtHastaKayitTc.Text) ||
                string.IsNullOrWhiteSpace(txtHastaKayitSifre.Text) ||
                string.IsNullOrWhiteSpace(comboHastaCins.Text))

            {
                // Boş olan girdiler varsa hata mesajı göster
                MessageBox.Show("Lütfen tüm alanları doldurun.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (txtHastaKayitTc.Text.Length != 11)
            {
                MessageBox.Show("Lütfen 11 haneli kimlik numaranızı giriniz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            
            string query = "Insert into Hasta " +
                                   "(HastaAd,HastaSoyad,HastaTc,HastaSifre,HastaCinsiyet) " +
                                   "values(@p1,@p2,@p3,@p4,@p5)";

            SqlCommand komut = new SqlCommand(query, bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", txtHastaKayitAd.Text);
            komut.Parameters.AddWithValue("@p2", txtHastaKayitSoyad.Text);
            komut.Parameters.AddWithValue("@p3", txtHastaKayitTc.Text);
            komut.Parameters.AddWithValue("@p4", txtHastaKayitSifre.Text);
            komut.Parameters.AddWithValue("@p5", comboHastaCins.Text);

            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Kaydınız gerçekleştirildi\nŞifreniz:" + txtHastaKayitSifre.Text, "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Hide();
        }

        private void txtHastaKayitTc_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true; // Eğer sayı değilse, karakteri kabul etme
            }
        }
        private void txtHastaKayitAd_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar) && e.KeyChar != ' ')
            {
                e.Handled = true; // Eğer harf değilse, karakteri kabul etme
            }
        }

        private void txtHastaKayitSoyad_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar) && e.KeyChar != ' ')
            {
                e.Handled = true; // Eğer harf değilse, karakteri kabul etme
            }
        }
    }
}
