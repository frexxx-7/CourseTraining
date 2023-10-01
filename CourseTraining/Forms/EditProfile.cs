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
using System.Xml;

namespace CourseTraining.Forms
{
    public partial class EditProfile : Form
    {
        private string idInfo;
        private string idPost;
        private string post;
        private Main main;
        public EditProfile(string idInfo, string idPost, string post, Main main)
        {
            InitializeComponent();
            this.idInfo = idInfo;
            this.idPost = idPost;
            this.post = post;
            this.main = main;
        }
        private void editSupervisor()
        {
            if (post == "Руководитель")
            {
                DB db = new DB();
                string query = "Update supervisor set ";
                if (NameTextBox.Text.Length != 0)
                {
                    query += $"name='{NameTextBox.Text}', ";
                }
                if (SurnameTextBox.Text.Length != 0)
                {
                    query += $"surname='{SurnameTextBox.Text}', ";
                }
                if (PatronymicTextBox.Text.Length != 0)
                {
                    query += $"patronymic='{PatronymicTextBox.Text}', ";
                }
                if (query != "Update supervisor set ")
                {
                    query = query.Remove(query.Length - 2);
                    query += " ";
                }
                query += $"Where id={idPost}";

                MySqlCommand command = new MySqlCommand(query, db.getConnection());


                db.openConnection();

                if (command.ExecuteNonQuery() == 1)
                {
                }
                else
                {
                    MessageBox.Show("Ошибка");
                }

                db.closeConnection();
            } 
        }
        private void editTeacher()
        {
            if (post == "Преподаватель")
            {
                DB db = new DB();
                string query = "Update teacher set ";
                if (NameTextBox.Text.Length != 0)
                {
                    query += $"name='{NameTextBox.Text}', ";
                }
                if (SurnameTextBox.Text.Length != 0)
                {
                    query += $"surname='{SurnameTextBox.Text}', ";
                }
                if (PatronymicTextBox.Text.Length != 0)
                {
                    query += $"patronymic='{PatronymicTextBox.Text}', ";
                }
                if (EducationTextBox.Text.Length != 0)
                {
                    query += $"education='{EducationTextBox.Text}', ";
                }
                if (ExperienceTextBox.Text.Length != 0)
                {
                    query += $"experience='{ExperienceTextBox.Text}', ";
                }
                if (NumberPassportTextBox.Text.Length != 0)
                {
                    query += $"number_passport='{NumberPassportTextBox.Text}', ";
                }
                if (query != "Update teacher set ")
                {
                    query = query.Remove(query.Length - 2);
                    query += " ";
                }
                query += $"Where id={idPost}";

                MySqlCommand command = new MySqlCommand(query, db.getConnection());


                db.openConnection();

                if (command.ExecuteNonQuery() == 1)
                {
                }
                else
                {
                    MessageBox.Show("Ошибка");
                }

                db.closeConnection();
            }
        }
        private void editParticipant()
        {
            if (post == "Ученик")
            {
                DB db = new DB();
                string query = "Update participant set ";
                if (NameTextBox.Text.Length != 0)
                {
                    query += $"name='{NameTextBox.Text}', ";
                }
                if (SurnameTextBox.Text.Length != 0)
                {
                    query += $"surname='{SurnameTextBox.Text}', ";
                }
                if (PatronymicTextBox.Text.Length != 0)
                {
                    query += $"patronymic='{PatronymicTextBox.Text}', ";
                }
                if (NumberPassportParticipantTextBox.Text.Length != 0)
                {
                    query += $"number_passport='{NumberPassportParticipantTextBox.Text}', ";
                }
                if (ArrivalCityTextBox.Text.Length != 0)
                {
                    query += $"arrival_city='{ArrivalCityTextBox.Text}', ";
                }
                if (query != "Update participant set ")
                {
                    query = query.Remove(query.Length - 2);
                    query += " ";
                }
                query += $"Where id={idPost}";

                MySqlCommand command = new MySqlCommand(query, db.getConnection());


                db.openConnection();

                if (command.ExecuteNonQuery() == 1)
                {
                }
                else
                {
                    MessageBox.Show("Ошибка");
                }

                db.closeConnection();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            switch (post)
            {
                case "Руководитель": editSupervisor(); break;
                case "Преподаватель": editTeacher(); break;
                case "Ученик": editParticipant(); break;
                default:
                    break;
            }
            DB db = new DB();

            string queryUser = "Update users set ";
            if (LoginTextBox.Text.Length != 0)
            {
                queryUser += $"login='{LoginTextBox.Text}', ";
            }
            if (SurnameTextBox.Text.Length != 0)
            {
                queryUser += $"password='{PasswordTextBox.Text}', ";
            }
            if (queryUser != "Update supervisor set ")
            {
                queryUser = queryUser.Remove(queryUser.Length - 2);
                queryUser += " ";
            }
            queryUser += $"Where id={idInfo}";
            MySqlCommand commandUser = new MySqlCommand(queryUser, db.getConnection());


            db.openConnection();

            if (commandUser.ExecuteNonQuery() == 1)
            {
                MessageBox.Show("Профиль изменен");
                this.Close();
            }
            else
            {
                MessageBox.Show("Ошибка");
            }

            switch (post)
            {
                case "Руководитель": main.loadInfoSupervisor(); break;
                case "Преподаватель": main.loadInfoTeacher(); break;
                case "Ученик": main.loadInfoParticipant(); break;
                default:
                    break;
            }
        }
        private void loadInfoSupervisor()
        {
            if (post == "Руководитель")
            {
                DB db = new DB();
                string queryInfo = $"select users.login, users.password, supervisor.name, supervisor.surname, supervisor.patronymic from users " +
                    $"inner join supervisor on users.idSupervisor = supervisor.id";
                MySqlCommand mySqlCommand = new MySqlCommand(queryInfo, db.getConnection());

                db.openConnection();

                MySqlDataReader reader = mySqlCommand.ExecuteReader();
                while (reader.Read())
                {
                    NameTextBox.Text = reader["name"].ToString();
                    PatronymicTextBox.Text = reader["patronymic"].ToString();
                    SurnameTextBox.Text = reader["surname"].ToString();
                    LoginTextBox.Text = reader["login"].ToString();
                    PasswordTextBox.Text = reader["password"].ToString();
                }
                reader.Close();

                db.closeConnection();
            }
        }
        private void loadInfoTeacher()
        {
            if (post == "Преподаватель")
            {
                DB db = new DB();
                string queryInfo = $"select users.login, users.password, teacher.name, teacher.surname, teacher.patronymic, " +
                    $"teacher.education, teacher.experience, teacher.number_passport from users " +
                    $"inner join teacher on users.idTeacher = teacher.id";
                MySqlCommand mySqlCommand = new MySqlCommand(queryInfo, db.getConnection());

                db.openConnection();

                MySqlDataReader reader = mySqlCommand.ExecuteReader();
                while (reader.Read())
                {
                    NameTextBox.Text = reader["name"].ToString();
                    PatronymicTextBox.Text = reader["patronymic"].ToString();
                    SurnameTextBox.Text = reader["surname"].ToString();
                    LoginTextBox.Text = reader["login"].ToString();
                    PasswordTextBox.Text = reader["password"].ToString();
                    EducationTextBox.Text = reader["education"].ToString();
                    ExperienceTextBox.Text = reader["experience"].ToString();
                    NumberPassportTextBox.Text = reader["number_passport"].ToString();
                }
                reader.Close();

                db.closeConnection();
                TeacherPanel.Dock = DockStyle.Fill;
                TeacherPanel.Visible = true;
            }
        }

        private void loadInfoParticipant()
        {
            if (post == "Ученик")
            {
                DB db = new DB();
                string queryInfo = $"select users.login, users.password, participant.name, participant.surname, participant.patronymic, " +
                    $"participant.number_passport, participant.arrival_city from users " +
                    $"inner join participant on users.idParticipant = participant.id";
                MySqlCommand mySqlCommand = new MySqlCommand(queryInfo, db.getConnection());

                db.openConnection();

                MySqlDataReader reader = mySqlCommand.ExecuteReader();
                while (reader.Read())
                {
                    NameTextBox.Text = reader["name"].ToString();
                    PatronymicTextBox.Text = reader["patronymic"].ToString();
                    SurnameTextBox.Text = reader["surname"].ToString();
                    LoginTextBox.Text = reader["login"].ToString();
                    PasswordTextBox.Text = reader["password"].ToString();
                    NumberPassportParticipantTextBox.Text = reader["number_passport"].ToString();
                    ArrivalCityTextBox.Text = reader["arrival_city"].ToString();
                }
                reader.Close();

                db.closeConnection();
                ParticipantPanel.Dock = DockStyle.Fill;
                ParticipantPanel.Visible = true;
            }
        }

        private void EditProfile_Load(object sender, EventArgs e)
        {
            switch (post)
            {
                case "Руководитель": loadInfoSupervisor(); break;
                case "Преподаватель": loadInfoTeacher(); break;
                case "Ученик": loadInfoParticipant(); break;
                default:
                    break;
            }
            
        }
    }
}
