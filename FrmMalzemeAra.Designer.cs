
namespace StokKayit
{
    partial class FrmMalzemeAra
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMalzemeAra));
            this.label1 = new System.Windows.Forms.Label();
            this.TxtMalzemeKodu = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.malzemelerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.stokKayitDataSet1 = new StokKayit.StokKayitDataSet1();
            this.malzemelerTableAdapter = new StokKayit.StokKayitDataSet1TableAdapters.MalzemelerTableAdapter();
            this.BtnAra = new System.Windows.Forms.Button();
            this.BtnTemizle = new System.Windows.Forms.Button();
            this.malzemeKoduDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.malzemeAdiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.yillikSatisDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.birimFiyatDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.minStokDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.teminSüresiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.malzemelerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stokKayitDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(123, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Malzeme Kodu:";
            // 
            // TxtMalzemeKodu
            // 
            this.TxtMalzemeKodu.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TxtMalzemeKodu.Location = new System.Drawing.Point(230, 43);
            this.TxtMalzemeKodu.Name = "TxtMalzemeKodu";
            this.TxtMalzemeKodu.Size = new System.Drawing.Size(149, 26);
            this.TxtMalzemeKodu.TabIndex = 2;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.malzemeKoduDataGridViewTextBoxColumn,
            this.malzemeAdiDataGridViewTextBoxColumn,
            this.yillikSatisDataGridViewTextBoxColumn,
            this.birimFiyatDataGridViewTextBoxColumn,
            this.minStokDataGridViewTextBoxColumn,
            this.teminSüresiDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.malzemelerBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(21, 104);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(778, 307);
            this.dataGridView1.TabIndex = 11;
            // 
            // malzemelerBindingSource
            // 
            this.malzemelerBindingSource.DataMember = "Malzemeler";
            this.malzemelerBindingSource.DataSource = this.stokKayitDataSet1;
            // 
            // stokKayitDataSet1
            // 
            this.stokKayitDataSet1.DataSetName = "StokKayitDataSet1";
            this.stokKayitDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // malzemelerTableAdapter
            // 
            this.malzemelerTableAdapter.ClearBeforeFill = true;
            // 
            // BtnAra
            // 
            this.BtnAra.BackColor = System.Drawing.Color.AliceBlue;
            this.BtnAra.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Aqua;
            this.BtnAra.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnAra.Location = new System.Drawing.Point(415, 35);
            this.BtnAra.Name = "BtnAra";
            this.BtnAra.Size = new System.Drawing.Size(135, 39);
            this.BtnAra.TabIndex = 12;
            this.BtnAra.Text = "ARA";
            this.BtnAra.UseVisualStyleBackColor = false;
            this.BtnAra.Click += new System.EventHandler(this.BtnAra_Click);
            // 
            // BtnTemizle
            // 
            this.BtnTemizle.BackColor = System.Drawing.Color.AliceBlue;
            this.BtnTemizle.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Aqua;
            this.BtnTemizle.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnTemizle.Location = new System.Drawing.Point(572, 35);
            this.BtnTemizle.Name = "BtnTemizle";
            this.BtnTemizle.Size = new System.Drawing.Size(135, 39);
            this.BtnTemizle.TabIndex = 13;
            this.BtnTemizle.Text = "TEMİZLE";
            this.BtnTemizle.UseVisualStyleBackColor = false;
            this.BtnTemizle.Click += new System.EventHandler(this.BtnTemizle_Click);
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
            // FrmMalzemeAra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.LightSkyBlue;
            this.ClientSize = new System.Drawing.Size(836, 407);
            this.Controls.Add(this.BtnTemizle);
            this.Controls.Add(this.BtnAra);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.TxtMalzemeKodu);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FrmMalzemeAra";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Malzeme Ara";
            this.Load += new System.EventHandler(this.FrmMalzemeAra_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.malzemelerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stokKayitDataSet1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtMalzemeKodu;
        private System.Windows.Forms.DataGridView dataGridView1;
        private StokKayitDataSet1 stokKayitDataSet1;
        private System.Windows.Forms.BindingSource malzemelerBindingSource;
        private StokKayitDataSet1TableAdapters.MalzemelerTableAdapter malzemelerTableAdapter;
        private System.Windows.Forms.Button BtnAra;
        private System.Windows.Forms.Button BtnTemizle;
        private System.Windows.Forms.DataGridViewTextBoxColumn malzemeKoduDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn malzemeAdiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn yillikSatisDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn birimFiyatDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn minStokDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn teminSüresiDataGridViewTextBoxColumn;
    }
}