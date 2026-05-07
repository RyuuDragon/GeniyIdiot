using GeniyIdiot.Common;

namespace GeniyIdiotWinFormsApp
{
    public partial class MainForm : Form
    {
        private readonly User user;
        private Point lastPoint;
        private readonly QuestionsStorage questionStorage = new QuestionsStorage();

        public MainForm(User user)
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

        private void mainForm_Load(object sender, EventArgs e)
        {
            headLabel.Text = "Здравствуйте, " + user.Name;
        }

        private void firstCommandButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            var testForm = new TestForm(user);
            testForm.Show();
        }

        private void secondCommandButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            var addQuestionForm = new AddQuestionForm(user);
            addQuestionForm.Show();
        }

        private void thirdCommandButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            var deleteQuestionForm = new DeleteQuestionForm(user);
            deleteQuestionForm.Show();
        }

        private void showResultsButton_Click(object sender, EventArgs e)
        {
            if (UsersResultStorage.IsEmpty())
            {
                MessageBox.Show("Никто еще не прошел тест!");
                return;
            }

            this.Hide();
            var usersResultsForm = new UsersResultsForm(user);
            usersResultsForm.Show();
        }
    }
}
