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
            ivykiai.Add(new Ivykis(1, 1, "Pietauti", TimeSpan.FromMinutes(30)));
            ivykiai.Add(new Ivykis(1, 2, "Pietauti", TimeSpan.FromMinutes(30)));
            ivykiai.Add(new Ivykis(1, 3, "Pietauti", TimeSpan.FromMinutes(30)));
            ivykiai.Add(new Ivykis(1, 5, "Pietauti", TimeSpan.FromMinutes(30)));
            ivykiai.Add(new Ivykis(1, 6, "Pietauti", TimeSpan.FromMinutes(30)));
            ivykiai.Add(new Ivykis(1, 7, "Pietauti", TimeSpan.FromMinutes(30)));
            ivykiai.Add(new Ivykis(1, 8, "Pietauti", TimeSpan.FromMinutes(30)));
            ivykiai.Add(new Ivykis(1, 10, "Pietauti", TimeSpan.FromMinutes(30)));
            ivykiai.Add(new Ivykis(2, 4, "Parukyti", TimeSpan.FromMinutes(15)));
            ivykiai.Add(new Ivykis(2, 4, "Parukyti", TimeSpan.FromMinutes(15)));
            ivykiai.Add(new Ivykis(2, 4, "Parukyti", TimeSpan.FromMinutes(15)));
            ivykiai.Add(new Ivykis(2, 3, "Parukyti", TimeSpan.FromMinutes(15)));
            ivykiai.Add(new Ivykis(2, 7, "Parukyti", TimeSpan.FromMinutes(15)));
            ivykiai.Add(new Ivykis(2, 9, "Parukyti", TimeSpan.FromMinutes(15)));
            ivykiai.Add(new Ivykis(2, 9, "Parukyti", TimeSpan.FromMinutes(15)));
            ivykiai.Add(new Ivykis(2, 9, "Parukyti", TimeSpan.FromMinutes(15)));
            ivykiai.Add(new Ivykis(2, 2, "Parukyti", TimeSpan.FromMinutes(15)));
            ivykiai.Add(new Ivykis(2, 6, "Parukyti", TimeSpan.FromMinutes(15)));
            ivykiai.Add(new Ivykis(2, 2, "Parukyti", TimeSpan.FromMinutes(15)));
            ivykiai.Add(new Ivykis(2, 4, "Parukyti", TimeSpan.FromMinutes(15)));
            ivykiai.Add(new Ivykis(3, 1, "Tualetas", TimeSpan.FromMinutes(10)));
            ivykiai.Add(new Ivykis(3, 1, "Tualetas", TimeSpan.FromMinutes(10)));
            ivykiai.Add(new Ivykis(3, 2, "Tualetas", TimeSpan.FromMinutes(10)));
            ivykiai.Add(new Ivykis(3, 3, "Tualetas", TimeSpan.FromMinutes(10)));
            ivykiai.Add(new Ivykis(3, 3, "Tualetas", TimeSpan.FromMinutes(10)));
            ivykiai.Add(new Ivykis(3, 3, "Tualetas", TimeSpan.FromMinutes(10)));
            ivykiai.Add(new Ivykis(3, 4, "Tualetas", TimeSpan.FromMinutes(10)));
            ivykiai.Add(new Ivykis(3, 5, "Tualetas", TimeSpan.FromMinutes(10)));
            ivykiai.Add(new Ivykis(3, 5, "Tualetas", TimeSpan.FromMinutes(10)));
            ivykiai.Add(new Ivykis(3, 6, "Tualetas", TimeSpan.FromMinutes(10)));
            ivykiai.Add(new Ivykis(3, 7, "Tualetas", TimeSpan.FromMinutes(10)));
            ivykiai.Add(new Ivykis(3, 7, "Tualetas", TimeSpan.FromMinutes(10)));
            ivykiai.Add(new Ivykis(3, 7, "Tualetas", TimeSpan.FromMinutes(10)));
            ivykiai.Add(new Ivykis(3, 8, "Tualetas", TimeSpan.FromMinutes(10)));
            ivykiai.Add(new Ivykis(3, 8, "Tualetas", TimeSpan.FromMinutes(10)));
            ivykiai.Add(new Ivykis(3, 9, "Tualetas", TimeSpan.FromMinutes(10)));
            ivykiai.Add(new Ivykis(3, 10, "Tualetas", TimeSpan.FromMinutes(10)));
        }
        public Ivykis Retrieve(int Id)
        {
            var ivykis = ivykiai.FirstOrDefault(x => x.Id == Id);
            return ivykis;
        }

        public List<Ivykis> Retrieve()
        {
            return ivykiai;
        }
    }
}
