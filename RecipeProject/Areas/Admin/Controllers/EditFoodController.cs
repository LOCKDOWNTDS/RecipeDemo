using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Recipe.BL.Manager.Abstract;
using Recipe.Entities.DbContexts;
using Recipe.Entities.Model.Concrete;
using RecipeProjectMVC.Areas.Admin.Models;

namespace RecipeProjectMVC.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize(Roles = "Admin")]
    public class EditFoodController(IManager<Food, int> foodManager, sqlContext context, IWebHostEnvironment webHostEnvironment) : Controller
    {
        [HttpGet]
        public IActionResult Index(int id)
        {
            var food = context.Foods
                            .Include(f => f.Categorys)      // İlişkili kategorileri dahil et
                            .Where(f => f.ID == id)         // İstediğiniz ID'ye göre filtrele
                            .FirstOrDefault();
            ViewBag.kategori = context.Categories.ToList();
            var newFoodsVm = new FoodsVM
            {
                Food = food,
                FoodID = id,
            };
            return View(newFoodsVm);
        }
        [HttpGet]
        public IActionResult Hide(int id)
        {
            var selectedFood = foodManager.GetById(id);
            selectedFood.Active = (selectedFood.Active == true) ? selectedFood.Active = false : selectedFood.Active = true;
            // ViewBag.message = "OK";
            foodManager.Update(selectedFood);
            return RedirectToAction("Foods", "AdminPage", "Admin");
        }

        [HttpPost]
        public async Task<IActionResult> Update(FoodsVM food)
        {
            if (food == null || food.FoodID == 0)
            {
                return BadRequest("Invalid food data.");
            }

            var foodCategoryList = context.Foods
                .Include(x => x.Categorys)
                .ThenInclude(x => x.Category)
                .FirstOrDefault(p => p.ID == food.FoodID);

            if (foodCategoryList == null)
            {
                return NotFound("Food not found.");
            }

            // Null kontrolü ve boş liste başlatma
            var selectedCategoryIds = food.SelectedCategoryIds ?? new List<int>();

            if (ModelState.IsValid)
            {
                // Yemekte olmayan kategorileri ekle
                var existingCategoryIds = foodCategoryList.Categorys.Select(x => x.CategoryId).ToList();
                var newCategoryIds = selectedCategoryIds.Except(existingCategoryIds).ToList();

                foreach (var categoryId in newCategoryIds)
                {
                    foodCategoryList.Categorys.Add(
                        new CategoryFood
                        {
                            FoodId = food.FoodID,
                            CategoryId = categoryId
                        });
                }

                // Yemekte olup food.categorysinde olmayan kategorileri kaldır
                var deleteCategoryList = foodCategoryList.Categorys
                    .Where(fCat => !selectedCategoryIds.Contains(fCat.CategoryId))
                    .ToList();

                foreach (var deletecat in deleteCategoryList)
                {
                    foodCategoryList.Categorys.Remove(deletecat);
                }

                List<string> imagespaths = new List<string>();

                // Fotoğraf ekleme
                if (food.OtherPictures != null)
                {
                    foreach (var item in food.OtherPictures)
                    {
                        string imagepath = await SaveImage(item);
                        imagespaths.Add(imagepath);
                    }
                }

                foodCategoryList.Name = food.Name;
                foodCategoryList.Materials = food.Materials;
                foodCategoryList.HowManyPerson = food.HowManyPerson;
                foodCategoryList.PreparationTime = food.PreparationTime;
                foodCategoryList.CookingTime = food.CookingTime;
                foodCategoryList.RecipeExplanation = food.RecipeExplanation;

                // Eski resimleri kaldır (opsiyonel)
                // foodCategoryList.OtherPictures.Clear();

                foodCategoryList.OtherPictures = imagespaths.Select(p => new Photos { PhotoPath = p }).ToList();

                // Veritabanında güncelleme
                context.Update(foodCategoryList);
                await context.SaveChangesAsync();

                return RedirectToAction("Foods", "AdminPage", "Admin");
            }

            return RedirectToAction("Foods", "AdminPage", "Admin");
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

            var uploadsFolder = Path.Combine(webHostEnvironment.WebRootPath, "img");
            var filePath = Path.Combine(uploadsFolder, uniqueFileName);

            using (var fileStream = new FileStream(filePath, FileMode.Create))
            {
                await file.CopyToAsync(fileStream);
            }

            return "/img/" + uniqueFileName;
        }
    }
}
