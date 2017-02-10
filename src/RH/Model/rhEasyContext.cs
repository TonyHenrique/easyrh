using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WinRH;

namespace RH
{
    public class rhEasyContext : DbContext
    {
        public rhEasyContext()
        {
        }

        public rhEasyContext(DbContextOptions<rhEasyContext> options) : base(options)
        {

        }

        public virtual DbSet<Talento> Talento { get; set; }
        public virtual DbSet<Conhecimento> Conhecimento { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
            optionsBuilder.UseSqlServer(@"Server=tcp:rheasy.database.windows.net,1433;Initial Catalog=rheasy;Persist Security Info=False;User ID=easy;Password=Burro2015;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Talento>().HasKey(e => e.id_Talento).HasName("id_Talento");

            modelBuilder.Entity<Talento>()
                .HasMany(c => c.Conhecimento)
                    .WithOne(c => c.Talento)
                    .HasForeignKey(c => c.Talento_id_Talento)
                    .OnDelete(Microsoft.EntityFrameworkCore.Metadata.DeleteBehavior.Cascade);


            modelBuilder.Entity<Conhecimento>(entity =>
            {
                entity.HasKey(e => e.id_Conhecimento).HasName("id_Conhecimento");
                //entity.HasOne(d => d.Talento)
                //    .WithMany(p => p.Conhecimento)
                //    .HasForeignKey(d => d.Talento_id_Talento)
                //;
            });

        }
    }
}
