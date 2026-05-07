namespace GeniyIdiot.Common
{
    public class Question
    {
        public string Text { get; set; }
        public int Answer { get; set; }

        public Question(string question, int answer)
        {
            Text = question;
            Answer = answer;
        }
    }
}
