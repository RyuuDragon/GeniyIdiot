namespace GeniyIdiotWinFormsApp
{
    partial class AddQuestionForm
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
            userQuestionTextBox = new TextBox();
            addQuestionButton = new Button();
            callQuestionLabel = new Label();
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
            mainPanel.Controls.Add(userQuestionTextBox);
            mainPanel.Controls.Add(addQuestionButton);
            mainPanel.Controls.Add(callQuestionLabel);
            mainPanel.Dock = DockStyle.Fill;
            mainPanel.Location = new Point(0, 0);
            mainPanel.Name = "mainPanel";
            mainPanel.Size = new Size(1464, 753);
            mainPanel.TabIndex = 3;
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
            listQuestionsBox.Size = new Size(986, 284);
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
            callAnswerLabel.Location = new Point(108, 453);
            callAnswerLabel.Name = "callAnswerLabel";
            callAnswerLabel.Size = new Size(348, 39);
            callAnswerLabel.TabIndex = 7;
            callAnswerLabel.Text = "Введите ответ на вопрос";
            // 
            // userQuestionTextBox
            // 
            userQuestionTextBox.Location = new Point(472, 388);
            userQuestionTextBox.Name = "userQuestionTextBox";
            userQuestionTextBox.Size = new Size(899, 31);
            userQuestionTextBox.TabIndex = 6;
            // 
            // addQuestionButton
            // 
            addQuestionButton.BackColor = Color.FromArgb(34, 34, 139);
            addQuestionButton.Cursor = Cursors.Hand;
            addQuestionButton.FlatAppearance.BorderSize = 0;
            addQuestionButton.FlatAppearance.MouseDownBackColor = Color.Red;
            addQuestionButton.FlatAppearance.MouseOverBackColor = Color.Maroon;
            addQuestionButton.FlatStyle = FlatStyle.Flat;
            addQuestionButton.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point, 0);
            addQuestionButton.ForeColor = Color.White;
            addQuestionButton.Location = new Point(651, 521);
            addQuestionButton.Name = "addQuestionButton";
            addQuestionButton.Size = new Size(328, 60);
            addQuestionButton.TabIndex = 5;
            addQuestionButton.Text = "Добавить вопрос";
            addQuestionButton.UseVisualStyleBackColor = false;
            addQuestionButton.Click += addQuestionButton_Click;
            // 
            // callQuestionLabel
            // 
            callQuestionLabel.AutoSize = true;
            callQuestionLabel.Font = new Font("Comic Sans MS", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            callQuestionLabel.ForeColor = Color.White;
            callQuestionLabel.Location = new Point(226, 380);
            callQuestionLabel.Name = "callQuestionLabel";
            callQuestionLabel.Size = new Size(230, 39);
            callQuestionLabel.TabIndex = 3;
            callQuestionLabel.Text = "Введите вопрос";
            // 
            // AddQuestionForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1464, 753);
            Controls.Add(mainPanel);
            FormBorderStyle = FormBorderStyle.None;
            Name = "AddQuestionForm";
            Text = "AddQuestionForm";
            Load += AddQuestionForm_Load;
            mainPanel.ResumeLayout(false);
            mainPanel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel mainPanel;
        private Label callAnswerLabel;
        private TextBox userQuestionTextBox;
        private Button addQuestionButton;
        private Label callQuestionLabel;
        private Label exitLabel;
        private TextBox userAnswerTextBox;
        private ListBox listQuestionsBox;
        private Label listQuestionsLabel;
        private Button startTestButton;
        private Button comeMainFormButton;
    }
}