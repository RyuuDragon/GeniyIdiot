namespace GeniyIdiotWinFormsApp
{
    partial class UsersResultsForm
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
            resultsDataGridView = new DataGridView();
            User = new DataGridViewTextBoxColumn();
            CorrectAnswersCount = new DataGridViewTextBoxColumn();
            Diagnosis = new DataGridViewTextBoxColumn();
            exitLabel = new Label();
            comeMainFormButton = new Button();
            resultsLabel = new Label();
            mainPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)resultsDataGridView).BeginInit();
            SuspendLayout();
            // 
            // mainPanel
            // 
            mainPanel.BackColor = Color.ForestGreen;
            mainPanel.Controls.Add(resultsDataGridView);
            mainPanel.Controls.Add(exitLabel);
            mainPanel.Controls.Add(comeMainFormButton);
            mainPanel.Controls.Add(resultsLabel);
            mainPanel.Dock = DockStyle.Fill;
            mainPanel.Location = new Point(0, 0);
            mainPanel.Name = "mainPanel";
            mainPanel.Size = new Size(1518, 712);
            mainPanel.TabIndex = 4;
            mainPanel.MouseDown += mainPanel_MouseDown;
            mainPanel.MouseMove += mainPanel_MouseMove;
            // 
            // resultsDataGridView
            // 
            resultsDataGridView.BackgroundColor = Color.White;
            resultsDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            resultsDataGridView.Columns.AddRange(new DataGridViewColumn[] { User, CorrectAnswersCount, Diagnosis });
            resultsDataGridView.Location = new Point(395, 90);
            resultsDataGridView.Name = "resultsDataGridView";
            resultsDataGridView.RowHeadersWidth = 62;
            resultsDataGridView.Size = new Size(584, 434);
            resultsDataGridView.TabIndex = 10;
            // 
            // User
            // 
            User.HeaderText = "Имя";
            User.MinimumWidth = 8;
            User.Name = "User";
            User.Width = 150;
            // 
            // CorrectAnswersCount
            // 
            CorrectAnswersCount.HeaderText = "Количество верных ответов";
            CorrectAnswersCount.MinimumWidth = 8;
            CorrectAnswersCount.Name = "CorrectAnswersCount";
            CorrectAnswersCount.Width = 220;
            // 
            // Diagnosis
            // 
            Diagnosis.HeaderText = "Диагноз";
            Diagnosis.MinimumWidth = 8;
            Diagnosis.Name = "Diagnosis";
            Diagnosis.Width = 150;
            // 
            // exitLabel
            // 
            exitLabel.AutoSize = true;
            exitLabel.Cursor = Cursors.Hand;
            exitLabel.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            exitLabel.ForeColor = Color.White;
            exitLabel.Location = new Point(1477, 0);
            exitLabel.Name = "exitLabel";
            exitLabel.Size = new Size(41, 48);
            exitLabel.TabIndex = 9;
            exitLabel.Text = "Х";
            exitLabel.Click += exitLabel_Click;
            exitLabel.MouseEnter += exitLabel_MouseEnter;
            exitLabel.MouseLeave += exitLabel_MouseLeave;
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
            comeMainFormButton.Location = new Point(549, 561);
            comeMainFormButton.Name = "comeMainFormButton";
            comeMainFormButton.Size = new Size(328, 60);
            comeMainFormButton.TabIndex = 5;
            comeMainFormButton.Text = "Главное меню";
            comeMainFormButton.UseVisualStyleBackColor = false;
            comeMainFormButton.Click += comeMainFormButton_Click;
            // 
            // resultsLabel
            // 
            resultsLabel.AutoSize = true;
            resultsLabel.Font = new Font("Comic Sans MS", 22F, FontStyle.Regular, GraphicsUnit.Point, 0);
            resultsLabel.ForeColor = Color.White;
            resultsLabel.Location = new Point(381, 9);
            resultsLabel.Name = "resultsLabel";
            resultsLabel.Size = new Size(598, 61);
            resultsLabel.TabIndex = 3;
            resultsLabel.Text = "Результаты пользователей";
            // 
            // UsersResultsForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1518, 712);
            Controls.Add(mainPanel);
            FormBorderStyle = FormBorderStyle.None;
            Name = "UsersResultsForm";
            Text = "UsersResultsForm";
            Load += UsersResultsForm_Load;
            mainPanel.ResumeLayout(false);
            mainPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)resultsDataGridView).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel mainPanel;
        private DataGridView resultsDataGridView;
        private Label exitLabel;
        private Button comeMainFormButton;
        private Label resultsLabel;
        private DataGridViewTextBoxColumn User;
        private DataGridViewTextBoxColumn CorrectAnswersCount;
        private DataGridViewTextBoxColumn Diagnosis;
    }
}