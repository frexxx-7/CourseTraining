namespace CourseTraining.Forms
{
    partial class PassingTheTest
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
            this.NameLabel = new System.Windows.Forms.Label();
            this.BackButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.QuestionPanel = new System.Windows.Forms.Panel();
            this.QuestionNamePanel = new System.Windows.Forms.Panel();
            this.NextButton = new System.Windows.Forms.Button();
            this.AOPanel = new System.Windows.Forms.Panel();
            this.CheckButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.ResLbl = new System.Windows.Forms.Label();
            this.QuestionPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // NameLabel
            // 
            this.NameLabel.AutoSize = true;
            this.NameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NameLabel.Location = new System.Drawing.Point(88, 41);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(72, 17);
            this.NameLabel.TabIndex = 0;
            this.NameLabel.Text = "Название";
            // 
            // BackButton
            // 
            this.BackButton.Location = new System.Drawing.Point(9, 11);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(75, 23);
            this.BackButton.TabIndex = 1;
            this.BackButton.Text = "Назад";
            this.BackButton.UseVisualStyleBackColor = true;
            this.BackButton.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(6, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Название:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Вопросы";
            // 
            // QuestionPanel
            // 
            this.QuestionPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.QuestionPanel.AutoScroll = true;
            this.QuestionPanel.Controls.Add(this.QuestionNamePanel);
            this.QuestionPanel.Controls.Add(this.NextButton);
            this.QuestionPanel.Controls.Add(this.AOPanel);
            this.QuestionPanel.Location = new System.Drawing.Point(9, 80);
            this.QuestionPanel.Name = "QuestionPanel";
            this.QuestionPanel.Size = new System.Drawing.Size(643, 358);
            this.QuestionPanel.TabIndex = 10;
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
            this.NextButton.Location = new System.Drawing.Point(538, 324);
            this.NextButton.Name = "NextButton";
            this.NextButton.Size = new System.Drawing.Size(90, 23);
            this.NextButton.TabIndex = 6;
            this.NextButton.Text = "Следующий";
            this.NextButton.UseVisualStyleBackColor = true;
            this.NextButton.Click += new System.EventHandler(this.NextButton_Click);
            // 
            // AOPanel
            // 
            this.AOPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.AOPanel.AutoScroll = true;
            this.AOPanel.Location = new System.Drawing.Point(12, 125);
            this.AOPanel.Name = "AOPanel";
            this.AOPanel.Size = new System.Drawing.Size(616, 184);
            this.AOPanel.TabIndex = 3;
            // 
            // CheckButton
            // 
            this.CheckButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.CheckButton.Location = new System.Drawing.Point(658, 323);
            this.CheckButton.Name = "CheckButton";
            this.CheckButton.Size = new System.Drawing.Size(130, 34);
            this.CheckButton.TabIndex = 12;
            this.CheckButton.Text = "Проверить тест";
            this.CheckButton.UseVisualStyleBackColor = true;
            this.CheckButton.Visible = false;
            this.CheckButton.Click += new System.EventHandler(this.CheckButton_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(658, 369);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 20);
            this.label3.TabIndex = 13;
            this.label3.Text = "Результат:";
            this.label3.Visible = false;
            // 
            // ResLbl
            // 
            this.ResLbl.AutoSize = true;
            this.ResLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ResLbl.Location = new System.Drawing.Point(662, 393);
            this.ResLbl.Name = "ResLbl";
            this.ResLbl.Size = new System.Drawing.Size(0, 20);
            this.ResLbl.TabIndex = 14;
            // 
            // PassingTheTest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ResLbl);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.CheckButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.QuestionPanel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BackButton);
            this.Controls.Add(this.NameLabel);
            this.Name = "PassingTheTest";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Прохождение теста";
            this.Load += new System.EventHandler(this.PassingTheTest_Load);
            this.QuestionPanel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label NameLabel;
        private System.Windows.Forms.Button BackButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel QuestionPanel;
        private System.Windows.Forms.Panel QuestionNamePanel;
        private System.Windows.Forms.Button NextButton;
        private System.Windows.Forms.Panel AOPanel;
        private System.Windows.Forms.Button CheckButton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label ResLbl;
    }
}