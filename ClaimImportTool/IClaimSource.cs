using System;
using System.Collections.Generic;
using System.Text;

namespace ClaimImportTool
{
    public interface IClaimsSource
    {
        string GetClaimsFromSource();
    }
}
