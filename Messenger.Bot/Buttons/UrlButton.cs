﻿using Newtonsoft.Json;

namespace Messenger.Bot.Buttons
{
    public class UrlButton : IButton
    {
        public ButtonTypes ButtonType => ButtonTypes.UrlButton;

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }
    }
}
