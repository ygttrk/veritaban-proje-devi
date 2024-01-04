﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using forms_turk.Context;

#nullable disable

namespace forms_turk.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20240103195833_createdbs2")]
    partial class createdbs2
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("forms_turk.Models.AlisVeris", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<bool>("IsAlis")
                        .HasColumnType("bit");

                    b.Property<DateTime>("IslemTarihi")
                        .HasColumnType("datetime2");

                    b.Property<int>("MusteriId")
                        .HasColumnType("int");

                    b.Property<int>("PersonelId")
                        .HasColumnType("int");

                    b.Property<decimal>("ToplamTutar")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("UrunAdeti")
                        .HasColumnType("int");

                    b.Property<int>("UrunId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("MusteriId");

                    b.HasIndex("PersonelId");

                    b.ToTable("AlisVeris");
                });

            modelBuilder.Entity("forms_turk.Models.AylikCiro", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("ay_bilgisi")
                        .HasColumnType("datetime2");

                    b.Property<decimal>("ciro")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("Id");

                    b.ToTable("AylikCiro");
                });

            modelBuilder.Entity("forms_turk.Models.Ilce", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("IlceAdi")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("SehirId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("SehirId");

                    b.ToTable("Ilce");
                });

            modelBuilder.Entity("forms_turk.Models.Mahalle", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("IlceId")
                        .HasColumnType("int");

                    b.Property<string>("MahalleAdi")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("IlceId");

                    b.ToTable("Mahalle");
                });

            modelBuilder.Entity("forms_turk.Models.Musteri", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Ad")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("AdresDetay")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Iletisim")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsKurumsal")
                        .HasColumnType("bit");

                    b.Property<int>("MahalleId")
                        .HasColumnType("int");

                    b.Property<string>("SirketAdi")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Soyad")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("MahalleId");

                    b.ToTable("Musteri");
                });

            modelBuilder.Entity("forms_turk.Models.Personel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Ad")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Soyad")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TelNo")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Personel");
                });

            modelBuilder.Entity("forms_turk.Models.Sehir", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("SehirAdi")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Sehir");
                });

            modelBuilder.Entity("forms_turk.Models.Urun", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<decimal>("Fiyat")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("StokBilgisi")
                        .HasColumnType("int");

                    b.Property<string>("UrunKodu")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UrunMarka")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UrunModel")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("UrunTuruId")
                        .HasColumnType("int");

                    b.Property<int?>("Urunid")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("UrunTuruId");

                    b.HasIndex("Urunid");

                    b.ToTable("Urun");
                });

            modelBuilder.Entity("forms_turk.Models.UrunTuru", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("UrunTuruAdi")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("UrunTuru");
                });

            modelBuilder.Entity("forms_turk.Models.AlisVeris", b =>
                {
                    b.HasOne("forms_turk.Models.Musteri", "Musteri")
                        .WithMany()
                        .HasForeignKey("MusteriId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("forms_turk.Models.Personel", "Personel")
                        .WithMany()
                        .HasForeignKey("PersonelId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Musteri");

                    b.Navigation("Personel");
                });

            modelBuilder.Entity("forms_turk.Models.Ilce", b =>
                {
                    b.HasOne("forms_turk.Models.Sehir", "Sehir")
                        .WithMany()
                        .HasForeignKey("SehirId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Sehir");
                });

            modelBuilder.Entity("forms_turk.Models.Mahalle", b =>
                {
                    b.HasOne("forms_turk.Models.Ilce", "Ilce")
                        .WithMany()
                        .HasForeignKey("IlceId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Ilce");
                });

            modelBuilder.Entity("forms_turk.Models.Musteri", b =>
                {
                    b.HasOne("forms_turk.Models.Mahalle", "Mahalle")
                        .WithMany()
                        .HasForeignKey("MahalleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Mahalle");
                });

            modelBuilder.Entity("forms_turk.Models.Urun", b =>
                {
                    b.HasOne("forms_turk.Models.UrunTuru", "UrunTuru")
                        .WithMany()
                        .HasForeignKey("UrunTuruId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("forms_turk.Models.AlisVeris", null)
                        .WithMany("Uruns")
                        .HasForeignKey("Urunid");

                    b.Navigation("UrunTuru");
                });

            modelBuilder.Entity("forms_turk.Models.AlisVeris", b =>
                {
                    b.Navigation("Uruns");
                });
#pragma warning restore 612, 618
        }
    }
}
