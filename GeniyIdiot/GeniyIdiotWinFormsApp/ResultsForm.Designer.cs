namespace GeniyIdiotWinFormsApp
{
    partial class ResultsForm
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
            exitLabel = new Label();
            disagreeButton = new Button();
            callAnswerLabel = new Label();
            agreeButton = new Button();
            diagnosisLabel = new Label();
            mainPanel.SuspendLayout();
            SuspendLayout();
            // 
            // mainPanel
            // 
            mainPanel.BackColor = Color.ForestGreen;
            mainPanel.Controls.Add(exitLabel);
            mainPanel.Controls.Add(disagreeButton);
            mainPanel.Controls.Add(callAnswerLabel);
            mainPanel.Controls.Add(agreeButton);
            mainPanel.Controls.Add(diagnosisLabel);
            mainPanel.Dock = DockStyle.Fill;
            mainPanel.Location = new Point(0, 0);
            mainPanel.Name = "mainPanel";
            mainPanel.Size = new Size(1027, 407);
            mainPanel.TabIndex = 3;
            mainPanel.MouseDown += mainPanel_MouseDown;
            mainPanel.MouseMove += mainPanel_MouseMove;
            // 
            // exitLabel
            // 
            exitLabel.AutoSize = true;
            exitLabel.Cursor = Cursors.Hand;
            exitLabel.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            exitLabel.ForeColor = Color.White;
            exitLabel.Location = new Point(986, 0);
            exitLabel.Name = "exitLabel";
            exitLabel.Size = new Size(41, 48);
            exitLabel.TabIndex = 9;
            exitLabel.Text = "Х";
            exitLabel.Click += exitLabel_Click;
            exitLabel.MouseEnter += exitLabel_MouseEnter;
            exitLabel.MouseLeave += exitLabel_MouseLeave;
            // 
            // disagreeButton
            // 
            disagreeButton.BackColor = Color.FromArgb(34, 34, 139);
            disagreeButton.Cursor = Cursors.Hand;
            disagreeButton.FlatAppearance.BorderSize = 0;
            disagreeButton.FlatAppearance.MouseDownBackColor = Color.Red;
            disagreeButton.FlatAppearance.MouseOverBackColor = Color.Maroon;
            disagreeButton.FlatStyle = FlatStyle.Flat;
            disagreeButton.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point, 0);
            disagreeButton.ForeColor = Color.White;
            disagreeButton.Location = new Point(549, 262);
            disagreeButton.Name = "disagreeButton";
            disagreeButton.Size = new Size(328, 60);
            disagreeButton.TabIndex = 8;
            disagreeButton.Text = "Нет";
            disagreeButton.UseVisualStyleBackColor = false;
            disagreeButton.Click += disagreeButton_Click;
            // 
            // callAnswerLabel
            // 
            callAnswerLabel.AutoSize = true;
            callAnswerLabel.Font = new Font("Comic Sans MS", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            callAnswerLabel.ForeColor = Color.White;
            callAnswerLabel.Location = new Point(274, 165);
            callAnswerLabel.Name = "callAnswerLabel";
            callAnswerLabel.Size = new Size(492, 51);
            callAnswerLabel.TabIndex = 7;
            callAnswerLabel.Text = "Хотите пройти тест снова?";
            // 
            // agreeButton
            // 
            agreeButton.BackColor = Color.FromArgb(34, 34, 139);
            agreeButton.Cursor = Cursors.Hand;
            agreeButton.FlatAppearance.BorderSize = 0;
            agreeButton.FlatAppearance.MouseDownBackColor = Color.Red;
            agreeButton.FlatAppearance.MouseOverBackColor = Color.Maroon;
            agreeButton.FlatStyle = FlatStyle.Flat;
            agreeButton.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point, 0);
            agreeButton.ForeColor = Color.White;
            agreeButton.Location = new Point(178, 262);
            agreeButton.Name = "agreeButton";
            agreeButton.Size = new Size(328, 60);
            agreeButton.TabIndex = 5;
            agreeButton.Text = "Да";
            agreeButton.UseVisualStyleBackColor = false;
            agreeButton.Click += agreeButton_Click;
            // 
            // diagnosisLabel
            // 
            diagnosisLabel.AutoSize = true;
            diagnosisLabel.Font = new Font("Comic Sans MS", 22F, FontStyle.Regular, GraphicsUnit.Point, 0);
            diagnosisLabel.ForeColor = Color.White;
            diagnosisLabel.Location = new Point(213, 63);
            diagnosisLabel.Name = "diagnosisLabel";
            diagnosisLabel.Size = new Size(293, 61);
            diagnosisLabel.TabIndex = 3;
            diagnosisLabel.Text = "Ваш диагноз";
            // 
            // ResultsForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1027, 407);
            Controls.Add(mainPanel);
            FormBorderStyle = FormBorderStyle.None;
            Name = "ResultsForm";
            Text = "ResultsForm";
            Load += ResultsForm_Load;
            mainPanel.ResumeLayout(false);
            mainPanel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel mainPanel;
        private Label callAnswerLabel;
        private Button agreeButton;
        private Label diagnosisLabel;
        private Button disagreeButton;
        private Label exitLabel;
    }
}