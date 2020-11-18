using System;
using System.Configuration;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace Model.Models
{
    public partial class EstateBrokersContext : DbContext
    {
        public EstateBrokersContext()
        {
        }

        public EstateBrokersContext(DbContextOptions<EstateBrokersContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Broker> Brokers { get; set; }
        public virtual DbSet<CaseOrder> CaseOrders { get; set; }
        public virtual DbSet<Customer> Customers { get; set; }
        public virtual DbSet<Department> Departments { get; set; }
        public virtual DbSet<Estate> Estates { get; set; }
        public virtual DbSet<OpenHouse> OpenHouses { get; set; }
        public virtual DbSet<PriceHistory> PriceHistories { get; set; }
        public virtual DbSet<ZipCode> ZipCodes { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                
                optionsBuilder.UseSqlServer(ConfigurationManager.ConnectionStrings["ConnString"].ConnectionString);
                //optionsBuilder.UseSqlServer("Server=tcp:lacour.database.windows.net,1433;Initial Catalog=EstateBrokers;Persist Security Info=False;User ID=Jesper_laCour;Password=Azure1234;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Broker>(entity =>
            {
                entity.ToTable("Broker");

                entity.Property(e => e.BrokerId).HasColumnName("BrokerID");

                entity.Property(e => e.DepartmentId).HasColumnName("DepartmentID");

                entity.Property(e => e.Name)
                    .HasMaxLength(45)
                    .IsUnicode(false);

                entity.HasOne(d => d.Department)
                    .WithMany(p => p.Brokers)
                    .HasForeignKey(d => d.DepartmentId)
                    .HasConstraintName("FK__Broker__Departme__5EBF139D");
            });

            modelBuilder.Entity<CaseOrder>(entity =>
            {
                entity.HasKey(e => e.CaseId)
                    .HasName("PK__CaseOrde__6CAE526CCCAC15CD");

                entity.ToTable("CaseOrder");

                entity.Property(e => e.CaseId).HasColumnName("CaseID");

                entity.Property(e => e.BrokerId).HasColumnName("BrokerID");

                entity.Property(e => e.CaseStatus)
                    .HasMaxLength(45)
                    .IsUnicode(false);

                entity.Property(e => e.CustomerId).HasColumnName("CustomerID");

                entity.Property(e => e.EstateId).HasColumnName("EstateID");

                entity.HasOne(d => d.Broker)
                    .WithMany(p => p.CaseOrders)
                    .HasForeignKey(d => d.BrokerId)
                    .HasConstraintName("FK__CaseOrder__Broke__7C4F7684");

                entity.HasOne(d => d.Customer)
                    .WithMany(p => p.CaseOrders)
                    .HasForeignKey(d => d.CustomerId)
                    .HasConstraintName("FK__CaseOrder__Custo__7B5B524B");

                entity.HasOne(d => d.Estate)
                    .WithMany(p => p.CaseOrders)
                    .HasForeignKey(d => d.EstateId)
                    .HasConstraintName("FK__CaseOrder__Estat__7D439ABD");
            });

            modelBuilder.Entity<Customer>(entity =>
            {
                entity.ToTable("Customer");

                entity.Property(e => e.CustomerId).HasColumnName("CustomerID");

                entity.Property(e => e.Address)
                    .HasMaxLength(55)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .HasMaxLength(45)
                    .IsUnicode(false);

                entity.HasOne(d => d.ZipCodeNavigation)
                    .WithMany(p => p.Customers)
                    .HasForeignKey(d => d.ZipCode)
                    .HasConstraintName("FK__Customer__ZipCod__75A278F5");
            });

            modelBuilder.Entity<Department>(entity =>
            {
                entity.ToTable("Department");

                entity.Property(e => e.DepartmentId).HasColumnName("DepartmentID");

                entity.Property(e => e.DepartmentName)
                    .HasMaxLength(55)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Estate>(entity =>
            {
                entity.ToTable("Estate");

                entity.Property(e => e.EstateId).HasColumnName("EstateID");

                entity.Property(e => e.Address)
                    .HasMaxLength(55)
                    .IsUnicode(false);

                entity.Property(e => e.Type)
                    .HasMaxLength(55)
                    .IsUnicode(false);

                entity.HasOne(d => d.ZipCodeNavigation)
                    .WithMany(p => p.Estates)
                    .HasForeignKey(d => d.ZipCode)
                    .HasConstraintName("FK__Estate__ZipCode__72C60C4A");
            });

            modelBuilder.Entity<OpenHouse>(entity =>
            {
                entity.ToTable("OpenHouse");

                entity.Property(e => e.OpenHouseId).HasColumnName("OpenHouseID");

                entity.Property(e => e.BrokerId).HasColumnName("BrokerID");

                entity.Property(e => e.CaseId).HasColumnName("CaseID");

                entity.Property(e => e.Date).HasColumnType("datetime");

                entity.HasOne(d => d.Broker)
                    .WithMany(p => p.OpenHouses)
                    .HasForeignKey(d => d.BrokerId)
                    .HasConstraintName("FK__OpenHouse__Broke__00200768");

                entity.HasOne(d => d.Case)
                    .WithMany(p => p.OpenHouses)
                    .HasForeignKey(d => d.CaseId)
                    .HasConstraintName("FK__OpenHouse__CaseI__01142BA1");
            });

            modelBuilder.Entity<PriceHistory>(entity =>
            {
                entity.ToTable("PriceHistory");

                entity.Property(e => e.PriceHistoryId).HasColumnName("PriceHistoryID");

                entity.Property(e => e.Date)
                    .HasColumnType("date")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.EstateId).HasColumnName("EstateID");

                entity.Property(e => e.Price).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.PriceType)
                    .HasMaxLength(45)
                    .IsUnicode(false);

                entity.HasOne(d => d.Estate)
                    .WithMany(p => p.PriceHistories)
                    .HasForeignKey(d => d.EstateId)
                    .HasConstraintName("FK__PriceHist__Estat__04E4BC85");
            });

            modelBuilder.Entity<ZipCode>(entity =>
            {
                entity.HasKey(e => e.ZipCode1)
                    .HasName("PK__ZipCode__2CC2CDB9596020E5");

                entity.ToTable("ZipCode");

                entity.Property(e => e.ZipCode1)
                    .ValueGeneratedNever()
                    .HasColumnName("ZipCode");

                entity.Property(e => e.City)
                    .HasMaxLength(45)
                    .IsUnicode(false);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
