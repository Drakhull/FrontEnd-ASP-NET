//    using QuickType;

namespace QuickType
{
    using ModelsJava;
    using Newtonsoft.Json;

    public partial class Address
    {
        [JsonProperty("logradouro")]
        public string Logradouro { get; set; }

        [JsonProperty("complemento")]
        public string Complemento { get; set; }

        [JsonProperty("numero")]
        [JsonConverter(typeof(ParseStringConverter))]
        public long Numero { get; set; }

        [JsonProperty("cidade")]
        public string Cidade { get; set; }

        [JsonProperty("estado")]
        public string Estado { get; set; }

        [JsonProperty("pais")]
        public string Pais { get; set; }

        [JsonProperty("cep")]
        public string Cep { get; set; }
    }
}
