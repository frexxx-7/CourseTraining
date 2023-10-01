using CourseTraining.Classes;
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

namespace CourseTraining.Forms
{
    public partial class PassingTest : Form
    {
        private string idPost;
        private string post;

        public PassingTest(string idPost, string post)
        {
            InitializeComponent();
            this.idPost = idPost;
            this.post = post;
        }

        private void PassingTest_Load(object sender, EventArgs e)
        {
            GenerateDynamicPassingTestControls();
        }
        private void GenerateDynamicPassingTestControls()
        {
            flowLayoutPanel1.Controls.Clear();
            DB db = new DB();
            string queryInfo = $"";
            switch (post)
            {
                case "Руководитель":
                    queryInfo = $"SELECT test.name, course.name, test.id FROM test INNER JOIN course on test.idCourse = course.id";
                    break;
                case "Преподаватель": 
                    queryInfo = $"SELECT test.name, course.name, test.id FROM test INNER JOIN course on test.idCourse = course.id INNER JOIN teacher ON teacher.id = course.idTeacher where teacher.id = {idPost}";
                    break;
                case "Ученик":
                    queryInfo = $"SELECT test.name, course.name, test.id FROM test INNER JOIN course on test.idCourse = course.id " +
                        $"INNER JOIN listofparticipant ON listofparticipant.idCourse = course.id " +
                        $"INNER JOIN participantinliat on participantinliat.idList =  listofparticipant.id  " +
                        $"INNER JOIN participant ON participant.id = participantinliat.idParticipant where participant.id = {idPost}";
                    break;
                default:
                    break;
            }

            MySqlCommand mySqlCommand = new MySqlCommand(queryInfo, db.getConnection());

            db.openConnection();

            MySqlDataReader reader = mySqlCommand.ExecuteReader();
            int panelNumber = 0;

            List<PassTest> listItems = new List<PassTest>();
            while (reader.Read())
            {
                listItems.Add(new PassTest(reader[0].ToString(), reader[1].ToString(), reader[2].ToString(), this, idPost, post));
                flowLayoutPanel1.Controls.Add(listItems[panelNumber]);
                panelNumber++;

            }
            reader.Close();

            db.closeConnection();
        }
    }
}
