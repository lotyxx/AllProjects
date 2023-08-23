using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using static System.Net.WebRequestMethods;
using System.IO;
using File = System.IO.File;

namespace StartSearchingFiles
{
    public class Program
    {
        static void Main(string[] args)
        {
            //Decription - general: This code checking if logfile contains current fingeprint after that take fingeprint from File and put this value into variable checkChar like argument of  startinfo.Arguments.
            //Decription - general: New process (instance) perform login into device with required arguments

            string fingerPrintline = @"C:\TestAutZaloha\swupApps\IVI_delete_files\log.txt";
            Iofile iofile = new Iofile(@"C:\TestAutZaloha\swupApps\IVI_delete_files\log.txt");

            //Get FingerPrintFrom file
            if ( (iofile.VerifyValidpath()) == "exist")
            {
                fingerPrintline = iofile.GetValidLine();     
            } else
            {
                Console.WriteLine("File missed. Please checked valid path of file");
            }

            //Get example Length of Fingerprint for counting real value of FingerPrint
            int lengthOfFP = iofile.GetLengthOfFingerPrint("d9:ee:7f:61:74:c1:c6:f2:b0:ac:80:bc:81:3b:72:4a");
            Console.WriteLine("lengthOfFP : {0}", lengthOfFP);

            //Get real string value of FingerPrint from logfile
            //iofile.GetFingerPrint(fingerPrintline);
            string checkChar = iofile.GetFingerPrint(fingerPrintline);
            Console.WriteLine("checkChar {0}", checkChar);

            //Delete log file
            File.Delete(@"C:\TestAutZaloha\swupApps\IVI_delete_files\log.txt");

            //Plink plink = new Plink(@"C:\Program Files\PuTTY\plink.exe");

            //Imput parameter -hoskey into PlinkCong
            ProcessStartInfo startinfo = new ProcessStartInfo();
            startinfo.FileName = @"C:\Program Files\PuTTY\plink.exe";
            startinfo.Arguments = "-batch" + " " + "-no-antispoof" + " " + "-hostkey" + " " + checkChar + " " + "-ssh" + " " + "root@192.168.1.4" + " " + "-m" + " " + "C:\\TestAutZaloha\\swupApps\\IVI_delete_files\\foundFiles.txt";
            Process process = new Process();
            process.StartInfo = startinfo;
            process.StartInfo.UseShellExecute = false;
            process.StartInfo.RedirectStandardInput = true;
            process.Start();
            //process.StandardInput.WriteLine("ls");
            process.WaitForExit();
            Thread.Sleep(1000);
            process.CloseMainWindow();
            process.Close();
            //Console.ReadKey();

        }
    }
}
