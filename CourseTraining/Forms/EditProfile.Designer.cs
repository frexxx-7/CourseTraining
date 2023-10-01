namespace CourseTraining.Forms
{
    partial class EditProfile
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
            this.SupervisorPanel = new System.Windows.Forms.Panel();
            this.DynamicPanel = new System.Windows.Forms.Panel();
            this.ParticipantPanel = new System.Windows.Forms.Panel();
            this.ArrivalCityTextBox = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.NumberPassportParticipantTextBox = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.TeacherPanel = new System.Windows.Forms.Panel();
            this.NumberPassportTextBox = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.ExperienceTextBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.EducationTextBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.PasswordTextBox = new System.Windows.Forms.TextBox();
            this.LoginTextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.PatronymicTextBox = new System.Windows.Forms.TextBox();
            this.SurnameTextBox = new System.Windows.Forms.TextBox();
            this.NameTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SupervisorPanel.SuspendLayout();
            this.DynamicPanel.SuspendLayout();
            this.ParticipantPanel.SuspendLayout();
            this.TeacherPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // SupervisorPanel
            // 
            this.SupervisorPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SupervisorPanel.Controls.Add(this.DynamicPanel);
            this.SupervisorPanel.Controls.Add(this.PasswordTextBox);
            this.SupervisorPanel.Controls.Add(this.LoginTextBox);
            this.SupervisorPanel.Controls.Add(this.label5);
            this.SupervisorPanel.Controls.Add(this.label4);
            this.SupervisorPanel.Controls.Add(this.button1);
            this.SupervisorPanel.Controls.Add(this.PatronymicTextBox);
            this.SupervisorPanel.Controls.Add(this.SurnameTextBox);
            this.SupervisorPanel.Controls.Add(this.NameTextBox);
            this.SupervisorPanel.Controls.Add(this.label3);
            this.SupervisorPanel.Controls.Add(this.label2);
            this.SupervisorPanel.Controls.Add(this.label1);
            this.SupervisorPanel.Location = new System.Drawing.Point(12, 12);
            this.SupervisorPanel.Name = "SupervisorPanel";
            this.SupervisorPanel.Size = new System.Drawing.Size(967, 516);
            this.SupervisorPanel.TabIndex = 0;
            // 
            // DynamicPanel
            // 
            this.DynamicPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DynamicPanel.Controls.Add(this.ParticipantPanel);
            this.DynamicPanel.Controls.Add(this.TeacherPanel);
            this.DynamicPanel.Location = new System.Drawing.Point(470, 16);
            this.DynamicPanel.Name = "DynamicPanel";
            this.DynamicPanel.Size = new System.Drawing.Size(481, 330);
            this.DynamicPanel.TabIndex = 11;
            // 
            // ParticipantPanel
            // 
            this.ParticipantPanel.Controls.Add(this.ArrivalCityTextBox);
            this.ParticipantPanel.Controls.Add(this.label10);
            this.ParticipantPanel.Controls.Add(this.NumberPassportParticipantTextBox);
            this.ParticipantPanel.Controls.Add(this.label9);
            this.ParticipantPanel.Location = new System.Drawing.Point(393, 13);
            this.ParticipantPanel.Name = "ParticipantPanel";
            this.ParticipantPanel.Size = new System.Drawing.Size(509, 113);
            this.ParticipantPanel.TabIndex = 13;
            this.ParticipantPanel.Visible = false;
            // 
            // ArrivalCityTextBox
            // 
            this.ArrivalCityTextBox.Location = new System.Drawing.Point(195, 80);
            this.ArrivalCityTextBox.Name = "ArrivalCityTextBox";
            this.ArrivalCityTextBox.Size = new System.Drawing.Size(280, 22);
            this.ArrivalCityTextBox.TabIndex = 20;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label10.Location = new System.Drawing.Point(3, 79);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(191, 25);
            this.label10.TabIndex = 19;
            this.label10.Text = "Город прибывания:";
            // 
            // NumberPassportParticipantTextBox
            // 
            this.NumberPassportParticipantTextBox.Location = new System.Drawing.Point(195, 18);
            this.NumberPassportParticipantTextBox.Name = "NumberPassportParticipantTextBox";
            this.NumberPassportParticipantTextBox.Size = new System.Drawing.Size(280, 22);
            this.NumberPassportParticipantTextBox.TabIndex = 18;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.Location = new System.Drawing.Point(3, 14);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(172, 25);
            this.label9.TabIndex = 17;
            this.label9.Text = "Номер паспорта:";
            // 
            // TeacherPanel
            // 
            this.TeacherPanel.Controls.Add(this.NumberPassportTextBox);
            this.TeacherPanel.Controls.Add(this.label8);
            this.TeacherPanel.Controls.Add(this.ExperienceTextBox);
            this.TeacherPanel.Controls.Add(this.label7);
            this.TeacherPanel.Controls.Add(this.EducationTextBox);
            this.TeacherPanel.Controls.Add(this.label6);
            this.TeacherPanel.Location = new System.Drawing.Point(358, 220);
            this.TeacherPanel.Name = "TeacherPanel";
            this.TeacherPanel.Size = new System.Drawing.Size(510, 190);
            this.TeacherPanel.TabIndex = 12;
            this.TeacherPanel.Visible = false;
            // 
            // NumberPassportTextBox
            // 
            this.NumberPassportTextBox.Location = new System.Drawing.Point(195, 157);
            this.NumberPassportTextBox.Name = "NumberPassportTextBox";
            this.NumberPassportTextBox.Size = new System.Drawing.Size(280, 22);
            this.NumberPassportTextBox.TabIndex = 16;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.Location = new System.Drawing.Point(17, 154);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(172, 25);
            this.label8.TabIndex = 15;
            this.label8.Text = "Номер паспорта:";
            // 
            // ExperienceTextBox
            // 
            this.ExperienceTextBox.Location = new System.Drawing.Point(195, 91);
            this.ExperienceTextBox.Name = "ExperienceTextBox";
            this.ExperienceTextBox.Size = new System.Drawing.Size(280, 22);
            this.ExperienceTextBox.TabIndex = 14;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(17, 91);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(70, 25);
            this.label7.TabIndex = 13;
            this.label7.Text = "Стаж:";
            // 
            // EducationTextBox
            // 
            this.EducationTextBox.Location = new System.Drawing.Point(195, 32);
            this.EducationTextBox.Name = "EducationTextBox";
            this.EducationTextBox.Size = new System.Drawing.Size(280, 22);
            this.EducationTextBox.TabIndex = 13;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(17, 28);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(140, 25);
            this.label6.TabIndex = 13;
            this.label6.Text = "Образование:";
            // 
            // PasswordTextBox
            // 
            this.PasswordTextBox.Location = new System.Drawing.Point(150, 300);
            this.PasswordTextBox.Name = "PasswordTextBox";
            this.PasswordTextBox.Size = new System.Drawing.Size(280, 22);
            this.PasswordTextBox.TabIndex = 10;
            // 
            // LoginTextBox
            // 
            this.LoginTextBox.Location = new System.Drawing.Point(150, 240);
            this.LoginTextBox.Name = "LoginTextBox";
            this.LoginTextBox.Size = new System.Drawing.Size(280, 22);
            this.LoginTextBox.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(19, 296);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(104, 25);
            this.label5.TabIndex = 8;
            this.label5.Text = "Пароль:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(19, 236);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 25);
            this.label4.TabIndex = 7;
            this.label4.Text = "Логин:";
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Location = new System.Drawing.Point(806, 466);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(145, 38);
            this.button1.TabIndex = 6;
            this.button1.Text = "Сохранить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // PatronymicTextBox
            // 
            this.PatronymicTextBox.Location = new System.Drawing.Point(150, 103);
            this.PatronymicTextBox.Name = "PatronymicTextBox";
            this.PatronymicTextBox.Size = new System.Drawing.Size(280, 22);
            this.PatronymicTextBox.TabIndex = 5;
            // 
            // SurnameTextBox
            // 
            this.SurnameTextBox.Location = new System.Drawing.Point(150, 175);
            this.SurnameTextBox.Name = "SurnameTextBox";
            this.SurnameTextBox.Size = new System.Drawing.Size(280, 22);
            this.SurnameTextBox.TabIndex = 4;
            // 
            // NameTextBox
            // 
            this.NameTextBox.Location = new System.Drawing.Point(150, 29);
            this.NameTextBox.Name = "NameTextBox";
            this.NameTextBox.Size = new System.Drawing.Size(280, 22);
            this.NameTextBox.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(19, 100);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(110, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Отчество:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(19, 172);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Фамилия:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(19, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Имя:";
            // 
            // EditProfile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(991, 540);
            this.Controls.Add(this.SupervisorPanel);
            this.Name = "EditProfile";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Редактировать профиль";
            this.Load += new System.EventHandler(this.EditProfile_Load);
            this.SupervisorPanel.ResumeLayout(false);
            this.SupervisorPanel.PerformLayout();
            this.DynamicPanel.ResumeLayout(false);
            this.ParticipantPanel.ResumeLayout(false);
            this.ParticipantPanel.PerformLayout();
            this.TeacherPanel.ResumeLayout(false);
            this.TeacherPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel SupervisorPanel;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox PatronymicTextBox;
        private System.Windows.Forms.TextBox SurnameTextBox;
        private System.Windows.Forms.TextBox NameTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox PasswordTextBox;
        private System.Windows.Forms.TextBox LoginTextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel TeacherPanel;
        private System.Windows.Forms.TextBox ExperienceTextBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox EducationTextBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel DynamicPanel;
        private System.Windows.Forms.TextBox NumberPassportTextBox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel ParticipantPanel;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox NumberPassportParticipantTextBox;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox ArrivalCityTextBox;
    }
}