using Entities.Models;

namespace Services.Contracts
{
    public interface IMovieService
    {
        Task<Movie> GetByTitle(string title);
    }
}
