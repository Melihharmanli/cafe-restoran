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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        SqlConnection sqlbaglan = new SqlConnection("");
        
        private void girisbt_Click(object sender, EventArgs e)
        {
            if (sqlbaglan.State == ConnectionState.Closed)
                sqlbaglan.Open();

            int giriskontrol = 0;
            SqlCommand komut = new SqlCommand();
            komut.CommandText= "select * from kullanicitb";
            komut.Connection = sqlbaglan;
            SqlDataAdapter adaptor = new SqlDataAdapter(komut);
            DataTable tablo = new DataTable();
            adaptor.Fill(tablo);
            
            for (int i = 0; i < tablo.Rows.Count; i++)
            {
                if(kadi.Text==tablo.Rows[i]["kuladi"].ToString() && pass.Text== tablo.Rows[i]["pass"].ToString())
                {
                    int k = 1;
                    MessageBox.Show("Giriş Yapıldı");
                    label7.Text =Convert.ToString(tablo.Rows[i]["ad"]);
                    label7.Text += " ";
                    label7.Text +=Convert.ToString(tablo.Rows[i]["soyad"]);
                    giriskontrol = 1;
                    kontrollb.Visible = Convert.ToBoolean("False");
                    /* 2=garson 3=mutfak 5=kasa 7=admin  */
                    if (Convert.ToInt32(tablo.Rows[i]["calistigi_yer"]) % 2 == 0)
                    {
                        tabPage1.TabPages.Insert(k, garsonmn);
                        k++;
                    }
                    if (Convert.ToInt32(tablo.Rows[i]["calistigi_yer"]) % 3 == 0)
                    {
                        tabPage1.TabPages.Insert(k, mutfakmn);
                        k++;
                    }
                    if (Convert.ToInt32(tablo.Rows[i]["calistigi_yer"]) % 5 == 0)
                    {
                        tabPage1.TabPages.Insert(k, kasamn);
                        k++;
                    }
                    if (Convert.ToInt32(tablo.Rows[i]["calistigi_yer"]) % 7 == 0)
                    {
                        tabPage1.TabPages.Insert(k, garsonmn);
                        k++;
                        tabPage1.TabPages.Insert(k, mutfakmn);
                        k++;
                        tabPage1.TabPages.Insert(k, kasamn);
                        k++;
                        tabPage1.TabPages.Insert(k, yonetimmn);
                        k++;
                    }
                    kadi.Enabled = false;
                    pass.Enabled = false;

                    break;
                    
                }
            }
            if (giriskontrol == 0)
            {
                kontrollb.Text = "Giriş Yapılmadı";
                kontrollb.Visible = Convert.ToBoolean("True");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 ff = new Form2(((Button)sender).Text);
            ff.Show();
        }

        int toplammasa=30;
 
        public void Form1_Load(object sender, EventArgs e)
        {
            tabPage1.TabPages.Remove(garsonmn);
            tabPage1.TabPages.Remove(mutfakmn);
            tabPage1.TabPages.Remove(kasamn);
            tabPage1.TabPages.Remove(yonetimmn);

            if (sqlbaglan.State == ConnectionState.Closed)
                sqlbaglan.Open();
            SqlCommand vericek = new SqlCommand();
            vericek.CommandText = "select * from yonetimtb";
            vericek.Connection = sqlbaglan;
            SqlDataAdapter adaptor2 = new SqlDataAdapter(vericek);
            DataTable yonetimtb2 = new DataTable();
            adaptor2.Fill(yonetimtb2);

            SqlCommand urunveri = new SqlCommand();
            vericek.CommandText = "select * from urunlertb";
            vericek.Connection = sqlbaglan;
            SqlDataAdapter adaptorurun = new SqlDataAdapter(urunveri);
            DataTable urunlertb = new DataTable();
            adaptor2.Fill(urunlertb);

            try
            {
                for(int k = 0; k < yonetimtb2.Rows.Count; k++)
                {
                    if ("masasayi" == yonetimtb2.Rows[k]["bilgi"].ToString())
                    {
                        toplammasa = Convert.ToInt16(yonetimtb2.Rows[k]["deger"]);
                        break;
                    }
                }
                
            }
            catch (Exception hata)
            {
                MessageBox.Show("İşlem Sırasında Hata Oluştu.23" + hata.Message);
            }


            int sayac = 0;
            for(int i = 1; i <= 1000; i++)
            {
                for(int j = 1; j <= 5; j++)
                {
                    Button btnekle = new Button();
                    btnekle.Text = "Masa " + (sayac+1).ToString();
                    btnekle.Name = "masa_" + (sayac+1).ToString();
                    btnekle.Size = new Size(100, 44);
                    btnekle.Location = new Point(120*(j-1)+150, 60 * i);   
                    kasamn.Controls.Add(btnekle);
                    btnekle.Click += button1_Click;
                    sayac++;
                    comboBox3.Items.Add(sayac);
                    if (sayac == toplammasa) break;
                }
                if (sayac == toplammasa) break;
            }
            timer1.Interval = 2000;
            timer1.Enabled = true;

            timer2.Interval = 2000;
            timer2.Enabled = true;
            

            for (int ydf = 0; ydf < urunlertb.Rows.Count; ydf++)
            {
                comboBox1.Items.Add(urunlertb.Rows[ydf]["urun_adi"]);
            }
            for(int sgs=0; sgs < 100; sgs++)
            {
                comboBox2.Items.Add(sgs);
            }
                
        }

        private void sipariseklebt_Click(object sender, EventArgs e)
        {
            try
            {
                if (sqlbaglan.State == ConnectionState.Closed)
                    sqlbaglan.Open();
                string kayit = "insert into siparislertb(masa_no,urun,adet,aciklama,durum,cekildi,gad_soy) values (@masano,@urunler,@adeti,@aciklamasi,@durumu,@cekildiler,@garson)";
                SqlCommand kayitkomut = new SqlCommand(kayit, sqlbaglan);
                kayitkomut.Parameters.AddWithValue("@masano", comboBox3.Text);
                kayitkomut.Parameters.AddWithValue("@urunler", comboBox1.Text);
                kayitkomut.Parameters.AddWithValue("@adeti", comboBox2.Text);
                kayitkomut.Parameters.AddWithValue("@aciklamasi", richTextBox1.Text);
                kayitkomut.Parameters.AddWithValue("@durumu", "Hazırlanıyor");
                kayitkomut.Parameters.AddWithValue("@cekildiler", 3);
                string garson = label7.Text;
                kayitkomut.Parameters.AddWithValue("@garson", garson);
                kayitkomut.ExecuteNonQuery();

                sqlbaglan.Close();
            }
            catch (Exception hata)
            {
                MessageBox.Show("İşlem Sırasında Hata Oluştu.a" + hata.Message);
            }
        }
        int sonsiparisid = 0, sonsatir = 0;

        private void siparishzbt_Click(object sender, EventArgs e)
        {
            string aranan =listView1.SelectedItems[0].SubItems[0].Text;

            if (listView1.SelectedItems.Count > 0)
            {
                string kayit = "update siparislertb set durum=@durumu,cekildi=@cekildiler where sip_no="+aranan;
                SqlCommand kayitkomut = new SqlCommand(kayit, sqlbaglan);
                kayitkomut.Parameters.AddWithValue("@durumu", "Hazır");
                kayitkomut.Parameters.AddWithValue("@cekildiler", 0);
                kayitkomut.ExecuteNonQuery();
                listView1.SelectedItems[0].Remove();

            }
                
            else
                MessageBox.Show("Secili Kayıt Yok");
        }


        private void button2_Click_1(object sender, EventArgs e)
        {
            if (listView2.SelectedItems.Count > 0) listView2.SelectedItems[0].Remove();
            else MessageBox.Show("Secili Sipariş Yok");
        }

        private void bilgilerbt_Click(object sender, EventArgs e)
        {
            Bilgilerform bilgilerformac = new Bilgilerform();
            bilgilerformac.Show();
        }

        private void calisanlarbt_Click(object sender, EventArgs e)
        {
            calisanlarfm calisanlarformac = new calisanlarfm();
            calisanlarformac.Show();
        }

        private void urunlerbt_Click(object sender, EventArgs e)
        {
            urunlerfm urunlerformac = new urunlerfm();
            urunlerformac.Show();
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            if (sqlbaglan.State == ConnectionState.Closed)
                sqlbaglan.Open();
            SqlCommand vericek2 = new SqlCommand();
            vericek2.CommandText = "select * from siparislertb";
            vericek2.Connection = sqlbaglan;
            SqlDataAdapter adaptor3 = new SqlDataAdapter(vericek2);
            DataTable siparistb = new DataTable();
            adaptor3.Fill(siparistb);

           for(int disfor = 0; disfor < siparistb.Rows.Count; disfor++)
            {
                if (Convert.ToInt16(siparistb.Rows[disfor]["cekildi"]) == 0)
                {
                    string[] siparis2 = { siparistb.Rows[disfor]["masa_no"].ToString(),
                                         siparistb.Rows[disfor]["durum"].ToString() };
                    listView2.Items.Add(new ListViewItem(siparis2));
                    string cekti = "update siparislertb set cekildi=@cekildiler";
                    SqlCommand kayitkomut2 = new SqlCommand(cekti, sqlbaglan);
                    kayitkomut2.Parameters.AddWithValue("@cekildiler", 1);
                    kayitkomut2.ExecuteNonQuery();
                }
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            
            if (sqlbaglan.State == ConnectionState.Closed)
                sqlbaglan.Open();
            SqlCommand vericek = new SqlCommand();
            vericek.CommandText = "select * from siparislertb";
            vericek.Connection = sqlbaglan;
            SqlDataAdapter adaptor2 = new SqlDataAdapter(vericek);
            DataTable siparistb = new DataTable();
            adaptor2.Fill(siparistb);

            try
            {
                for (int k = sonsatir; k <siparistb.Rows.Count; k++)
                {
                    string[] siparis = { siparistb.Rows[k]["sip_no"].ToString(),
                                         siparistb.Rows[k]["masa_no"].ToString(),
                                         siparistb.Rows[k]["gad_soy"].ToString(),
                                         siparistb.Rows[k]["urun"].ToString(),
                                         siparistb.Rows[k]["adet"].ToString(),
                                         siparistb.Rows[k]["aciklama"].ToString() };
                    listView1.Items.Add(new ListViewItem(siparis));
                    sonsiparisid = Convert.ToInt16(siparistb.Rows[k]["sip_no"]);
                    sonsatir = k+1;
                }

            }
            catch (Exception hata)
            {
                MessageBox.Show("İşlem Sırasında Hata Oluştu." + hata.Message);
            }

        }
    }
}
