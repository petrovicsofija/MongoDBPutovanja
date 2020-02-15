using MongoDB.Bson;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MongoDB_Repository
{
    public class Putovanje
    {
        public ObjectId Id { get; set; }
        public string TipPutovanja { get; set; }
        public double Cena { get; set; }
        public string Lokacija { get; set; }
        public string Opis { get; set; }
        public byte[] Slika { get; set; }
        public string DatumOd { get; set; }
        public string DatumDo { get; set; }

        public List<MongoDBRef> Komentari { get; set; }

        public Putovanje()
        {
            Komentari = new List<MongoDBRef>();

        }
    }
}
