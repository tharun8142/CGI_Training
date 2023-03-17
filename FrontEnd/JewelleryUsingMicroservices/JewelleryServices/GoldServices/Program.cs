using GoldServices.Entities;
using GoldServices.Repository;
using GoldServices.Services;
using Microsoft.EntityFrameworkCore;

namespace GoldServices
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            builder.Services.AddDbContext<GoldContext>(Options => Options.UseSqlServer(builder.Configuration.GetConnectionString("goldstring")));
            builder.Services.AddScoped<IGoldRepository, GoldRepository>();
            builder.Services.AddScoped<IGoldService,GoldService>();
            builder.Services.AddControllers();

            var app = builder.Build();

            // Configure the HTTP request pipeline.

            app.UseAuthorization();


            app.MapControllers();

            app.Run();
        }
    }
}