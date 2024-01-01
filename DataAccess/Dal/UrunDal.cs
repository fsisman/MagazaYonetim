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
    public class UrunDal : IBaseDal<Urun>,IUrunDal
    {
        public void Ekle(Urun entity)
        {
            using (var baglantı = new MagazaYonetimDB())
            {
                var eklenenEntity = baglantı.Entry(entity);
                eklenenEntity.State = EntityState.Added;
                baglantı.SaveChanges();
            }
        }

        public Urun Getir(Expression<Func<Urun, bool>> filter)
        {
            using (var baglanti = new MagazaYonetimDB())
            {
                return baglanti.Set<Urun>().SingleOrDefault(filter);
            }
        }

        public void Guncelle(Urun entity)
        {
            using (var baglanti = new MagazaYonetimDB())
            {
                var guncellenen = baglanti.Entry(entity);
                guncellenen.State = EntityState.Modified;
                baglanti.SaveChanges();
            }
        }

        public List<Urun> Listele()
        {
            using (var baglanti = new MagazaYonetimDB()) 
            {
                return baglanti.Set<Urun>().ToList();
            }
        }

        public void Sil(Urun entity)
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
