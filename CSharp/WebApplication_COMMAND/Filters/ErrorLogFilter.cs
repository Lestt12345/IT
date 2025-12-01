using Microsoft.AspNetCore.Mvc.Filters;
using WebApplication_COMMAND.Data;
using WebApplication_COMMAND.Models;

namespace WebApplication_COMMAND.Filters
{
    public class ErrorLogFilter : IExceptionFilter
    {
        private readonly AppDbContext _db;

        public ErrorLogFilter(AppDbContext db)
        {
            _db = db;
        }

        public void OnException(ExceptionContext context)
        {
            var log = new ErrorLog
            {
                Path = context.HttpContext.Request.Path,
                Message = context.Exception.Message,
                StackTrace = context.Exception.StackTrace,
                Time = DateTime.Now
            };

            _db.ErrorLogs.Add(log);
            _db.SaveChanges();
        }
    }

}
