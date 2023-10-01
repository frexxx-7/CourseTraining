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
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using static System.Net.Mime.MediaTypeNames;
using static System.Windows.Forms.LinkLabel;

namespace CourseTraining.Forms
{
    public partial class DetailedTest : Form
    {
        private string nameTest;
        private int countPanel = 0;
        private string idTest;
        private int numberQuestion = 1;
        private int countQuestion = 0;
        public DetailedTest(string nameTest, string idTest)
        {
            InitializeComponent();
            this.nameTest = nameTest;
            this.idTest = idTest;
        }

        private void DetailedTest_Load(object sender, EventArgs e)
        {
            DB db = new DB();
            string queryInfo = $"select name, dataTest from test where name = '{nameTest}'";
            MySqlCommand mySqlCommand = new MySqlCommand(queryInfo, db.getConnection());

            db.openConnection();

            MySqlDataReader reader = mySqlCommand.ExecuteReader();
            string pathFile = AppDomain.CurrentDomain.BaseDirectory + "dataTest.txt";
            string pathFile2 = AppDomain.CurrentDomain.BaseDirectory + "editTest.txt";
            File.WriteAllText(pathFile, string.Empty);
            File.WriteAllText(pathFile2, string.Empty);
            using (StreamWriter writer = new StreamWriter(pathFile, true))
            {
                while (reader.Read())
                {
                    QuestionNameText.Text = reader[0].ToString();
                    writer.WriteLine(reader.GetString(reader.GetOrdinal("dataTest")));
                }
            }
            reader.Close();
            db.closeConnection();
            string[] lines = File.ReadAllLines(pathFile);

            bool isGenerate = true;
            foreach (string line in lines)
            {
                if (line.Length != 0)
                {
                    string[] parts = line.Split('|');
                    if (parts[0] == "question")
                    {
                        countQuestion++;
                        if (numberQuestion.ToString() == parts[1])
                        {
                            TextBox textbox = new TextBox();
                            textbox.Name = $"textboxQuest{numberQuestion}";
                            textbox.Text = parts[2];
                            textbox.Dock = DockStyle.Top;
                            QuestionNamePanel.Controls.Add(textbox);
                            if (parts[3] == "True")
                            {
                                CheckBoxAO.Checked = true;
                            }
                        }
                        else
                        {
                            isGenerate = false;
                            continue;
                        }
                    }
                    else
                    {
                        if (isGenerate)
                        {
                            countPanel++;
                            CheckBox checkbox = new CheckBox();
                            checkbox.Name = $"checkbox{countPanel}";
                            checkbox.Dock = DockStyle.Top;
                            checkbox.Checked = bool.Parse(parts[2]);
                            checkbox.Text = "Правильный ответ";
                            AOPanel.Controls.Add(checkbox);

                            TextBox textbox = new TextBox();
                            textbox.Name = $"textbox{countPanel}";
                            textbox.Text = parts[1];
                            textbox.Dock = DockStyle.Top;
                            AOPanel.Controls.Add(textbox);
                        }
                    }
                }
            }
        }

        private void loadQuestion()
        {
            QuestionNamePanel.Controls.Clear(); 
            AOPanel.Controls.Clear();

            countPanel = 0;

            string pathFile = AppDomain.CurrentDomain.BaseDirectory + "dataTest.txt";
            string[] lines = File.ReadAllLines(pathFile);
            bool isGenerate = false;
            foreach (string line in lines)
            {
                if (line.Length != 0)
                {
                    string[] parts = line.Split('|');
                    if (parts[0] == "question")
                    {
                        if (numberQuestion.ToString() == parts[1])
                        {
                            TextBox textbox = new TextBox();
                            textbox.Name = $"textboxQuest{numberQuestion}";
                            textbox.Text = parts[2];
                            textbox.Dock = DockStyle.Top;
                            QuestionNamePanel.Controls.Add(textbox);
                            if (parts[3] == "True")
                            {
                                CheckBoxAO.Checked = true;
                            }
                            isGenerate = true;
                        }
                        else
                        {
                            isGenerate = false;
                        }
                    }
                    else
                    {
                        if (isGenerate)
                        {
                            countPanel++;
                            CheckBox checkbox = new CheckBox();
                            checkbox.Name = $"checkbox{countPanel}";
                            checkbox.Dock = DockStyle.Top;
                            checkbox.Checked = bool.Parse(parts[2]);
                            checkbox.Text = "Правильный ответ";
                            AOPanel.Controls.Add(checkbox);

                            TextBox textbox = new TextBox();
                            textbox.Name = $"textbox{countPanel}";
                            textbox.Text = parts[1];
                            textbox.Dock = DockStyle.Top;
                            AOPanel.Controls.Add(textbox);
                        }
                    }
                }
            }
        }
        private void saveQuestion()
        {
            string pathFile = AppDomain.CurrentDomain.BaseDirectory + "editTest.txt";

            using (StreamWriter writer = new StreamWriter(pathFile, true))
            {
                    writer.WriteLine($"question|{numberQuestion}|{this.Controls.Find($"textboxQuest{numberQuestion}", true)[0].Text}|{CheckBoxAO.Checked}|");
                    for (int j = 1; j <= countPanel; j++)
                    {
                        writer.WriteLine($"ao|{this.Controls.Find($"textbox{j}", true)[0].Text}|{((CheckBox)this.Controls.Find($"checkbox{j}", true)[0]).Checked}");
                    }

            }
        }
        
        private void EditButton_Click(object sender, EventArgs e)
        {
            string pathFile = AppDomain.CurrentDomain.BaseDirectory + "editTest.txt";
            using (StreamWriter writer = new StreamWriter(pathFile, true))
            {
                    writer.WriteLine($"question|{numberQuestion}|{this.Controls.Find($"textboxQuest{numberQuestion}", true)[0].Text}|{CheckBoxAO.Checked}|");
                    for (int j = 1; j <= countPanel; j++)
                    {
                        writer.WriteLine($"ao|{this.Controls.Find($"textbox{j}", true)[0].Text}|{((CheckBox)this.Controls.Find($"checkbox{j}", true)[0]).Checked}");
                    }

            }
            string fileContent = File.ReadAllText(pathFile);

            DB db = new DB();
            string nameTest = QuestionNameText.Text;
            MySqlCommand command = new MySqlCommand($"UPDATE test set name = '{nameTest}', dataTest = '{fileContent}' WHERE id = {idTest}", db.getConnection());
            db.openConnection();

            try
            {
                command.ExecuteNonQuery();
            }
            catch (Exception exep)
            {
                MessageBox.Show(exep.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            db.closeConnection();
        }

        private void NextButton_Click(object sender, EventArgs e)
        {
            saveQuestion();
            numberQuestion++;
            loadQuestion();
            if (numberQuestion==countQuestion) 
            {
                NextButton.Visible = false;
            }
        }
    }
}
