namespace CourseTraining.Forms
{
    partial class AddStudent
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
            this.participantCbb = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.participant = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idPatr = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addPart = new System.Windows.Forms.Button();
            this.savePatBtn = new System.Windows.Forms.Button();
            this.DeleteButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // participantCbb
            // 
            this.participantCbb.FormattingEnabled = true;
            this.participantCbb.Location = new System.Drawing.Point(39, 52);
            this.participantCbb.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.participantCbb.Name = "participantCbb";
            this.participantCbb.Size = new System.Drawing.Size(388, 24);
            this.participantCbb.TabIndex = 0;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.participant,
            this.idPatr});
            this.dataGridView1.Location = new System.Drawing.Point(39, 107);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(469, 378);
            this.dataGridView1.TabIndex = 1;
            // 
            // participant
            // 
            this.participant.HeaderText = "Ученики";
            this.participant.MinimumWidth = 6;
            this.participant.Name = "participant";
            this.participant.Width = 300;
            // 
            // idPatr
            // 
            this.idPatr.HeaderText = "id";
            this.idPatr.MinimumWidth = 6;
            this.idPatr.Name = "idPatr";
            this.idPatr.Visible = false;
            this.idPatr.Width = 125;
            // 
            // addPart
            // 
            this.addPart.Location = new System.Drawing.Point(459, 52);
            this.addPart.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.addPart.Name = "addPart";
            this.addPart.Size = new System.Drawing.Size(100, 28);
            this.addPart.TabIndex = 2;
            this.addPart.Text = "Добавить";
            this.addPart.UseVisualStyleBackColor = true;
            this.addPart.Click += new System.EventHandler(this.addPart_Click);
            // 
            // savePatBtn
            // 
            this.savePatBtn.Location = new System.Drawing.Point(492, 516);
            this.savePatBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.savePatBtn.Name = "savePatBtn";
            this.savePatBtn.Size = new System.Drawing.Size(100, 25);
            this.savePatBtn.TabIndex = 3;
            this.savePatBtn.Text = "Сохранить";
            this.savePatBtn.UseVisualStyleBackColor = true;
            this.savePatBtn.Click += new System.EventHandler(this.savePatBtn_Click);
            // 
            // DeleteButton
            // 
            this.DeleteButton.Location = new System.Drawing.Point(13, 513);
            this.DeleteButton.Margin = new System.Windows.Forms.Padding(4);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(100, 28);
            this.DeleteButton.TabIndex = 4;
            this.DeleteButton.Text = "Удалить";
            this.DeleteButton.UseVisualStyleBackColor = true;
            this.DeleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // AddStudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(605, 554);
            this.Controls.Add(this.DeleteButton);
            this.Controls.Add(this.savePatBtn);
            this.Controls.Add(this.addPart);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.participantCbb);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "AddStudent";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Добавить учеников";
            this.Load += new System.EventHandler(this.AddStudent_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox participantCbb;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button addPart;
        private System.Windows.Forms.Button savePatBtn;
        private System.Windows.Forms.DataGridViewTextBoxColumn participant;
        private System.Windows.Forms.DataGridViewTextBoxColumn idPatr;
        private System.Windows.Forms.Button DeleteButton;
    }
}