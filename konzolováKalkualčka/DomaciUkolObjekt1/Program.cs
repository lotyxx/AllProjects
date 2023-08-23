using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomaciUkolObjekt1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Kalkulacka kalkulacka = new Kalkulacka();
            kalkulacka.VstupniText("Zadej 1. číslo: ");
            float a = kalkulacka.VstupniPromenna1();
            kalkulacka.VstupniText("Zadej 2. číslo: ");
            float b = kalkulacka.VstupniPromenna2();



             float vysl = kalkulacka.Scitani(a,b);
             Console.WriteLine("Součet: {0}", vysl);
            float vysl1 = kalkulacka.Rozdil(a,b);
            Console.WriteLine("Rozdíl: {0}", vysl1);
            float vysl2 = kalkulacka.Podil(a,b);
            Console.WriteLine("Podíl: {0}", vysl2);
            float vysl3 = kalkulacka.Nasobeni(a,b);
            Console.WriteLine("Součin: {0}", vysl3);
            Console.ReadKey();

            

        }
    }
}
