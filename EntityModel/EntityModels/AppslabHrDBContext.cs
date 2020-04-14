using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace EntityModel.EntityModels
{
    public partial class AppslabHrDBContext : DbContext
    {
        public AppslabHrDBContext()
        {
        }

        public AppslabHrDBContext(DbContextOptions<AppslabHrDBContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Employee> Employee { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                //#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Data Source=DESKTOP-4JOONED;Initial Catalog=AppslabHrDB;Integrated Security=True");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Employee>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.EmployeeAddress).HasMaxLength(100);

                entity.Property(e => e.EmployeeName).HasMaxLength(50);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
