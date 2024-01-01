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

namespace Presentation.Personel
{
    public partial class PersonelAnaEkran : Form
    {
        IPersonelService _personelService;
        public PersonelAnaEkran(IPersonelService personelService)
        {
            InitializeComponent();
            _personelService = personelService; 
        }
        private void ListeyiGetir() 
        {
            DgwPersonel.DataSource = _personelService.Listele();
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void PersonelAnaEkran_Load(object sender, EventArgs e)
        {
            ListeyiGetir();
        }

        private void DgwPersonel_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            txtPersonelId.Text = DgwPersonel.CurrentRow.Cells[0].Value.ToString();
            txtPersonelNo.Text = DgwPersonel.CurrentRow.Cells[1].Value.ToString();
            txtPersonelAd.Text = DgwPersonel.CurrentRow.Cells[2].Value.ToString();
            txtPersonelSoyad.Text = DgwPersonel.CurrentRow.Cells[3].Value.ToString();
            txtPersonelMaas.Text = DgwPersonel.CurrentRow.Cells[4].Value.ToString();
            txtPersonelDepartman.Text = DgwPersonel.CurrentRow.Cells[5].Value.ToString();
        }
        private void AlanlariTemizle() 
        {
            txtPersonelId.Text = "";
            txtPersonelNo.Text = ""; 
            txtPersonelAd.Text = "";
            txtPersonelSoyad.Text = "";
            txtPersonelMaas.Text = "";
            txtPersonelDepartman.Text = "";
        }

        private void btnPersonelSil_Click(object sender, EventArgs e)
        {
            _personelService.Sil(new Entities.Entities.Personel
            {
                PersonelId = Convert.ToInt32(txtPersonelId.Text)
            });
            MessageBox.Show("Personel Silindi ");
            AlanlariTemizle();
            ListeyiGetir();
        }

        private void btnPersonelGuncelle_Click(object sender, EventArgs e)
        {
            _personelService.Guncelle(new Entities.Entities.Personel
            {
                PersonelId = Convert.ToInt32(txtPersonelId.Text),
                PersonelNo = Convert.ToInt32(txtPersonelNo.Text),
                PersonelAd = txtPersonelId.Text,
                PersonelSoyad = txtPersonelSoyad.Text,
                Maas = Convert.ToDecimal(txtPersonelMaas.Text),
                Departman = txtPersonelDepartman.Text,
            }) ;
            MessageBox.Show("Personel Güncellendi");
            AlanlariTemizle();
            ListeyiGetir();
        }

        private void btnPersonelEkle_Click(object sender, EventArgs e)
        {
            PersonelEkle personelEkle = new PersonelEkle(_personelService);
            personelEkle.ShowDialog();
            ListeyiGetir();
        }
    }
}
