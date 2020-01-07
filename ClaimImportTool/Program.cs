using System;

namespace ClaimImportTool
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Pharmacy Business Manager Solution v0.1");
            Console.WriteLine("¡¡Starting Claim Import Tool flow!!");

            var engine = new ClaimEngine();
            engine.ImportProcess();

            Console.WriteLine("\n\n¡¡Ending Claim Import Tool flow!!");
        }
    }
}
