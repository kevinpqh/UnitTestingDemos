using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace DataTestingDemo.Moldels
{
    public partial class TestingDBContext : DbContext
    {
        public TestingDBContext()
        {
        }

        public TestingDBContext(DbContextOptions<TestingDBContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Person> Person { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {

                optionsBuilder.UseSqlServer("");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("ProductVersion", "2.2.6-servicing-10079");

            modelBuilder.Entity<Person>(entity =>
            {
                entity.HasKey(e => e.Idperson)
                    .HasName("PK__person__03BCEA8CFE7096CC");

                entity.ToTable("person");

                entity.Property(e => e.Idperson).HasColumnName("idperson");

                entity.Property(e => e.Firstname)
                    .IsRequired()
                    .HasColumnName("firstname")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Lastname)
                    .IsRequired()
                    .HasColumnName("lastname")
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });
        }
    }
}
