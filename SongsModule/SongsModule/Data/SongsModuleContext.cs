using SongsModule.Configurations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SongsModule.Data
{
    public class SongsModuleContext : DbContext
    {
        public SongsModuleContext(DbContextOptions<SongsModuleContext> options)
            : base(options)
        {
        }
        public DbSet<Song> Songs { get; set; }
        public DbSet<Artist> Artists { get; set; }
        public DbSet<Genre> Genres { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new ArtistConfiguration());
            modelBuilder.ApplyConfiguration(new GenreConfiguration());
            modelBuilder.ApplyConfiguration(new SongConfiguration());

            modelBuilder.Entity<Song>().HasOne(t => t.Genre).WithMany(t => t.Songs);
            modelBuilder.Entity<Song>().HasOne(t => t.Artist).WithMany(t => t.Songs);
        }
    }
}
