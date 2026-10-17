using System;
using System.Collections.Generic;
using System.Text;

namespace Console_App_Project
{
    public class Student
    {
        public string Name { get; set; }
        public string ID { get; set; }
        public double Marks { get; private set; }

        public Student (string name,string id,double marks)
        {
            Name = name;
            ID = id;
            Marks = marks;
        }

        public void UpdateMarks(double marks)
        {
            
                if (marks < 0 || marks > 100)
                {
                   throw new Exception ("Invalid marks");
                }
                else
                {
                    Marks = marks;
                }
            }

        public void ShowInfo()
        {
            Console.WriteLine($"Name : {Name} | ID : {ID} | Marks : {Marks}");
        }
    }
}
