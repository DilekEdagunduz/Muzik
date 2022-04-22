using Muzik;
using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Album album = new Album();
            album.Name = "Impossible";
            
            // list ve sayım


            Artist artist = new Artist( "eda", "gunduz" );
            artist.Country = "Turkey";
            DateTime newdate = new DateTime(1998, 04, 10);
            artist.DateOfBirth = newdate;


            Log log = new Log();
            log.Name = "songname";
            log.Description = "Hip Hop";
            log.Category = 1;

            MyFavorites myFavorites = new MyFavorites();
            

            Song song = new Song();
            DateTime newdate2 = new DateTime(2022, 01, 22);
            song.LastPlay = newdate2;

            SongManager songManager = new SongManager();
            
            User user = new User();
            user.Adress = "istanbul";
            user.Email = "eda@g.com";
            user.Password = "1234";
            
        }
    }
}