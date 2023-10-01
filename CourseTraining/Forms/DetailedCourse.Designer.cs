namespace CourseTraining.Forms
{
    partial class DetailedCourse
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.EditButton = new System.Windows.Forms.Button();
            this.AdminPanel = new System.Windows.Forms.Panel();
            this.DeleteButton = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.NameLabel = new System.Windows.Forms.Label();
            this.DescriptionLabel = new System.Windows.Forms.Label();
            this.DurationLabel = new System.Windows.Forms.Label();
            this.PriceLabel = new System.Windows.Forms.Label();
            this.TeacherLabel = new System.Windows.Forms.Label();
            this.CoursePlaneLabel = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idPatr = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NameParticipant = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SurnameParticipant = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PatronymicParticipant = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NumberPassport = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ArrivalCity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BackButton = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.AdminPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(12, 49);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Название:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(12, 103);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "Описание:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(12, 175);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(158, 18);
            this.label3.TabIndex = 2;
            this.label3.Text = "Продолжительность:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(12, 247);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 18);
            this.label4.TabIndex = 3;
            this.label4.Text = "Цена:";
            // 
            // EditButton
            // 
            this.EditButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.EditButton.Location = new System.Drawing.Point(14, 7);
            this.EditButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.EditButton.Name = "EditButton";
            this.EditButton.Size = new System.Drawing.Size(108, 32);
            this.EditButton.TabIndex = 4;
            this.EditButton.Text = "Редактировать";
            this.EditButton.UseVisualStyleBackColor = true;
            this.EditButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // AdminPanel
            // 
            this.AdminPanel.Controls.Add(this.DeleteButton);
            this.AdminPanel.Controls.Add(this.EditButton);
            this.AdminPanel.Location = new System.Drawing.Point(658, 10);
            this.AdminPanel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.AdminPanel.Name = "AdminPanel";
            this.AdminPanel.Size = new System.Drawing.Size(131, 128);
            this.AdminPanel.TabIndex = 5;
            // 
            // DeleteButton
            // 
            this.DeleteButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.DeleteButton.Location = new System.Drawing.Point(14, 74);
            this.DeleteButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(108, 32);
            this.DeleteButton.TabIndex = 5;
            this.DeleteButton.Text = "Удалить";
            this.DeleteButton.UseVisualStyleBackColor = true;
            this.DeleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(12, 306);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(121, 18);
            this.label5.TabIndex = 6;
            this.label5.Text = "Преподаватель:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(12, 370);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(91, 18);
            this.label6.TabIndex = 7;
            this.label6.Text = "План курса:";
            // 
            // NameLabel
            // 
            this.NameLabel.AutoSize = true;
            this.NameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NameLabel.Location = new System.Drawing.Point(109, 49);
            this.NameLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(75, 18);
            this.NameLabel.TabIndex = 8;
            this.NameLabel.Text = "Название";
            // 
            // DescriptionLabel
            // 
            this.DescriptionLabel.AutoSize = true;
            this.DescriptionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DescriptionLabel.Location = new System.Drawing.Point(109, 103);
            this.DescriptionLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.DescriptionLabel.Name = "DescriptionLabel";
            this.DescriptionLabel.Size = new System.Drawing.Size(76, 18);
            this.DescriptionLabel.TabIndex = 9;
            this.DescriptionLabel.Text = "Описание";
            // 
            // DurationLabel
            // 
            this.DurationLabel.AutoSize = true;
            this.DurationLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DurationLabel.Location = new System.Drawing.Point(169, 175);
            this.DurationLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.DurationLabel.Name = "DurationLabel";
            this.DurationLabel.Size = new System.Drawing.Size(154, 18);
            this.DurationLabel.TabIndex = 10;
            this.DurationLabel.Text = "Продолжительность";
            // 
            // PriceLabel
            // 
            this.PriceLabel.AutoSize = true;
            this.PriceLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PriceLabel.Location = new System.Drawing.Point(61, 247);
            this.PriceLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.PriceLabel.Name = "PriceLabel";
            this.PriceLabel.Size = new System.Drawing.Size(43, 18);
            this.PriceLabel.TabIndex = 11;
            this.PriceLabel.Text = "Цена";
            // 
            // TeacherLabel
            // 
            this.TeacherLabel.AutoSize = true;
            this.TeacherLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TeacherLabel.Location = new System.Drawing.Point(134, 306);
            this.TeacherLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.TeacherLabel.Name = "TeacherLabel";
            this.TeacherLabel.Size = new System.Drawing.Size(117, 18);
            this.TeacherLabel.TabIndex = 12;
            this.TeacherLabel.Text = "Преподаватель";
            // 
            // CoursePlaneLabel
            // 
            this.CoursePlaneLabel.AutoSize = true;
            this.CoursePlaneLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CoursePlaneLabel.Location = new System.Drawing.Point(109, 370);
            this.CoursePlaneLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.CoursePlaneLabel.Name = "CoursePlaneLabel";
            this.CoursePlaneLabel.Size = new System.Drawing.Size(87, 18);
            this.CoursePlaneLabel.TabIndex = 13;
            this.CoursePlaneLabel.Text = "План курса";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(12, 421);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(147, 18);
            this.label7.TabIndex = 15;
            this.label7.Text = "Список участников:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idPatr,
            this.NameParticipant,
            this.SurnameParticipant,
            this.PatronymicParticipant,
            this.NumberPassport,
            this.ArrivalCity});
            this.dataGridView1.Location = new System.Drawing.Point(12, 443);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(768, 179);
            this.dataGridView1.TabIndex = 16;
            // 
            // idPatr
            // 
            this.idPatr.HeaderText = "id";
            this.idPatr.MinimumWidth = 6;
            this.idPatr.Name = "idPatr";
            this.idPatr.Visible = false;
            this.idPatr.Width = 47;
            // 
            // NameParticipant
            // 
            this.NameParticipant.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.NameParticipant.HeaderText = "Имя";
            this.NameParticipant.MinimumWidth = 6;
            this.NameParticipant.Name = "NameParticipant";
            // 
            // SurnameParticipant
            // 
            this.SurnameParticipant.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.SurnameParticipant.HeaderText = "Фамилия";
            this.SurnameParticipant.MinimumWidth = 6;
            this.SurnameParticipant.Name = "SurnameParticipant";
            // 
            // PatronymicParticipant
            // 
            this.PatronymicParticipant.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.PatronymicParticipant.HeaderText = "Отчество";
            this.PatronymicParticipant.MinimumWidth = 6;
            this.PatronymicParticipant.Name = "PatronymicParticipant";
            // 
            // NumberPassport
            // 
            this.NumberPassport.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.NumberPassport.HeaderText = "Номер паспорта";
            this.NumberPassport.MinimumWidth = 6;
            this.NumberPassport.Name = "NumberPassport";
            // 
            // ArrivalCity
            // 
            this.ArrivalCity.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ArrivalCity.HeaderText = "ГородПрибывания";
            this.ArrivalCity.MinimumWidth = 6;
            this.ArrivalCity.Name = "ArrivalCity";
            // 
            // BackButton
            // 
            this.BackButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BackButton.Location = new System.Drawing.Point(9, 10);
            this.BackButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(108, 32);
            this.BackButton.TabIndex = 6;
            this.BackButton.Text = "Назад";
            this.BackButton.UseVisualStyleBackColor = true;
            this.BackButton.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // DetailedCourse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(798, 632);
            this.Controls.Add(this.BackButton);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.CoursePlaneLabel);
            this.Controls.Add(this.TeacherLabel);
            this.Controls.Add(this.PriceLabel);
            this.Controls.Add(this.DurationLabel);
            this.Controls.Add(this.DescriptionLabel);
            this.Controls.Add(this.NameLabel);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.AdminPanel);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "DetailedCourse";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Курс";
            this.Load += new System.EventHandler(this.DetailedCourse_Load);
            this.AdminPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button EditButton;
        private System.Windows.Forms.Panel AdminPanel;
        private System.Windows.Forms.Button DeleteButton;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label NameLabel;
        private System.Windows.Forms.Label DescriptionLabel;
        private System.Windows.Forms.Label DurationLabel;
        private System.Windows.Forms.Label PriceLabel;
        private System.Windows.Forms.Label TeacherLabel;
        private System.Windows.Forms.Label CoursePlaneLabel;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idPatr;
        private System.Windows.Forms.DataGridViewTextBoxColumn NameParticipant;
        private System.Windows.Forms.DataGridViewTextBoxColumn SurnameParticipant;
        private System.Windows.Forms.DataGridViewTextBoxColumn PatronymicParticipant;
        private System.Windows.Forms.DataGridViewTextBoxColumn NumberPassport;
        private System.Windows.Forms.DataGridViewTextBoxColumn ArrivalCity;
        private System.Windows.Forms.Button BackButton;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}