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
                    Console.WriteLine(rdpFile);
                    var rdpContent = File.ReadAllText(rdpFile);
                    if (rdpContent.IndexOf("use multimon") < 0)
                    {
                        using (var sw = new StreamWriter(rdpFile, true))
                        {
                            sw.WriteLine("\r\nuse multimon:i:1\r\n");
                        }
                    }

                    Process.Start(@"C:\Windows\system32\mstsc.exe", $"{rdpFile}");
                }

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
