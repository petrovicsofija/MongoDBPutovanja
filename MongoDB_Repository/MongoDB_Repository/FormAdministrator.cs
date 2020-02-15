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
    public partial class FormAdministrator : Form
    {
        string tipPutovanja;
        Letovanje letovanje; Zimovanje zimovanje; Spa spa; Ekskurzija ekskurzija;
        public FormAdministrator()
        {
            InitializeComponent();
            Init();
            letovanje = new Letovanje();
            zimovanje = new Zimovanje();
            spa = new Spa();
            ekskurzija = new Ekskurzija();
            tipPutovanja = null;
            cbParnoKupatilo.Visible = false;
            cbSezonaSkiSkolaSauna.Visible = false;

        }

        public void Init()
        {
            var connectionString = "mongodb://localhost/?safe=true";
            var server = MongoServer.Create(connectionString);
            var database = server.GetDatabase("agencija");

            var collectionAdministratori = database.GetCollection<Administrator>("administratori");
            var collectionPutovanja = database.GetCollection<Putovanje>("putovanja");
            foreach (Administrator a in collectionAdministratori.FindAll())
            {
                comboBox1.Items.Add(a.KorisnickoIme);

            }

            groupBox1.Visible = false;

            var query1 = from letovanje in collectionPutovanja.AsQueryable<Letovanje>()
                         where letovanje.TipPutovanja == "Letovanje"
                         select new Letovanje { Cena = letovanje.Cena, DatumDo = letovanje.DatumDo, DatumOd = letovanje.DatumOd, Komentari = letovanje.Komentari, Id = letovanje.Id, Lokacija = letovanje.Lokacija, TipLetovanja = letovanje.TipLetovanja, Opis = letovanje.Opis, Sezona = letovanje.Sezona, Slika = letovanje.Slika, TipPutovanja = letovanje.TipPutovanja };
            var query2 = from z in collectionPutovanja.AsQueryable<Zimovanje>()
                         where z.TipPutovanja == "Zimovanje"
                         select new Zimovanje { Cena = z.Cena, DatumDo = z.DatumDo, DatumOd = z.DatumOd, Komentari = z.Komentari, Id = z.Id, Lokacija = z.Lokacija, Opis = z.Opis, Slika = z.Slika, TipPutovanja = z.TipPutovanja, SkiPass = z.SkiPass, SkolaSkijanja = z.SkolaSkijanja };
            var query3 = from z in collectionPutovanja.AsQueryable<Spa>()
                         where z.TipPutovanja == "Spa"
                         select new Spa { Cena = z.Cena, DatumDo = z.DatumDo, DatumOd = z.DatumOd, Komentari = z.Komentari, Id = z.Id, Lokacija = z.Lokacija, Opis = z.Opis, Slika = z.Slika, TipPutovanja = z.TipPutovanja, DoplataMasaza = z.DoplataMasaza, ParnoKupatilo = z.ParnoKupatilo, Sauna = z.Sauna };

            var query4 = from z in collectionPutovanja.AsQueryable<Ekskurzija>()
                         where z.TipPutovanja == "Ekskurzija"
                         select new Ekskurzija { Cena = z.Cena, DatumDo = z.DatumDo, DatumOd = z.DatumOd, Komentari = z.Komentari, Id = z.Id, Lokacija = z.Lokacija, Opis = z.Opis, Slika = z.Slika, TipPutovanja = z.TipPutovanja, TipEkskurzije = z.TipEkskurzije };


            foreach (Letovanje l in query1)
            {
                comboBox2.Items.Add(l.Lokacija);
            }


            foreach (Zimovanje z in query2)
            {
                comboBox2.Items.Add(z.Lokacija);
            }

            foreach (Spa z in query3)
            {
                comboBox2.Items.Add(z.Lokacija);
            }
            foreach (Ekskurzija z in query4)
            {
                comboBox2.Items.Add(z.Lokacija);
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {

            var connectionString = "mongodb://localhost/?safe=true";
            var server = MongoServer.Create(connectionString);
            var database = server.GetDatabase("agencija");

            var collectionAdm = database.GetCollection<Administrator>("administratori");

            var query1 = from administrator in collectionAdm.AsQueryable<Administrator>()
                         where administrator.KorisnickoIme == comboBox1.SelectedItem.ToString()
                         where administrator.Lozinka == tbLozinka.Text
                         select new Administrator { KorisnickoIme = administrator.KorisnickoIme, Id = administrator.Id, Lozinka = administrator.Lozinka };

            if (query1.FirstOrDefault() != null)
            { 
                groupBox1.Visible = true;

            }

            else
            {
                MessageBox.Show("Pogresili ste korisnicko ime ili lozinku");
                return;
            }


        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            string lokacija = comboBox2.SelectedItem.ToString();
            var connectionString = "mongodb://localhost/?safe=true";
            var server = MongoServer.Create(connectionString);
            var database = server.GetDatabase("agencija");

            var collectionPutovanje = database.GetCollection<Putovanje>("putovanja");

            var query1 = from letovanje in collectionPutovanje.AsQueryable<Letovanje>()
                         where letovanje.Lokacija == lokacija
                         where letovanje.TipPutovanja == "Letovanje"
                         select new Letovanje { Cena = letovanje.Cena, DatumDo = letovanje.DatumDo, DatumOd = letovanje.DatumOd, Komentari = letovanje.Komentari, Id = letovanje.Id, Lokacija = letovanje.Lokacija, TipLetovanja = letovanje.TipLetovanja, Opis = letovanje.Opis, Sezona = letovanje.Sezona, Slika = letovanje.Slika, TipPutovanja = letovanje.TipPutovanja };
            if (query1.FirstOrDefault() != null && query1.First().GetType().Equals(typeof(Letovanje)))
            {
                tipPutovanja = "Letovanje";
                letovanje = query1.FirstOrDefault();
                zimovanje = null; spa = null; ekskurzija = null;

            }
            else
            {
                var query2 = from z in collectionPutovanje.AsQueryable<Zimovanje>()
                             where z.Lokacija == lokacija
                             where z.TipPutovanja == "Zimovanje"
                             select new Zimovanje { Cena = z.Cena, DatumDo = z.DatumDo, DatumOd = z.DatumOd, Komentari = z.Komentari, Id = z.Id, Lokacija = z.Lokacija, Opis = z.Opis, Slika = z.Slika, TipPutovanja = z.TipPutovanja, SkiPass = z.SkiPass, SkolaSkijanja = z.SkolaSkijanja };
                if (query2.FirstOrDefault() != null && query2.First().GetType().Equals(typeof(Zimovanje)))
                {
                    tipPutovanja = "Zimovanje"; zimovanje = query2.FirstOrDefault();
                    letovanje = null;
                    spa = null;
                    ekskurzija = null;
                }
                else
                {
                    var query3 = from putovanje in collectionPutovanje.AsQueryable<Spa>()
                                 where putovanje.Lokacija == lokacija
                                 where putovanje.TipPutovanja == "Spa"
                                 select new Spa { Cena = putovanje.Cena, DatumDo = putovanje.DatumDo, DatumOd = putovanje.DatumOd, Komentari = putovanje.Komentari, Id = putovanje.Id, Lokacija = putovanje.Lokacija, Opis = putovanje.Opis, Slika = putovanje.Slika, TipPutovanja = putovanje.TipPutovanja, DoplataMasaza = putovanje.DoplataMasaza, ParnoKupatilo = putovanje.ParnoKupatilo, Sauna = putovanje.Sauna };
                    if (query3.FirstOrDefault() != null && query3.First().GetType().Equals(typeof(Spa)))
                    {
                        tipPutovanja = "Spa";
                        spa = query3.FirstOrDefault();
                        letovanje = null;
                        zimovanje = null;
                        ekskurzija = null;
                    }
                    else
                    {
                        var query4 = from z in collectionPutovanje.AsQueryable<Ekskurzija>()
                                     where z.Lokacija == lokacija
                                     where z.TipPutovanja == "Ekskurzija"
                                     select new Ekskurzija { Cena = z.Cena, DatumDo = z.DatumDo, DatumOd = z.DatumOd, Komentari = z.Komentari, Id = z.Id, Lokacija = z.Lokacija, Opis = z.Opis, Slika = z.Slika, TipPutovanja = z.TipPutovanja, TipEkskurzije = z.TipEkskurzije };
                        if (query4.FirstOrDefault() != null && query4.First().GetType().Equals(typeof(Ekskurzija)))
                        {
                            tipPutovanja = "Ekskurzija";
                            ekskurzija = query4.FirstOrDefault();
                            zimovanje = null;
                            letovanje = null;
                            spa = null;
                        }
                    }
                }
            }

            if (tipPutovanja.Equals("Letovanje"))
            {
                cbSezonaSkiSkolaSauna.Text = "Sezona";
                cbSezonaSkiSkolaSauna.Checked = letovanje.Sezona;
                cbSezonaSkiSkolaSauna.Visible = true;

                comboEnum.Items.Clear();
                comboEnum.Items.Add("letoZaMlade");
                comboEnum.Items.Add("porodicnoLetovanje");
                comboEnum.Items.Add("egzoticnaDestinacija");
                if (letovanje.TipLetovanja == TipLetovanja.letoZaMlade)
                    comboEnum.SelectedItem = comboEnum.Items[0];
                else if (letovanje.TipLetovanja == TipLetovanja.porodicnoLetovanje)
                    comboEnum.SelectedItem = comboEnum.Items[1];
                else 
                    comboEnum.SelectedItem = comboEnum.Items[2];
                
                //vrati za ostale
                cbParnoKupatilo.Visible = false;
                lblNamena.Visible = false;
                tbSkiPassMassage.Visible = false;

                if (letovanje.Slika == null)
                    return;

                byte[] buffer = letovanje.Slika.ToArray();
                MemoryStream memStream = new MemoryStream();
                memStream.Write(buffer, 0, buffer.Length);
                pbSlika.SizeMode = PictureBoxSizeMode.StretchImage;
                pbSlika.Image = Image.FromStream(memStream);

                tbOpis.Text = letovanje.Opis;
                tbLok.Text = letovanje.Lokacija;
                tbCena.Text = letovanje.Cena.ToString();

                dateTimePicker1.Text = letovanje.DatumOd;
                dateTimePicker2.Text = letovanje.DatumDo;

            }
            else if (tipPutovanja.Equals("Zimovanje"))
            {
                cbSezonaSkiSkolaSauna.Checked = zimovanje.SkolaSkijanja;
                cbSezonaSkiSkolaSauna.Text = "Ski skola ukljucena";
                cbSezonaSkiSkolaSauna.Visible = true;
                
                tbSkiPassMassage.Text = zimovanje.SkiPass.ToString();
                lblNamena.Text = "SkiPass doplata";
                lblNamena.Visible = true;
                tbSkiPassMassage.Visible = true;


                if (zimovanje.Slika == null)
                    return;

                byte[] buffer = zimovanje.Slika.ToArray();
                MemoryStream memStream = new MemoryStream();
                memStream.Write(buffer, 0, buffer.Length);
                pbSlika.SizeMode = PictureBoxSizeMode.StretchImage;
                pbSlika.Image = Image.FromStream(memStream);

                tbOpis.Text = zimovanje.Opis;
                tbLok.Text = zimovanje.Lokacija;
                tbCena.Text = zimovanje.Cena.ToString();

                dateTimePicker1.Text = zimovanje.DatumOd;
                dateTimePicker2.Text = zimovanje.DatumDo;


            }
            else if (tipPutovanja.Equals("Ekskurzija"))
            {
                comboEnum.Items.Clear();
                comboEnum.Items.Add("apsolventska");
                comboEnum.Items.Add("springBreak");
                comboEnum.Items.Add("skolska");


                if (ekskurzija.TipEkskurzije == TipEkskurzije.apsolventska)
                    comboEnum.SelectedItem = comboEnum.Items[0];
                else if (ekskurzija.TipEkskurzije == TipEkskurzije.springBreak)
                    comboEnum.SelectedItem = comboEnum.Items[1];
                else
                    comboEnum.SelectedItem = comboEnum.Items[2];
                cbParnoKupatilo.Visible = false;
                cbSezonaSkiSkolaSauna.Visible = false;
                lblNamena.Visible = false;
                tbSkiPassMassage.Visible = false;
                comboEnum.Visible = true;

                if (ekskurzija.Slika == null)
                    return;

                byte[] buffer = ekskurzija.Slika.ToArray();
                MemoryStream memStream = new MemoryStream();
                memStream.Write(buffer, 0, buffer.Length);
                pbSlika.SizeMode = PictureBoxSizeMode.StretchImage;
                pbSlika.Image = Image.FromStream(memStream);

                tbOpis.Text = ekskurzija.Opis;
                tbLok.Text = ekskurzija.Lokacija;
                tbCena.Text = ekskurzija.Cena.ToString();

                dateTimePicker1.Text = ekskurzija.DatumOd;
                dateTimePicker2.Text = ekskurzija.DatumDo;

            }
            else
            {
                cbParnoKupatilo.Checked = spa.ParnoKupatilo;
                cbParnoKupatilo.Text = "Parno kupatilo";
                cbParnoKupatilo.Visible = true;
                cbSezonaSkiSkolaSauna.Checked = spa.Sauna;
                cbSezonaSkiSkolaSauna.Text = "Sauna";
                cbSezonaSkiSkolaSauna.Visible = true;
                tbSkiPassMassage.Text = spa.DoplataMasaza.ToString();
                tbSkiPassMassage.Visible = true;
                lblNamena.Text = "Doplata za masazu";
                comboEnum.Visible = false;

                if (spa.Slika == null)
                    return;

                byte[] buffer = spa.Slika.ToArray();
                MemoryStream memStream = new MemoryStream();
                memStream.Write(buffer, 0, buffer.Length);
                pbSlika.SizeMode = PictureBoxSizeMode.StretchImage;
                pbSlika.Image = Image.FromStream(memStream);

                tbOpis.Text = spa.Opis;
                tbLok.Text = spa.Lokacija;
                tbCena.Text = spa.Cena.ToString();

                dateTimePicker1.Text = spa.DatumOd;
                dateTimePicker2.Text = spa.DatumDo;

            }

        }

        private void btnAzuriraj_Click(object sender, EventArgs e)
        {
            string inicijalnaLokacija = comboBox2.SelectedItem.ToString();
            byte[] buffer;
            string opis = tbOpis.Text;
            string lokacija = tbLok.Text;
            string slika = tbSlika.Text;
            double cena = Double.Parse(tbCena.Text);

            if (slika.Equals(""))
            { buffer = null; }
            else
            {
                FileStream fileStream = new FileStream(slika, FileMode.Open, FileAccess.Read);
                buffer = new byte[fileStream.Length];
                fileStream.Read(buffer, 0, (int)fileStream.Length);
                fileStream.Close();
            }

            var connectionString = "mongodb://localhost/?safe=true";
            var server = MongoServer.Create(connectionString);
            var database = server.GetDatabase("agencija");
            var query = Query.EQ("Lokacija", inicijalnaLokacija);

            if (letovanje != null)
            {
                var collectionLetovanja = database.GetCollection<Letovanje>("putovanja");

                if (buffer == null)
                {
                    var update = MongoDB.Driver.Builders.Update.Set("Opis", opis)
                                                            .Set("Lokacija", lokacija)
                                                            .Set("Cena", cena)
                                                            .Set("Sezona", cbSezonaSkiSkolaSauna.Checked)
                                                            .Set("TipLetovanja", comboEnum.SelectedIndex);
                    collectionLetovanja.Update(query, update);

                }
                else
                {
                    var update = MongoDB.Driver.Builders.Update.Set("Opis", opis)
                                                                .Set("Lokacija", lokacija)
                                                                .Set("Cena", cena)
                                                            .Set("Slika", buffer)
                                                            .Set("Sezona", cbSezonaSkiSkolaSauna.Checked)
                                                            .Set("TipLetovanja", comboEnum.SelectedIndex);

                    collectionLetovanja.Update(query, update);

                }
            }

            if (zimovanje != null)
            {
                var collectionZimovanja = database.GetCollection<Zimovanje>("putovanja");

                if (buffer == null)
                {
                    var update = MongoDB.Driver.Builders.Update.Set("Opis", opis)
                                                            .Set("Lokacija", lokacija)
                                                            .Set("Cena", cena)
                                                            .Set("SkolaSkijanja", cbSezonaSkiSkolaSauna.Checked)
                                                            .Set("SkiPass", Double.Parse(tbSkiPassMassage.Text));
                    collectionZimovanja.Update(query, update);

                }
                else
                {
                    var update = MongoDB.Driver.Builders.Update.Set("Opis", opis)
                                                                .Set("Lokacija", lokacija)
                                                                .Set("Cena", cena)
                                                                .Set("Slika", buffer)
                                                                .Set("SkolaSkijanja", cbSezonaSkiSkolaSauna.Checked)
                                                                .Set("SkiPass", Double.Parse(tbSkiPassMassage.Text));

                    collectionZimovanja.Update(query, update);

                }
            }


            if (spa != null)
            {
                var collectionSpa = database.GetCollection<Spa>("putovanja");

                if (buffer == null)
                {
                    var update = MongoDB.Driver.Builders.Update.Set("Opis", opis)
                                                            .Set("Lokacija", lokacija)
                                                            .Set("Cena", cena)
                                                               .Set("Sauna", cbSezonaSkiSkolaSauna.Checked)
                                                                .Set("DoplataMasaza", Double.Parse(tbSkiPassMassage.Text))
                                                                .Set("ParnoKupatilo", cbParnoKupatilo.Checked);
                    collectionSpa.Update(query, update);

                }
                else
                {
                    var update = MongoDB.Driver.Builders.Update.Set("Opis", opis)
                                                                .Set("Lokacija", lokacija)
                                                                .Set("Cena", cena)
                                                                .Set("Slika", buffer)
                                                                .Set("Sauna", cbSezonaSkiSkolaSauna.Checked)
                                                                .Set("DoplataMasaza", Double.Parse(tbSkiPassMassage.Text))
                                                                .Set("ParnoKupatilo", cbParnoKupatilo.Checked);

                    collectionSpa.Update(query, update);

                }
            }

            if (ekskurzija != null)
            {
                var collectionEks = database.GetCollection<Ekskurzija>("putovanja");

                if (buffer == null)
                {
                    var update = MongoDB.Driver.Builders.Update.Set("Opis", opis)
                                                            .Set("Lokacija", lokacija)
                                                            .Set("Cena", cena)
                                                            .Set("TipEkskurzije", comboEnum.SelectedIndex);
                 collectionEks.Update(query, update);

                }
                else
                {
                    var update = MongoDB.Driver.Builders.Update.Set("Opis", opis)
                                                                .Set("Lokacija", lokacija)
                                                                .Set("Cena", cena)
                                                                .Set("Slika", buffer)
                                                            .Set("TipEkskurzije", comboEnum.SelectedIndex);
          
                    collectionEks.Update(query, update);

                }
            }
        }

        private void btnUkloni_Click(object sender, EventArgs e)
        {
            var connectionString = "mongodb://localhost/?safe=true";
            var server = MongoServer.Create(connectionString);
            var db = server.GetDatabase("agencija");


            var collectionLetovanja = db.GetCollection<Putovanje>("letovanja");
            var query = Query.EQ("Lokacija", comboBox2.SelectedItem.ToString());
            collectionLetovanja.Remove(query);


        }

        private void btnSrediKomentare_Click(object sender, EventArgs e)
        {
            
            FormAdminKomentari formKomentari = new FormAdminKomentari(letovanje,zimovanje,spa,ekskurzija);
            formKomentari.Show();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
