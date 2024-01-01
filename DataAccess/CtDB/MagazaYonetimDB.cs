using Entities.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.CtDB
{
    public class MagazaYonetimDB : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\MSSQLLocalDB ;
                                        DAtabase = MagazaYonetimDB;
                                        Trusted_Connection = true");
        }
        public DbSet<Personel> Personeller { get; set; }
        public DbSet<Urun> Urunler { get; set; }
    }
}
