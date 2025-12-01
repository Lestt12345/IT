using Microsoft.AspNetCore.Mvc.Filters;
using System.Diagnostics;
using WebApplication_COMMAND.Data;
using WebApplication_COMMAND.Models;

namespace WebApplication_COMMAND.Filters
{
    public class RequestLogFilter : IAsyncActionFilter
    {
        private readonly AppDbContext _db;

        public RequestLogFilter(AppDbContext db)
        {
            _db = db;
        }

        public async Task OnActionExecutionAsync(ActionExecutingContext context, ActionExecutionDelegate next)
        {
            var sw = Stopwatch.StartNew();
            var result = await next();
            sw.Stop();

            var log = new RequestLog
            {
                Url = context.HttpContext.Request.Path,
                HttpMethod = context.HttpContext.Request.Method,
                Time = DateTime.Now,
                DurationMs = sw.ElapsedMilliseconds,
                UserEmail = context.HttpContext.User.Identity?.Name
            };

            _db.RequestLogs.Add(log);
            await _db.SaveChangesAsync();
        }
    }

}
