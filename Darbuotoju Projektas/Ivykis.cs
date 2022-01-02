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
        public int DarbuotojoId { get; set; }
        public string Pavadinimas { get; set; }
        public TimeSpan Trukme { get; set; }

        public Ivykis()
        {

        }
        public Ivykis(int Id, int DarbuotojoId, string Pavadinimas, TimeSpan Trukme)
        {
            Id = Id;
            DarbuotojoId = DarbuotojoId;
            Pavadinimas = Pavadinimas;
            Trukme = Trukme;
        }

    }
}
