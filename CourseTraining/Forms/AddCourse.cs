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
    public partial class AddCourse : Form
    {
        private string idCourse = null;
        private string idListofparticipant = "";
        private string idInfo;
        public AddCourse(string idCourse, string idInfo)
        {
            InitializeComponent();
            this.idCourse = idCourse;
            this.idInfo = idInfo;
        }

        private void AddCourse_Load(object sender, EventArgs e)
        {
            DB db = new DB();

            string queryInfoCbb = $"SELECT id, name, surname, patronymic FROM teacher";

            MySqlCommand mySqlCommandCbb = new MySqlCommand(queryInfoCbb, db.getConnection());

            db.openConnection();

            MySqlDataReader readerCbb = mySqlCommandCbb.ExecuteReader();
            while (readerCbb.Read())
            {
                ComboboxItem item = new ComboboxItem();
                item.Text = $" {readerCbb[1]} {readerCbb[3]} {readerCbb[2]}";
                item.Value = readerCbb[0];
                TeacherComboBox.Items.Add(item);
            }
            readerCbb.Close();

            db.closeConnection();

            if (idCourse != null)
            {
                string queryInfo = $"SELECT course.*, courseplan.course_plan as planCourse FROM course " +
                    $"inner join courseplan on course.idCourseplan = courseplan.id " +
                    $"where course.id = {idCourse}";

                MySqlCommand mySqlCommand = new MySqlCommand(queryInfo, db.getConnection());

                db.openConnection();

                MySqlDataReader reader = mySqlCommand.ExecuteReader();
                while (reader.Read())
                {
                    NameTextBox.Text = reader["name"].ToString();
                    DescriptionTextBox.Text = reader["description"].ToString();
                    DurationTextBox.Text = reader["duration"].ToString();
                    PriceTextBox.Text = reader["price"].ToString();

                    for (int i = 0; i < TeacherComboBox.Items.Count; i++)
                    {
                        if (reader["idTeacher"].ToString() != "")
                        {
                            if (Convert.ToInt32((TeacherComboBox.Items[i] as ComboboxItem).Value) == Convert.ToInt32(reader["idTeacher"]))
                            {
                                TeacherComboBox.SelectedIndex = i;
                            }
                        }
                    }

                    PlanCourseTextBox.Text = reader["planCourse"].ToString();
                }
                reader.Close();

                db.closeConnection();
            }
        }

        private void addCourse()
        {
            string idCoursePlan = "";
            DB db = new DB();

            MySqlCommand command1 = new MySqlCommand($"INSERT into courseplan (course_plan) values(@courseplan)", db.getConnection());
            MySqlCommand commandGetLastID = new MySqlCommand($"SELECT id FROM courseplan WHERE (id = LAST_INSERT_ID())", db.getConnection());
            command1.Parameters.AddWithValue("@courseplan", PlanCourseTextBox.Text);
            db.openConnection();

            try
            {
                command1.ExecuteNonQuery();

            }
            catch (Exception exep)
            {
                MessageBox.Show(exep.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            MySqlDataReader reader1 = commandGetLastID.ExecuteReader();
            while (reader1.Read())
            {
                idCoursePlan = reader1[0].ToString();
            }
            reader1.Close();

            db.closeConnection();

            MySqlCommand command2 = new MySqlCommand($"INSERT into course (name, description, duration, price, idTeacher, idCourseplan) " +
                $"values(@name, @description, @duration, @price, @idTeacher, @idCourseplan)", db.getConnection());
            MySqlCommand commandGetLastID2 = new MySqlCommand($"SELECT id FROM course WHERE (id = LAST_INSERT_ID())", db.getConnection());
            command2.Parameters.AddWithValue("@name", NameTextBox.Text);
            command2.Parameters.AddWithValue("@description", DescriptionTextBox.Text);
            command2.Parameters.AddWithValue("@duration", DurationTextBox.Text);
            command2.Parameters.AddWithValue("@price", PriceTextBox.Text);
            command2.Parameters.AddWithValue("@idTeacher", (TeacherComboBox.SelectedItem as ComboboxItem).Value);
            command2.Parameters.AddWithValue("@idCourseplan", idCoursePlan);


            db.openConnection();

            try
            {
                command2.ExecuteNonQuery();
            }
            catch (Exception exep)
            {
                MessageBox.Show(exep.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            MySqlDataReader reader2 = commandGetLastID2.ExecuteReader();
            while (reader2.Read())
            {
                idCourse = reader2[0].ToString();
            }
            reader2.Close();
            db.closeConnection();

            MySqlCommand command3 = new MySqlCommand($"INSERT into listofparticipant (idCourse) values (@idCourse)", db.getConnection());
            MySqlCommand commandGetLastID3 = new MySqlCommand($"SELECT id FROM listofparticipant WHERE (id = LAST_INSERT_ID())", db.getConnection());
            command3.Parameters.AddWithValue("@idCourse", idCourse);


            db.openConnection();

            try
            {
                command3.ExecuteNonQuery();
            }
            catch (Exception exep)
            {
                MessageBox.Show(exep.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            MySqlDataReader reader3 = commandGetLastID3.ExecuteReader();
            while (reader3.Read())
            {
                idListofparticipant = reader3[0].ToString();
            }
            reader3.Close();


            db.closeConnection();
        }
        private void editCourse()
        {
            DB db = new DB();
            string query = "Update course set ";
            string query2 = $"Update courseplan set course_plan = '{PlanCourseTextBox.Text}'";
            if (NameTextBox.Text.Length != 0)
            {
                query += $"name='{NameTextBox.Text}', ";
            }
            if (DescriptionTextBox.Text.Length != 0)
            {
                query += $"description='{DescriptionTextBox.Text}', ";
            }
            if (DurationTextBox.Text.Length != 0)
            {
                query += $"duration='{DurationTextBox.Text}', ";
            }
            if (PriceTextBox.Text.Length != 0)
            {
                query += $"price='{PriceTextBox.Text}', ";
            }
            query += $"idTeacher = {(TeacherComboBox.SelectedItem as ComboboxItem).Value} ";

            query += $"Where id={idCourse}";

            MySqlCommand command = new MySqlCommand(query, db.getConnection());
            MySqlCommand command2 = new MySqlCommand(query2, db.getConnection());


            db.openConnection();

            if (command.ExecuteNonQuery() == 1)
            {
                command2.ExecuteNonQuery();
            }
            else
            {
                MessageBox.Show("Ошибка");
            }

            db.closeConnection();

        }
        private void getLastIdList()
        {
            DB db = new DB();
            string queryInfo2 = $"select id from listofparticipant where idCourse = {idCourse}";
            MySqlCommand mySqlCommand2 = new MySqlCommand(queryInfo2, db.getConnection());

            db.openConnection();

            MySqlDataReader reader2 = mySqlCommand2.ExecuteReader();

            while (reader2.Read())
            {
                idListofparticipant = reader2["id"].ToString();
            }
            reader2.Close();

            db.closeConnection();
        }
        private void AddButton_Click(object sender, EventArgs e)
        {
            if (idCourse == null)
            {
                addCourse();
                new AddStudent(idListofparticipant, null).Show();
            }
            else
            {
                getLastIdList();
                new AddStudent(idListofparticipant, idCourse).Show();
                editCourse();
            }
            this.Hide();
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            if (idCourse == null)
            {
                this.Close();
            }
            else
            {
                new DetailedCourse(idCourse, idInfo).Show();
                this.Close();
            }
        }
    }
}
