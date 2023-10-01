using CourseTraining.Classes;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;
using CheckBox = System.Windows.Forms.CheckBox;

namespace CourseTraining.Forms
{
    public partial class PassingTheTest : Form
    {
        private string idTest = null;
        private string idPost = null;
        private string post = null;
        private int numberQuestion = 1;
        private int countQuestion = 0;
        private int countPanel = 0;
        private int result = 0;

        public PassingTheTest(string idTest, string idPost, string post)
        {
            InitializeComponent();
            this.idTest = idTest;
            this.idPost = idPost;
            this.post = post;
        }

        private void PassingTheTest_Load(object sender, EventArgs e)
        {
            string pathFile = AppDomain.CurrentDomain.BaseDirectory + "dataTest.txt";

            using (StreamWriter writer = new StreamWriter(pathFile, false))
            {
                writer.Write("");
            }
            DB db = new DB();

            string queryInfo = $"select * from test where test.id = {idTest}";

            MySqlCommand mySqlCommand = new MySqlCommand(queryInfo, db.getConnection());

            db.openConnection();

            MySqlDataReader reader = mySqlCommand.ExecuteReader();
            using (StreamWriter writer = new StreamWriter(pathFile, true))
            {
                while (reader.Read())
                {
                    NameLabel.Text = reader["name"].ToString();

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
                            Label label = new Label();
                            label.Name = $"textboxQuest{numberQuestion}";
                            label.Text = parts[2];
                            label.Dock = DockStyle.Top;
                            QuestionNamePanel.Controls.Add(label);
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
                            if (bool.Parse(parts[2]))
                            {
                                countPanel++;
                                CheckBox checkbox = new CheckBox();
                                checkbox.Name = $"checkboxTrue{countPanel}";
                                checkbox.Dock = DockStyle.Top;
                                checkbox.Text = parts[1];
                                AOPanel.Controls.Add(checkbox);
                            }
                            if (bool.Parse(parts[2]) == false)
                            {
                                countPanel++;
                                CheckBox checkbox = new CheckBox();
                                checkbox.Name = $"checkboxFalse{countPanel}";
                                checkbox.Dock = DockStyle.Top;
                                checkbox.Text = parts[1];
                                AOPanel.Controls.Add(checkbox);
                            }
                        }
                    }
                }
            }
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            new PassingTest(idPost, post).Show();
            this.Close();
        }

        private void NextButton_Click(object sender, EventArgs e)
        {
            numberQuestion++;
            checkRes(countPanel);
            loadQuestion();
            if (numberQuestion == countQuestion)
            {
                NextButton.Visible = false;
                CheckButton.Visible = true;
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
                            Label label = new Label();
                            label.Name = $"textboxQuest{numberQuestion}";
                            label.Text = parts[2];
                            label.Dock = DockStyle.Top;
                            QuestionNamePanel.Controls.Add(label);

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
                            if (bool.Parse(parts[2]))
                            {
                                countPanel++;
                                CheckBox checkbox = new CheckBox();
                                checkbox.Name = $"checkboxTrue{countPanel}";
                                checkbox.Dock = DockStyle.Top;
                                checkbox.Text = parts[1];
                                AOPanel.Controls.Add(checkbox);
                            }
                            if (bool.Parse(parts[2]) == false)
                            {
                                countPanel++;
                                CheckBox checkbox = new CheckBox();
                                checkbox.Name = $"checkboxFalse{countPanel}";
                                checkbox.Dock = DockStyle.Top;
                                checkbox.Text = parts[1];
                                AOPanel.Controls.Add(checkbox);
                            }
                        }
                    }
                }
            }
        }
        private int checkRes(int countPane)
        {
            bool check;
            for (int i = 1; i <= countPane; i++)
            {
                if (this.Controls.Find($"checkboxTrue{i}", true).Length != 0)
                {
                    check = ((CheckBox)this.Controls.Find($"checkboxTrue{i}", true)[0]).Checked;
                    if (check)
                    {
                        result++;
                    }
                }
            }
            return result;
        }

        private void CheckButton_Click(object sender, EventArgs e)
        {
            label3.Visible = true;
            ResLbl.Text = checkRes(countPanel).ToString();
        }
    }
}
