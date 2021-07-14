using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace AdvanceMVC.Controllers
{
    [AllowAnonymous]
    public class AccountController : Controller
    {
        // GET: Account
        WebAppDbEntities db = new WebAppDbEntities();
        public ActionResult Login()
        {
            return View();
        }


        [HttpPost]
        public ActionResult Login(tbl_User user)
        {
            var isUserExists = db.tbl_User.Where(x => x.UserName==user.UserName && x.Password==user.Password).FirstOrDefault();

            if(isUserExists != null)
            {
                FormsAuthentication.SetAuthCookie(user.UserName,true);
                return RedirectToAction("Index","Admin");

            }
            else
            {
                TempData["Msg"] = "Invalid User";
                return View();
            }


      
        }

        public ActionResult Logout()
        {
            FormsAuthentication.SignOut();
            return RedirectToAction("Index", "Admin");
            
        }
    }
}