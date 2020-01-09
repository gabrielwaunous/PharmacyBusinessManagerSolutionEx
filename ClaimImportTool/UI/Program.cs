using ClaimImportTool.Infrastructure.ClaimSource;
using ClaimImportTool.Infrastructure.Loggers;
using ClaimImportTool.Infrastructure.Serializers;
using System;

namespace ClaimImportTool
{
    class Program
    {
        static void Main(string[] args)
        {
            //ILogger logger = new ConsoleLogger();
            ILogger logger = new FileLogger();

            logger.Log("Pharmacy Business Manager Solution v0.1");

            logger.Log("¡¡Starting Claim Import Tool flow!!");

            var engine = new ClaimEngine(
                logger, 
                new JsonFileClaimSource(), 
                //new XmlFileClaimSource(), 
                new JsonClaimSerializer(),
                //new XmlClaimSerializer(),
                new ClaimFactory(logger, new ImportProcess())
            );

            engine.ImportProcess();

            logger.Log("\n\n¡¡Ending Claim Import Tool flow!!");
            //Console.ReadLine();
        }
    }
}

