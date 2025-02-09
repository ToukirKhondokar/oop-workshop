public class Homework
{
    private string _homeworkId;
    public string HomeworkId { get => _homeworkId; set => _homeworkId = value; }
    private string _homeworkTitle;

    public string HomeworkTitle { get => _homeworkTitle; set => _homeworkTitle = value; }
    private DateTime _duedate;
    public DateTime DeuDate { get => _duedate; set => _duedate = value; }

    public List<string> Task = new List<string>();

    public Homework()
    {

    }

    public Homework(string title, DateTime dueDate, List<string> tasks)
    {
        HomeworkTitle = title;
        DeuDate = dueDate;
        Task = tasks;
    }
}