using CourseTraining.Classes;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace CourseTraining.Forms
{
    public partial class Test : Form
    {
        private int countPanel = 0;
        private int countQuestions = 1;
        public Test()
        {
            InitializeComponent();
        }

        private void Test_Load(object sender, EventArgs e)
        {
            DB db = new DB();

            string queryInfoCbb = $"SELECT id, name, description, duration FROM course";

            MySqlCommand mySqlCommandCbb = new MySqlCommand(queryInfoCbb, db.getConnection());

            db.openConnection();

            MySqlDataReader readerCbb = mySqlCommandCbb.ExecuteReader();
            while (readerCbb.Read())
            {
                ComboboxItem item = new ComboboxItem();
                item.Text = $" {readerCbb[1]} {readerCbb[3]} {readerCbb[2]}";
                item.Value = readerCbb[0];
                CourseComboBox.Items.Add(item);
            }
            readerCbb.Close();

            db.closeConnection();

            string pathFile = AppDomain.CurrentDomain.BaseDirectory + "dataTest.txt";

            using (StreamWriter writer = new StreamWriter(pathFile, false))
            {
                writer.Write("");
            }

        }

        private void AddQuestion_Click(object sender, EventArgs e)
        {
            QuestionPanel.Visible = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AOPanel.Visible = true;
            countPanel++;

            Panel panel = new Panel();
            panel.Name = $"panel{countPanel}";
            panel.Dock = DockStyle.Top;
            AOPanel.Controls.Add(panel);

            CheckBox checkbox = new CheckBox();
            checkbox.Name = $"checkbox{countPanel}";
            checkbox.Dock = DockStyle.Top;
            checkbox.Text = "Правильный ответ";
            panel.Controls.Add(checkbox);

            TextBox textbox = new TextBox();
            textbox.Name = $"textbox{countPanel}";
            textbox.Dock = DockStyle.Top;
            panel.Controls.Add(textbox);

        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            string pathFile = AppDomain.CurrentDomain.BaseDirectory + "dataTest.txt";

            using (StreamWriter writer = new StreamWriter(pathFile, true))
            {
                writer.WriteLine($"question|{countQuestions}|{QuestionTextBox.Text}|{CheckBoxAO.Checked}| ");
                for (int i = 1; i <= countPanel; i++)
                {
                    writer.WriteLine($"ao|{ this.Controls.Find($"textbox{i}", true)[0].Text }|{((CheckBox)this.Controls.Find($"checkbox{i}", true)[0]).Checked}");
                }
            }

            AOPanel.Visible = false;
            AOPanel.Controls.Clear();
            QuestionTextBox.Text = "";
            CheckBoxAO.Checked = false;
            countPanel= 0;
            countQuestions++;
            QuestionPanel.Visible = false;
        }

        private void SaveTestButton_Click(object sender, EventArgs e)
        {
            string filePath = AppDomain.CurrentDomain.BaseDirectory + "dataTest.txt";
            string fileContent = File.ReadAllText(filePath);

            DB db = new DB();

            MySqlCommand command = new MySqlCommand($"INSERT into test (name, idCourse, dataTest) " +
                $"values(@name, @idCourse, @dataTest)", db.getConnection());

            command.Parameters.AddWithValue("@name", NameTextBox.Text);
            command.Parameters.AddWithValue("@idCourse", (CourseComboBox.SelectedItem as ComboboxItem).Value);
            command.Parameters.AddWithValue("@dataTest", fileContent);


            db.openConnection();

            try
            {
                command.ExecuteNonQuery();
            }
            catch (Exception exep)
            {
                MessageBox.Show(exep.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
