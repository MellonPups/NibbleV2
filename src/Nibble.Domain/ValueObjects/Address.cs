﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nibble.Domain.ValueObjects
{
    public class Address
    {
        public string FriendlyName { get; set; }
        public double Latitude { get; set; }
        public double Longitude { get; set; }

    }
}
