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
    public partial class calisanlarfm : Form
    {
        int duzenlekontrol = 0;
        public calisanlarfm()
        {
            /* 
             2=garson
             3=mutfak
             5=kasa
             7=admin
             */
            InitializeComponent();
        }
        SqlConnection sqlbaglan = new SqlConnection("Data Source=LAPTOP-4NQ38S5C;Initial Catalog=cafec#;Integrated Security=True");
        SqlCommand komut = new SqlCommand();
        private void calısanlarfm_Load(object sender, EventArgs e)
        {
            button3.Visible = false;
            if (sqlbaglan.State == ConnectionState.Closed)
                sqlbaglan.Open();
            
            komut.CommandText = "select kulid,ad,soyad,kuladi,pass,calistigi_yer from kullanicitb ";
            komut.Connection = sqlbaglan;
            SqlDataAdapter adaptor = new SqlDataAdapter (komut);
            DataTable tablo = new DataTable();
            adaptor.Fill(tablo);
            string gorevi = "";

            for (int i = 0; i < tablo.Rows.Count; i++)
            {
                gorevi = "";
                int gorev = Convert.ToInt32(tablo.Rows[i]["calistigi_yer"]);
                if (gorev % 2 == 0)
                    gorevi+= "Garson,";
                if (gorev % 3 == 0)
                    gorevi+= "Mutfak,";
                if (gorev % 5 == 0)
                    gorevi+= "Kasa,";
                if (gorev % 7 == 0)
                    gorevi+= "ADMİN,";

                string[] siparis = { tablo.Rows[i]["kulid"].ToString(),
                                     tablo.Rows[i]["ad"].ToString(),
                                     tablo.Rows[i]["soyad"].ToString(),
                                     tablo.Rows[i]["kuladi"].ToString(),
                                     tablo.Rows[i]["pass"].ToString(),
                                     gorevi
                                    };
                listView1.Items.Add(new ListViewItem(siparis));

            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (duzenlekontrol==0)
            {
                string gorevilv = "";
                try
                {
                    if (sqlbaglan.State == ConnectionState.Closed)
                        sqlbaglan.Open();

                    int sayi = 1;
                    if (garsoncb.Checked) { sayi *= 2; gorevilv += "Garson,"; }
                    if (mutfakcb.Checked) { sayi *= 3; gorevilv += "Mutfak,"; }
                    if (kasacb.Checked) { sayi *= 5; gorevilv += "Kasa,"; }
                    if (admincb.Checked) { sayi *= 7; gorevilv += "ADMİN,"; }

                    string kayit = "INSERT INTO kullanicitb(ad,soyad,kuladi,pass,calistigi_yer) values (@adi,@soyadi,@kullaniciadi,@password,@gorevi)";
                    SqlCommand kayitkomut = new SqlCommand(kayit, sqlbaglan);

                    kayitkomut.Parameters.AddWithValue("@adi", textBox1.Text);
                    kayitkomut.Parameters.AddWithValue("@soyadi", textBox2.Text);
                    kayitkomut.Parameters.AddWithValue("@kullaniciadi", textBox3.Text);
                    kayitkomut.Parameters.AddWithValue("@password", textBox4.Text);
                    kayitkomut.Parameters.AddWithValue("@gorevi", sayi);
                    kayitkomut.ExecuteNonQuery();

                    SqlCommand komut = new SqlCommand();
                    komut.CommandText = "select kulid,kuladi from kullanicitb where convert(nvarchar(max), kuladi)=@kullaniciadi";
                    komut.Parameters.AddWithValue("@kullaniciadi", textBox3.Text);
                    komut.Connection = sqlbaglan;
                    SqlDataAdapter adaptor = new SqlDataAdapter(komut);
                    DataTable tablo = new DataTable();
                    adaptor.Fill(tablo);

                    string[] ekle = { tablo.Rows[0]["kulid"].ToString(), textBox1.Text, textBox2.Text, textBox3.Text, textBox4.Text , gorevilv };
                    listView1.Items.Add(new ListViewItem(ekle));
                }
                catch (Exception hata)
                {
                    MessageBox.Show("İşlem Sırasında Hata Oluştu." + hata.Message);
                }
            }
            else
            {
                try
                {
                    int duzkayitid = Convert.ToInt32(label6.Text);
                    string kayit = "update kullanicitb set ad=@adi,soyad=@soyadi,kuladi=@kullaniciadi,pass=@sifresi,calistigi_yer=@gorevi  where kulid=" + duzkayitid.ToString();
                    SqlCommand kayitkomut = new SqlCommand(kayit, sqlbaglan);
                    kayitkomut.Parameters.AddWithValue("@adi", textBox1.Text);
                    kayitkomut.Parameters.AddWithValue("@soyadi", textBox2.Text);
                    kayitkomut.Parameters.AddWithValue("@kullaniciadi", textBox3.Text);
                    kayitkomut.Parameters.AddWithValue("@sifresi", textBox4.Text);

                    string gorevilv = "";
                    int sayi = 1;
                    if (garsoncb.Checked) { sayi *= 2; gorevilv += "Garson,"; }
                    if (mutfakcb.Checked) { sayi *= 3; gorevilv += "Mutfak,"; }
                    if (kasacb.Checked) { sayi *= 5; gorevilv += "Kasa,"; }
                    if (admincb.Checked) { sayi *= 7; gorevilv += "ADMİN,"; }

                    kayitkomut.Parameters.AddWithValue("@gorevi", sayi);
                    kayitkomut.ExecuteNonQuery();
                    for(int i = 0; i < listView1.Items.Count; i++)
                    {
                        if (listView1.Items[i].SubItems[0].Text == label6.Text)
                        {
                            listView1.Items[i].Remove();

                            SqlCommand komut = new SqlCommand();
                            komut.CommandText = "select kulid from kullanicitb where kulid=@kullaniciid";
                            komut.Parameters.AddWithValue("@kullaniciid", Convert.ToString(duzkayitid));
                            komut.Connection = sqlbaglan;
                            SqlDataAdapter adaptor = new SqlDataAdapter(komut);
                            DataTable tablo = new DataTable();
                            adaptor.Fill(tablo);

                            string[] ekle = { tablo.Rows[0]["kulid"].ToString(), textBox1.Text, textBox2.Text, textBox3.Text, textBox4.Text, gorevilv };
                            listView1.Items.Add(new ListViewItem(ekle));
                            break;
                        }
                    }
                    

                    
                    
                }
                catch (Exception hata)
                {
                    MessageBox.Show("İşlem Sırasında Hata Oluştu." + hata.Message);
                }
                duzenlekontrol = 0;
                textBox1.Text = "";
                textBox2.Text = "";
                textBox3.Text = "";
                textBox4.Text = "";
                garsoncb.Checked = false;
                mutfakcb.Checked = false;
                kasacb.Checked = false;
                admincb.Checked = false;
                button3.Visible = false;
                kaydetbt.Text = "Kaydet";
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (sqlbaglan.State == ConnectionState.Closed)
                    sqlbaglan.Open();
                string silinecek = "";
                silinecek = listView1.SelectedItems[0].SubItems[2].Text;
                string kayit = ("delete from kullanicitb where convert(nvarchar(max), kuladi)=@kullaniciadi");
                SqlCommand kayitkomut = new SqlCommand(kayit, sqlbaglan);
                kayitkomut.Parameters.AddWithValue("@kullaniciadi", silinecek);
                kayitkomut.ExecuteNonQuery();

                listView1.Items.Remove(listView1.SelectedItems[0]);
            }
            catch (Exception hata)
            {
                MessageBox.Show("İşlem Sırasında Hata Oluştu." + hata.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            for(int i = 0; i<listView1.Items.Count; i++)
            {
                if (listView1.Items[i].SubItems[0].Text == bultb2.Text)
                {
                    label6.Text = bultb2.Text;
                    textBox1.Text= listView1.Items[i].SubItems[1].Text;
                    textBox2.Text= listView1.Items[i].SubItems[2].Text;
                    textBox3.Text= listView1.Items[i].SubItems[3].Text;
                    textBox4.Text= listView1.Items[i].SubItems[4].Text;
                    button3.Visible = true;
                    kaydetbt.Text = "Düzenle";
                    duzenlekontrol = 1;
                    break;
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            garsoncb.Checked = false;
            mutfakcb.Checked = false;
            kasacb.Checked = false;
            admincb.Checked = false;
            button3.Visible = false;
            kaydetbt.Text = "Kaydet";
        }
    }
}
