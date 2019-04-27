using System;
using System.Collections.Generic;
using System.Linq;

public class Movie
{
    public DateTime Start { get; private set; }
    public DateTime End { get; private set; }

    public Movie(DateTime start, DateTime end)
    {
        this.Start = start;
        this.End = end;
    }
}

public static class MovieNight
{
    public static bool CanViewAll(IEnumerable<Movie> movies)
    {
        var moviesList = movies.OrderBy(o => o.Start).ToArray();

        for (int i = 0; i < moviesList.Length - 1; ++i)
        {
            DateTime firstMovieEnd = moviesList[i].End;

            DateTime secondMovieStart = moviesList[i + 1].Start;

            bool overlap = secondMovieStart < firstMovieEnd;
            if (overlap)
                return false;
        }
        return true;
    }



    public static void Main(string[] args)
    {
        var format = System.Globalization.CultureInfo.InvariantCulture.DateTimeFormat;

        Movie[] movies = new Movie[]
        {
            new Movie(DateTime.Parse("1/1/2015 20:00", format), DateTime.Parse("1/1/2015 21:30", format)),
            new Movie(DateTime.Parse("1/1/2015 23:10", format), DateTime.Parse("1/1/2015 23:30", format)),
            new Movie(DateTime.Parse("1/1/2015 21:30", format), DateTime.Parse("1/1/2015 23:00", format))
        };

        Console.WriteLine(MovieNight.CanViewAll(movies));
    }
}