public class Student
{
    private string _studentId;
    public string StudentId { get => _studentId; set => _studentId = value; }

    private string _studentName;
    public string StudentName { get => _studentName; set => _studentName = value; }

    public List<string> SubmittedHomework = new List<string>()
    {
        "10 maths done",
        "Assingment done",
    };

    public Student()
    {

    }
    public Student(string StudentId, string StudentName)
    {
        StudentId = StudentId;
        StudentName = StudentName;
    }

}


