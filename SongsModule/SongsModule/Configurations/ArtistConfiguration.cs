using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SongsModule.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SongsModule.Configurations
{
    public class ArtistConfiguration : IEntityTypeConfiguration<Artist>
    {
        public void Configure(EntityTypeBuilder<Artist> builder)
        {
            builder
                .ToTable("Artist")
                .HasKey(x => x.ArtistId);

            builder
                .Property(p => p.ArtistId)
                .HasColumnName("ArtistId")
                .HasColumnType("int")
                .IsRequired();

            builder
                .Property(p => p.Name)
                .HasColumnName("Name")
                .HasColumnType("varchar")
                .HasMaxLength(50)
                .IsRequired();

            builder
                .Property(p => p.DateOfBirth)
                .HasColumnName("DateOfBirth")
                .HasColumnType("date")
                .IsRequired();

            builder
                .Property(p => p.Phone)
                .HasColumnName("Phone")
                .HasColumnType("int");

            builder
                .Property(p => p.Email)
                .HasColumnName("Email")
                .HasColumnType("varchar")
                .HasMaxLength(50);

            builder
                .Property(p => p.InstagramUrl)
                .HasColumnName("InstagramUrl")
                .HasColumnType("varchar")
                .HasMaxLength(50);

            builder.HasData(new Artist[] {
                new Artist { ArtistId = 1, DateOfBirth = new DateTime(2000, 12, 12), Name = "Vasya"},
                new Artist { ArtistId = 2, DateOfBirth = new DateTime(1999, 4, 26), Name = "Oleg"},
                new Artist { ArtistId = 3, DateOfBirth = new DateTime(1989, 3, 3), Name = "Vova"},
                new Artist { ArtistId = 4, DateOfBirth = new DateTime(1965, 6, 23), Name = "Artem"}
                }
            );
        }
    }
}
