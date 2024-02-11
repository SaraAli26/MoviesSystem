using MovieSystem.Domain.Entities;

namespace MovieSystem.Application.Feature.Movies.Queries.Responces
{
    public class GetMovieResponse
    {
        //public Movie Movie { get; set; }
        public int Id { get; set; }

        public string Name { get; set; }

        public string Poster { get; set; }

        public string Video { get; set; }

        public bool Type { get; set; }

        public int CategoryId { get; set; }
    }
}
