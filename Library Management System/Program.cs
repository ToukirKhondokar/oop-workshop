public class Program
{
    static void Main()
    {
        try
        {
            
        

        ManagementSystem managementSystem = new ManagementSystem();
        managementSystem.AddBook(new Book("The Great Gatsby", "F. Scott Fitzgerald", "Available", 1234567890,"223"));
        managementSystem.AddBook(new Book("To Kill a Mockingbird", "Harper Lee", "Available", 1234567890,"222"));
        managementSystem.AddBook(new Book("1984", "George Orwell", "Available", 1234567890,"221"));

        
        var BorrowBook=managementSystem.BorrowBook(new Member("John Doe", "1234567890", "john.doe@example.com", "1234567890"), new Book("The Great Gatsby", "F. Scott Fitzgerald", "Available", 1234567890,"223"));
        Console.WriteLine(BorrowBook.ToString());

        var ReturnBook=managementSystem.ReturnBook(new Member("John Doe", "1234567890", "john.doe@example.com", "1234567890"), new Book("The Great Gatsby", "F. Scott Fitzgerald", "Available", 1234567890,"223"));
        Console.WriteLine(ReturnBook.ToString());
        
        managementSystem.checkDueDate();



        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
        }


    }
}


