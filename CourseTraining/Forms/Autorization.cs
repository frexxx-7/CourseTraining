using CourseTraining.Classes;
using CourseTraining.Forms;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CourseTraining
{
    public partial class Autorization : Form
    {
        public Autorization()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            string loginUser = LoginTextBox.Text;
            string passUser = PasswordTextBox.Text;

            DB db = new DB();

            DataTable table = new DataTable();

            MySqlDataAdapter adapter = new MySqlDataAdapter();

            MySqlCommand command = new MySqlCommand("SELECT * FROM users WHERE login = @uL AND password = @uP", db.getConnection());
            command.Parameters.Add("@uL", MySqlDbType.VarChar).Value = loginUser;
            command.Parameters.Add("@uP", MySqlDbType.VarChar).Value = passUser;

            adapter.SelectCommand = command;
            adapter.Fill(table);

            if (table.Rows.Count > 0)
            {
                string queryAccount = $"SELECT id FROM users WHERE login = '{loginUser}'";
                MySqlCommand mySqlCommand = new MySqlCommand(queryAccount, db.getConnection());
                Main main = new Main();

                db.openConnection();
                main.idInfo = mySqlCommand.ExecuteScalar().ToString();

                db.closeConnection();


                this.Hide();
                main.Show();
            }
            else
            {
                MessageBox.Show("Неверный логин или пароль", "Ошибка");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Registration().Show();
        }
    }
}
