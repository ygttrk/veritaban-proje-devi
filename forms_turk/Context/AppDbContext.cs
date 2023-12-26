using forms_turk.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace forms_turk.Context
{
    public class AppDbContext : DbContext
    {

        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        public AppDbContext()
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Data Source=DESKTOP-BKHR88K;" +
                    "Initial Catalog=turk_konveksiyon2;" +
                    "Integrated Security=True;Encrypt=True;" +
                    "Trust Server Certificate=True");
            }
        }

        public DbSet<AlisVeris> AlisVeris { get; set; }
        public DbSet<AylikCiro> AylikCiro { get; set; }
        public DbSet<Ilce> Ilce { get; set; }
        public DbSet<Mahalle> Mahalle { get; set; }
        public DbSet<Musteri> Musteri { get; set; }
        public  DbSet<Personel> Personel { get; set; }
        public DbSet<Sehir> Sehir { get; set; }
        public DbSet<Urun> Urun { get; set; }
        public DbSet<UrunTuru> UrunTuru { get; set; }
    }
}
