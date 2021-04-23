
namespace projekafe
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pass = new System.Windows.Forms.TextBox();
            this.kadi = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.kontrollb = new System.Windows.Forms.Label();
            this.girisbt = new System.Windows.Forms.Button();
            this.fileSystemWatcher1 = new System.IO.FileSystemWatcher();
            this.tabPage1 = new System.Windows.Forms.TabControl();
            this.girismn = new System.Windows.Forms.TabPage();
            this.label7 = new System.Windows.Forms.Label();
            this.garsonmn = new System.Windows.Forms.TabPage();
            this.button2 = new System.Windows.Forms.Button();
            this.listView2 = new System.Windows.Forms.ListView();
            this.masanomn2 = new System.Windows.Forms.ColumnHeader();
            this.Durumu = new System.Windows.Forms.ColumnHeader();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.sipariseklebt = new System.Windows.Forms.Button();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Label3 = new System.Windows.Forms.Label();
            this.mutfakmn = new System.Windows.Forms.TabPage();
            this.siparishzbt = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.sipidtablo = new System.Windows.Forms.ColumnHeader();
            this.masanomf = new System.Windows.Forms.ColumnHeader();
            this.garsonmf = new System.Windows.Forms.ColumnHeader();
            this.siparismf = new System.Windows.Forms.ColumnHeader();
            this.adetmf = new System.Windows.Forms.ColumnHeader();
            this.aciklamamn = new System.Windows.Forms.ColumnHeader();
            this.kasamn = new System.Windows.Forms.TabPage();
            this.yonetimmn = new System.Windows.Forms.TabPage();
            this.urunlerbt = new System.Windows.Forms.Button();
            this.calisanlarbt = new System.Windows.Forms.Button();
            this.bilgilerbt = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).BeginInit();
            this.tabPage1.SuspendLayout();
            this.girismn.SuspendLayout();
            this.garsonmn.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.mutfakmn.SuspendLayout();
            this.yonetimmn.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(51, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kullanıcı Adı";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(51, 115);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Şifre";
            // 
            // pass
            // 
            this.pass.Location = new System.Drawing.Point(145, 112);
            this.pass.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pass.Name = "pass";
            this.pass.PasswordChar = '*';
            this.pass.Size = new System.Drawing.Size(110, 23);
            this.pass.TabIndex = 2;
            // 
            // kadi
            // 
            this.kadi.Location = new System.Drawing.Point(145, 58);
            this.kadi.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.kadi.Name = "kadi";
            this.kadi.Size = new System.Drawing.Size(110, 23);
            this.kadi.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.kontrollb);
            this.groupBox1.Controls.Add(this.girisbt);
            this.groupBox1.Controls.Add(this.pass);
            this.groupBox1.Controls.Add(this.kadi);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(307, 98);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(334, 195);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Giriş Yap";
            // 
            // kontrollb
            // 
            this.kontrollb.AutoSize = true;
            this.kontrollb.Location = new System.Drawing.Point(120, 25);
            this.kontrollb.Name = "kontrollb";
            this.kontrollb.Size = new System.Drawing.Size(55, 15);
            this.kontrollb.TabIndex = 5;
            this.kontrollb.Text = "kontrollb";
            this.kontrollb.Visible = false;
            // 
            // girisbt
            // 
            this.girisbt.Location = new System.Drawing.Point(156, 164);
            this.girisbt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.girisbt.Name = "girisbt";
            this.girisbt.Size = new System.Drawing.Size(82, 22);
            this.girisbt.TabIndex = 3;
            this.girisbt.Text = "Giriş Yap";
            this.girisbt.UseVisualStyleBackColor = true;
            this.girisbt.Click += new System.EventHandler(this.girisbt_Click);
            // 
            // fileSystemWatcher1
            // 
            this.fileSystemWatcher1.EnableRaisingEvents = true;
            this.fileSystemWatcher1.SynchronizingObject = this;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.girismn);
            this.tabPage1.Controls.Add(this.garsonmn);
            this.tabPage1.Controls.Add(this.mutfakmn);
            this.tabPage1.Controls.Add(this.kasamn);
            this.tabPage1.Controls.Add(this.yonetimmn);
            this.tabPage1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabPage1.Location = new System.Drawing.Point(0, 0);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.SelectedIndex = 0;
            this.tabPage1.Size = new System.Drawing.Size(989, 480);
            this.tabPage1.TabIndex = 6;
            // 
            // girismn
            // 
            this.girismn.Controls.Add(this.label7);
            this.girismn.Controls.Add(this.groupBox1);
            this.girismn.Location = new System.Drawing.Point(4, 24);
            this.girismn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.girismn.Name = "girismn";
            this.girismn.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.girismn.Size = new System.Drawing.Size(981, 452);
            this.girismn.TabIndex = 0;
            this.girismn.Tag = "";
            this.girismn.Text = "Giriş Yap";
            this.girismn.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(8, 8);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(38, 15);
            this.label7.TabIndex = 5;
            this.label7.Text = "label7";
            this.label7.Visible = false;
            // 
            // garsonmn
            // 
            this.garsonmn.Controls.Add(this.button2);
            this.garsonmn.Controls.Add(this.listView2);
            this.garsonmn.Controls.Add(this.groupBox2);
            this.garsonmn.Location = new System.Drawing.Point(4, 24);
            this.garsonmn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.garsonmn.Name = "garsonmn";
            this.garsonmn.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.garsonmn.Size = new System.Drawing.Size(981, 452);
            this.garsonmn.TabIndex = 1;
            this.garsonmn.Text = "Garson";
            this.garsonmn.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(843, 95);
            this.button2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(110, 74);
            this.button2.TabIndex = 7;
            this.button2.Text = "Sipariş Tamamlandı";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // listView2
            // 
            this.listView2.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.masanomn2,
            this.Durumu});
            this.listView2.FullRowSelect = true;
            this.listView2.HideSelection = false;
            this.listView2.Location = new System.Drawing.Point(629, 31);
            this.listView2.Name = "listView2";
            this.listView2.Size = new System.Drawing.Size(208, 357);
            this.listView2.TabIndex = 1;
            this.listView2.UseCompatibleStateImageBehavior = false;
            this.listView2.View = System.Windows.Forms.View.Details;
            // 
            // masanomn2
            // 
            this.masanomn2.Text = "Masa No";
            this.masanomn2.Width = 100;
            // 
            // Durumu
            // 
            this.Durumu.Text = "Durumu";
            this.Durumu.Width = 100;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.comboBox3);
            this.groupBox2.Controls.Add(this.richTextBox1);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.sipariseklebt);
            this.groupBox2.Controls.Add(this.comboBox2);
            this.groupBox2.Controls.Add(this.comboBox1);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.Label3);
            this.groupBox2.Location = new System.Drawing.Point(94, 31);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Size = new System.Drawing.Size(480, 351);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Sipariş Ekle";
            // 
            // comboBox3
            // 
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Items.AddRange(new object[] {
            "1",
            "2"});
            this.comboBox3.Location = new System.Drawing.Point(212, 34);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(133, 23);
            this.comboBox3.TabIndex = 10;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(212, 178);
            this.richTextBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(203, 110);
            this.richTextBox1.TabIndex = 9;
            this.richTextBox1.Text = "";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(123, 194);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 15);
            this.label6.TabIndex = 7;
            this.label6.Text = "Açıklama";
            // 
            // sipariseklebt
            // 
            this.sipariseklebt.Location = new System.Drawing.Point(239, 316);
            this.sipariseklebt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.sipariseklebt.Name = "sipariseklebt";
            this.sipariseklebt.Size = new System.Drawing.Size(82, 22);
            this.sipariseklebt.TabIndex = 6;
            this.sipariseklebt.Text = "Sipariş Ekle";
            this.sipariseklebt.UseVisualStyleBackColor = true;
            this.sipariseklebt.Click += new System.EventHandler(this.sipariseklebt_Click);
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(212, 142);
            this.comboBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(133, 23);
            this.comboBox2.TabIndex = 5;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(212, 88);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(133, 23);
            this.comboBox1.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(123, 148);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(32, 15);
            this.label5.TabIndex = 2;
            this.label5.Text = "Adet";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(123, 94);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(33, 15);
            this.label4.TabIndex = 1;
            this.label4.Text = "Ürün";
            // 
            // Label3
            // 
            this.Label3.AutoSize = true;
            this.Label3.Location = new System.Drawing.Point(123, 34);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(54, 15);
            this.Label3.TabIndex = 0;
            this.Label3.Text = "Masa No";
            // 
            // mutfakmn
            // 
            this.mutfakmn.Controls.Add(this.siparishzbt);
            this.mutfakmn.Controls.Add(this.listView1);
            this.mutfakmn.Location = new System.Drawing.Point(4, 24);
            this.mutfakmn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.mutfakmn.Name = "mutfakmn";
            this.mutfakmn.Size = new System.Drawing.Size(981, 452);
            this.mutfakmn.TabIndex = 3;
            this.mutfakmn.Text = "Mutfak";
            this.mutfakmn.UseVisualStyleBackColor = true;
            // 
            // siparishzbt
            // 
            this.siparishzbt.Location = new System.Drawing.Point(838, 43);
            this.siparishzbt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.siparishzbt.Name = "siparishzbt";
            this.siparishzbt.Size = new System.Drawing.Size(110, 44);
            this.siparishzbt.TabIndex = 1;
            this.siparishzbt.Text = "Sipariş Hazır";
            this.siparishzbt.UseVisualStyleBackColor = true;
            this.siparishzbt.Click += new System.EventHandler(this.siparishzbt_Click);
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.sipidtablo,
            this.masanomf,
            this.garsonmf,
            this.siparismf,
            this.adetmf,
            this.aciklamamn});
            this.listView1.FullRowSelect = true;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(21, 22);
            this.listView1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.listView1.MultiSelect = false;
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(811, 358);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // sipidtablo
            // 
            this.sipidtablo.Text = "Siparis No";
            this.sipidtablo.Width = 80;
            // 
            // masanomf
            // 
            this.masanomf.Text = "Masa No";
            this.masanomf.Width = 80;
            // 
            // garsonmf
            // 
            this.garsonmf.Text = "Garson Adı";
            this.garsonmf.Width = 150;
            // 
            // siparismf
            // 
            this.siparismf.Text = "Sipariş";
            this.siparismf.Width = 180;
            // 
            // adetmf
            // 
            this.adetmf.Text = "Adet";
            this.adetmf.Width = 70;
            // 
            // aciklamamn
            // 
            this.aciklamamn.Text = "Açıklama";
            this.aciklamamn.Width = 200;
            // 
            // kasamn
            // 
            this.kasamn.Location = new System.Drawing.Point(4, 24);
            this.kasamn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.kasamn.Name = "kasamn";
            this.kasamn.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.kasamn.Size = new System.Drawing.Size(981, 452);
            this.kasamn.TabIndex = 2;
            this.kasamn.Text = "Kasa";
            this.kasamn.UseVisualStyleBackColor = true;
            // 
            // yonetimmn
            // 
            this.yonetimmn.Controls.Add(this.urunlerbt);
            this.yonetimmn.Controls.Add(this.calisanlarbt);
            this.yonetimmn.Controls.Add(this.bilgilerbt);
            this.yonetimmn.Location = new System.Drawing.Point(4, 24);
            this.yonetimmn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.yonetimmn.Name = "yonetimmn";
            this.yonetimmn.Size = new System.Drawing.Size(981, 452);
            this.yonetimmn.TabIndex = 4;
            this.yonetimmn.Text = "Yönetim";
            this.yonetimmn.UseVisualStyleBackColor = true;
            // 
            // urunlerbt
            // 
            this.urunlerbt.Location = new System.Drawing.Point(505, 115);
            this.urunlerbt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.urunlerbt.Name = "urunlerbt";
            this.urunlerbt.Size = new System.Drawing.Size(109, 38);
            this.urunlerbt.TabIndex = 2;
            this.urunlerbt.Text = "Ürünler";
            this.urunlerbt.UseVisualStyleBackColor = true;
            this.urunlerbt.Click += new System.EventHandler(this.urunlerbt_Click);
            // 
            // calisanlarbt
            // 
            this.calisanlarbt.Location = new System.Drawing.Point(365, 195);
            this.calisanlarbt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.calisanlarbt.Name = "calisanlarbt";
            this.calisanlarbt.Size = new System.Drawing.Size(116, 38);
            this.calisanlarbt.TabIndex = 1;
            this.calisanlarbt.Text = "Çalışanlar";
            this.calisanlarbt.UseVisualStyleBackColor = true;
            this.calisanlarbt.Click += new System.EventHandler(this.calisanlarbt_Click);
            // 
            // bilgilerbt
            // 
            this.bilgilerbt.Location = new System.Drawing.Point(241, 115);
            this.bilgilerbt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bilgilerbt.Name = "bilgilerbt";
            this.bilgilerbt.Size = new System.Drawing.Size(101, 38);
            this.bilgilerbt.TabIndex = 0;
            this.bilgilerbt.Text = "Bilgiler";
            this.bilgilerbt.UseVisualStyleBackColor = true;
            this.bilgilerbt.Click += new System.EventHandler(this.bilgilerbt_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timer2
            // 
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(989, 480);
            this.Controls.Add(this.tabPage1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).EndInit();
            this.tabPage1.ResumeLayout(false);
            this.girismn.ResumeLayout(false);
            this.girismn.PerformLayout();
            this.garsonmn.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.mutfakmn.ResumeLayout(false);
            this.yonetimmn.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox pass;
        private System.Windows.Forms.TextBox kadi;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button girisbt;
        private System.Windows.Forms.Label kontrollb;
        private System.IO.FileSystemWatcher fileSystemWatcher1;
        private System.Windows.Forms.TabControl tabPage1;
        private System.Windows.Forms.TabPage garsonmn;
        private System.Windows.Forms.TabPage kasamn;
        private System.Windows.Forms.TabPage mutfakmn;
        private System.Windows.Forms.TabPage yonetimmn;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button sipariseklebt;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label Label3;
        private System.Windows.Forms.Button siparishzbt;
        private System.Windows.Forms.ColumnHeader masanomf;
        private System.Windows.Forms.ColumnHeader garsonmf;
        private System.Windows.Forms.ColumnHeader siparismf;
        private System.Windows.Forms.ColumnHeader adetmf;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox comboBox3;
        internal System.Windows.Forms.TabPage girismn;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ColumnHeader aciklamamn;
        private System.Windows.Forms.ListView listView2;
        private System.Windows.Forms.ColumnHeader masanomn2;
        private System.Windows.Forms.ColumnHeader Durumu;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.ColumnHeader sipidtablo;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button urunlerbt;
        private System.Windows.Forms.Button calisanlarbt;
        private System.Windows.Forms.Button bilgilerbt;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ListView listView1;
    }
}

