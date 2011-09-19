using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using StudentsDatabase.Core;
using System.Collections;

namespace StudentsDatabase
{
    [TestClass]
    public class OsobaTesty
    {
        Osoba _osoba { get; set; }
        
        [TestInitialize]
        public void Setup()
        {
            _osoba = new Osoba()
            {
                Imie = "Jan",
                Nazwisko = "Kowalski",
                DataUrodzenia = new DateTime(1988, 12, 1),
                ECTS = 0,
                NumerAlbumu = 113311,
                Semestr = 0
            };
        }

        [TestMethod]
        public void MetodaToStringZwracaImieOrazNazwisko()
        {
            Assert.AreEqual("113311 Jan Kowalski ECTS: 0 Semestr: 0", _osoba.ToString());
        }

        [TestMethod]
        public void MetodaWiekZwracaIloscLatOsoby()
        {
            Assert.AreEqual(23, _osoba.Wiek);
        }

        [TestMethod]
        public void MetodaZwrocPrzedmiotyZwracaJedenPrzedmiot()
        {
            var _przedmiot = new Przedmiot()
            {
                ID = 1,
                Nazwa = "Szkolenie BHP",
                Prowadzacy = "Anna Niebezpieczna"
            };
            _osoba.Przedmioty.Add(_przedmiot);
            Assert.AreEqual(_przedmiot, _osoba.ZwrocPrzedmioty()[0]);
        }

        [TestMethod]
        public void MetodaZwrocPrzedmiotyZwracaKilkaPrzedmiotow()
        {
            var przedmioty = new ArrayList();
            przedmioty.Add(new Przedmiot() { ID = 1, Nazwa = "Szkolenie BHP", Prowadzacy = "Anna Niebezpieczna" });
            przedmioty.Add(new Przedmiot() { ID = 2, Nazwa = "Szkolenie Biblioteczne", Prowadzacy = "Anna Czytacz" });
            przedmioty.Add(new Przedmiot() { ID = 3, Nazwa = "Wychowanie Sportowe", Prowadzacy = "Henryk Kania" });
            _osoba.Przedmioty = przedmioty;
            Assert.AreEqual(przedmioty, _osoba.ZwrocPrzedmioty());
        }
    }

    
}
