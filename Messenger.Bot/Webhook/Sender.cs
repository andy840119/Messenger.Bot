using Newtonsoft.Json;

namespace Messenger.Bot.Webhook
{
    public struct Sender
    {
        [JsonProperty("id")]
        public string Id { get; set; }
    }
}
