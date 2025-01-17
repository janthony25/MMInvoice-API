﻿// <auto-generated />
using MMInvoice_API.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace MMInvoice_API.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.7")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("MMInvoice_API.Models.Entity.tblCar", b =>
                {
                    b.Property<int>("CarId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CarId"));

                    b.Property<string>("CarModel")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CarRego")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("CustomerId")
                        .HasColumnType("int");

                    b.HasKey("CarId");

                    b.HasIndex("CustomerId");

                    b.ToTable("tblCar");
                });

            modelBuilder.Entity("MMInvoice_API.Models.Entity.tblCarMake", b =>
                {
                    b.Property<int>("CarMakeId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CarMakeId"));

                    b.Property<string>("CarMakeName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CarMakeId");

                    b.ToTable("tblCarMake");
                });

            modelBuilder.Entity("MMInvoice_API.Models.Entity.tblCarManufacturer", b =>
                {
                    b.Property<int>("CarId")
                        .HasColumnType("int");

                    b.Property<int>("CarMakeId")
                        .HasColumnType("int");

                    b.HasKey("CarId", "CarMakeId");

                    b.HasIndex("CarMakeId");

                    b.ToTable("tblCarManufacturer");
                });

            modelBuilder.Entity("MMInvoice_API.Models.Entity.tblCustomer", b =>
                {
                    b.Property<int>("CustomerId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CustomerId"));

                    b.Property<string>("CustomerEmail")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CustomerName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PaymentStatus")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CustomerId");

                    b.ToTable("tblCustomer");
                });

            modelBuilder.Entity("MMInvoice_API.Models.Entity.tblCar", b =>
                {
                    b.HasOne("MMInvoice_API.Models.Entity.tblCustomer", "tblCustomer")
                        .WithMany("tblCar")
                        .HasForeignKey("CustomerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("tblCustomer");
                });

            modelBuilder.Entity("MMInvoice_API.Models.Entity.tblCarManufacturer", b =>
                {
                    b.HasOne("MMInvoice_API.Models.Entity.tblCar", "tblCar")
                        .WithMany("tblCarManufacturer")
                        .HasForeignKey("CarId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("MMInvoice_API.Models.Entity.tblCarMake", "tblCarMake")
                        .WithMany("tblCarManufacturer")
                        .HasForeignKey("CarMakeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("tblCar");

                    b.Navigation("tblCarMake");
                });

            modelBuilder.Entity("MMInvoice_API.Models.Entity.tblCar", b =>
                {
                    b.Navigation("tblCarManufacturer");
                });

            modelBuilder.Entity("MMInvoice_API.Models.Entity.tblCarMake", b =>
                {
                    b.Navigation("tblCarManufacturer");
                });

            modelBuilder.Entity("MMInvoice_API.Models.Entity.tblCustomer", b =>
                {
                    b.Navigation("tblCar");
                });
#pragma warning restore 612, 618
        }
    }
}
