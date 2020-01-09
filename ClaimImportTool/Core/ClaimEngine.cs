using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace ClaimImportTool
{
    public class ClaimEngine
    {
        private readonly ILogger _logger;
        private readonly IClaimsSource _claimSource;
        private readonly IClaimSerializer _claimSerializer;
        private readonly IClaimFactory _claimFactory;

        public ClaimEngine(
            ILogger logger,
            IClaimsSource claimSource,
            IClaimSerializer claimSerializer,
            IClaimFactory claimFactory
            )
        {
            _logger = logger;
            _claimSource = claimSource;
            _claimSerializer = claimSerializer;
            _claimFactory = claimFactory;
        }
        public void ImportProcess()
        {
            _logger.Log("Starting Import.");
            _logger.Log("Loading Claims.");

            string claimString = _claimSource.GetClaimsFromSource();

            IEnumerable<ClaimDTO> claimList = _claimSerializer.GetClaimFromString(claimString);

            _logger.Log("Claim Imported.");

            _claimFactory.ClaimProcessor(claimList);

            _logger.Log("Claim Reported.");
        }

    }
}
