using Newtonsoft.Json;

namespace BinanceClient.Models.UserStream
{
    public class UserStreamInfo
    {
        [JsonProperty("listenKey")]
        public string ListenKey { get; set; }
    }
}
