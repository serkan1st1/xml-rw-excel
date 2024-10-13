﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using TaskMvc.Data;

#nullable disable

namespace TaskMvc.Migrations
{
    [DbContext(typeof(AppDbContext))]
    partial class AppDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.35")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("TaskMvc.Models.FaturaBilgileri", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"), 1L, 1);

                    b.Property<string>("FaturaNo")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("FaturaParaBirimi")
                        .IsRequired()
                        .HasMaxLength(3)
                        .HasColumnType("nvarchar(3)");

                    b.Property<DateTime>("FaturaTarih")
                        .HasColumnType("datetime2");

                    b.Property<string>("FaturaTeslimSekli")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("FaturaTuru")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<decimal>("FaturaTutari")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("GenelBilgilerID")
                        .HasColumnType("int");

                    b.Property<string>("OdemeSekli")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("ID");

                    b.HasIndex("GenelBilgilerID");

                    b.ToTable("FaturaBilgileri");
                });

            modelBuilder.Entity("TaskMvc.Models.GenelBilgiler", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"), 1L, 1);

                    b.Property<string>("BelgeNo")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<int>("DepoKullanimBelgeNo")
                        .HasColumnType("int");

                    b.Property<string>("DepoKullanimBelgeliFirma")
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<string>("DisReferansNo")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<string>("FirmaFaaliyetRuhsatiKonusu")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<string>("FirmaFaaliyetRuhsatiNo")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<string>("FirmaTelefonu")
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<string>("FirmaTicaretUnvani")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<string>("FormDurumu")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<string>("FormuDolduraninAdi")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<string>("GumrukId")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<string>("IslemKonusu")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<string>("IslemKonusuTicari")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<string>("IslemKonusuTicariOlmayan")
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<string>("IslemTuru")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<string>("IslemYonu")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<DateTime>("KayitTarihi")
                        .HasColumnType("datetime2");

                    b.Property<string>("SerbestBolgeAdi")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<string>("SevkiyatSekliAdi")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.HasKey("ID");

                    b.ToTable("GenelBilgiler");
                });

            modelBuilder.Entity("TaskMvc.Models.KarsiFirmaBilgisi", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"), 1L, 1);

                    b.Property<string>("AdiUnvani")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<string>("Adresi")
                        .IsRequired()
                        .HasMaxLength(500)
                        .HasColumnType("nvarchar(500)");

                    b.Property<string>("EPosta")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<string>("Faks1")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<string>("Faks2")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<int>("FaturaID")
                        .HasColumnType("int");

                    b.Property<string>("Telefon1")
                        .IsRequired()
                        .HasMaxLength(15)
                        .HasColumnType("nvarchar(15)");

                    b.Property<string>("Telefon2")
                        .IsRequired()
                        .HasMaxLength(15)
                        .HasColumnType("nvarchar(15)");

                    b.Property<string>("Telefon3")
                        .IsRequired()
                        .HasMaxLength(15)
                        .HasColumnType("nvarchar(15)");

                    b.Property<string>("Ulke")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("VergiDairesi")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("VergiKimlikNo")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<string>("WebAdresi")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.HasKey("ID");

                    b.HasIndex("FaturaID");

                    b.ToTable("KarsiFirmaBilgisi");
                });

            modelBuilder.Entity("TaskMvc.Models.MalKalemBilgileri", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"), 1L, 1);

                    b.Property<string>("BirinciBirim")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<decimal>("BirinciMiktar")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("BrutAgirlik")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("Cins")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<int>("FaturaID")
                        .HasColumnType("int");

                    b.Property<string>("GeldigiGidecegiUlke")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<int>("GumrukSiraNo")
                        .HasColumnType("int");

                    b.Property<int>("KapAdedi")
                        .HasColumnType("int");

                    b.Property<string>("KapTuru")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<decimal>("MalBedeli")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("MalBedeliParaBirimi")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("MalKalemId")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("MalKalemTeslimSekli")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("Mensei")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<decimal>("NavlunBedeli")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("NavlunBedeliParaBirimi")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<decimal>("SigortaBedeli")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("SigortaBedeliParaBirimi")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<int>("SiraNo")
                        .HasColumnType("int");

                    b.Property<string>("gtip")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.HasKey("ID");

                    b.HasIndex("FaturaID");

                    b.ToTable("MalKalemBilgileri");
                });

            modelBuilder.Entity("TaskMvc.Models.SbifBilgiFisi", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"), 1L, 1);

                    b.Property<string>("FonDekontDekontNo")
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<decimal>("FonDekontKullanilan")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("FonDekontKullanilanDolar")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("FonDekontKullanilanPB")
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<DateTime?>("FonDekontTarih")
                        .HasColumnType("datetime2");

                    b.Property<decimal>("FonDekontTutar")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("FonDekontTutarPB")
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<int>("GenelBilgilerID")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.HasIndex("GenelBilgilerID");

                    b.ToTable("SbifBilgiFisi");
                });

            modelBuilder.Entity("TaskMvc.Models.TalepEdilenIsleticiHizmetleri", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"), 1L, 1);

                    b.Property<string>("DigerTalepEdilenHizmetler")
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<string>("Ellecleme")
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<int>("GenelBilgilerID")
                        .HasColumnType("int");

                    b.Property<string>("IsMakinasi")
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<string>("Kantar")
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<string>("KoordinasyonHizmeti")
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<string>("OrtakDepo")
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<string>("YuklemeBosaltma")
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.HasKey("ID");

                    b.HasIndex("GenelBilgilerID");

                    b.ToTable("TalepEdilenIsleticiHizmetleri");
                });

            modelBuilder.Entity("TaskMvc.Models.TeslimAdresi", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"), 1L, 1);

                    b.Property<string>("AdiTicaretUnvani")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<string>("Adresi")
                        .IsRequired()
                        .HasMaxLength(500)
                        .HasColumnType("nvarchar(500)");

                    b.Property<string>("EPosta")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<string>("Faks1")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<string>("Faks2")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<int>("FaturaID")
                        .HasColumnType("int");

                    b.Property<string>("Il")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("Ilce")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("PostaKodu")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<string>("Telefon1")
                        .IsRequired()
                        .HasMaxLength(15)
                        .HasColumnType("nvarchar(15)");

                    b.Property<string>("Telefon2")
                        .IsRequired()
                        .HasMaxLength(15)
                        .HasColumnType("nvarchar(15)");

                    b.Property<string>("Telefon3")
                        .IsRequired()
                        .HasMaxLength(15)
                        .HasColumnType("nvarchar(15)");

                    b.Property<string>("Ulke")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("ID");

                    b.HasIndex("FaturaID");

                    b.ToTable("TeslimAdresi");
                });

            modelBuilder.Entity("TaskMvc.Models.FaturaBilgileri", b =>
                {
                    b.HasOne("TaskMvc.Models.GenelBilgiler", "GenelBilgiler")
                        .WithMany()
                        .HasForeignKey("GenelBilgilerID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("GenelBilgiler");
                });

            modelBuilder.Entity("TaskMvc.Models.KarsiFirmaBilgisi", b =>
                {
                    b.HasOne("TaskMvc.Models.FaturaBilgileri", "FaturaBilgileri")
                        .WithMany()
                        .HasForeignKey("FaturaID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("FaturaBilgileri");
                });

            modelBuilder.Entity("TaskMvc.Models.MalKalemBilgileri", b =>
                {
                    b.HasOne("TaskMvc.Models.FaturaBilgileri", "FaturaBilgileri")
                        .WithMany()
                        .HasForeignKey("FaturaID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("FaturaBilgileri");
                });

            modelBuilder.Entity("TaskMvc.Models.SbifBilgiFisi", b =>
                {
                    b.HasOne("TaskMvc.Models.GenelBilgiler", "GenelBilgiler")
                        .WithMany()
                        .HasForeignKey("GenelBilgilerID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("GenelBilgiler");
                });

            modelBuilder.Entity("TaskMvc.Models.TalepEdilenIsleticiHizmetleri", b =>
                {
                    b.HasOne("TaskMvc.Models.GenelBilgiler", "GenelBilgiler")
                        .WithMany()
                        .HasForeignKey("GenelBilgilerID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("GenelBilgiler");
                });

            modelBuilder.Entity("TaskMvc.Models.TeslimAdresi", b =>
                {
                    b.HasOne("TaskMvc.Models.FaturaBilgileri", "FaturaBilgileri")
                        .WithMany()
                        .HasForeignKey("FaturaID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("FaturaBilgileri");
                });
#pragma warning restore 612, 618
        }
    }
}
