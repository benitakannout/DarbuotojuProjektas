using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Darbuotoju_Projektas.Repozitorijos
{
    public class ZmoniuRepozitorija
    {
        public List<Zmogus> zmones = new List<Zmogus>();

        public ZmoniuRepozitorija()
        {
            zmones.Add(new Zmogus(1, "Sandra"));
            zmones.Add(new Zmogus(2, "Aurimas"));
            zmones.Add(new Zmogus(3, "Rimantas"));
            zmones.Add(new Zmogus(4, "Laura"));
            zmones.Add(new Zmogus(5, "Ieva"));
            zmones.Add(new Zmogus(6, "Karolis"));
            zmones.Add(new Zmogus(7, "Zigmas"));
            zmones.Add(new Zmogus(8, "Mindaugas"));
            zmones.Add(new Zmogus(9, "Edvinas"));
            zmones.Add(new Zmogus(10, "Rasa"));
        }

        public Zmogus Retrieve(string Vardas)
        {
            var zmogus = zmones.FirstOrDefault(x => x.Vardas == Vardas);
            return zmogus;
        }

        public List<Zmogus> Retrieve()
        {
            return zmones;
        }
    }
}
