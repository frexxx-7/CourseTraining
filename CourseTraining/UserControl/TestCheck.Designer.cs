namespace CourseTraining
{
    partial class TestCheck
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TestLbl = new System.Windows.Forms.Label();
            this.CourseLbl = new System.Windows.Forms.Label();
            this.DeleteButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Название курса";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(4, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Название теста";
            // 
            // TestLbl
            // 
            this.TestLbl.AutoSize = true;
            this.TestLbl.Location = new System.Drawing.Point(5, 83);
            this.TestLbl.Name = "TestLbl";
            this.TestLbl.Size = new System.Drawing.Size(88, 13);
            this.TestLbl.TabIndex = 2;
            this.TestLbl.Text = "Название теста";
            // 
            // CourseLbl
            // 
            this.CourseLbl.AutoSize = true;
            this.CourseLbl.Location = new System.Drawing.Point(5, 20);
            this.CourseLbl.Name = "CourseLbl";
            this.CourseLbl.Size = new System.Drawing.Size(88, 13);
            this.CourseLbl.TabIndex = 3;
            this.CourseLbl.Text = "Название теста";
            // 
            // DeleteButton
            // 
            this.DeleteButton.Location = new System.Drawing.Point(8, 109);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(214, 23);
            this.DeleteButton.TabIndex = 5;
            this.DeleteButton.Text = "Удалить";
            this.DeleteButton.UseVisualStyleBackColor = true;
            this.DeleteButton.Visible = false;
            this.DeleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // TestCheck
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Coral;
            this.Controls.Add(this.DeleteButton);
            this.Controls.Add(this.CourseLbl);
            this.Controls.Add(this.TestLbl);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "TestCheck";
            this.Size = new System.Drawing.Size(228, 140);
            this.Click += new System.EventHandler(this.TestCheck_Click);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label TestLbl;
        private System.Windows.Forms.Label CourseLbl;
        private System.Windows.Forms.Button DeleteButton;
    }
}
