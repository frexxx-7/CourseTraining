using CourseTraining.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CourseTraining
{
    public partial class CourseCheck : UserControl
    {
        private string idCourse;
        private CheckCourse cc;
        public CourseCheck(string name, string description, string duration, string price, string idCourse, CheckCourse cc)
        {
            InitializeComponent();
            this.name.Text = name;
            this.description.Text = description;
            this.duration.Text = duration;
            this.price.Text = price;
            this.idCourse = idCourse;
            this.cc = cc;
        }

        private void CourseCheck_Click(object sender, EventArgs e)
        {
            new DetailedCourse(idCourse, cc.idInfo).Show();
            cc.Close();
        }
    }
}
