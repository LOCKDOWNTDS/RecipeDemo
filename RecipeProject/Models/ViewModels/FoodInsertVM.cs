using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
namespace RecipeProjectMVC.Models.ViewModels;

public class FoodInsertVM
{
    [MaxLength(100, ErrorMessage = "Lütfen Yemek Adını Kısaltın!")]
    [Required(AllowEmptyStrings = false, ErrorMessage = "Boş Bırakılamaz!")]
    [DisplayName("Yemek Adı:")]
    public string Name { get; set; }

    [MaxLength(1000, ErrorMessage = "Lütfen Malzeme Listesini Kısaltın!")]
    [Required(AllowEmptyStrings = false, ErrorMessage = "Boş Bırakılamaz!")]
    [DisplayName("Malzemeler:")]
    public string Materials { get; set; }

    [MaxLength(50, ErrorMessage = "Girilen Değer Geçersiz")]
    [Required(AllowEmptyStrings = false, ErrorMessage = "Boş Bırakılamaz!")]
    [DisplayName("Kaç Kişilik:")]
    public string HowManyPerson { get; set; }

    [MaxLength(50, ErrorMessage = "Girilen Değer Geçersiz")]
    [Required(AllowEmptyStrings = false, ErrorMessage = "Boş Bırakılamaz!")]
    [DisplayName("Hazırlama Süresi:")]
    public string PreparationTime { get; set; }

    [MaxLength(50, ErrorMessage = "Girilen Değer Geçersiz")]
    [Required(AllowEmptyStrings = false, ErrorMessage = "Boş Bırakılamaz!")]
    [DisplayName("Pişirme Süresi:")]
    public string CookingTime { get; set; }

    [MaxLength(1000, ErrorMessage = "Tarif Açıklaması Çok Uzun")]
    [Required(AllowEmptyStrings = false, ErrorMessage = "Boş Bırakılamaz!")]
    [DisplayName("Tarif Açıklaması:")]
    public string RecipeExplanation { get; set; }


    public List<IFormFile>? OtherPictures { get; set; } // Resim dosyasını alacak property

    [Required(ErrorMessage = "Lütfen bir kategori seçin")]
    public List<int> SelectedCategoryIds { get; set; } // Kategori ID
}
