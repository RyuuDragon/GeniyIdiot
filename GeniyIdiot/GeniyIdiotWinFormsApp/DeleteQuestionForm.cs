using GeniyIdiot.Common;

namespace GeniyIdiotWinFormsApp
{
    public partial class DeleteQuestionForm : Form
    {
        private List<Question> questions = QuestionsStorage.GetAll();
        private readonly User user;
        private int questionNumber;
        private Point lastPoint;

        public DeleteQuestionForm(User user)
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
            exitLabel.ForeColor = Color.Red;
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

        private void DeleteQuestionForm_Load(object sender, EventArgs e)
        {
            questionNumber = 1;

            foreach (var question in questions)
            {
                listQuestionsBox.Items.Add($"{questionNumber}. {question.Text}");
                questionNumber++;
            }
        }

        private void deleteQuestionButton_Click(object sender, EventArgs e)
        {
            var questionsCount = questions.Count;

            var input = userAnswerTextBox.Text;
            if (!int.TryParse(input, out int questionIndex))
            {
                MessageBox.Show("Пожалуйста, введите число!!!");
                return;
            }

            if (questionIndex > questionsCount || questionIndex < 1)
            {
                MessageBox.Show("Такого вопроса не существует!");
                return;
            }

            if (questionsCount == 3)
            {
                MessageBox.Show("Должно остаться минимум 3 вопроса. Больше вопросов удалить нельзя!" +
                    "Выберите другую команду!");
                return;
            }

            QuestionsStorage.Delete(questionIndex - 1);
            MessageBox.Show("Вопрос удален!");
            listQuestionsBox.Items.RemoveAt(questionIndex - 1);

            userAnswerTextBox.Text = string.Empty;
        }

        private void startTestButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            var testForm = new TestForm(user);
            testForm.Show();
        }

        private void comeMainFormButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            var mainForm = new MainForm(user);
            mainForm.Show();
        }
    }
}
