﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using SMP.Data;

namespace SMP.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20210104152044_AspnetusersKompaniaIdDepartamentiId")]
    partial class AspnetusersKompaniaIdDepartamentiId
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedName")
                        .HasColumnType("nvarchar(256)")
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
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(128)")
                        .HasMaxLength(128);

                    b.Property<string>("ProviderKey")
                        .HasColumnType("nvarchar(128)")
                        .HasMaxLength(128);

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("RoleId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(128)")
                        .HasMaxLength(128);

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(128)")
                        .HasMaxLength(128);

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens");
                });

            modelBuilder.Entity("SMP.Data.ApplicationUser", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("Address")
                        .HasColumnType("nvarchar(200)")
                        .HasMaxLength(200);

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("DepartamentiId")
                        .HasColumnType("int");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("FirstName")
                        .HasColumnType("nvarchar(64)")
                        .HasMaxLength(64);

                    b.Property<string>("Image")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("KompaniaId")
                        .HasColumnType("int");

                    b.Property<string>("LastName")
                        .HasColumnType("nvarchar(64)")
                        .HasMaxLength(64);

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("NormalizedEmail")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedUserName")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("UserName")
                        .IsRequired()
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("DepartamentiId");

                    b.HasIndex("KompaniaId");

                    b.HasIndex("NormalizedEmail")
                        .HasName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers");
                });

            modelBuilder.Entity("SMP.Data.Banka", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Emri")
                        .IsRequired()
                        .HasColumnType("nvarchar(200)")
                        .HasMaxLength(200);

                    b.Property<string>("Kodi")
                        .IsRequired()
                        .HasColumnType("nvarchar(10)")
                        .HasMaxLength(10);

                    b.HasKey("Id");

                    b.ToTable("BANKA");
                });

            modelBuilder.Entity("SMP.Data.Bonuset", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("Bruto")
                        .HasColumnType("bit");

                    b.Property<DateTime>("Created")
                        .HasColumnType("datetime");

                    b.Property<string>("CreatedBy")
                        .IsRequired()
                        .HasColumnType("nvarchar(128)")
                        .HasMaxLength(128);

                    b.Property<int>("Muaji")
                        .HasColumnType("int");

                    b.Property<string>("Pershkrimi")
                        .IsRequired()
                        .HasColumnType("nvarchar(250)")
                        .HasMaxLength(250);

                    b.Property<int>("PunetoriId")
                        .HasColumnType("int");

                    b.Property<int>("Viti")
                        .HasColumnType("int");

                    b.Property<decimal>("Vlera")
                        .HasColumnType("decimal(18, 2)");

                    b.HasKey("Id");

                    b.HasIndex("PunetoriId");

                    b.ToTable("BONUSET");
                });

            modelBuilder.Entity("SMP.Data.Departamenti", b =>
                {
                    b.Property<int>("Id")
                        .HasColumnType("int");

                    b.Property<DateTime>("Created")
                        .HasColumnType("datetime");

                    b.Property<string>("CreatedBy")
                        .IsRequired()
                        .HasColumnType("nvarchar(128)")
                        .HasMaxLength(128);

                    b.Property<string>("Emri")
                        .IsRequired()
                        .HasColumnType("nvarchar(250)")
                        .HasMaxLength(250);

                    b.Property<int>("KompaniaId")
                        .HasColumnType("int");

                    b.Property<string>("Shkurtesa")
                        .IsRequired()
                        .HasColumnType("nvarchar(10)")
                        .HasMaxLength(10);

                    b.Property<bool>("Status")
                        .HasColumnType("bit");

                    b.HasKey("Id");

                    b.HasIndex("KompaniaId");

                    b.ToTable("DEPARTAMENTI");
                });

            modelBuilder.Entity("SMP.Data.Grada", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Emri")
                        .IsRequired()
                        .HasColumnType("nvarchar(100)")
                        .HasMaxLength(100);

                    b.Property<decimal>("PagaMujore")
                        .HasColumnType("decimal(18, 2)");

                    b.Property<decimal>("PagaVjetore")
                        .HasColumnType("decimal(18, 2)");

                    b.HasKey("Id");

                    b.ToTable("GRADA");
                });

            modelBuilder.Entity("SMP.Data.Kompania", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Emri")
                        .IsRequired()
                        .HasColumnType("nvarchar(200)")
                        .HasMaxLength(200);

                    b.Property<string>("Kodi")
                        .IsRequired()
                        .HasColumnType("nvarchar(10)")
                        .HasMaxLength(10);

                    b.Property<int>("KomunaId")
                        .HasColumnType("int");

                    b.Property<int>("Niveli")
                        .HasColumnType("int");

                    b.Property<int?>("ParentId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("KomunaId");

                    b.ToTable("KOMPANIA");
                });

            modelBuilder.Entity("SMP.Data.Komuna", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Emri")
                        .IsRequired()
                        .HasColumnType("nvarchar(250)")
                        .HasMaxLength(250);

                    b.HasKey("Id");

                    b.ToTable("KOMUNA");
                });

            modelBuilder.Entity("SMP.Data.LogUseractivity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Activity")
                        .IsRequired()
                        .HasColumnType("nvarchar(500)")
                        .HasMaxLength(500);

                    b.Property<DateTime>("EntryDate")
                        .HasColumnType("datetime");

                    b.Property<string>("HttpMethod")
                        .IsRequired()
                        .HasColumnType("nvarchar(500)")
                        .HasMaxLength(500);

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(128)")
                        .HasMaxLength(128);

                    b.HasKey("Id");

                    b.ToTable("LOG_USERACTIVITY");
                });

            modelBuilder.Entity("SMP.Data.Paga", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<decimal?>("Bonuse")
                        .HasColumnType("decimal(18, 2)");

                    b.Property<decimal>("Bruto")
                        .HasColumnType("decimal(18, 2)");

                    b.Property<string>("CreatedBy")
                        .IsRequired()
                        .HasColumnType("nvarchar(128)")
                        .HasMaxLength(128);

                    b.Property<DateTime>("DataEkzekutimit")
                        .HasColumnType("datetime");

                    b.Property<int>("GradaId")
                        .HasColumnType("int");

                    b.Property<decimal>("KontributiPunedhenesi")
                        .HasColumnType("decimal(18, 2)");

                    b.Property<decimal>("KontributiPunetori")
                        .HasColumnType("decimal(18, 2)");

                    b.Property<int>("MenyraEkzekutimit")
                        .HasColumnType("int");

                    b.Property<int>("Muaji")
                        .HasColumnType("int");

                    b.Property<decimal>("PagaFinale")
                        .HasColumnType("decimal(18, 2)");

                    b.Property<decimal>("PagaNeto")
                        .HasColumnType("decimal(18, 2)");

                    b.Property<decimal>("PagaTatim")
                        .HasColumnType("decimal(18, 2)");

                    b.Property<int>("PunetoriId")
                        .HasColumnType("int");

                    b.Property<decimal>("Tatimi")
                        .HasColumnType("decimal(18, 2)");

                    b.Property<int>("Viti")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("GradaId");

                    b.HasIndex("PunetoriId");

                    b.ToTable("PAGA");
                });

            modelBuilder.Entity("SMP.Data.Pozita", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("Created")
                        .HasColumnType("datetime");

                    b.Property<string>("CreatedBy")
                        .IsRequired()
                        .HasColumnType("nvarchar(128)")
                        .HasMaxLength(128);

                    b.Property<int>("DepartamentiId")
                        .HasColumnType("int");

                    b.Property<string>("Emri")
                        .IsRequired()
                        .HasColumnType("nvarchar(100)")
                        .HasMaxLength(100);

                    b.Property<int>("KompaniaId")
                        .HasColumnType("int");

                    b.Property<bool>("Status")
                        .HasColumnType("bit");

                    b.HasKey("Id");

                    b.HasIndex("DepartamentiId");

                    b.HasIndex("KompaniaId");

                    b.ToTable("POZITA");
                });

            modelBuilder.Entity("SMP.Data.Punetori", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Adresa")
                        .HasColumnType("nvarchar(250)")
                        .HasMaxLength(250);

                    b.Property<int>("BankaId")
                        .HasColumnType("int");

                    b.Property<DateTime>("Created")
                        .HasColumnType("datetime");

                    b.Property<string>("CreatedBy")
                        .IsRequired()
                        .HasColumnType("nvarchar(128)")
                        .HasMaxLength(128);

                    b.Property<DateTime>("Datelindja")
                        .HasColumnType("datetime");

                    b.Property<int>("DepartamentiId")
                        .HasColumnType("int");

                    b.Property<string>("Emri")
                        .IsRequired()
                        .HasColumnType("nvarchar(250)")
                        .HasMaxLength(250);

                    b.Property<int>("GradaId")
                        .HasColumnType("int");

                    b.Property<int>("KompaniaId")
                        .HasColumnType("int");

                    b.Property<int>("KomunaId")
                        .HasColumnType("int");

                    b.Property<string>("Mbiemri")
                        .IsRequired()
                        .HasColumnType("nvarchar(250)")
                        .HasMaxLength(250);

                    b.Property<string>("NumriPersonal")
                        .IsRequired()
                        .HasColumnType("nvarchar(10)")
                        .HasMaxLength(10);

                    b.Property<int>("PozitaId")
                        .HasColumnType("int");

                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(128)")
                        .HasMaxLength(128);

                    b.Property<string>("Xhirollogaria")
                        .IsRequired()
                        .HasColumnType("nvarchar(16)")
                        .HasMaxLength(16);

                    b.HasKey("Id");

                    b.HasIndex("BankaId");

                    b.HasIndex("DepartamentiId");

                    b.HasIndex("GradaId");

                    b.HasIndex("KompaniaId");

                    b.HasIndex("KomunaId");

                    b.HasIndex("PozitaId");

                    b.ToTable("PUNETORI");
                });

            modelBuilder.Entity("SMP.Data.PunetoriKontrata", b =>
                {
                    b.Property<int>("Id")
                        .HasColumnType("int");

                    b.Property<DateTime>("Created")
                        .HasColumnType("datetime");

                    b.Property<string>("CreatedBy")
                        .IsRequired()
                        .HasColumnType("nvarchar(128)")
                        .HasMaxLength(128);

                    b.Property<string>("Emri")
                        .IsRequired()
                        .HasColumnType("nchar(10)")
                        .IsFixedLength(true)
                        .HasMaxLength(10);

                    b.Property<string>("Path")
                        .IsRequired()
                        .HasColumnType("nvarchar(200)")
                        .HasMaxLength(200);

                    b.Property<int>("PunetoriId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("Status")
                        .HasColumnType("bit");

                    b.HasKey("Id");

                    b.HasIndex("PunetoriId");

                    b.ToTable("PUNETORI_KONTRATA");
                });

            modelBuilder.Entity("SMP.Data.Tatimi", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<decimal>("PerqindjaDyte")
                        .HasColumnType("decimal(18, 2)");

                    b.Property<decimal>("PerqindjaPare")
                        .HasColumnType("decimal(18, 2)");

                    b.Property<decimal>("PerqindjaTrete")
                        .HasColumnType("decimal(18, 2)");

                    b.Property<decimal>("PerqindjaZero")
                        .HasColumnType("decimal(18, 2)");

                    b.Property<decimal>("VleraDyte")
                        .HasColumnType("decimal(18, 2)");

                    b.Property<decimal>("VleraPare")
                        .HasColumnType("decimal(18, 2)");

                    b.Property<decimal>("VleraTrete")
                        .HasColumnType("decimal(18, 2)");

                    b.HasKey("Id");

                    b.ToTable("TATIMI");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("SMP.Data.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("SMP.Data.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("SMP.Data.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("SMP.Data.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("SMP.Data.ApplicationUser", b =>
                {
                    b.HasOne("SMP.Data.Departamenti", "Departamenti")
                        .WithMany()
                        .HasForeignKey("DepartamentiId");

                    b.HasOne("SMP.Data.Kompania", "Kompania")
                        .WithMany()
                        .HasForeignKey("KompaniaId");
                });

            modelBuilder.Entity("SMP.Data.Bonuset", b =>
                {
                    b.HasOne("SMP.Data.Punetori", "Punetori")
                        .WithMany("Bonuset")
                        .HasForeignKey("PunetoriId")
                        .HasConstraintName("FK_BONUSET_PUNETORI")
                        .IsRequired();
                });

            modelBuilder.Entity("SMP.Data.Departamenti", b =>
                {
                    b.HasOne("SMP.Data.Kompania", "Kompania")
                        .WithMany("Departamenti")
                        .HasForeignKey("KompaniaId")
                        .HasConstraintName("FK_DEPARTAMENTI_KOMPANIA")
                        .IsRequired();
                });

            modelBuilder.Entity("SMP.Data.Kompania", b =>
                {
                    b.HasOne("SMP.Data.Komuna", "Komuna")
                        .WithMany("Kompania")
                        .HasForeignKey("KomunaId")
                        .HasConstraintName("FK_KOMPANIA_KOMUNA")
                        .IsRequired();
                });

            modelBuilder.Entity("SMP.Data.Paga", b =>
                {
                    b.HasOne("SMP.Data.Grada", "Grada")
                        .WithMany("Paga")
                        .HasForeignKey("GradaId")
                        .HasConstraintName("FK_PAGA_GRADA")
                        .IsRequired();

                    b.HasOne("SMP.Data.Punetori", "Punetori")
                        .WithMany("Paga")
                        .HasForeignKey("PunetoriId")
                        .HasConstraintName("FK_PAGA_PUNETORI")
                        .IsRequired();
                });

            modelBuilder.Entity("SMP.Data.Pozita", b =>
                {
                    b.HasOne("SMP.Data.Departamenti", "Departamenti")
                        .WithMany("Pozita")
                        .HasForeignKey("DepartamentiId")
                        .HasConstraintName("FK_POZITA_DEPARTAMENTI")
                        .IsRequired();

                    b.HasOne("SMP.Data.Kompania", "Kompania")
                        .WithMany("Pozita")
                        .HasForeignKey("KompaniaId")
                        .HasConstraintName("FK_POZITA_KOMPANIA")
                        .IsRequired();
                });

            modelBuilder.Entity("SMP.Data.Punetori", b =>
                {
                    b.HasOne("SMP.Data.Banka", "Banka")
                        .WithMany("Punetori")
                        .HasForeignKey("BankaId")
                        .HasConstraintName("FK_PUNETORI_BANKA")
                        .IsRequired();

                    b.HasOne("SMP.Data.Departamenti", "Departamenti")
                        .WithMany("Punetori")
                        .HasForeignKey("DepartamentiId")
                        .HasConstraintName("FK_PUNETORI_DEPARTAMENTI")
                        .IsRequired();

                    b.HasOne("SMP.Data.Grada", "Grada")
                        .WithMany("Punetori")
                        .HasForeignKey("GradaId")
                        .HasConstraintName("FK_PUNETORI_GRADA")
                        .IsRequired();

                    b.HasOne("SMP.Data.Kompania", "Kompania")
                        .WithMany("Punetori")
                        .HasForeignKey("KompaniaId")
                        .HasConstraintName("FK_PUNETORI_KOMPANIA")
                        .IsRequired();

                    b.HasOne("SMP.Data.Komuna", "Komuna")
                        .WithMany("Punetori")
                        .HasForeignKey("KomunaId")
                        .HasConstraintName("FK_PUNETORI_KOMUNA")
                        .IsRequired();

                    b.HasOne("SMP.Data.Pozita", "Pozita")
                        .WithMany("Punetori")
                        .HasForeignKey("PozitaId")
                        .HasConstraintName("FK_PUNETORI_POZITA")
                        .IsRequired();
                });

            modelBuilder.Entity("SMP.Data.PunetoriKontrata", b =>
                {
                    b.HasOne("SMP.Data.Punetori", "Punetori")
                        .WithMany("PunetoriKontrata")
                        .HasForeignKey("PunetoriId")
                        .HasConstraintName("FK_PUNETORI_KONTRATA_PUNETORI")
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
