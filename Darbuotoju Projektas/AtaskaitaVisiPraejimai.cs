using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Darbuotoju_Projektas.Repozitorijos;

namespace Darbuotoju_Projektas
{
    public class AtaskaitaVisiPraejimai
    {
        public IvykiuRepozitorija _ivykiuRepozitorija;
        public VartuRepozitorija _vartuRepozitorija;
        public ZmoniuRepozitorija _zmoniuRepozitorija;

        public AtaskaitaVisiPraejimai(IvykiuRepozitorija ivykiuRepozitorija, VartuRepozitorija vartuRepozitorija, ZmoniuRepozitorija zmoniuRepozitorija)
        {
            _ivykiuRepozitorija = ivykiuRepozitorija;
            _vartuRepozitorija = vartuRepozitorija;
            _zmoniuRepozitorija = zmoniuRepozitorija;
        }

        public List<PraejimuSarasas> PraejimuSarasas(IvykiuRepozitorija ivykiuRepozitorija, ZmoniuRepozitorija zmoniuRepozitorija)
        {
            var zmones = zmoniuRepozitorija.Retrieve();
            var items = new List<PraejimuSarasas>();

            foreach (var zmogus in zmones)
            {
                var item = new PraejimuSarasas();
                item.Vardas = zmogus.Vardas;
                var ivykiai = ivykiuRepozitorija.RetrieveByPerson(item.Vardas);
                
                foreach (var ivykis in ivykiai)
                {
                    item.PraejimuKiekis += 1;
                    item.PraejimuLaikas += ivykis.Trukme;

                    if (ivykis.Id == 1)
                    {
                        item.Pietauti += 1;
                        item.PietautiLaikas += ivykis.Trukme;
                    }
                    else if (ivykis.Id == 2)
                    {
                        item.Parukyti += 1;
                        item.ParukytiLaikas += ivykis.Trukme;
                    }
                    else if (ivykis.Id == 3)
                    {
                        item.Tualetas += 1;
                        item.TualetasLaikas += ivykis.Trukme;
                    }
                }
            }
            return items;
        }

    }
}
