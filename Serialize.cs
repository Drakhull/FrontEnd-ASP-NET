using ModelsJava;

namespace ModelsJava
{
    using Newtonsoft.Json;

    public static class Serialize
    {
        public static string ToJson(this User self) => JsonConvert.SerializeObject(self, ModelsJava.Converter.Settings);
    }
}
