public class Program
{
    public static void Main()
    {
        try
        {
            
        

        ManagementSystem managementSystem = new ManagementSystem();
        managementSystem.AddBook(new Book("The Great Gatsby", "F. Scott Fitzgerald", "Available", 1234567890));
        managementSystem.AddBook(new Book("To Kill a Mockingbird", "Harper Lee", "Available", 1234567890));
        managementSystem.AddBook(new Book("1984", "George Orwell", "Available", 1234567890));

        managementSystem.BorrowBook(new Member("John Doe", "1234567890", "john.doe@example.com", "1234567890"), new Book("The Great Gatsby", "F. Scott Fitzgerald", "Available", 1234567890));
        managementSystem.ReturnBook(new Member("John Doe", "1234567890", "john.doe@example.com", "1234567890"), new Book("The Great Gatsby", "F. Scott Fitzgerald", "Available", 1234567890));
        managementSystem.checkDueDate();
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
        }


    }
}


