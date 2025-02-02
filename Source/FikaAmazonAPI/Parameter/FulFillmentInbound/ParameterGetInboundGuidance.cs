﻿using FikaAmazonAPI.Search;
using System;
using System.Collections.Generic;
using System.Text;

namespace FikaAmazonAPI.Parameter.FulFillmentInbound
{
    public class ParameterGetInboundGuidance : ParameterBased
    {
        public string MarketplaceId { get; set; }
        public IList<string> SellerSKUList { get; set; }
        public IList<string> ASINList { get; set; }
    }
}
