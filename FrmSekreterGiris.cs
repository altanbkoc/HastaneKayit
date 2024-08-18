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
    public partial class FrmSekreterGiris : Form
    {
        public FrmSekreterGiris()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;

        }

        SqlBaglanti bgl= new SqlBaglanti();
        
        private void txtSekreterTC_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void guna2ControlBox1_Click(object sender, EventArgs e)
        {
            FrmGirisler frm= new FrmGirisler();
            frm.Show();
        }

        private void btnSekreter_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtSekreterSifre.Text) ||
             string.IsNullOrWhiteSpace(txtSekreterSifre.Text))
            {
                MessageBox.Show("Lütfen tüm alanları doldurun.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if(txtSekreterTC.Text.Length != 11)
            {
                MessageBox.Show("Lütfen geçerli bir kimlik numarası giriniz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;

            }

            string query = "Select SekreterTc,SekreterSifre,SekreterAdSoyad From Sekreter Where SekreterTc=@p1 and SekreterSifre=@p2";
            SqlCommand komut= new SqlCommand(query,bgl.baglanti());
            komut.Parameters.AddWithValue("@p1",txtSekreterTC.Text);
            komut.Parameters.AddWithValue("@p2", txtSekreterSifre.Text);
            SqlDataReader reader=komut.ExecuteReader();

            if (reader.Read())
            {
                FrmSekreterDetay frm= new FrmSekreterDetay();
                string adSoyad = reader["SekreterAdSoyad"].ToString();
                frm.tc = txtSekreterTC.Text;
                frm.adSoyad = adSoyad;

                frm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Kullanıcı bulunumadı.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            bgl.baglanti().Close();
        }
    }
}
