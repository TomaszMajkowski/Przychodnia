using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace przychodnia
{
    class Pacjent : Osoba // dziedziczenie
    {
        private int wiek;
        private string choroba;

        public Pacjent (string imieNazwisko, int wiek, string choroba ):base(imieNazwisko) // konstruktor parometryczny(ustawiający)
        {
        this.wiek = wiek;
        this.choroba = choroba;
        }

        public override string ToString() //metoda przysłaniajaca i zwracajaca informacje
        {
            return "Pacjent:" + Environment.NewLine + "Imie Nazwisko "+ imieNazwisko + " Wiek " + wiek + " Choroba " + choroba ; // envitonment przeniesienie do nowej lini
        }
    }
}
