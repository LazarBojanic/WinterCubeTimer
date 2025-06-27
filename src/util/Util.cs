using WinterCubeTimer.model;
using System.Text.Json;

namespace WinterCubeTimer.util {
    public static class Util {
        public static readonly Random random = new ();
        public static readonly string[] turns = ["U", "R", "F", "D", "L", "B"];
        public static readonly Color COLOR_WHITE = Color.FromArgb(255, 255, 255);
        public static readonly Color COLOR_YELLOW = Color.FromArgb(255, 249, 46);
        public static readonly Color COLOR_ORANGE = Color.FromArgb(255, 119, 0);
        public static readonly Color COLOR_RED = Color.FromArgb(227, 7, 7);
        public static readonly Color COLOR_GREEN = Color.FromArgb(52, 196, 8);
        public static readonly Color COLOR_BLUE = Color.FromArgb(2, 91, 181);
        public const string SIDE_UP = "U";
        public const string SIDE_RIGHT = "R";
        public const string SIDE_FRONT = "F";
        public const string SIDE_DOWN = "D";
        public const string SIDE_LEFT = "L";
        public const string SIDE_BACK = "B";
        public const string TABLES_DIRECTORY = "Assets\\Kociemba\\Tables\\";
        public const string CUBE_STATE_FILENAME = "cubeState.json";
        public const string CUBE_SOLUTION_FILENAME = "cubeSolution.txt";
        public const string CONFIG_FILE_NAME = "config.json";
        public const string DATABASE_FILE_NAME = "times.db";
        public static string DATABASE_FILE_PATH = "config.json";
        public static string DATABASE_CONNECTION_STRING = "Data Source=times.db";
        public const string DEFAULT_CONFIG_JSON = "{ \"inspection_enabled\": true }";
        
        public static string serialize<T>(T obj) {
            return JsonSerializer.Serialize(obj);
        }
        public static T deserialize<T>(string json) {
            return JsonSerializer.Deserialize<T>(json);
        }
        public static DateTime dateTimeWithoutMilliseconds(DateTime date) {
            return new DateTime(date.Year, date.Month, date.Day, date.Hour, date.Minute, date.Second);
        }
        
        public static string listToString(List<SolveTime> times) {
            string listString = "";
            foreach (SolveTime time in times) {
                listString += time.solveTimeInMilliseconds + "\n";
            }
            return listString;
        }
        public static string turnSequenceListToString(List<string> scramble) {
            string scrambleString = "";
            foreach (string turn in scramble) {
                scrambleString += turn + " ";
            }
            return scrambleString.Trim();
        }
        public static List<string> turnSequenceToList(string scramble) {
            List<string> scrambleList = new List<string>();
            foreach (string turn in scramble.Split(" ")) {
                scrambleList.Add(turn);
            }
            return scrambleList;
        }
        public static string longMillisecondsToString(long elapsedMilliseconds) {
            string millisecondsString = "";
            string secondsString = "";
            string minutesString = "";
            int milliseconds = (int)elapsedMilliseconds % 1000 / 10;
            int seconds = (int)(elapsedMilliseconds / 1000) % 60;
            int minutes = (int)(elapsedMilliseconds / (1000 * 60) % 60);
            if (milliseconds < 10) {
                millisecondsString = "0" + milliseconds;
            }
            else {
                millisecondsString = milliseconds.ToString();
            }
            if (seconds < 10) {
                secondsString = "0" + seconds;
            }
            else {
                secondsString = seconds.ToString();
            }
            if (minutes < 10) {
                minutesString = "0" + minutes;
            }
            else {
                minutesString = minutes.ToString();
            }
            return minutesString + " : " + secondsString + " . " + millisecondsString;
        }
        public static string colorNameToSideName(string colorName) {
            return colorName switch {
                "W" => "U",
                "R" => "R",
                "G" => "F",
                "Y" => "D",
                "O" => "L",
                "B" => "B",
                _ => ""
            };
        }
    }
}