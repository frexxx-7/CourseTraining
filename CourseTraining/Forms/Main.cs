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
    public partial class Main : Form
    {
        public string idInfo;
        public string idPost;
        public string post;

        public Main()
        {
            InitializeComponent();
        }

        private void Main_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
        public void loadInfoSupervisor()
        {
            if (post == "Руководитель")
            {
                DB db = new DB();
                string queryInfo = $"select users.login, users.password, supervisor.name, supervisor.surname, supervisor.patronymic from users " +
                    $"inner join supervisor on users.idSupervisor = supervisor.id where supervisor.id = '{idPost}'";
                MySqlCommand mySqlCommand = new MySqlCommand(queryInfo, db.getConnection());

                db.openConnection();

                MySqlDataReader reader = mySqlCommand.ExecuteReader();
                while (reader.Read())
                {
                    NameLabel.Text = reader["name"].ToString();
                    PatronymicLabel.Text = reader["patronymic"].ToString();
                    SurnameLabel.Text = reader["surname"].ToString();
                    LoginLabel.Text = reader["login"].ToString();
                }
                reader.Close();

                db.closeConnection();
            }
        }
        public void loadInfoTeacher()
        {
            if (post == "Преподаватель")
            {
                DB db = new DB();
                string queryInfo = $"select users.login, users.password, teacher.name, teacher.surname, teacher.patronymic, " +
                    $"teacher.education, teacher.experience, teacher.number_passport from users " +
                    $"inner join teacher on users.idTeacher = teacher.id where teacher.id = '{idPost}'";
                MySqlCommand mySqlCommand = new MySqlCommand(queryInfo, db.getConnection());

                db.openConnection();

                MySqlDataReader reader = mySqlCommand.ExecuteReader();
                while (reader.Read())
                {
                    NameLabel.Text = reader["name"].ToString();
                    PatronymicLabel.Text = reader["patronymic"].ToString();
                    SurnameLabel.Text = reader["surname"].ToString();
                    LoginLabel.Text = reader["login"].ToString();
                    EducationLabel.Text = reader["education"].ToString();
                    ExperienceLabel.Text = reader["experience"].ToString();
                    NumberPassportLabel.Text = reader["number_passport"].ToString();
                }
                reader.Close();

                db.closeConnection();
                TeacherPanel.Dock = DockStyle.Fill;
                TeacherPanel.Visible = true;
            }
        }

        public void loadInfoParticipant()
        {
            if (post == "Ученик")
            {
                DB db = new DB();
                string queryInfo = $"select users.login, users.password, participant.name, participant.surname, participant.patronymic, " +
                    $"participant.number_passport, participant.arrival_city from users " +
                    $"inner join participant on users.idParticipant = participant.id where participant.id = '{idPost}'";
                MySqlCommand mySqlCommand = new MySqlCommand(queryInfo, db.getConnection());

                db.openConnection();

                MySqlDataReader reader = mySqlCommand.ExecuteReader();
                while (reader.Read())
                {
                    NameLabel.Text = reader["name"].ToString();
                    PatronymicLabel.Text = reader["patronymic"].ToString();
                    SurnameLabel.Text = reader["surname"].ToString();
                    LoginLabel.Text = reader["login"].ToString();
                    NumberPassportParticipantLabel.Text = reader["number_passport"].ToString();
                    ArrivalCityLabel.Text = reader["arrival_city"].ToString();
                }
                reader.Close();

                db.closeConnection();
                ParticipantPanel.Dock = DockStyle.Fill;
                ParticipantPanel.Visible = true;
            }
        }

        private void Main_Load(object sender, EventArgs e)
        {
            DB db = new DB();
            string queryInfo = $"select idSupervisor, idParticipant, idTeacher from users where id = {idInfo}";

            MySqlCommand mySqlCommand = new MySqlCommand(queryInfo, db.getConnection());

            db.openConnection();

            MySqlDataReader reader = mySqlCommand.ExecuteReader();
            while (reader.Read())
            {
                if (reader["idParticipant"].ToString() != "")
                {
                    post = "Ученик";
                    idPost = reader["idParticipant"].ToString();
                }
                if (reader["idTeacher"].ToString() != "")
                {
                    post = "Преподаватель";
                    idPost = reader["idTeacher"].ToString();
                }

                if (reader["idSupervisor"].ToString() != "")
                {
                    post = "Руководитель";
                    idPost = reader["idSupervisor"].ToString();
                }
            }
            reader.Close();

            db.closeConnection();

            switch (post)
            {
                case "Руководитель": loadInfoSupervisor(); break;
                case "Преподаватель": loadInfoTeacher(); break;
                case "Ученик": loadInfoParticipant(); break;
                default:
                    break;
            }
            if (post == "Преподаватель")
            {
                просмотретьТестToolStripMenuItem.Visible = true;
            }

            if (post == "Руководитель")
            {
                добавитьКурсToolStripMenuItem.Visible = true;
                добавитьТестToolStripMenuItem.Visible = true;
                просмотретьТестToolStripMenuItem.Visible = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            new EditProfile(idInfo, idPost, post, this).Show();
        }

        private void добавитьКурсToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new AddCourse(null, idInfo).Show();
        }

        private void посмотретьКурсыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new CheckCourse(idPost).Show();

        }

        private void добавитьТестToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new Test().Show();
        }

        private void просмотретьТестToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new CheckTest(post).Show();
        }

        private void пройтиТестToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new PassingTest(idPost, post).Show();
        }
    }
}
