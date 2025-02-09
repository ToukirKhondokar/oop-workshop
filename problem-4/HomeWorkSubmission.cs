
public class HomeWorkSubmission
{
    private string _studentId;
    public string SubmissionId { get => _studentId; set => _studentName = value; }
    private string _studentName;
    public string StudentName { get=>_studentName; set=>_studentName=value; }
    public Homework Homework { get; set; }
    public DateTime SubmissionDate { get; set; }

    public List <string>submit=new List<string>();

    public HomeWorkSubmission(string studentId, string studentName)
    {
        _studentId = studentId;
        _studentName = studentName;
    }


    

        public  void submittedHomework(string studentId, string studentName,List <string>HomeworkDone)
    {
        submit=HomeworkDone;
        // Student = new Student("223002070","Toukir Khondokar" );
        // Homework homework = new Homework();
        // Student.SubmittedHomework = submit;
        // return submittedHomework;

    }
}
