using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SongsModule
{
    internal class QueriesAdo : IQueries
    {
        public void InnerJoin(SongsModuleContext context)
        {
            StringBuilder stringBuilder = new StringBuilder();
            try
            {
                string query = "SELECT Song.Title, Artist.Name, Genre.Title FROM Artist JOIN Song ON Artist.ArtistId = Song.ArtistId JOIN Genre ON Song.GenreId = Genre.GenreId";
                SqlConnection sqlconn = new SqlConnection(context.Database.GetDbConnection().ConnectionString);
                SqlCommand command = new SqlCommand(query, sqlconn);
                sqlconn.Open();
                var reader = command.ExecuteReader();
                while (reader.Read())
                {
                    stringBuilder.Append(reader.GetValue(0).ToString() + "\n");
                    stringBuilder.Append(reader.GetValue(1).ToString() + "\n");
                    stringBuilder.Append(reader.GetValue(2).ToString() + "\n");
                }
                sqlconn.Close();
            }
            catch (Exception ex)
            {
            }
            stringBuilder.Append("\n");
            Console.WriteLine(stringBuilder.ToString());
        }

        public void SongsBeforeTheYoungestArtist(SongsModuleContext context)
        {
            StringBuilder stringBuilder = new StringBuilder();
            try
            {
                string query = "SELECT Song.Title, Artist.Name, Genre.Title, Song.Duration, Song.ReleasedDate " +
                    "FROM Artist JOIN Song ON Artist.ArtistId = Song.ArtistId JOIN Genre ON Song.GenreId = Genre.GenreId " +
                    "WHERE Song.ReleasedDate < (SELECT Max(DateOfBirth) FROM Artist)";
                SqlConnection sqlconn = new SqlConnection(context.Database.GetDbConnection().ConnectionString);
                SqlCommand command = new SqlCommand(query, sqlconn);
                sqlconn.Open();
                var reader = command.ExecuteReader();
                while (reader.Read())
                {
                    for (int i = 0; i <= 4; i++)
                    {
                        stringBuilder.Append(reader.GetValue(i).ToString() + "\n");
                    }
                }
                sqlconn.Close();
                stringBuilder.Append("\n");
            }
            catch (Exception ex)
            {
            }
            Console.WriteLine(stringBuilder.ToString());
        }
    }
}
