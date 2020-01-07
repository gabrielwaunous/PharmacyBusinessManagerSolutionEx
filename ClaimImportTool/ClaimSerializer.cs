using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System;
using System.Collections.Generic;
using System.Text;

namespace ClaimImportTool
{
    class ClaimSerializer : IClaimSerializer
    {
        public IEnumerable<Claim> GetClaimFromString(string claimString)
        {
            return JsonConvert.DeserializeObject<IEnumerable<Claim>>(claimString, new StringEnumConverter());
        }
    }
}
