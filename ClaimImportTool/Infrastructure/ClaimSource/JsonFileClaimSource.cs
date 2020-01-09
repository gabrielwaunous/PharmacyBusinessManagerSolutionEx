using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace ClaimImportTool
{
    class JsonFileClaimSource : IClaimsSource
    {
        public string GetClaimsFromSource()=> File.ReadAllText("ClaimsSource.json");
    }
}
