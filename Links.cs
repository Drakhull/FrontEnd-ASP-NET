namespace ModelsJava
{
    using Newtonsoft.Json;

    public partial class Links
    {
        [JsonProperty("Users List")]
        public UsersList UsersList { get; set; }
    }
}
