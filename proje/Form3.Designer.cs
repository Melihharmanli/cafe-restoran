
namespace projekafe
{
    partial class calisanlarfm
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
            this.kaydetbt = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.kulid = new System.Windows.Forms.ColumnHeader();
            this.ad = new System.Windows.Forms.ColumnHeader();
            this.soyadi = new System.Windows.Forms.ColumnHeader();
            this.kulladi = new System.Windows.Forms.ColumnHeader();
            this.pass = new System.Windows.Forms.ColumnHeader();
            this.gorev = new System.Windows.Forms.ColumnHeader();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.garsoncb = new System.Windows.Forms.CheckBox();
            this.mutfakcb = new System.Windows.Forms.CheckBox();
            this.kasacb = new System.Windows.Forms.CheckBox();
            this.admincb = new System.Windows.Forms.CheckBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.bultb2 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // kaydetbt
            // 
            this.kaydetbt.Location = new System.Drawing.Point(801, 298);
            this.kaydetbt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.kaydetbt.Name = "kaydetbt";
            this.kaydetbt.Size = new System.Drawing.Size(82, 22);
            this.kaydetbt.TabIndex = 1;
            this.kaydetbt.Text = "Kaydet";
            this.kaydetbt.UseVisualStyleBackColor = true;
            this.kaydetbt.Click += new System.EventHandler(this.button1_Click);
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.kulid,
            this.ad,
            this.soyadi,
            this.kulladi,
            this.pass,
            this.gorev});
            this.listView1.FullRowSelect = true;
            this.listView1.GridLines = true;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(10, 0);
            this.listView1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(629, 332);
            this.listView1.TabIndex = 2;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // kulid
            // 
            this.kulid.Text = "İD";
            // 
            // ad
            // 
            this.ad.Text = "Adı";
            this.ad.Width = 100;
            // 
            // soyadi
            // 
            this.soyadi.Text = "Soyadı";
            this.soyadi.Width = 100;
            // 
            // kulladi
            // 
            this.kulladi.Text = "Kullanıcı Adı";
            this.kulladi.Width = 100;
            // 
            // pass
            // 
            this.pass.Text = "Şifresi";
            this.pass.Width = 100;
            // 
            // gorev
            // 
            this.gorev.Text = "Görevi";
            this.gorev.Width = 150;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(678, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(25, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "Adı";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(678, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "Soyadı";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(678, 122);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 15);
            this.label3.TabIndex = 5;
            this.label3.Text = "Kullanıcı Adı";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(678, 178);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(30, 15);
            this.label4.TabIndex = 6;
            this.label4.Text = "Şifre";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(678, 230);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 15);
            this.label5.TabIndex = 7;
            this.label5.Text = "Görevi";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(801, 21);
            this.textBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(110, 23);
            this.textBox1.TabIndex = 8;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(801, 73);
            this.textBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(110, 23);
            this.textBox2.TabIndex = 9;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(801, 122);
            this.textBox3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(110, 23);
            this.textBox3.TabIndex = 10;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(801, 178);
            this.textBox4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox4.Name = "textBox4";
            this.textBox4.PasswordChar = '*';
            this.textBox4.Size = new System.Drawing.Size(110, 23);
            this.textBox4.TabIndex = 11;
            // 
            // garsoncb
            // 
            this.garsoncb.AutoSize = true;
            this.garsoncb.Location = new System.Drawing.Point(801, 230);
            this.garsoncb.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.garsoncb.Name = "garsoncb";
            this.garsoncb.Size = new System.Drawing.Size(63, 19);
            this.garsoncb.TabIndex = 12;
            this.garsoncb.Text = "Garson";
            this.garsoncb.UseVisualStyleBackColor = true;
            // 
            // mutfakcb
            // 
            this.mutfakcb.AutoSize = true;
            this.mutfakcb.Location = new System.Drawing.Point(895, 230);
            this.mutfakcb.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.mutfakcb.Name = "mutfakcb";
            this.mutfakcb.Size = new System.Drawing.Size(64, 19);
            this.mutfakcb.TabIndex = 13;
            this.mutfakcb.Text = "Mutfak";
            this.mutfakcb.UseVisualStyleBackColor = true;
            // 
            // kasacb
            // 
            this.kasacb.AutoSize = true;
            this.kasacb.Location = new System.Drawing.Point(801, 260);
            this.kasacb.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.kasacb.Name = "kasacb";
            this.kasacb.Size = new System.Drawing.Size(50, 19);
            this.kasacb.TabIndex = 14;
            this.kasacb.Text = "Kasa";
            this.kasacb.UseVisualStyleBackColor = true;
            // 
            // admincb
            // 
            this.admincb.AutoSize = true;
            this.admincb.Location = new System.Drawing.Point(895, 260);
            this.admincb.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.admincb.Name = "admincb";
            this.admincb.Size = new System.Drawing.Size(65, 19);
            this.admincb.TabIndex = 15;
            this.admincb.Text = "ADMİN";
            this.admincb.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(214, 352);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(107, 23);
            this.button1.TabIndex = 16;
            this.button1.Text = "Çalışanı Sil";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(801, 352);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(82, 23);
            this.button2.TabIndex = 17;
            this.button2.Text = "Çalışanı Bul";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(895, 298);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(117, 23);
            this.button3.TabIndex = 18;
            this.button3.Text = "Düzenleme İptal";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // bultb2
            // 
            this.bultb2.Location = new System.Drawing.Point(667, 353);
            this.bultb2.Name = "bultb2";
            this.bultb2.Size = new System.Drawing.Size(128, 23);
            this.bultb2.TabIndex = 19;
            this.bultb2.Text = "İD yazınız";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(422, 356);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(38, 15);
            this.label6.TabIndex = 20;
            this.label6.Text = "label6";
            this.label6.Visible = false;
            // 
            // calisanlarfm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1024, 387);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.bultb2);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.admincb);
            this.Controls.Add(this.kasacb);
            this.Controls.Add(this.mutfakcb);
            this.Controls.Add(this.garsoncb);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.kaydetbt);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "calisanlarfm";
            this.Text = "Çalışanlar";
            this.Load += new System.EventHandler(this.calısanlarfm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button kaydetbt;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader ad;
        private System.Windows.Forms.ColumnHeader soyadi;
        private System.Windows.Forms.ColumnHeader kulladi;
        private System.Windows.Forms.ColumnHeader pass;
        private System.Windows.Forms.ColumnHeader gorev;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.CheckBox garsoncb;
        private System.Windows.Forms.CheckBox mutfakcb;
        private System.Windows.Forms.CheckBox kasacb;
        private System.Windows.Forms.CheckBox admincb;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ColumnHeader kulid;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox bultb;
        private System.Windows.Forms.TextBox bultb2;
        private System.Windows.Forms.Label label6;
    }
}