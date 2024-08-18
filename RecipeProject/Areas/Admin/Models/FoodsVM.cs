using Recipe.Entities.Model.Concrete;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace RecipeProjectMVC.Areas.Admin.Models
{
    public class FoodsVM
    {
        public int FoodID { get; set; }
        public Food? Food { get; set; }
        [MaxLength(50, ErrorMessage = "Yemek Adı Çok Uzun!")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "Boş Bırakılamaz!")]
        [DisplayName("Yemek Adı:")]
        public string Name { get; set; }

        [MaxLength(500, ErrorMessage = "Malzemeler Çok Uzun!")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "Boş Bırakılamaz!")]
        [DisplayName("Malzemeler:")]
        public string Materials { get; set; }

        [MaxLength(50, ErrorMessage = "En Fazla 50 Karakter Girin!")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "Boş Bırakılamaz!")]
        [DisplayName("Kaç Kişilik:")]
        public string HowManyPerson { get; set; }

        [MaxLength(50, ErrorMessage = "En Fazla 50 Karakter Girin!")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "Boş Bırakılamaz!")]
        [DisplayName("Hazırlanma Süresi:")]
        public string PreparationTime { get; set; }

        [MaxLength(50, ErrorMessage = "En Fazla 50 Karakter Girin!")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "Boş Bırakılamaz!")]
        [DisplayName("Pişirme Süresi:")]
        public string CookingTime { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "Boş Bırakılamaz!")]
        [DisplayName("Açıklama:")]
        public string RecipeExplanation { get; set; }

        public List<IFormFile>? OtherPictures { get; set; } // Resim dosyasını alacak property

        [Required(ErrorMessage = "Lütfen bir kategori seçin")]
        public List<int> SelectedCategoryIds { get; set; } // Kategori ID
        public List<CategoryFood>? Categorys { get; set; }




    }
}
