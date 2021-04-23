
namespace projekafe
{
    partial class Form2
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
            this.masanolabel = new System.Windows.Forms.Label();
            this.listView1 = new System.Windows.Forms.ListView();
            this.siparisid = new System.Windows.Forms.ColumnHeader();
            this.siparismf = new System.Windows.Forms.ColumnHeader();
            this.adetmf = new System.Windows.Forms.ColumnHeader();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.hesapodendibt = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // masanolabel
            // 
            this.masanolabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.masanolabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.masanolabel.Font = new System.Drawing.Font("Segoe UI", 40.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.masanolabel.Location = new System.Drawing.Point(186, 28);
            this.masanolabel.Name = "masanolabel";
            this.masanolabel.Size = new System.Drawing.Size(350, 76);
            this.masanolabel.TabIndex = 0;
            this.masanolabel.Text = "label1";
            this.masanolabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.siparisid,
            this.siparismf,
            this.adetmf});
            this.listView1.FullRowSelect = true;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(10, 105);
            this.listView1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(492, 358);
            this.listView1.TabIndex = 1;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // siparisid
            // 
            this.siparisid.Text = "Sipariş No";
            this.siparisid.Width = 80;
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
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(543, 154);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 29);
            this.label1.TabIndex = 2;
            this.label1.Text = "Tutar=";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(631, 154);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(131, 29);
            this.label2.TabIndex = 3;
            this.label2.Text = "hesaplanan";
            // 
            // hesapodendibt
            // 
            this.hesapodendibt.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.hesapodendibt.Location = new System.Drawing.Point(543, 196);
            this.hesapodendibt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.hesapodendibt.Name = "hesapodendibt";
            this.hesapodendibt.Size = new System.Drawing.Size(219, 47);
            this.hesapodendibt.TabIndex = 4;
            this.hesapodendibt.Text = "Hesap Ödendi";
            this.hesapodendibt.UseVisualStyleBackColor = true;
            this.hesapodendibt.Click += new System.EventHandler(this.hesapodendibt_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(798, 499);
            this.Controls.Add(this.hesapodendibt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.masanolabel);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label masanolabel;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader siparismf;
        private System.Windows.Forms.ColumnHeader adetmf;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button hesapodendibt;
        private System.Windows.Forms.ColumnHeader siparisid;
    }
}