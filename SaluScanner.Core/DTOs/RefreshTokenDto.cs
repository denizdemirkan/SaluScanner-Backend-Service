﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SaluScanner.Core.DTOs
{
    public class RefreshTokenDto : IDto
    {
        public string RefreshToken { get; set; }
    }
}
