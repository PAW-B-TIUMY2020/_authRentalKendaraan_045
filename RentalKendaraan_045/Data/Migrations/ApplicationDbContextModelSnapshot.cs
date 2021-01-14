﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using RentalKendaraan_045.Models;

namespace RentalKendaraan_045.Data.Migrations
{
    [DbContext(typeof(RentKendaraanContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.14-servicing-32113")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken();

                    b.Property<string>("Name")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType");

                    b.Property<string>("ClaimValue");

                    b.Property<string>("RoleId")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUser", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("AccessFailedCount");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken();

                    b.Property<string>("Email")
                        .HasMaxLength(256);

                    b.Property<bool>("EmailConfirmed");

                    b.Property<bool>("LockoutEnabled");

                    b.Property<DateTimeOffset?>("LockoutEnd");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256);

                    b.Property<string>("PasswordHash");

                    b.Property<string>("PhoneNumber");

                    b.Property<bool>("PhoneNumberConfirmed");

                    b.Property<string>("SecurityStamp");

                    b.Property<bool>("TwoFactorEnabled");

                    b.Property<string>("UserName")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType");

                    b.Property<string>("ClaimValue");

                    b.Property<string>("UserId")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider");

                    b.Property<string>("ProviderKey");

                    b.Property<string>("ProviderDisplayName");

                    b.Property<string>("UserId")
                        .IsRequired();

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId");

                    b.Property<string>("RoleId");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId");

                    b.Property<string>("LoginProvider");

                    b.Property<string>("Name");

                    b.Property<string>("Value");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens");
                });

            modelBuilder.Entity("RentalKendaraan_045.Models.Customer", b =>
                {
                    b.Property<int>("IdCustomer")
                        .HasColumnName("ID_Customer");

                    b.Property<string>("Alamat")
                        .IsRequired()
                        .HasMaxLength(150)
                        .IsUnicode(false);

                    b.Property<int?>("IdGender")
                        .IsRequired()
                        .HasColumnName("ID_Gender");

                    b.Property<string>("NamaCustomer")
                        .IsRequired()
                        .HasColumnName("Nama_Customer")
                        .HasMaxLength(30)
                        .IsUnicode(false);

                    b.Property<string>("Nik")
                        .HasColumnName("NIK")
                        .HasMaxLength(16)
                        .IsUnicode(false);

                    b.Property<string>("NoHp")
                        .IsRequired()
                        .HasColumnName("No_HP")
                        .HasMaxLength(13)
                        .IsUnicode(false);

                    b.HasKey("IdCustomer");

                    b.HasIndex("IdGender");

                    b.ToTable("Customer");
                });

            modelBuilder.Entity("RentalKendaraan_045.Models.Gender", b =>
                {
                    b.Property<int>("IdGender")
                        .HasColumnName("ID_Gender");

                    b.Property<string>("NamaGender")
                        .IsRequired()
                        .HasColumnName("Nama_Gender")
                        .HasMaxLength(1)
                        .IsUnicode(false);

                    b.HasKey("IdGender");

                    b.ToTable("Gender");
                });

            modelBuilder.Entity("RentalKendaraan_045.Models.Jaminan", b =>
                {
                    b.Property<int>("IdJaminan")
                        .HasColumnName("ID_Jaminan");

                    b.Property<string>("NamaJaminan")
                        .IsRequired()
                        .HasColumnName("Nama_Jaminan")
                        .HasMaxLength(40)
                        .IsUnicode(false);

                    b.HasKey("IdJaminan");

                    b.ToTable("Jaminan");
                });

            modelBuilder.Entity("RentalKendaraan_045.Models.JenisKendaraan", b =>
                {
                    b.Property<int>("IdJenisKendaraan")
                        .HasColumnName("ID_Jenis_Kendaraan");

                    b.Property<string>("NamaJenisKendaraan")
                        .IsRequired()
                        .HasColumnName("Nama_Jenis_Kendaraan")
                        .HasMaxLength(30)
                        .IsUnicode(false);

                    b.HasKey("IdJenisKendaraan");

                    b.ToTable("Jenis_Kendaraan");
                });

            modelBuilder.Entity("RentalKendaraan_045.Models.Kendaraan", b =>
                {
                    b.Property<int>("IdKendaraan")
                        .HasColumnName("ID_Kendaraan");

                    b.Property<int?>("IdJenisKendaraan")
                        .IsRequired()
                        .HasColumnName("ID_Jenis_kendaraan");

                    b.Property<string>("Ketersediaan")
                        .IsRequired()
                        .HasMaxLength(15)
                        .IsUnicode(false);

                    b.Property<string>("NamaKendaraan")
                        .IsRequired()
                        .HasColumnName("Nama_Kendaraan")
                        .HasMaxLength(25)
                        .IsUnicode(false);

                    b.Property<string>("NoPolisi")
                        .IsRequired()
                        .HasColumnName("No_Polisi")
                        .HasMaxLength(15)
                        .IsUnicode(false);

                    b.Property<string>("NoStnk")
                        .IsRequired()
                        .HasColumnName("No_STNK")
                        .HasMaxLength(8)
                        .IsUnicode(false);

                    b.HasKey("IdKendaraan");

                    b.HasIndex("IdJenisKendaraan");

                    b.ToTable("Kendaraan");
                });

