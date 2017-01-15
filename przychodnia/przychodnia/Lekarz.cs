using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace przychodnia
{
    class Lekarz : Osoba
    {
        private string Specjalnosc;

        public Lekarz(string imieNazwisko, string Specjalnosc):base(imieNazwisko)
        {
            this.Specjalnosc = Specjalnosc;
        }

        public override string ToString()
        {
            return "Lekarz, imie i nazwisko " + imieNazwisko + ", " + "specjalnosc  " + Specjalnosc;
        }

    }
}
