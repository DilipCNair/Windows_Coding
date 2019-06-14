using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tasklist
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                ProcessStartInfo info = new ProcessStartInfo(@"tasklist.exe");
                Process process = new Process();
                process.StartInfo = info;
                process.StartInfo.UseShellExecute = false;
                process.StartInfo.RedirectStandardOutput = true;
                string output = "";
                process.Start();
                while (!process.HasExited)
                {
                    output += process.StandardOutput.ReadToEnd();
                }
                Console.WriteLine(output);
                Console.Read();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }

        }
    }
}
