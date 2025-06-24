using WinterCubeTimer.util;
using System.Reflection;

public class Config {
    public string timesConnectionString {  get; set; }
    public bool inspectionEnabled { get; set; }
    public string cubeStateFileName { get; set; }
    public string cubeSolutionFileName { get; set; }
    private static Config instance {  get; set; }
    public static string configFileName = "config.json";
    public static string defaultConfigJson = @"{
                          ""timesConnectionString"": ""Data Source=times.db"",
                          ""inspectionEnabled"": true,
                          ""cubeStateFileName"": ""cubeState.json"",
                          ""cubeSolutionFileName"": ""cubeSolution.txt""
                        }
                        ";
    public Config() {
        
    }
    public static Config initConfig() {
        if (!File.Exists(configFileName)) {
            File.WriteAllText(configFileName, defaultConfigJson);
        }
        string configJson = File.ReadAllText(configFileName, System.Text.Encoding.UTF8);
        return Serializer.deserialize<Config>(configJson);
    }
    public Config(string timesConnectionString, bool inspectionEnabled, string cubeStateFileName, string cubeSolutionFileName) {
        this.timesConnectionString = timesConnectionString;
        this.inspectionEnabled = inspectionEnabled;
        this.cubeStateFileName = cubeStateFileName;
        this.cubeSolutionFileName = cubeSolutionFileName;
    }
    public static Config getInstance() {
        if (instance == null) {
            instance = initConfig();
        }
        return instance;
    }
    public void save() {
        string configJson = Serializer.serialize(this);
        File.WriteAllText(configFileName, configJson, System.Text.Encoding.UTF8);
    }
}
