﻿// <auto-generated />
using System;
using IT___Telefaune.Models.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace IT___Telefaune.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseIdentityColumns()
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.1");

            modelBuilder.Entity("IT___Telefaune.Models.AdminModel", b =>
                {
                    b.Property<int>("AdminId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("ConfirmPasssword")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("AdminId");

                    b.ToTable("Admin");
                });

            modelBuilder.Entity("IT___Telefaune.Models.SalarieModel", b =>
                {
                    b.Property<int>("SalarieId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nom")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("NomSiteSiteId")
                        .HasColumnType("int");

                    b.Property<string>("NomSiteWrong")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Prenom")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ServiceId")
                        .HasColumnType("int");

                    b.Property<int>("SiteId")
                        .HasColumnType("int");

                    b.Property<int>("TelephoneFixe")
                        .HasColumnType("int");

                    b.Property<int>("TelephonePortable")
                        .HasColumnType("int");

                    b.Property<int?>("TypeServiceServiceId")
                        .HasColumnType("int");

                    b.Property<string>("TypeServiceWrong")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("SalarieId");

                    b.HasIndex("NomSiteSiteId");

                    b.HasIndex("TypeServiceServiceId");

                    b.ToTable("Salarie");
                });

            modelBuilder.Entity("IT___Telefaune.Models.ServiceModel", b =>
                {
                    b.Property<int>("ServiceId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("TypeService")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ServiceId");

                    b.ToTable("Service");
                });

            modelBuilder.Entity("IT___Telefaune.Models.SiteModel", b =>
                {
                    b.Property<int>("SiteId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("NomSite")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ServiceId")
                        .HasColumnType("int");

                    b.Property<int?>("TypeServiceServiceId")
                        .HasColumnType("int");

                    b.Property<string>("TypeServiceWrong")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Ville")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("SiteId");

                    b.HasIndex("TypeServiceServiceId");

                    b.ToTable("Site");
                });

            modelBuilder.Entity("IT___Telefaune.Models.SalarieModel", b =>
                {
                    b.HasOne("IT___Telefaune.Models.SiteModel", "NomSite")
                        .WithMany("Salarie")
                        .HasForeignKey("NomSiteSiteId");

                    b.HasOne("IT___Telefaune.Models.ServiceModel", "TypeService")
                        .WithMany("Salarie")
                        .HasForeignKey("TypeServiceServiceId");

                    b.Navigation("NomSite");

                    b.Navigation("TypeService");
                });

            modelBuilder.Entity("IT___Telefaune.Models.SiteModel", b =>
                {
                    b.HasOne("IT___Telefaune.Models.ServiceModel", "TypeService")
                        .WithMany("Site")
                        .HasForeignKey("TypeServiceServiceId");

                    b.Navigation("TypeService");
                });

            modelBuilder.Entity("IT___Telefaune.Models.ServiceModel", b =>
                {
                    b.Navigation("Salarie");

                    b.Navigation("Site");
                });

            modelBuilder.Entity("IT___Telefaune.Models.SiteModel", b =>
                {
                    b.Navigation("Salarie");
                });
#pragma warning restore 612, 618
        }
    }
}
