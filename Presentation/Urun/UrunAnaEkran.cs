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
    public partial class UrunAnaEkran : Form
    {
        IUrunService _urunService;
        public UrunAnaEkran(IUrunService urunService)
        {
            InitializeComponent();
            _urunService = urunService;
        }

        private void ListeyiGetir() 
        {
            DgwUrun.DataSource = _urunService.Listele();


        }

        private void DgwUrun_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnUrunEkle_Click(object sender, EventArgs e)
        {
            UrunEkle urunEkle = new UrunEkle(_urunService);
            urunEkle.ShowDialog();
            ListeyiGetir();
        }

        private void btnUrunSil_Click(object sender, EventArgs e)
        {
            _urunService.Sil(new Entities.Entities.Urun
            {
                UrunId = Convert.ToInt32(txtUrunId.Text)
            }) ;
            MessageBox.Show("Ürün Silindi");
            AlanlarıTemizle();
            ListeyiGetir();
        }
        private void AlanlarıTemizle() 
        {
            txtUrunId.Text = " ";
            txtUrunAd.Text = " ";
            txtUrunKategoriAd.Text = " ";
            txtUrunFiyat.Text = " ";

        }

        private void btnUrunGuncelle_Click(object sender, EventArgs e)
        {
            _urunService.Guncelle(new Entities.Entities.Urun
            {
                UrunId = Convert.ToInt32(txtUrunId.Text),
                UrunAd = txtUrunAd.Text,
                KategoriAd = txtUrunAd.Text,
                Fiyat = Convert.ToDecimal(txtUrunFiyat.Text)
            }) ;
            MessageBox.Show("Ürün Güncellendi");
            AlanlarıTemizle();
            ListeyiGetir();
        }

        private void DgwUrun_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            txtUrunId.Text = DgwUrun.CurrentRow.Cells[0].Value.ToString();
            txtUrunAd.Text = DgwUrun.CurrentRow.Cells[1].Value.ToString();
            txtUrunKategoriAd.Text = DgwUrun.CurrentRow.Cells[2].Value.ToString();
            txtUrunFiyat.Text = DgwUrun.CurrentRow.Cells[3].Value.ToString();

        }

        private void UrunAnaEkran_Load(object sender, EventArgs e)
        {
            ListeyiGetir();
        }
    }
}
