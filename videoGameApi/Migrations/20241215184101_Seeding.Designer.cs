﻿// <auto-generated />
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
    [Migration("20241215184101_Seeding")]
    partial class Seeding
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
                            Platform = "OS",
                            Publisher = "Male",
                            Title = "new"
                        },
                        new
                        {
                            VideoGameId = 2,
                            Developer = "19",
                            Platform = "WIN",
                            Publisher = "Male",
                            Title = "old"
                        },
                        new
                        {
                            VideoGameId = 3,
                            Developer = "29",
                            Platform = "LIN",
                            Publisher = "Male",
                            Title = "teen"
                        },
                        new
                        {
                            VideoGameId = 4,
                            Developer = "88",
                            Platform = "APP",
                            Publisher = "Male",
                            Title = "child"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}