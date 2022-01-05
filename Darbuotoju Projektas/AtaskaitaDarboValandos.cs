using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Darbuotoju_Projektas.Repozitorijos;

namespace Darbuotoju_Projektas
{
    public class AtaskaitaDarboValandos
    {
        public IvykiuRepozitorija _ivykiuRepozitorija;
        public VartuRepozitorija _vartuRepozitorija;
        public ZmoniuRepozitorija _zmoniuRepozitorija;

        public AtaskaitaDarboValandos(IvykiuRepozitorija ivykiuRepozitorija, VartuRepozitorija vartuRepozitorija, ZmoniuRepozitorija zmoniuRepozitorija)
        {
            _ivykiuRepozitorija = ivykiuRepozitorija;
            _vartuRepozitorija = vartuRepozitorija;
            _zmoniuRepozitorija = zmoniuRepozitorija;
        }

        public List<DarboValanduSarasas> ValanduSarasas (IvykiuRepozitorija ivykiuRepozitorija, ZmoniuRepozitorija zmoniuRepozitorija)
        {
            var zmones = zmoniuRepozitorija.Retrieve();
            var items = new List<DarboValanduSarasas>();

            foreach (var zmogus in zmones)
            {
                var item = new DarboValanduSarasas();
                item.Vardas = zmogus.Vardas;
                var ivykiai = ivykiuRepozitorija.RetrieveByPerson(item.Vardas);
                item.Valandos = TimeSpan.FromHours(9);

                foreach (var ivykis in ivykiai)
                {
                    item.Valandos -= ivykis.Trukme;
                }
            }
            return items;
        }

    }
}
