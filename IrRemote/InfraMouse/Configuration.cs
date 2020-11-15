using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;

namespace InfraMouse
{
    public class Configuration : Dictionary<ActionType, List<string>>
    {
        private const string filename = "config.json";

        public void Save() => File.WriteAllText(filename, JsonConvert.SerializeObject(this));
        private static Configuration _config;
        public static Configuration Current
        {
            get
            {
                if (_config == null)
                {
                    try
                    {
                        _config = JsonConvert.DeserializeObject<Configuration>(File.ReadAllText(filename));
                    }
                    catch
                    {
                        _config = new Configuration();                        
                    }
                    foreach (ActionType action in Enum.GetValues(typeof(ActionType)))
                    {
                        if (!_config.ContainsKey(action))
                        {
                            _config.Add(action, new List<string>());
                        }
                    }
                }
                return _config;
            }
        }
    }
}
