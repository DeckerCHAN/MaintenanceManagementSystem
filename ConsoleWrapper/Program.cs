using System;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;
using MMS.Core;

namespace MMS.ConsoleWrapper
{
    internal class Program
    {
        [STAThread]
        private static void Main(string[] args)
        {
            try
            {
                if (Process.GetProcessesByName("MMS").Length > 1)
                {
                    MessageBox.Show("MMS is running!", "Error!");
                    Environment.Exit(-1);
                }

                var e = Engine.GetEngine();
                e.Run();
            }
            catch (Exception ex)
            {
                var report =
                    new FileInfo(String.Format("crash-report-{0}.report",
                        DateTime.Now.ToString("yyyy-MM-dd_hh-mm-ss-tt")));
                File.WriteAllText(report.FullName, ex.ToString());
                Console.WriteLine("!!!CRASH!!!Encountered unhandled exception. System crashed!");
                Console.WriteLine("!!!CRASH!!!More detail at {0}", report.FullName);
            }
            finally
            {
                Console.WriteLine("Programme returned...Press any key to exit.");
                Console.ReadKey();
                Environment.Exit(0);
            }
        }
    }
}