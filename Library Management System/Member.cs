public class Member
{
    private string? _memberName;
    public string? MemberName { get => _memberName; set => _memberName = value; }
    private string? _memberId;
    public string? MemberId { get => _memberId; set => _memberId = value; }
    private string? _contactNumber;
    public string? ContactNumber { get => _contactNumber; set => _contactNumber = value; }
    private string? _email;
    public string? Email { get => _email; set => _email = value; }

    public Member(string memberName, string memberId, string contactNumber, string email)
    {
        MemberName = memberName;
        MemberId = memberId;
        ContactNumber = contactNumber;
        Email = email;
    }


}