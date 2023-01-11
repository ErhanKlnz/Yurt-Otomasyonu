namespace denemee
{
    partial class FrmOgrArama
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmOgrArama));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbxAdaGore = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbxSoyadaGore = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cbxBolumeGore = new System.Windows.Forms.ComboBox();
            this.tbxTCgore = new System.Windows.Forms.TextBox();
            this.pbxTC = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.dgwOgrArama = new System.Windows.Forms.DataGridView();
            this.ogrenciBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.yurtSistemiDataSet5 = new denemee.YurtSistemiDataSet5();
            this.ogrenciTableAdapter = new denemee.YurtSistemiDataSet5TableAdapters.OgrenciTableAdapter();
            this.pbxBolum = new System.Windows.Forms.PictureBox();
            this.pbxAd = new System.Windows.Forms.PictureBox();
            this.pbxSoyad = new System.Windows.Forms.PictureBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbxTC)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgwOgrArama)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ogrenciBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.yurtSistemiDataSet5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxBolum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxAd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxSoyad)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(27, 63);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "TC\'ye Göre Ara";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(39, 114);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Ada Göre Ara";
            // 
            // tbxAdaGore
            // 
            this.tbxAdaGore.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tbxAdaGore.Location = new System.Drawing.Point(168, 114);
            this.tbxAdaGore.Margin = new System.Windows.Forms.Padding(4);
            this.tbxAdaGore.Name = "tbxAdaGore";
            this.tbxAdaGore.Size = new System.Drawing.Size(180, 25);
            this.tbxAdaGore.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(482, 63);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(121, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "Soyad\'a Göre Ara";
            // 
            // tbxSoyadaGore
            // 
            this.tbxSoyadaGore.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tbxSoyadaGore.Location = new System.Drawing.Point(638, 63);
            this.tbxSoyadaGore.Margin = new System.Windows.Forms.Padding(4);
            this.tbxSoyadaGore.Name = "tbxSoyadaGore";
            this.tbxSoyadaGore.Size = new System.Drawing.Size(180, 25);
            this.tbxSoyadaGore.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(482, 114);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(123, 17);
            this.label4.TabIndex = 8;
            this.label4.Text = "Bölüme Göre Ara";
            // 
            // cbxBolumeGore
            // 
            this.cbxBolumeGore.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cbxBolumeGore.FormattingEnabled = true;
            this.cbxBolumeGore.Location = new System.Drawing.Point(638, 109);
            this.cbxBolumeGore.Margin = new System.Windows.Forms.Padding(4);
            this.cbxBolumeGore.Name = "cbxBolumeGore";
            this.cbxBolumeGore.Size = new System.Drawing.Size(180, 25);
            this.cbxBolumeGore.TabIndex = 9;
            // 
            // tbxTCgore
            // 
            this.tbxTCgore.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tbxTCgore.Location = new System.Drawing.Point(168, 63);
            this.tbxTCgore.Margin = new System.Windows.Forms.Padding(4);
            this.tbxTCgore.Name = "tbxTCgore";
            this.tbxTCgore.Size = new System.Drawing.Size(180, 25);
            this.tbxTCgore.TabIndex = 10;
            // 
            // pbxTC
            // 
            this.pbxTC.Image = global::denemee.Properties.Resources.icons8_search_client_90;
            this.pbxTC.Location = new System.Drawing.Point(390, 50);
            this.pbxTC.Margin = new System.Windows.Forms.Padding(4);
            this.pbxTC.Name = "pbxTC";
            this.pbxTC.Size = new System.Drawing.Size(46, 39);
            this.pbxTC.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbxTC.TabIndex = 11;
            this.pbxTC.TabStop = false;
            this.pbxTC.Click += new System.EventHandler(this.pbxTC_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(860, 153);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 17);
            this.label5.TabIndex = 12;
            this.label5.Text = "ARA";
            // 
            // dgwOgrArama
            // 
            this.dgwOgrArama.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwOgrArama.Location = new System.Drawing.Point(19, 203);
            this.dgwOgrArama.Margin = new System.Windows.Forms.Padding(4);
            this.dgwOgrArama.Name = "dgwOgrArama";
            this.dgwOgrArama.RowHeadersWidth = 51;
            this.dgwOgrArama.Size = new System.Drawing.Size(1094, 350);
            this.dgwOgrArama.TabIndex = 13;
            // 
            // ogrenciBindingSource
            // 
            this.ogrenciBindingSource.DataMember = "Ogrenci";
            this.ogrenciBindingSource.DataSource = this.yurtSistemiDataSet5;
            // 
            // yurtSistemiDataSet5
            // 
            this.yurtSistemiDataSet5.DataSetName = "YurtSistemiDataSet5";
            this.yurtSistemiDataSet5.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ogrenciTableAdapter
            // 
            this.ogrenciTableAdapter.ClearBeforeFill = true;
            // 
            // pbxBolum
            // 
            this.pbxBolum.Image = global::denemee.Properties.Resources.icons8_search_client_90;
            this.pbxBolum.Location = new System.Drawing.Point(857, 109);
            this.pbxBolum.Margin = new System.Windows.Forms.Padding(4);
            this.pbxBolum.Name = "pbxBolum";
            this.pbxBolum.Size = new System.Drawing.Size(46, 39);
            this.pbxBolum.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxBolum.TabIndex = 15;
            this.pbxBolum.TabStop = false;
            this.pbxBolum.Click += new System.EventHandler(this.pbxBolum_Click);
            // 
            // pbxAd
            // 
            this.pbxAd.Image = global::denemee.Properties.Resources.icons8_search_client_90;
            this.pbxAd.Location = new System.Drawing.Point(390, 109);
            this.pbxAd.Margin = new System.Windows.Forms.Padding(4);
            this.pbxAd.Name = "pbxAd";
            this.pbxAd.Size = new System.Drawing.Size(46, 39);
            this.pbxAd.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxAd.TabIndex = 16;
            this.pbxAd.TabStop = false;
            this.pbxAd.Click += new System.EventHandler(this.pbxAd_Click);
            // 
            // pbxSoyad
            // 
            this.pbxSoyad.Image = global::denemee.Properties.Resources.icons8_search_client_90;
            this.pbxSoyad.Location = new System.Drawing.Point(857, 50);
            this.pbxSoyad.Margin = new System.Windows.Forms.Padding(4);
            this.pbxSoyad.Name = "pbxSoyad";
            this.pbxSoyad.Size = new System.Drawing.Size(46, 39);
            this.pbxSoyad.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxSoyad.TabIndex = 17;
            this.pbxSoyad.TabStop = false;
            this.pbxSoyad.Click += new System.EventHandler(this.pbxSoyad_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(860, 89);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 17);
            this.label6.TabIndex = 18;
            this.label6.Text = "ARA";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(393, 153);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(41, 17);
            this.label7.TabIndex = 19;
            this.label7.Text = "ARA";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.Location = new System.Drawing.Point(393, 89);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(41, 17);
            this.label8.TabIndex = 20;
            this.label8.Text = "ARA";
            // 
            // FrmOgrArama
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 589);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.pbxSoyad);
            this.Controls.Add(this.pbxAd);
            this.Controls.Add(this.pbxBolum);
            this.Controls.Add(this.dgwOgrArama);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.pbxTC);
            this.Controls.Add(this.tbxTCgore);
            this.Controls.Add(this.cbxBolumeGore);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbxSoyadaGore);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbxAdaGore);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmOgrArama";
            this.Text = "Öğrenci Arama";
            this.Load += new System.EventHandler(this.FrmOgrArama_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbxTC)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgwOgrArama)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ogrenciBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.yurtSistemiDataSet5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxBolum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxAd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxSoyad)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbxAdaGore;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbxSoyadaGore;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbxBolumeGore;
        private System.Windows.Forms.TextBox tbxTCgore;
        private System.Windows.Forms.PictureBox pbxTC;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dgwOgrArama;
        private YurtSistemiDataSet5 yurtSistemiDataSet5;
        private System.Windows.Forms.BindingSource ogrenciBindingSource;
        private YurtSistemiDataSet5TableAdapters.OgrenciTableAdapter ogrenciTableAdapter;
        private System.Windows.Forms.PictureBox pbxBolum;
        private System.Windows.Forms.PictureBox pbxAd;
        private System.Windows.Forms.PictureBox pbxSoyad;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
    }
}