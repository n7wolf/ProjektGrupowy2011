using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using StudentsDatabase.Core;

namespace StudentsDatabase
{
    [TestClass]
    public class PrzedmiotTesty
    {
        public Przedmiot _przedmiot;

        [TestInitialize]
        public void Setup()
        {
            _przedmiot = new Przedmiot()
            {
                ID=0,
                Nazwa="Szkolenie",
                Prowadzacy = "Ktoś SuperŁoś"
            };
        }

        [TestMethod]
        public void MetodaToStringZwracaDanePrzedmiotu()
        {
            Assert.AreEqual("ID: 0, \"Szkolenie\", Prowadzacy: Ktoś SuperŁoś", _przedmiot.ToString());
        }
    }
}
