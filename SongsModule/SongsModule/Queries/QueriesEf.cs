using Microsoft.Data.SqlClient;
using SongsModule.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SongsModule
{
    public class QueriesEf : IQueries
    {
        public void InnerJoin(SongsModuleContext context)
        {
            foreach (var item in context.Songs.ToList())
            {
                try
                {
                    Console.WriteLine($"SongName: {item.Title}\nArtist: {item.Artist!.Name}\nGenre: {item.Genre!.Title}\n");
                }
                catch (Exception)
                {
                }
            }
        }

        public void SongsBeforeTheYoungestArtist(SongsModuleContext context)
        {
            var minDate = context.Artists.ToList().Max(p => p.DateOfBirth);
            Console.WriteLine("Mindate: " + minDate + "\n");
            foreach (var item in context.Songs.ToList())
            {
                if (item.ReleasedDate < minDate)
                {
                    try
                    {
                        Console.WriteLine($"SongName: {item.Title}\nArtist: {item.Artist!.Name}\nGenre: {item.Genre!.Title}\nDuration{item.Duration}\nDate: {item.ReleasedDate}\n");
                    }
                    catch (Exception)
                    {
                    }
                }
            }
        }
    }
}
