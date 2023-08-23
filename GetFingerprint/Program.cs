using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace GetFingerprint
{
    internal class Program
    {
        //Description: This application connect to server or device and return current Fingerprintkey
        
        static void Main(string[] args)
        {
            ProcessStartInfo startinfo = new ProcessStartInfo();
            // This code call putty and for automaton solution we use plink. This is same apllication
            startinfo.FileName = @"C:\Program Files\PuTTY\plink.exe";
            // Configuration of plink
            startinfo.Arguments = "-batch"+" "+"-no-antispoof"+" "+"-sshrawlog"+" "+ "C:\\TestAutZaloha\\swupApps\\IVI_delete_files\\log.txt" + " "+"-ssh"+" "+"root@192.168.1.4";
            Process process = new Process();
            process.StartInfo = startinfo;
            process.StartInfo.UseShellExecute = false;
            process.StartInfo.RedirectStandardInput = true;
            process.Start();
            process.StandardInput.WriteLine("exit");
            process.WaitForExit();
            //Console.ReadKey();
            Thread.Sleep(5000);
            process.CloseMainWindow();
            process.Close();
        }
    }
}
