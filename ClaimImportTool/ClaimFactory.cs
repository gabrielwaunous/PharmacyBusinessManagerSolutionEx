using System;
using System.Collections.Generic;

namespace ClaimImportTool
{
    public class ClaimFactory : IClaimFactory
    {
        private readonly ILogger _logger;
        private readonly IImportProcess _importProcess;

        public ClaimFactory(ILogger Logger, IImportProcess ImportProcess)
        {
            _logger = Logger;
            _importProcess = ImportProcess;
        }

        public void ClaimProcessor(IEnumerable<ClaimDTO> ListOfClaims)
        {
            foreach (ClaimDTO ClaimString in ListOfClaims)
            {
                Validator Claim = Create(ClaimString);

                _importProcess.SaveClaim(_logger, Claim.Claim);
            }
        }

        public Validator Create(ClaimDTO ClaimString)
        {
            try
            {
                return (Validator)Activator.CreateInstance(
                    Type.GetType($"ClaimImportTool.Claim{ClaimString.Type}Validator"),
                    new object[] { _logger, ClaimString });
            }
            catch (Exception)
            {

                return new UnKnownClaimType(_logger, ClaimString);
            }
        }
    }
}
