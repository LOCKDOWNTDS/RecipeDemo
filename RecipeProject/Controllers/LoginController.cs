using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Mvc;
using Recipe.BL.Manager.Abstract;
using Recipe.Entities.DbContexts;
using Recipe.Entities.Model.Concrete;
using RecipeProjectMVC.Models.ViewModels;
using System.Security.Claims;

namespace RecipeProjectMVC.Controllers
{
    public class LoginController(sqlContext context, IManager<MyUser, int> userManager) : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Log(LoginVM login)
        {
            var user = userManager.GetAllInclude(p => p.NickName == login.NickName && p.Password == login.Password, p => p.Roles).FirstOrDefault();
            if (user != null)
            {
                var claims = new List<Claim>
            {
                new Claim(ClaimTypes.Name,user.Name),
                new Claim(ClaimTypes.Email,user.Mail)

            };
                foreach (var item in user.Roles)
                {
                    claims.Add(new Claim(ClaimTypes.Role, item.RoleName));
                }
                var claimsIdentity = new ClaimsIdentity(claims, CookieAuthenticationDefaults.AuthenticationScheme);
                var authProperties = new AuthenticationProperties();

                await HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme, new ClaimsPrincipal(claimsIdentity), authProperties);

                return RedirectToAction("Index", "AdminPage");
            }
            return RedirectToAction("Index");
        }


        [HttpPost]
        public IActionResult Register(LoginVM login)
        {
            if (ModelState.IsValid)
            {
                var newUser = new MyUser
                {
                    Name = login.Name,
                    LastName = login.LastName,
                    NickName = login.NickName,
                    Mail = login.Mail,
                    Password = login.Password,
                    PasswordConfirm = login.PasswordConfirm,
                    Roles = login.Role.Select(p => new Role { RoleName = p }).ToList(),
                };
                context.Myusers.Add(newUser);
                context.SaveChanges();
                TempData["Message"] = "Kullanıcı başarıyla kaydedildi.";
                return RedirectToAction("Index");
            }
            TempData["Message"] = "Hata.";
            return RedirectToAction("Index");
        }


    }
}

