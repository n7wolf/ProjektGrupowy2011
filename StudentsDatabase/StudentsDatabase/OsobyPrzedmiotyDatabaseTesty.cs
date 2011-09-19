using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using StudentsDatabase.Core;

namespace StudentsDatabase
{
    [TestClass]
    public class OsobyPrzedmiotyDatabaseTesty
    {
        [TestMethod]
        public void MetodaSzukajOsobyZwracaPrawidlowaOsobe()
        {
            OsobyPrzedmiotyDatabase opd = new OsobyPrzedmiotyDatabase();
            Osoba studentIstniejacy = new Osoba()
            {
                Imie = "Jan",
                Nazwisko = "Istniejacy",
                ECTS = 1,
                DataUrodzenia = new DateTime(1991, 2, 3),
                NumerAlbumu = 01234,
                Semestr = 3
            };
            opd.Studenci.Add(studentIstniejacy);
            Assert.AreEqual(studentIstniejacy, opd.SzukajOsoby(studentIstniejacy));
            
        }

        //do przerobienia
        [TestMethod]
        [ExpectedException(typeof(ApplicationException),"W bazie nie ma takiej osoby")]
        public void MetodaSzukajOsobyZwracaWyjatekGdyNieMaTakiejOsobyWBazie()
        {
            OsobyPrzedmiotyDatabase opd = new OsobyPrzedmiotyDatabase();
            Osoba studentNieIstniejacy = new Osoba(){
                Imie = "Jan",
                Nazwisko = "Nieistniejacy",
                ECTS = 33333,
                DataUrodzenia = new DateTime(1991,2,3),
                NumerAlbumu = 01234,
                Semestr = 3
            };
            opd.SzukajOsoby(studentNieIstniejacy);
            
        }

        [TestMethod]
        public void MetodaSzukajPrzedmiotyZwracaPrawidlowyPrzedmiot()
        {
            Przedmiot przedmiot = new Przedmiot()
            {
                ID = 0,
                Nazwa = "Szkolenie BHP",
                Prowadzacy = "Anna BeHaPe"
            };
            OsobyPrzedmiotyDatabase opd = new OsobyPrzedmiotyDatabase();
            opd.Przedmioty.Add(przedmiot);
            Assert.AreEqual(przedmiot, opd.SzukajPrzedmiotu(przedmiot));
        }

        [TestMethod]
        [ExpectedException(typeof(ApplicationException),"W bazie nie ma takiego przedmiotu")]
        public void MetodaSzukajPrzedmiotyZwracaWyjatekGdyNieMaTakiegoPrzedmiotu()
        {
            Przedmiot przedmiot = new Przedmiot()
            {
                ID = 0,
                Nazwa = "Szkolenie BHP Nie Istnieje",
                Prowadzacy = "Anna BeHaPe"
            };
            OsobyPrzedmiotyDatabase opd = new OsobyPrzedmiotyDatabase();
            opd.SzukajPrzedmiotu(przedmiot);
            //Assert.AreEqual(null, opd.SzukajPrzedmiotu(przedmiot));
        }
    }
}
