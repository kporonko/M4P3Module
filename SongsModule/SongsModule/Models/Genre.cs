using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SongsModule.Models
{
    public class Genre
    {
        public int GenreId { get; set; }
        public string Title { get; set; } = null!;
        public virtual List<Song> Songs { get; set; } = new List<Song>();
    }
}
