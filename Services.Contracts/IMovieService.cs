using Entities.Models;
using Entities.Responses;
using Entities.Search;

namespace Services.Contracts
{
    public interface IMovieService
    {
        Task<ApiBaseResponse> GetByTitle(SearchOptions searchOptions);
    }
}
