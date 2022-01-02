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


    }
}
