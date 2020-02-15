using MongoDB.Bson;
using MongoDB.Driver;
using MongoDB.Driver.Builders;
using MongoDB.Driver.Linq;
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
    public partial class FormLetovanje : Form
    {

        PictureBox[] pbName;
        Button[] butns;
        Label[] labels;
        string idLetovanja;
        public FormLetovanje(string id)
        {

            InitializeComponent();
            //za sad 5 komentara samo da mogu da se prikzuu
            labels = new Label[10];
            butns = new Button[10];
            pbName = new PictureBox[10];
            idLetovanja = id;
            Init();

        }

        public void Init()
        {
            var connectionString = "mongodb://localhost/?safe=true";
            var server = MongoServer.Create(connectionString);
            var database = server.GetDatabase("agencija");

            var collectionLetovanja = database.GetCollection<Letovanje>("putovanja");

            foreach (Letovanje l in collectionLetovanja.Find(Query.EQ("_id", ObjectId.Parse(idLetovanja))))
            {

                textBox1.Text = l.Opis;
                lbCena.Text = l.Cena.ToString() + "e";
                lbLokacija.Text = l.Lokacija;
                pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                byte[] buffer = l.Slika.ToArray();
                MemoryStream memStream = new MemoryStream();
                memStream.Write(buffer, 0, buffer.Length);
                pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                pictureBox1.Image = Image.FromStream(memStream);
            }

        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            var connectionString = "mongodb://localhost/?safe=true";
            var server = MongoServer.Create(connectionString);
            var database = server.GetDatabase("agencija");

            var collectionKomentari = database.GetCollection<Komentar>("komentari");

            groupBox1.Controls.Clear();
            int i = 0;
            foreach (Komentar k in collectionKomentari.FindAll())
            {
                //treba da se sredi da se tu negde uglavi i pictureBox sa slikom koju korisnik uploaduje nisam stigla to 
                if (i < 4 && comboBox1.SelectedItem.Equals(k.Ocena.ToString()) && k.Putovanje.Id.Equals(ObjectId.Parse(idLetovanja)))
                {
                    labels[i] = new Label();
                    labels[i].Text = k.Ocena + ", " + k.Tekst;
                    labels[i].Location = new Point(labels[i].Location.X, labels[i].Location.Y + i * 80);
                    groupBox1.Controls.Add(labels[i]);

                    PictureBox pb = new PictureBox();
                    pb.SizeMode = PictureBoxSizeMode.StretchImage;
                    byte[] buffer = k.Slika.ToArray();
                    MemoryStream memStream = new MemoryStream();
                    memStream.Write(buffer, 0, buffer.Length);
                    pb.SizeMode = PictureBoxSizeMode.StretchImage;
                    pb.Location = new Point(pb.Location.X, pb.Location.Y + i * 80);
                    pb.Size = new Size(groupBox1.Width, groupBox1.Height / 4);
                    pb.Image = Image.FromStream(memStream);
                    groupBox1.Controls.Add(pb);

                    i++;
                }

                else if (i < 8 && i >= 4 && comboBox1.SelectedItem.Equals(k.Ocena.ToString()) && k.Putovanje.Id.Equals(ObjectId.Parse(idLetovanja)))
                {

                    labels[i] = new Label();
                    labels[i].Text = k.Ocena + ", " + k.Tekst;
                    labels[i].Location = new Point(labels[i].Location.X, labels[i].Location.Y + (i - 4) * 80);
                    groupBox2.Controls.Add(labels[i]);

                    PictureBox pb = new PictureBox();
                    pb.SizeMode = PictureBoxSizeMode.StretchImage;
                    byte[] buffer = k.Slika.ToArray();
                    MemoryStream memStream = new MemoryStream();
                    memStream.Write(buffer, 0, buffer.Length);
                    pb.SizeMode = PictureBoxSizeMode.StretchImage;
                    pb.Location = new Point(pb.Location.X, pb.Location.Y + (i - 4) * 80);
                    pb.Size = new Size(groupBox1.Width, groupBox1.Height / 4);
                    pb.Image = Image.FromStream(memStream);
                    groupBox2.Controls.Add(pb);

                    i++;
                }

            }
        }

        /*private void btnDodajUtisak_Click(object sender, EventArgs e)
        {
            FormKomentar frk = new FormKomentar(idLetovanja);
            frk.Show();

        }*/

        private void FormLetovanje_MouseHover(object sender, EventArgs e)
        {

        }

        private void btnUtisak_Click(object sender, EventArgs e)
        {
            FormKomentar frk = new FormKomentar(idLetovanja, 0);
            frk.Show();
        }
    }
}
