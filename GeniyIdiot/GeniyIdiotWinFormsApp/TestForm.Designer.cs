namespace GeniyIdiotWinFormsApp
{
    partial class TestForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            mainPanel = new Panel();
            timerLabel = new Label();
            callAnswerLabel = new Label();
            userAnswerTextBox = new TextBox();
            nextQuestionButton = new Button();
            questionTextLabel = new Label();
            headPanel = new Panel();
            exitLabel = new Label();
            questionNumberLabel = new Label();
            timer = new System.Windows.Forms.Timer(components);
            mainPanel.SuspendLayout();
            headPanel.SuspendLayout();
            SuspendLayout();
            // 
            // mainPanel
            // 
            mainPanel.BackColor = Color.ForestGreen;
            mainPanel.Controls.Add(timerLabel);
            mainPanel.Controls.Add(callAnswerLabel);
            mainPanel.Controls.Add(userAnswerTextBox);
            mainPanel.Controls.Add(nextQuestionButton);
            mainPanel.Controls.Add(questionTextLabel);
            mainPanel.Controls.Add(headPanel);
            mainPanel.Dock = DockStyle.Fill;
            mainPanel.Location = new Point(0, 0);
            mainPanel.Name = "mainPanel";
            mainPanel.Size = new Size(1245, 665);
            mainPanel.TabIndex = 2;
            mainPanel.MouseDown += mainPanel_MouseDown;
            mainPanel.MouseMove += mainPanel_MouseMove;
            // 
            // timerLabel
            // 
            timerLabel.Font = new Font("Comic Sans MS", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            timerLabel.ForeColor = Color.White;
            timerLabel.Location = new Point(559, 171);
            timerLabel.Name = "timerLabel";
            timerLabel.Size = new Size(119, 73);
            timerLabel.TabIndex = 8;
            timerLabel.Text = "Таймер";
            timerLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // callAnswerLabel
            // 
            callAnswerLabel.AutoSize = true;
            callAnswerLabel.Font = new Font("Comic Sans MS", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            callAnswerLabel.ForeColor = Color.White;
            callAnswerLabel.Location = new Point(263, 335);
            callAnswerLabel.Name = "callAnswerLabel";
            callAnswerLabel.Size = new Size(215, 39);
            callAnswerLabel.TabIndex = 7;
            callAnswerLabel.Text = "Введите ответ:";
            // 
            // userAnswerTextBox
            // 
            userAnswerTextBox.Location = new Point(496, 343);
            userAnswerTextBox.Name = "userAnswerTextBox";
            userAnswerTextBox.Size = new Size(253, 31);
            userAnswerTextBox.TabIndex = 6;
            // 
            // nextQuestionButton
            // 
            nextQuestionButton.BackColor = Color.FromArgb(34, 34, 139);
            nextQuestionButton.Cursor = Cursors.Hand;
            nextQuestionButton.FlatAppearance.BorderSize = 0;
            nextQuestionButton.FlatAppearance.MouseDownBackColor = Color.Red;
            nextQuestionButton.FlatAppearance.MouseOverBackColor = Color.Maroon;
            nextQuestionButton.FlatStyle = FlatStyle.Flat;
            nextQuestionButton.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point, 0);
            nextQuestionButton.ForeColor = Color.White;
            nextQuestionButton.Location = new Point(463, 444);
            nextQuestionButton.Name = "nextQuestionButton";
            nextQuestionButton.Size = new Size(328, 60);
            nextQuestionButton.TabIndex = 5;
            nextQuestionButton.Text = "Следующий вопрос";
            nextQuestionButton.UseVisualStyleBackColor = false;
            nextQuestionButton.Click += nextQuestionButton_Click;
            // 
            // questionTextLabel
            // 
            questionTextLabel.AutoSize = true;
            questionTextLabel.Font = new Font("Comic Sans MS", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            questionTextLabel.ForeColor = Color.White;
            questionTextLabel.Location = new Point(51, 249);
            questionTextLabel.Name = "questionTextLabel";
            questionTextLabel.Size = new Size(209, 39);
            questionTextLabel.TabIndex = 3;
            questionTextLabel.Text = "Текст вопроса";
            // 
            // headPanel
            // 
            headPanel.BackColor = Color.FromArgb(139, 34, 34);
            headPanel.Controls.Add(exitLabel);
            headPanel.Controls.Add(questionNumberLabel);
            headPanel.Dock = DockStyle.Top;
            headPanel.Location = new Point(0, 0);
            headPanel.Name = "headPanel";
            headPanel.Size = new Size(1245, 150);
            headPanel.TabIndex = 0;
            // 
            // exitLabel
            // 
            exitLabel.AutoSize = true;
            exitLabel.Cursor = Cursors.Hand;
            exitLabel.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            exitLabel.ForeColor = Color.White;
            exitLabel.Location = new Point(1204, 0);
            exitLabel.Name = "exitLabel";
            exitLabel.Size = new Size(41, 48);
            exitLabel.TabIndex = 1;
            exitLabel.Text = "Х";
            exitLabel.Click += exitLabel_Click;
            exitLabel.MouseEnter += exitLabel_MouseEnter;
            exitLabel.MouseLeave += exitLabel_MouseLeave;
            // 
            // questionNumberLabel
            // 
            questionNumberLabel.Dock = DockStyle.Fill;
            questionNumberLabel.Font = new Font("Comic Sans MS", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            questionNumberLabel.ForeColor = Color.White;
            questionNumberLabel.Location = new Point(0, 0);
            questionNumberLabel.Name = "questionNumberLabel";
            questionNumberLabel.Size = new Size(1245, 150);
            questionNumberLabel.TabIndex = 0;
            questionNumberLabel.Text = "Вопрос";
            questionNumberLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // timer
            // 
            timer.Interval = 1000;
            timer.Tick += timer_Tick;
            // 
            // TestForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1245, 665);
            Controls.Add(mainPanel);
            FormBorderStyle = FormBorderStyle.None;
            Name = "TestForm";
            Text = "TestForm";
            Load += testForm_Load;
            mainPanel.ResumeLayout(false);
            mainPanel.PerformLayout();
            headPanel.ResumeLayout(false);
            headPanel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel mainPanel;
        private Button nextQuestionButton;
        private Label questionTextLabel;
        private Panel headPanel;
        private Label exitLabel;
        private Label questionNumberLabel;
        private Label callAnswerLabel;
        private TextBox userAnswerTextBox;
        private Label timerLabel;
        private System.Windows.Forms.Timer timer;
    }
}