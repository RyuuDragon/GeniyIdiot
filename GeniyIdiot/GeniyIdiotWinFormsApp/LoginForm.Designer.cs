namespace GeniyIdiotWinFormsApp
{
    partial class LoginForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            mainPanel = new Panel();
            nextButton = new Button();
            callNameLabel = new Label();
            userPictureBox = new PictureBox();
            userNameTextBox = new TextBox();
            headPanel = new Panel();
            exitLabel = new Label();
            headLabel = new Label();
            mainPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)userPictureBox).BeginInit();
            headPanel.SuspendLayout();
            SuspendLayout();
            // 
            // mainPanel
            // 
            mainPanel.BackColor = Color.ForestGreen;
            mainPanel.Controls.Add(nextButton);
            mainPanel.Controls.Add(callNameLabel);
            mainPanel.Controls.Add(userPictureBox);
            mainPanel.Controls.Add(userNameTextBox);
            mainPanel.Controls.Add(headPanel);
            mainPanel.Dock = DockStyle.Fill;
            mainPanel.Location = new Point(0, 0);
            mainPanel.Name = "mainPanel";
            mainPanel.Size = new Size(950, 650);
            mainPanel.TabIndex = 0;
            mainPanel.MouseDown += mainPanel_MouseDown;
            mainPanel.MouseMove += mainPanel_MouseMove;
            // 
            // nextButton
            // 
            nextButton.BackColor = Color.FromArgb(34, 34, 139);
            nextButton.Cursor = Cursors.Hand;
            nextButton.FlatAppearance.BorderSize = 0;
            nextButton.FlatAppearance.MouseDownBackColor = Color.Red;
            nextButton.FlatAppearance.MouseOverBackColor = Color.Maroon;
            nextButton.FlatStyle = FlatStyle.Flat;
            nextButton.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point, 0);
            nextButton.ForeColor = Color.White;
            nextButton.Location = new Point(347, 452);
            nextButton.Name = "nextButton";
            nextButton.Size = new Size(266, 118);
            nextButton.TabIndex = 4;
            nextButton.Text = "Далее";
            nextButton.UseVisualStyleBackColor = false;
            nextButton.Click += nextButton_Click;
            // 
            // callNameLabel
            // 
            callNameLabel.AutoSize = true;
            callNameLabel.Font = new Font("Comic Sans MS", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            callNameLabel.ForeColor = Color.White;
            callNameLabel.Location = new Point(128, 343);
            callNameLabel.Name = "callNameLabel";
            callNameLabel.Size = new Size(196, 39);
            callNameLabel.TabIndex = 3;
            callNameLabel.Text = "Введите имя:";
            // 
            // userPictureBox
            // 
            userPictureBox.Image = (Image)resources.GetObject("userPictureBox.Image");
            userPictureBox.Location = new Point(413, 204);
            userPictureBox.Name = "userPictureBox";
            userPictureBox.Size = new Size(131, 101);
            userPictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            userPictureBox.TabIndex = 2;
            userPictureBox.TabStop = false;
            // 
            // userNameTextBox
            // 
            userNameTextBox.Location = new Point(330, 351);
            userNameTextBox.Name = "userNameTextBox";
            userNameTextBox.Size = new Size(426, 31);
            userNameTextBox.TabIndex = 1;
            // 
            // headPanel
            // 
            headPanel.BackColor = Color.FromArgb(139, 34, 34);
            headPanel.Controls.Add(exitLabel);
            headPanel.Controls.Add(headLabel);
            headPanel.Dock = DockStyle.Top;
            headPanel.Location = new Point(0, 0);
            headPanel.Name = "headPanel";
            headPanel.Size = new Size(950, 150);
            headPanel.TabIndex = 0;
            // 
            // exitLabel
            // 
            exitLabel.AutoSize = true;
            exitLabel.Cursor = Cursors.Hand;
            exitLabel.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            exitLabel.ForeColor = Color.White;
            exitLabel.Location = new Point(909, 0);
            exitLabel.Name = "exitLabel";
            exitLabel.Size = new Size(41, 48);
            exitLabel.TabIndex = 1;
            exitLabel.Text = "Х";
            exitLabel.Click += exitLabel_Click;
            exitLabel.MouseEnter += exitLabel_MouseEnter;
            exitLabel.MouseLeave += exitLabel_MouseLeave;
            // 
            // headLabel
            // 
            headLabel.Dock = DockStyle.Fill;
            headLabel.Font = new Font("Comic Sans MS", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            headLabel.ForeColor = Color.White;
            headLabel.Location = new Point(0, 0);
            headLabel.Name = "headLabel";
            headLabel.Size = new Size(950, 150);
            headLabel.TabIndex = 0;
            headLabel.Text = "Авторизация";
            headLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(950, 650);
            Controls.Add(mainPanel);
            FormBorderStyle = FormBorderStyle.None;
            Name = "LoginForm";
            Text = "LoginForm";
            mainPanel.ResumeLayout(false);
            mainPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)userPictureBox).EndInit();
            headPanel.ResumeLayout(false);
            headPanel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel mainPanel;
        private Panel headPanel;
        private Label headLabel;
        private Label exitLabel;
        private TextBox userNameTextBox;
        private PictureBox userPictureBox;
        private Label callNameLabel;
        private Button nextButton;
    }
}
