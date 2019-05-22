using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace LiamRussell.Data {
    [JsonConverter(typeof(StringEnumConverter))]
    public enum Proficiency {
        Learning,
        Familiar,
        Proficient
    }
}
