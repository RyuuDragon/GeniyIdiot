using Newtonsoft.Json;
using System.Data;

namespace GeniyIdiot.Common
{
    public class UsersResultStorage
    {
        private const string Path = "testsResult.json";

        public static void Append(string[] results)
        {
            var userResults = GetAll();
            userResults.Add(results);
            Save(userResults);
        }

        public static void Save(List<string[]> results)
        {
            var data = JsonConvert.SerializeObject(results, Formatting.Indented);
            FileManager.SaveAll(Path, data);
        }

        public static List<string[]> GetAll()
        {
            if (IsEmpty())
            {
                return new List<string[]>();
            }

            var data = FileManager.Load(Path);
            var usersResults = JsonConvert.DeserializeObject<List<string[]>>(data);
            return usersResults;
        }

        public static bool IsEmpty()
        {
            var info = FileManager.Info(Path);
            if (!info.Exists || info.Length == 0)
            {
                return true;
            }

            return false;
        }
    }
}
