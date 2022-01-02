using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Darbuotoju_Projektas
{
    public class IvykisManager
    {
        public TimeSpan TrukmePagalPavadinima(string pavadinimas)
        {
            switch (pavadinimas)
            {
                case "Pietauti":
                    return new TimeSpan(45);
                case "Parukyti":
                    return new TimeSpan(15);
                case "Tualetas":
                    return new TimeSpan(10);
                default:
                    return new TimeSpan(0);
            }
        }
    }
}
