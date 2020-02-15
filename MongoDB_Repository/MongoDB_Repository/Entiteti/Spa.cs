using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MongoDB_Repository.Entiteti
{
    public class Spa : Putovanje
    {
        public bool Sauna { get; set;}
        public bool ParnoKupatilo { get; set; }
        public double DoplataMasaza { get; set;}

    }
}
