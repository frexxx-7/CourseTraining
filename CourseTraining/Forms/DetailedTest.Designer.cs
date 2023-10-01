namespace CourseTraining.Forms
{
    partial class DetailedTest
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
            this.QuestionPanel = new System.Windows.Forms.Panel();
            this.QuestionNamePanel = new System.Windows.Forms.Panel();
            this.NextButton = new System.Windows.Forms.Button();
            this.CheckBoxAO = new System.Windows.Forms.CheckBox();
            this.AOPanel = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.QuestionNameText = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.AdminPanel = new System.Windows.Forms.Panel();
            this.EditButton = new System.Windows.Forms.Button();
            this.QuestionPanel.SuspendLayout();
            this.AdminPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // QuestionPanel
            // 
            this.QuestionPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.QuestionPanel.AutoScroll = true;
            this.QuestionPanel.Controls.Add(this.QuestionNamePanel);
            this.QuestionPanel.Controls.Add(this.NextButton);
            this.QuestionPanel.Controls.Add(this.CheckBoxAO);
            this.QuestionPanel.Controls.Add(this.AOPanel);
            this.QuestionPanel.Location = new System.Drawing.Point(12, 56);
            this.QuestionPanel.Name = "QuestionPanel";
            this.QuestionPanel.Size = new System.Drawing.Size(640, 329);
            this.QuestionPanel.TabIndex = 7;
            // 
            // QuestionNamePanel
            // 
            this.QuestionNamePanel.AutoScroll = true;
            this.QuestionNamePanel.Location = new System.Drawing.Point(12, 13);
            this.QuestionNamePanel.Name = "QuestionNamePanel";
            this.QuestionNamePanel.Size = new System.Drawing.Size(613, 58);
            this.QuestionNamePanel.TabIndex = 7;
            // 
            // NextButton
            // 
            this.NextButton.Location = new System.Drawing.Point(534, 303);
            this.NextButton.Name = "NextButton";
            this.NextButton.Size = new System.Drawing.Size(90, 23);
            this.NextButton.TabIndex = 6;
            this.NextButton.Text = "Следующий";
            this.NextButton.UseVisualStyleBackColor = true;
            this.NextButton.Click += new System.EventHandler(this.NextButton_Click);
            // 
            // CheckBoxAO
            // 
            this.CheckBoxAO.AutoSize = true;
            this.CheckBoxAO.Location = new System.Drawing.Point(12, 89);
            this.CheckBoxAO.Name = "CheckBoxAO";
            this.CheckBoxAO.Size = new System.Drawing.Size(175, 17);
            this.CheckBoxAO.TabIndex = 4;
            this.CheckBoxAO.Text = "Несколько вариантов ответа";
            this.CheckBoxAO.UseVisualStyleBackColor = true;
            // 
            // AOPanel
            // 
            this.AOPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.AOPanel.AutoScroll = true;
            this.AOPanel.Location = new System.Drawing.Point(12, 125);
            this.AOPanel.Name = "AOPanel";
            this.AOPanel.Size = new System.Drawing.Size(613, 155);
            this.AOPanel.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 2);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Имя вопроса:";
            // 
            // QuestionNameText
            // 
            this.QuestionNameText.Location = new System.Drawing.Point(12, 18);
            this.QuestionNameText.Name = "QuestionNameText";
            this.QuestionNameText.Size = new System.Drawing.Size(492, 20);
            this.QuestionNameText.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Вопросы";
            // 
            // AdminPanel
            // 
            this.AdminPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.AdminPanel.Controls.Add(this.EditButton);
            this.AdminPanel.Location = new System.Drawing.Point(658, 20);
            this.AdminPanel.Margin = new System.Windows.Forms.Padding(2);
            this.AdminPanel.Name = "AdminPanel";
            this.AdminPanel.Size = new System.Drawing.Size(131, 52);
            this.AdminPanel.TabIndex = 6;
            // 
            // EditButton
            // 
            this.EditButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.EditButton.Location = new System.Drawing.Point(14, 7);
            this.EditButton.Margin = new System.Windows.Forms.Padding(2);
            this.EditButton.Name = "EditButton";
            this.EditButton.Size = new System.Drawing.Size(108, 32);
            this.EditButton.TabIndex = 4;
            this.EditButton.Text = "Редактировать";
            this.EditButton.UseVisualStyleBackColor = true;
            this.EditButton.Click += new System.EventHandler(this.EditButton_Click);
            // 
            // DetailedTest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(799, 397);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.QuestionNameText);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.QuestionPanel);
            this.Controls.Add(this.AdminPanel);
            this.Name = "DetailedTest";
            this.Text = "Информация о тесте";
            this.Load += new System.EventHandler(this.DetailedTest_Load);
            this.QuestionPanel.ResumeLayout(false);
            this.QuestionPanel.PerformLayout();
            this.AdminPanel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel QuestionPanel;
        private System.Windows.Forms.CheckBox CheckBoxAO;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox QuestionNameText;
        private System.Windows.Forms.Panel AOPanel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button NextButton;
        private System.Windows.Forms.Panel QuestionNamePanel;
        private System.Windows.Forms.Panel AdminPanel;
        private System.Windows.Forms.Button EditButton;
    }
}