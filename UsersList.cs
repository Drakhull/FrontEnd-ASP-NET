namespace ModelsJava
{
    using System;
    using Newtonsoft.Json;

    public partial class UsersList
    {
        [JsonProperty("href")]
        public Uri Href { get; set; }
    }
}
