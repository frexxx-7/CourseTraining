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
    public partial class DetailedCourse : Form
    {
        private string idCourse;
        private string idInfo;
        public DetailedCourse(string idCourse, string idInfo)
        {
            InitializeComponent();
            this.idCourse = idCourse;
            this.idInfo = idInfo;
        }

        private void DetailedCourse_Load(object sender, EventArgs e)
        {
            DB db = new DB();
            string queryInfo = $"SELECT course.*, teacher.name as teacherName, teacher.patronymic as teacherPatronymic, teacher.surname as teacherSurname, courseplan.course_plan as planCourse FROM course " +
                $"inner join teacher on course.idTeacher = teacher.id " +
                $"inner join courseplan on course.idCourseplan = courseplan.id " +
                $"where course.id = {idCourse}";
            MySqlCommand mySqlCommand = new MySqlCommand(queryInfo, db.getConnection());

            db.openConnection();

            MySqlDataReader reader = mySqlCommand.ExecuteReader();

            while (reader.Read())
            {
                NameLabel.Text = reader["name"].ToString();
                DescriptionLabel.Text = reader["description"].ToString();
                DurationLabel.Text = reader["duration"].ToString();
                PriceLabel.Text = reader["price"].ToString();
                TeacherLabel.Text = $"{reader["teacherName"]} {reader["teacherPatronymic"]} {reader["teacherSurname"]}";
                CoursePlaneLabel.Text = reader["planCourse"].ToString();
            }
            reader.Close();

            db.closeConnection();

            string queryInfo2 = $"select * from participant where participant.id in " +
                $"(select idParticipant from participantinliat where idList in " +
                $"(select listofparticipant.id from listofparticipant where idCourse={idCourse}))";
            MySqlCommand mySqlCommand2 = new MySqlCommand(queryInfo2, db.getConnection());

            db.openConnection();

            MySqlDataReader reader2 = mySqlCommand2.ExecuteReader();

            List<string[]> dataDB = new List<string[]>();
            while (reader2.Read())
            {
                dataDB.Add(new string[reader2.FieldCount]);

                for (int i = 0; i < reader2.FieldCount; i++)
                {
                    dataDB[dataDB.Count - 1][i] = reader2[i].ToString();
                }
            }
            reader2.Close();
            foreach (string[] s in dataDB)
                dataGridView1.Rows.Add(s);

            db.closeConnection();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            new AddCourse(idCourse, idInfo).Show();
            this.Close();
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            new CheckCourse(idInfo).Show();
            this.Close();
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            DB db = new DB();

            MySqlCommand command = new MySqlCommand($"DELETE FROM course WHERE id ={idCourse}", db.getConnection());
            MySqlCommand command2 = new MySqlCommand($"DELETE FROM listofparticipant WHERE idCourse ={idCourse}", db.getConnection());
            MySqlCommand command3 = new MySqlCommand($"DELETE FROM participantinliat WHERE idList = (select id from listofparticipant where idCourse = {idCourse})", db.getConnection());
            MySqlCommand command4 = new MySqlCommand($"DELETE FROM courseplan WHERE courseplan.id = (select idCourseplan from course where course.id = {idCourse})", db.getConnection());

            db.openConnection();

            try
            {
                command4.ExecuteNonQuery();
                command2.ExecuteNonQuery();
                command3.ExecuteNonQuery();
                command.ExecuteNonQuery();
                MessageBox.Show("Запись успешно удалена");
                this.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("Ошибка");
            }

            db.closeConnection();
        }
    }
}
