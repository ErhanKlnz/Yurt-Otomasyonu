namespace denemee
{
    partial class FrmAnaForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAnaForm));
            this.ogrenciBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.yurtSistemiDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.yurtSistemiDataSet = new denemee.YurtSistemiDataSet();
            this.ogrenciBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.lblDateTimer = new System.Windows.Forms.Label();
            this.lblTimer = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.ogrenciBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.ogrenciTableAdapter = new denemee.YurtSistemiDataSetTableAdapters.OgrenciTableAdapter();
            this.ogrenciBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.yurtSistemiDataSet2 = new denemee.YurtSistemiDataSet2();
            this.dataSet1 = new denemee.DataSet1();
            this.dataSet1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ogrenciTableAdapter1 = new denemee.YurtSistemiDataSet2TableAdapters.OgrenciTableAdapter();
            this.yurtSistemiDataSet3 = new denemee.YurtSistemiDataSet3();
            this.ogrenciBindingSource4 = new System.Windows.Forms.BindingSource(this.components);
            this.ogrenciTableAdapter2 = new denemee.YurtSistemiDataSet3TableAdapters.OgrenciTableAdapter();
            this.yurtSistemiDataSet4 = new denemee.YurtSistemiDataSet4();
            this.ogrenciBindingSource5 = new System.Windows.Forms.BindingSource(this.components);
            this.ogrenciTableAdapter3 = new denemee.YurtSistemiDataSet4TableAdapters.OgrenciTableAdapter();
            this.ogrTelNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ogrTCDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ogrSoyadDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ogrAdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.OgrMail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ogrenciBindingSource6 = new System.Windows.Forms.BindingSource(this.components);
            this.yurtSistemiDataSet5 = new denemee.YurtSistemiDataSet5();
            this.ogrenciTableAdapter4 = new denemee.YurtSistemiDataSet5TableAdapters.OgrenciTableAdapter();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.öğrenciToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.öğrenciEkleVeDüzenleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.öğrenciAraToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bölümlerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bölümDüzenleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ödemeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.personelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.personelEkleVeDüzenleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kullanıcıAyarlarıToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kayıtSildirenÖğrencilerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.ogrenciBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.yurtSistemiDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.yurtSistemiDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ogrenciBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ogrenciBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ogrenciBindingSource3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.yurtSistemiDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.yurtSistemiDataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ogrenciBindingSource4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.yurtSistemiDataSet4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ogrenciBindingSource5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ogrenciBindingSource6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.yurtSistemiDataSet5)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ogrenciBindingSource
            // 
            this.ogrenciBindingSource.DataMember = "Ogrenci";
            this.ogrenciBindingSource.DataSource = this.yurtSistemiDataSetBindingSource;
            // 
            // yurtSistemiDataSetBindingSource
            // 
            this.yurtSistemiDataSetBindingSource.DataSource = this.yurtSistemiDataSet;
            this.yurtSistemiDataSetBindingSource.Position = 0;
            // 
            // yurtSistemiDataSet
            // 
            this.yurtSistemiDataSet.DataSetName = "YurtSistemiDataSet";
            this.yurtSistemiDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ogrenciBindingSource2
            // 
            this.ogrenciBindingSource2.DataMember = "Ogrenci";
            this.ogrenciBindingSource2.DataSource = this.yurtSistemiDataSetBindingSource;
            // 
            // lblDateTimer
            // 
            this.lblDateTimer.AutoSize = true;
            this.lblDateTimer.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblDateTimer.Location = new System.Drawing.Point(465, 99);
            this.lblDateTimer.Name = "lblDateTimer";
            this.lblDateTimer.Size = new System.Drawing.Size(74, 26);
            this.lblDateTimer.TabIndex = 2;
            this.lblDateTimer.Text = "label1";
            // 
            // lblTimer
            // 
            this.lblTimer.AutoSize = true;
            this.lblTimer.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblTimer.Location = new System.Drawing.Point(497, 125);
            this.lblTimer.Name = "lblTimer";
            this.lblTimer.Size = new System.Drawing.Size(74, 26);
            this.lblTimer.TabIndex = 3;
            this.lblTimer.Text = "label2";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // ogrenciBindingSource1
            // 
            this.ogrenciBindingSource1.DataMember = "Ogrenci";
            this.ogrenciBindingSource1.DataSource = this.yurtSistemiDataSet;
            // 
            // ogrenciTableAdapter
            // 
            this.ogrenciTableAdapter.ClearBeforeFill = true;
            // 
            // ogrenciBindingSource3
            // 
            this.ogrenciBindingSource3.DataMember = "Ogrenci";
            this.ogrenciBindingSource3.DataSource = this.yurtSistemiDataSet2;
            // 
            // yurtSistemiDataSet2
            // 
            this.yurtSistemiDataSet2.DataSetName = "YurtSistemiDataSet2";
            this.yurtSistemiDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "DataSet1";
            this.dataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dataSet1BindingSource
            // 
            this.dataSet1BindingSource.DataSource = this.dataSet1;
            this.dataSet1BindingSource.Position = 0;
            // 
            // ogrenciTableAdapter1
            // 
            this.ogrenciTableAdapter1.ClearBeforeFill = true;
            // 
            // yurtSistemiDataSet3
            // 
            this.yurtSistemiDataSet3.DataSetName = "YurtSistemiDataSet3";
            this.yurtSistemiDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ogrenciBindingSource4
            // 
            this.ogrenciBindingSource4.DataMember = "Ogrenci";
            this.ogrenciBindingSource4.DataSource = this.yurtSistemiDataSet3;
            // 
            // ogrenciTableAdapter2
            // 
            this.ogrenciTableAdapter2.ClearBeforeFill = true;
            // 
            // yurtSistemiDataSet4
            // 
            this.yurtSistemiDataSet4.DataSetName = "YurtSistemiDataSet4";
            this.yurtSistemiDataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ogrenciBindingSource5
            // 
            this.ogrenciBindingSource5.DataMember = "Ogrenci";
            this.ogrenciBindingSource5.DataSource = this.yurtSistemiDataSet4;
            // 
            // ogrenciTableAdapter3
            // 
            this.ogrenciTableAdapter3.ClearBeforeFill = true;
            // 
            // ogrTelNoDataGridViewTextBoxColumn
            // 
            this.ogrTelNoDataGridViewTextBoxColumn.DataPropertyName = "OgrTelNo";
            this.ogrTelNoDataGridViewTextBoxColumn.HeaderText = "OgrTelNo";
            this.ogrTelNoDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.ogrTelNoDataGridViewTextBoxColumn.Name = "ogrTelNoDataGridViewTextBoxColumn";
            this.ogrTelNoDataGridViewTextBoxColumn.Width = 125;
            // 
            // ogrTCDataGridViewTextBoxColumn
            // 
            this.ogrTCDataGridViewTextBoxColumn.DataPropertyName = "OgrTC";
            this.ogrTCDataGridViewTextBoxColumn.HeaderText = "OgrTC";
            this.ogrTCDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.ogrTCDataGridViewTextBoxColumn.Name = "ogrTCDataGridViewTextBoxColumn";
            this.ogrTCDataGridViewTextBoxColumn.Width = 125;
            // 
            // ogrSoyadDataGridViewTextBoxColumn
            // 
            this.ogrSoyadDataGridViewTextBoxColumn.DataPropertyName = "OgrSoyad";
            this.ogrSoyadDataGridViewTextBoxColumn.HeaderText = "OgrSoyad";
            this.ogrSoyadDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.ogrSoyadDataGridViewTextBoxColumn.Name = "ogrSoyadDataGridViewTextBoxColumn";
            this.ogrSoyadDataGridViewTextBoxColumn.Width = 125;
            // 
            // ogrAdDataGridViewTextBoxColumn
            // 
            this.ogrAdDataGridViewTextBoxColumn.DataPropertyName = "OgrAd";
            this.ogrAdDataGridViewTextBoxColumn.HeaderText = "OgrAd";
            this.ogrAdDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.ogrAdDataGridViewTextBoxColumn.Name = "ogrAdDataGridViewTextBoxColumn";
            this.ogrAdDataGridViewTextBoxColumn.Width = 125;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ogrAdDataGridViewTextBoxColumn,
            this.ogrSoyadDataGridViewTextBoxColumn,
            this.ogrTCDataGridViewTextBoxColumn,
            this.ogrTelNoDataGridViewTextBoxColumn,
            this.OgrMail});
            this.dataGridView1.DataSource = this.ogrenciBindingSource6;
            this.dataGridView1.Location = new System.Drawing.Point(17, 205);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(662, 261);
            this.dataGridView1.TabIndex = 4;
            // 
            // OgrMail
            // 
            this.OgrMail.DataPropertyName = "OgrMail";
            this.OgrMail.HeaderText = "OgrMail";
            this.OgrMail.MinimumWidth = 6;
            this.OgrMail.Name = "OgrMail";
            this.OgrMail.Width = 125;
            // 
            // ogrenciBindingSource6
            // 
            this.ogrenciBindingSource6.DataMember = "Ogrenci";
            this.ogrenciBindingSource6.DataSource = this.yurtSistemiDataSet5;
            // 
            // yurtSistemiDataSet5
            // 
            this.yurtSistemiDataSet5.DataSetName = "YurtSistemiDataSet5";
            this.yurtSistemiDataSet5.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ogrenciTableAdapter4
            // 
            this.ogrenciTableAdapter4.ClearBeforeFill = true;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.öğrenciToolStripMenuItem,
            this.bölümlerToolStripMenuItem,
            this.ödemeToolStripMenuItem,
            this.personelToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(691, 28);
            this.menuStrip1.TabIndex = 5;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // öğrenciToolStripMenuItem
            // 
            this.öğrenciToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.öğrenciEkleVeDüzenleToolStripMenuItem,
            this.öğrenciAraToolStripMenuItem,
            this.kayıtSildirenÖğrencilerToolStripMenuItem});
            this.öğrenciToolStripMenuItem.Name = "öğrenciToolStripMenuItem";
            this.öğrenciToolStripMenuItem.Size = new System.Drawing.Size(92, 24);
            this.öğrenciToolStripMenuItem.Text = "Öğrenciler";
            // 
            // öğrenciEkleVeDüzenleToolStripMenuItem
            // 
            this.öğrenciEkleVeDüzenleToolStripMenuItem.Name = "öğrenciEkleVeDüzenleToolStripMenuItem";
            this.öğrenciEkleVeDüzenleToolStripMenuItem.Size = new System.Drawing.Size(252, 26);
            this.öğrenciEkleVeDüzenleToolStripMenuItem.Text = "Öğrenci Ekle ve Düzenle";
            this.öğrenciEkleVeDüzenleToolStripMenuItem.Click += new System.EventHandler(this.öğrenciEkleVeDüzenleToolStripMenuItem_Click);
            // 
            // öğrenciAraToolStripMenuItem
            // 
            this.öğrenciAraToolStripMenuItem.Name = "öğrenciAraToolStripMenuItem";
            this.öğrenciAraToolStripMenuItem.Size = new System.Drawing.Size(252, 26);
            this.öğrenciAraToolStripMenuItem.Text = "Öğrenci Ara";
            this.öğrenciAraToolStripMenuItem.Click += new System.EventHandler(this.öğrenciAraToolStripMenuItem_Click);
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
            this.bölümDüzenleToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
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
            // personelToolStripMenuItem
            // 
            this.personelToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.personelEkleVeDüzenleToolStripMenuItem,
            this.kullanıcıAyarlarıToolStripMenuItem});
            this.personelToolStripMenuItem.Name = "personelToolStripMenuItem";
            this.personelToolStripMenuItem.Size = new System.Drawing.Size(212, 24);
            this.personelToolStripMenuItem.Text = "Personel ve Kullanıcı Ayarları";
            // 
            // personelEkleVeDüzenleToolStripMenuItem
            // 
            this.personelEkleVeDüzenleToolStripMenuItem.Name = "personelEkleVeDüzenleToolStripMenuItem";
            this.personelEkleVeDüzenleToolStripMenuItem.Size = new System.Drawing.Size(255, 26);
            this.personelEkleVeDüzenleToolStripMenuItem.Text = "Personel Ekle ve Düzenle";
            this.personelEkleVeDüzenleToolStripMenuItem.Click += new System.EventHandler(this.personelEkleVeDüzenleToolStripMenuItem_Click);
            // 
            // kullanıcıAyarlarıToolStripMenuItem
            // 
            this.kullanıcıAyarlarıToolStripMenuItem.Name = "kullanıcıAyarlarıToolStripMenuItem";
            this.kullanıcıAyarlarıToolStripMenuItem.Size = new System.Drawing.Size(255, 26);
            this.kullanıcıAyarlarıToolStripMenuItem.Text = "Kullanıcı Ayarları";
            this.kullanıcıAyarlarıToolStripMenuItem.Click += new System.EventHandler(this.kullanıcıAyarlarıToolStripMenuItem_Click);
            // 
            // kayıtSildirenÖğrencilerToolStripMenuItem
            // 
            this.kayıtSildirenÖğrencilerToolStripMenuItem.Name = "kayıtSildirenÖğrencilerToolStripMenuItem";
            this.kayıtSildirenÖğrencilerToolStripMenuItem.Size = new System.Drawing.Size(252, 26);
            this.kayıtSildirenÖğrencilerToolStripMenuItem.Text = "Kayıt Sildiren Öğrenciler";
            this.kayıtSildirenÖğrencilerToolStripMenuItem.Click += new System.EventHandler(this.kayıtSildirenÖğrencilerToolStripMenuItem_Click);
            // 
            // FrmAnaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(691, 478);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.lblTimer);
            this.Controls.Add(this.lblDateTimer);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FrmAnaForm";
            this.Text = "Ana Sayfa";
            this.Load += new System.EventHandler(this.FrmAnaForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ogrenciBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.yurtSistemiDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.yurtSistemiDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ogrenciBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ogrenciBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ogrenciBindingSource3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.yurtSistemiDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.yurtSistemiDataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ogrenciBindingSource4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.yurtSistemiDataSet4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ogrenciBindingSource5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ogrenciBindingSource6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.yurtSistemiDataSet5)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.BindingSource yurtSistemiDataSetBindingSource;
        private YurtSistemiDataSet yurtSistemiDataSet;
        private System.Windows.Forms.BindingSource ogrenciBindingSource;
        private YurtSistemiDataSetTableAdapters.OgrenciTableAdapter ogrenciTableAdapter;
        private System.Windows.Forms.BindingSource ogrenciBindingSource1;
        private System.Windows.Forms.Label lblDateTimer;
        private System.Windows.Forms.Label lblTimer;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.BindingSource ogrenciBindingSource2;
        private System.Windows.Forms.BindingSource dataSet1BindingSource;
        private DataSet1 dataSet1;
        private YurtSistemiDataSet2 yurtSistemiDataSet2;
        private System.Windows.Forms.BindingSource ogrenciBindingSource3;
        private YurtSistemiDataSet2TableAdapters.OgrenciTableAdapter ogrenciTableAdapter1;
        private YurtSistemiDataSet3 yurtSistemiDataSet3;
        private System.Windows.Forms.BindingSource ogrenciBindingSource4;
        private YurtSistemiDataSet3TableAdapters.OgrenciTableAdapter ogrenciTableAdapter2;
        private YurtSistemiDataSet4 yurtSistemiDataSet4;
        private System.Windows.Forms.BindingSource ogrenciBindingSource5;
        private YurtSistemiDataSet4TableAdapters.OgrenciTableAdapter ogrenciTableAdapter3;
        private System.Windows.Forms.DataGridViewTextBoxColumn ogrTelNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ogrTCDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ogrSoyadDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ogrAdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridView dataGridView1;
        private YurtSistemiDataSet5 yurtSistemiDataSet5;
        private System.Windows.Forms.BindingSource ogrenciBindingSource6;
        private YurtSistemiDataSet5TableAdapters.OgrenciTableAdapter ogrenciTableAdapter4;
        private System.Windows.Forms.DataGridViewTextBoxColumn OgrMail;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem öğrenciToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem öğrenciEkleVeDüzenleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bölümlerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bölümDüzenleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ödemeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem öğrenciAraToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem personelToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem personelEkleVeDüzenleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kullanıcıAyarlarıToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kayıtSildirenÖğrencilerToolStripMenuItem;
    }
}