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

        }
    }
}
