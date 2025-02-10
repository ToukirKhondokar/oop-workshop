public class Loan
{
    private string? _loanId;
    public string? LoanId { get => _loanId; set => _loanId = value; }

    private string? _memberId;
    public string? MemberId { get => _memberId; set => _memberId = value; }

    private string? _bookId;
    public string? BookId { get => _bookId; set => _bookId = value; }

    private DateTime _loanDate;
    public DateTime LoanDate { get => _loanDate; set => _loanDate = value; }

    public Loan(string memberId, string bookId, DateTime loanDate)
    {
        MemberId = memberId;
        BookId = bookId;
        LoanDate = loanDate;
    }
}
