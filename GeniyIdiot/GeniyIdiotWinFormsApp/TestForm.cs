using GeniyIdiot.Common;

namespace GeniyIdiotWinFormsApp
{
    public partial class TestForm : Form
    {
        private List<Question> questions = QuestionsStorage.GetAll();
        private Question currentQuestion;
        private readonly User user;
        private int questionNumber = 1;
        private int correctAnswersCount = 0;
        private Point lastPoint;
        private int haveSeconds = 10;

        public TestForm(User user)
        {
            InitializeComponent();

            this.user = user;
        }

        private void exitLabel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void exitLabel_MouseEnter(object sender, EventArgs e)
        {
            exitLabel.ForeColor = Color.ForestGreen;
        }

        private void exitLabel_MouseLeave(object sender, EventArgs e)
        {
            exitLabel.ForeColor = Color.White;
        }

        private void mainPanel_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                int x = e.X - lastPoint.X;
                int y = e.Y - lastPoint.Y;

                this.Left += x;
                this.Top += y;
            }
        }

        private void mainPanel_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = e.Location;
        }

        private void testForm_Load(object sender, EventArgs e)
        {
            var warning = "На ответ дается 10 секунд." +
                " По окончании таймера ответ будет засчитан неверным и выведется следующий вопрос";
            MessageBox.Show(warning);

            ShowQuestion();
        }

        private void ShowQuestion()
        {
            timer.Stop();
            haveSeconds = 10;
            timerLabel.Text = haveSeconds.ToString();

            var random = new Random();

            var randomQuestionIndex = random.Next(0, questions.Count);
            currentQuestion = questions[randomQuestionIndex];

            questionTextLabel.Text = currentQuestion.Text;
            questionNumberLabel.Text = "Вопрос номер " + questionNumber;

            timer.Start();
        }

        private void nextQuestionButton_Click(object sender, EventArgs e)
        {
            var input = userAnswerTextBox.Text;
            if (!int.TryParse(input, out int userAnswer))
            {
                MessageBox.Show("Пожалуйста, введите число!!!");
                return;
            }

            var correctAnswer = currentQuestion.Answer;
            if (userAnswer == correctAnswer)
            {
                correctAnswersCount++;
            }

            questionNumber++;

            questions.Remove(currentQuestion);


            var endGame = questions.Count == 0;
            if (endGame)
            {
                timer.Stop();

                ShowResult();
                return;
            }

            userAnswerTextBox.Text = string.Empty;

            ShowQuestion();
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            haveSeconds--;
            timerLabel.Text = haveSeconds.ToString();

            if (haveSeconds == 0)
            {
                questionNumber++;

                questions.Remove(currentQuestion);

                userAnswerTextBox.Text = string.Empty;

                var endGame = questions.Count == 0;
                if (endGame)
                {
                    timer.Stop();

                    ShowResult();
                    return;
                }

                ShowQuestion();
            }
        }

        private void ShowResult()
        {
            var diagnosis = DiagnosesStorage.GetDiagnosisAssessment(correctAnswersCount, questionNumber);

            var testResults = new string[] { user.Name, correctAnswersCount.ToString(), diagnosis.Text };

            UsersResultStorage.Append(testResults);

            this.Hide();
            var resultsForm = new ResultsForm(diagnosis, user);
            resultsForm.Show();
        }
    }
}
