using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Darbuotoju_Projektas
{
    public class Vartai
    {
        public int Id { get; set; }
        public string Pavadinimas { get; set; }
        public int DarbuotojoId { get; set; }

        public Vartai()
        {

        }
        public Vartai (int Id, string Pavadinimas, int DarbuotojoId)
        {
            Id = Id;
            Pavadinimas = Pavadinimas;
            DarbuotojoId = DarbuotojoId;
        }
    }
}
