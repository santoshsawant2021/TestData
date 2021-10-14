using System;
using System.Linq;

namespace FileData
{
    public static class Program
    {
        public static void Main(string[] args)
        {
            AssemblyInformation assemblyInformation = new AssemblyInformation();
            if (args.Length == 0)
            {
                Console.WriteLine("Invalid argument");
                Console.ReadLine();
                return;
            }
            try
            {
                if (AssemblyInfo.AsseblyVersion.Contains(args[0]))
                {
                    Console.WriteLine(assemblyInformation.Version(args));
                }
                else
                {
                    Console.WriteLine(assemblyInformation.Size(args[0]));
                }

            }
            catch (InvalidArgumentException ex)
            {
                Console.WriteLine(ex.Message);
            }
            Console.ReadLine();
        }

    }
}
