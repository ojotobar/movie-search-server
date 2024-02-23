using Entities.Exceptions;
using Entities.Responses;
using Microsoft.AspNetCore.Diagnostics;
using System.Net;

namespace MovieSearch.Extensions
{
    public static class ExceptionMiddlewareExtension
    {
        public static void UseGlobalExceptionHandler(this WebApplication app)
        {
            app.UseExceptionHandler(appError =>
            {
                appError.Run(async context =>
                {
                    context.Response.StatusCode = (int)HttpStatusCode.InternalServerError;
                    context.Response.ContentType = "application/json";
                    var contextFeature = context.Features.Get<IExceptionHandlerFeature>();
                    if (contextFeature != null)
                    {
                        context.Response.StatusCode = contextFeature.Error switch
                        {
                            BadRequestException => StatusCodes.Status400BadRequest,
                            NotFoundException => StatusCodes.Status404NotFound,
                            _ => StatusCodes.Status500InternalServerError
                        };

                        var details = new ErrorDetails()
                        {
                            StatusCode = context.Response.StatusCode,
                            Message = contextFeature.Error?.Message ?? string.Empty
                        }.ToString() ?? string.Empty;

                        await context.Response.WriteAsync(details);
                    }
                });
            });
        }
    }
}
