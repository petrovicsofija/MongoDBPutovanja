using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MongoDB_Repository
{
    public enum TipLetovanja{
        letoZaMlade,
        porodicnoLetovanje,
        egzoticnaDestinacija
    }
    public class Letovanje : Putovanje
    {
        public TipLetovanja TipLetovanja { get; set; }
        public bool Sezona { get; set; }
    }
}
