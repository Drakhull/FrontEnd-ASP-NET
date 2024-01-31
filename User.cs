using ModelsJava;

namespace ModelsJava
{
    using System;
    using Newtonsoft.Json;
    using QuickType;

    public partial class User
    {
        [JsonProperty("idUser")]
        public Guid IdUser { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("email")]
        public string Email { get; set; }

        [JsonProperty("password")]
        public string Password { get; set; }

        [JsonProperty("cpf")]
        public string Cpf { get; set; }

        [JsonProperty("profile")]
        public string Profile { get; set; }

        [JsonProperty("creationDate")]
        public string CreationDate { get; set; }

        [JsonProperty("updateDate")]
        public string UpdateDate { get; set; }

        [JsonProperty("birthDate")]
        public DateTimeOffset BirthDate { get; set; }

        [JsonProperty("address")]
        public Address Address { get; set; }

        [JsonProperty("phoneNumbers")]
        public PhoneNumber[] PhoneNumbers { get; set; }

        [JsonProperty("_links")]
        public Links Links { get; set; }
    }
}
