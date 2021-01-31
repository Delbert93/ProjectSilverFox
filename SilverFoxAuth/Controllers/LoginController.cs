using Microsoft.AspNetCore.Mvc;
using SilverFoxAuth.Data;
using SilverFoxAuth.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SilverFoxAuth.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LoginController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost("[action]")]
        [ValidateAntiForgeryToken]
        public ActionResult Login(UserModel User)
        {
            if (ModelState.IsValid)
            {
                var display = Userloginvalues().Where(m => m.username == User.username && m.password == User.password).FirstOrDefault();
                if (display != null)
                {
                    ViewBag.Status = "CORRECT UserName and Password";
                }
                else
                {
                    ViewBag.Status = "INCORRECT UserName or Password";
                }
                return View(User);
            }
            return View();
        }
        public List<UserModel> Userloginvalues()
        {
            List<UserModel> objModel = new List<UserModel>();
            objModel.Add(new UserModel { username = "user1", password = "password1" });
            objModel.Add(new UserModel { username = "user2", password = "password2" });
            objModel.Add(new UserModel { username = "user3", password = "password3" });
            objModel.Add(new UserModel { username = "user4", password = "password4" });
            objModel.Add(new UserModel { username = "user5", password = "password5" });
            return objModel;
        }

    }
}
