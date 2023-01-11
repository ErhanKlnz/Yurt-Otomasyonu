namespace denemee
{
    partial class sifreislemleri
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(sifreislemleri));
            this.txtsifre = new System.Windows.Forms.TextBox();
            this.txtkullanıcıadi = new System.Windows.Forms.TextBox();
            this.labe2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbyöneticiTC = new System.Windows.Forms.ComboBox();
            this.btnkaydet = new System.Windows.Forms.Button();
            this.btngüncelle = new System.Windows.Forms.Button();
            this.btnsil = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.kullaniciAdiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sifreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.perTCDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.yoneticiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.yurtSistemiDataSet6 = new denemee.YurtSistemiDataSet6();
            this.yoneticiTableAdapter = new denemee.YurtSistemiDataSet6TableAdapters.YoneticiTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.yoneticiBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.yurtSistemiDataSet6)).BeginInit();
            this.SuspendLayout();
            // 
            // txtsifre
            // 
            this.txtsifre.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtsifre.Location = new System.Drawing.Point(195, 141);
            this.txtsifre.Name = "txtsifre";
            this.txtsifre.Size = new System.Drawing.Size(194, 25);
            this.txtsifre.TabIndex = 8;
            this.txtsifre.UseSystemPasswordChar = true;
            // 
            // txtkullanıcıadi
            // 
            this.txtkullanıcıadi.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtkullanıcıadi.Location = new System.Drawing.Point(195, 100);
            this.txtkullanıcıadi.Name = "txtkullanıcıadi";
            this.txtkullanıcıadi.Size = new System.Drawing.Size(194, 25);
            this.txtkullanıcıadi.TabIndex = 7;
            // 
            // labe2
            // 
            this.labe2.AutoSize = true;
            this.labe2.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labe2.Location = new System.Drawing.Point(133, 144);
            this.labe2.Name = "labe2";
            this.labe2.Size = new System.Drawing.Size(47, 17);
            this.labe2.TabIndex = 6;
            this.labe2.Text = "Şifre :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(83, 103);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 17);
            this.label1.TabIndex = 5;
            this.label1.Text = "Kullanıcı Adı:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(83, 74);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 17);
            this.label3.TabIndex = 9;
            this.label3.Text = "Yönetici TC :";
            // 
            // cmbyöneticiTC
            // 
            this.cmbyöneticiTC.FormattingEnabled = true;
            this.cmbyöneticiTC.Location = new System.Drawing.Point(195, 70);
            this.cmbyöneticiTC.Name = "cmbyöneticiTC";
            this.cmbyöneticiTC.Size = new System.Drawing.Size(194, 24);
            this.cmbyöneticiTC.TabIndex = 12;
            // 
            // btnkaydet
            // 
            this.btnkaydet.Location = new System.Drawing.Point(57, 198);
            this.btnkaydet.Name = "btnkaydet";
            this.btnkaydet.Size = new System.Drawing.Size(96, 35);
            this.btnkaydet.TabIndex = 13;
            this.btnkaydet.Text = "Kaydet";
            this.btnkaydet.UseVisualStyleBackColor = true;
            this.btnkaydet.Click += new System.EventHandler(this.btnkaydet_Click);
            // 
            // btngüncelle
            // 
            this.btngüncelle.Location = new System.Drawing.Point(315, 198);
            this.btngüncelle.Name = "btngüncelle";
            this.btngüncelle.Size = new System.Drawing.Size(96, 35);
            this.btngüncelle.TabIndex = 14;
            this.btngüncelle.Text = "Güncelle";
            this.btngüncelle.UseVisualStyleBackColor = true;
            this.btngüncelle.Click += new System.EventHandler(this.btngüncelle_Click);
            // 
            // btnsil
            // 
            this.btnsil.Location = new System.Drawing.Point(182, 198);
            this.btnsil.Name = "btnsil";
            this.btnsil.Size = new System.Drawing.Size(96, 35);
            this.btnsil.TabIndex = 15;
            this.btnsil.Text = "Sil";
            this.btnsil.UseVisualStyleBackColor = true;
            this.btnsil.Click += new System.EventHandler(this.btnsil_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.kullaniciAdiDataGridViewTextBoxColumn,
            this.sifreDataGridViewTextBoxColumn,
            this.perTCDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.yoneticiBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(34, 280);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(405, 157);
            this.dataGridView1.TabIndex = 16;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // kullaniciAdiDataGridViewTextBoxColumn
            // 
            this.kullaniciAdiDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.kullaniciAdiDataGridViewTextBoxColumn.DataPropertyName = "KullaniciAdi";
            this.kullaniciAdiDataGridViewTextBoxColumn.HeaderText = "KullaniciAdi";
            this.kullaniciAdiDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.kullaniciAdiDataGridViewTextBoxColumn.Name = "kullaniciAdiDataGridViewTextBoxColumn";
            this.kullaniciAdiDataGridViewTextBoxColumn.Width = 105;
            // 
            // sifreDataGridViewTextBoxColumn
            // 
            this.sifreDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.sifreDataGridViewTextBoxColumn.DataPropertyName = "Sifre";
            this.sifreDataGridViewTextBoxColumn.HeaderText = "Sifre";
            this.sifreDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.sifreDataGridViewTextBoxColumn.Name = "sifreDataGridViewTextBoxColumn";
            this.sifreDataGridViewTextBoxColumn.Width = 63;
            // 
            // perTCDataGridViewTextBoxColumn
            // 
            this.perTCDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.perTCDataGridViewTextBoxColumn.DataPropertyName = "PerTC";
            this.perTCDataGridViewTextBoxColumn.HeaderText = "PerTC";
            this.perTCDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.perTCDataGridViewTextBoxColumn.Name = "perTCDataGridViewTextBoxColumn";
            this.perTCDataGridViewTextBoxColumn.Width = 75;
            // 
            // yoneticiBindingSource
            // 
            this.yoneticiBindingSource.DataMember = "Yonetici";
            this.yoneticiBindingSource.DataSource = this.yurtSistemiDataSet6;
            // 
            // yurtSistemiDataSet6
            // 
            this.yurtSistemiDataSet6.DataSetName = "YurtSistemiDataSet6";
            this.yurtSistemiDataSet6.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // yoneticiTableAdapter
            // 
            this.yoneticiTableAdapter.ClearBeforeFill = true;
            // 
            // sifreislemleri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(487, 513);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnsil);
            this.Controls.Add(this.btngüncelle);
            this.Controls.Add(this.btnkaydet);
            this.Controls.Add(this.cmbyöneticiTC);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtsifre);
            this.Controls.Add(this.txtkullanıcıadi);
            this.Controls.Add(this.labe2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "sifreislemleri";
            this.Text = "Kullanıcı İşlemleri";
            this.Load += new System.EventHandler(this.sifreislemleri_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.yoneticiBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.yurtSistemiDataSet6)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtsifre;
        private System.Windows.Forms.TextBox txtkullanıcıadi;
        private System.Windows.Forms.Label labe2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbyöneticiTC;
        private System.Windows.Forms.Button btnkaydet;
        private System.Windows.Forms.Button btngüncelle;
        private System.Windows.Forms.Button btnsil;
        private System.Windows.Forms.DataGridView dataGridView1;
        private YurtSistemiDataSet6 yurtSistemiDataSet6;
        private System.Windows.Forms.BindingSource yoneticiBindingSource;
        private YurtSistemiDataSet6TableAdapters.YoneticiTableAdapter yoneticiTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn kullaniciAdiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sifreDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn perTCDataGridViewTextBoxColumn;
    }
}