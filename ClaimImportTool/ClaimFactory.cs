using System;
using System.Collections.Generic;
using System.Text;

namespace ClaimImportTool
{
    class ClaimFactory : IClaimFactory
    {
        private readonly ILogger _logger;
        public ClaimFactory(ILogger Logger)
        {
            _logger = Logger;
        }
        public void ClaimProcessor(IEnumerable<Claim> ListOfClaims)
        {
            foreach (Claim Claim in ListOfClaims)
            {
                Claim.Validate();
                _logger.Log("Claim Number: " + Claim.Number + " - Type: " + Claim.Type + " - Date of Injury: " + Claim.DOI.ToShortDateString() + " - Claimant: " + Claim.Claimant.LastName + " " + Claim.Claimant.FirstName);
            }
        }

    }
}
