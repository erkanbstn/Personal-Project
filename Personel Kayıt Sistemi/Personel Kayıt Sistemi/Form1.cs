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

namespace Personel_Kayıt_Sistemi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public void listele()
        {
            SqlDataAdapter adapter = new SqlDataAdapter("Select * from TblPersonel", baglanti);
            DataTable table = new DataTable();
            adapter.Fill(table);
            dataGridView1.DataSource = table;
        }
        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-PKO8JLN\\SQLEXPRESS;Initial Catalog=PersonelVeriTabani;Integrated Security=True");
        private void Form1_Load(object sender, EventArgs e)
        {
            SqlDataAdapter adapter = new SqlDataAdapter("Select * from TblPersonel", baglanti);
            DataTable table = new DataTable();
            adapter.Fill(table);
            dataGridView1.DataSource = table;
        }
       

        private void btnkay_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into TblPersonel (PerAd,PerSoyad,PerŞehir,PerMaaş,PerMeslek,PerDurum) values (@p1,@p2,@p3,@p4,@p5,@p6) ", baglanti);
            komut.Parameters.AddWithValue("@p1", textad.Text);
            komut.Parameters.AddWithValue("@p2", textsad.Text);
            komut.Parameters.AddWithValue("@p3", cmbseh.Text);
            komut.Parameters.AddWithValue("@p4", mskdmaas.Text.ToString());
            komut.Parameters.AddWithValue("@p5", textmes.Text);
            komut.Parameters.AddWithValue("@p6", label8.Text);
            komut.ExecuteNonQuery(); 
            baglanti.Close();
            listele();
            MessageBox.Show("Personel Eklendi", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnsil_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand k = new SqlCommand("delete from TblPersonel where PersonelID=@p1",baglanti);
            k.Parameters.AddWithValue("@p1",txtid.Text);
            k.ExecuteNonQuery();
            baglanti.Close();
            listele();
            MessageBox.Show("Personel Silindi", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btntem_Click(object sender, EventArgs e)
        {
            txtid.Text = "";
            textad.Text = "";
            textsad.Text = "";
            textmes.Text = "";
            cmbseh.Text = "";
            mskdmaas.Text = "";
            rdbe.Checked = false;
            rdev.Checked = false;
        }

        private void btngün_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand d=new SqlCommand("update TblPersonel set PerAd=@p1,PerSoyad=@p2,PerŞehir=@p3,PerMaaş=@p4,PerDurum=@p5,PerMeslek=@p6 where PersonelID=@p7",baglanti);
            d.Parameters.AddWithValue("@p1",textad.Text);
            d.Parameters.AddWithValue("@p2",textsad.Text);
            d.Parameters.AddWithValue("@p3",cmbseh.Text);
            d.Parameters.AddWithValue("@p4",mskdmaas.Text);
            d.Parameters.AddWithValue("@p5",label8.Text);
            d.Parameters.AddWithValue("@p6",textmes.Text);
            d.Parameters.AddWithValue("@p7",txtid.Text);
            d.ExecuteNonQuery();
            baglanti.Close();
            listele();
            MessageBox.Show("Personel Güncellendi", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void rdev_CheckedChanged(object sender, EventArgs e)
        {
            label8.Text = "1";
        }

        private void rdbe_CheckedChanged(object sender, EventArgs e)
        {
            label8.Text = "0";
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            txtid.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            textad.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            textsad.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            cmbseh.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
            mskdmaas.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();        
            textmes.Text = dataGridView1.Rows[e.RowIndex].Cells[6].Value.ToString();
            label8.Text = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();
            if (label8.Text == "True")
            {
                rdev.Checked = true;
            }
            else
            {
                rdbe.Checked = true;
            }
         
        }

        private void btngraf_Click(object sender, EventArgs e)
        {
            FrmGrafik fe = new FrmGrafik();
            fe.Show();
            
        }
    }
}
