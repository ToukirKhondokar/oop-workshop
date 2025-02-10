public class OnlineStream
{
    private readonly List<Movie> _movies = new();

    public readonly List<Movie> _watchedList = new List<Movie>();

    private readonly List<User> _user = new List<User>();

    public OnlineStream()
    {

    }

    public IReadOnlyList<Movie> Movies => _movies;


    public void AddMovieToMovieList(Movie movie)
    {

        _movies.Add(movie);

    }


    public void AddMovieToWatchedList(Movie movie)
    {
        if (!_watchedList.Any(m => m.MovieId == movie.MovieId))
        {
            _watchedList.Add(movie);
        }
    }


    public List<Movie> AvailableMovies(List<Movie> _movies, string MovieName)
    {
        if (_movies == null) throw new ArgumentNullException(nameof(_movies));
        if (MovieName == null) throw new ArgumentNullException(nameof(MovieName));
        var _availableMovies = _movies.Where(movie => movie.MovieName.Contains(MovieName, StringComparison.OrdinalIgnoreCase)).ToList();
        return _availableMovies;

    }

    public List<Movie> RecommendMovies(User user)
    {
        var watchedMovies = user.GetWatchedMovies();
        return _movies.Where(movie => !watchedMovies.Any(watchedMovie => watchedMovie.MovieId == movie.MovieId)).ToList();
    }

    public List<Movie> SearchMovies(string movieName)
    {
        return _movies.Where(movie => movie.MovieName.Contains(movieName, StringComparison.OrdinalIgnoreCase)).ToList();
    }

    public List<Movie> GetMoviesByGenre(string genre)
    {
        return _movies.Where(movie => movie.MovieGenere.Contains(genre, StringComparison.OrdinalIgnoreCase)).ToList();
    }
}