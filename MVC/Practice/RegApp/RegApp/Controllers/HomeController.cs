using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace RegApp.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Register()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Register(tbl_User user)
        {
            WebAppDbEntities db = new WebAppDbEntities();
            db.tbl_User.Add(user);
            db.SaveChanges();



            return RedirectToAction("ListUser");
        }

        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Login(tbl_User user)
        {
            WebAppDbEntities db = new WebAppDbEntities();

            int temp=db.tbl_User.Where(x => x.Email == user.Email  && x.Password==user.Password ).Count();

            if(temp > 0)
            {
                return RedirectToAction("ListUser");
            }
            else
            {
                return RedirectToAction("Login");
            }

            
        }

         
        public ActionResult ListUser()
        {
            WebAppDbEntities db = new WebAppDbEntities();
            var users=db.tbl_User.ToList();
            return View(users);
        }

        public ActionResult UserProfile(int id)
        {
            WebAppDbEntities db = new WebAppDbEntities();
            var user=db.tbl_User.Find(id);

            user.isIntrestedInCSharp = user.isIntrestedInCSharp == null ? false : true;
            user.isIntrestedInJava = user.isIntrestedInJava == null ? false : true;
            user.isIntrestedInPython = user.isIntrestedInPython == null ? false : true;


            var cityList = db.tbl_city.ToList();
           /* ViewBag.CityList = new SelectList(cityList,"cityId","cityName");*/

            user.CityList=new SelectList(cityList, "cityId", "cityName"); ;

            return View(user);
        }

        private SelectList SelectList(List<tbl_city> cityList, string v1, string v2)
        {
            throw new NotImplementedException();
        }

        [HttpPost]
        public ActionResult UserProfile(tbl_User user,string Java,string Python,string CSharp)
        {
            /*if (CSharp=="true")
            {
                user.isIntrestedInCSharp = true;
            }
            else
            {
                user.isIntrestedInCSharp = false;
            }
            
            if(Python == "true")
            {
                user.isIntrestedInPython = true;
            }
            else
            {
                user.isIntrestedInPython = false;
            }


             if(Java == "true")
            {
                user.isIntrestedInJava = true;
            }
            else
            {
                user.isIntrestedInJava = false;
            }*/

            user.isIntrestedInCSharp= (CSharp == "true")?true:false;
            user.isIntrestedInJava = (Java == "true") ? true : false;
            user.isIntrestedInPython = (Python == "true") ? true : false;


            WebAppDbEntities db = new WebAppDbEntities();
            db.Entry(user).State = System.Data.Entity.EntityState.Modified;
            db.SaveChanges();
            

            return RedirectToAction("UserProfile",new { id=user.UserId});
        }


    }
}

/*public SelectList CityList { get; set; }*/