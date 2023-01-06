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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
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
            this.CmbBolum = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.CmbOdaNo = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbDogtarih = new System.Windows.Forms.MaskedTextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtKangrup = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // CmbOgrAd
            // 
            resources.ApplyResources(this.CmbOgrAd, "CmbOgrAd");
            this.CmbOgrAd.Name = "CmbOgrAd";
            this.CmbOgrAd.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // CmbOgrSoyad
            // 
            resources.ApplyResources(this.CmbOgrSoyad, "CmbOgrSoyad");
            this.CmbOgrSoyad.Name = "CmbOgrSoyad";
            // 
            // CmbOgrMail
            // 
            resources.ApplyResources(this.CmbOgrMail, "CmbOgrMail");
            this.CmbOgrMail.Name = "CmbOgrMail";
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.Name = "label3";
            // 
            // CmbOgrTC
            // 
            resources.ApplyResources(this.CmbOgrTC, "CmbOgrTC");
            this.CmbOgrTC.Name = "CmbOgrTC";
            this.CmbOgrTC.ValidatingType = typeof(int);
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.Name = "label4";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // CmbOgrTel
            // 
            resources.ApplyResources(this.CmbOgrTel, "CmbOgrTel");
            this.CmbOgrTel.Name = "CmbOgrTel";
            // 
            // label5
            // 
            resources.ApplyResources(this.label5, "label5");
            this.label5.Name = "label5";
            // 
            // label6
            // 
            resources.ApplyResources(this.label6, "label6");
            this.label6.Name = "label6";
            // 
            // CmbBolum
            // 
            resources.ApplyResources(this.CmbBolum, "CmbBolum");
            this.CmbBolum.FormattingEnabled = true;
            this.CmbBolum.Name = "CmbBolum";
            this.CmbBolum.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // label7
            // 
            resources.ApplyResources(this.label7, "label7");
            this.label7.Name = "label7";
            // 
            // button1
            // 
            resources.ApplyResources(this.button1, "button1");
            this.button1.Name = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label8
            // 
            resources.ApplyResources(this.label8, "label8");
            this.label8.Name = "label8";
            // 
            // CmbOdaNo
            // 
            resources.ApplyResources(this.CmbOdaNo, "CmbOdaNo");
            this.CmbOdaNo.FormattingEnabled = true;
            this.CmbOdaNo.Name = "CmbOdaNo";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            this.label2.Click += new System.EventHandler(this.label2_Click_1);
            // 
            // cmbDogtarih
            // 
            resources.ApplyResources(this.cmbDogtarih, "cmbDogtarih");
            this.cmbDogtarih.Name = "cmbDogtarih";
            this.cmbDogtarih.ValidatingType = typeof(System.DateTime);
            // 
            // label9
            // 
            resources.ApplyResources(this.label9, "label9");
            this.label9.Name = "label9";
            // 
            // txtKangrup
            // 
            resources.ApplyResources(this.txtKangrup, "txtKangrup");
            this.txtKangrup.Name = "txtKangrup";
            // 
            // Form1
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.txtKangrup);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.cmbDogtarih);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.CmbOdaNo);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.CmbBolum);
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
            this.Name = "Form1";
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
        private System.Windows.Forms.ComboBox CmbBolum;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox CmbOdaNo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MaskedTextBox cmbDogtarih;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtKangrup;
    }
}

