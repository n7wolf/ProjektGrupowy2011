using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StudentsDatabase.Core
{
    public class KalkulatorWieku
    {
        public readonly IWiek _osoba;
        public KalkulatorWieku(IWiek osoba)
        {
            _osoba = osoba;
        }
        public int Oblicz()
        {
            return DateTime.Now.Year - _osoba.DataUrodzenia.Year;
        }
    }
}
