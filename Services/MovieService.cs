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

        public async Task<ApiBaseResponse> GetByTitle(SearchOptions searchOptions)
        {
            if (!searchOptions.IsValid)
                return new ApiBadRequestResponse($"{nameof(searchOptions.Title)} is required.");

            var movie = await repository.GetByTitle(searchOptions.Title);
            if (string.IsNullOrEmpty(movie.Title))
                return new ApiNotFoundResponse($"Movie not found!");

            return new ApiOkResponse<Movie>(movie);
        }
    }
}
