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
    public partial class CheckTest : Form
    {
        public string post = null;
        public string idTest = null;
        public CheckTest(string post)
        {
            this.post = post;
            InitializeComponent();
        }

        private void CheckTest_Load(object sender, EventArgs e)
        {
            GenerateDynamicTestControls();
        }

        public void GenerateDynamicTestControls()
        {
            flowLayoutPanel1.Controls.Clear();
            DB db = new DB();
            string queryInfo = $"SELECT test.id, test.name, course.name FROM test Inner join course ON test.idCourse = course.id";
            MySqlCommand mySqlCommand = new MySqlCommand(queryInfo, db.getConnection());

            db.openConnection();

            MySqlDataReader reader = mySqlCommand.ExecuteReader();
            int panelNumber = 0;

            List<TestCheck> listItems = new List<TestCheck>();
            while (reader.Read())
            {
                idTest = reader[0].ToString();
                listItems.Add(new TestCheck(reader[1].ToString(), reader[2].ToString(), post, this));
                flowLayoutPanel1.Controls.Add(listItems[panelNumber]);
                panelNumber++;

            }
            reader.Close();

            db.closeConnection();
        }
    }
}
