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
    public partial class FrmGrafik : Form
    {
        public FrmGrafik()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-PKO8JLN\\SQLEXPRESS;Initial Catalog=PersonelVeriTabani;Integrated Security=True");
        private void FrmGrafik_Load(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand k = new SqlCommand("Select PerAd,PerMaaş from TblPersonel  where PersonelID between 0 and 10   ", baglanti);  
            SqlDataReader dr = k.ExecuteReader();
            while (dr.Read())
            {
                chart1.Series["Maaşlar"].Points.AddXY(dr[0],dr[1]);
            }
            baglanti.Close();

          

     
        }

        private void chart1_Click(object sender, EventArgs e)
        {
            int sayac = 2;          
            if (sayac%2==0)
            {
                baglanti.Open();
                SqlCommand k = new SqlCommand("Select PerAd,PerMaaş from TblPersonel  where PersonelID between 10 and 18   ", baglanti);
                SqlDataReader dr = k.ExecuteReader();
                while (dr.Read())
                {
                    chart1.Series["Maaşlar"].Points.AddXY(dr[0], dr[1]);
                }
                baglanti.Close();
                sayac++;
            }
            
            else if (sayac % 3 == 0)
            {
                baglanti.Open();
                SqlCommand k = new SqlCommand("Select PerAd,PerMaaş from TblPersonel  where PersonelID between 19 and 28   ", baglanti);
                SqlDataReader dr = k.ExecuteReader();
                while (dr.Read())
                {
                    chart1.Series["Maaşlar"].Points.AddXY(dr[0], dr[1]);
                }
                baglanti.Close();
            }
         

            
        }
    }
}
