using Microsoft.EntityFrameworkCore;
using Recipe.BL.Manager.Abstract;
using Recipe.BL.Manager.Concrete;
using Recipe.Entities.DbContexts;
using Recipe.Entities.Model.Concrete;

namespace RecipeProject
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            builder.Services.AddControllersWithViews();
            builder.Services.AddScoped(typeof(IManager<Food, int>), typeof(BaseManager<Food, int>));
            builder.Services.AddScoped(typeof(IManager<Category, int>), typeof(BaseManager<Category, int>));
            builder.Services.AddScoped(typeof(IManager<Info, int>), typeof(BaseManager<Info, int>));
            builder.Services.AddDbContext<sqlContext>(option => option.UseSqlServer(builder.Configuration.GetConnectionString("default")));
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
