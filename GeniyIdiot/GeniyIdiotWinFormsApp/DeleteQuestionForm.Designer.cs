namespace GeniyIdiotWinFormsApp
{
    partial class DeleteQuestionForm
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
            mainPanel = new Panel();
            startTestButton = new Button();
            comeMainFormButton = new Button();
            listQuestionsLabel = new Label();
            listQuestionsBox = new ListBox();
            userAnswerTextBox = new TextBox();
            exitLabel = new Label();
            callAnswerLabel = new Label();
            deleteQuestionButton = new Button();
            mainPanel.SuspendLayout();
            SuspendLayout();
            // 
            // mainPanel
            // 
            mainPanel.BackColor = Color.ForestGreen;
            mainPanel.Controls.Add(startTestButton);
            mainPanel.Controls.Add(comeMainFormButton);
            mainPanel.Controls.Add(listQuestionsLabel);
            mainPanel.Controls.Add(listQuestionsBox);
            mainPanel.Controls.Add(userAnswerTextBox);
            mainPanel.Controls.Add(exitLabel);
            mainPanel.Controls.Add(callAnswerLabel);
            mainPanel.Controls.Add(deleteQuestionButton);
            mainPanel.Dock = DockStyle.Fill;
            mainPanel.Location = new Point(0, 0);
            mainPanel.Name = "mainPanel";
            mainPanel.Size = new Size(1456, 745);
            mainPanel.TabIndex = 4;
            mainPanel.MouseDown += mainPanel_MouseDown;
            mainPanel.MouseMove += mainPanel_MouseMove;
            // 
            // startTestButton
            // 
            startTestButton.BackColor = Color.FromArgb(34, 34, 139);
            startTestButton.Cursor = Cursors.Hand;
            startTestButton.FlatAppearance.BorderSize = 0;
            startTestButton.FlatAppearance.MouseDownBackColor = Color.Red;
            startTestButton.FlatAppearance.MouseOverBackColor = Color.Maroon;
            startTestButton.FlatStyle = FlatStyle.Flat;
            startTestButton.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point, 0);
            startTestButton.ForeColor = Color.White;
            startTestButton.Location = new Point(472, 628);
            startTestButton.Name = "startTestButton";
            startTestButton.Size = new Size(328, 60);
            startTestButton.TabIndex = 15;
            startTestButton.Text = "Начать тест";
            startTestButton.UseVisualStyleBackColor = false;
            startTestButton.Click += startTestButton_Click;
            // 
            // comeMainFormButton
            // 
            comeMainFormButton.BackColor = Color.FromArgb(34, 34, 139);
            comeMainFormButton.Cursor = Cursors.Hand;
            comeMainFormButton.FlatAppearance.BorderSize = 0;
            comeMainFormButton.FlatAppearance.MouseDownBackColor = Color.Red;
            comeMainFormButton.FlatAppearance.MouseOverBackColor = Color.Maroon;
            comeMainFormButton.FlatStyle = FlatStyle.Flat;
            comeMainFormButton.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point, 0);
            comeMainFormButton.ForeColor = Color.White;
            comeMainFormButton.Location = new Point(848, 628);
            comeMainFormButton.Name = "comeMainFormButton";
            comeMainFormButton.Size = new Size(328, 60);
            comeMainFormButton.TabIndex = 14;
            comeMainFormButton.Text = "Главное меню";
            comeMainFormButton.UseVisualStyleBackColor = false;
            comeMainFormButton.Click += comeMainFormButton_Click;
            // 
            // listQuestionsLabel
            // 
            listQuestionsLabel.AutoSize = true;
            listQuestionsLabel.Font = new Font("Comic Sans MS", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            listQuestionsLabel.ForeColor = Color.White;
            listQuestionsLabel.Location = new Point(244, 18);
            listQuestionsLabel.Name = "listQuestionsLabel";
            listQuestionsLabel.Size = new Size(249, 39);
            listQuestionsLabel.TabIndex = 13;
            listQuestionsLabel.Text = "Список вопросов";
            // 
            // listQuestionsBox
            // 
            listQuestionsBox.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            listQuestionsBox.FormattingEnabled = true;
            listQuestionsBox.Location = new Point(244, 73);
            listQuestionsBox.Name = "listQuestionsBox";
            listQuestionsBox.Size = new Size(986, 340);
            listQuestionsBox.TabIndex = 12;
            // 
            // userAnswerTextBox
            // 
            userAnswerTextBox.Location = new Point(472, 461);
            userAnswerTextBox.Name = "userAnswerTextBox";
            userAnswerTextBox.Size = new Size(236, 31);
            userAnswerTextBox.TabIndex = 11;
            // 
            // exitLabel
            // 
            exitLabel.AutoSize = true;
            exitLabel.Cursor = Cursors.Hand;
            exitLabel.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            exitLabel.ForeColor = Color.White;
            exitLabel.Location = new Point(1420, 0);
            exitLabel.Name = "exitLabel";
            exitLabel.Size = new Size(41, 48);
            exitLabel.TabIndex = 10;
            exitLabel.Text = "Х";
            exitLabel.Click += exitLabel_Click;
            exitLabel.MouseEnter += exitLabel_MouseEnter;
            exitLabel.MouseLeave += exitLabel_MouseLeave;
            // 
            // callAnswerLabel
            // 
            callAnswerLabel.AutoSize = true;
            callAnswerLabel.Font = new Font("Comic Sans MS", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            callAnswerLabel.ForeColor = Color.White;
            callAnswerLabel.Location = new Point(120, 453);
            callAnswerLabel.Name = "callAnswerLabel";
            callAnswerLabel.Size = new Size(336, 39);
            callAnswerLabel.TabIndex = 7;
            callAnswerLabel.Text = "Введите номер вопроса";
            // 
            // deleteQuestionButton
            // 
            deleteQuestionButton.BackColor = Color.FromArgb(34, 34, 139);
            deleteQuestionButton.Cursor = Cursors.Hand;
            deleteQuestionButton.FlatAppearance.BorderSize = 0;
            deleteQuestionButton.FlatAppearance.MouseDownBackColor = Color.Red;
            deleteQuestionButton.FlatAppearance.MouseOverBackColor = Color.Maroon;
            deleteQuestionButton.FlatStyle = FlatStyle.Flat;
            deleteQuestionButton.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point, 0);
            deleteQuestionButton.ForeColor = Color.White;
            deleteQuestionButton.Location = new Point(651, 521);
            deleteQuestionButton.Name = "deleteQuestionButton";
            deleteQuestionButton.Size = new Size(328, 60);
            deleteQuestionButton.TabIndex = 5;
            deleteQuestionButton.Text = "Удалить вопрос";
            deleteQuestionButton.UseVisualStyleBackColor = false;
            deleteQuestionButton.Click += deleteQuestionButton_Click;
            // 
            // DeleteQuestionForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1456, 745);
            Controls.Add(mainPanel);
            FormBorderStyle = FormBorderStyle.None;
            Name = "DeleteQuestionForm";
            Text = "DeleteQuestionForm";
            Load += DeleteQuestionForm_Load;
            mainPanel.ResumeLayout(false);
            mainPanel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel mainPanel;
        private Button startTestButton;
        private Button comeMainFormButton;
        private Label listQuestionsLabel;
        private ListBox listQuestionsBox;
        private TextBox userAnswerTextBox;
        private Label exitLabel;
        private Label callAnswerLabel;
        private Button deleteQuestionButton;
    }
}