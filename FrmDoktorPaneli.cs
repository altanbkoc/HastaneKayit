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
    public partial class FrmDoktorPaneli : Form
    {
        public FrmDoktorPaneli()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;


        }
        SqlBaglanti bgl=new SqlBaglanti();

        private void FrmDoktorPaneli_Load(object sender, EventArgs e)
        {
            //Doktor data
            string query = "Select * From Doktor";

           DataTable dt = new DataTable();
           SqlDataAdapter da= new SqlDataAdapter(query,bgl.baglanti());
           da.Fill(dt);
           dataDoktor.DataSource = dt;

            dataDoktor.Columns["DoktorId"].HeaderText = "ID";
            dataDoktor.Columns["DoktorAd"].HeaderText = "Ad";
            dataDoktor.Columns["DoktorSoyad"].HeaderText = "Soyad";
            dataDoktor.Columns["DoktorTc"].HeaderText = "T.C.";
            dataDoktor.Columns["DoktorSifre"].HeaderText = "Sifre";
            dataDoktor.Columns["DoktorBrans"].HeaderText = "Brans";

            bgl.baglanti().Close();

            //Branşları çek
            string query2= "Select BransAd From Brans";
            SqlCommand komut=new SqlCommand(query2,bgl.baglanti());
            SqlDataReader reader=komut.ExecuteReader();
            while (reader.Read())
            {
                comboBrans.Items.Add(reader[0]);
            }
            bgl.baglanti().Close();





        }


        private void guna2GradientPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txtDoktorPanelAd_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar) && e.KeyChar != ' ')
            {
                e.Handled = true; // Eğer harf değilse, karakteri kabul etme
            }

        }

        private void txtDoktorPanelSoyad_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar) && e.KeyChar != ' ')
            {
                e.Handled = true; // Eğer harf değilse, karakteri kabul etme
            }
        }

        private void txtDoktorPanelTc_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true; // Eğer sayı değilse, karakteri kabul etme
            }

        }

        private void btnDoktorEkle_Click(object sender, EventArgs e)
        {
            string query = "insert into Doktor " +
                "(DoktorAd,DoktorSoyad,DoktorTc,DoktorSifre,DoktorBrans) " +
                "values(@p1,@p2,@p3,@p4,@p5)";
            SqlCommand komut=new SqlCommand(query,bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", txtDoktorPanelAd.Text);
            komut.Parameters.AddWithValue("@p2", txtDoktorPanelSoyad.Text);
            komut.Parameters.AddWithValue("@p3", txtDoktorPanelTc.Text);
            komut.Parameters.AddWithValue("@p4", txtDoktorPanelSifre.Text);
            komut.Parameters.AddWithValue("@p5", comboBrans.Text);

            komut.ExecuteNonQuery();

            MessageBox.Show("İşlem başarıyla gerçekleştirildi.");

            bgl.baglanti().Close();

        }

        private void guna2GradientButton1_Click(object sender, EventArgs e)
        {
            string query = "Select * From Doktor";

            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(query, bgl.baglanti());
            da.Fill(dt);
            dataDoktor.DataSource = dt;

            dataDoktor.Columns["DoktorId"].HeaderText = "ID";
            dataDoktor.Columns["DoktorAd"].HeaderText = "Ad";
            dataDoktor.Columns["DoktorSoyad"].HeaderText = "Soyad";
            dataDoktor.Columns["DoktorTc"].HeaderText = "T.C.";
            dataDoktor.Columns["DoktorSifre"].HeaderText = "Sifre";
            dataDoktor.Columns["DoktorBrans"].HeaderText = "Brans";

            bgl.baglanti().Close();
        }

        private void dataDoktor_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataDoktor.SelectedCells[0].RowIndex;

            txtDoktorPanelAd.Text = dataDoktor.Rows[secilen].Cells[1].Value.ToString();
            txtDoktorPanelSoyad.Text = dataDoktor.Rows[secilen].Cells[2].Value.ToString();
            txtDoktorPanelTc.Text = dataDoktor.Rows[secilen].Cells[3].Value.ToString();
            txtDoktorPanelSifre.Text = dataDoktor.Rows[secilen].Cells[4].Value.ToString();
            comboBrans.Text= dataDoktor.Rows[secilen].Cells[5].Value.ToString();

            label6.Text= txtDoktorPanelTc.Text = dataDoktor.Rows[secilen].Cells[0].Value.ToString();

            lbid.Text = label6.Text;

        }

        private void btnDoktorGuncelle_Click(object sender, EventArgs e)
        {
            // SQL UPDATE sorgusunu tanımla
            string query = "UPDATE Doktor SET DoktorAd = @p1, DoktorSoyad = @p2, DoktorSifre = @p4, DoktorBrans = @p5 WHERE DoktorId = @p6";

            // SqlCommand nesnesini oluştur ve parametreleri ayarla
            SqlCommand komut = new SqlCommand(query, bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", txtDoktorPanelAd.Text);
            komut.Parameters.AddWithValue("@p2", txtDoktorPanelSoyad.Text);
            komut.Parameters.AddWithValue("@p3", txtDoktorPanelTc.Text);
            komut.Parameters.AddWithValue("@p4", txtDoktorPanelSifre.Text);
            komut.Parameters.AddWithValue("@p5", comboBrans.Text);
            komut.Parameters.AddWithValue("@p6", lbid.Text);



            komut.ExecuteNonQuery();

            MessageBox.Show("İşlem başarıyla gerçekleştirildi.");
            
            bgl.baglanti().Close();
            
        }

        private void btnDoktorSil_Click(object sender, EventArgs e)
        {
            string query = "Delete From Doktor Where DoktorId=@p1";
            SqlCommand komut = new SqlCommand( query, bgl.baglanti());
            komut.Parameters.AddWithValue("@p1",lbid.Text);
            komut.ExecuteNonQuery();

            bgl.baglanti().Close();

            MessageBox.Show(lbid.Text + ". ID kodlu doktor başarıyla silindi");
            txtDoktorPanelAd.Text = "";
            txtDoktorPanelSoyad.Text = "";
            txtDoktorPanelTc.Text = "";
            txtDoktorPanelSifre.Text = "";
            lbid.Text = "";


        }
    }
}
