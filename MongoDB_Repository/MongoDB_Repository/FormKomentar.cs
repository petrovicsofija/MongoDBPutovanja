using MongoDB.Bson;
using MongoDB.Driver;
using MongoDB.Driver.Builders;
using MongoDB_Repository.Entiteti;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MongoDB_Repository
{
    public partial class FormKomentar : Form
    {
        string idPutovanja;
        public int tip; //da bi znali koje putovanje da povucemo iz baze 0-letovanje, 1-zimovanje, 2-spa, 3-ekskurzija



        public FormKomentar(string id, int tip)
        {
            InitializeComponent();
            idPutovanja = id;
            Init();
            this.tip = tip;


        }

        public void Init()
        {

        }

        public byte[] UploadSlike(string putanja)
        {
            FileStream fileStream = new FileStream(putanja, FileMode.Open, FileAccess.Read);
            byte[] buffer = new byte[fileStream.Length];
            fileStream.Read(buffer, 0, (int)fileStream.Length);
            fileStream.Close();

            return buffer;

        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            var connectionString = "mongodb://localhost/?safe=true";
            var server = MongoServer.Create(connectionString);
            var db = server.GetDatabase("agencija");

            var komentariCollection = db.GetCollection<Komentar>("komentari");
            Komentar k1 = new Komentar { Tekst = tbTekst.Text, Ocena = Int32.Parse(tbOcena.Text), Slika = UploadSlike(tbSlika.Text) };
            komentariCollection.Insert(k1);

            if (tip == 0)
            {
                var kolekcija = db.GetCollection<Letovanje>("putovanja");
                k1.Putovanje = new MongoDBRef("letovanja", ObjectId.Parse(idPutovanja));
                foreach (Putovanje l in kolekcija.Find(Query.EQ("_id", ObjectId.Parse(idPutovanja))))
                {
                    l.Komentari.Add(new MongoDBRef("komentari", ObjectId.Parse(k1.Id.ToString())));
                    kolekcija.Save(l);
                }
            }
            else if (tip == 1)
            {
                var kolekcija = db.GetCollection<Zimovanje>("putovanja");
                k1.Putovanje = new MongoDBRef("zimovanja", ObjectId.Parse(idPutovanja));
                foreach (Putovanje l in kolekcija.Find(Query.EQ("_id", ObjectId.Parse(idPutovanja))))
                {
                    l.Komentari.Add(new MongoDBRef("komentari", ObjectId.Parse(k1.Id.ToString())));
                    kolekcija.Save(l);
                }
            }
            else if (tip == 2)
            {
                var kolekcija = db.GetCollection<Spa>("putovanja");
                k1.Putovanje = new MongoDBRef("spa", ObjectId.Parse(idPutovanja));
                foreach (Putovanje l in kolekcija.Find(Query.EQ("_id", ObjectId.Parse(idPutovanja))))
                {
                    l.Komentari.Add(new MongoDBRef("komentari", ObjectId.Parse(k1.Id.ToString())));
                    kolekcija.Save(l);
                }
            }
            else
            {
                var kolekcija = db.GetCollection<Ekskurzija>("putovanja");
                k1.Putovanje = new MongoDBRef("ekskurzija", ObjectId.Parse(idPutovanja));
                foreach (Putovanje l in kolekcija.Find(Query.EQ("_id", ObjectId.Parse(idPutovanja))))
                {
                    l.Komentari.Add(new MongoDBRef("komentari", ObjectId.Parse(k1.Id.ToString())));
                    kolekcija.Save(l);
                }
            }


            komentariCollection.Save(k1);

            //foreach (Letovanje l in letovanjaCollection.Find(Query.EQ("_id", ObjectId.Parse(idPutovanja))))
            //{

            //    for (int i = 0; i < l.Komentari.Count(); i++)
            //    {

            //        Komentar k = db.FetchDBRefAs<Komentar>(l.Komentari[i]);
            //        if (k != null)//obavezno se ogranici jer ocigledno u startu postoje neki bezveze dbrefovi komentara koji nisu u bazi pa vrate null
            //        {
            //            MessageBox.Show(k.Tekst + " " + k.Ocena);
            //        }
            //    }
            //}


            //foreach (Komentar k in komentariCollection.FindAll())
            //{
            //   Letovanje l = db.FetchDBRefAs<Letovanje>(k.Putovanje);
            //   MessageBox.Show(l.Lokacija);
            //}
            this.Hide();
        }

        private void FormKomentar_Load(object sender, EventArgs e)
        {

        }
    }
}
