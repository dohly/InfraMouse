using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace InfraMouse
{
    [JsonConverter(typeof(StringEnumConverter))]
    public enum ActionType
    {
        MouseUp,
        MouseDown,
        MouseLeft,
        MouseRight,
        MouseLeftClick,
        MouseRightClick
    }
}
