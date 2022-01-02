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

        public int Pietauti = 45;
        public int Parukyti = 15;
        public int Tualetas = 10;
    }
}
