using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MongoDB_Repository.Entiteti
{
    public enum TipEkskurzije
    {
        apsolventska,
        springBreak,
        skolska
    }
    public class Ekskurzija : Putovanje
    {
        public TipEkskurzije TipEkskurzije { get; set; }

    }
}
