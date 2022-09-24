﻿// <auto-generated />
using System;
using DAL;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace DAL.Migrations
{
    [DbContext(typeof(context))]
    [Migration("20220809081856_migration1")]
    partial class migration1
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.7")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("Entity.Concrete.Arama", b =>
                {
                    b.Property<int>("Arama_id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Arama_id"));

                    b.Property<string>("Ad")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("Arama_tipi_id")
                        .HasColumnType("integer");

                    b.Property<int>("Arayan_tipi_id")
                        .HasColumnType("integer");

                    b.Property<string>("Konu")
                        .HasColumnType("text");

                    b.Property<string>("Tel")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Arama_id");

                    b.HasIndex("Arama_tipi_id");

                    b.HasIndex("Arayan_tipi_id");

                    b.ToTable("Arama");
                });

            modelBuilder.Entity("Entity.Concrete.AramaTipi", b =>
                {
                    b.Property<int>("Arama_tipi_id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Arama_tipi_id"));

                    b.Property<string>("Arama_tipi")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Arama_tipi_id");

                    b.ToTable("Arama_tipi");
                });

            modelBuilder.Entity("Entity.Concrete.ArayanTipi", b =>
                {
                    b.Property<int>("Arayan_tipi_id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Arayan_tipi_id"));

                    b.Property<string>("Arayan_tipi")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Arayan_tipi_id");

                    b.ToTable("Arayan_tipi");
                });

            modelBuilder.Entity("Entity.Concrete.Randevu_durumu", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("randevu_durumu")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Randevu_durumu");
                });

            modelBuilder.Entity("Entity.Concrete.Randevular", b =>
                {
                    b.Property<int>("Randevu_id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Randevu_id"));

                    b.Property<DateOnly>("Date")
                        .HasColumnType("date");

                    b.Property<DateTimeOffset>("EndTime")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("Konu")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("RandevuAlan")
                        .HasColumnType("integer");

                    b.Property<string>("Randevuya_Gelen")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<DateTimeOffset>("StartTime")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("Telefon")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("ZiyaretEdilen")
                        .HasColumnType("integer");

                    b.HasKey("Randevu_id");

                    b.HasIndex("RandevuAlan");

                    b.HasIndex("ZiyaretEdilen");

                    b.ToTable("Randevu");
                });

            modelBuilder.Entity("Entity.Concrete.Users", b =>
                {
                    b.Property<int>("User_id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("User_id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Surname")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Username")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("User_id");

                    b.ToTable("User");
                });

            modelBuilder.Entity("Entity.Concrete.Arama", b =>
                {
                    b.HasOne("Entity.Concrete.AramaTipi", "AramaTipi")
                        .WithMany("Aramalar")
                        .HasForeignKey("Arama_tipi_id")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("Entity.Concrete.ArayanTipi", "ArayanTipi")
                        .WithMany("Aramalar")
                        .HasForeignKey("Arayan_tipi_id")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("AramaTipi");

                    b.Navigation("ArayanTipi");
                });

            modelBuilder.Entity("Entity.Concrete.Randevular", b =>
                {
                    b.HasOne("Entity.Concrete.Users", "Randevu")
                        .WithMany("RandevuAl")
                        .HasForeignKey("RandevuAlan")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("Entity.Concrete.Users", "Ziyaret")
                        .WithMany("ZiyaretEt")
                        .HasForeignKey("ZiyaretEdilen")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("Randevu");

                    b.Navigation("Ziyaret");
                });

            modelBuilder.Entity("Entity.Concrete.AramaTipi", b =>
                {
                    b.Navigation("Aramalar");
                });

            modelBuilder.Entity("Entity.Concrete.ArayanTipi", b =>
                {
                    b.Navigation("Aramalar");
                });

            modelBuilder.Entity("Entity.Concrete.Users", b =>
                {
                    b.Navigation("RandevuAl");

                    b.Navigation("ZiyaretEt");
                });
#pragma warning restore 612, 618
        }
    }
}
