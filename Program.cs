using System.Diagnostics;

namespace RemoteMultiMon
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Process.Start(@"C:\Windows\system32\mstsc.exe", $"/multimon {string.Join(' ', args)}");
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
