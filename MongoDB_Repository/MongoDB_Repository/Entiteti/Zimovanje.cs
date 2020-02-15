using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MongoDB_Repository.Entiteti
{
    public class Zimovanje : Putovanje 
    {
        public double SkiPass { get; set; }
        public bool SkolaSkijanja { get; set; }
    }
}
