using System.Collections.Generic;
using Xunit;

namespace ClaimImportTool.Test
{
    public class FileClaimSourceTest
    {
        [Fact]
        public void CheckClaimSourceTest()
        {
            FakeClaimSource ClaimSource = new FakeClaimSource();

            string ClaimStringSource = ClaimSource.GetClaimsFromSource();

            Assert.Equal("", ClaimStringSource);

        }


    }
}
