namespace GeniyIdiot.Common
{
    public class DiagnosesStorage
    {
        private static List<Diagnosis> diagnoses = new List<Diagnosis>()
        {
            new Diagnosis("идиот"),
            new Diagnosis("кретин"),
            new Diagnosis("дурак"),
            new Diagnosis("нормальный"),
            new Diagnosis("талант"),
            new Diagnosis("гений"),
        };

        public static List<Diagnosis> GetAll()
        {
            return diagnoses;
        }

        public static Diagnosis GetDiagnosisAssessment(int correctAnswerCount, int questionsCount)
        {
            var correctAnswerPercent = (double)correctAnswerCount / questionsCount * 100;

            if (correctAnswerPercent == 0)
            {
                return diagnoses[0];
            }

            if (correctAnswerPercent <= 20)
            {
                return diagnoses[1];
            }

            if (correctAnswerPercent <= 40)
            {
                return diagnoses[2];
            }

            if (correctAnswerPercent <= 60)
            {
                return diagnoses[3];
            }

            if (correctAnswerPercent <= 80)
            {
                return diagnoses[4];
            }

            return diagnoses[5];
        }
    }
}
