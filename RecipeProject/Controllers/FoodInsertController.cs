using Microsoft.AspNetCore.Mvc;
using Recipe.BL.Manager.Abstract;
using Recipe.Entities.DbContexts;
using Recipe.Entities.Model.Concrete;
using RecipeProjectMVC.Models.ViewModels;

namespace RecipeProjectMVC.Controllers
{
    public class FoodInsertController : Controller
    {
        private readonly IManager<Food, int> _foodManager;
        private readonly IManager<Category, int> _categoryManager;
        private readonly IWebHostEnvironment _webHostEnvironment;
        private readonly sqlContext _context;

        public FoodInsertController(IManager<Food, int> foodManager, IManager<Category, int> categoryManager, IWebHostEnvironment webHostEnvironment, sqlContext context)
        {
            _foodManager = foodManager;
            _categoryManager = categoryManager;
            _webHostEnvironment = webHostEnvironment;
            _context = context;
        }

        public IActionResult Index()
        {
            ViewBag.kategori = _categoryManager.GetAll();
            int lastFoodId = _context.Foods.OrderByDescending(x => x.ID).Select(p => p.ID).FirstOrDefault();
            var newID = new FoodInsertVM()
            {
                LastID = lastFoodId
            };


            return View(newID);
        }

        [HttpPost]
        public async Task<IActionResult> SaveFood(FoodInsertVM foodVM)
        {
            if (ModelState.IsValid)
            {

                List<string> imagespaths = new List<string>();

                // PictureOne dosyasını kaydet
                if (foodVM.OtherPictures != null)
                {

                    foreach (var item in foodVM.OtherPictures)
                    {
                        string imagepath = await SaveImage(item);
                        imagespaths.Add(imagepath);
                    }
                }

                var selectedCategorys = foodVM.SelectedCategoryIds;
                Food food = new Food
                {
                    ID = foodVM.LastID + 1,
                    Name = foodVM.Name,
                    Materials = foodVM.Materials,
                    HowManyPerson = foodVM.HowManyPerson,
                    PreparationTime = foodVM.PreparationTime,
                    CookingTime = foodVM.CookingTime,
                    RecipeExplanation = foodVM.RecipeExplanation,
                    Categorys = selectedCategorys.Select(p => new CategoryFood { CategoryId = p }).ToList(),
                    OtherPictures = imagespaths.Select(p => new Photos { PhotoPath = p }).ToList(),
                };

                var result = _foodManager.Insert(food);
                return Json(new { success = true, message = "Form başarıyla kaydedildi." });
            }
            else
            {
                return Json(new { success = false, message = "Hata." });
            }
        }
        private async Task<string> SaveImage(IFormFile file)
        {
            var uploadsFolder = Path.Combine(_webHostEnvironment.WebRootPath, "img");
            var uniqueFileName = Guid.NewGuid().ToString() + "_" + file.FileName;
            var filePath = Path.Combine(uploadsFolder, uniqueFileName);

            using (var fileStream = new FileStream(filePath, FileMode.Create))
            {
                await file.CopyToAsync(fileStream);
            }

            return "/img/" + uniqueFileName;
        }

    }
}
