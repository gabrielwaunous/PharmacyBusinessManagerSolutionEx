using System;
using System.Collections.Generic;
using System.Text;

namespace ClaimImportTool
{
    public class Claimant
    {
        public Claimant(Dictionary<string,string> ClaimantString)
        {
            FirstName = ClaimantString["FirstName"];
            LastName = ClaimantString["LastName"];

        }
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
}
