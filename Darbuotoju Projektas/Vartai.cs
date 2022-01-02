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
        public Vartai (int VartuId, string Pavadinimas, int DarbuotojoId)
        {
            VartuId = VartuId;
            Pavadinimas = Pavadinimas;
            DarbuotojoId = DarbuotojoId;
        }
    }
}
