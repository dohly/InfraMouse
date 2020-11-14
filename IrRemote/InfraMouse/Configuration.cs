using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System;
using System.Collections.Generic;
using System.IO;

namespace InfraMouse
{
    [JsonConverter(typeof(StringEnumConverter))]
    public enum ActionType
    {
        MouseUp,
        MouseDown,
        MouseLeft,
        MouseRight
    }
    public class Configuration : Dictionary<ActionType, List<string>>
    {
        private const string filename = "config.json";

        public void Save()
        {
            File.WriteAllText(filename, JsonConvert.SerializeObject(this));
        }
        public static Configuration Load()
        {
            try
            {
                return JsonConvert.DeserializeObject<Configuration>(File.ReadAllText(filename));
            }
            catch
            {
                var cfg = new Configuration();
                foreach (ActionType action in Enum.GetValues(typeof(ActionType)))
                {
                    cfg.Add(action, new List<string>());
                }
                return cfg;
            }
        }

        public static string GetActionName(ActionType actionType)=> actionType switch { }
    }
}
