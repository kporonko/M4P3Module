using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SongsModule.Configurations
{
    public class SongConfiguration : IEntityTypeConfiguration<Song>
    {
        public void Configure(EntityTypeBuilder<Song> builder)
        {
            builder
                .ToTable("Song")
                .HasKey(k => k.SongId);
            builder
                .Property(p => p.SongId)
                .IsRequired()
                .HasColumnName("SongId")
                .HasColumnType("int");
            builder
                .Property(p => p.Title)
                .IsRequired()
                .HasColumnName("Title")
                .HasColumnType("varchar")
                .HasMaxLength(50);
            builder
                .Property(p => p.Duration)
                .IsRequired()
                .HasColumnName("Duration")
                .HasColumnType("varchar")
                .HasMaxLength(50);
            builder
                .Property(p => p.ReleasedDate)
                .IsRequired()
                .HasColumnName("ReleasedDate")
                .HasColumnType("date");
            builder
                .Property(p => p.ArtistId)
                .HasColumnName("ArtistId")
                .HasColumnType("int");
            builder
                .Property(p => p.GenreId)
                .HasColumnName("GenreId")
                .HasColumnType("int");
        }
    }
}
