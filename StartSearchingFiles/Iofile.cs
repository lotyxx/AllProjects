using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StartSearchingFiles
{

    //Description: This class contains functions for working with file
    public class Iofile
    {
        public string path;
        string keyWord = "Host key fingerprint is:";
        int numberOfline = 0;
        int foundLine = 0;
        string foundedkey = "";
        public int lengthOfFingerPrint;
        public int valueExampleFP;
        public string realFingerPrint;

        //Constructor set variable of path of logFile
        public Iofile(string path) 
        {
            this.path = path;
        }

        //Checking if path exist
        public string VerifyValidpath ()
        {
            if (System.IO.File.Exists(path))
            {
                return "exist";         
            } else
            {
                return "nexist";
            }
        }
        
        //Checking if logfile contain string of FingerPrint
        public string GetValidLine ()
        {
            using (System.IO.FileStream fs = File.OpenRead(path))
            {
                foreach (string line in File.ReadLines(path))
                {
                    numberOfline++;
                    if (line.Contains(keyWord))
                    {
                        Console.WriteLine(line);
                        foundLine = numberOfline;
                    }
                    if ((foundLine != 0) && (numberOfline > foundLine))
                    {
                        Console.WriteLine(line);
                        foundedkey = line;
                        return foundedkey;
                    }

                }
            }
            return "Line did not containt correct pattern";
        }
        public int GetLengthOfFingerPrint(string exampleFP) {
            int lengthOfFingerPrint = exampleFP.Length;
            return lengthOfFingerPrint;
        }
        public string GetFingerPrint(string foundedkey)
        {
            List<string> charFP = new List<string>();          
            string currentChar = foundedkey.Substring(foundedkey.Length - 47);
            return currentChar;
        }




    }
}
