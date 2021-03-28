using BinanceClient.Models.Market;
using System.Collections.Generic;

namespace BinanceClient.Models.WebSocket
{
    public class DepthMessage
    {
        public string EventType { get; set; }
        public long EventTime { get; set; }
        public string Symbol { get; set; }
        public int UpdateId { get; set; }
        public IEnumerable<OrderBookOffer> Bids { get; set; }
        public IEnumerable<OrderBookOffer> Asks { get; set; }
    }
}
