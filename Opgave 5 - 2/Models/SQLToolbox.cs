using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;

namespace Opgave_5___2.Models
{
    public static class SQLToolbox
    {
        public static void GetMovieData()
        {
            // connection to database
            using (SqlConnection connection = new SqlConnection("Data Source=10.0.4.114;Initial Catalog=master;User ID=Logon;Password=Passw0rd1"))
            {
                using (SqlCommand cmd = new SqlCommand("SELECT * FROM dbo.MovieTable", connection))
                {
                    // clear the list, so its fresh data each time
                    MovieListClass.MovieList.Clear();
                    connection.Open();
                    SqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        Movies movie = new Movies();
                        movie.Thumbnail = reader.GetString(1);
                        movie.Title = reader.GetString(2);
                        movie.Rating = reader.GetDecimal(3);
                        movie.Genre = reader.GetString(4);
                        movie.Runtime = reader.GetInt32(5);
                        movie.Price = reader.GetDecimal(6);
                        movie.ReleaseDate = reader.GetString(7);
                        MovieListClass.MovieList.Add(movie);
                    }
                    reader.Close();
                }
            }
        }
    }
}