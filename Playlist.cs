using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Muzik
{
    public class Playlist:User,IPieceEntity
    {
        List<Song> songs = new List<Song>();
        public int SongCount { get => songs.Count(); }
        public DateTime LastPlay { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    }
}
