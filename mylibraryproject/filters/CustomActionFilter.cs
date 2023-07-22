using Microsoft.AspNetCore.Mvc.Filters;

namespace mylibraryproject.filters
{
    public class CustomActionFilter : IActionFilter
    {
        public void OnActionExecuted(ActionExecutedContext context)
        {
            // Execute code after the action method is called
            // For example, you could log the response
            var response = context.HttpContext.Response;
            var logMessage = $"Response {response.StatusCode} sent at {DateTime.UtcNow}";
            Console.WriteLine(logMessage);

        }


        public void OnActionExecuting(ActionExecutingContext context)
        {
            // Execute code before the action method is called
            // For example, you could log the request

            var request = context.HttpContext.Request;
            var logMessage = $"Request {request.Method} {request.Path} received at {DateTime.UtcNow}";
            Console.WriteLine(logMessage);

        }
    }
}
