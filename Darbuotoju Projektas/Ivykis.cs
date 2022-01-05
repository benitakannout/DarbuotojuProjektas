using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Darbuotoju_Projektas
{
    public class Ivykis
    {
        public int Id { get; set; }
        public string Darbuotojas { get; set; }
        public string Pavadinimas { get; set; }
        public TimeSpan Trukme { get; set; }

        public Ivykis()
        {

        }
        public Ivykis(int Id, string Darbuotojas, string Pavadinimas, TimeSpan Trukme)
        {
            Id = Id;
            Darbuotojas = Darbuotojas;
            Pavadinimas = Pavadinimas;
            Trukme = Trukme;
        }

    }
}
