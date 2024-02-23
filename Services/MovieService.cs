using Contracts;
using Entities.Models;
using Microsoft.Extensions.Options;
using Repositories.Configurations;
using Services.Contracts;

namespace Services
{
    public class MovieService : IMovieService
    {
        private readonly IMovieRepository repository;

        public MovieService(IMovieRepository repository) =>
            this.repository = repository;

        public async Task<Movie> GetByTitle(string title)
        {
            if (string.IsNullOrWhiteSpace(title))
                throw new ArgumentNullException(nameof(title));

            try
            {
                var movie = await repository.GetByTitle(title);
                return movie;
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
