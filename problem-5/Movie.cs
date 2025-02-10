using System;

public class Movie
{
    private string _movieName;
    public string MovieName { get => _movieName; set => _movieName = value; }

    private string _movieGenere;
    public string MovieGenere { get => _movieGenere; set => _movieGenere = value; }

    private int _year;
    public int Year { get => _year; set => _year = value; }


    private int _movieId;
    public int MovieId { get => _movieId; set => _movieId = value; }


    private List<Ratings> _ratings { get; set; } = new List<Ratings>();

    public Movie()
    {
        _year = 0;
        _movieName = "";
        _movieGenere = "";
    }

    public Movie(string _movieName, string _movieGenere, int _year, int _movieId)
    {
        this._movieName = _movieName;
        this._movieGenere = _movieGenere;
        this._year = _year;
        this._movieId = _movieId;

    }


    public void RateMovie(Ratings ratings)
    {
        _ratings.Add(ratings);

    }

    public double GetMovieRate()
    {
        return _ratings.Any() ? _ratings.Average(r => r.Value) : 0;
    }




}
