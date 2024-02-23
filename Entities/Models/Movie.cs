namespace Entities.Models
{
    public class Movie
    {
        public Movie() =>
            Ratings = new List<Rating>();

        public string? Title { get; set; }
        public string? Year { get; set; }
        public string? Rated { get; set; }
        public string? Released { get; set; }
        public string? Runtime { get; set; }
        public string? Genre { get; set; }
        public string? Director { get; set; }
        public string? Poster { get; set; }
        public string? Writer { get; set; }
        public string? Actors { get; set; }
        public string? Plot { get; set; }
        public string? Language { get; set; }
        public string? Country { get; set; }
        public string? ImDbVotes { get; set; }
        public string? ImDbRating { get; set; }
        public string? ImDbId { get; set; }
        public ICollection<Rating> Ratings { get; set; }
        public string? Type { get; set; }
    }
}
