﻿namespace denemee
{
    partial class FrmBolumler
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmBolumler));
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pcbBolumEkle = new System.Windows.Forms.PictureBox();
            this.pcbBolumDuzenle = new System.Windows.Forms.PictureBox();
            this.pcbBolumSil = new System.Windows.Forms.PictureBox();
            this.lblBolumId = new System.Windows.Forms.Label();
            this.txtBolumId = new System.Windows.Forms.TextBox();
            this.txtBolumAd = new System.Windows.Forms.TextBox();
            this.lblBolumAd = new System.Windows.Forms.Label();
            this.dgwBolumler = new System.Windows.Forms.DataGridView();
            this.bolumIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bolumAdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bolumBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.yurtSistemiDataSet10 = new denemee.YurtSistemiDataSet10();
            this.bolumBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.yurtSistemiDataSet1 = new denemee.YurtSistemiDataSet1();
            this.bolumTableAdapter = new denemee.YurtSistemiDataSet1TableAdapters.BolumTableAdapter();
            this.bolumTableAdapter1 = new denemee.YurtSistemiDataSet10TableAdapters.BolumTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbBolumEkle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbBolumDuzenle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbBolumSil)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgwBolumler)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bolumBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.yurtSistemiDataSet10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bolumBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.yurtSistemiDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(-708, 137);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(107, 98);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // pcbBolumEkle
            // 
            this.pcbBolumEkle.Image = global::denemee.Properties.Resources.ekle1;
            this.pcbBolumEkle.Location = new System.Drawing.Point(59, 426);
            this.pcbBolumEkle.Margin = new System.Windows.Forms.Padding(4);
            this.pcbBolumEkle.Name = "pcbBolumEkle";
            this.pcbBolumEkle.Size = new System.Drawing.Size(107, 98);
            this.pcbBolumEkle.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pcbBolumEkle.TabIndex = 2;
            this.pcbBolumEkle.TabStop = false;
            this.pcbBolumEkle.Click += new System.EventHandler(this.pcbBolumEkle_Click);
            // 
            // pcbBolumDuzenle
            // 
            this.pcbBolumDuzenle.Image = global::denemee.Properties.Resources.guncelle;
            this.pcbBolumDuzenle.Location = new System.Drawing.Point(173, 426);
            this.pcbBolumDuzenle.Margin = new System.Windows.Forms.Padding(4);
            this.pcbBolumDuzenle.Name = "pcbBolumDuzenle";
            this.pcbBolumDuzenle.Size = new System.Drawing.Size(107, 98);
            this.pcbBolumDuzenle.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pcbBolumDuzenle.TabIndex = 3;
            this.pcbBolumDuzenle.TabStop = false;
            this.pcbBolumDuzenle.Click += new System.EventHandler(this.pcbBolumDuzenle_Click);
            // 
            // pcbBolumSil
            // 
            this.pcbBolumSil.Image = global::denemee.Properties.Resources.cikar;
            this.pcbBolumSil.Location = new System.Drawing.Point(288, 426);
            this.pcbBolumSil.Margin = new System.Windows.Forms.Padding(4);
            this.pcbBolumSil.Name = "pcbBolumSil";
            this.pcbBolumSil.Size = new System.Drawing.Size(107, 98);
            this.pcbBolumSil.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pcbBolumSil.TabIndex = 4;
            this.pcbBolumSil.TabStop = false;
            this.pcbBolumSil.Click += new System.EventHandler(this.pcbBolumSil_Click);
            // 
            // lblBolumId
            // 
            this.lblBolumId.AutoSize = true;
            this.lblBolumId.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblBolumId.Location = new System.Drawing.Point(19, 310);
            this.lblBolumId.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBolumId.Name = "lblBolumId";
            this.lblBolumId.Size = new System.Drawing.Size(72, 17);
            this.lblBolumId.TabIndex = 5;
            this.lblBolumId.Text = "Bölüm ID";
            // 
            // txtBolumId
            // 
            this.txtBolumId.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtBolumId.Location = new System.Drawing.Point(104, 306);
            this.txtBolumId.Margin = new System.Windows.Forms.Padding(4);
            this.txtBolumId.Name = "txtBolumId";
            this.txtBolumId.Size = new System.Drawing.Size(289, 25);
            this.txtBolumId.TabIndex = 6;
            // 
            // txtBolumAd
            // 
            this.txtBolumAd.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtBolumAd.Location = new System.Drawing.Point(104, 340);
            this.txtBolumAd.Margin = new System.Windows.Forms.Padding(4);
            this.txtBolumAd.Name = "txtBolumAd";
            this.txtBolumAd.Size = new System.Drawing.Size(289, 25);
            this.txtBolumAd.TabIndex = 8;
            // 
            // lblBolumAd
            // 
            this.lblBolumAd.AutoSize = true;
            this.lblBolumAd.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblBolumAd.Location = new System.Drawing.Point(19, 342);
            this.lblBolumAd.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBolumAd.Name = "lblBolumAd";
            this.lblBolumAd.Size = new System.Drawing.Size(73, 17);
            this.lblBolumAd.TabIndex = 7;
            this.lblBolumAd.Text = "Bölüm Ad";
            // 
            // dgwBolumler
            // 
            this.dgwBolumler.AutoGenerateColumns = false;
            this.dgwBolumler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwBolumler.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.bolumIdDataGridViewTextBoxColumn,
            this.bolumAdDataGridViewTextBoxColumn});
            this.dgwBolumler.DataSource = this.bolumBindingSource1;
            this.dgwBolumler.Location = new System.Drawing.Point(452, 29);
            this.dgwBolumler.Margin = new System.Windows.Forms.Padding(4);
            this.dgwBolumler.Name = "dgwBolumler";
            this.dgwBolumler.RowHeadersWidth = 51;
            this.dgwBolumler.Size = new System.Drawing.Size(413, 495);
            this.dgwBolumler.TabIndex = 9;
            this.dgwBolumler.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgwBolumler_CellClick);
            // 
            // bolumIdDataGridViewTextBoxColumn
            // 
            this.bolumIdDataGridViewTextBoxColumn.DataPropertyName = "Bolum_Id";
            this.bolumIdDataGridViewTextBoxColumn.HeaderText = "Bölüm ID";
            this.bolumIdDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.bolumIdDataGridViewTextBoxColumn.Name = "bolumIdDataGridViewTextBoxColumn";
            this.bolumIdDataGridViewTextBoxColumn.ReadOnly = true;
            this.bolumIdDataGridViewTextBoxColumn.Width = 80;
            // 
            // bolumAdDataGridViewTextBoxColumn
            // 
            this.bolumAdDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.bolumAdDataGridViewTextBoxColumn.DataPropertyName = "BolumAd";
            this.bolumAdDataGridViewTextBoxColumn.HeaderText = "Bölümün Adı";
            this.bolumAdDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.bolumAdDataGridViewTextBoxColumn.Name = "bolumAdDataGridViewTextBoxColumn";
            // 
            // bolumBindingSource1
            // 
            this.bolumBindingSource1.DataMember = "Bolum";
            this.bolumBindingSource1.DataSource = this.yurtSistemiDataSet10;
            // 
            // yurtSistemiDataSet10
            // 
            this.yurtSistemiDataSet10.DataSetName = "YurtSistemiDataSet10";
            this.yurtSistemiDataSet10.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bolumBindingSource
            // 
            this.bolumBindingSource.DataMember = "Bolum";
            this.bolumBindingSource.DataSource = this.yurtSistemiDataSet1;
            // 
            // yurtSistemiDataSet1
            // 
            this.yurtSistemiDataSet1.DataSetName = "YurtSistemiDataSet1";
            this.yurtSistemiDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bolumTableAdapter
            // 
            this.bolumTableAdapter.ClearBeforeFill = true;
            // 
            // bolumTableAdapter1
            // 
            this.bolumTableAdapter1.ClearBeforeFill = true;
            // 
            // FrmBolumler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(881, 554);
            this.Controls.Add(this.dgwBolumler);
            this.Controls.Add(this.txtBolumAd);
            this.Controls.Add(this.lblBolumAd);
            this.Controls.Add(this.txtBolumId);
            this.Controls.Add(this.lblBolumId);
            this.Controls.Add(this.pcbBolumSil);
            this.Controls.Add(this.pcbBolumDuzenle);
            this.Controls.Add(this.pcbBolumEkle);
            this.Controls.Add(this.pictureBox2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmBolumler";
            this.Text = "Bölümleri Düzenle";
            this.Load += new System.EventHandler(this.FrmBolumler_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbBolumEkle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbBolumDuzenle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbBolumSil)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgwBolumler)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bolumBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.yurtSistemiDataSet10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bolumBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.yurtSistemiDataSet1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pcbBolumEkle;
        private System.Windows.Forms.PictureBox pcbBolumDuzenle;
        private System.Windows.Forms.PictureBox pcbBolumSil;
        private System.Windows.Forms.Label lblBolumId;
        private System.Windows.Forms.TextBox txtBolumId;
        private System.Windows.Forms.TextBox txtBolumAd;
        private System.Windows.Forms.Label lblBolumAd;
        private System.Windows.Forms.DataGridView dgwBolumler;
        private YurtSistemiDataSet1 yurtSistemiDataSet1;
        private System.Windows.Forms.BindingSource bolumBindingSource;
        private YurtSistemiDataSet1TableAdapters.BolumTableAdapter bolumTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn bolumIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bolumAdDataGridViewTextBoxColumn;
        private YurtSistemiDataSet10 yurtSistemiDataSet10;
        private System.Windows.Forms.BindingSource bolumBindingSource1;
        private YurtSistemiDataSet10TableAdapters.BolumTableAdapter bolumTableAdapter1;
    }
}