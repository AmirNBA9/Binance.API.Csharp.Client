﻿using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinanceClient.Models.Market.TradingRules
{
   public class RateLimit
    {
        [JsonProperty("rateLimitType")]
        public string RateLimitType { get; set; }
        [JsonProperty("interval")]
        public string Interval { get; set; }
        [JsonProperty("limit")]
        public int Limit { get; set; }
    }
}
