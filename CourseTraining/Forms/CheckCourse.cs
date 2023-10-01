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
    public partial class CheckCourse : Form
    {
        public string idInfo;
        public CheckCourse(string idInfo)
        {
            InitializeComponent();
            this.idInfo = idInfo;
        }

        private void CheckCourse_Load(object sender, EventArgs e)
        {
            GenerateDynamicCourseControls();
        }

        private void GenerateDynamicCourseControls()
        {
            flowLayoutPanel1.Controls.Clear();
            DB db = new DB();
            string queryInfo = $"SELECT * FROM course ";
            MySqlCommand mySqlCommand = new MySqlCommand(queryInfo, db.getConnection());

            db.openConnection();

            MySqlDataReader reader = mySqlCommand.ExecuteReader();
            int panelNumber = 0;

            List<CourseCheck> listItems = new List<CourseCheck>();
            while (reader.Read())
            {
                listItems.Add(new CourseCheck(reader["name"].ToString(), reader["description"].ToString(), reader["duration"].ToString(),
                    reader["price"].ToString(), reader["id"].ToString(), this));
                flowLayoutPanel1.Controls.Add(listItems[panelNumber]);
                panelNumber++;

            }
            reader.Close();

            db.closeConnection();
        }
    }
}
