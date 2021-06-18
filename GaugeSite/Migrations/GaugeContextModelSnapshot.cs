﻿// <auto-generated />
using System;
using Gauge.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace GaugeSite.Migrations
{
    [DbContext(typeof(GaugeContext))]
    partial class GaugeContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.14")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("Gauge.Models.DateStat", b =>
                {
                    b.Property<int>("DateStatId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime(6)");

                    b.Property<bool>("IsCarriedOverFromPriorDay")
                        .HasColumnType("tinyint(1)");

                    b.Property<double>("PPRAverage")
                        .HasColumnType("double");

                    b.Property<double>("PPRMax")
                        .HasColumnType("double");

                    b.Property<double>("PPRMedian")
                        .HasColumnType("double");

                    b.Property<double>("PPRMin")
                        .HasColumnType("double");

                    b.Property<double>("PPRMode")
                        .HasColumnType("double");

                    b.Property<double>("PriceAverage")
                        .HasColumnType("double");

                    b.Property<double>("PriceMax")
                        .HasColumnType("double");

                    b.Property<double>("PriceMedian")
                        .HasColumnType("double");

                    b.Property<double>("PriceMin")
                        .HasColumnType("double");

                    b.Property<double>("PriceMode")
                        .HasColumnType("double");

                    b.Property<double>("RoundsAverage")
                        .HasColumnType("double");

                    b.Property<double>("RoundsMax")
                        .HasColumnType("double");

                    b.Property<double>("RoundsMedian")
                        .HasColumnType("double");

                    b.Property<double>("RoundsMin")
                        .HasColumnType("double");

                    b.Property<double>("RoundsMode")
                        .HasColumnType("double");

                    b.HasKey("DateStatId");

                    b.ToTable("DateStats");
                });

            modelBuilder.Entity("Gauge.Models.Observation", b =>
                {
                    b.Property<long>("ObsId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    b.Property<long>("BackupID")
                        .HasColumnType("bigint");

                    b.Property<byte>("IsPPR")
                        .HasColumnType("tinyint unsigned");

                    b.Property<double>("PPR")
                        .HasColumnType("double");

                    b.Property<double>("Price")
                        .HasColumnType("double");

                    b.Property<string>("ProductSource")
                        .HasColumnType("varchar(15) CHARACTER SET utf8mb4")
                        .HasMaxLength(15);

                    b.Property<string>("ProductTitle")
                        .HasColumnType("varchar(35) CHARACTER SET utf8mb4")
                        .HasMaxLength(35);

                    b.Property<int>("Rounds")
                        .HasColumnType("int");

                    b.Property<string>("ScrapeUrl")
                        .HasColumnType("varchar(50) CHARACTER SET utf8mb4")
                        .HasMaxLength(50);

                    b.Property<DateTime>("WhenObserved")
                        .HasColumnType("datetime(6)");

                    b.HasKey("ObsId");

                    b.ToTable("Observations");
                });
#pragma warning restore 612, 618
        }
    }
}
