using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;


namespace przychodnia
{
    class Przychodnia : IPrzychodnia
    {
        private Lekarz lekarz;
        private Stack<Pacjent> pacjenci = new Stack<Pacjent>();

        public void UstawLekarza(string imieN, string specjalnosc)
        {
            lekarz = new Lekarz(imieN, specjalnosc);
        }

        public void ZapiszDoLekarza(string imieN, int wiek, string choroba)
        {
            pacjenci.Push(new Pacjent(imieN, wiek, choroba));
        }

        public string WykonajPorade()
        {
            Pacjent temp = pacjenci.Pop();
            return "Wykonano porade! " + temp.ToString();
        }

        public string WykonajBadanie()
        {
            Pacjent temp = pacjenci.Peek();
            return "Wykonano badanie! " + temp.ToString();
        }

        public int CzasOczekiwania()
        {
            int count = pacjenci.Count;
            int result = (int)Math.Truncate((decimal)count / 5);
            return result;
        }

        public override string ToString()
        {
            string temp = "";
            temp += lekarz.ToString() + "\nPacjenci oczekujący: \n";
            foreach (Object obj in pacjenci)
            {
                temp += obj.ToString() + ",\n";
            }
            temp += Convert.ToString(CzasOczekiwania());
            return temp;
        }

        public void GenerujRaport()
        {
            string path = System.Environment.GetFolderPath(System.Environment.SpecialFolder.Desktop) + @"\Generowane raporty\";
            string name = "Raport" + Convert.ToString(DateTime.Now.Day) +
                Convert.ToString(DateTime.Now.Month) +
                Convert.ToString(DateTime.Now.Year) +
                Convert.ToString(DateTime.Now.Hour) +
                Convert.ToString(DateTime.Now.Minute) + ".txt";
            using (StreamWriter plik = new StreamWriter(path + name))
            {
                plik.WriteLine(ToString());
            }
        }

        public bool CzyLekarz()
        {
            return (this.lekarz != null) ? true : false;
        }
    }
}