using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Darbuotoju_Projektas.Repozitorijos
{
    public class IvykiuRepozitorija
    {
        public List<Ivykis> ivykiai = new List<Ivykis>();
        public IvykiuRepozitorija()
        {
            ivykiai.Add(new Ivykis(1, 1, "Pietauti"));
        }
    }
}
