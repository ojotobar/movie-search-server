using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Services.Contracts;

namespace MovieSearch.Controllers
{
    [Route("api/movies")]
    [ApiController]
    public class MovieController : ControllerBase
    {
        private readonly IMovieService service;
        public MovieController(IMovieService service) =>
            this.service = service;

        [HttpGet]
        public async Task<IActionResult> Get([FromQuery] string title)
        {
            return Ok(await service.GetByTitle(title));
        }
    }
}
