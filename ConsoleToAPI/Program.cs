using ConsoleToAPI.Data;
using ConsoleToAPI.Repositories;
using Microsoft.EntityFrameworkCore;

namespace ConsoleToAPI
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //creates builder with default host settings
            var builder = WebApplication.CreateBuilder(args);

            //add services to it
            builder.Services.AddControllers();
            builder.Services.AddDbContext<StudentContext>(options => options.UseSqlServer(builder.Configuration.GetConnectionString("StudentDB")));
            builder.Services.AddScoped<IEmployeeRepository, EmployeeRepository>();

            //builds the app
            var app = builder.Build();
            if (app.Environment.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            app.UseRouting();

            app.UseHttpsRedirection();

            //middleware enables routing for application

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
            app.Run();
        }
        //public static IHostBuilder CreateHostBuilder()
        //{
        //    return Host.CreateDefaultBuilder()
        //        .ConfigureWebHostDefaults(webBuilder => { }
        //}

    }
}
