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
    public partial class FrmMalzemeKayit : Form
    {
        public FrmMalzemeKayit()
        {
            InitializeComponent();
        }

        // SQL Server'a bağlantı yapmak için kullanılacak SqlConnection nesnesi
        SqlConnection baglanti = new SqlConnection("Data Source= .\\sqlexpress;Initial Catalog=StokKayit;Integrated Security=True");

        // Ekle butonuna tıklandığında çalışacak metod
        private void BtnEkle_Click(object sender, EventArgs e)
        {
            try
            {
                // Veritabanı bağlantısı açılıyor
                baglanti.Open();

                // SQL sorgusu hazırlanıyor ve parametreler atanıyor
                SqlCommand komut1 = new SqlCommand("insert into Malzemeler (MalzemeKodu,MalzemeAdi,YillikSatis,BirimFiyat,MinStok,TeminSüresi) values (@m1,@m2,@m3,@m4,@m5,@m6)", baglanti);
                komut1.Parameters.AddWithValue("@m1", TxtMalzemeKodu.Text);
                komut1.Parameters.AddWithValue("@m2", TxtMalzemeAdı.Text);
                komut1.Parameters.AddWithValue("@m3", TxtYillikSatis.Text);
                komut1.Parameters.AddWithValue("@m4", TxtBirimFiyat.Text);
                komut1.Parameters.AddWithValue("@m5", TxtMinStok.Text);
                komut1.Parameters.AddWithValue("@m6", TxtTedarikSüresi.Text);

                // SQL sorgusu çalıştırılıyor
                komut1.ExecuteNonQuery();

                // Veritabanı bağlantısı kapatılıyor
                baglanti.Close();

                // Kullanıcıya başarılı mesajı gösteriliyor
                MessageBox.Show("Kayıt Başarılı bir şekilde eklendi");

                // DataGridView güncelleniyor
                listele();

                // TextBox'lar temizleniyor
                Temizle();
            }
            catch (Exception ex)
            {
                // Hata durumunda kullanıcıya bilgi veriliyor
                MessageBox.Show("Kayıt eklenemedi, Tekrar Deneyiniz!", ex.Message);
            }
        }

        // Form yüklendiğinde çalışacak metod
        private void Form1_Load(object sender, EventArgs e)
        {
            // Veritabanından veriler çekilip DataGridView'e yükleniyor
            this.malzemelerTableAdapter.Fill(this.stokKayitDataSet.Malzemeler);
            listele();
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

        // TextBox'ları temizleyen metod
        private void Temizle()
        {
            TxtMalzemeKodu.Text = "";
            TxtMalzemeAdı.Text = "";
            TxtYillikSatis.Text = "";
            TxtBirimFiyat.Text = "";
            TxtMinStok.Text = "";
            TxtTedarikSüresi.Text = "";
        }

        // Sil butonuna tıklandığında çalışacak metod
        private void BtnSil_Click(object sender, EventArgs e)
        {
            try
            {
                baglanti.Open();

                // Seçilen MalzemeKodu'na göre veritabanından kayıt siliniyor
                SqlCommand komut2 = new SqlCommand("delete from Malzemeler where MalzemeKodu = @m1", baglanti);
                komut2.Parameters.AddWithValue("@m1", TxtMalzemeKodu.Text);
                komut2.ExecuteNonQuery();

                baglanti.Close();
                MessageBox.Show("Kayıt Başarılı bir şekilde silindi");
                listele();
                Temizle();
            }
            catch (Exception)
            {
                MessageBox.Show("Kayıt silinemedi, Tekrar Deneyiniz!");
            }
        }

        // DataGridView hücresine tıklandığında çalışacak metod
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Seçilen hücrenin indeksi alınıyor
            int sec = dataGridView1.SelectedCells[0].RowIndex;

            // Seçilen hücrenin değerleri alınıyor
            string mlzmkod = dataGridView1.Rows[sec].Cells[0].Value.ToString();
            string mlzmad = dataGridView1.Rows[sec].Cells[1].Value.ToString();
            string mlzmyilliksatis = dataGridView1.Rows[sec].Cells[2].Value.ToString();
            string mlzmbirimfiyat = dataGridView1.Rows[sec].Cells[3].Value.ToString();
            string mlzmminstok = dataGridView1.Rows[sec].Cells[4].Value.ToString();
            string mlzmtdrksüresi = dataGridView1.Rows[sec].Cells[5].Value.ToString();

            // Seçilen veriler TextBox'lara atanıyor
            TxtMalzemeKodu.Text = mlzmkod;
            TxtMalzemeAdı.Text = mlzmad;
            TxtYillikSatis.Text = mlzmyilliksatis;
            TxtBirimFiyat.Text = mlzmbirimfiyat;
            TxtMinStok.Text = mlzmminstok;
            TxtTedarikSüresi.Text = mlzmtdrksüresi;
        }

        // Güncelle butonuna tıklandığında çalışacak metod
        private void BtnGüncelle_Click(object sender, EventArgs e)
        {
            try
            {
                baglanti.Open();

                // Seçilen MalzemeKodu'na göre veritabanındaki kayıt güncelleniyor
                SqlCommand komut3 = new SqlCommand("update Malzemeler Set MalzemeAdi = @m2,YillikSatis = @m3,BirimFiyat = @m4,MinStok = @m5,TeminSüresi = @m6 Where MalzemeKodu = @m1", baglanti);
                komut3.Parameters.AddWithValue("@m1", TxtMalzemeKodu.Text);
                komut3.Parameters.AddWithValue("@m2", TxtMalzemeAdı.Text);
                komut3.Parameters.AddWithValue("@m3", TxtYillikSatis.Text);
                komut3.Parameters.AddWithValue("@m4", TxtBirimFiyat.Text);
                komut3.Parameters.AddWithValue("@m5", TxtMinStok.Text);
                komut3.Parameters.AddWithValue("@m6", TxtTedarikSüresi.Text);
                komut3.ExecuteNonQuery();

                baglanti.Close();
                MessageBox.Show("Kayıt Başarılı bir şekilde güncellendi");
                listele();
                Temizle();
            }
            catch (Exception)
            {
                MessageBox.Show("Kayıt güncellenemedi, Tekrar Deneyiniz!");
            }
        }

        private void malzemeAraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmMalzemeAra malzemeFormu = new FrmMalzemeAra();
            malzemeFormu.Show();
        }

        private void malzemeListesiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmMalzemeListesi malzemeListesi = new FrmMalzemeListesi();
            malzemeListesi.Show();
        }

        private void çıkışToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
