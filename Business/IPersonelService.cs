using Entities.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business
{
    public interface IPersonelService
    {
       void Ekle(Personel personel);
        void Sil(Personel personel);
        void Guncelle(Personel personel);
        List<Personel> Listele();
    }
}
