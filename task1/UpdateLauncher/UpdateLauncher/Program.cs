using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Diagnostics;
using System.IO;
using System.Threading;

namespace UpdateLauncher
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Args:");

                string oldFile = args[0];
                string newFile = args[1];

                Console.WriteLine(oldFile);
                Console.WriteLine(newFile);

                string process = oldFile.Replace(".exe", "");

                Console.WriteLine("Terminate process!");

                while (Process.GetProcessesByName(process).Length > 0)
                {
                    Process[] subProcesses = Process.GetProcessesByName(process);

                    for (int i = 0; i < subProcesses.Length; i++) {
                        subProcesses[i].Kill();
                    }

                    Thread.Sleep(300);
                }

                Console.WriteLine("Deleting...");

                if (File.Exists(oldFile)) {
                    File.Delete(oldFile); }

                File.Copy(newFile, oldFile);

                Console.WriteLine("Starting " + oldFile);

                Process.Start(oldFile);
            }
            catch (Exception error) {
                Console.WriteLine(error.Message);
            }

            Console.ReadKey();
        }
    }
}
