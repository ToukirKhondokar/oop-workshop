public class Ratings
{

    private int _userId;
    public int UserId { get => _userId; set => _userId = value; }

    private int _value;
    public int Value
    {
        get => _value;

        set
        {
            if (value == 0 || value > 11) throw new ArgumentOutOfRangeException(" rating cannot be less then 0 and bigger then 10 ");
            _value = value;
        }
    }



    public Ratings(int userId, int value)
    {
        UserId = userId;
        Value = value;

    }
}