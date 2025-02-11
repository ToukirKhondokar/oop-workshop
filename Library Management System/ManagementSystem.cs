public class ManagementSystem
{
    private List<Book> _books = new List<Book>();

    private List<Member> _members = new List<Member>();

    public List<Loan> _loans = new List<Loan>();

    public void AddMember(Member member)
    {
        _members.Add(member);
    }



    public void AddBook(Book book)
    {
        if (book == null) throw new Exception("Book cannot be null ");

        if (_books.Any(b => b.BookId == book.BookId)) throw new Exception("Book already exists");

        _books.Add(book);
    }

    public string BorrowBook(Member member, Book book)
    {
        if (member == null) throw new Exception("Member cannot be null ");

        if (book == null) throw new Exception("Book cannot be null ");

        if (book.Availability == BookStatus.Borrowed) throw new Exception("Book is already borrowed");

        if (!_books.Any(b => b.BookId == book.BookId)) throw new Exception("Book not found");


        if (book.Availability == BookStatus.Borrowed) throw new Exception("Book is already borrowed");


        book.Availability = BookStatus.Borrowed;

        _loans.Add(new Loan(member.MemberId ?? "", book.BookId ?? "", DateTime.Now));
        // var borrow="Book borrow by {}";
        return $"Book borrow by {member.MemberName}";

    }


    public string ReturnBook(Member member, Book book)
    {
        var loan = _loans.FirstOrDefault(l => l.MemberId == member.MemberId && l.BookId == book.BookId);
        if (loan != null)
        {
            book.Availability = BookStatus.Available;
            _loans.Remove(loan);
        }
        else
        {
            throw new Exception("Book not borrowed by this Member");
        }
        return $"{member.MemberName} return this book";
    }

    public void checkDueDate()
    {

        var currentDate = DateTime.Now;
        var dueDate = currentDate.AddDays(15);
        throw new Exception("Due Date: " + dueDate.ToShortDateString());
    }




}