using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


using MongoDB.Bson;
using MongoDB.Driver;

namespace MongoDB_Repository
{
    public class Administrator
    {
        public ObjectId Id { get; set; }
        public string KorisnickoIme  { get; set; }
        public string Lozinka { get; set; }
    }
}
