using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text.Json;
using System.Threading.Tasks;
using Core.Exceptions;

namespace API
{
    public class ExceptionMiddleware
    {
        private readonly RequestDelegate _next;

        public ExceptionMiddleware(RequestDelegate next)
        {
            _next = next;
        }

        public async Task Invoke(HttpContext context)
        {
            try{
                await _next(context);
            }
            catch (Exception ex)
            {
                await HandleExceptionAsync(context, ex);
            }
        }

        public static Task HandleExceptionAsync(HttpContext context, Exception exception)
        {
            context.Response.ContentType= "application/json";
            HttpStatusCode status = exception switch
        {
            EntityNotFoundException => HttpStatusCode.NotFound,
            ValidationException => HttpStatusCode.BadRequest,
            _ => HttpStatusCode.InternalServerError
        };

        context.Response.StatusCode = (int)status;

        var response = new
        {
            message = exception.Message,
            statusCode = context.Response.StatusCode
        };

        return context.Response.WriteAsync(JsonSerializer.Serialize(response));
        }
    }
}