using Microsoft.AspNetCore.Mvc;
using Recipe.BL.Manager.Abstract;
using Recipe.Entities.DbContexts;
using Recipe.Entities.Model.Concrete;
using RecipeProjectMVC.Areas.Admin.Models;
using System.Data;

namespace RecipeProjectMVC.Areas.Admin.Controllers
{
    public class EditUserController(IManager<MyUser, int> userManager, sqlContext context) : Controller
    {
        [Area("Admin")]
        public IActionResult Index(int id)
        {

            var user = userManager.GetById(id);
            var newUserVm = new UsersVM
            {
                User = user
            };
            return View(newUserVm);
        }
        [HttpPost]
        public IActionResult Update(UsersVM _user)
        {
            var userRoleList = userManager.GetAllInclude(p => p.ID == _user.User.ID, x => x.Roles).FirstOrDefault();
            foreach (var role in _user.Roles)
            {
                if (!userRoleList.Roles.Select(x => x.RoleName).Contains(role))
                {
                    userRoleList.Roles.Add(new Role { RoleName = role });
                }

            }
            var deleteRoleList = new List<string>();
            foreach (var uRole in userRoleList.Roles)
            {
                foreach (var role in _user.Roles)
                {
                    if (uRole.RoleName != role)
                    {
                        deleteRoleList.Add(role);
                    }
                }
            }

            foreach (var deleteRole in deleteRoleList)
            {
                var remoteToRole = userRoleList.Roles.FirstOrDefault(x => x.RoleName == deleteRole);
                if (remoteToRole != null)
                {
                    userRoleList.Roles.Remove(remoteToRole);
                }
            }


            userManager.Update(userRoleList);


            return View("Index", "AdminPage");
        }
        public IActionResult Delete(int id)
        {
            userManager.DeleteById(id);
            return RedirectToAction("Index", "AdminPage");
        }



    }
}
