using CourseTraining.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CourseTraining
{
    public partial class PassTest : UserControl
    {
        private string idTest = null;
        private PassingTest ps;
        private string idPost = null;
        private string post = null;
        public PassTest(string nameTest, string nameCourse, string idTest, PassingTest ps, string idPost, string post)
        {
            InitializeComponent();
            TestLbl.Text = nameTest;
            CourseLbl.Text = nameCourse;
            this.idTest = idTest;
            this.ps = ps;
            this.idPost = idPost;
            this.post = post;
        }

        private void PassTest_Click(object sender, EventArgs e)
        {
            new PassingTheTest(idTest, idPost, post).Show();
            ps.Close();
        }
    }
}
