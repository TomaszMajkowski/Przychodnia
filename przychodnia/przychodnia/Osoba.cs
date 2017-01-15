using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace przychodnia
{
    abstract class Osoba
    {
        protected string imieNazwisko;

        public Osoba (string imieNazwisko) // Konstruktor z parometrem 
        {
            this.imieNazwisko = imieNazwisko;
        }
    }
}
