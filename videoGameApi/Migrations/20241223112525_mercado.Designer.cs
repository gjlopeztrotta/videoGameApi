﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using videoGameApi.Model.Database;

#nullable disable

namespace videoGameApi.Migrations
{
    [DbContext(typeof(VideoGameDbContext))]
    [Migration("20241223112525_mercado")]
    partial class mercado
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "9.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("videoGameApi.Model.VideoGame", b =>
                {
                    b.Property<int>("VideoGameId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("VideoGameId"));

                    b.Property<string>("Developer")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("IdMercado")
                        .HasColumnType("int");

                    b.Property<string>("Platform")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Publisher")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Title")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("VideoGameId");

                    b.ToTable("VideoGames");

                    b.HasData(
                        new
                        {
                            VideoGameId = 1,
                            Developer = "9",
                            IdMercado = 0,
                            Platform = "OS",
                            Publisher = "Male",
                            Title = "new"
                        },
                        new
                        {
                            VideoGameId = 2,
                            Developer = "19",
                            IdMercado = 0,
                            Platform = "WIN",
                            Publisher = "Male",
                            Title = "old"
                        },
                        new
                        {
                            VideoGameId = 3,
                            Developer = "29",
                            IdMercado = 0,
                            Platform = "LIN",
                            Publisher = "Male",
                            Title = "teen"
                        },
                        new
                        {
                            VideoGameId = 4,
                            Developer = "88",
                            IdMercado = 0,
                            Platform = "APP",
                            Publisher = "Male",
                            Title = "child"
                        });
                });

            modelBuilder.Entity("videoGameApi.Model.VideoGameDetails", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("RealeseDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("VideoGameId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("VideoGameId")
                        .IsUnique();

                    b.ToTable("VideoGameDetails");
                });

            modelBuilder.Entity("videoGameApi.Model.VideoGameMercado", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Mercado")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("VideoGameId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("VideoGameId")
                        .IsUnique();

                    b.ToTable("VideoGameMercado");
                });

            modelBuilder.Entity("videoGameApi.Model.VideoGameDetails", b =>
                {
                    b.HasOne("videoGameApi.Model.VideoGame", null)
                        .WithOne("VideoGameDetails")
                        .HasForeignKey("videoGameApi.Model.VideoGameDetails", "VideoGameId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("videoGameApi.Model.VideoGameMercado", b =>
                {
                    b.HasOne("videoGameApi.Model.VideoGame", null)
                        .WithOne("Mercado")
                        .HasForeignKey("videoGameApi.Model.VideoGameMercado", "VideoGameId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("videoGameApi.Model.VideoGame", b =>
                {
                    b.Navigation("Mercado");

                    b.Navigation("VideoGameDetails");
                });
#pragma warning restore 612, 618
        }
    }
}