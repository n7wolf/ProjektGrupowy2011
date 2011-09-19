using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;

namespace StudentsDatabase.Core
{
    public class OsobyPrzedmiotyDatabase
    {
        public ArrayList Studenci = new ArrayList();
        public ArrayList Przedmioty = new ArrayList();

        public Osoba SzukajOsoby(Osoba osoba)
        {
            try
            {
                return (Osoba)Studenci[Studenci.IndexOf(osoba)];
            }
            catch (System.ArgumentOutOfRangeException ex)
            {
                throw new ApplicationException("W bazie nie ma takiej osoby");
            }

        }

        public Przedmiot SzukajPrzedmiotu(Przedmiot przedmiot)
        {
            try
            {
                return (Przedmiot)Przedmioty[Przedmioty.IndexOf(przedmiot)];
            }
            catch (System.ArgumentOutOfRangeException ex)
            {
                throw new ApplicationException("W bazie nie ma takiego przedmiotu");
            }
        }
    }
}
