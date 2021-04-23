
namespace projekafe
{
    partial class urunlerfm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.urunadi = new System.Windows.Forms.Label();
            this.fiyat = new System.Windows.Forms.ColumnHeader();
            this.urun = new System.Windows.Forms.ColumnHeader();
            this.label2 = new System.Windows.Forms.Label();
            this.listView1 = new System.Windows.Forms.ListView();
            this.urunid = new System.Windows.Forms.ColumnHeader();
            this.kaydetbt = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(768, 188);
            this.textBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(110, 23);
            this.textBox2.TabIndex = 24;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(768, 136);
            this.textBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(110, 23);
            this.textBox1.TabIndex = 23;
            // 
            // urunadi
            // 
            this.urunadi.AutoSize = true;
            this.urunadi.Location = new System.Drawing.Point(645, 136);
            this.urunadi.Name = "urunadi";
            this.urunadi.Size = new System.Drawing.Size(54, 15);
            this.urunadi.TabIndex = 18;
            this.urunadi.Text = "Ürün Adı";
            // 
            // fiyat
            // 
            this.fiyat.Text = "Fiyat";
            this.fiyat.Width = 140;
            // 
            // urun
            // 
            this.urun.Text = "Ürün Adı";
            this.urun.Width = 350;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(645, 188);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 15);
            this.label2.TabIndex = 19;
            this.label2.Text = "Fiyat";
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.urunid,
            this.urun,
            this.fiyat});
            this.listView1.FullRowSelect = true;
            this.listView1.GridLines = true;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(20, 28);
            this.listView1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(577, 362);
            this.listView1.TabIndex = 17;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // urunid
            // 
            this.urunid.Text = "Urun No";
            // 
            // kaydetbt
            // 
            this.kaydetbt.Location = new System.Drawing.Point(728, 254);
            this.kaydetbt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.kaydetbt.Name = "kaydetbt";
            this.kaydetbt.Size = new System.Drawing.Size(82, 22);
            this.kaydetbt.TabIndex = 16;
            this.kaydetbt.Text = "Kaydet";
            this.kaydetbt.UseVisualStyleBackColor = true;
            this.kaydetbt.Click += new System.EventHandler(this.kaydetbt_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(224, 417);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(172, 40);
            this.button1.TabIndex = 25;
            this.button1.Text = "Ürünü Sil";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(678, 367);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 26;
            this.button2.Text = "Bul";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(818, 254);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(103, 23);
            this.button3.TabIndex = 27;
            this.button3.Text = "Düzenleme İptal";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Visible = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(678, 338);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(142, 23);
            this.textBox3.TabIndex = 28;
            this.textBox3.Text = "Ürün No yazınız...";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(577, 442);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 15);
            this.label1.TabIndex = 29;
            this.label1.Text = "label1";
            this.label1.Visible = false;
            // 
            // urunlerfm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(933, 502);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.urunadi);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.kaydetbt);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "urunlerfm";
            this.Text = "Ürünler";
            this.Load += new System.EventHandler(this.urunlerfm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label urunadi;
        private System.Windows.Forms.ColumnHeader fiyat;
        private System.Windows.Forms.ColumnHeader urun;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Button kaydetbt;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ColumnHeader urunid;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label1;
    }
}