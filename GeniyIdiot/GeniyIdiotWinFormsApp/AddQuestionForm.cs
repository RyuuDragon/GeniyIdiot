using GeniyIdiot.Common;

namespace GeniyIdiotWinFormsApp
{
    public partial class AddQuestionForm : Form
    {
        private List<Question> questions = QuestionsStorage.GetAll();
        private Question question;
        private readonly User user;
        private int questionNumber;
        private Point lastPoint;

        public AddQuestionForm(User user)
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

        private void AddQuestionForm_Load(object sender, EventArgs e)
        {
            questionNumber = 1;

            foreach (var question in questions)
            {
                listQuestionsBox.Items.Add($"{questionNumber}. {question.Text}");
                questionNumber++;
            }
        }

        private void addQuestionButton_Click(object sender, EventArgs e)
        {
            var message = string.Empty;
            var questionText = string.Empty;

            var isValidQuestion = Validator.IsValidQuestion(userQuestionTextBox.Text, out message);
            if (!isValidQuestion)
            {
                MessageBox.Show(message);
                return;
            }
            else
            {
                questionText = userQuestionTextBox.Text;
            }

            var input = userAnswerTextBox.Text;
            if (!int.TryParse(input, out int questionAnswer))
            {
                MessageBox.Show("Пожалуйста, введите число!!!");
                return;
            }

            bool questionExists = questions.Any(q => q.Text == questionText);
            if (!questionExists)
            {
                question = new Question(questionText, questionAnswer);
            }
            else
            {
                MessageBox.Show("Такой вопрос уже существует. Пожалуйста введите вопрос снова");
                return;
            }

            QuestionsStorage.Add(question);
            MessageBox.Show("Вопрос добавлен!");
            listQuestionsBox.Items.Add($"{questionNumber++}. {questionText}");

            userQuestionTextBox.Text = string.Empty;
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
