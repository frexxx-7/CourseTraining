namespace CourseTraining
{
    partial class PassTest
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
            this.CourseLbl = new System.Windows.Forms.Label();
            this.TestLbl = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // CourseLbl
            // 
            this.CourseLbl.AutoSize = true;
            this.CourseLbl.Location = new System.Drawing.Point(32, 45);
            this.CourseLbl.Name = "CourseLbl";
            this.CourseLbl.Size = new System.Drawing.Size(88, 13);
            this.CourseLbl.TabIndex = 7;
            this.CourseLbl.Text = "Название теста";
            // 
            // TestLbl
            // 
            this.TestLbl.AutoSize = true;
            this.TestLbl.Location = new System.Drawing.Point(32, 108);
            this.TestLbl.Name = "TestLbl";
            this.TestLbl.Size = new System.Drawing.Size(88, 13);
            this.TestLbl.TabIndex = 6;
            this.TestLbl.Text = "Название теста";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Название теста";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Название курса";
            // 
            // PassTest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Coral;
            this.Controls.Add(this.CourseLbl);
            this.Controls.Add(this.TestLbl);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "PassTest";
            this.Click += new System.EventHandler(this.PassTest_Click);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label CourseLbl;
        private System.Windows.Forms.Label TestLbl;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}
