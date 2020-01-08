using System;
using System.Collections.Generic;
using Xunit;

namespace ClaimImportTool.Test
{
    public class ClaimFactoryTest
    {
        private FakeLogger _logger;
        private string[] _expectedValues { get; set; }= {
            "Claim Number: WC159487 - Type: WC - Date of Injury: 12/19/2015 - Claimant: Data 1 Test",
            "Claim Number: 159487-01 - Type: Auto - Date of Injury: 12/19/2015 - Claimant: Data 2 Test",
            "UnKnown Claim Type",
            "Claim Number: 159487 - Type: UnKnown - Date of Injury: 12/19/2015 - Claimant: Data 3 Test" };

        public ClaimFactoryTest()
        {
            _logger = new FakeLogger();
        }

        [Fact]
        public void ClaimFactoryTestMethod()
        {
            var ClaimFactory = new ClaimFactory(_logger, new ImportProcess());

            ClaimFactory.ClaimProcessor(GetClaimList());

            CheckAsserts();
        }

        private void CheckAsserts()
        {
            int index = 0;
            foreach (var message in _logger.LoggedMessages)
            {
                Assert.Contains(_logger.LoggedMessages, m => m == _expectedValues[index]);
                index++;
            }
        }

        private IEnumerable<ClaimDTO> GetClaimList()
        {
            List<ClaimDTO> ListOfClaims = new List<ClaimDTO>();
            ListOfClaims.Add(new ClaimDTO {
                Type = "WC",
                DOI = "2016-01-20T00:00:00.000Z",
                Number = "159487",
                Claimant = new Dictionary<string,string>{ { "FirstName", "Test" }, { "LastName", "Data 1" } }

            });
            ListOfClaims.Add(new ClaimDTO
            {
                Type = "Auto",
                DOI = "2016-01-20T00:00:00.000Z",
                Number = "159487",
                Claimant = new Dictionary<string, string> { { "FirstName", "Test" }, { "LastName", "Data 2" } }

            });
            ListOfClaims.Add(new ClaimDTO
            {
                Type = "SomeType",
                DOI = "2016-01-20T00:00:00.000Z",
                Number = "159487",
                Claimant = new Dictionary<string, string> { { "FirstName", "Test" }, { "LastName", "Data 3" } }

            });

            return ListOfClaims;
        }
    }
}
