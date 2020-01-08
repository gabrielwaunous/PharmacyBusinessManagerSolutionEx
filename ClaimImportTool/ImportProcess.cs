using System;
using System.Collections.Generic;
using System.Text;

namespace ClaimImportTool
{
    public class ImportProcess : IImportProcess
    {
        public void SaveClaim(ILogger Logger, Claim Claim)
        {
            Logger.Log("Claim Number: " + Claim.Number + " - Type: " + Claim.Type + " - Date of Injury: " + Claim.DOI.ToShortDateString() + " - Claimant: " + Claim.Claimant.LastName + " " + Claim.Claimant.FirstName);
        }
    }
}
