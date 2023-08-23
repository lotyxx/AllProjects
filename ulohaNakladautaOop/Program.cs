using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ulohaNakladautaOop
{
    //Zadání
    //S použitím objektově orientovaného programování vytvořte aplikaci, ve
    //které figuruje nákladní auto, které převáží písek.Toto auto má
    //nosnost 3 tuny a jeho náklad je zpočátku prázdný.
    //Nechte auto postupně:
    //naložit 10 tun
    //naložit 500 kg
    //vyložit 300 kg
    //vyložit 1 tunu
    //Jak asi tušíte, naložení a vyložení nákladu bude probíhat pomocí
    //metod, které si před změnou váhy nákladu nejprve ověří, zda je v autě
    //dost místa nebo zda nevykládáme více, než je naloženo.V případě chyby
    //se náklad nevloží/nevyloží.
    //Po dokončení nakládání a vykládání nechte vypsat kolik je v autě kg
    //nákladu, mělo by vám vyjít 200 kg.
    //Zdroj: 
    class Program
    {
        static void Main(string[] args)
        {
            Auto auto;
            auto = new Auto();
            int test1;
            int test2;
            int test3;
            test3 = 0;

            while ( test3 == 0)
            {
             test1 = auto.vypocetnakladu();
             test2 = auto.vypismezinakladu();
             Console.WriteLine(" Aktualni zustatek mezinakladu " + test2 + " kg");
             test3 = auto.podminkaPropreruseni();

            } 
                
  
            Console.ReadKey();
        }
    }
}
