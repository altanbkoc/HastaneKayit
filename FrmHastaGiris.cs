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
    public partial class FrmHastaGiris : Form
    {
        public FrmHastaGiris()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;

        }

        SqlBaglanti bgl=new SqlBaglanti();

    

        private void txtHastaTC_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true; // Eğer sayı değilse, karakteri kabul etme
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void guna2ControlBox1_Click(object sender, EventArgs e)
        {
            FrmGirisler frm = new FrmGirisler();
            frm.Show();
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FrmHastaKayit frm=new FrmHastaKayit();
            frm.Show();
        }

        private void btnHastaGiris_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrWhiteSpace(txtHastaTC.Text) ||
                string.IsNullOrWhiteSpace(txtHastaSifre.Text))
                {
                MessageBox.Show("Lütfen tüm alanları doldurun.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
                }

            string query = "Select * from Hasta WHERE HastaTc=@p1 and HastaSifre=@p2";
           
            SqlCommand komut= new SqlCommand(query,bgl.baglanti());

            komut.Parameters.AddWithValue("@p1",txtHastaTC.Text);
            komut.Parameters.AddWithValue("@p2",txtHastaSifre.Text);

            SqlDataReader reader = komut.ExecuteReader();

           if(reader.Read())
            {
                FrmHastaDetay frm=new FrmHastaDetay();
                frm.tc=txtHastaTC.Text;
                frm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Kullanıcı bulunamadı.");
            }

            bgl.baglanti().Close();
                
        }
    }
}
