using System;

namespace ClaimImportTool
{
    class Program
    {
        static void Main(string[] args)
        {
            ILogger logger = new ConsoleLogger();

            logger.Log("Pharmacy Business Manager Solution v0.1");

            logger.Log("¡¡Starting Claim Import Tool flow!!");

            var engine = new ClaimEngine(
                logger, 
                new FileClaimSource(), 
                new ClaimSerializer()
            );

            engine.ImportProcess();

            logger.Log("\n\n¡¡Ending Claim Import Tool flow!!");
            Console.ReadLine();
        }
    }
}
