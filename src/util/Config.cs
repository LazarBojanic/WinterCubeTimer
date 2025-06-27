
using System.Text;
using System.Text.Json.Serialization;

namespace WinterCubeTimer.util {
    public class Config {
        private static Config? instance {  get; set; }
        [JsonPropertyName("inspection_enabled")]
        public bool inspectionEnabled { get; set; }
        public Config() {
            
        }

        public static Config initConfig() {
            if (!File.Exists(Util.CONFIG_FILE_NAME)) {
                File.WriteAllText(Util.CONFIG_FILE_NAME, Util.DEFAULT_CONFIG_JSON, Encoding.UTF8);
            }
            string configJson = File.ReadAllText(Util.CONFIG_FILE_NAME, Encoding.UTF8);
            return Util.deserialize<Config>(configJson);
        }
        public static Config getInstance() {
            if (instance == null) {
                instance = initConfig();
            }
            return instance;
        }
        public void save() {
            string configJson = Util.serialize(this);
            File.WriteAllText(Util.CONFIG_FILE_NAME, configJson, System.Text.Encoding.UTF8);
        }
    }

}

