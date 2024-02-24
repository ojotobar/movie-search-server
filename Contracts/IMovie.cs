using Entities.Models;
using Refit;

namespace Contracts
{
    public interface IMovie
    {
        [Get("/?apiKey={apiKey}&i={id}")]
        Task<Movie> Get(string apiKey, string id);

        [Get("/?apiKey={apiKey}&s={title}")]
        Task<ResponseData> GetAll([Query]string apiKey, [Query]string title);
    }
}
