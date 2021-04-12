using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Demo
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //Lambda Expression

            //IEnumerable<Student> students = Student.GetAllStudents().Where(student => student.Gender == "Male");
            //GridView1.DataSource = students;
            //GridView1.DataBind();

            //SQL Query Operator
            IEnumerable<Student> students = from student in Student.GetAllStudents()
                                            where student.Gender == "Male"
                                            select student;
            GridView1.DataSource = students;
            GridView1.DataBind();
        }
    }
}