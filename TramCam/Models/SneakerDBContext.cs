using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace TramCam.Models
{
    public partial class SneakerDBContext : DbContext
    {
        public SneakerDBContext()
            : base("name=SneakerDBContext")
        {
        }

        public virtual DbSet<Sneaker> Sneakers { get; set; }
        public virtual DbSet<Type> Types { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Sneaker>()
                .Property(e => e.TenGiay)
                .IsUnicode(false);

            modelBuilder.Entity<Sneaker>()
                .Property(e => e.Gia)
                .HasPrecision(18, 0);

            modelBuilder.Entity<Sneaker>()
                .Property(e => e.Hinh)
                .IsUnicode(false);

            modelBuilder.Entity<Sneaker>()
                .Property(e => e.MoTa)
                .IsUnicode(false);
        }
    }
}
