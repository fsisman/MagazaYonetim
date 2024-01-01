using Business;
using Business.DependencyInjection;
using Presentation.Personel;
using Presentation.Urun;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentation
{
    public partial class Giris : Form
    {
        public Giris()
        {
            InitializeComponent();
            _personelService = KernelFactory.GetService<IPersonelService>();
            _urunService = KernelFactory.GetService<IUrunService>();
        }
        IPersonelService _personelService;
        IUrunService _urunService;

        private void pictureBoxPersonel_Click(object sender, EventArgs e)
        {
            PersonelAnaEkran personelAnaEkran = new PersonelAnaEkran(_personelService);
            personelAnaEkran.ShowDialog();
            this.Close();
        }

        private void pictureBoxUrun_Click(object sender, EventArgs e)
        {
            UrunAnaEkran urunAnaEkran = new UrunAnaEkran(_urunService);
            urunAnaEkran.ShowDialog();
            this.Close();
        }

        private void Giris_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void Giris_Load(object sender, EventArgs e)
        {

        }
    }
}
