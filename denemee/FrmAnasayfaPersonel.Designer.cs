namespace denemee
{
    partial class FrmAnasayfaPersonel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAnasayfaPersonel));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ogrIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ogrAdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ogrSoyadDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OgrMail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dogTarihDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bolumIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.odaNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ogrenciBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.yurtSistemiDataSet14 = new denemee.YurtSistemiDataSet14();
            this.lblTimer = new System.Windows.Forms.Label();
            this.lblDateTimer = new System.Windows.Forms.Label();
            this.ogrenciTableAdapter = new denemee.YurtSistemiDataSet14TableAdapters.OgrenciTableAdapter();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.öğrenciToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.öğrenciEkleVeDüzenleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.öğrenciAraToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kayıtSildirenÖğrencilerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.girişÇıkışKayıtlarıToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bölümlerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bölümDüzenleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ödemeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ogrenciBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.yurtSistemiDataSet14)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ogrIdDataGridViewTextBoxColumn,
            this.ogrAdDataGridViewTextBoxColumn,
            this.ogrSoyadDataGridViewTextBoxColumn,
            this.OgrMail,
            this.dogTarihDataGridViewTextBoxColumn,
            this.bolumIdDataGridViewTextBoxColumn,
            this.odaNoDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.ogrenciBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 174);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(662, 261);
            this.dataGridView1.TabIndex = 7;
            // 
            // ogrIdDataGridViewTextBoxColumn
            // 
            this.ogrIdDataGridViewTextBoxColumn.DataPropertyName = "OgrId";
            this.ogrIdDataGridViewTextBoxColumn.HeaderText = "OgrId";
            this.ogrIdDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.ogrIdDataGridViewTextBoxColumn.Name = "ogrIdDataGridViewTextBoxColumn";
            this.ogrIdDataGridViewTextBoxColumn.ReadOnly = true;
            this.ogrIdDataGridViewTextBoxColumn.Width = 125;
            // 
            // ogrAdDataGridViewTextBoxColumn
            // 
            this.ogrAdDataGridViewTextBoxColumn.DataPropertyName = "OgrAd";
            this.ogrAdDataGridViewTextBoxColumn.HeaderText = "OgrAd";
            this.ogrAdDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.ogrAdDataGridViewTextBoxColumn.Name = "ogrAdDataGridViewTextBoxColumn";
            this.ogrAdDataGridViewTextBoxColumn.Width = 125;
            // 
            // ogrSoyadDataGridViewTextBoxColumn
            // 
            this.ogrSoyadDataGridViewTextBoxColumn.DataPropertyName = "OgrSoyad";
            this.ogrSoyadDataGridViewTextBoxColumn.HeaderText = "OgrSoyad";
            this.ogrSoyadDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.ogrSoyadDataGridViewTextBoxColumn.Name = "ogrSoyadDataGridViewTextBoxColumn";
            this.ogrSoyadDataGridViewTextBoxColumn.Width = 125;
            // 
            // OgrMail
            // 
            this.OgrMail.DataPropertyName = "OgrMail";
            this.OgrMail.HeaderText = "OgrMail";
            this.OgrMail.MinimumWidth = 6;
            this.OgrMail.Name = "OgrMail";
            this.OgrMail.Width = 125;
            // 
            // dogTarihDataGridViewTextBoxColumn
            // 
            this.dogTarihDataGridViewTextBoxColumn.DataPropertyName = "DogTarih";
            this.dogTarihDataGridViewTextBoxColumn.HeaderText = "DogTarih";
            this.dogTarihDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.dogTarihDataGridViewTextBoxColumn.Name = "dogTarihDataGridViewTextBoxColumn";
            this.dogTarihDataGridViewTextBoxColumn.Width = 125;
            // 
            // bolumIdDataGridViewTextBoxColumn
            // 
            this.bolumIdDataGridViewTextBoxColumn.DataPropertyName = "Bolum_Id";
            this.bolumIdDataGridViewTextBoxColumn.HeaderText = "Bolum_Id";
            this.bolumIdDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.bolumIdDataGridViewTextBoxColumn.Name = "bolumIdDataGridViewTextBoxColumn";
            this.bolumIdDataGridViewTextBoxColumn.Width = 125;
            // 
            // odaNoDataGridViewTextBoxColumn
            // 
            this.odaNoDataGridViewTextBoxColumn.DataPropertyName = "OdaNo";
            this.odaNoDataGridViewTextBoxColumn.HeaderText = "OdaNo";
            this.odaNoDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.odaNoDataGridViewTextBoxColumn.Name = "odaNoDataGridViewTextBoxColumn";
            this.odaNoDataGridViewTextBoxColumn.Width = 125;
            // 
            // ogrenciBindingSource
            // 
            this.ogrenciBindingSource.DataMember = "Ogrenci";
            this.ogrenciBindingSource.DataSource = this.yurtSistemiDataSet14;
            // 
            // yurtSistemiDataSet14
            // 
            this.yurtSistemiDataSet14.DataSetName = "YurtSistemiDataSet14";
            this.yurtSistemiDataSet14.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // lblTimer
            // 
            this.lblTimer.AutoSize = true;
            this.lblTimer.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblTimer.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblTimer.Location = new System.Drawing.Point(448, 103);
            this.lblTimer.Name = "lblTimer";
            this.lblTimer.Size = new System.Drawing.Size(74, 26);
            this.lblTimer.TabIndex = 6;
            this.lblTimer.Text = "label2";
            // 
            // lblDateTimer
            // 
            this.lblDateTimer.AutoSize = true;
            this.lblDateTimer.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblDateTimer.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblDateTimer.Location = new System.Drawing.Point(416, 77);
            this.lblDateTimer.Name = "lblDateTimer";
            this.lblDateTimer.Size = new System.Drawing.Size(74, 26);
            this.lblDateTimer.TabIndex = 5;
            this.lblDateTimer.Text = "label1";
            // 
            // ogrenciTableAdapter
            // 
            this.ogrenciTableAdapter.ClearBeforeFill = true;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.öğrenciToolStripMenuItem,
            this.bölümlerToolStripMenuItem,
            this.ödemeToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(703, 28);
            this.menuStrip1.TabIndex = 8;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // öğrenciToolStripMenuItem
            // 
            this.öğrenciToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.öğrenciEkleVeDüzenleToolStripMenuItem,
            this.öğrenciAraToolStripMenuItem,
            this.kayıtSildirenÖğrencilerToolStripMenuItem,
            this.girişÇıkışKayıtlarıToolStripMenuItem});
            this.öğrenciToolStripMenuItem.Name = "öğrenciToolStripMenuItem";
            this.öğrenciToolStripMenuItem.Size = new System.Drawing.Size(92, 24);
            this.öğrenciToolStripMenuItem.Text = "Öğrenciler";
            // 
            // öğrenciEkleVeDüzenleToolStripMenuItem
            // 
            this.öğrenciEkleVeDüzenleToolStripMenuItem.Name = "öğrenciEkleVeDüzenleToolStripMenuItem";
            this.öğrenciEkleVeDüzenleToolStripMenuItem.Size = new System.Drawing.Size(257, 26);
            this.öğrenciEkleVeDüzenleToolStripMenuItem.Text = "Öğrenci Ekle ve Düzenle";
            this.öğrenciEkleVeDüzenleToolStripMenuItem.Click += new System.EventHandler(this.öğrenciEkleVeDüzenleToolStripMenuItem_Click);
            // 
            // öğrenciAraToolStripMenuItem
            // 
            this.öğrenciAraToolStripMenuItem.Name = "öğrenciAraToolStripMenuItem";
            this.öğrenciAraToolStripMenuItem.Size = new System.Drawing.Size(257, 26);
            this.öğrenciAraToolStripMenuItem.Text = "Öğrenci Ara";
            this.öğrenciAraToolStripMenuItem.Click += new System.EventHandler(this.öğrenciAraToolStripMenuItem_Click);
            // 
            // kayıtSildirenÖğrencilerToolStripMenuItem
            // 
            this.kayıtSildirenÖğrencilerToolStripMenuItem.Name = "kayıtSildirenÖğrencilerToolStripMenuItem";
            this.kayıtSildirenÖğrencilerToolStripMenuItem.Size = new System.Drawing.Size(257, 26);
            this.kayıtSildirenÖğrencilerToolStripMenuItem.Text = "Kaydı Silinmiş Öğrenciler";
            this.kayıtSildirenÖğrencilerToolStripMenuItem.Click += new System.EventHandler(this.kayıtSildirenÖğrencilerToolStripMenuItem_Click);
            // 
            // girişÇıkışKayıtlarıToolStripMenuItem
            // 
            this.girişÇıkışKayıtlarıToolStripMenuItem.Name = "girişÇıkışKayıtlarıToolStripMenuItem";
            this.girişÇıkışKayıtlarıToolStripMenuItem.Size = new System.Drawing.Size(257, 26);
            this.girişÇıkışKayıtlarıToolStripMenuItem.Text = "Giriş Çıkış Kayıtları";
            this.girişÇıkışKayıtlarıToolStripMenuItem.Click += new System.EventHandler(this.girişÇıkışKayıtlarıToolStripMenuItem_Click);
            // 
            // bölümlerToolStripMenuItem
            // 
            this.bölümlerToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bölümDüzenleToolStripMenuItem});
            this.bölümlerToolStripMenuItem.Name = "bölümlerToolStripMenuItem";
            this.bölümlerToolStripMenuItem.Size = new System.Drawing.Size(83, 24);
            this.bölümlerToolStripMenuItem.Text = "Bölümler";
            // 
            // bölümDüzenleToolStripMenuItem
            // 
            this.bölümDüzenleToolStripMenuItem.Name = "bölümDüzenleToolStripMenuItem";
            this.bölümDüzenleToolStripMenuItem.Size = new System.Drawing.Size(193, 26);
            this.bölümDüzenleToolStripMenuItem.Text = "Bölüm Düzenle";
            this.bölümDüzenleToolStripMenuItem.Click += new System.EventHandler(this.bölümDüzenleToolStripMenuItem_Click);
            // 
            // ödemeToolStripMenuItem
            // 
            this.ödemeToolStripMenuItem.Name = "ödemeToolStripMenuItem";
            this.ödemeToolStripMenuItem.Size = new System.Drawing.Size(72, 24);
            this.ödemeToolStripMenuItem.Text = "Ödeme";
            this.ödemeToolStripMenuItem.Click += new System.EventHandler(this.ödemeToolStripMenuItem_Click);
            // 
            // timer2
            // 
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // FrmAnasayfaPersonel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(703, 447);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.lblTimer);
            this.Controls.Add(this.lblDateTimer);
            this.ForeColor = System.Drawing.Color.AliceBlue;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmAnasayfaPersonel";
            this.Text = "Ana Sayfa";
            this.Load += new System.EventHandler(this.FrmAnasayfaPersonel_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ogrenciBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.yurtSistemiDataSet14)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label lblTimer;
        private System.Windows.Forms.Label lblDateTimer;
        private YurtSistemiDataSet14 yurtSistemiDataSet14;
        private System.Windows.Forms.BindingSource ogrenciBindingSource;
        private YurtSistemiDataSet14TableAdapters.OgrenciTableAdapter ogrenciTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn ogrIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ogrAdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ogrSoyadDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn OgrMail;
        private System.Windows.Forms.DataGridViewTextBoxColumn dogTarihDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bolumIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn odaNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem öğrenciToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem öğrenciEkleVeDüzenleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem öğrenciAraToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kayıtSildirenÖğrencilerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bölümlerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bölümDüzenleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ödemeToolStripMenuItem;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.ToolStripMenuItem girişÇıkışKayıtlarıToolStripMenuItem;
    }
}