﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoreLayer.Utilities.Security.JWT
{
    public class TokenOptions
    {
        public string SecurityKey { get; set; }
        public string Issuer { get; set; }
        public string Audience { get; set; }
        public double AccessTokenExpiration { get; set; }
    }
}
