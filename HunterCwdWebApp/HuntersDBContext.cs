using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace HunterCwdWebApp
{
    public partial class HuntersDBContext : DbContext
    {
        public HuntersDBContext()
        {
        }

        public HuntersDBContext(DbContextOptions<HuntersDBContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Cwd> Cwds { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                //Fucking Kyle
                optionsBuilder.UseSqlServer("Server=tcp:hunter1.database.windows.net,1433;Initial Catalog=HuntersDB;Persist Security Info=False;User ID=Alec;Password=Azure123;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Cwd>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("CWD");

                entity.Property(e => e.County)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("county");

                entity.Property(e => e.PositiveTestCount).HasColumnName("positiveTestCount");

                entity.Property(e => e.State)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("state");

                entity.Property(e => e.TotalTestCount).HasColumnName("totalTestCount");

                entity.Property(e => e.Year).HasColumnName("year");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
