using Entities.Models;
using Entities.Search;
using Microsoft.AspNetCore.Mvc;
using MovieSearch.Controllers.Extensions;
using Services.Contracts;

namespace MovieSearch.Controllers
{
    [Route("api/movies")]
    [ApiController]
    public class MovieController : ApiControllerBase
    {
        private readonly IMovieService service;
        public MovieController(IMovieService service) =>
            this.service = service;

        [HttpGet("{id}")]
        public async Task<IActionResult> Get([FromRoute]string id)
        {
            var baseResult = await service.Get(id);
            if (!baseResult.Success)
                return ProcessError(baseResult);

            return Ok(baseResult.GetResult<Movie>());
        }

        [HttpGet]
        public async Task<IActionResult> Get([FromQuery] SearchOptions search)
        {
            var baseResult = await service.Get(search);
            if (!baseResult.Success)
                return ProcessError(baseResult);

            return Ok(baseResult.GetResult<ResponseData>());
        }
    }
}
