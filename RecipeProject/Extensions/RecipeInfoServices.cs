using Microsoft.AspNetCore.Authentication.Cookies;
using Recipe.BL.Manager.Abstract;
using Recipe.BL.Manager.Concrete;
using Recipe.Entities.Model.Concrete;

namespace RecipeProjectMVC.Extensions
{
    public static class RecipeInfoServices
    {
        public static IServiceCollection AddRecipeInfoService(this IServiceCollection Services)
        {
            Services.AddControllersWithViews();
            Services.AddScoped(typeof(IManager<Food, int>), typeof(BaseManager<Food, int>));
            Services.AddScoped(typeof(IManager<Category, int>), typeof(BaseManager<Category, int>));
            Services.AddScoped(typeof(IManager<Info, int>), typeof(BaseManager<Info, int>));
            Services.AddScoped(typeof(IManager<Comments, int>), typeof(BaseManager<Comments, int>));
            Services.AddScoped(typeof(IManager<MyUser, int>), typeof(BaseManager<MyUser, int>));
            // services.AddScoped(typeof(IManager<>),typeof(BaseManager<>));
            return Services;
        }

        public static IServiceCollection AddCookieSettings(this IServiceCollection services)
        {
            services.AddAuthentication(CookieAuthenticationDefaults.AuthenticationScheme).AddCookie(options =>
            {
                options.Cookie.Name = "RecipeLogin";
                options.LoginPath = "/Home/Index";
                options.LogoutPath = "/Login/Index";
                options.AccessDeniedPath = "/Login/Error";
                options.Cookie.HttpOnly = true; //Tarayicidaki diger scriptler okuyamasin
                options.Cookie.SameSite = SameSiteMode.Strict; // Bizim tarayicimiz disinda kullanilamasin

                options.ExpireTimeSpan = TimeSpan.FromMinutes(10);
                options.SlidingExpiration = true; //Herhangi bir hareket oldugunda 10 dakika daha sureyi uzatir


            });
            return services;
        }
    }
}