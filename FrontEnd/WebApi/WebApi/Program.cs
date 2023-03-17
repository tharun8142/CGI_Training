using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using WebApi.Controllers.Entities;
using WebApi.Controllers.Repository;

namespace WebApi
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            builder.Services.
                AddDbContext<JewelleryContext>
                (Options => Options.UseSqlServer(@"server=WIN-RAAV6KLNV17\SQLEXPRESS;Initial Catalog=Jewellery;User Id=sa;Password=pass@123"));
            builder.Services.AddScoped<IGoldRepository, GoldRepository>(); 
            builder.Services.AddCors();
            builder.Services.AddControllers();

            var app = builder.Build();
            app.UseCors(options =>
            {
                options.AllowAnyOrigin();
                options.AllowAnyHeader();
                options.AllowAnyMethod();
            }
            );

            // Configure the HTTP request pipeline.

            app.UseAuthorization();


            app.MapControllers();

            app.Run();
        }
    }
}