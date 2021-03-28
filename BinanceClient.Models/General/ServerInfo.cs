using Newtonsoft.Json;

namespace BinanceClient.Models.General
{
    public class ServerInfo
    {
        [JsonProperty("serverTIme")]
        public long ServerTime { get; set; }
    }
}
