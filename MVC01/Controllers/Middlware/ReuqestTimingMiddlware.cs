using System.Diagnostics;

namespace MVC01.Controllers.Middlware
{
    public class ReuqestTimingMiddlware
    {
     
        private readonly RequestDelegate next;

        public ReuqestTimingMiddlware(RequestDelegate next)
                {
            this.next = next;
        }
        public async Task Invokasync(HttpContext context)
        {
            var Watch = Stopwatch.StartNew();
            await next(context);
            //Next
            Watch.Stop();
            Console.WriteLine($"{context.Request.Path }:: {Watch.ElapsedMilliseconds}ms");;

        }
    }
}
