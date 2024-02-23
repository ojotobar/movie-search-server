using Entities.Models;

namespace Contracts
{
    public interface IMovieRepository
    {
        Task<Movie> GetByTitle(string title);
    }
}
