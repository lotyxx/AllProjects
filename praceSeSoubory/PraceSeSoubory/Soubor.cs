using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;


namespace PraceSeSoubory
{
    public class Soubor
    {
        public static bool ExistujeSoubor(string soubor)
        {

            if (File.Exists(soubor))
            {
                Console.WriteLine("soubor  {0} existuje", soubor);
                return true;

            }
            Console.WriteLine("soubor  {0} neexistuje", soubor);
            return false;
        }
        public static void VymazSoubor(string soubor)
        {
            File.Delete(soubor);
            Console.WriteLine("soubor {0} byl smazan  neexistuje", soubor);
        }
        public static void InfoOSouboru(string soubor)

        {
            var fi = new FileInfo(soubor);
            if (!fi.Exists)
                return;
            Console.WriteLine("informace o souboru {0}", soubor);
            Console.WriteLine("CreationTime {0}", fi.CreationTime);
            Console.WriteLine("LastAccesTime {0}", fi.LastAccessTime);            
        }
        public static void PathPokusy (string soubor)
        {
            Console.WriteLine("Soubor                    {0}",soubor);
            Console.WriteLine("GetFullPath               {0}", Path.GetFullPath(soubor));
            Console.WriteLine("GetDirectoryName          {0}", Path.GetDirectoryName(soubor));
            Console.WriteLine("GetExtension               {0}", Path.GetExtension(soubor));
            Console.WriteLine("GetFileName               {0}", Path.GetFileName(soubor));
            Console.WriteLine("GetFileNameWithoutExtension      {0}", Path.GetFileNameWithoutExtension(soubor));
            Console.WriteLine(" GetPathRoot              {0}", Path.GetPathRoot(soubor));
        }
        public static void PodlozkyVeSlozce(string slozka)
        {
            string[] soubory = Directory.GetFiles(slozka);
            foreach (string soubor in soubory)
                Console.WriteLine(Path.GetFileName(soubor));
        }
        public static void PodslozkyVeSlozce(string slozka)
        {
            string[] soubory = Directory.GetDirectories(slozka);
            foreach (string soubor in soubory)
                Console.WriteLine(Path.GetFileName(soubor));
        }
        
    }
}
