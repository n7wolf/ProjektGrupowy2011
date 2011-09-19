using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;

namespace StudentsDatabase.Core
{
    public class Osoba : IWiek
    {
        public string Imie { get; set; }
        public string Nazwisko { get; set; }
        public DateTime DataUrodzenia { get; set; }
        public int ECTS { get; set; }
        public int NumerAlbumu { get; set; }
        public int Semestr { get; set; }
        public ArrayList Przedmioty { get; set; }
        public Osoba()
        {
            Przedmioty = new ArrayList();
        }
        public override string ToString()
        {
            return string.Format("{0} {1} {2} ECTS: {3} Semestr: {4}", NumerAlbumu,Imie, Nazwisko, ECTS, Semestr);
        }
        public int Wiek
        {
            get
            {
                return DateTime.Now.Year - DataUrodzenia.Year;
            }
        }

        public ArrayList ZwrocPrzedmioty()
        {
            return Przedmioty;
        }
    }
}
