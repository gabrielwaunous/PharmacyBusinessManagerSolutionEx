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
        private readonly ILogger _logger;
        private readonly IClaimsSource _claimSource;
        private readonly IClaimSerializer _claimSerializer;

        public ClaimEngine(
            ILogger logger,
            IClaimsSource claimSource,
            IClaimSerializer claimSerializer
            )
        {
            _logger = logger;
            _claimSource = claimSource;
            _claimSerializer = claimSerializer;
        }
        public void ImportProcess()
        {

            _logger.Log("Starting Import.");
            _logger.Log("Loading Claims.");

            string claimString = _claimSource.GetClaimsFromSource();

            IEnumerable<Claim> claimList = _claimSerializer.GetClaimFromString(claimString);

            _logger.Log("Claim Imported.");
            foreach (var Claim in claimList)
            {
                Claim.Validate();
                _logger.Log("Claim Number: "+ Claim.Number + " - Type: "+ Claim.Type + " - Date of Injury: "+ Claim.DOI.ToShortDateString() + " - Claimant: "+ Claim.Claimant.LastName + " " + Claim.Claimant.FirstName);
            }

            _logger.Log("Claim Reported.");
        }

    }
}
