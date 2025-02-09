public class Teacher
{
    private string _teacherId;
    public string TeacherId { get => _teacherId; set => _teacherId = value; }
    private string _teacherName;
    public string TeacherName { get => _teacherName; set => _teacherName = value; }





    public void CreateHomework(string title, DateTime dueDate, List<string> list)
    {

        Homework homework = new Homework(title, dueDate, list);


    }

}