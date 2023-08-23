using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ulohaNakladautaOop
{
     class Auto
    {
        public int nakladdesettisickg = 10000;
        public int nakladpetsetkg = 500;
        public int vylozittristakg = 300;
        public int vylozittisickg = 1000;
        public int nalozenoAktualne = 0;
        public int mezivypocetNakladu = 0;
        public int koliknalozit2 = 0;
        public int nosnost3 = 3000;
        public int kontrolnihodnota1 = 0;
        

        public int nalozeniNakladu()
        {
            for (int i = 0; i < 1; i++) { 
            koliknalozit2 = nosnost3 - nalozenoAktualne;
            if ((nalozenoAktualne == 0) && (mezivypocetNakladu == 0))
            {
                int koliknalozit;
                int nosnost = 3000;
                mezivypocetNakladu = nakladdesettisickg - nosnost;
                koliknalozit = nosnost - nalozenoAktualne;
                nalozenoAktualne = nalozenoAktualne + koliknalozit;
                 Console.WriteLine("Prvni nalozeni, nalozeno " + nalozenoAktualne + " kg");
                return nalozenoAktualne;
            }
            if ((mezivypocetNakladu > koliknalozit2) && (nalozenoAktualne < 3000))
            {
                int koliknalozit1;
                int nosnost1 = 3000;
                koliknalozit1 = nosnost1 - nalozenoAktualne;
                nalozenoAktualne = nalozenoAktualne + koliknalozit1;
                mezivypocetNakladu = mezivypocetNakladu - koliknalozit1;
                Console.WriteLine("Nalozeno " + koliknalozit1 + " kg ");
                return nalozenoAktualne;

            }
            if ((mezivypocetNakladu < koliknalozit2) && (nalozenoAktualne < 3000) && (mezivypocetNakladu >0))
            {
                nalozenoAktualne = nalozenoAktualne + mezivypocetNakladu;
                    mezivypocetNakladu = mezivypocetNakladu - mezivypocetNakladu;
                    Console.WriteLine(" je min nakladu nez kolik by se melo nalozit do maximalni nosnosti" );
                return nalozenoAktualne;

            }
            if (mezivypocetNakladu == 0)
            {
                   kontrolnihodnota1++;
                if (kontrolnihodnota1 < 2)
                {
                    mezivypocetNakladu = mezivypocetNakladu + nakladpetsetkg;
                    Console.WriteLine("nalozilo se poslednich 500kg uz se bude jen vykladat !!!!! ");
                    return nalozenoAktualne;
                    break;
                    
                    
                    }
                else
                break;
               
            }

            }
            return nalozenoAktualne;
        }


        public int vypocetnakladu ()

        {
                nalozeniNakladu();
        
                if ((nalozenoAktualne > 0) && (nalozenoAktualne <= 3000))
                  {
                vylozitnaklad();
                   }
            return nalozenoAktualne;
        }

        public int vypismezinakladu ( )
        {
            return mezivypocetNakladu;
        }

        public int vypisnalozenoAktualne()
        {
            return nalozenoAktualne;
        }

        public int vylozitnaklad ()
        {
            for (int i = 0; i < 1; i++)
            {
                int kontrolnivypocet;
                int kontrolnivypocet1;
                kontrolnivypocet = nalozenoAktualne - vylozittristakg;
                kontrolnivypocet1 = kontrolnivypocet - vylozittisickg;
                if ((kontrolnivypocet <= 0) || (nalozenoAktualne <= 0))
                {
                    Console.WriteLine("nelze nic vykladat nemame dostatek nakladu k nalozen, meniznaklad je prazdny" + nalozenoAktualne);
                    break;
                }

                if (((kontrolnivypocet > 0) && (kontrolnivypocet1 > 0)) || (kontrolnivypocet1 ==0))
                {
                    int vylozitaktualne = vylozittristakg + vylozittisickg;
                    nalozenoAktualne = nalozenoAktualne - vylozitaktualne;
                 Console.WriteLine("Vylozeno " + vylozitaktualne + " kg");
                 Console.WriteLine("Zustatek nakladu v aute po vylozeni " + nalozenoAktualne + " kg");
                    return nalozenoAktualne;

                }
                if (((kontrolnivypocet>0) && ( kontrolnivypocet1 < 0)) || (kontrolnivypocet ==0))
                {
                  nalozenoAktualne = nalozenoAktualne - vylozittristakg;
                    Console.WriteLine(" Vylozeno " + vylozittristakg+ "kg" );
                    Console.WriteLine("V nákladním autě je naloženo " + nalozenoAktualne + "kg");
                    return nalozenoAktualne;
                }
                         

                
            }
           


            return nalozenoAktualne;
        }
        public int NakladtriStakg()
        {
            return vylozittristakg;
        }

        public int podminkaPropreruseni()
        {
            if ((mezivypocetNakladu == 0) && (nalozenoAktualne < vylozittristakg))
            {
                return 1;
            }
            return 0;
        }

    }
}
