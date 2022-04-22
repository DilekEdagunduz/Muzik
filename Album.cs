using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Muzik
{
    public class Album:Artist
    {
        public string Name { get; set; }
        List<Song> Songs = new List<Song>();
        public int SongCount { get => Songs.Count(); }
        public string CoverPhoto { get; set; }
    }
}
