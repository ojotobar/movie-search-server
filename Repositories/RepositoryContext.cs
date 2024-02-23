using Contracts;
using Microsoft.Extensions.Options;
using Refit;
using Repositories.Configurations;

namespace Repositories
{
    public class RepositoryContext
    {
        public IMovie Movies { get; set; }

        public RepositoryContext(IOptions<ImDbSettings> options)
        {
            var url = options.Value.Url;
            Movies = RestService.For<IMovie>(url);
        }
    }
}
