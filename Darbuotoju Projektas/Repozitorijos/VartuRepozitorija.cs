using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Darbuotoju_Projektas.Repozitorijos
{
    public class VartuRepozitorija
    {
        public List<Vartai> vartai = new List<Vartai>();
        public VartuRepozitorija()
        {
            vartai.Add(new Vartai(1, "Šiauriniai", 2));
            vartai.Add(new Vartai(1, "Šiauriniai", 3));
            vartai.Add(new Vartai(1, "Šiauriniai", 6));
            vartai.Add(new Vartai(1, "Šiauriniai", 9));
            vartai.Add(new Vartai(1, "Šiauriniai", 10));
            vartai.Add(new Vartai(2, "Rytiniai", 1));
            vartai.Add(new Vartai(2, "Rytiniai", 2));
            vartai.Add(new Vartai(2, "Rytiniai", 4));
            vartai.Add(new Vartai(2, "Rytiniai", 7));
            vartai.Add(new Vartai(2, "Rytiniai", 8));
            vartai.Add(new Vartai(3, "Pietiniai", 3));
            vartai.Add(new Vartai(3, "Pietiniai", 5));
            vartai.Add(new Vartai(3, "Pietiniai", 6));
            vartai.Add(new Vartai(3, "Pietiniai", 8));
            vartai.Add(new Vartai(3, "Pietiniai", 10));
            vartai.Add(new Vartai(4, "Vakariniai", 1));
            vartai.Add(new Vartai(4, "Vakariniai", 3));
            vartai.Add(new Vartai(4, "Vakariniai", 4));
            vartai.Add(new Vartai(4, "Vakariniai", 5));
            vartai.Add(new Vartai(4, "Vakariniai", 7));
            vartai.Add(new Vartai(4, "Vakariniai", 9));
        }

        public Vartai Retrieve(int Id)
        {
            var darbuotojoVartai = vartai.FirstOrDefault(x => x.Id == Id);
            return darbuotojoVartai;
        }
    }
}
