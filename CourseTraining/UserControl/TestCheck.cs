using CourseTraining.Classes;
using CourseTraining.Forms;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CourseTraining
{
    public partial class TestCheck : UserControl
    {
        private CheckTest checkTest;
        public TestCheck(string nameTest, string nameCourse, string post, CheckTest checkTest = null)
        {
            InitializeComponent();
            TestLbl.Text = nameTest;
            CourseLbl.Text = nameCourse;
            this.checkTest = checkTest;
            if (post == "Руководитель")
            {
                DeleteButton.Visible = true;
            }
        }

        private void TestCheck_Click(object sender, EventArgs e)
        {
            new DetailedTest(TestLbl.Text, checkTest.idTest).Show();
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            DB db = new DB();

            MySqlCommand command = new MySqlCommand($"DELETE FROM test WHERE name = '{TestLbl.Text}'", db.getConnection());
            
            db.openConnection();

            try
            {
                command.ExecuteNonQuery();
                MessageBox.Show("Запись успешно удалена");
                checkTest.GenerateDynamicTestControls();
            }
            catch (Exception)
            {
                MessageBox.Show("Запись удалена");
            }

            db.closeConnection();
        }
    }
}
