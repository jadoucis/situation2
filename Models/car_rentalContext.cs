using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace Car_Rental.Models
{
    public partial class car_rentalContext : DbContext
    {
        public car_rentalContext()
        {
        }

        public car_rentalContext(DbContextOptions<car_rentalContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Car> Cars { get; set; }
        public virtual DbSet<CarModel> Carmodels { get; set; }
        public virtual DbSet<Command> Commands { get; set; }
        public virtual DbSet<Customer> Customers { get; set; }
        public virtual DbSet<Member> Members { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseMySql("server=localhost;database=car_rental;uid=root", Microsoft.EntityFrameworkCore.ServerVersion.Parse("5.7.31-mysql"));
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasCharSet("latin1")
                .UseCollation("latin1_swedish_ci");

            modelBuilder.Entity<Car>(entity =>
            {
                entity.HasKey(e => e.IdCar)
                    .HasName("PRIMARY");

                entity.ToTable("car");

                entity.HasIndex(e => e.IdCarModel, "car_carModel_FK");

                entity.Property(e => e.IdCar)
                    .HasColumnType("int(11)")
                    .HasColumnName("Id_Car");

                entity.Property(e => e.DescriptionCar)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasColumnName("Description_Car");

                entity.Property(e => e.IdCarModel)
                    .HasColumnType("int(11)")
                    .HasColumnName("Id_CarModel");

                entity.Property(e => e.IsRentedCar).HasColumnName("IsRented_Car");
                entity.Property(e => e.NeedReparedCar).HasColumnName("NeedRepared_Car");

                entity.Property(e => e.LicenseCar)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("License_Car");

                entity.Property(e => e.NameCar)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasColumnName("Name_Car");

                entity.Property(e => e.PriceCar).HasColumnName("Price_Car");

                entity.Property(e => e.SlotCar)
                    .HasColumnType("int(11)")
                    .HasColumnName("Slot_Car");

                entity.HasOne(d => d.IdCarModelNavigation)
                    .WithMany(p => p.Cars)
                    .HasForeignKey(d => d.IdCarModel)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("car_carModel_FK");
            });

            modelBuilder.Entity<CarModel>(entity =>
            {
                entity.HasKey(e => e.IdCarModel)
                    .HasName("PRIMARY");

                entity.ToTable("carmodel");

                entity.Property(e => e.IdCarModel)
                    .HasColumnType("int(11)")
                    .HasColumnName("Id_CarModel");

                entity.Property(e => e.NameCarModel)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasColumnName("Name_CarModel");
            });

            modelBuilder.Entity<Command>(entity =>
            {
                entity.HasKey(e => e.IdCommand)
                    .HasName("PRIMARY");

                entity.ToTable("command");

                entity.HasIndex(e => e.IdCar, "command_car0_FK");

                entity.HasIndex(e => e.IdCustomer, "command_customer_FK");

                entity.Property(e => e.IdCommand)
                    .HasColumnType("int(11)")
                    .HasColumnName("Id_Command");

                entity.Property(e => e.DateEndCommand)
                    .HasColumnType("date")
                    .HasColumnName("DateEnd_Command");

                entity.Property(e => e.DateStartCommand)
                    .HasColumnType("date")
                    .HasColumnName("DateStart_Command");

                entity.Property(e => e.HasPaiedDepositCommand).HasColumnName("HasPaiedDeposit_Command");

                entity.Property(e => e.IdCar)
                    .HasColumnType("int(11)")
                    .HasColumnName("Id_Car");

                entity.Property(e => e.IdCustomer)
                    .HasColumnType("int(11)")
                    .HasColumnName("Id_Customer");

                entity.HasOne(d => d.IdCarNavigation)
                    .WithMany(p => p.Commands)
                    .HasForeignKey(d => d.IdCar)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("command_car0_FK");

                entity.HasOne(d => d.IdCustomerNavigation)
                    .WithMany(p => p.Commands)
                    .HasForeignKey(d => d.IdCustomer)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("command_customer_FK");
            });

            modelBuilder.Entity<Customer>(entity =>
            {
                entity.HasKey(e => e.IdCustomer)
                    .HasName("PRIMARY");

                entity.ToTable("customer");

                entity.Property(e => e.IdCustomer)
                    .HasColumnType("int(11)")
                    .HasColumnName("Id_Customer");

                entity.Property(e => e.AgeCustomer)
                    .HasColumnType("date")
                    .HasColumnName("Age_Customer");

                entity.Property(e => e.CarLicenseCustomer).HasColumnName("CarLicense_Customer");

                entity.Property(e => e.FirstNameCustomer)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasColumnName("FirstName_Customer");

                entity.Property(e => e.HasRentedCustomer).HasColumnName("HasRented_Customer");

                entity.Property(e => e.LastNameCustomer)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasColumnName("LastName_Customer");

                entity.Property(e => e.MailCustomer)
                    .IsRequired()
                    .HasMaxLength(200)
                    .HasColumnName("Mail_Customer");
            });

            modelBuilder.Entity<Member>(entity =>
            {
                entity.HasKey(e => e.IdMember)
                    .HasName("PRIMARY");

                entity.ToTable("member");

                entity.Property(e => e.IdMember)
                    .HasColumnType("int(11)")
                    .HasColumnName("Id_Member");

                entity.Property(e => e.LoginMember)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasColumnName("Login_Member");

                entity.Property(e => e.PasswordMember)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasColumnName("Password_Member");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
