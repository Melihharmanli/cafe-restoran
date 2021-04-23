
namespace projekafe
{
    partial class Bilgilerform
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cafeaditb = new System.Windows.Forms.TextBox();
            this.masasayisitb = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(57, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kafe Adı";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(57, 125);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Masa Sayısı";
            // 
            // cafeaditb
            // 
            this.cafeaditb.Location = new System.Drawing.Point(159, 55);
            this.cafeaditb.Name = "cafeaditb";
            this.cafeaditb.Size = new System.Drawing.Size(125, 27);
            this.cafeaditb.TabIndex = 2;
            // 
            // masasayisitb
            // 
            this.masasayisitb.Location = new System.Drawing.Point(159, 125);
            this.masasayisitb.Name = "masasayisitb";
            this.masasayisitb.Size = new System.Drawing.Size(125, 27);
            this.masasayisitb.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(175, 194);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(94, 29);
            this.button1.TabIndex = 4;
            this.button1.Text = "Kaydet";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Bilgilerform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(400, 302);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.masasayisitb);
            this.Controls.Add(this.cafeaditb);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Bilgilerform";
            this.Text = "Cafe Bilgileri";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox cafeaditb;
        private System.Windows.Forms.TextBox masasayisitb;
        private System.Windows.Forms.Button button1;
    }
}