using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace Console_App_Project
{
    public class StudentManager
    {
        private Dictionary<string, Student> students = new Dictionary<string, Student>();

        public void AddStudent (Student student)
        {
            if (students.ContainsKey("ST-101"))
            {
                throw new Exception("This ID already exits");
            }

            students["ST-102"] = student;
        }
    }
}
