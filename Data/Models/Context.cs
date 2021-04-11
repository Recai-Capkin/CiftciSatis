using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CiftciSatis.Data.Models
{
    public class Context : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=.; database=DbCiftciSatis;integrated security=true;");
        }
        public DbSet<Ciftci> Ciftcis { get; set; }
        public DbSet<Musteri> Musteris { get; set; }
        public DbSet<Siparisler> Siparislers { get; set; }
        public DbSet<Urunler> Urunlers { get; set; }
    }
}
