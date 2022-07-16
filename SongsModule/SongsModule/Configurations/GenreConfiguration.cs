global using Microsoft.EntityFrameworkCore;
global using Microsoft.EntityFrameworkCore.Metadata.Builders;
global using SongsModule.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SongsModule.Configurations
{
    public class GenreConfiguration : IEntityTypeConfiguration<Genre>
    {
        public void Configure(EntityTypeBuilder<Genre> builder)
        {
            builder
                .ToTable("Genre")
                .HasKey(x => x.GenreId);
            builder
                .Property(p => p.GenreId)
                .IsRequired()
                .HasColumnName("GenreId")
                .HasColumnType("int");
            builder
                .Property(p => p.Title)
                .IsRequired()
                .HasColumnName("Title")
                .HasColumnType("varchar")
                .HasMaxLength(50);
        }
    }
}
