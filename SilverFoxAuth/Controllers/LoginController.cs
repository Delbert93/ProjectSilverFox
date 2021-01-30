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
        private readonly ApplicationDbContext context;

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
                string username = "";
                string password = "";
                //if (User.ValidateUsername(username) && User.ValidatePassword(password))
                //{
                //    //using (DB_Entities db = new DB_Entities())
                //    //{
                //    //    var obj = db.UserProfiles.Where(a => a.UserName.Equals(User.username) && a.Password.Equals(User.password)).FirstOrDefault();
                //    //    if (obj != null)
                //    //    {
                //    //        Session["UserID"] = obj.UserId.ToString();
                //    //        Session["UserName"] = obj.UserName.ToString();
                //    //        return RedirectToAction("UserDashBoard");
                //    //    }
                //    //}
                     
                //}
                //else
                //{
                //    Console.WriteLine("Back Off Hacker");
                //}
               
            }
            return View();
        }

    }
}
