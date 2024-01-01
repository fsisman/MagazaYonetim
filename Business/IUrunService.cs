using Entities.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business
{
    public interface IUrunService
    {
        void Ekle(Urun urun);
        void Sil(Urun urun);
        void Guncelle(Urun urun);
        List<Urun> Listele();
    }
}
