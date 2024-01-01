using DataAccess.CtDB;
using DataAccess.Dal.BaseDal;
using Entities.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace DataAccess.Dal
{
    public class PersonelDal : IBaseDal<Personel>, IPersonelDal
    {
        public void Ekle(Personel entity)
        {
            using (var baglanti = new MagazaYonetimDB())
            {
                var eklenen = baglanti.Entry(entity);
                eklenen.State = EntityState.Added;
                baglanti.SaveChanges();
            }
        }

        public Personel Getir(Expression<Func<Personel, bool>> filter)
        {
            using (var baglanti = new MagazaYonetimDB())
            {
                return baglanti.Set<Personel>().SingleOrDefault(filter);
            }
        }

        public void Guncelle(Personel entity)
        {
            using (var baglanti = new MagazaYonetimDB())
            {
                var guncellenen = baglanti.Entry(entity);
                guncellenen.State = EntityState.Modified;
                baglanti.SaveChanges();
            }
        }

        public List<Personel> Listele()
        {
            using (var baglanti = new MagazaYonetimDB())
            {
                return baglanti.Set<Personel>().ToList();
            }
        }

        public void Sil(Personel entity)
        {
            using (var baglanti = new MagazaYonetimDB())
            {
                var silinen = baglanti.Entry(entity);
                silinen.State = EntityState.Deleted;
                baglanti.SaveChanges();
            }
        }
    }
}
