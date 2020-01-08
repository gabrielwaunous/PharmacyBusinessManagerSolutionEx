using System;
using System.Collections.Generic;
using System.Text;

namespace ClaimImportTool.Test
{
    public class FakeClaimSource : IClaimsSource
    {
        public string ClaimString { get; set; } = "";

        public string GetClaimsFromSource()
            => ClaimString;        
    }
}
