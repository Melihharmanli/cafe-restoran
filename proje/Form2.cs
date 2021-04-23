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
    public partial class Form2 : Form
    {
        int masano=0, sirasi=0,tutar=0;
        string masanost;
        SqlConnection sqlbaglan = new SqlConnection("Data Source=LAPTOP-4NQ38S5C;Initial Catalog=cafec#;Integrated Security=True");

        private void hesapodendibt_Click(object sender, EventArgs e)
        {
            if (sqlbaglan.State.ToString() == "Closed")
            {
                sqlbaglan.Open();
            }

            listView1.Clear();
            string silmeSorgusu = "DELETE from siparislertb where masa_no=@masaid";
            SqlCommand silKomutu = new SqlCommand(silmeSorgusu, sqlbaglan);
            silKomutu.Parameters.AddWithValue("@masaid", masano);
            silKomutu.ExecuteNonQuery();
            tutar = 0;
            label2.Text = Convert.ToString(tutar);
            MessageBox.Show("Hesap Ödendi...");

        }

        public Form2(String a)
        {
            InitializeComponent();
            masanolabel.Text = a;
            
            sirasi = a.LastIndexOf(" ");
            masano=Convert.ToInt32(a.Substring(sirasi));
            masanost = Convert.ToString(masano);
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            tutar = 0;
            /*----------------------------------*/

            SqlCommand komutform2 = new SqlCommand();
            string siparistbkomut = "select * from siparislertb where masa_no=" + masanost;
            komutform2.CommandText = siparistbkomut;
            komutform2.Connection = sqlbaglan;
            SqlDataAdapter adaptorform2 = new SqlDataAdapter(komutform2);
            DataTable tablo = new DataTable();
            adaptorform2.Fill(tablo);

            /*----------------------------------*/
            SqlCommand komutform3 = new SqlCommand();
            string tutarhesapkomut = "select * from urunlertb";
            komutform3.CommandText = tutarhesapkomut;
            komutform3.Connection = sqlbaglan;
            SqlDataAdapter adaptor2form2 = new SqlDataAdapter(komutform3);
            DataTable tablo2 = new DataTable();
            adaptor2form2.Fill(tablo2);
            /*----------------------------------*/

            try
            {
                for(int i = 0; i<tablo.Rows.Count ; i++)
                {
                    if (Convert.ToInt16(tablo.Rows[i]["masa_no"])==masano)
                    {
                        string[] siparis = { tablo.Rows[i]["sip_no"].ToString(),
                                             tablo.Rows[i]["urun"].ToString(),
                                             tablo.Rows[i]["adet"].ToString() };
                        listView1.Items.Add(new ListViewItem(siparis));

                        for(int x=0;x<tablo2.Rows.Count;x++)
                        {
                            if (tablo2.Rows[x]["urun_adi"].ToString() == tablo.Rows[i]["urun"].ToString())
                            {
                                tutar =tutar+ Convert.ToInt16(tablo.Rows[i]["adet"]) * Convert.ToInt16(tablo2.Rows[x]["fiyati"]);
                            }
                                
                        }
                        
                    }
                }

            }
            catch (Exception hata)
            {
                MessageBox.Show("İşlem Sırasında Hata Oluştu." + hata.Message);
            }
            label2.Text = tutar.ToString();
        }
    }
}
