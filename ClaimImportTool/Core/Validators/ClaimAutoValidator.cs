﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace ClaimImportTool
{
    public class ClaimAutoValidator : Validator
    {
        private static readonly string CtypeAutoPostfix = "-01";

        public ClaimAutoValidator(ILogger logger, ClaimDTO ClaimString) : base(logger, ClaimString)
        {
        }

        public override ClaimDTO Validate(ClaimDTO ClaimSource)
        {
            string value = Regex.Match(ClaimSource.Number, @"(.{3})\s*$").ToString();
            if (value != CtypeAutoPostfix) ClaimSource.Number += CtypeAutoPostfix;
            return ClaimSource;
        }
    }
}