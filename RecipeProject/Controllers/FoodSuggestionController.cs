using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Caching.Memory;
using Recipe.Entities.DbContexts;
using RecipeProjectMVC.Models.ViewModels;

namespace RecipeProjectMVC.Controllers
{
    public class FoodSuggestionController : Controller
    {
        private readonly sqlContext _context;
        private readonly IMemoryCache _cache;
        private const string CacheKey = "DailyMenu";
        private static readonly TimeSpan CacheDuration = TimeSpan.FromHours(24);

        public FoodSuggestionController(sqlContext context, IMemoryCache cache)
        {
            _context = context;
            _cache = cache;
        }

        public IActionResult Index()
        {
            if (!_cache.TryGetValue(CacheKey, out DailyMenuVM dailyMenu))
            {
                dailyMenu = GenerateNewDailyMenu();
                var cacheEntryOptions = new MemoryCacheEntryOptions()
                    .SetAbsoluteExpiration(CacheDuration);
                _cache.Set(CacheKey, dailyMenu, cacheEntryOptions);
            }

            return View(dailyMenu);
        }

        private DailyMenuVM GenerateNewDailyMenu()
        {
            var rnd = new Random();

            var food1 = _context.CategoryFoods.Where(p => p.CategoryId == 2).Include(p => p.Food).ThenInclude(p => p.OtherPictures).ToList();
            var food2 = _context.CategoryFoods.Where(p => p.CategoryId == RandomCategory()).Include(p => p.Food).ThenInclude(p => p.OtherPictures).ToList();
            var food3 = _context.CategoryFoods.Where(p => p.CategoryId == 9).Include(p => p.Food).ThenInclude(p => p.OtherPictures).ToList();

            var soap = food1.OrderBy(x => rnd.Next()).Where(x => x.Food.Active == true).FirstOrDefault();
            var mainFood = food2.OrderBy(x => rnd.Next()).Where(x => x.Food.Active == true).FirstOrDefault();
            var dessert = food3.OrderBy(x => rnd.Next()).Where(x => x.Food.Active == true).FirstOrDefault();

            return new DailyMenuVM
            {
                Soap = soap,
                Main = mainFood,
                Dessert = dessert
            };
        }

        private int RandomCategory()
        {
            var rnd = new Random();
            List<int> randoms = new List<int> { 1, 3, 4, 5, 7, 8 };
            int randomIndex = rnd.Next(randoms.Count);
            return randoms[randomIndex];
        }
    }
}