namespace GeniyIdiot.Common
{
    public class FileManager
    {
        public static FileInfo Info(string path)
        {
            FileInfo fileInfo = new FileInfo(path);

            return fileInfo;
        }

        public static void SaveLine(string path, string data)
        {
            using (var writer = new StreamWriter(path, true))
            {
                writer.WriteLine(data);
            }
        }

        public static void SaveAll(string path, string data)
        {
            using (var writer = new StreamWriter(path, false))
            {
                writer.WriteLine(data);
            }
        }

        public static void DeleteLine(string path, int index)
        {
            var lines = File.ReadAllLines(path).ToList();

            lines.RemoveAt(index);

            File.WriteAllLines(path, lines);
        }

        public static string Load(string path)
        {
            using var reader = new StreamReader(path);
            var data = reader.ReadToEnd();
            return data;
        }
    }
}
