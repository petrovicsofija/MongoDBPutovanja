using MongoDB.Bson;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MongoDB_Repository
{
    public class Komentar
    {
        public ObjectId Id { get; set; }
        public string Tekst { get; set; }
        public int Ocena { get; set; }
        public byte[] Slika { get; set; }
        public MongoDBRef Putovanje { get; set; }

    }
}
