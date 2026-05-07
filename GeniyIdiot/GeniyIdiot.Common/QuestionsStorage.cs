using Newtonsoft.Json;

namespace GeniyIdiot.Common
{
    public class QuestionsStorage
    {
        private const string Path = "questions.json";
        private static List<Question> questions = new List<Question>()
        {
            new Question("Сколько будет два плюс два умноженное на два?", 6),
            new Question("Бревно нужно распилить на 10 частей, сколько надо сделать распилов?", 9),
            new Question("На двух руках 10 пальцев. Сколько пальцев на 5 руках?", 25),
            new Question("Укол делают каждые полчаса, сколько нужно минут для трех уколов?", 60),
            new Question("Пять свечей горело, две потухли. Сколько свечей осталось?", 2)
        };

        public QuestionsStorage()
        {
            if (IsEmpty())
            {
                SaveAll(questions);
            }
        }

        private static void SaveAll(List<Question> questions)
        {
            var json = JsonConvert.SerializeObject(questions, Formatting.Indented);
            FileManager.SaveAll(Path, json);
        }

        public static List<Question> GetAll()
        {
            if (IsEmpty())
            {
                return new List<Question>();
            }

            var data = FileManager.Load(Path);
            var jsonQquestions = JsonConvert.DeserializeObject<List<Question>>(data);
            return jsonQquestions;
        }

        public static void Add(Question question)
        {
            questions = GetAll();
            questions.Add(question);
            SaveAll(questions);
        }

        public static void Delete(int index)
        {
            var questions = GetAll();
            questions.RemoveAt(index);
            SaveAll(questions);
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
