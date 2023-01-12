namespace denemee
{
    partial class FrmGirCik
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmGirCik));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.girisIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.girisTarihDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ogrTCDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ogrGirisBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.yurtSistemiDataSet16 = new denemee.YurtSistemiDataSet16();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ogrTCDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ogrCikisBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.yurtSistemiDataSet15 = new denemee.YurtSistemiDataSet15();
            this.TxtTCGir = new System.Windows.Forms.TextBox();
            this.TxtTCCik = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.BtnCikis = new System.Windows.Forms.Button();
            this.BtnGiris = new System.Windows.Forms.Button();
            this.ogrCikisTableAdapter = new denemee.YurtSistemiDataSet15TableAdapters.OgrCikisTableAdapter();
            this.ogrGirisBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ogrCikisBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ogrGirisTableAdapter = new denemee.YurtSistemiDataSet16TableAdapters.OgrGirisTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ogrGirisBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.yurtSistemiDataSet16)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ogrCikisBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.yurtSistemiDataSet15)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ogrGirisBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ogrCikisBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.girisIdDataGridViewTextBoxColumn,
            this.girisTarihDataGridViewTextBoxColumn,
            this.ogrTCDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.ogrGirisBindingSource1;
            this.dataGridView1.Location = new System.Drawing.Point(20, 164);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(457, 255);
            this.dataGridView1.TabIndex = 0;
            // 
            // girisIdDataGridViewTextBoxColumn
            // 
            this.girisIdDataGridViewTextBoxColumn.DataPropertyName = "GirisId";
            this.girisIdDataGridViewTextBoxColumn.HeaderText = "GirisId";
            this.girisIdDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.girisIdDataGridViewTextBoxColumn.Name = "girisIdDataGridViewTextBoxColumn";
            this.girisIdDataGridViewTextBoxColumn.ReadOnly = true;
            this.girisIdDataGridViewTextBoxColumn.Width = 125;
            // 
            // girisTarihDataGridViewTextBoxColumn
            // 
            this.girisTarihDataGridViewTextBoxColumn.DataPropertyName = "GirisTarih";
            this.girisTarihDataGridViewTextBoxColumn.HeaderText = "GirisTarih";
            this.girisTarihDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.girisTarihDataGridViewTextBoxColumn.Name = "girisTarihDataGridViewTextBoxColumn";
            this.girisTarihDataGridViewTextBoxColumn.Width = 125;
            // 
            // ogrTCDataGridViewTextBoxColumn
            // 
            this.ogrTCDataGridViewTextBoxColumn.DataPropertyName = "OgrTC";
            this.ogrTCDataGridViewTextBoxColumn.HeaderText = "OgrTC";
            this.ogrTCDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.ogrTCDataGridViewTextBoxColumn.Name = "ogrTCDataGridViewTextBoxColumn";
            this.ogrTCDataGridViewTextBoxColumn.Width = 125;
            // 
            // ogrGirisBindingSource1
            // 
            this.ogrGirisBindingSource1.DataMember = "OgrGiris";
            this.ogrGirisBindingSource1.DataSource = this.yurtSistemiDataSet16;
            // 
            // yurtSistemiDataSet16
            // 
            this.yurtSistemiDataSet16.DataSetName = "YurtSistemiDataSet16";
            this.yurtSistemiDataSet16.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.ogrTCDataGridViewTextBoxColumn2});
            this.dataGridView2.DataSource = this.ogrCikisBindingSource1;
            this.dataGridView2.Location = new System.Drawing.Point(584, 164);
            this.dataGridView2.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.Size = new System.Drawing.Size(455, 255);
            this.dataGridView2.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "CikisId";
            this.dataGridViewTextBoxColumn1.HeaderText = "CikisId";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 125;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "CikisTarih";
            this.dataGridViewTextBoxColumn2.HeaderText = "CikisTarih";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 125;
            // 
            // ogrTCDataGridViewTextBoxColumn2
            // 
            this.ogrTCDataGridViewTextBoxColumn2.DataPropertyName = "OgrTC";
            this.ogrTCDataGridViewTextBoxColumn2.HeaderText = "OgrTC";
            this.ogrTCDataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.ogrTCDataGridViewTextBoxColumn2.Name = "ogrTCDataGridViewTextBoxColumn2";
            this.ogrTCDataGridViewTextBoxColumn2.Width = 125;
            // 
            // ogrCikisBindingSource1
            // 
            this.ogrCikisBindingSource1.DataMember = "OgrCikis";
            this.ogrCikisBindingSource1.DataSource = this.yurtSistemiDataSet15;
            // 
            // yurtSistemiDataSet15
            // 
            this.yurtSistemiDataSet15.DataSetName = "YurtSistemiDataSet15";
            this.yurtSistemiDataSet15.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // TxtTCGir
            // 
            this.TxtTCGir.Location = new System.Drawing.Point(60, 101);
            this.TxtTCGir.Margin = new System.Windows.Forms.Padding(4);
            this.TxtTCGir.Name = "TxtTCGir";
            this.TxtTCGir.Size = new System.Drawing.Size(192, 22);
            this.TxtTCGir.TabIndex = 2;
            // 
            // TxtTCCik
            // 
            this.TxtTCCik.Location = new System.Drawing.Point(633, 101);
            this.TxtTCCik.Margin = new System.Windows.Forms.Padding(4);
            this.TxtTCCik.Name = "TxtTCCik";
            this.TxtTCCik.Size = new System.Drawing.Size(192, 22);
            this.TxtTCCik.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Moccasin;
            this.label1.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(56, 63);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 24);
            this.label1.TabIndex = 4;
            this.label1.Text = "GİRİŞ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Moccasin;
            this.label2.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(629, 63);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 24);
            this.label2.TabIndex = 5;
            this.label2.Text = "ÇIKIŞ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(16, 98);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 24);
            this.label4.TabIndex = 7;
            this.label4.Text = "TC:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(580, 101);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 24);
            this.label3.TabIndex = 8;
            this.label3.Text = "TC:";
            // 
            // BtnCikis
            // 
            this.BtnCikis.Location = new System.Drawing.Point(859, 98);
            this.BtnCikis.Margin = new System.Windows.Forms.Padding(4);
            this.BtnCikis.Name = "BtnCikis";
            this.BtnCikis.Size = new System.Drawing.Size(100, 28);
            this.BtnCikis.TabIndex = 9;
            this.BtnCikis.Text = "Çıkış Yap";
            this.BtnCikis.UseVisualStyleBackColor = true;
            this.BtnCikis.Click += new System.EventHandler(this.BtnCikis_Click);
            // 
            // BtnGiris
            // 
            this.BtnGiris.Location = new System.Drawing.Point(291, 100);
            this.BtnGiris.Margin = new System.Windows.Forms.Padding(4);
            this.BtnGiris.Name = "BtnGiris";
            this.BtnGiris.Size = new System.Drawing.Size(100, 28);
            this.BtnGiris.TabIndex = 10;
            this.BtnGiris.Text = "Giriş Yap";
            this.BtnGiris.UseVisualStyleBackColor = true;
            this.BtnGiris.Click += new System.EventHandler(this.BtnGiris_Click);
            // 
            // ogrCikisTableAdapter
            // 
            this.ogrCikisTableAdapter.ClearBeforeFill = true;
            // 
            // ogrGirisBindingSource
            // 
            this.ogrGirisBindingSource.DataMember = "OgrGiris";
            // 
            // ogrCikisBindingSource
            // 
            this.ogrCikisBindingSource.DataMember = "OgrCikis";
            // 
            // ogrGirisTableAdapter
            // 
            this.ogrGirisTableAdapter.ClearBeforeFill = true;
            // 
            // FrmGirCik
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.BtnGiris);
            this.Controls.Add(this.BtnCikis);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TxtTCCik);
            this.Controls.Add(this.TxtTCGir);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.dataGridView1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmGirCik";
            this.Text = "Giriş Çıkış kayıtları";
            this.Load += new System.EventHandler(this.FrmGirCik_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ogrGirisBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.yurtSistemiDataSet16)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ogrCikisBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.yurtSistemiDataSet15)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ogrGirisBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ogrCikisBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.TextBox TxtTCGir;
        private System.Windows.Forms.TextBox TxtTCCik;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.BindingSource ogrGirisBindingSource;
        private System.Windows.Forms.BindingSource ogrCikisBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn cikisIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cikisTarihDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ogrTCDataGridViewTextBoxColumn1;
        private System.Windows.Forms.Button BtnCikis;
        private System.Windows.Forms.Button BtnGiris;
        private YurtSistemiDataSet15 yurtSistemiDataSet15;
        private System.Windows.Forms.BindingSource ogrCikisBindingSource1;
        private YurtSistemiDataSet15TableAdapters.OgrCikisTableAdapter ogrCikisTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn ogrTCDataGridViewTextBoxColumn2;
        private YurtSistemiDataSet16 yurtSistemiDataSet16;
        private System.Windows.Forms.BindingSource ogrGirisBindingSource1;
        private YurtSistemiDataSet16TableAdapters.OgrGirisTableAdapter ogrGirisTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn girisIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn girisTarihDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ogrTCDataGridViewTextBoxColumn;
    }
}