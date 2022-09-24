 using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entity.Concrete;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace DAL
{
    public class context:IdentityDbContext<AppUser,AppRole,int>
    {

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
            => optionsBuilder.UseNpgsql("Host=localhost;Database=Randevu_SystemOne;Username=postgres;Password=123456;Port=5432;");
        public DbSet<Arama> Arama { get; set; } = null!;
        public DbSet<ArayanTipi> Arayan_tipi { get; set; } = null!;
        public DbSet<AramaTipi> Arama_tipi { get; set; } = null!;
        public DbSet<Randevular> Randevu { get; set; } = null!;
        public DbSet<UserRole> UserRole { get; set; } = null!;
        public DbSet<Randevu_durumu> Randevu_durumu { get; set; } = null!;

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
          
        }
    }
}
