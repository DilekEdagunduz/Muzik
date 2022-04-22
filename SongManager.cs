using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Muzik
{
    public class SongManager 
    {
        public SongManager()
        {
            
        }
        public SongManager(Song song)
        {
            this.song = song;
        }

        public string LastPlayedDate(IPieceEntity song)
        {
            var val = song.LastPlay.ToString("dd MMMM yyyy, dddd");
            return val;
        }

        public void SongPlay(IPlaying playing)
        {
            Console.WriteLine("Çalıyor..."+song.Name);
            playing.Playing(song);
        }
        public DateTime LastPlay { get ; set; }

        public Song song { get; set; }
    }
}
