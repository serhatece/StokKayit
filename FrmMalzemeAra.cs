using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace StokKayit
{
    public partial class FrmMalzemeAra : Form
    {
        public FrmMalzemeAra()
        {
            InitializeComponent();
        }

        // SQL Server'a bağlantı yapmak için kullanılacak SqlConnection nesnesi
        SqlConnection baglanti = new SqlConnection("Data Source= .\\sqlexpress;Initial Catalog=StokKayit;Integrated Security=True");

        // Form yüklendiğinde çalışacak metod
        private void FrmMalzemeAra_Load(object sender, EventArgs e)
        {
            // Malzemeler tablosundan verileri yükler
            this.malzemelerTableAdapter.Fill(this.stokKayitDataSet1.Malzemeler);
        }

        // Ara butonuna tıklandığında çalışacak metod
        private void BtnAra_Click(object sender, EventArgs e)
        {
            string malzemeKodu = TxtMalzemeKodu.Text;

            // Malzeme kodu boş ise uyarı ver
            if (malzemeKodu == "")
            {
                MessageBox.Show("Malzeme kodu giriniz.");
                return;
            }

            try
            {
                baglanti.Open();

                // Malzeme koduna göre SQL sorgusu
                string query = "SELECT * FROM Malzemeler WHERE MalzemeKodu = @MalzemeKodu";

                SqlCommand komut1 = new SqlCommand(query, baglanti);

                komut1.Parameters.AddWithValue("@MalzemeKodu", malzemeKodu);

                // Veri okuyucu oluştur
                SqlDataReader reader = komut1.ExecuteReader();

                // Veri bulunduğunda DataGridView'i doldur
                if (reader.HasRows)
                {
                    DataTable dataTable = new DataTable();
                    dataTable.Load(reader);
                    dataGridView1.DataSource = dataTable;
                }
                else
                {
                    MessageBox.Show("Malzeme bulunamadı.");
                }

                baglanti.Close();

            }
            catch (Exception)
            {
                MessageBox.Show("HATA OLUŞTU, Tekrar Deneyiniz!");
            }
        }

        // DataGridView'i dolduran metod
        private void listele()
        {
            baglanti.Open();
            SqlDataAdapter da = new SqlDataAdapter("Select * from Malzemeler", baglanti);
            DataTable tablo = new DataTable();
            da.Fill(tablo);
            dataGridView1.DataSource = tablo;
            baglanti.Close();
        }

        // Temizle butonuna tıklandığında çalışacak metod
        private void BtnTemizle_Click(object sender, EventArgs e)
        {
            // Malzeme kodu textbox'ını temizle ve DataGridView'i yeniden doldur
            TxtMalzemeKodu.Clear();
            listele();
        }
    }
}
