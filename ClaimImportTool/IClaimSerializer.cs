using System;
using System.Collections.Generic;
using System.Text;

namespace ClaimImportTool
{
    public interface IClaimSerializer
    {
        IEnumerable<Claim> GetClaimFromString(string claimString);
    }
}
