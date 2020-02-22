using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace RegnskabAPI.mysql
{
    public partial class holmsennels_dk_dbContext : DbContext
    {
        public holmsennels_dk_dbContext()
        {
        }

        public holmsennels_dk_dbContext(DbContextOptions<holmsennels_dk_dbContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Kontostam> Kontostam { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseMySql("server=mysql26.unoeuro.com;port=3306;user=holmsennels_dk;password=xwft2gcy;database=holmsennels_dk_db", x => x.ServerVersion("5.7.29-mysql"));
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Kontostam>(entity =>
            {
                entity.HasComment("kontostam for astrids tøjpenge");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("bigint(20)");

                entity.Property(e => e.Belob)
                    .HasColumnName("belob")
                    .HasColumnType("decimal(10,0)");

                entity.Property(e => e.Beskrivelse)
                    .IsRequired()
                    .HasColumnName("beskrivelse")
                    .HasColumnType("varchar(1000)")
                    .HasCharSet("latin1")
                    .HasCollation("latin1_swedish_ci");

                entity.Property(e => e.Dato)
                    .HasColumnName("dato")
                    .HasColumnType("date");

                entity.Property(e => e.Konto)
                    .HasColumnName("konto")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Mtts)
                    .HasColumnName("MTTS")
                    .HasColumnType("timestamp")
                    .HasDefaultValueSql("CURRENT_TIMESTAMP");

                entity.Property(e => e.Saldo)
                    .HasColumnName("saldo")
                    .HasColumnType("decimal(10,0)");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
