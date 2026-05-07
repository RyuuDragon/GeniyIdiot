namespace GeniyIdiotWinFormsApp
{
    partial class MainForm
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
            showResultsButton = new Button();
            thirdCommandButton = new Button();
            secondCommandButton = new Button();
            firstCommandButton = new Button();
            callNameLabel = new Label();
            headPanel = new Panel();
            exitLabel = new Label();
            headLabel = new Label();
            mainPanel.SuspendLayout();
            headPanel.SuspendLayout();
            SuspendLayout();
            // 
            // mainPanel
            // 
            mainPanel.BackColor = Color.ForestGreen;
            mainPanel.Controls.Add(showResultsButton);
            mainPanel.Controls.Add(thirdCommandButton);
            mainPanel.Controls.Add(secondCommandButton);
            mainPanel.Controls.Add(firstCommandButton);
            mainPanel.Controls.Add(callNameLabel);
            mainPanel.Controls.Add(headPanel);
            mainPanel.Dock = DockStyle.Fill;
            mainPanel.Location = new Point(0, 0);
            mainPanel.Name = "mainPanel";
            mainPanel.Size = new Size(945, 651);
            mainPanel.TabIndex = 1;
            mainPanel.MouseDown += mainPanel_MouseDown;
            mainPanel.MouseMove += mainPanel_MouseMove;
            // 
            // showResultsButton
            // 
            showResultsButton.BackColor = Color.FromArgb(34, 34, 139);
            showResultsButton.Cursor = Cursors.Hand;
            showResultsButton.FlatAppearance.BorderSize = 0;
            showResultsButton.FlatAppearance.MouseDownBackColor = Color.Red;
            showResultsButton.FlatAppearance.MouseOverBackColor = Color.Maroon;
            showResultsButton.FlatStyle = FlatStyle.Flat;
            showResultsButton.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point, 0);
            showResultsButton.ForeColor = Color.White;
            showResultsButton.Location = new Point(294, 512);
            showResultsButton.Name = "showResultsButton";
            showResultsButton.Size = new Size(355, 60);
            showResultsButton.TabIndex = 7;
            showResultsButton.Text = "Показать результаты";
            showResultsButton.UseVisualStyleBackColor = false;
            showResultsButton.Click += showResultsButton_Click;
            // 
            // thirdCommandButton
            // 
            thirdCommandButton.BackColor = Color.FromArgb(34, 34, 139);
            thirdCommandButton.Cursor = Cursors.Hand;
            thirdCommandButton.FlatAppearance.BorderSize = 0;
            thirdCommandButton.FlatAppearance.MouseDownBackColor = Color.Red;
            thirdCommandButton.FlatAppearance.MouseOverBackColor = Color.Maroon;
            thirdCommandButton.FlatStyle = FlatStyle.Flat;
            thirdCommandButton.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point, 0);
            thirdCommandButton.ForeColor = Color.White;
            thirdCommandButton.Location = new Point(310, 422);
            thirdCommandButton.Name = "thirdCommandButton";
            thirdCommandButton.Size = new Size(328, 60);
            thirdCommandButton.TabIndex = 6;
            thirdCommandButton.Text = "Удалить вопрос(ы)";
            thirdCommandButton.UseVisualStyleBackColor = false;
            thirdCommandButton.Click += thirdCommandButton_Click;
            // 
            // secondCommandButton
            // 
            secondCommandButton.BackColor = Color.FromArgb(34, 34, 139);
            secondCommandButton.Cursor = Cursors.Hand;
            secondCommandButton.FlatAppearance.BorderSize = 0;
            secondCommandButton.FlatAppearance.MouseDownBackColor = Color.Red;
            secondCommandButton.FlatAppearance.MouseOverBackColor = Color.Maroon;
            secondCommandButton.FlatStyle = FlatStyle.Flat;
            secondCommandButton.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point, 0);
            secondCommandButton.ForeColor = Color.White;
            secondCommandButton.Location = new Point(310, 335);
            secondCommandButton.Name = "secondCommandButton";
            secondCommandButton.Size = new Size(328, 60);
            secondCommandButton.TabIndex = 5;
            secondCommandButton.Text = "Добавить вопрос(ы)";
            secondCommandButton.UseVisualStyleBackColor = false;
            secondCommandButton.Click += secondCommandButton_Click;
            // 
            // firstCommandButton
            // 
            firstCommandButton.BackColor = Color.FromArgb(34, 34, 139);
            firstCommandButton.Cursor = Cursors.Hand;
            firstCommandButton.FlatAppearance.BorderSize = 0;
            firstCommandButton.FlatAppearance.MouseDownBackColor = Color.Red;
            firstCommandButton.FlatAppearance.MouseOverBackColor = Color.Maroon;
            firstCommandButton.FlatStyle = FlatStyle.Flat;
            firstCommandButton.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point, 0);
            firstCommandButton.ForeColor = Color.White;
            firstCommandButton.Location = new Point(325, 249);
            firstCommandButton.Name = "firstCommandButton";
            firstCommandButton.Size = new Size(293, 60);
            firstCommandButton.TabIndex = 4;
            firstCommandButton.Text = "Начать тест";
            firstCommandButton.UseVisualStyleBackColor = false;
            firstCommandButton.Click += firstCommandButton_Click;
            // 
            // callNameLabel
            // 
            callNameLabel.AutoSize = true;
            callNameLabel.Font = new Font("Comic Sans MS", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            callNameLabel.ForeColor = Color.White;
            callNameLabel.Location = new Point(248, 162);
            callNameLabel.Name = "callNameLabel";
            callNameLabel.Size = new Size(474, 67);
            callNameLabel.TabIndex = 3;
            callNameLabel.Text = "Выберите команду:";
            // 
            // headPanel
            // 
            headPanel.BackColor = Color.FromArgb(139, 34, 34);
            headPanel.Controls.Add(exitLabel);
            headPanel.Controls.Add(headLabel);
            headPanel.Dock = DockStyle.Top;
            headPanel.Location = new Point(0, 0);
            headPanel.Name = "headPanel";
            headPanel.Size = new Size(945, 150);
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
            headLabel.Size = new Size(945, 150);
            headLabel.TabIndex = 0;
            headLabel.Text = "Здравствуйте, Имя.";
            headLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(945, 651);
            Controls.Add(mainPanel);
            FormBorderStyle = FormBorderStyle.None;
            Name = "MainForm";
            Text = "MainForm";
            Load += mainForm_Load;
            mainPanel.ResumeLayout(false);
            mainPanel.PerformLayout();
            headPanel.ResumeLayout(false);
            headPanel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel mainPanel;
        private Label callNameLabel;
        private Panel headPanel;
        private Label exitLabel;
        private Label headLabel;
        private Button showResultsButton;
        private Button thirdCommandButton;
        private Button secondCommandButton;
        private Button firstCommandButton;
    }
}