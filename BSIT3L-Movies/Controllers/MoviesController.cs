using System;
using BSIT3L_Movies.Models;
using Microsoft.AspNetCore.Mvc;

namespace BSIT3L_Movies.Controllers
{
	public class MoviesController : Controller
    {
        private List<MovieViewModel> _movies;
        public MoviesController()
		{
            // Sample movie data
            _movies = new List<MovieViewModel>
            {
            new MovieViewModel { Id = 1, Name = "Titanic", Rating = "5", ReleaseYear = 1997, Genre = "Romance/Drama", Image = "~/picture/Titanic.png", Trailer = "https://www.youtube.com/embed/kVrqfYjkTdQ?si=a0Q9iXDG0bD0cxAK" },            
            new MovieViewModel { Id = 2, Name = "Inception", Rating = "4", ReleaseYear = 2010, Genre = "Science Fiction/Thriller", Image = "~/picture/Inception_.jpg", Trailer = "https://www.youtube.com/embed/YoHD9XEInc0?si=ybbCSU-8VlMmPief" },
            new MovieViewModel { Id = 3, Name = "The Shawshank Redemption", Rating = "5", ReleaseYear = 1994, Genre = "Drama", Image = "~/picture/The Shawshank Redemption.jpg", Trailer = "https://www.youtube.com/embed/NmzuHjWmXOc" },
            new MovieViewModel { Id = 4, Name = "The Godfather", Rating = "5", ReleaseYear = 1972, Genre = "Crime", Image = "~/picture/The Godfather.jpg", Trailer = "https://www.youtube.com/embed/UaVTIH8mujA?si=gmUa4ZaCkMn4gK8Y"},
            new MovieViewModel { Id = 5, Name = "The Dark Knight", Rating = "4", ReleaseYear = 2008, Genre = "Action/Crime/Drama", Image = "~/picture/The Dark Knight.jpg", Trailer = "https://www.youtube.com/embed/EXeTwQWrcwY?si=TX70AxJh1B2CJqI"},
            new MovieViewModel { Id = 6, Name = "Pulp Fiction", Rating = "3", ReleaseYear = 1994, Genre = "Crime/Drama", Image ="~/picture/Pulp Fiction.jpg", Trailer = ""},
            new MovieViewModel { Id = 7, Name = "Schindler's List", Rating = "3", ReleaseYear = 1993, Genre = "Biography/Drama/History", Image = "~/picture/Schindler's List.jpg", Trailer = ""},
            new MovieViewModel { Id = 8, Name = "Fight Club", Rating = "4", ReleaseYear = 1999, Genre = "Drama", Image= "~/picture/Fight Club.jpg", Trailer = ""},
            new MovieViewModel { Id = 9, Name = "Forrest Gump", Rating = "3", ReleaseYear = 1994, Genre = "Drama/Romance", Image= "~/picture/Forrest Gump.jpg", Trailer = ""},
            new MovieViewModel { Id = 10, Name = "Up", Rating = "5", ReleaseYear = 2009, Genre = "Action/Adventure/Science Fiction", Image = "~/picture/Up.jpg", Trailer = ""},
            new MovieViewModel { Id = 11, Name = "The Matrix", Rating = "5", ReleaseYear = 1999, Genre = "Action/Science Fiction", Image = "~/picture/The Matrix.jpg", Trailer = ""},
            new MovieViewModel { Id = 12, Name = "The Lord of the Rings:The Fellowship of the Ring", Rating = "5", ReleaseYear = 2001, Genre = "Adventure/Drama/Fantasy", Image = "~/picture/The Fellowship of the Ring.jpg", Trailer = ""},
            new MovieViewModel { Id = 13, Name = "The Lord of the Rings:The Two Towers", Rating = "5", ReleaseYear = 2002, Genre = "Adventure/Drama/Fantasy", Image = "~/picture/The Two Towers.jpg", Trailer = ""},
            new MovieViewModel { Id = 14, Name = "Your Name", Rating = "5", ReleaseYear = 2016, Genre = "Adventure/Drama/Fantasy", Image = "~/picture/Your Name.jpg", Trailer = ""},
            new MovieViewModel { Id = 15, Name = "The Lord of the Rings:The Return of the King", Rating = "5", ReleaseYear = 2003, Genre = "Adventure/Drama/Fantasy", Image = "~/picture/The Return of the King.jpg", Trailer = ""},
            new MovieViewModel { Id = 16, Name = "Gladiator", Rating = "4", ReleaseYear = 2000, Genre = "Adventure/Drama", Image = "~/picture/Gladiator.jpg", Trailer = ""},
            };
        }
        public ActionResult Random()
        {
            var movie = new MovieViewModel() { Name = "Avatar", Rating = "5" };
            return View(movie);
        }
        public ActionResult GetMovie(int id)
        {
            var movie = _movies.Find(m => m.Id == id);
            if (movie == null)
                return NotFound();
            return View(movie);

        }

    }
}

