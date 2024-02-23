using Entities.Responses;

namespace MovieSearch.Controllers.Extensions
{
    public static class ApiBaseResultExtension
    {
        public static TResultType GetResult<TResultType>(this ApiBaseResponse apiBaseResponse) =>
            ((ApiOkResponse<TResultType>)apiBaseResponse).Result;
    }
}
