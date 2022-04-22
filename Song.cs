using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Muzik
{
    public class Song:Artist,IPlaying,IPieceEntity
    {
        public Song(string ad)    
        {

        }
        public DateTime AnnouncementDate { get; set; }
        public DateTime PublicationDate { get => AnnouncementDate.AddDays(10); }
        public DateTime Sure { get; set; }
        public DateTime LastPlay { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public void Playing(Song song)
        {
            throw new NotImplementedException();
        }
    }
}
