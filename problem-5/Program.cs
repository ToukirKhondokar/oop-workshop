class Program
{
    static void Main()
    {


        var movie1 = new Movie("Avater", "Action", 2012, 10);
        var movie2 = new Movie("Sawariya", "Romantic", 2007, 20);
        var movie3 = new Movie("Avanger", "Action", 2012, 30);
        var movie4 = new Movie("Iron man", "Action", 2009, 40);
        var movie5 = new Movie("Iron man 2", "Action", 2014, 50);
        var movie6 = new Movie("Pari", "Horror", 2023, 60);


        OnlineStream onlineStream = new OnlineStream();

        // adding movie to the List
        onlineStream.AddMovieToMovieList(movie1);
        onlineStream.AddMovieToMovieList(movie2);
        onlineStream.AddMovieToMovieList(movie3);
        onlineStream.AddMovieToMovieList(movie4);
        onlineStream.AddMovieToMovieList(movie5);
        onlineStream.AddMovieToMovieList(movie6);


        User _user1 = new User(223002070, "Toukir Khondokar");
        User _user2 = new User(223002024, "Golam sarowar heem");

        //rate the movies
        movie3.RateMovie(new Ratings(_user1.UserId, 7));
        movie3.RateMovie(new Ratings(_user2.UserId, 5));

        double ratings = movie3.GetMovieRate();
        System.Console.WriteLine($"Rating of the movie is:{ratings}");

        //add to the WatchList
        _user1.AddToWatchlist(movie1);
        _user1.AddToWatchlist(movie2);
        _user1.AddToWatchlist(movie3);


        _user2.AddToWatchlist(movie5);
        _user2.AddToWatchlist(movie2);
        _user2.AddToWatchlist(movie6);


        //add to the WatchedList
        onlineStream.AddMovieToWatchedList(movie2);
        onlineStream.AddMovieToWatchedList(movie3);

        var recommendedMovies = onlineStream.RecommendMovies(_user2);



        foreach (var movie in recommendedMovies)
        {
            Console.WriteLine($"Recommended Movie: {movie.MovieName}");
        }





        try
        {
            var _availableMovies = onlineStream.AvailableMovies(onlineStream._movies, "Iron man");

            if (_availableMovies.Any())
            {
                foreach (var movie in _availableMovies)
                {
                    System.Console.WriteLine($"Available Movies are :{movie.MovieName}");
                }

            }
            else
            {
                System.Console.WriteLine("Movie's are not found");
            }

        }
        catch (System.Exception ex)
        {

            System.Console.WriteLine(ex.Message);
        }






    }
}