            modelBuilder.Entity("RentalKendaraan_045.Models.KondisiKendaraan", b =>
                {
                    b.Property<int>("IdKondisi")
                        .HasColumnName("ID_Kondisi");

                    b.Property<string>("NamaKondisi")
                        .IsRequired()
                        .HasColumnName("Nama_Kondisi")
                        .HasMaxLength(30)
                        .IsUnicode(false);

                    b.HasKey("IdKondisi");

                    b.ToTable("Kondisi_Kendaraan");
                });

            modelBuilder.Entity("RentalKendaraan_045.Models.Peminjaman", b =>
                {
                    b.Property<int>("IdPeminjaman")
                        .HasColumnName("ID_Peminjaman");

                    b.Property<int?>("Biaya")
                        .IsRequired();

                    b.Property<int?>("IdCostumer")
                        .IsRequired()
                        .HasColumnName("ID_Customer");

                    b.Property<int?>("IdJaminan")
                        .IsRequired()
                        .HasColumnName("ID_Jaminan");

                    b.Property<int?>("IdKendaraan")
                        .IsRequired()
                        .HasColumnName("ID_Kendaraan");

                    b.Property<DateTime?>("TglPeminjaman")
                        .IsRequired()
                        .HasColumnName("Tgl_Peminjaman")
                        .HasColumnType("datetime");

                    b.HasKey("IdPeminjaman");

                    b.HasIndex("IdCostumer");

                    b.HasIndex("IdJaminan");

                    b.HasIndex("IdKendaraan");

                    b.ToTable("Peminjaman");
                });

            modelBuilder.Entity("RentalKendaraan_045.Models.Pengembalian", b =>
                {
                    b.Property<int>("IdPengembalian")
                        .HasColumnName("ID_Pengembalian");

                    b.Property<int?>("Denda")
                        .IsRequired();

                    b.Property<int?>("IdKondisi")
                        .IsRequired()
                        .HasColumnName("ID_Kondisi");

                    b.Property<int?>("IdPeminjaman")
                        .IsRequired()
                        .HasColumnName("ID_Peminjaman");

                    b.Property<DateTime?>("TglPengembalian")
                        .IsRequired()
                        .HasColumnName("Tgl_Pengembalian")
                        .HasColumnType("datetime");

                    b.HasKey("IdPengembalian");

                    b.HasIndex("IdKondisi");

                    b.HasIndex("IdPeminjaman");

                    b.ToTable("Pengembalian");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole")
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole")
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("RentalKendaraan_045.Models.Customer", b =>
                {
                    b.HasOne("RentalKendaraan_045.Models.Gender", "IdGenderNavigation")
                        .WithMany("Customer")
                        .HasForeignKey("IdGender")
                        .HasConstraintName("FK_Customer_Gender")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("RentalKendaraan_045.Models.Kendaraan", b =>
                {
                    b.HasOne("RentalKendaraan_045.Models.JenisKendaraan", "IdJenisKendaraanNavigation")
                        .WithMany("Kendaraan")
                        .HasForeignKey("IdJenisKendaraan")
                        .HasConstraintName("FK_Kendaraan_Jenis_Kendaraan")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("RentalKendaraan_045.Models.Peminjaman", b =>
                {
                    b.HasOne("RentalKendaraan_045.Models.Customer", "IdCostumerNavigation")
                        .WithMany("Peminjaman")
                        .HasForeignKey("IdCostumer")
                        .HasConstraintName("FK_Peminjaman_Customer")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("RentalKendaraan_045.Models.Jaminan", "IdJaminanNavigation")
                        .WithMany("Peminjaman")
                        .HasForeignKey("IdJaminan")
                        .HasConstraintName("FK_Peminjaman_Jaminan")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("RentalKendaraan_045.Models.Kendaraan", "IdKendaraanNavigation")
                        .WithMany("Peminjaman")
                        .HasForeignKey("IdKendaraan")
                        .HasConstraintName("FK_Peminjaman_Kendaraan")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("RentalKendaraan_045.Models.Pengembalian", b =>
                {
                    b.HasOne("RentalKendaraan_045.Models.KondisiKendaraan", "IdKondisiNavigation")
                        .WithMany("Pengembalian")
                        .HasForeignKey("IdKondisi")
                        .HasConstraintName("FK_Pengembalian_Kondisi_Kendaraan")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("RentalKendaraan_045.Models.Peminjaman", "IdPeminjamanNavigation")
                        .WithMany("Pengembalian")
                        .HasForeignKey("IdPeminjaman")
                        .HasConstraintName("FK_Pengembalian_Peminjaman")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
