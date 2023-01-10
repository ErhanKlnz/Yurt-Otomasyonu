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
            this.components = new System.ComponentModel.Container();
            this.lblOgrAd = new System.Windows.Forms.Label();
            this.lblOgrSoyad = new System.Windows.Forms.Label();
            this.lblOgrTc = new System.Windows.Forms.Label();
            this.lblDogtarih = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.txtOgrAd = new System.Windows.Forms.TextBox();
            this.txtOgrSoyad = new System.Windows.Forms.TextBox();
            this.txtOgrKan = new System.Windows.Forms.TextBox();
            this.txtOgrMail = new System.Windows.Forms.TextBox();
            this.txtVeliAdSoyad = new System.Windows.Forms.TextBox();
            this.mTxtOgrTc = new System.Windows.Forms.MaskedTextBox();
            this.mTxtOgrTel = new System.Windows.Forms.MaskedTextBox();
            this.mTxtDogTarih = new System.Windows.Forms.MaskedTextBox();
            this.mTxtVeliTel = new System.Windows.Forms.MaskedTextBox();
            this.cbxOgrBolum = new System.Windows.Forms.ComboBox();
            this.cbxOdaNo = new System.Windows.Forms.ComboBox();
            this.rTxtAdres = new System.Windows.Forms.RichTextBox();
            this.btnOgrEkle = new System.Windows.Forms.Button();
            this.btnDuzenle = new System.Windows.Forms.Button();
            this.btnSil = new System.Windows.Forms.Button();
            this.dgwOgrIslem = new System.Windows.Forms.DataGridView();
            this.ogrAdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ogrSoyadDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ogrTCDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ogrTelNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ogrenciBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.yurtSistemiDataSet3 = new denemee.YurtSistemiDataSet3();
            this.ogrenciTableAdapter = new denemee.YurtSistemiDataSet3TableAdapters.OgrenciTableAdapter();
            this.yurtSistemiDataSet8 = new denemee.YurtSistemiDataSet8();
            this.ogrenciBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.ogrenciTableAdapter1 = new denemee.YurtSistemiDataSet8TableAdapters.OgrenciTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dgwOgrIslem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ogrenciBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.yurtSistemiDataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.yurtSistemiDataSet8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ogrenciBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblOgrAd
            // 
            this.lblOgrAd.AutoSize = true;
            this.lblOgrAd.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblOgrAd.Location = new System.Drawing.Point(37, 528);
            this.lblOgrAd.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblOgrAd.Name = "lblOgrAd";
            this.lblOgrAd.Size = new System.Drawing.Size(87, 17);
            this.lblOgrAd.TabIndex = 0;
            this.lblOgrAd.Text = "Öğrenci Adı";
            // 
            // lblOgrSoyad
            // 
            this.lblOgrSoyad.AutoSize = true;
            this.lblOgrSoyad.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblOgrSoyad.Location = new System.Drawing.Point(13, 558);
            this.lblOgrSoyad.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblOgrSoyad.Name = "lblOgrSoyad";
            this.lblOgrSoyad.Size = new System.Drawing.Size(107, 17);
            this.lblOgrSoyad.TabIndex = 1;
            this.lblOgrSoyad.Text = "Öğrenci Soyadı";
            // 
            // lblOgrTc
            // 
            this.lblOgrTc.AutoSize = true;
            this.lblOgrTc.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblOgrTc.Location = new System.Drawing.Point(38, 591);
            this.lblOgrTc.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblOgrTc.Name = "lblOgrTc";
            this.lblOgrTc.Size = new System.Drawing.Size(86, 17);
            this.lblOgrTc.TabIndex = 2;
            this.lblOgrTc.Text = "Öğrenci TC";
            // 
            // lblDogtarih
            // 
            this.lblDogtarih.AutoSize = true;
            this.lblDogtarih.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblDogtarih.Location = new System.Drawing.Point(26, 621);
            this.lblDogtarih.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDogtarih.Name = "lblDogtarih";
            this.lblDogtarih.Size = new System.Drawing.Size(97, 17);
            this.lblDogtarih.TabIndex = 3;
            this.lblDogtarih.Text = "Doğum Tarihi";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(85, 650);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 17);
            this.label5.TabIndex = 4;
            this.label5.Text = "Mail";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(38, 677);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(80, 17);
            this.label6.TabIndex = 5;
            this.label6.Text = "Telefon No";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(513, 528);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(59, 17);
            this.label7.TabIndex = 6;
            this.label7.Text = "Bölümü";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.Location = new System.Drawing.Point(493, 557);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(80, 17);
            this.label8.TabIndex = 7;
            this.label8.Text = "Kan Grubu";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.Location = new System.Drawing.Point(470, 586);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(101, 17);
            this.label9.TabIndex = 8;
            this.label9.Text = "Oda Numarası";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label10.Location = new System.Drawing.Point(467, 613);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(97, 17);
            this.label10.TabIndex = 9;
            this.label10.Text = "Veli Ad Soyad";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label11.Location = new System.Drawing.Point(486, 647);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(81, 17);
            this.label11.TabIndex = 10;
            this.label11.Text = "Veli Tel No";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label12.Location = new System.Drawing.Point(872, 533);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(48, 17);
            this.label12.TabIndex = 11;
            this.label12.Text = "Adres";
            // 
            // txtOgrAd
            // 
            this.txtOgrAd.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtOgrAd.Location = new System.Drawing.Point(147, 525);
            this.txtOgrAd.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtOgrAd.Name = "txtOgrAd";
            this.txtOgrAd.Size = new System.Drawing.Size(226, 25);
            this.txtOgrAd.TabIndex = 12;
            // 
            // txtOgrSoyad
            // 
            this.txtOgrSoyad.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtOgrSoyad.Location = new System.Drawing.Point(147, 557);
            this.txtOgrSoyad.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtOgrSoyad.Name = "txtOgrSoyad";
            this.txtOgrSoyad.Size = new System.Drawing.Size(226, 25);
            this.txtOgrSoyad.TabIndex = 13;
            // 
            // txtOgrKan
            // 
            this.txtOgrKan.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtOgrKan.Location = new System.Drawing.Point(598, 557);
            this.txtOgrKan.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtOgrKan.Name = "txtOgrKan";
            this.txtOgrKan.Size = new System.Drawing.Size(226, 25);
            this.txtOgrKan.TabIndex = 14;
            // 
            // txtOgrMail
            // 
            this.txtOgrMail.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtOgrMail.Location = new System.Drawing.Point(147, 647);
            this.txtOgrMail.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtOgrMail.Name = "txtOgrMail";
            this.txtOgrMail.Size = new System.Drawing.Size(226, 25);
            this.txtOgrMail.TabIndex = 15;
            // 
            // txtVeliAdSoyad
            // 
            this.txtVeliAdSoyad.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtVeliAdSoyad.Location = new System.Drawing.Point(598, 615);
            this.txtVeliAdSoyad.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtVeliAdSoyad.Name = "txtVeliAdSoyad";
            this.txtVeliAdSoyad.Size = new System.Drawing.Size(226, 25);
            this.txtVeliAdSoyad.TabIndex = 16;
            // 
            // mTxtOgrTc
            // 
            this.mTxtOgrTc.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.mTxtOgrTc.Location = new System.Drawing.Point(147, 586);
            this.mTxtOgrTc.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.mTxtOgrTc.Mask = "00000000000";
            this.mTxtOgrTc.Name = "mTxtOgrTc";
            this.mTxtOgrTc.Size = new System.Drawing.Size(226, 25);
            this.mTxtOgrTc.TabIndex = 17;
            // 
            // mTxtOgrTel
            // 
            this.mTxtOgrTel.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.mTxtOgrTel.Location = new System.Drawing.Point(147, 675);
            this.mTxtOgrTel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.mTxtOgrTel.Mask = "(999) 000-0000";
            this.mTxtOgrTel.Name = "mTxtOgrTel";
            this.mTxtOgrTel.Size = new System.Drawing.Size(226, 25);
            this.mTxtOgrTel.TabIndex = 18;
            // 
            // mTxtDogTarih
            // 
            this.mTxtDogTarih.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.mTxtDogTarih.Location = new System.Drawing.Point(147, 618);
            this.mTxtDogTarih.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.mTxtDogTarih.Mask = "00/00/0000";
            this.mTxtDogTarih.Name = "mTxtDogTarih";
            this.mTxtDogTarih.Size = new System.Drawing.Size(226, 25);
            this.mTxtDogTarih.TabIndex = 19;
            this.mTxtDogTarih.ValidatingType = typeof(System.DateTime);
            // 
            // mTxtVeliTel
            // 
            this.mTxtVeliTel.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.mTxtVeliTel.Location = new System.Drawing.Point(598, 647);
            this.mTxtVeliTel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.mTxtVeliTel.Mask = "(999) 000-0000";
            this.mTxtVeliTel.Name = "mTxtVeliTel";
            this.mTxtVeliTel.Size = new System.Drawing.Size(226, 25);
            this.mTxtVeliTel.TabIndex = 20;
            // 
            // cbxOgrBolum
            // 
            this.cbxOgrBolum.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cbxOgrBolum.FormattingEnabled = true;
            this.cbxOgrBolum.Location = new System.Drawing.Point(598, 525);
            this.cbxOgrBolum.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbxOgrBolum.Name = "cbxOgrBolum";
            this.cbxOgrBolum.Size = new System.Drawing.Size(226, 25);
            this.cbxOgrBolum.TabIndex = 21;
            // 
            // cbxOdaNo
            // 
            this.cbxOdaNo.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cbxOdaNo.FormattingEnabled = true;
            this.cbxOdaNo.Location = new System.Drawing.Point(598, 584);
            this.cbxOdaNo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbxOdaNo.Name = "cbxOdaNo";
            this.cbxOdaNo.Size = new System.Drawing.Size(226, 25);
            this.cbxOdaNo.TabIndex = 22;
            // 
            // rTxtAdres
            // 
            this.rTxtAdres.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rTxtAdres.Location = new System.Drawing.Point(928, 530);
            this.rTxtAdres.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rTxtAdres.Name = "rTxtAdres";
            this.rTxtAdres.Size = new System.Drawing.Size(223, 113);
            this.rTxtAdres.TabIndex = 23;
            this.rTxtAdres.Text = "";
            // 
            // btnOgrEkle
            // 
            this.btnOgrEkle.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnOgrEkle.Location = new System.Drawing.Point(928, 307);
            this.btnOgrEkle.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnOgrEkle.Name = "btnOgrEkle";
            this.btnOgrEkle.Size = new System.Drawing.Size(152, 25);
            this.btnOgrEkle.TabIndex = 24;
            this.btnOgrEkle.Text = "Ekle";
            this.btnOgrEkle.UseVisualStyleBackColor = true;
            this.btnOgrEkle.Click += new System.EventHandler(this.btnOgrEkle_Click_2);
            // 
            // btnDuzenle
            // 
            this.btnDuzenle.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnDuzenle.Location = new System.Drawing.Point(928, 373);
            this.btnDuzenle.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnDuzenle.Name = "btnDuzenle";
            this.btnDuzenle.Size = new System.Drawing.Size(152, 25);
            this.btnDuzenle.TabIndex = 25;
            this.btnDuzenle.Text = "Düzenle";
            this.btnDuzenle.UseVisualStyleBackColor = true;
            this.btnDuzenle.Click += new System.EventHandler(this.btnDuzenle_Click);
            // 
            // btnSil
            // 
            this.btnSil.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSil.Location = new System.Drawing.Point(928, 433);
            this.btnSil.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(152, 25);
            this.btnSil.TabIndex = 26;
            this.btnSil.Text = "Sil";
            this.btnSil.UseVisualStyleBackColor = true;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // dgwOgrIslem
            // 
            this.dgwOgrIslem.AutoGenerateColumns = false;
            this.dgwOgrIslem.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwOgrIslem.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ogrAdDataGridViewTextBoxColumn,
            this.ogrSoyadDataGridViewTextBoxColumn,
            this.ogrTCDataGridViewTextBoxColumn,
            this.ogrTelNoDataGridViewTextBoxColumn});
            this.dgwOgrIslem.DataSource = this.ogrenciBindingSource1;
            this.dgwOgrIslem.Location = new System.Drawing.Point(13, 30);
            this.dgwOgrIslem.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgwOgrIslem.Name = "dgwOgrIslem";
            this.dgwOgrIslem.RowHeadersWidth = 51;
            this.dgwOgrIslem.Size = new System.Drawing.Size(700, 386);
            this.dgwOgrIslem.TabIndex = 27;
            this.dgwOgrIslem.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgwOgrIslem_CellClick_1);
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
            // ogrTCDataGridViewTextBoxColumn
            // 
            this.ogrTCDataGridViewTextBoxColumn.DataPropertyName = "OgrTC";
            this.ogrTCDataGridViewTextBoxColumn.HeaderText = "OgrTC";
            this.ogrTCDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.ogrTCDataGridViewTextBoxColumn.Name = "ogrTCDataGridViewTextBoxColumn";
            this.ogrTCDataGridViewTextBoxColumn.Width = 125;
            // 
            // ogrTelNoDataGridViewTextBoxColumn
            // 
            this.ogrTelNoDataGridViewTextBoxColumn.DataPropertyName = "OgrTelNo";
            this.ogrTelNoDataGridViewTextBoxColumn.HeaderText = "OgrTelNo";
            this.ogrTelNoDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.ogrTelNoDataGridViewTextBoxColumn.Name = "ogrTelNoDataGridViewTextBoxColumn";
            this.ogrTelNoDataGridViewTextBoxColumn.Width = 125;
            // 
            // ogrenciBindingSource
            // 
            this.ogrenciBindingSource.DataMember = "Ogrenci";
            this.ogrenciBindingSource.DataSource = this.yurtSistemiDataSet3;
            // 
            // yurtSistemiDataSet3
            // 
            this.yurtSistemiDataSet3.DataSetName = "YurtSistemiDataSet3";
            this.yurtSistemiDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ogrenciTableAdapter
            // 
            this.ogrenciTableAdapter.ClearBeforeFill = true;
            // 
            // yurtSistemiDataSet8
            // 
            this.yurtSistemiDataSet8.DataSetName = "YurtSistemiDataSet8";
            this.yurtSistemiDataSet8.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ogrenciBindingSource1
            // 
            this.ogrenciBindingSource1.DataMember = "Ogrenci";
            this.ogrenciBindingSource1.DataSource = this.yurtSistemiDataSet8;
            // 
            // ogrenciTableAdapter1
            // 
            this.ogrenciTableAdapter1.ClearBeforeFill = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1197, 718);
            this.Controls.Add(this.dgwOgrIslem);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.btnDuzenle);
            this.Controls.Add(this.btnOgrEkle);
            this.Controls.Add(this.rTxtAdres);
            this.Controls.Add(this.cbxOdaNo);
            this.Controls.Add(this.cbxOgrBolum);
            this.Controls.Add(this.mTxtVeliTel);
            this.Controls.Add(this.mTxtDogTarih);
            this.Controls.Add(this.mTxtOgrTel);
            this.Controls.Add(this.mTxtOgrTc);
            this.Controls.Add(this.txtVeliAdSoyad);
            this.Controls.Add(this.txtOgrMail);
            this.Controls.Add(this.txtOgrKan);
            this.Controls.Add(this.txtOgrSoyad);
            this.Controls.Add(this.txtOgrAd);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblDogtarih);
            this.Controls.Add(this.lblOgrTc);
            this.Controls.Add(this.lblOgrSoyad);
            this.Controls.Add(this.lblOgrAd);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgwOgrIslem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ogrenciBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.yurtSistemiDataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.yurtSistemiDataSet8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ogrenciBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblOgrAd;
        private System.Windows.Forms.Label lblOgrSoyad;
        private System.Windows.Forms.Label lblOgrTc;
        private System.Windows.Forms.Label lblDogtarih;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtOgrAd;
        private System.Windows.Forms.TextBox txtOgrSoyad;
        private System.Windows.Forms.TextBox txtOgrKan;
        private System.Windows.Forms.TextBox txtOgrMail;
        private System.Windows.Forms.TextBox txtVeliAdSoyad;
        private System.Windows.Forms.MaskedTextBox mTxtOgrTc;
        private System.Windows.Forms.MaskedTextBox mTxtOgrTel;
        private System.Windows.Forms.MaskedTextBox mTxtDogTarih;
        private System.Windows.Forms.MaskedTextBox mTxtVeliTel;
        private System.Windows.Forms.ComboBox cbxOgrBolum;
        private System.Windows.Forms.ComboBox cbxOdaNo;
        private System.Windows.Forms.RichTextBox rTxtAdres;
        private System.Windows.Forms.Button btnOgrEkle;
        private System.Windows.Forms.Button btnDuzenle;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.DataGridView dgwOgrIslem;
        private YurtSistemiDataSet3 yurtSistemiDataSet3;
        private System.Windows.Forms.BindingSource ogrenciBindingSource;
        private YurtSistemiDataSet3TableAdapters.OgrenciTableAdapter ogrenciTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn ogrIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ogrAdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ogrSoyadDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ogrTCDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dogTarihDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ogrMailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ogrTelNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bolumIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kanGrupDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn odaNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn veliAdSoyadDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn veliTelNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ogrAdresDataGridViewTextBoxColumn;
        private YurtSistemiDataSet8 yurtSistemiDataSet8;
        private System.Windows.Forms.BindingSource ogrenciBindingSource1;
        private YurtSistemiDataSet8TableAdapters.OgrenciTableAdapter ogrenciTableAdapter1;
    }
}