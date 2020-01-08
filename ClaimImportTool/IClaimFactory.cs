using System;
using System.Collections.Generic;
using System.Text;

namespace ClaimImportTool
{
    public interface IClaimFactory
    {
        void ClaimProcessor(IEnumerable<Claim> ListOfClaims);
    }
}
