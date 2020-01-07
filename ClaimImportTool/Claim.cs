using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace ClaimImportTool
{
    public class Claim
    {
        private static readonly string CtypeAutoPostfix = "-01";
        private static readonly string CtypeWCPrefix = "WC";

        public ClaimType Type { get; set; }
        public DateTime DOI { get; set; }
        public string Number { get; set; }
        public Claimant Claimant { get; set; }

        public void Validate()
        {
            ClaimTypeValidation();
            ClaimDOIValidation();

        }

        private void ClaimTypeValidation()
        {
            string value;

            switch (Type)
            {
                case ClaimType.WC:
                    value = Regex.Match(Number, @"^.{0,2}").ToString();
                    if (value != CtypeWCPrefix) Number = CtypeWCPrefix + Number;
                    break;
                case ClaimType.Auto:
                    value = Regex.Match(Number, @"(.{3})\s*$").ToString();
                    if (value != CtypeAutoPostfix) Number += CtypeAutoPostfix;
                    break;
                default:
                    break;
            }
        }

        private void ClaimDOIValidation() => DOI = DOI.AddMonths(-1);
        
    }
}


