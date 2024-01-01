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
    public partial class PersonelEkle : Form
    {
        IPersonelService _personelService;
        public PersonelEkle(IPersonelService personelService)
        {
            InitializeComponent();
            _personelService = personelService;
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            _personelService.Ekle(new Entities.Entities.Personel
            {
                PersonelNo = Convert.ToInt32(txtPersonelNo.Text),
                PersonelAd = txtPersonelAd.Text,
                PersonelSoyad = txtPersonelNo.Text,
                Maas = Convert.ToDecimal(txtPersonelMaas.Text),
                Departman = txtPersonelDepartman.Text,
            }) ;
            MessageBox.Show("Personel Eklendi");
            this.Close();
        }
    }
}
