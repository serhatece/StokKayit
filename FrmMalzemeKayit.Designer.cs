
namespace StokKayit
{
    partial class FrmMalzemeKayit
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMalzemeKayit));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.TxtTedarikSüresi = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.TxtMinStok = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.TxtBirimFiyat = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.TxtYillikSatis = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TxtMalzemeAdı = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtMalzemeKodu = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.malzemelerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.stokKayitDataSet = new StokKayit.StokKayitDataSet();
            this.BtnEkle = new System.Windows.Forms.Button();
            this.BtnSil = new System.Windows.Forms.Button();
            this.BtnGüncelle = new System.Windows.Forms.Button();
            this.malzemelerTableAdapter = new StokKayit.StokKayitDataSetTableAdapters.MalzemelerTableAdapter();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.malzemeAraToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.malzemeListesiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.çıkışToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.malzemeKoduDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.malzemeAdiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.yillikSatisDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.birimFiyatDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.minStokDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.teminSüresiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.malzemelerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stokKayitDataSet)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.groupBox1.Controls.Add(this.TxtTedarikSüresi);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.TxtMinStok);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.TxtBirimFiyat);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.TxtYillikSatis);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.TxtMalzemeAdı);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.TxtMalzemeKodu);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(13, 60);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(652, 153);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Malzeme Bilgileri";
            // 
            // TxtTedarikSüresi
            // 
            this.TxtTedarikSüresi.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TxtTedarikSüresi.Location = new System.Drawing.Point(472, 95);
            this.TxtTedarikSüresi.Name = "TxtTedarikSüresi";
            this.TxtTedarikSüresi.Size = new System.Drawing.Size(149, 26);
            this.TxtTedarikSüresi.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(333, 100);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(133, 17);
            this.label6.TabIndex = 10;
            this.label6.Text = "Tedarik Süresi (Gün):";
            // 
            // TxtMinStok
            // 
            this.TxtMinStok.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TxtMinStok.Location = new System.Drawing.Point(472, 63);
            this.TxtMinStok.Name = "TxtMinStok";
            this.TxtMinStok.Size = new System.Drawing.Size(149, 26);
            this.TxtMinStok.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(327, 68);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(139, 17);
            this.label5.TabIndex = 8;
            this.label5.Text = "Minimum Stok (Adet):";
            // 
            // TxtBirimFiyat
            // 
            this.TxtBirimFiyat.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TxtBirimFiyat.Location = new System.Drawing.Point(472, 31);
            this.TxtBirimFiyat.Name = "TxtBirimFiyat";
            this.TxtBirimFiyat.Size = new System.Drawing.Size(149, 26);
            this.TxtBirimFiyat.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(325, 36);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(141, 17);
            this.label4.TabIndex = 6;
            this.label4.Text = "Birim Fiyat (TL/Adet):";
            // 
            // TxtYillikSatis
            // 
            this.TxtYillikSatis.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TxtYillikSatis.Location = new System.Drawing.Point(136, 95);
            this.TxtYillikSatis.Name = "TxtYillikSatis";
            this.TxtYillikSatis.Size = new System.Drawing.Size(149, 26);
            this.TxtYillikSatis.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(14, 100);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(116, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Yıllık Satış (Adet):";
            // 
            // TxtMalzemeAdı
            // 
            this.TxtMalzemeAdı.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TxtMalzemeAdı.Location = new System.Drawing.Point(136, 63);
            this.TxtMalzemeAdı.Name = "TxtMalzemeAdı";
            this.TxtMalzemeAdı.Size = new System.Drawing.Size(149, 26);
            this.TxtMalzemeAdı.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(41, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Malzeme Adı:";
            // 
            // TxtMalzemeKodu
            // 
            this.TxtMalzemeKodu.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TxtMalzemeKodu.Location = new System.Drawing.Point(136, 31);
            this.TxtMalzemeKodu.Name = "TxtMalzemeKodu";
            this.TxtMalzemeKodu.Size = new System.Drawing.Size(149, 26);
            this.TxtMalzemeKodu.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(29, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Malzeme Kodu:";
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
            this.dataGridView1.Location = new System.Drawing.Point(13, 243);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(775, 207);
            this.dataGridView1.TabIndex = 10;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // malzemelerBindingSource
            // 
            this.malzemelerBindingSource.DataMember = "Malzemeler";
            this.malzemelerBindingSource.DataSource = this.stokKayitDataSet;
            // 
            // stokKayitDataSet
            // 
            this.stokKayitDataSet.DataSetName = "StokKayitDataSet";
            this.stokKayitDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // BtnEkle
            // 
            this.BtnEkle.BackColor = System.Drawing.Color.LightGreen;
            this.BtnEkle.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Lime;
            this.BtnEkle.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Lime;
            this.BtnEkle.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnEkle.Location = new System.Drawing.Point(676, 74);
            this.BtnEkle.Name = "BtnEkle";
            this.BtnEkle.Size = new System.Drawing.Size(112, 39);
            this.BtnEkle.TabIndex = 7;
            this.BtnEkle.Text = "Ekle";
            this.BtnEkle.UseVisualStyleBackColor = false;
            this.BtnEkle.Click += new System.EventHandler(this.BtnEkle_Click);
            // 
            // BtnSil
            // 
            this.BtnSil.BackColor = System.Drawing.Color.Red;
            this.BtnSil.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.BtnSil.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.BtnSil.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnSil.Location = new System.Drawing.Point(676, 119);
            this.BtnSil.Name = "BtnSil";
            this.BtnSil.Size = new System.Drawing.Size(112, 39);
            this.BtnSil.TabIndex = 8;
            this.BtnSil.Text = "Sil";
            this.BtnSil.UseVisualStyleBackColor = false;
            this.BtnSil.Click += new System.EventHandler(this.BtnSil_Click);
            // 
            // BtnGüncelle
            // 
            this.BtnGüncelle.BackColor = System.Drawing.Color.CornflowerBlue;
            this.BtnGüncelle.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.BtnGüncelle.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.BtnGüncelle.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnGüncelle.Location = new System.Drawing.Point(676, 164);
            this.BtnGüncelle.Name = "BtnGüncelle";
            this.BtnGüncelle.Size = new System.Drawing.Size(112, 39);
            this.BtnGüncelle.TabIndex = 9;
            this.BtnGüncelle.Text = "Güncelle";
            this.BtnGüncelle.UseVisualStyleBackColor = false;
            this.BtnGüncelle.Click += new System.EventHandler(this.BtnGüncelle_Click);
            // 
            // malzemelerTableAdapter
            // 
            this.malzemelerTableAdapter.ClearBeforeFill = true;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.malzemeAraToolStripMenuItem,
            this.malzemeListesiToolStripMenuItem,
            this.çıkışToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(812, 27);
            this.menuStrip1.TabIndex = 11;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // malzemeAraToolStripMenuItem
            // 
            this.malzemeAraToolStripMenuItem.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.malzemeAraToolStripMenuItem.Name = "malzemeAraToolStripMenuItem";
            this.malzemeAraToolStripMenuItem.Size = new System.Drawing.Size(107, 23);
            this.malzemeAraToolStripMenuItem.Text = "Malzeme Ara";
            this.malzemeAraToolStripMenuItem.Click += new System.EventHandler(this.malzemeAraToolStripMenuItem_Click);
            // 
            // malzemeListesiToolStripMenuItem
            // 
            this.malzemeListesiToolStripMenuItem.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.malzemeListesiToolStripMenuItem.Name = "malzemeListesiToolStripMenuItem";
            this.malzemeListesiToolStripMenuItem.Size = new System.Drawing.Size(129, 23);
            this.malzemeListesiToolStripMenuItem.Text = "Malzeme Listesi";
            this.malzemeListesiToolStripMenuItem.Click += new System.EventHandler(this.malzemeListesiToolStripMenuItem_Click);
            // 
            // çıkışToolStripMenuItem
            // 
            this.çıkışToolStripMenuItem.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.çıkışToolStripMenuItem.Name = "çıkışToolStripMenuItem";
            this.çıkışToolStripMenuItem.Size = new System.Drawing.Size(56, 23);
            this.çıkışToolStripMenuItem.Text = "Çıkış";
            this.çıkışToolStripMenuItem.Click += new System.EventHandler(this.çıkışToolStripMenuItem_Click);
            // 
            // malzemeKoduDataGridViewTextBoxColumn
            // 
            this.malzemeKoduDataGridViewTextBoxColumn.DataPropertyName = "MalzemeKodu";
            this.malzemeKoduDataGridViewTextBoxColumn.HeaderText = "MalzemeKodu";
            this.malzemeKoduDataGridViewTextBoxColumn.Name = "malzemeKoduDataGridViewTextBoxColumn";
            this.malzemeKoduDataGridViewTextBoxColumn.ReadOnly = true;
            this.malzemeKoduDataGridViewTextBoxColumn.Width = 85;
            // 
            // malzemeAdiDataGridViewTextBoxColumn
            // 
            this.malzemeAdiDataGridViewTextBoxColumn.DataPropertyName = "MalzemeAdi";
            this.malzemeAdiDataGridViewTextBoxColumn.HeaderText = "MalzemeAdi";
            this.malzemeAdiDataGridViewTextBoxColumn.Name = "malzemeAdiDataGridViewTextBoxColumn";
            this.malzemeAdiDataGridViewTextBoxColumn.ReadOnly = true;
            this.malzemeAdiDataGridViewTextBoxColumn.Width = 150;
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
            // FrmMalzemeKayit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.LightSkyBlue;
            this.ClientSize = new System.Drawing.Size(812, 443);
            this.Controls.Add(this.BtnGüncelle);
            this.Controls.Add(this.BtnSil);
            this.Controls.Add(this.BtnEkle);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "FrmMalzemeKayit";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Malzeme Kayıt";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.malzemelerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stokKayitDataSet)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox TxtTedarikSüresi;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox TxtMinStok;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TxtBirimFiyat;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TxtYillikSatis;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TxtMalzemeAdı;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TxtMalzemeKodu;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button BtnEkle;
        private System.Windows.Forms.Button BtnSil;
        private System.Windows.Forms.Button BtnGüncelle;
        private StokKayitDataSet stokKayitDataSet;
        private System.Windows.Forms.BindingSource malzemelerBindingSource;
        private StokKayitDataSetTableAdapters.MalzemelerTableAdapter malzemelerTableAdapter;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem malzemeAraToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem malzemeListesiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem çıkışToolStripMenuItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn malzemeKoduDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn malzemeAdiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn yillikSatisDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn birimFiyatDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn minStokDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn teminSüresiDataGridViewTextBoxColumn;
    }
}

