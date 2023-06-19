namespace PiggyBank
{
    partial class Form1
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
            this.cbSecPara = new System.Windows.Forms.ComboBox();
            this.chbKatla = new System.Windows.Forms.CheckBox();
            this.btnEkle = new System.Windows.Forms.Button();
            this.btnAcKumbara = new System.Windows.Forms.Button();
            this.btnYapistirKumbara = new System.Windows.Forms.Button();
            this.btnSalla = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cbSecPara
            // 
            this.cbSecPara.FormattingEnabled = true;
            this.cbSecPara.Items.AddRange(new object[] {
            "5 Kuruş",
            "10 Kuruş",
            "25 Kuruş",
            "50 Kuruş",
            "1 TL",
            "5 TL",
            "10 TL",
            "20 TL",
            "50 TL",
            "100 TL",
            "200 TL"});
            this.cbSecPara.Location = new System.Drawing.Point(76, 61);
            this.cbSecPara.Margin = new System.Windows.Forms.Padding(2);
            this.cbSecPara.Name = "cbSecPara";
            this.cbSecPara.Size = new System.Drawing.Size(126, 21);
            this.cbSecPara.TabIndex = 0;
            this.cbSecPara.Tag = "";
            this.cbSecPara.Text = "Atılcak Parayı Seçiniz";
            // 
            // chbKatla
            // 
            this.chbKatla.AutoSize = true;
            this.chbKatla.Location = new System.Drawing.Point(220, 63);
            this.chbKatla.Margin = new System.Windows.Forms.Padding(2);
            this.chbKatla.Name = "chbKatla";
            this.chbKatla.Size = new System.Drawing.Size(50, 17);
            this.chbKatla.TabIndex = 1;
            this.chbKatla.Text = "Katla";
            this.chbKatla.UseVisualStyleBackColor = true;
            // 
            // btnEkle
            // 
            this.btnEkle.Location = new System.Drawing.Point(76, 97);
            this.btnEkle.Margin = new System.Windows.Forms.Padding(2);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(190, 36);
            this.btnEkle.TabIndex = 2;
            this.btnEkle.Text = "KUMBARAYA EKLE";
            this.btnEkle.UseVisualStyleBackColor = true;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // btnAcKumbara
            // 
            this.btnAcKumbara.Location = new System.Drawing.Point(76, 216);
            this.btnAcKumbara.Margin = new System.Windows.Forms.Padding(2);
            this.btnAcKumbara.Name = "btnAcKumbara";
            this.btnAcKumbara.Size = new System.Drawing.Size(190, 40);
            this.btnAcKumbara.TabIndex = 3;
            this.btnAcKumbara.Text = "KUMBARAYI AÇ";
            this.btnAcKumbara.UseVisualStyleBackColor = true;
            this.btnAcKumbara.Click += new System.EventHandler(this.btnAcKumbara_Click);
            // 
            // btnYapistirKumbara
            // 
            this.btnYapistirKumbara.Location = new System.Drawing.Point(76, 282);
            this.btnYapistirKumbara.Margin = new System.Windows.Forms.Padding(2);
            this.btnYapistirKumbara.Name = "btnYapistirKumbara";
            this.btnYapistirKumbara.Size = new System.Drawing.Size(190, 39);
            this.btnYapistirKumbara.TabIndex = 4;
            this.btnYapistirKumbara.Text = "KUMBARAYI YAPIŞTIR";
            this.btnYapistirKumbara.UseVisualStyleBackColor = true;
            // 
            // btnSalla
            // 
            this.btnSalla.Location = new System.Drawing.Point(76, 156);
            this.btnSalla.Name = "btnSalla";
            this.btnSalla.Size = new System.Drawing.Size(190, 39);
            this.btnSalla.TabIndex = 5;
            this.btnSalla.Text = "Salla";
            this.btnSalla.UseMnemonic = false;
            this.btnSalla.UseVisualStyleBackColor = true;
            this.btnSalla.Click += new System.EventHandler(this.btnSalla_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(352, 392);
            this.Controls.Add(this.btnSalla);
            this.Controls.Add(this.btnYapistirKumbara);
            this.Controls.Add(this.btnAcKumbara);
            this.Controls.Add(this.btnEkle);
            this.Controls.Add(this.chbKatla);
            this.Controls.Add(this.cbSecPara);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = " ";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbSecPara;
        private System.Windows.Forms.CheckBox chbKatla;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.Button btnAcKumbara;
        private System.Windows.Forms.Button btnYapistirKumbara;
        private System.Windows.Forms.Button btnSalla;
    }
}

