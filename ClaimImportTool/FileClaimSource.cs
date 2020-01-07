using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace ClaimImportTool
{
    class FileClaimSource : IClaimsSource
    {
        public string GetClaimsFromSource()=> File.ReadAllText("ClaimsSource.json");
    }
}
