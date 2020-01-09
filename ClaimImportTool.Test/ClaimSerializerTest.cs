using System;
using System.Collections.Generic;
using Xunit;

namespace ClaimImportTool.Test
{
    public class ClaimSerializerTest
    {
        [Fact]
        public void ReturnsDefaultPolicyFromEmptyJsonStringArray()
        {
            string inputJson = "[{ }]";
            IClaimSerializer serializer = new JsonClaimSerializer();

            IEnumerable<ClaimDTO> result = serializer.GetClaimFromString(inputJson);

            ClaimDTO ExpectedOutput = new ClaimDTO();

            AssertClaimList(result, ExpectedOutput);

        }

        private void AssertClaimList(IEnumerable<ClaimDTO> result, ClaimDTO expectedOutput)
        {
            foreach (ClaimDTO Claim in result)
            {
                Assert.Equal(Claim.Number, expectedOutput.Number);
                Assert.Equal(Claim.Type, expectedOutput.Type);
                Assert.Equal(Claim.DOI, expectedOutput.DOI);
                Assert.Equal(Claim.Claimant, expectedOutput.Claimant);
            }
        }
        
        
    }
}
