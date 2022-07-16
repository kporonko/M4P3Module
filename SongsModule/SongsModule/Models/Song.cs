using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SongsModule.Models
{
    public class Song
    {
        public int SongId { get; set; }
        public string Title { get; set; } = null!;
        public string Duration { get; set; } = null!;
        public DateTime ReleasedDate { get; set; }
        public virtual Genre? Genre { get; set; }
        public int? GenreId { get; set; }
        public virtual Artist? Artist { get; set; }
        public int? ArtistId { get; set; }
    }
}
