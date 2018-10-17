using Newtonsoft.Json;

namespace Messenger.Bot.Webhook
{
    public struct Recipient
    {
        [JsonProperty("id")]
        public string Id { get; set; }
    }
}
