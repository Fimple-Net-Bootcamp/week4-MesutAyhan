﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using week4.Entitites;

#nullable disable

namespace week4.Migrations
{
    [DbContext(typeof(SanalHayvanDbContext))]
    partial class SanalHayvanDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("EvcilHayvanSosyalEtkilesim", b =>
                {
                    b.Property<int>("KatilanEvcilHayvanlarId")
                        .HasColumnType("int");

                    b.Property<int>("SosyalEtkilesimlerId")
                        .HasColumnType("int");

                    b.HasKey("KatilanEvcilHayvanlarId", "SosyalEtkilesimlerId");

                    b.HasIndex("SosyalEtkilesimlerId");

                    b.ToTable("EvcilHayvanSosyalEtkilesim");
                });

            modelBuilder.Entity("week4.Entitites.Aktivite", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("AktiviteAdi")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("EvcilHayvanId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("EvcilHayvanId");

                    b.ToTable("Aktivites");
                });

            modelBuilder.Entity("week4.Entitites.Besin", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Adi")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("EvcilHayvanId")
                        .HasColumnType("int");

                    b.Property<string>("Miktar")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("EvcilHayvanId");

                    b.ToTable("Besins");
                });

            modelBuilder.Entity("week4.Entitites.Egitim", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Adi")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("EvcilHayvanId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("EvcilHayvanId");

                    b.ToTable("Egitims");
                });

            modelBuilder.Entity("week4.Entitites.EvcilHayvan", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Isim")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("KullaniciId")
                        .HasColumnType("int");

                    b.Property<int>("SaglikDurumuId")
                        .HasColumnType("int");

                    b.Property<string>("Tur")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("KullaniciId");

                    b.HasIndex("SaglikDurumuId");

                    b.ToTable("EvcilHayvans");
                });

            modelBuilder.Entity("week4.Entitites.Kullanici", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("KullaniciAdi")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Kullanicis");
                });

            modelBuilder.Entity("week4.Entitites.SaglikDurumu", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Durum")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("SaglikDurumus");
                });

            modelBuilder.Entity("week4.Entitites.SosyalEtkilesim", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Turu")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("SosyalEtkilesims");
                });

            modelBuilder.Entity("EvcilHayvanSosyalEtkilesim", b =>
                {
                    b.HasOne("week4.Entitites.EvcilHayvan", null)
                        .WithMany()
                        .HasForeignKey("KatilanEvcilHayvanlarId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("week4.Entitites.SosyalEtkilesim", null)
                        .WithMany()
                        .HasForeignKey("SosyalEtkilesimlerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("week4.Entitites.Aktivite", b =>
                {
                    b.HasOne("week4.Entitites.EvcilHayvan", "EvcilHayvan")
                        .WithMany("Aktiviteler")
                        .HasForeignKey("EvcilHayvanId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("EvcilHayvan");
                });

            modelBuilder.Entity("week4.Entitites.Besin", b =>
                {
                    b.HasOne("week4.Entitites.EvcilHayvan", "EvcilHayvan")
                        .WithMany("Besinler")
                        .HasForeignKey("EvcilHayvanId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("EvcilHayvan");
                });

            modelBuilder.Entity("week4.Entitites.Egitim", b =>
                {
                    b.HasOne("week4.Entitites.EvcilHayvan", "EvcilHayvan")
                        .WithMany("Egitimler")
                        .HasForeignKey("EvcilHayvanId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("EvcilHayvan");
                });

            modelBuilder.Entity("week4.Entitites.EvcilHayvan", b =>
                {
                    b.HasOne("week4.Entitites.Kullanici", "Kullanici")
                        .WithMany("EvcilHayvanlar")
                        .HasForeignKey("KullaniciId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("week4.Entitites.SaglikDurumu", "SaglikDurumu")
                        .WithMany()
                        .HasForeignKey("SaglikDurumuId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Kullanici");

                    b.Navigation("SaglikDurumu");
                });

            modelBuilder.Entity("week4.Entitites.EvcilHayvan", b =>
                {
                    b.Navigation("Aktiviteler");

                    b.Navigation("Besinler");

                    b.Navigation("Egitimler");
                });

            modelBuilder.Entity("week4.Entitites.Kullanici", b =>
                {
                    b.Navigation("EvcilHayvanlar");
                });
#pragma warning restore 612, 618
        }
    }
}