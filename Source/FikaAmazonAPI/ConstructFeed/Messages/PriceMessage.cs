﻿using System;
using System.Collections.Generic;
using System.Text;

namespace FikaAmazonAPI.ConstructFeed.Messages
{
    public class PriceMessage
    {
        public string SKU { get; set; }

        public StandardPrice StandardPrice { get; set; }
    }
}
