using Darbuotoju_Projektas;
using Darbuotoju_Projektas.Repozitorijos;
using System;
using System.Collections.Generic;
using System.Linq;

namespace MyApp // Note: actual namespace depends on the project name.
{
    public class Program
    {
        public static void Main(string[] args, DarboValanduSarasas darboValanduSarasas)
        {          
            foreach (var item in darboValanduSarasas)
            {
                Console.WriteLine(item);
            }

            Console.ReadLine();
        }
    }
}