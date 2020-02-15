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
    public partial class FormAdminKomentari : Form
    {
        Letovanje letovanje; Zimovanje zimovanje; Spa spa; Ekskurzija ekskurzija;
        Label[] labels;
        CheckBox[] chbs;
        List<int> zaBrisanje = new List<int>();

        public FormAdminKomentari(Letovanje l, Zimovanje z, Spa s, Ekskurzija e)
        {
            InitializeComponent();
            letovanje = l;
            zimovanje = z;
            spa = s;
            ekskurzija = e;
            labels = new Label[30];
            chbs = new CheckBox[30];

            Init();

        }

        public void Init()
        {
            var connectionString = "mongodb://localhost/?safe=true";
            var server = MongoServer.Create(connectionString);
            var db = server.GetDatabase("agencija");
            Putovanje p = new Putovanje();
            if (spa != null)
            {
                p = spa as Putovanje;
            }
            else if (zimovanje != null)
            {
                p = zimovanje as Putovanje;
            }
            else if (letovanje != null)
            {
                p = letovanje as Putovanje;
            }

            else
            {
                p = ekskurzija as Putovanje;
            }

            int i = 0;

            foreach (MongoDBRef kRef in p.Komentari)
            {

                Komentar k = db.FetchDBRefAs<Komentar>(kRef);
                if (k != null)
                {
                    if (i < 4)
                    {

                        labels[i] = new Label();
                        labels[i].Text = k.Ocena + ", " + k.Tekst;
                        labels[i].Location = new Point(labels[i].Location.X, labels[i].Location.Y + i * (groupBox1.Height / 6 + labels[i].Height * 2));
                        groupBox1.Controls.Add(labels[i]);


                        PictureBox pb = new PictureBox();
                        pb.SizeMode = PictureBoxSizeMode.StretchImage;
                        if (k.Slika != null)
                        {
                            byte[] buffer = k.Slika.ToArray();
                            MemoryStream memStream = new MemoryStream();
                            memStream.Write(buffer, 0, buffer.Length);
                            pb.Image = Image.FromStream(memStream);
                        }
                        pb.Location = new Point(labels[i].Location.X, labels[i].Location.Y + labels[i].Height);
                        pb.SizeMode = PictureBoxSizeMode.StretchImage;
                        pb.Size = new Size(groupBox1.Width, groupBox1.Height / 6);
                        groupBox1.Controls.Add(pb);


                        chbs[i] = new CheckBox();
                        chbs[i].Text = "Ukloni";
                        chbs[i].Tag = i;
                        chbs[i].Name = k.Id.ToString();
                        chbs[i].CheckedChanged += new EventHandler(chbs_Changed);
                        chbs[i].Location = new Point(pb.Location.X, pb.Location.Y + pb.Height);
                        groupBox1.Controls.Add(chbs[i]);


                        i++;
                    }

                    else if (i < 8 && i >= 4)
                    {
                        labels[i] = new Label();
                        labels[i].Text = k.Ocena + ", " + k.Tekst;
                        labels[i].Location = new Point(labels[i].Location.X, labels[i].Location.Y + (i - 4) * 80);
                        groupBox2.Controls.Add(labels[i]);

                        PictureBox pb = new PictureBox();
                        pb.SizeMode = PictureBoxSizeMode.StretchImage;
                        if (k.Slika != null)
                        {
                            byte[] buffer = k.Slika.ToArray();
                            MemoryStream memStream = new MemoryStream();
                            memStream.Write(buffer, 0, buffer.Length);
                            pb.Image = Image.FromStream(memStream);
                        }
                        pb.SizeMode = PictureBoxSizeMode.StretchImage;
                        pb.Location = new Point(pb.Location.X, pb.Location.Y + (i - 4) * 80);
                        pb.Size = new Size(groupBox1.Width, groupBox1.Height / 6);
                        groupBox2.Controls.Add(pb);

                        chbs[i] = new CheckBox();
                        chbs[i].Text = "Ukloni";
                        chbs[i].Tag = i;
                        chbs[i].Name = k.Id.ToString();
                        chbs[i].CheckedChanged += new EventHandler(chbs_Changed);
                        chbs[i].Location = new Point(pb.Location.X, pb.Location.Y + ((i - 4) + 1) * pb.Height);
                        groupBox2.Controls.Add(chbs[i]);


                        i++;
                    }

                    else if (i < 12 && i >= 8)
                    {
                        labels[i] = new Label();
                        labels[i].Text = k.Ocena + ", " + k.Tekst;
                        labels[i].Location = new Point(labels[i].Location.X, labels[i].Location.Y + (i - 8) * 80);
                        groupBox2.Controls.Add(labels[i]);

                        PictureBox pb = new PictureBox();
                        pb.SizeMode = PictureBoxSizeMode.StretchImage;
                        if (k.Slika != null)
                        {
                            byte[] buffer = k.Slika.ToArray();
                            MemoryStream memStream = new MemoryStream();
                            memStream.Write(buffer, 0, buffer.Length);
                            pb.Image = Image.FromStream(memStream);

                        }
                        pb.SizeMode = PictureBoxSizeMode.StretchImage;
                        pb.Location = new Point(pb.Location.X, pb.Location.Y + (i - 8) * 80);
                        pb.Size = new Size(groupBox1.Width, groupBox1.Height / 6);
                        groupBox2.Controls.Add(pb);

                        chbs[i] = new CheckBox();
                        chbs[i].Text = "Ukloni";
                        chbs[i].Tag = i;
                        chbs[i].Name = k.Id.ToString();
                        chbs[i].CheckedChanged += new EventHandler(chbs_Changed);
                        chbs[i].Location = new Point(pb.Location.X, pb.Location.Y + ((i - 8) + 1) * pb.Height);
                        groupBox2.Controls.Add(chbs[i]);


                        i++;
                    }
                }

            }




        }

        private void chbs_Changed(object sender, EventArgs e)
        {
            CheckBox cb = sender as CheckBox;
            int i = Int32.Parse(cb.Tag.ToString());

            zaBrisanje.Add(i);


            string id = chbs[i].Name;
            var connectionString = "mongodb://localhost/?safe=true";
            var server = MongoServer.Create(connectionString);
            var db = server.GetDatabase("agencija");

            var collectionKomentari = db.GetCollection<Komentar>("komentari");
            var kom = collectionKomentari.Remove(Query.EQ("_id", ObjectId.Parse(id)));



        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            foreach (int i in zaBrisanje)
            {

                string id = chbs[i].Name;
                var connectionString = "mongodb://localhost/?safe=true";
                var server = MongoServer.Create(connectionString);
                var db = server.GetDatabase("agencija");

                var collectionKomentari = db.GetCollection<Komentar>("komentari");
                var kom = collectionKomentari.Remove(Query.EQ("_id", ObjectId.Parse(id)));



            }
            this.Close();

        }
    }
}


