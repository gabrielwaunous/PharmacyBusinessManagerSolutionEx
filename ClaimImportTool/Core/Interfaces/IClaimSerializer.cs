using System;
using System.Collections.Generic;
using System.Text;

namespace ClaimImportTool
{
    public interface IClaimSerializer
    {
        IEnumerable<ClaimDTO> GetClaimFromString(string claimString);
    }
}
