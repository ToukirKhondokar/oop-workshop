public class Program
{
    static void Main()
     {
        Teacher teacher = new Teacher();
        DateTime dateTime = new DateTime(2025, 2, 17);
        List<string> list = new List<string>{
        "create 10 math",
        "dont use the calculator",
     };
        teacher.CreateHomework("math question 1", dateTime, list);

        Student student = new Student("223002070", "Toukir Khondokar");
        List<string> HomeworkDone = new List<string>{
            "solution of the 10 math problems",
            "i dont use the calculator",
        };
        HomeWorkSubmission StudentSubmitHomework = new HomeWorkSubmission("223002070", "Toukir Khondokar");
        StudentSubmitHomework.submittedHomework("223002070", "Toukir Khondokar", HomeworkDone);



    }



 }
