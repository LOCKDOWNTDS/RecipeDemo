using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Recipe.BL.Manager.Abstract;
using Recipe.Entities.DbContexts;
using Recipe.Entities.Model.Concrete;
using RecipeProjectMVC.Areas.Admin.Models;

namespace RecipeProjectMVC.Areas.Admin.Controllers
{
    public class EditUserController(IManager<MyUser, int> userManager, sqlContext context) : Controller
    {
        [Area("Admin")]
        [Authorize(Roles = "Admin")]
        public IActionResult Index(int id)
        {
            var user = userManager.GetById(id);
            var newUserVm = new UsersVM
            {
                User = user
            };
            return View(newUserVm);
        }

        [Area("Admin")]
        [HttpPost]
        [Authorize(Roles = "Admin")]
        public IActionResult Update(UsersVM _user)
        {
            var userRoleList = userManager.GetAllInclude(p => p.ID == _user.User.ID, x => x.Roles).FirstOrDefault();

            if (ModelState.IsValid)
            {
                // Kullanıcıda olmayan rolleri ekle
                foreach (var role in _user.Roles)
                {
                    if (!userRoleList.Roles.Any(x => x.RoleName == role))
                    {
                        userRoleList.Roles.Add(new Role { RoleName = role });
                    }
                }

                // Kullanıcıda olup _user.Roles'te olmayan rolleri kaldır
                var deleteRoleList = new List<Role>();

                foreach (var uRole in userRoleList.Roles)
                {
                    if (!_user.Roles.Contains(uRole.RoleName))
                    {
                        deleteRoleList.Add(uRole);
                    }
                }

                foreach (var deleteRole in deleteRoleList)
                {
                    userRoleList.Roles.Remove(deleteRole);
                }

                // Kullanıcı bilgilerini güncelle
                userRoleList.Name = _user.Name;
                userRoleList.LastName = _user.LastName;
                userRoleList.NickName = _user.NickName;
                userRoleList.Mail = _user.Mail;
                userRoleList.Password = _user.Password;
                userRoleList.PasswordConfirm = _user.PasswordConfirm;
                userManager.Update(userRoleList);

                return RedirectToAction("MyUser", "AdminPage");
            }

            return RedirectToAction("MyUser", "AdminPage");
        }

        [Area("Admin")]
        [HttpGet]
        [Authorize(Roles = "Admin")]
        public IActionResult Ban(MyUser user)
        {
            var realUser = userManager.GetById(user.ID);
            if (realUser.Active == true)
                realUser.Active = false;
            else if (realUser.Active == false || realUser.Active == null)
                realUser.Active = true;
            userManager.Update(realUser);
            return RedirectToAction("MyUser", "AdminPage", "Admin");
        }



    }
}
