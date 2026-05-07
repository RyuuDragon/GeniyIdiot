using GeniyIdiot.Common;

namespace GeniyIdiotWinFormsApp
{
    public partial class ResultsForm : Form
    {
        private readonly Diagnosis diagnosis;
        private readonly User user;
        private Point lastPoint;

        public ResultsForm(Diagnosis diagnosis, User user)
        {
            InitializeComponent();

            this.diagnosis = diagnosis;
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

        private void ResultsForm_Load(object sender, EventArgs e)
        {
            diagnosisLabel.Text = $"{user.Name}, Ваш диагноз - {diagnosis.Text}";
        }

        private void agreeButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            var testForm = new TestForm(user);
            testForm.Show();
        }

        private void disagreeButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            var mainForm = new MainForm(user);
            mainForm.Show();
        }
    }
}
