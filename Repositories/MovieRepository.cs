using Contracts;
using Entities.Models;
using Microsoft.Extensions.Options;
using Repositories.Configurations;

namespace Repositories
{
    public class MovieRepository : IMovieRepository
    {
        private readonly RepositoryContext _context;
        private readonly IOptions<ImDbSettings> options;
        public MovieRepository(RepositoryContext context, IOptions<ImDbSettings> options)
        {
            _context = context;
            this.options = options;
        }

        public async Task<Movie> GetById(string id) =>
            await _context.Movies.Get(options.Value.Key, id);

        public async Task<ResponseData> GetAll(string title) =>
            await _context.Movies.GetAll(options.Value.Key, title);
    }
}
