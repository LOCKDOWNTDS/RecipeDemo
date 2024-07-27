using Recipe.Entities.Model.Abstract;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Recipe.Entities.Model.Concrete
{
    public class Comments : BaseEntity<int>
    {
        [MaxLength(50, ErrorMessage = "Lütfen Başlığı Kısaltın!")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "Boş Bırakılamaz!")]
        [DisplayName("Yorum Başlığı:")]
        public string CommentTitle { get; set; }

        [MaxLength(200, ErrorMessage = "Lütfen Yorumunuzu Kısaltın!")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "Boş Bırakılamaz!")]
        [DisplayName("Yorum :")]

        public string CommentText { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "Boş Bırakılamaz!")]
        [DisplayName("Yıldız:")]
        public int Stars { get; set; }

        public Food Food { get; set; }
        public int FoodId { get; set; }
    }
}