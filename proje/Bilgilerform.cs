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

namespace projekafe
{
    public partial class Bilgilerform : Form
    {
        public Bilgilerform()
        {
            InitializeComponent();
        }
        SqlConnection sqlbaglan = new SqlConnection("Data Source=LAPTOP-4NQ38S5C;Initial Catalog=cafec#;Integrated Security=True");
        private void button1_Click(object sender, EventArgs e)
        {
            if (sqlbaglan.State == ConnectionState.Closed)
                sqlbaglan.Open();
            string aranan = cafeaditb.Text;
            string kayit = "select * from yonetimtb " +
                           "update yonetimtb set deger=@adi where CONVERT(NVARCHAR(MAX), bilgi) = 'cafe_adi'";
            SqlCommand kayitkomut = new SqlCommand(kayit, sqlbaglan);
                kayitkomut.Parameters.AddWithValue("@adi", aranan);
                kayitkomut.ExecuteNonQuery();

            string aranan2 = masasayisitb.Text;
            string kayitmasa = "select * from yonetimtb " +
                           "update yonetimtb set deger=@masasayisi where CONVERT(NVARCHAR(MAX), bilgi) = 'masasayi'";
            SqlCommand komutmasa = new SqlCommand(kayitmasa, sqlbaglan);
            komutmasa.Parameters.AddWithValue("@masasayisi", aranan2);
            komutmasa.ExecuteNonQuery();


        }
    }
}
