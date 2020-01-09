using System;
using System.Collections.Generic;
using System.Text;

namespace ClaimImportTool
{
    public interface IImportProcess
    {
        void SaveClaim(ILogger Logger, Claim Claim);
    }
}
