using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SongsModule.Models
{
    public class Artist
    {
        public int ArtistId { get; set; }
        public string Name { get; set; } = null!;
        public DateTime DateOfBirth { get; set; }
        public int? Phone { get; set; }
        public string? Email { get; set; }
        public string? InstagramUrl { get; set; }
        public List<Song> Songs { get; set; } = new List<Song>();
    }
}
