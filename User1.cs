namespace ModelsJava
{
    using Newtonsoft.Json;

    public partial class User
    {
        public static User FromJson(string json) => JsonConvert.DeserializeObject<User>(json, ModelsJava.Converter.Settings);
    }
}
