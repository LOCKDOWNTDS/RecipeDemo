using Microsoft.AspNetCore.Mvc;
using Recipe.BL.Manager.Abstract;
using Recipe.Entities.Model.Concrete;
using RecipeProjectMVC.Models.ViewModels;

namespace RecipeProjectMVC.Controllers
{
    public class FoodInsertController : Controller
    {
        private readonly IManager<Food, int> _foodManager;
        private readonly IManager<Category, int> _categoryManager;
        private readonly IWebHostEnvironment _webHostEnvironment;

        public FoodInsertController(IManager<Food, int> foodManager, IManager<Category, int> categoryManager, IWebHostEnvironment webHostEnvironment)
        {
            _foodManager = foodManager;
            _categoryManager = categoryManager;
            _webHostEnvironment = webHostEnvironment;
        }

        public IActionResult Index()
        {
            ViewBag.kategori = _categoryManager.GetAll();
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> SaveFood(FoodInsertVM foodVM)
        {
            if (!ModelState.IsValid)
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
                var errors = ModelState.Values.SelectMany(v => v.Errors).Select(e => e.ErrorMessage).ToList();
                return Json(new { success = false, message = string.Join(" ", errors) });
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
