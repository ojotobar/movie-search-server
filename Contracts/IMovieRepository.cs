using Entities.Models;

namespace Contracts
{
    public interface IMovieRepository
    {
        Task<ResponseData> GetAll(string title);
        Task<Movie> GetById(string title);
    }
}
