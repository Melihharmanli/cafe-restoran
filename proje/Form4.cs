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
    public partial class urunlerfm : Form
    {
        public urunlerfm()
        {
            InitializeComponent();
        }
        SqlConnection sqlbaglan = new SqlConnection("Data Source=LAPTOP-4NQ38S5C;Initial Catalog=cafec#;Integrated Security=True");
        SqlCommand komut = new SqlCommand();
        private void urunlerfm_Load(object sender, EventArgs e)
        {
            formload2();
        }

        private void formload2()
        {
            if (sqlbaglan.State == ConnectionState.Closed)
                sqlbaglan.Open();

            komut.CommandText = "select * from urunlertb ORDER BY Convert(Varchar(max),urun_adi) asc";
            komut.Connection = sqlbaglan;
            SqlDataAdapter adaptor = new SqlDataAdapter(komut);
            DataTable tablo = new DataTable();
            adaptor.Fill(tablo);

            for (int i = 0; i < tablo.Rows.Count; i++)
            {
                string[] siparis = { tablo.Rows[i]["urun_no"].ToString(),
                                     tablo.Rows[i]["urun_adi"].ToString(),
                                     tablo.Rows[i]["fiyati"].ToString(),
                                    };
                listView1.Items.Add(new ListViewItem(siparis));

            }
        }
        
        int duzkayit = 0;
        private void kaydetbt_Click(object sender, EventArgs e)
        {
            if (duzkayit == 0)
            {
                try
                {
                    if (sqlbaglan.State == ConnectionState.Closed)
                        sqlbaglan.Open();

                    string kayit = "INSERT INTO urunlertb(urun_adi,fiyati) values (@adi,@tutar)";
                    SqlCommand kayitkomut = new SqlCommand(kayit, sqlbaglan);

                    kayitkomut.Parameters.AddWithValue("@adi", textBox1.Text);
                    kayitkomut.Parameters.AddWithValue("@tutar", textBox2.Text);
                    kayitkomut.ExecuteNonQuery();

                    listView1.Items.Clear();
                    formload2();
                }
                catch (Exception hata)
                {
                    MessageBox.Show("İşlem Sırasında Hata Oluştu." + hata.Message);
                }
            }
            else
            {
                int duzkayitid = Convert.ToInt32(label1.Text);
                string kayit = "update urunlertb set urun_adi=@adi,fiyati=@TL  where urun_no=" + duzkayitid.ToString();
                SqlCommand kayitkomut = new SqlCommand(kayit, sqlbaglan);
                kayitkomut.Parameters.AddWithValue("@adi", textBox1.Text);
                kayitkomut.Parameters.AddWithValue("@TL", textBox2.Text);
                kayitkomut.ExecuteNonQuery();
                listView1.Items.Clear();
                duzkayit = 0;
                kaydetbt.Text = "Kaydet";
                button3.Visible = false;
                textBox3.Enabled = true;
                button2.Enabled = true;
                formload2();
                

            }
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (sqlbaglan.State == ConnectionState.Closed)
                    sqlbaglan.Open();
                string silinecek ="";
                silinecek =listView1.SelectedItems[0].SubItems[0].Text;
                string kayit = ("delete from urunlertb where urun_no=@urunnumarasi");
                SqlCommand kayitkomut = new SqlCommand(kayit, sqlbaglan);
                kayitkomut.Parameters.AddWithValue("@urunnumarasi", silinecek);
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
            for(int i = 0; i < listView1.Items.Count; i++)
            {
                if (listView1.Items[i].SubItems[0].Text == textBox3.Text)
                {
                    textBox1.Text = listView1.Items[i].SubItems[1].Text;
                    textBox2.Text = listView1.Items[i].SubItems[2].Text;
                    kaydetbt.Text = "Düzenle";
                    button3.Visible = true;
                    textBox3.Enabled = false;
                    button2.Enabled = false;
                    label1.Text = listView1.Items[i].SubItems[0].Text;
                    duzkayit = 1;
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            kaydetbt.Text = "Kaydet";
            button3.Visible = false;
            textBox3.Enabled = true;
            button2.Enabled = true;
            duzkayit = 0;
        }
    }
}
