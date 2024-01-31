namespace ModelsJava
{
    using Newtonsoft.Json;

    public partial class PhoneNumber
    {
        [JsonProperty("phoneNumber")]
        [JsonConverter(typeof(ParseStringConverter))]
        public long PhoneNumberPhoneNumber { get; set; }

        [JsonProperty("phoneType")]
        public string PhoneType { get; set; }
    }
}
