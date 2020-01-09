using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace ClaimImportTool.Infrastructure.ClaimSource
{
    public class XmlFileClaimSource : IClaimsSource
    {
            public string GetClaimsFromSource() => File.ReadAllText("ClaimSource.xml");       
    }
}
