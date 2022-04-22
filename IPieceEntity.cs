using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Muzik
{
    public interface IPieceEntity
    {
        public DateTime LastPlay { get; set; }
    }
}
