using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace StudentApp
{
    [Serializable]
    public class Student
    {
        public string name;
        public string email;
        public string regNo;

        public string GetInfo( )
        {
            return "Name is : " + name + "; Email is: " + email + ";Reg No is : " + regNo+" \n Last of all Welcome to all";
        }
    }
}