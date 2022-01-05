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
            ivykiai.Add(new Ivykis(1, "Sandra", "Pietauti", TimeSpan.FromMinutes(30)));
            ivykiai.Add(new Ivykis(1, "Aurimas", "Pietauti", TimeSpan.FromMinutes(30)));
            ivykiai.Add(new Ivykis(1, "Rimantas", "Pietauti", TimeSpan.FromMinutes(30)));
            ivykiai.Add(new Ivykis(1, "Ieva", "Pietauti", TimeSpan.FromMinutes(30)));
            ivykiai.Add(new Ivykis(1, "Karolis", "Pietauti", TimeSpan.FromMinutes(30)));
            ivykiai.Add(new Ivykis(1, "Zigmas", "Pietauti", TimeSpan.FromMinutes(30)));
            ivykiai.Add(new Ivykis(1, "Mindaugas", "Pietauti", TimeSpan.FromMinutes(30)));
            ivykiai.Add(new Ivykis(1, "Rasa", "Pietauti", TimeSpan.FromMinutes(30)));
            ivykiai.Add(new Ivykis(2, "Laura", "Parukyti", TimeSpan.FromMinutes(15)));
            ivykiai.Add(new Ivykis(2, "Laura", "Parukyti", TimeSpan.FromMinutes(15)));
            ivykiai.Add(new Ivykis(2, "Laura", "Parukyti", TimeSpan.FromMinutes(15)));
            ivykiai.Add(new Ivykis(2, "Rimantas", "Parukyti", TimeSpan.FromMinutes(15)));
            ivykiai.Add(new Ivykis(2, "Zigmas", "Parukyti", TimeSpan.FromMinutes(15)));
            ivykiai.Add(new Ivykis(2, "Edvinas", "Parukyti", TimeSpan.FromMinutes(15)));
            ivykiai.Add(new Ivykis(2, "Edvinas", "Parukyti", TimeSpan.FromMinutes(15)));
            ivykiai.Add(new Ivykis(2, "Edvinas", "Parukyti", TimeSpan.FromMinutes(15)));
            ivykiai.Add(new Ivykis(2, "Aurimas", "Parukyti", TimeSpan.FromMinutes(15)));
            ivykiai.Add(new Ivykis(2, "Karolis", "Parukyti", TimeSpan.FromMinutes(15)));
            ivykiai.Add(new Ivykis(2, "Aurimas", "Parukyti", TimeSpan.FromMinutes(15)));
            ivykiai.Add(new Ivykis(2, "Laura", "Parukyti", TimeSpan.FromMinutes(15)));
            ivykiai.Add(new Ivykis(3, "Sandra", "Tualetas", TimeSpan.FromMinutes(10)));
            ivykiai.Add(new Ivykis(3, "Sandra", "Tualetas", TimeSpan.FromMinutes(10)));
            ivykiai.Add(new Ivykis(3, "Aurimas", "Tualetas", TimeSpan.FromMinutes(10)));
            ivykiai.Add(new Ivykis(3, "Rimantas", "Tualetas", TimeSpan.FromMinutes(10)));
            ivykiai.Add(new Ivykis(3, "Rimantas", "Tualetas", TimeSpan.FromMinutes(10)));
            ivykiai.Add(new Ivykis(3, "Rimantas", "Tualetas", TimeSpan.FromMinutes(10)));
            ivykiai.Add(new Ivykis(3, "Laura", "Tualetas", TimeSpan.FromMinutes(10)));
            ivykiai.Add(new Ivykis(3, "Ieva", "Tualetas", TimeSpan.FromMinutes(10)));
            ivykiai.Add(new Ivykis(3, "Ieva", "Tualetas", TimeSpan.FromMinutes(10)));
            ivykiai.Add(new Ivykis(3, "Karolis", "Tualetas", TimeSpan.FromMinutes(10)));
            ivykiai.Add(new Ivykis(3, "Zigmas", "Tualetas", TimeSpan.FromMinutes(10)));
            ivykiai.Add(new Ivykis(3, "Zigmas", "Tualetas", TimeSpan.FromMinutes(10)));
            ivykiai.Add(new Ivykis(3, "Zigmas", "Tualetas", TimeSpan.FromMinutes(10)));
            ivykiai.Add(new Ivykis(3, "Mindaugas", "Tualetas", TimeSpan.FromMinutes(10)));
            ivykiai.Add(new Ivykis(3, "Mindaugas", "Tualetas", TimeSpan.FromMinutes(10)));
            ivykiai.Add(new Ivykis(3, "Edvinas", "Tualetas", TimeSpan.FromMinutes(10)));
            ivykiai.Add(new Ivykis(3, "Rasa", "Tualetas", TimeSpan.FromMinutes(10)));
        }
        public Ivykis Retrieve(string Darbuotojas)
        {
            var ivykis = ivykiai.FirstOrDefault(x => x.Darbuotojas == Darbuotojas);
            return ivykis;
        }

        public List<Ivykis> Retrieve()
        {
            return ivykiai;
        }

        public List<Ivykis> RetrieveByPerson(string darbuotojas)
        {
            var ivykiai = Retrieve();
            ivykiai = ivykiai.Where(ivykis => ivykis.Darbuotojas.Equals(darbuotojas)).ToList();
            return ivykiai;
        }
    }
}
