using MVC01.Controllers.Middlware;

namespace MVC01
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
           


            // Add services to the container.
            builder.Services.AddControllersWithViews();// MVC
            builder.Services.AddControllers();// API
            builder.Services.AddRazorPages();// Razor Pages
            var app = builder.Build();
            app.Use(async (context, next) =>

            {
                Console.WriteLine("Hello");
                await next(context);
                Console.WriteLine("Bye");
            });

            // Configure the HTTP request pipeline.
            if (!app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseRouting();

            app.UseAuthorization();

            app.MapStaticAssets();
            app.MapControllerRoute(
                name: "default",
                pattern: "{controller=Home}/{action=Index}/{id?}")
                .WithStaticAssets();
            app.UseMiddleware<ReuqestTimingMiddlware>();
            

            app.Run();
                



        }
    }
}
