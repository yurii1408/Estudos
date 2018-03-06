using System;
using System.Diagnostics;

namespace Executando_comandoCMD
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("GBK:");
            string gbk = Console.ReadLine();
            Console.Write("ECO:");
            string eco = Console.ReadLine();
            Process process = new Process();
            process.StartInfo.FileName = "cmd";
            process.StartInfo.CreateNoWindow = true;
            process.StartInfo.RedirectStandardInput = true;
            process.StartInfo.RedirectStandardOutput = true;
            process.StartInfo.UseShellExecute = false;
            process.Start();
            //process.StandardInput.WriteLine(@"cd\");
            process.StandardInput.WriteLine(@"cd \Firebird\Firebird_2_5\bin");
            process.StandardInput.WriteLine(@"gbak -r -v -c -st t -se service_mgr "+gbk+" "+eco+" -user sysdba -pass masterkey");
            process.StandardInput.Flush();
            process.StandardInput.Close();
            process.WaitForExit();
            Console.WriteLine(process.StandardOutput.ReadToEnd());
            Console.ReadKey();

        }
    }
}
