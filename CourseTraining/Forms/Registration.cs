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
    public partial class Registration : Form
    {
        string post = null;
        string idLine = null;
        public Registration()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (PasswordTextBox.Text != RepeatPasswordTextBox.Text)
            {
                MessageBox.Show("Пароли не совпадают");
            }
            else
            {
                DB db = new DB();
                MySqlCommand command = new MySqlCommand("INSERT INTO users (login, password, idParticipant, idTeacher, idSupervisor) " +
                "VALUES (@login, @password, @idParticipant, @idTeacher, @idSupervisor)", db.getConnection());

                command.Parameters.Add("@login", MySqlDbType.VarChar).Value = LoginTextBox.Text;
                command.Parameters.Add("@password", MySqlDbType.VarChar).Value = PasswordTextBox.Text;

                switch (post)
                {
                    case "Ученик":
                        string query1 = "insert into participant(name) values (\"\")";
                        MySqlCommand command1 = new MySqlCommand(query1, db.getConnection());
                        db.openConnection();
                        command1.ExecuteNonQuery();
                        db.closeConnection();
                        string queryIdLine1 = $"SELECT id FROM participant WHERE (id = LAST_INSERT_ID())";
                        MySqlCommand commandIdLine1 = new MySqlCommand(queryIdLine1, db.getConnection());
                        db.openConnection();
                        MySqlDataReader reader1 = commandIdLine1.ExecuteReader();
                        while (reader1.Read())
                        {
                            idLine = reader1[0].ToString();
                        }
                        reader1.Close();
                        db.closeConnection();
                        command.Parameters.Add("@idParticipant", MySqlDbType.Int32).Value = idLine;
                        command.Parameters.Add("@idTeacher", MySqlDbType.Int32).Value = null;
                        command.Parameters.Add("@idSupervisor", MySqlDbType.Int32).Value = null;

                        break;
                    case "Преподаватель":
                        string query2 = "insert into teacher(name) values (\"\")";
                        MySqlCommand command2 = new MySqlCommand(query2, db.getConnection());
                        db.openConnection();
                        command2.ExecuteNonQuery();
                        db.closeConnection();
                        string queryIdLine2 = $"SELECT id FROM teacher WHERE (id = LAST_INSERT_ID())";
                        MySqlCommand commandIdLine2 = new MySqlCommand(queryIdLine2, db.getConnection());
                        db.openConnection();
                        MySqlDataReader reader2 = commandIdLine2.ExecuteReader();
                        while (reader2.Read())
                        {
                            idLine = reader2[0].ToString();
                        }
                        reader2.Close();
                        db.closeConnection();
                        command.Parameters.Add("@idTeacher", MySqlDbType.Int32).Value = idLine;
                        command.Parameters.Add("@idParticipant", MySqlDbType.Int32).Value = null;
                        command.Parameters.Add("@idSupervisor", MySqlDbType.Int32).Value = null;

                        break;
                    case "Руководитель":
                        string query3 = "insert into supervisor(name) values (\"\")";
                        MySqlCommand command3 = new MySqlCommand(query3, db.getConnection());
                        db.openConnection();
                        command3.ExecuteNonQuery();
                        db.closeConnection();
                        string queryIdLine3 = $"SELECT id FROM supervisor WHERE (id = LAST_INSERT_ID())";
                        MySqlCommand commandIdLine3 = new MySqlCommand(queryIdLine3, db.getConnection());
                        db.openConnection();
                        MySqlDataReader reader3 = commandIdLine3.ExecuteReader();
                        while (reader3.Read())
                        {
                            idLine = reader3[0].ToString();
                        }
                        reader3.Close();
                        db.closeConnection();
                        command.Parameters.Add("@idSupervisor", MySqlDbType.Int32).Value = idLine;
                        command.Parameters.Add("@idTeacher", MySqlDbType.Int32).Value = null;
                        command.Parameters.Add("@idParticipant", MySqlDbType.Int32).Value = null;
                        break;
                    default:
                        break;
                }


                db.openConnection();

                if (command.ExecuteNonQuery() == 1)
                {
                    MessageBox.Show("Аккаунт создан!");
                    this.Hide();
                    new Autorization().Show();
                }
                else
                {
                    MessageBox.Show("Ошибка создания аккаунта");
                }

                db.closeConnection();
            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            post = "Ученик";
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            post = "Преподаватель";
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            post = "Руководитель";
        }

        private void Registration_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
