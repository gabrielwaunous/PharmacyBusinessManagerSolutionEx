using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace ClaimImportTool
{
    public class ClaimEngine
    {
        public void ImportProcess()
        {

            Console.WriteLine("Starting Import.");
            Console.WriteLine("Loading Claims.");

            string claimSource = File.ReadAllText("ClaimsSource.json");

            IEnumerable<Claim> claimList = JsonConvert.DeserializeObject<IEnumerable<Claim>>(claimSource, new StringEnumConverter());

            Console.WriteLine("Claim Imported.");
            foreach (var Claim in claimList)
            {
                Claim.Validate();
                Console.WriteLine("Claim Number: {0} - Type: {1} - Date of Injury: {2} - Claimant: {3}", Claim.Number, Claim.Type, Claim.DOI.ToShortDateString(), Claim.Claimant.LastName + " " + Claim.Claimant.FirstName);
            }

            Console.WriteLine("Claim Reported.");



        }

    }
}
