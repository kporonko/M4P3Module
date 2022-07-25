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

            builder.HasData(new Song[] {
                new Song { SongId = 1, Title = "Song 1", Duration = "3.43", GenreId = 1, ArtistId = 1},
                new Song { SongId = 2, Title = "Song 2", Duration = "4.23", GenreId = 2, ArtistId = 2},
                new Song { SongId = 3, Title = "Song 3", Duration = "3.23", GenreId = 3, ArtistId = 3},
                new Song { SongId = 4, Title = "Song 4", Duration = "5.12", GenreId = 4, ArtistId = 4}
                }
           );
        }
    }
}
