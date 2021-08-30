using _07_RepositoryPattern_Repository;
using _08_StreamingContent_Inhertance.Content;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_StreamingContent_Inhertance
{
    public class StreamingRepository : StreamingContentRepository
    {
        public Show GetShowByTitle(string title)
        {
            foreach (StreamingContent content in _contentDirectory)
            {
                if (content.GetType() == typeof(Show) && content.Title == title)
                {
                    return (Show)content; // we have to use cast
                }

                // if (content is Show && content.Title == title)
            }

            return null;

            //fancy way with linq
            return (Show)_contentDirectory.FirstOrDefault(s => s is Show && s.Title == title);
        }

        public Movie GetMovieByTitle(string title)
        {
            foreach (StreamingContent content in _contentDirectory)
            {
                if(content is Movie && content.Title == title)
                {
                    return (Movie)content;
                }
            }
            return null;
            //Or
            return (Movie)_contentDirectory.FirstOrDefault(m => m is Movie && m.Title == title);
        }

        public List<Show> GetAllShows()
        {
            List<Show> allShows = new List<Show>();
            foreach (StreamingContent content in _contentDirectory)
            {
                if (content is Show)
                {
                    allShows.Add((Show)content);
                }
            }

            return allShows;

            //Or                                           //Cast = covert a type to another compatible type
            return _contentDirectory.Where(s => s is Show).Cast<Show>().ToList();

            //Example of Cast
            //double x = 0.3;
            //float y = (float) x;
        }

        public List<Movie> GetAllMovies()
        {
            return _contentDirectory.Where(s => s is Movie).Cast<Movie>().ToList();

        }
        // Challenges:
        // Get Shows by Rating
        public List<Show> GetShowssByStarRating(double stars)
        {
            return GetAllShows().Where(s => s.StarRating >= stars).ToList();
        }

        public List<Show> GetShowsByMaturityRating(MaturityRating rating)
        {
            return GetAllShows().Where(s => s.MaturityRating <= rating).ToList();
        }
        // Get Movies By Rating
        public List<Movie> GetMoviesByStarRating(double stars)
        {
            return GetAllMovies().Where(m => m.StarRating >= stars).ToList();
        }

        public List<Movie> GetMoviesByMaturityRating (MaturityRating rating)
        {
            return GetAllMovies().Where(m => m.MaturityRating <= rating).ToList();
        }
        // Get Movies by Genre
        public List<Movie> GetMoviesByGenre(GenreType genre)
        {
            return GetAllMovies().Where(m => m.GenreType == genre).ToList();
        }
        // Get Show By Genre

        public List<Show> GetShowsByGenre(GenreType genre)
        {
            return GetAllShows().Where(s => s.GenreType == genre).ToList();
        }
    }
}
