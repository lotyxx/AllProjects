using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomaciUkolObjekt1
{


    class Kalkulacka
    {

        
        public float vysl;
        public float vysl1;
        public float vysl2;
        public float vysl3;
        public float a;
        public float b;
        public float VstupniPromenna1()
        {
            float a = float.Parse(Console.ReadLine());
            return a;
        }

        public float VstupniPromenna2()
        {
            float b = float.Parse(Console.ReadLine());
            return b;
        }
       
        public void VstupniText( string cislo1)
        {
            Console.Write("{0}",cislo1);

        }
        
        public float Scitani(float a, float b)
        {
            vysl = a + b;
            return vysl;

        }

        public float Rozdil(float a, float b)
        {
            vysl1 = a - b;
            return vysl1;
        }
        public float Podil(float a, float b)
        {
            vysl2 = a / b;
            return vysl2;
            
               
        }
        public float Nasobeni(float a, float b)
        {
            vysl3 = a * b;
            return vysl3;
        }


    }
}
