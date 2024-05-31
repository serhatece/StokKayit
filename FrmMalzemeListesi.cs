using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StokKayit
{
    public partial class FrmMalzemeListesi : Form
    {
        public FrmMalzemeListesi()
        {
            InitializeComponent();
        }

        private void FrmMalzemeListesi_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'stokKayitDataSet2.Malzemeler' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.malzemelerTableAdapter.Fill(this.stokKayitDataSet2.Malzemeler);

        }
    }
}
