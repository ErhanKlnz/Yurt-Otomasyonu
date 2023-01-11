namespace denemee
{
    partial class FrmAdminGiris
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAdminGiris));
            this.label1 = new System.Windows.Forms.Label();
            this.labe2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.txtkullanıcıadi = new System.Windows.Forms.TextBox();
            this.txtadmsifre = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pbxTC = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxTC)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(127, 140);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kullanıcı Adı:";
            // 
            // labe2
            // 
            this.labe2.AutoSize = true;
            this.labe2.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labe2.Location = new System.Drawing.Point(177, 181);
            this.labe2.Name = "labe2";
            this.labe2.Size = new System.Drawing.Size(47, 17);
            this.labe2.TabIndex = 1;
            this.labe2.Text = "Şifre :";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.Location = new System.Drawing.Point(279, 236);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(108, 46);
            this.button1.TabIndex = 2;
            this.button1.Text = "Giriş Yap";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtkullanıcıadi
            // 
            this.txtkullanıcıadi.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtkullanıcıadi.Location = new System.Drawing.Point(262, 137);
            this.txtkullanıcıadi.Name = "txtkullanıcıadi";
            this.txtkullanıcıadi.Size = new System.Drawing.Size(143, 25);
            this.txtkullanıcıadi.TabIndex = 3;
            // 
            // txtadmsifre
            // 
            this.txtadmsifre.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtadmsifre.Location = new System.Drawing.Point(262, 181);
            this.txtadmsifre.Name = "txtadmsifre";
            this.txtadmsifre.Size = new System.Drawing.Size(143, 25);
            this.txtadmsifre.TabIndex = 4;
            this.txtadmsifre.UseSystemPasswordChar = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(84, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(386, 26);
            this.label2.TabIndex = 5;
            this.label2.Text = "Öğrenci Yurt Sisteminine Yönetici Girişi";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::denemee.Properties.Resources.Iconsmind_Outline_Students;
            this.pictureBox1.Location = new System.Drawing.Point(13, 34);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(64, 54);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 14;
            this.pictureBox1.TabStop = false;
            // 
            // pbxTC
            // 
            this.pbxTC.Image = global::denemee.Properties.Resources.Admin_Profile_PNG;
            this.pbxTC.Location = new System.Drawing.Point(26, 143);
            this.pbxTC.Margin = new System.Windows.Forms.Padding(4);
            this.pbxTC.Name = "pbxTC";
            this.pbxTC.Size = new System.Drawing.Size(64, 55);
            this.pbxTC.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbxTC.TabIndex = 13;
            this.pbxTC.TabStop = false;
            // 
            // FrmAdminGiris
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(513, 325);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pbxTC);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtadmsifre);
            this.Controls.Add(this.txtkullanıcıadi);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.labe2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmAdminGiris";
            this.Text = "Giriş";
            this.Load += new System.EventHandler(this.FrmAdminGiris_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxTC)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labe2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtkullanıcıadi;
        private System.Windows.Forms.TextBox txtadmsifre;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pbxTC;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}