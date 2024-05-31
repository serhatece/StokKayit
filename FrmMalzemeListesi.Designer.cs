
namespace StokKayit
{
    partial class FrmMalzemeListesi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMalzemeListesi));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.stokKayitDataSet2 = new StokKayit.StokKayitDataSet2();
            this.malzemelerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.malzemelerTableAdapter = new StokKayit.StokKayitDataSet2TableAdapters.MalzemelerTableAdapter();
            this.malzemeKoduDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.malzemeAdiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.yillikSatisDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.birimFiyatDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.minStokDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.teminSüresiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stokKayitDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.malzemelerBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.malzemeKoduDataGridViewTextBoxColumn,
            this.malzemeAdiDataGridViewTextBoxColumn,
            this.yillikSatisDataGridViewTextBoxColumn,
            this.birimFiyatDataGridViewTextBoxColumn,
            this.minStokDataGridViewTextBoxColumn,
            this.teminSüresiDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.malzemelerBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(785, 334);
            this.dataGridView1.TabIndex = 0;
            // 
            // stokKayitDataSet2
            // 
            this.stokKayitDataSet2.DataSetName = "StokKayitDataSet2";
            this.stokKayitDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // malzemelerBindingSource
            // 
            this.malzemelerBindingSource.DataMember = "Malzemeler";
            this.malzemelerBindingSource.DataSource = this.stokKayitDataSet2;
            // 
            // malzemelerTableAdapter
            // 
            this.malzemelerTableAdapter.ClearBeforeFill = true;
            // 
            // malzemeKoduDataGridViewTextBoxColumn
            // 
            this.malzemeKoduDataGridViewTextBoxColumn.DataPropertyName = "MalzemeKodu";
            this.malzemeKoduDataGridViewTextBoxColumn.HeaderText = "MalzemeKodu";
            this.malzemeKoduDataGridViewTextBoxColumn.Name = "malzemeKoduDataGridViewTextBoxColumn";
            this.malzemeKoduDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // malzemeAdiDataGridViewTextBoxColumn
            // 
            this.malzemeAdiDataGridViewTextBoxColumn.DataPropertyName = "MalzemeAdi";
            this.malzemeAdiDataGridViewTextBoxColumn.HeaderText = "MalzemeAdi";
            this.malzemeAdiDataGridViewTextBoxColumn.Name = "malzemeAdiDataGridViewTextBoxColumn";
            this.malzemeAdiDataGridViewTextBoxColumn.ReadOnly = true;
            this.malzemeAdiDataGridViewTextBoxColumn.Width = 140;
            // 
            // yillikSatisDataGridViewTextBoxColumn
            // 
            this.yillikSatisDataGridViewTextBoxColumn.DataPropertyName = "YillikSatis";
            this.yillikSatisDataGridViewTextBoxColumn.HeaderText = "YillikSatis";
            this.yillikSatisDataGridViewTextBoxColumn.Name = "yillikSatisDataGridViewTextBoxColumn";
            this.yillikSatisDataGridViewTextBoxColumn.ReadOnly = true;
            this.yillikSatisDataGridViewTextBoxColumn.Width = 125;
            // 
            // birimFiyatDataGridViewTextBoxColumn
            // 
            this.birimFiyatDataGridViewTextBoxColumn.DataPropertyName = "BirimFiyat";
            this.birimFiyatDataGridViewTextBoxColumn.HeaderText = "BirimFiyat";
            this.birimFiyatDataGridViewTextBoxColumn.Name = "birimFiyatDataGridViewTextBoxColumn";
            this.birimFiyatDataGridViewTextBoxColumn.ReadOnly = true;
            this.birimFiyatDataGridViewTextBoxColumn.Width = 125;
            // 
            // minStokDataGridViewTextBoxColumn
            // 
            this.minStokDataGridViewTextBoxColumn.DataPropertyName = "MinStok";
            this.minStokDataGridViewTextBoxColumn.HeaderText = "MinStok";
            this.minStokDataGridViewTextBoxColumn.Name = "minStokDataGridViewTextBoxColumn";
            this.minStokDataGridViewTextBoxColumn.ReadOnly = true;
            this.minStokDataGridViewTextBoxColumn.Width = 125;
            // 
            // teminSüresiDataGridViewTextBoxColumn
            // 
            this.teminSüresiDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.teminSüresiDataGridViewTextBoxColumn.DataPropertyName = "TeminSüresi";
            this.teminSüresiDataGridViewTextBoxColumn.HeaderText = "TeminSüresi";
            this.teminSüresiDataGridViewTextBoxColumn.Name = "teminSüresiDataGridViewTextBoxColumn";
            this.teminSüresiDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // FrmMalzemeListesi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(785, 334);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FrmMalzemeListesi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Malzeme Listesi";
            this.Load += new System.EventHandler(this.FrmMalzemeListesi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stokKayitDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.malzemelerBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private StokKayitDataSet2 stokKayitDataSet2;
        private System.Windows.Forms.BindingSource malzemelerBindingSource;
        private StokKayitDataSet2TableAdapters.MalzemelerTableAdapter malzemelerTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn malzemeKoduDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn malzemeAdiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn yillikSatisDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn birimFiyatDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn minStokDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn teminSüresiDataGridViewTextBoxColumn;
    }
}