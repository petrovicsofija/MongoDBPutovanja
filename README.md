Na nalog admina se loguje pomocu korisnickog imena Admin1 i sifre 12345 ili korisnickog imena Admin2 i sifre 67890
Inicijalno je u bazi samo kreirana prazna kolekcija "komentari", a ona dobija podatke tako sto korisnik unosi komentare(utiske) sa konkretnog putovanja i bira sliku iz svog fajl sistema unosenjem apsolutne putanje do nje. U resursima postoji nekoliko slika do kojih mozete da navedete putanju prilikom testiranja aplikacije.
Fajl "kreiranjeBazeIKolekcija.sql" sadrzi samo naredbe za kreiranje baze i kolekcije. Inicijalna baza unosi se pomocu mongoimport naredbi i navodjenjem odgovarajuceg .json fajla.

pr.
C:\mongodb\bin>mongoimport --db agencija --collection putovanja --jsonArray --file putovanja.json
C:\mongodb\bin>mongoimport --db agencija --collection administratori --jsonArray --file administratori.json