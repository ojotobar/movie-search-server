using Entities.Models;
using Refit;

namespace Contracts
{
    public interface IMovie
    {
        [Get("/?apiKey={apiKey}&t={title}")]
        Task<Movie> Get(string apiKey, string title);
    }
}
