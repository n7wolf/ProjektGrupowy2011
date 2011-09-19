using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using StudentsDatabase.Core;

namespace StudentsDatabase
{
    [TestClass]
    public class KalkulatorWiekuTesty
    {
        public static int RokTestowy = 1988;
        public static int MiesiacTestowy = 12;
        public static int DzienTestowy = 1;
        public int OczekiwanaIloscLat = DateTime.Now.Year - RokTestowy;
        private IWiek _osoba;

        [TestInitialize]
        public void Setup()
        {
            _osoba = new Osoba()
            {
                Imie = "Jan",
                Nazwisko = "Kowalski",
                DataUrodzenia = new DateTime(RokTestowy, MiesiacTestowy, DzienTestowy)
            };
        }

        [TestMethod]
        public void MetodaObliczZwracaIloscLat()
        {
            var kalkulatorWieku = new KalkulatorWieku(_osoba);
            Assert.AreEqual(OczekiwanaIloscLat, kalkulatorWieku.Oblicz());
        }
    }
}
