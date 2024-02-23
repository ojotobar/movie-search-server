using Entities.Responses;
using Microsoft.AspNetCore.Mvc;

namespace MovieSearch.Controllers
{
    public class ApiControllerBase : ControllerBase
    {
        [ApiExplorerSettings(IgnoreApi = true)]
        public IActionResult ProcessError(ApiBaseResponse baseResponse)
        {
            return baseResponse switch
            {
                ApiBadRequestResponse => BadRequest(new ErrorDetails
                {
                    Message = ((ApiBadRequestResponse)baseResponse).Message,
                    StatusCode = StatusCodes.Status400BadRequest
                }),
                ApiNotFoundResponse => BadRequest(new ErrorDetails
                {
                    Message= ((ApiNotFoundResponse)baseResponse).Message,
                    StatusCode= StatusCodes.Status404NotFound
                }),
                _ => throw new NotImplementedException()
            };
        }
    }
}
