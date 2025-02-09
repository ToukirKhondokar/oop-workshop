

public class User
{
    private int _userId;
    public int UserId { get => _userId; set => _userId = value; }

    private string _userName;

    public string UserName { get => _userName; set => _userName = value; }

    private readonly List<Movie> _watchList = new List<Movie>();



    public User(int UserId, string UserName)
    {
        this._userName = UserName;
        this._userId = UserId;
    }



    public void AddToWatchlist(Movie movie)
    {
        if (!_watchList.Any(m => m.MovieId == movie.MovieId))
        {
            _watchList.Add(movie);
        }
    }

    public List<Movie> GetWatchedMovies()
    {
        return _watchList;
    }



}