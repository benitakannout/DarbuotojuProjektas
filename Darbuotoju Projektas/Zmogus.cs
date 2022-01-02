using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Darbuotoju_Projektas
{
    public class Zmogus
    {
        public int Id { get; set; }
        public string Vardas { get; set; }

        public Zmogus()
        {

        }

        public Zmogus(int Id, string Vardas)
        {
            Id = Id;
            Vardas = Vardas;
        }
    }
}
