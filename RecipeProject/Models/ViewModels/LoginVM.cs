using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace RecipeProjectMVC.Models.ViewModels
{
	public class LoginVM
	{
		[MaxLength(50, ErrorMessage = "Adınız Çok Uzun!")]
		[Required(AllowEmptyStrings = false, ErrorMessage = "Boş Bırakılamaz!")]
		[DisplayName("Adınız:")]
		public string Name { get; set; }

		[MaxLength(50, ErrorMessage = "Soy Adınız Çok Uzun!")]
		[Required(AllowEmptyStrings = false, ErrorMessage = "Boş Bırakılamaz!")]
		[DisplayName("Soy Adınız:")]
		public string LastName { get; set; }

		[MaxLength(50, ErrorMessage = "Kullanıcı Adınız Çok Uzun!")]
		[Required(AllowEmptyStrings = false, ErrorMessage = "Boş Bırakılamaz!")]
		[DisplayName("Kullanıcı Adı:")]
		public string NickName { get; set; }

		[MaxLength(50, ErrorMessage = "Şifreniz Çok Uzun!")]
		[MinLength(6, ErrorMessage = "Şifreniz 6 Karakterden Uzun Olmalı ")]
		[Required(AllowEmptyStrings = false, ErrorMessage = "Boş Bırakılamaz!")]
		[DisplayName("Şifreniz:")]
		public string Password { get; set; }

		[MaxLength(50, ErrorMessage = "Şifreniz Çok Uzun!")]
		[MinLength(6, ErrorMessage = "Şifreniz 6 Karakterden Uzun Olmalı ")]
		[Compare("Password", ErrorMessage = "Şifreler eşleşmiyor.")]
		[Required(AllowEmptyStrings = false, ErrorMessage = "Boş Bırakılamaz!")]
		[DisplayName("Şifre Kontrol:")]
		public string PasswordConfirm { get; set; }
	}
}
