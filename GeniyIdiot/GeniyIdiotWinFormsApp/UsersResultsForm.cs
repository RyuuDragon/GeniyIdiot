using GeniyIdiot.Common;

namespace GeniyIdiotWinFormsApp
{
    public partial class UsersResultsForm : Form
    {
        private readonly User user;
        private Point lastPoint;

        public UsersResultsForm(User user)
        {
            InitializeComponent();

            resultsDataGridView.ReadOnly = true;

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

        private void UsersResultsForm_Load(object sender, EventArgs e)
        {
            var usersResultsStorage = UsersResultStorage.GetAll();
            foreach (var results in usersResultsStorage)
            {
                var user = results[0];
                var correctAnswersCount = results[1];
                var diagnosis = results[2];

                resultsDataGridView.Rows.Add(user, correctAnswersCount, diagnosis);
            }
        }

        private void comeMainFormButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            var mainForm = new MainForm(user);
            mainForm.Show();
        }
    }
}
