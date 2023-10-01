namespace CourseTraining.Forms
{
    partial class Test
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
            this.label1 = new System.Windows.Forms.Label();
            this.CourseComboBox = new System.Windows.Forms.ComboBox();
            this.AddQuestion = new System.Windows.Forms.Button();
            this.SaveTestButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.QuestionTextBox = new System.Windows.Forms.TextBox();
            this.AOButton = new System.Windows.Forms.Button();
            this.AOPanel = new System.Windows.Forms.Panel();
            this.QuestionPanel = new System.Windows.Forms.Panel();
            this.SaveButton = new System.Windows.Forms.Button();
            this.CheckBoxAO = new System.Windows.Forms.CheckBox();
            this.NameTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.QuestionPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(7, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Выберите курс";
            // 
            // CourseComboBox
            // 
            this.CourseComboBox.FormattingEnabled = true;
            this.CourseComboBox.Location = new System.Drawing.Point(12, 69);
            this.CourseComboBox.Name = "CourseComboBox";
            this.CourseComboBox.Size = new System.Drawing.Size(333, 21);
            this.CourseComboBox.TabIndex = 1;
            // 
            // AddQuestion
            // 
            this.AddQuestion.Location = new System.Drawing.Point(12, 105);
            this.AddQuestion.Name = "AddQuestion";
            this.AddQuestion.Size = new System.Drawing.Size(157, 26);
            this.AddQuestion.TabIndex = 3;
            this.AddQuestion.Text = "Добавить вопрос";
            this.AddQuestion.UseVisualStyleBackColor = true;
            this.AddQuestion.Click += new System.EventHandler(this.AddQuestion_Click);
            // 
            // SaveTestButton
            // 
            this.SaveTestButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.SaveTestButton.Location = new System.Drawing.Point(685, 505);
            this.SaveTestButton.Name = "SaveTestButton";
            this.SaveTestButton.Size = new System.Drawing.Size(94, 34);
            this.SaveTestButton.TabIndex = 5;
            this.SaveTestButton.Text = "Сохранить";
            this.SaveTestButton.UseVisualStyleBackColor = true;
            this.SaveTestButton.Click += new System.EventHandler(this.SaveTestButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(3, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "Вопрос:";
            // 
            // QuestionTextBox
            // 
            this.QuestionTextBox.Location = new System.Drawing.Point(69, 20);
            this.QuestionTextBox.Name = "QuestionTextBox";
            this.QuestionTextBox.Size = new System.Drawing.Size(492, 20);
            this.QuestionTextBox.TabIndex = 1;
            // 
            // AOButton
            // 
            this.AOButton.Location = new System.Drawing.Point(340, 71);
            this.AOButton.Name = "AOButton";
            this.AOButton.Size = new System.Drawing.Size(230, 32);
            this.AOButton.TabIndex = 2;
            this.AOButton.Text = "Добавить вариант ответа";
            this.AOButton.UseVisualStyleBackColor = true;
            this.AOButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // AOPanel
            // 
            this.AOPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.AOPanel.AutoScroll = true;
            this.AOPanel.Location = new System.Drawing.Point(12, 125);
            this.AOPanel.Name = "AOPanel";
            this.AOPanel.Size = new System.Drawing.Size(606, 212);
            this.AOPanel.TabIndex = 3;
            this.AOPanel.Visible = false;
            // 
            // QuestionPanel
            // 
            this.QuestionPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.QuestionPanel.Controls.Add(this.SaveButton);
            this.QuestionPanel.Controls.Add(this.CheckBoxAO);
            this.QuestionPanel.Controls.Add(this.AOPanel);
            this.QuestionPanel.Controls.Add(this.AOButton);
            this.QuestionPanel.Controls.Add(this.QuestionTextBox);
            this.QuestionPanel.Controls.Add(this.label2);
            this.QuestionPanel.Location = new System.Drawing.Point(12, 153);
            this.QuestionPanel.Name = "QuestionPanel";
            this.QuestionPanel.Size = new System.Drawing.Size(633, 386);
            this.QuestionPanel.TabIndex = 4;
            this.QuestionPanel.Visible = false;
            // 
            // SaveButton
            // 
            this.SaveButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.SaveButton.Location = new System.Drawing.Point(493, 343);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(125, 34);
            this.SaveButton.TabIndex = 6;
            this.SaveButton.Text = "Сохранить вопрос";
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // CheckBoxAO
            // 
            this.CheckBoxAO.AutoSize = true;
            this.CheckBoxAO.Location = new System.Drawing.Point(12, 71);
            this.CheckBoxAO.Name = "CheckBoxAO";
            this.CheckBoxAO.Size = new System.Drawing.Size(175, 17);
            this.CheckBoxAO.TabIndex = 4;
            this.CheckBoxAO.Text = "Несколько вариантов ответа";
            this.CheckBoxAO.UseVisualStyleBackColor = true;
            // 
            // NameTextBox
            // 
            this.NameTextBox.Location = new System.Drawing.Point(95, 12);
            this.NameTextBox.Name = "NameTextBox";
            this.NameTextBox.Size = new System.Drawing.Size(430, 20);
            this.NameTextBox.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(7, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 17);
            this.label3.TabIndex = 7;
            this.label3.Text = "Нзвание:";
            // 
            // Test
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(791, 551);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.NameTextBox);
            this.Controls.Add(this.SaveTestButton);
            this.Controls.Add(this.QuestionPanel);
            this.Controls.Add(this.AddQuestion);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CourseComboBox);
            this.Name = "Test";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Тест";
            this.Load += new System.EventHandler(this.Test_Load);
            this.QuestionPanel.ResumeLayout(false);
            this.QuestionPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox CourseComboBox;
        private System.Windows.Forms.Button AddQuestion;
        private System.Windows.Forms.Button SaveTestButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox QuestionTextBox;
        private System.Windows.Forms.Button AOButton;
        private System.Windows.Forms.Panel AOPanel;
        private System.Windows.Forms.Panel QuestionPanel;
        private System.Windows.Forms.CheckBox CheckBoxAO;
        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.TextBox NameTextBox;
        private System.Windows.Forms.Label label3;
    }
}