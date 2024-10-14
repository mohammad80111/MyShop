using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using MyShop.Models;
using MyShop.Repositry;

namespace MyShop
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            builder.Services.AddControllersWithViews();

            //sqlserver
            builder.Services.AddDbContext<ApplicationDbContext>(Options=>Options.UseSqlServer(
                builder.Configuration.GetConnectionString("myshop")
                
                ));

            //ham
            builder.Services.AddTransient<ICarsSizeRepositry, CarsSizeRepositry>();
            builder.Services.AddTransient<IServiceRepositry, ServiceRepositry>();
            builder.Services.AddTransient<ICarsRepositry, CarsRepositry>();

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (!app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();

            app.MapControllerRoute(
                name: "default",
                pattern: "{controller=Home}/{action=Index}/{id?}");

            app.Run();
        }
    }
}