using Contracts;
using Entities.Models;
using Entities.Responses;
using Entities.Search;
using Services.Contracts;

namespace Services
{
    public class MovieService : IMovieService
    {
        private readonly IMovieRepository repository;

        public MovieService(IMovieRepository repository) =>
            this.repository = repository;

        public async Task<ApiBaseResponse> Get(string id)
        {
            var movie = await repository.GetById(id);
            if (movie == null)
                return new ApiNotFoundResponse($"Movie with Id: {id} not found!");

            return new ApiOkResponse<Movie>(movie);
        }

        public async Task<ApiBaseResponse> Get(SearchOptions searchOptions)
        {
            var movies = await repository.GetAll(searchOptions.Title);

            return new ApiOkResponse<ResponseData>(movies);
        }
    }
}
