using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Darbuotoju_Projektas
{
    public class DarboValanduSarasas
    {
        public string Vardas { get; set; }
        public TimeSpan Valandos { get; set; }

        public List<DarboValanduSarasas> items = new List<DarboValanduSarasas>();

    }

}
