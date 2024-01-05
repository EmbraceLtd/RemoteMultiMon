using System.Diagnostics;

namespace RemoteMultiMon
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                if (args.Count() > 0)
                {
                    var rdpFile = args[0];
                    Process.Start(@"C:\Windows\system32\mstsc.exe", $"/multimon {rdpFile}");
                }
                else
                    Process.Start(@"C:\Windows\system32\mstsc.exe", "/multimon");

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                Console.ReadLine();
                throw;
            }
        }
    }
}
