using System;

namespace Class
{
    //[Serializable]
    public class Hitovi
    {

        string slika;
        string naziv;
        string izvodjac;
        double duzina;
        DateTime datumObjavljivanja;
        string opisPath;

        public Hitovi()
        {

        }

        public Hitovi(string slika, string naziv, string izvodjac, double duzina, DateTime datumObjavljivanja, string opisPath)
        {
            this.Slika = slika;
            this.Naziv = naziv;
            this.Izvodjac = izvodjac;
            this.Duzina = duzina;
            this.DatumObjavljivanja = datumObjavljivanja;
            this.OpisPath = opisPath;
        }

        public string Slika { get => slika; set => slika = value; }
        public string Naziv { get => naziv; set => naziv = value; }
        public string Izvodjac { get => izvodjac; set => izvodjac = value; }
        public double Duzina { get => duzina; set => duzina = value; }
        public DateTime DatumObjavljivanja { get => datumObjavljivanja; set => datumObjavljivanja = value; }
        public string OpisPath { get => opisPath; set => opisPath = value; }
    }
}