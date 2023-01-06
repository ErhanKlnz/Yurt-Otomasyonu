namespace denemee
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
            this.CmbOgrAd = new System.Windows.Forms.TextBox();
            this.CmbOgrSoyad = new System.Windows.Forms.TextBox();
            this.CmbOgrMail = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.CmbOgrTC = new System.Windows.Forms.MaskedTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.CmbOgrTel = new System.Windows.Forms.MaskedTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.CmbOgrKangrup = new System.Windows.Forms.ComboBox();
            this.CmbBolum = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.CmbOdaNo = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbDogtarih = new System.Windows.Forms.MaskedTextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // CmbOgrAd
            // 
            this.CmbOgrAd.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.CmbOgrAd.Location = new System.Drawing.Point(189, 80);
            this.CmbOgrAd.Name = "CmbOgrAd";
            this.CmbOgrAd.Size = new System.Drawing.Size(317, 25);
            this.CmbOgrAd.TabIndex = 0;
            this.CmbOgrAd.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // CmbOgrSoyad
            // 
            this.CmbOgrSoyad.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.CmbOgrSoyad.Location = new System.Drawing.Point(189, 109);
            this.CmbOgrSoyad.Name = "CmbOgrSoyad";
            this.CmbOgrSoyad.Size = new System.Drawing.Size(317, 25);
            this.CmbOgrSoyad.TabIndex = 1;
            // 
            // CmbOgrMail
            // 
            this.CmbOgrMail.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.CmbOgrMail.Location = new System.Drawing.Point(189, 192);
            this.CmbOgrMail.Name = "CmbOgrMail";
            this.CmbOgrMail.Size = new System.Drawing.Size(317, 25);
            this.CmbOgrMail.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(54, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "Öğrenci Adı :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(54, 134);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "Öğrenci TC :";
            // 
            // CmbOgrTC
            // 
            this.CmbOgrTC.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.CmbOgrTC.Location = new System.Drawing.Point(189, 136);
            this.CmbOgrTC.Mask = "00000000000";
            this.CmbOgrTC.Name = "CmbOgrTC";
            this.CmbOgrTC.Size = new System.Drawing.Size(317, 25);
            this.CmbOgrTC.TabIndex = 7;
            this.CmbOgrTC.ValidatingType = typeof(int);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(102, 192);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 17);
            this.label4.TabIndex = 8;
            this.label4.Text = "Mail:";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // CmbOgrTel
            // 
            this.CmbOgrTel.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.CmbOgrTel.Location = new System.Drawing.Point(189, 217);
            this.CmbOgrTel.Mask = "(999) 000-0000";
            this.CmbOgrTel.Name = "CmbOgrTel";
            this.CmbOgrTel.Size = new System.Drawing.Size(317, 25);
            this.CmbOgrTel.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(62, 247);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 17);
            this.label5.TabIndex = 10;
            this.label5.Text = "KanGrubu:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(28, 219);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(114, 17);
            this.label6.TabIndex = 11;
            this.label6.Text = "Öğrenci Tel No:";
            // 
            // CmbOgrKangrup
            // 
            this.CmbOgrKangrup.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.CmbOgrKangrup.FormattingEnabled = true;
            this.CmbOgrKangrup.Location = new System.Drawing.Point(189, 245);
            this.CmbOgrKangrup.Name = "CmbOgrKangrup";
            this.CmbOgrKangrup.Size = new System.Drawing.Size(317, 25);
            this.CmbOgrKangrup.TabIndex = 13;
            // 
            // CmbBolum
            // 
            this.CmbBolum.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.CmbBolum.FormattingEnabled = true;
            this.CmbBolum.Location = new System.Drawing.Point(189, 306);
            this.CmbBolum.Name = "CmbBolum";
            this.CmbBolum.Size = new System.Drawing.Size(317, 25);
            this.CmbBolum.TabIndex = 14;
            this.CmbBolum.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(76, 306);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(64, 17);
            this.label7.TabIndex = 15;
            this.label7.Text = "Bölümü:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(264, 360);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(134, 41);
            this.button1.TabIndex = 16;
            this.button1.Text = "Kaydet";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.Location = new System.Drawing.Point(79, 280);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(63, 17);
            this.label8.TabIndex = 17;
            this.label8.Text = "Oda No:";
            // 
            // CmbOdaNo
            // 
            this.CmbOdaNo.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.CmbOdaNo.FormattingEnabled = true;
            this.CmbOdaNo.Location = new System.Drawing.Point(189, 277);
            this.CmbOdaNo.Name = "CmbOdaNo";
            this.CmbOdaNo.Size = new System.Drawing.Size(317, 25);
            this.CmbOdaNo.TabIndex = 18;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(28, 107);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 17);
            this.label2.TabIndex = 19;
            this.label2.Text = "Öğrenci Soyadı:";
            this.label2.Click += new System.EventHandler(this.label2_Click_1);
            // 
            // cmbDogtarih
            // 
            this.cmbDogtarih.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmbDogtarih.Location = new System.Drawing.Point(189, 161);
            this.cmbDogtarih.Mask = "00/00/0000";
            this.cmbDogtarih.Name = "cmbDogtarih";
            this.cmbDogtarih.Size = new System.Drawing.Size(317, 25);
            this.cmbDogtarih.TabIndex = 20;
            this.cmbDogtarih.ValidatingType = typeof(System.DateTime);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.Location = new System.Drawing.Point(37, 164);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(106, 17);
            this.label9.TabIndex = 21;
            this.label9.Text = "Doğum Tarihi :";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(634, 450);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.cmbDogtarih);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.CmbOdaNo);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.CmbBolum);
            this.Controls.Add(this.CmbOgrKangrup);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.CmbOgrTel);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.CmbOgrTC);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CmbOgrMail);
            this.Controls.Add(this.CmbOgrSoyad);
            this.Controls.Add(this.CmbOgrAd);
            this.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox CmbOgrAd;
        private System.Windows.Forms.TextBox CmbOgrSoyad;
        private System.Windows.Forms.TextBox CmbOgrMail;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.MaskedTextBox CmbOgrTC;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.MaskedTextBox CmbOgrTel;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox CmbOgrKangrup;
        private System.Windows.Forms.ComboBox CmbBolum;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox CmbOdaNo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MaskedTextBox cmbDogtarih;
        private System.Windows.Forms.Label label9;
    }
}

