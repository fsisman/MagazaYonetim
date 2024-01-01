using Business;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentation.Urun
{
    public partial class UrunEkle : Form
    {
        IUrunService _urunService;
        public UrunEkle(IUrunService urunService)
        {
            InitializeComponent();
            _urunService = urunService;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void txtPersonelNo_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtPersonelAd_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtPersonelId_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void txtPersonelSoyad_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            _urunService.Ekle(new Entities.Entities.Urun
            {
                UrunAd = txtUrunAd.Text,
                KategoriAd = txtUrunKategoriAd.Text,
                Fiyat = Convert.ToDecimal(txtUrunFiyat.Text),
            });
            MessageBox.Show("Ürün Eklendi");
            this.Close();
            
        }
    }
}
