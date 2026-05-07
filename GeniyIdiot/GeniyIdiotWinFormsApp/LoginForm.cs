using GeniyIdiot.Common;

namespace GeniyIdiotWinFormsApp
{
    public partial class LoginForm : Form
    {
        private Point lastPoint;

        public LoginForm()
        {
            InitializeComponent();
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

        private void nextButton_Click(object sender, EventArgs e)
        {
            var message = string.Empty;

            if (!Validator.IsValidName(userNameTextBox.Text, out message))
            {
                MessageBox.Show(message);
                return;
            }

            var user = new User(userNameTextBox.Text);

            this.Hide();
            var mainForm = new MainForm(user);
            mainForm.Show();
        }
    }
}
