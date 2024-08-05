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

        public FoodInsertController(IManager<Food, int> foodManager, IManager<Category, int> categoryManager,
            IWebHostEnvironment webHostEnvironment,
            sqlContext context)
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

                TempData["Message"] = "Form başarıyla kaydedildi.";
                return RedirectToAction("Index");
            }
            else
            {
                TempData["Message"] = "Hata.";
                return RedirectToAction("Index");
            }
        }

        private async Task<string> SaveImage(IFormFile file)
        {
            // Dosya uzantısını kontrol et
            var allowedExtensions = new List<string> { ".jpg", ".jpeg", ".png" };
            var fileExtension = Path.GetExtension(file.FileName).ToLower();

            if (!allowedExtensions.Contains(fileExtension))
            {
                throw new InvalidOperationException("Geçersiz dosya uzantısı.");
            }

            // Dosya adını ve uzantısını yeniden düzenle
            var uniqueFileName = Guid.NewGuid().ToString() + fileExtension;

            var uploadsFolder = Path.Combine(_webHostEnvironment.WebRootPath, "img");
            var filePath = Path.Combine(uploadsFolder, uniqueFileName);

            using (var fileStream = new FileStream(filePath, FileMode.Create))
            {
                await file.CopyToAsync(fileStream);
            }

            return "/img/" + uniqueFileName;
        }



    }
}




