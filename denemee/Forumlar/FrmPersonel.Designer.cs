namespace denemee
{
    partial class FrmPersonel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPersonel));
            this.txtPerSoyad = new System.Windows.Forms.TextBox();
            this.txtPerAd = new System.Windows.Forms.TextBox();
            this.labe2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.mtxtPerTC = new System.Windows.Forms.MaskedTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.mtxtPerTel = new System.Windows.Forms.MaskedTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtPercins = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtPerkan = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtPerDep = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.perAdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.perSoyadDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.perTCDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cinsiyetDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PerTelNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kanGrupDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.departmanDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.personelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.yurtSistemiDataSet7 = new denemee.YurtSistemiDataSet7();
            this.personelTableAdapter = new denemee.YurtSistemiDataSet7TableAdapters.PersonelTableAdapter();
            this.tbxPerAra = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.btnPerAra = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.personelBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.yurtSistemiDataSet7)).BeginInit();
            this.SuspendLayout();
            // 
            // txtPerSoyad
            // 
            this.txtPerSoyad.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtPerSoyad.Location = new System.Drawing.Point(124, 94);
            this.txtPerSoyad.Name = "txtPerSoyad";
            this.txtPerSoyad.Size = new System.Drawing.Size(194, 25);
            this.txtPerSoyad.TabIndex = 12;
            // 
            // txtPerAd
            // 
            this.txtPerAd.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtPerAd.Location = new System.Drawing.Point(124, 58);
            this.txtPerAd.Name = "txtPerAd";
            this.txtPerAd.Size = new System.Drawing.Size(194, 25);
            this.txtPerAd.TabIndex = 11;
            // 
            // labe2
            // 
            this.labe2.AutoSize = true;
            this.labe2.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labe2.Location = new System.Drawing.Point(62, 97);
            this.labe2.Name = "labe2";
            this.labe2.Size = new System.Drawing.Size(55, 17);
            this.labe2.TabIndex = 10;
            this.labe2.Text = "Soyad :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(81, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 17);
            this.label1.TabIndex = 9;
            this.label1.Text = "Ad :";
            // 
            // mtxtPerTC
            // 
            this.mtxtPerTC.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.mtxtPerTC.Location = new System.Drawing.Point(124, 126);
            this.mtxtPerTC.Mask = "00000000000";
            this.mtxtPerTC.Name = "mtxtPerTC";
            this.mtxtPerTC.Size = new System.Drawing.Size(194, 25);
            this.mtxtPerTC.TabIndex = 13;
            this.mtxtPerTC.ValidatingType = typeof(int);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(79, 129);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 17);
            this.label2.TabIndex = 14;
            this.label2.Text = "TC :";
            // 
            // mtxtPerTel
            // 
            this.mtxtPerTel.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.mtxtPerTel.Location = new System.Drawing.Point(124, 188);
            this.mtxtPerTel.Mask = "0000000000";
            this.mtxtPerTel.Name = "mtxtPerTel";
            this.mtxtPerTel.Size = new System.Drawing.Size(194, 25);
            this.mtxtPerTel.TabIndex = 15;
            this.mtxtPerTel.ValidatingType = typeof(int);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(56, 191);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 17);
            this.label3.TabIndex = 16;
            this.label3.Text = "Tel No :";
            // 
            // txtPercins
            // 
            this.txtPercins.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtPercins.Location = new System.Drawing.Point(124, 157);
            this.txtPercins.Name = "txtPercins";
            this.txtPercins.Size = new System.Drawing.Size(194, 25);
            this.txtPercins.TabIndex = 17;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(10, 160);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(107, 17);
            this.label4.TabIndex = 18;
            this.label4.Text = "Cinsiyet (E,K):";
            // 
            // txtPerkan
            // 
            this.txtPerkan.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtPerkan.Location = new System.Drawing.Point(124, 219);
            this.txtPerkan.Name = "txtPerkan";
            this.txtPerkan.Size = new System.Drawing.Size(194, 25);
            this.txtPerkan.TabIndex = 19;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(28, 222);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(89, 17);
            this.label5.TabIndex = 20;
            this.label5.Text = "Kan Grubu :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(28, 252);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(93, 17);
            this.label6.TabIndex = 21;
            this.label6.Text = "Departman  :";
            // 
            // txtPerDep
            // 
            this.txtPerDep.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtPerDep.Location = new System.Drawing.Point(124, 249);
            this.txtPerDep.Name = "txtPerDep";
            this.txtPerDep.Size = new System.Drawing.Size(194, 25);
            this.txtPerDep.TabIndex = 22;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.Location = new System.Drawing.Point(121, 304);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(121, 38);
            this.button1.TabIndex = 23;
            this.button1.Text = "Kaydet";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button2.Location = new System.Drawing.Point(429, 304);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(121, 38);
            this.button2.TabIndex = 24;
            this.button2.Text = "Sil";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button3.Location = new System.Drawing.Point(272, 304);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(121, 38);
            this.button3.TabIndex = 25;
            this.button3.Text = "Güncelle";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.perAdDataGridViewTextBoxColumn,
            this.perSoyadDataGridViewTextBoxColumn,
            this.perTCDataGridViewTextBoxColumn,
            this.cinsiyetDataGridViewTextBoxColumn,
            this.PerTelNo,
            this.kanGrupDataGridViewTextBoxColumn,
            this.departmanDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.personelBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(329, 58);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(776, 216);
            this.dataGridView1.TabIndex = 26;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // perAdDataGridViewTextBoxColumn
            // 
            this.perAdDataGridViewTextBoxColumn.DataPropertyName = "PerAd";
            this.perAdDataGridViewTextBoxColumn.HeaderText = "PerAd";
            this.perAdDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.perAdDataGridViewTextBoxColumn.Name = "perAdDataGridViewTextBoxColumn";
            this.perAdDataGridViewTextBoxColumn.Width = 82;
            // 
            // perSoyadDataGridViewTextBoxColumn
            // 
            this.perSoyadDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.perSoyadDataGridViewTextBoxColumn.DataPropertyName = "PerSoyad";
            this.perSoyadDataGridViewTextBoxColumn.HeaderText = "PerSoyad";
            this.perSoyadDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.perSoyadDataGridViewTextBoxColumn.Name = "perSoyadDataGridViewTextBoxColumn";
            this.perSoyadDataGridViewTextBoxColumn.Width = 97;
            // 
            // perTCDataGridViewTextBoxColumn
            // 
            this.perTCDataGridViewTextBoxColumn.DataPropertyName = "PerTC";
            this.perTCDataGridViewTextBoxColumn.HeaderText = "PerTC";
            this.perTCDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.perTCDataGridViewTextBoxColumn.Name = "perTCDataGridViewTextBoxColumn";
            this.perTCDataGridViewTextBoxColumn.Width = 82;
            // 
            // cinsiyetDataGridViewTextBoxColumn
            // 
            this.cinsiyetDataGridViewTextBoxColumn.DataPropertyName = "Cinsiyet";
            this.cinsiyetDataGridViewTextBoxColumn.HeaderText = "Cinsiyet";
            this.cinsiyetDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.cinsiyetDataGridViewTextBoxColumn.Name = "cinsiyetDataGridViewTextBoxColumn";
            this.cinsiyetDataGridViewTextBoxColumn.Width = 96;
            // 
            // PerTelNo
            // 
            this.PerTelNo.DataPropertyName = "PerTelNo";
            this.PerTelNo.HeaderText = "PerTelNo";
            this.PerTelNo.MinimumWidth = 6;
            this.PerTelNo.Name = "PerTelNo";
            this.PerTelNo.Width = 125;
            // 
            // kanGrupDataGridViewTextBoxColumn
            // 
            this.kanGrupDataGridViewTextBoxColumn.DataPropertyName = "KanGrup";
            this.kanGrupDataGridViewTextBoxColumn.HeaderText = "KanGrup";
            this.kanGrupDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.kanGrupDataGridViewTextBoxColumn.Name = "kanGrupDataGridViewTextBoxColumn";
            this.kanGrupDataGridViewTextBoxColumn.Width = 95;
            // 
            // departmanDataGridViewTextBoxColumn
            // 
            this.departmanDataGridViewTextBoxColumn.DataPropertyName = "Departman";
            this.departmanDataGridViewTextBoxColumn.HeaderText = "Departman";
            this.departmanDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.departmanDataGridViewTextBoxColumn.Name = "departmanDataGridViewTextBoxColumn";
            this.departmanDataGridViewTextBoxColumn.Width = 82;
            // 
            // personelBindingSource
            // 
            this.personelBindingSource.DataMember = "Personel";
            this.personelBindingSource.DataSource = this.yurtSistemiDataSet7;
            // 
            // yurtSistemiDataSet7
            // 
            this.yurtSistemiDataSet7.DataSetName = "YurtSistemiDataSet7";
            this.yurtSistemiDataSet7.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // personelTableAdapter
            // 
            this.personelTableAdapter.ClearBeforeFill = true;
            // 
            // tbxPerAra
            // 
            this.tbxPerAra.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tbxPerAra.Location = new System.Drawing.Point(703, 326);
            this.tbxPerAra.Name = "tbxPerAra";
            this.tbxPerAra.Size = new System.Drawing.Size(194, 25);
            this.tbxPerAra.TabIndex = 28;
            this.tbxPerAra.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbxPerAra_KeyDown);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(660, 329);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(36, 17);
            this.label7.TabIndex = 27;
            this.label7.Text = "Ad :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.Location = new System.Drawing.Point(745, 304);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(93, 17);
            this.label8.TabIndex = 29;
            this.label8.Text = "Personel Ara";
            // 
            // btnPerAra
            // 
            this.btnPerAra.Location = new System.Drawing.Point(921, 317);
            this.btnPerAra.Name = "btnPerAra";
            this.btnPerAra.Size = new System.Drawing.Size(95, 33);
            this.btnPerAra.TabIndex = 30;
            this.btnPerAra.Text = "Ara";
            this.btnPerAra.UseVisualStyleBackColor = true;
            this.btnPerAra.Click += new System.EventHandler(this.btnPerAra_Click);
            // 
            // FrmPersonel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(1132, 392);
            this.Controls.Add(this.btnPerAra);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.tbxPerAra);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtPerDep);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtPerkan);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtPercins);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.mtxtPerTel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.mtxtPerTC);
            this.Controls.Add(this.txtPerSoyad);
            this.Controls.Add(this.txtPerAd);
            this.Controls.Add(this.labe2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmPersonel";
            this.Text = "Personel Düzenle";
            this.Load += new System.EventHandler(this.FrmPersonel_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.personelBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.yurtSistemiDataSet7)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtPerSoyad;
        private System.Windows.Forms.TextBox txtPerAd;
        private System.Windows.Forms.Label labe2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox mtxtPerTC;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MaskedTextBox mtxtPerTel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtPercins;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtPerkan;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtPerDep;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private YurtSistemiDataSet7 yurtSistemiDataSet7;
        private System.Windows.Forms.BindingSource personelBindingSource;
        private YurtSistemiDataSet7TableAdapters.PersonelTableAdapter personelTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn perAdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn perSoyadDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn perTCDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cinsiyetDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn PerTelNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn kanGrupDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn departmanDataGridViewTextBoxColumn;
        private System.Windows.Forms.TextBox tbxPerAra;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnPerAra;
    }
}