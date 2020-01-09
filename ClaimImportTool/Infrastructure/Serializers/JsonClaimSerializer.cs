using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System;
using System.Collections.Generic;
using System.Text;

namespace ClaimImportTool
{
    public class JsonClaimSerializer : IClaimSerializer
    {
        public IEnumerable<ClaimDTO> GetClaimFromString(string claimString)
                => JsonConvert.DeserializeObject<IEnumerable<ClaimDTO>>(claimString, 
                    new StringEnumConverter());
        
    }
}
