using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace StudentApp
{
    public partial class index : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void saveButton_Click(object sender, EventArgs e)
        {
            Student aStudent = new Student();
            aStudent.name = nameTextBox.Text;
            aStudent.email = emailTextBox.Text;
            aStudent.regNo = regNoTextBox.Text;
            if (ViewState["student"] != null)
            {
                List<Student> studentList = (List < Student >) ViewState["student"];
                if (studentList.Count < 3)
                {
                    studentList.Add(aStudent);
                }
                else
                {
                    Response.Write("3 student already exists<br/><br/>");
                }
                
            }
            else
            {
                List<Student> list = new List<Student>();
                list.Add(aStudent);
                ViewState["student"] = list;
            }
            
            
        }

        protected void showAllButton_Click(object sender, EventArgs e)
        {
            //Student aStudent = (Student)ViewState["student"];
            //Response.Write(aStudent.GetInfo());
            List<Student> studentList = (List<Student>) ViewState["student"];
            foreach (Student student in studentList)
            {
                Response.Write(student.GetInfo()+"<br/>");
            }
            Response.Write("</br><br/>");
        }
    }
}