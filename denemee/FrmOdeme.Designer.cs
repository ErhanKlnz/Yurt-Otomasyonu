namespace denemee
{
    partial class FrmOdeme
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmOdeme));
            this.label1 = new System.Windows.Forms.Label();
            this.txtOgrTcOdeme = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.txtOdenen = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtKalanBorc = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dgwOgrOdeme = new System.Windows.Forms.DataGridView();
            this.ogrenciBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.yurtSistemiDataSet4 = new denemee.YurtSistemiDataSet4();
            this.ogrenciTableAdapter = new denemee.YurtSistemiDataSet4TableAdapters.OgrenciTableAdapter();
            this.txtOgrAdOdeme = new System.Windows.Forms.TextBox();
            this.lblOgrAdOdeme = new System.Windows.Forms.Label();
            this.btnOdemeAl = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgwOgrOdeme)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ogrenciBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.yurtSistemiDataSet4)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(41, 76);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Öğrenci TC";
            // 
            // txtOgrTcOdeme
            // 
            this.txtOgrTcOdeme.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtOgrTcOdeme.Location = new System.Drawing.Point(119, 76);
            this.txtOgrTcOdeme.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtOgrTcOdeme.Name = "txtOgrTcOdeme";
            this.txtOgrTcOdeme.Size = new System.Drawing.Size(160, 25);
            this.txtOgrTcOdeme.TabIndex = 1;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // txtOdenen
            // 
            this.txtOdenen.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtOdenen.Location = new System.Drawing.Point(383, 45);
            this.txtOdenen.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtOdenen.Name = "txtOdenen";
            this.txtOdenen.Size = new System.Drawing.Size(160, 25);
            this.txtOdenen.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(303, 50);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Ödenen";
            // 
            // txtKalanBorc
            // 
            this.txtKalanBorc.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtKalanBorc.Location = new System.Drawing.Point(383, 81);
            this.txtKalanBorc.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtKalanBorc.Name = "txtKalanBorc";
            this.txtKalanBorc.Size = new System.Drawing.Size(160, 25);
            this.txtKalanBorc.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(293, 84);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Kalan Borç";
            // 
            // dgwOgrOdeme
            // 
            this.dgwOgrOdeme.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwOgrOdeme.Location = new System.Drawing.Point(25, 190);
            this.dgwOgrOdeme.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dgwOgrOdeme.Name = "dgwOgrOdeme";
            this.dgwOgrOdeme.RowHeadersWidth = 51;
            this.dgwOgrOdeme.Size = new System.Drawing.Size(550, 239);
            this.dgwOgrOdeme.TabIndex = 7;
            this.dgwOgrOdeme.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgwOgrOdeme_CellClick);
            // 
            // ogrenciBindingSource
            // 
            this.ogrenciBindingSource.DataMember = "Ogrenci";
            this.ogrenciBindingSource.DataSource = this.yurtSistemiDataSet4;
            // 
            // yurtSistemiDataSet4
            // 
            this.yurtSistemiDataSet4.DataSetName = "YurtSistemiDataSet4";
            this.yurtSistemiDataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ogrenciTableAdapter
            // 
            this.ogrenciTableAdapter.ClearBeforeFill = true;
            // 
            // txtOgrAdOdeme
            // 
            this.txtOgrAdOdeme.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtOgrAdOdeme.Location = new System.Drawing.Point(119, 46);
            this.txtOgrAdOdeme.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtOgrAdOdeme.Name = "txtOgrAdOdeme";
            this.txtOgrAdOdeme.Size = new System.Drawing.Size(160, 25);
            this.txtOgrAdOdeme.TabIndex = 9;
            // 
            // lblOgrAdOdeme
            // 
            this.lblOgrAdOdeme.AutoSize = true;
            this.lblOgrAdOdeme.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblOgrAdOdeme.Location = new System.Drawing.Point(41, 46);
            this.lblOgrAdOdeme.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblOgrAdOdeme.Name = "lblOgrAdOdeme";
            this.lblOgrAdOdeme.Size = new System.Drawing.Size(87, 17);
            this.lblOgrAdOdeme.TabIndex = 8;
            this.lblOgrAdOdeme.Text = "Öğrenci Adı";
            // 
            // btnOdemeAl
            // 
            this.btnOdemeAl.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnOdemeAl.Location = new System.Drawing.Point(201, 125);
            this.btnOdemeAl.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnOdemeAl.Name = "btnOdemeAl";
            this.btnOdemeAl.Size = new System.Drawing.Size(184, 39);
            this.btnOdemeAl.TabIndex = 10;
            this.btnOdemeAl.Text = "Ödeme Yap";
            this.btnOdemeAl.UseVisualStyleBackColor = true;
            this.btnOdemeAl.Click += new System.EventHandler(this.btnOdemeAl_Click);
            // 
            // FrmOdeme
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(611, 486);
            this.Controls.Add(this.btnOdemeAl);
            this.Controls.Add(this.txtOgrAdOdeme);
            this.Controls.Add(this.lblOgrAdOdeme);
            this.Controls.Add(this.dgwOgrOdeme);
            this.Controls.Add(this.txtKalanBorc);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtOdenen);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtOgrTcOdeme);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "FrmOdeme";
            this.Text = "Ödeme";
            this.Load += new System.EventHandler(this.frmOdeme_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgwOgrOdeme)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ogrenciBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.yurtSistemiDataSet4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtOgrTcOdeme;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.TextBox txtOdenen;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtKalanBorc;
        private System.Windows.Forms.Label label3;
        private YurtSistemiDataSet4 yurtSistemiDataSet4;
        private System.Windows.Forms.BindingSource ogrenciBindingSource;
        private YurtSistemiDataSet4TableAdapters.OgrenciTableAdapter ogrenciTableAdapter;
        private System.Windows.Forms.DataGridView dgwOgrOdeme;
        private System.Windows.Forms.TextBox txtOgrAdOdeme;
        private System.Windows.Forms.Label lblOgrAdOdeme;
        private System.Windows.Forms.Button btnOdemeAl;
    }
}