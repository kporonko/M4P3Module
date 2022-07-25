﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using SongsModule.Data;

#nullable disable

namespace SongsModule.Migrations
{
    [DbContext(typeof(SongsModuleContext))]
    partial class SongsModuleContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.7")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("SongsModule.Models.Artist", b =>
                {
                    b.Property<int>("ArtistId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("ArtistId");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ArtistId"), 1L, 1);

                    b.Property<DateTime>("DateOfBirth")
                        .HasColumnType("date")
                        .HasColumnName("DateOfBirth");

                    b.Property<string>("Email")
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)")
                        .HasColumnName("Email");

                    b.Property<string>("InstagramUrl")
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)")
                        .HasColumnName("InstagramUrl");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)")
                        .HasColumnName("Name");

                    b.Property<int?>("Phone")
                        .HasColumnType("int")
                        .HasColumnName("Phone");

                    b.HasKey("ArtistId");

                    b.ToTable("Artist", (string)null);

                    b.HasData(
                        new
                        {
                            ArtistId = 1,
                            DateOfBirth = new DateTime(2000, 12, 12, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "Vasya"
                        },
                        new
                        {
                            ArtistId = 2,
                            DateOfBirth = new DateTime(1999, 4, 26, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "Oleg"
                        },
                        new
                        {
                            ArtistId = 3,
                            DateOfBirth = new DateTime(1989, 3, 3, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "Vova"
                        },
                        new
                        {
                            ArtistId = 4,
                            DateOfBirth = new DateTime(1965, 6, 23, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "Artem"
                        });
                });

            modelBuilder.Entity("SongsModule.Models.Genre", b =>
                {
                    b.Property<int>("GenreId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("GenreId");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("GenreId"), 1L, 1);

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)")
                        .HasColumnName("Title");

                    b.HasKey("GenreId");

                    b.ToTable("Genre", (string)null);

                    b.HasData(
                        new
                        {
                            GenreId = 1,
                            Title = "Rock"
                        },
                        new
                        {
                            GenreId = 2,
                            Title = "Metal"
                        },
                        new
                        {
                            GenreId = 3,
                            Title = "Pop"
                        },
                        new
                        {
                            GenreId = 4,
                            Title = "Rock"
                        });
                });

            modelBuilder.Entity("SongsModule.Models.Song", b =>
                {
                    b.Property<int>("SongId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("SongId");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("SongId"), 1L, 1);

                    b.Property<int?>("ArtistId")
                        .HasColumnType("int")
                        .HasColumnName("ArtistId");

                    b.Property<string>("Duration")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)")
                        .HasColumnName("Duration");

                    b.Property<int?>("GenreId")
                        .HasColumnType("int")
                        .HasColumnName("GenreId");

                    b.Property<DateTime>("ReleasedDate")
                        .HasColumnType("date")
                        .HasColumnName("ReleasedDate");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)")
                        .HasColumnName("Title");

                    b.HasKey("SongId");

                    b.HasIndex("ArtistId");

                    b.HasIndex("GenreId");

                    b.ToTable("Song", (string)null);

                    b.HasData(
                        new
                        {
                            SongId = 1,
                            ArtistId = 1,
                            Duration = "3.43",
                            GenreId = 1,
                            ReleasedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Title = "Song 1"
                        },
                        new
                        {
                            SongId = 2,
                            ArtistId = 2,
                            Duration = "4.23",
                            GenreId = 2,
                            ReleasedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Title = "Song 2"
                        },
                        new
                        {
                            SongId = 3,
                            ArtistId = 3,
                            Duration = "3.23",
                            GenreId = 3,
                            ReleasedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Title = "Song 3"
                        },
                        new
                        {
                            SongId = 4,
                            ArtistId = 4,
                            Duration = "5.12",
                            GenreId = 4,
                            ReleasedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Title = "Song 4"
                        });
                });

            modelBuilder.Entity("SongsModule.Models.Song", b =>
                {
                    b.HasOne("SongsModule.Models.Artist", "Artist")
                        .WithMany("Songs")
                        .HasForeignKey("ArtistId");

                    b.HasOne("SongsModule.Models.Genre", "Genre")
                        .WithMany("Songs")
                        .HasForeignKey("GenreId");

                    b.Navigation("Artist");

                    b.Navigation("Genre");
                });

            modelBuilder.Entity("SongsModule.Models.Artist", b =>
                {
                    b.Navigation("Songs");
                });

            modelBuilder.Entity("SongsModule.Models.Genre", b =>
                {
                    b.Navigation("Songs");
                });
#pragma warning restore 612, 618
        }
    }
}
