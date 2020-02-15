using MongoDB.Driver;
using MongoDB.Driver.Builders;
using MongoDB.Driver.Linq;
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
    public partial class FormSvaZimovanja : Form
    {
        PictureBox[] pbName;
        Button[] butns;
        Label[] labels;

        public FormSvaZimovanja()
        {
            InitializeComponent();
            Init();
        }

        public void Init()
        {
            var connectionString = "mongodb://localhost/?safe=true";
            var server = MongoServer.Create(connectionString);
            var database = server.GetDatabase("agencija");

            var collectionZimovanja = database.GetCollection<Zimovanje>("putovanja");

            var query1 = from putovanje in collectionZimovanja.AsQueryable<Zimovanje>()
                         where putovanje.TipPutovanja == "Zimovanje"
                         select putovanje;

            long count = query1.Count();

            pbName = new PictureBox[count];
            butns = new Button[count];
            labels = new Label[count];

            int i = 0;
            foreach (Zimovanje l in query1)
            {

                pbName[i] = new PictureBox();
                pbName[i].Size = new Size(this.Size.Width / 8, this.Size.Width / 8);


                byte[] buffer = l.Slika.ToArray();
                MemoryStream memStream = new MemoryStream();
                memStream.Write(buffer, 0, buffer.Length);
                pbName[i].Image = Image.FromStream(memStream);

                pbName[i].SizeMode = PictureBoxSizeMode.StretchImage;


                pbName[i].Anchor = AnchorStyles.Left;
                pbName[i].Visible = true;

                int x = 100;
                int y = 15;
                if (i > 4)
                {
                    y += 300;
                }
                x = (int)((this.Size.Width / 5) * Math.IEEERemainder(i, 5) + 280);
                pbName[i].Location = new Point(x + 170, y);
                this.Controls.Add(pbName[i]);

                labels[i] = new Label();
                labels[i].MaximumSize = new Size(125, 0);
                labels[i].AutoSize = true;
                labels[i].BackColor = Color.Transparent;


                labels[i].Text = l.Lokacija + " " + l.Cena + "e";
                labels[i].Location = new Point(x + 170, y + 140);
                labels[i].Font = new Font(new FontFamily("Century Gothic"), 10);

                this.Controls.Add(labels[i]);

                butns[i] = new Button();
                butns[i].Click += new EventHandler(butns_Click);
                butns[i].Text = "Vidi vise";
                butns[i].Name = l.Id.ToString();
                butns[i].Location = new Point(x + 170, y + 200);
                butns[i].Tag = i;
                butns[i].Font = new Font(new FontFamily("Century Gothic"), 10);

                this.Controls.Add(butns[i]);
                i++;

            }


            int width = this.Size.Width;
            int height = this.Size.Height;
            this.MaximumSize = new Size(width, height);
        }

        private void butns_Click(object sender, EventArgs e)
        {
            Button b = sender as Button;
            int i = Int32.Parse(b.Tag.ToString());

            FormZimovanje zimovanjeForm = new FormZimovanje(butns[i].Name);
            zimovanjeForm.Show();
        }

        //public void UpdateZimovanjeSlikom(MongoCollection<Zimovanje> collectionZimovanja, string imagePath, string lokacija)
        //{
        //    FileStream fileStream = new FileStream(imagePath, FileMode.Open, FileAccess.Read);
        //    byte[] buffer = new byte[fileStream.Length];
        //    fileStream.Read(buffer, 0, (int)fileStream.Length);
        //    fileStream.Close();


        //    var query = Query.EQ("Lokacija", lokacija);
        //    var update = MongoDB.Driver.Builders.Update.Set("Slika", buffer);

        //    collectionZimovanja.Update(query, update);


        //}



    }

}
