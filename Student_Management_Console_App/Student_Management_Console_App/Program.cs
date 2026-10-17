
using Console_App_Project;

Student student = new Student("Rishan", "SI-101", 95);
student.ShowInfo();
try
{
    student.UpdateMarks(85);
}
catch(Exception ex)
{
    Console.WriteLine(ex.Message);
}
student.ShowInfo();
