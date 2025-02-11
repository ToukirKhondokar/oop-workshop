public class Book
{
    private string? _bookTitle;
    public string? BookTitle { get => _bookTitle; set => _bookTitle = value; }

    private string? _bookId;
    public string? BookId { get => _bookId; set => _bookId = value; }
    private string? _author;
    public string? Author { get => _author; set => _author = value; }
    //private string? _availability;
    public BookStatus Availability { get; set; } = BookStatus.Available;
    private int _isbn;
    public int Isbn { get => _isbn; set => _isbn = value; }

    public Book(string bookTitle, string author, string availability, int isbn, string bookId)
    {
        BookId = bookId;
        BookTitle = bookTitle;
        Author = author;
        Availability = BookStatus.Available;
        Isbn = isbn;
    }

}
