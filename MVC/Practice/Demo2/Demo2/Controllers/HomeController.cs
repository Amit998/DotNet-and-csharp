using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Demo2.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Contact()
        {
            return View();
        }

        public ActionResult About()
        {
            return View();
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(tbl_Category category)
        {
            WebAppDbContext2 db = new WebAppDbContext2();

            db.tbl_Category.Add(category);
            db.SaveChanges();

            return View();
        }

        public ActionResult List()
        {
            WebAppDbContext2 db = new WebAppDbContext2();

            ViewBag.List = db.tbl_Category.ToList();

            //var list=db.tbl_Category.ToList();



            /*return View(ViewBag.List);*/

            return View();
        }

        public ActionResult CreateCategory()
        {
            return View();
        }

        [HttpGet]
        public ActionResult Edit(int id)
        {
            WebAppDbContext2 db = new WebAppDbContext2();

            var category=db.tbl_Category.Find(id);

            return View(category);
        }

        [HttpPost]
        public ActionResult Edit(tbl_Category category)
        {
            WebAppDbContext2 db = new WebAppDbContext2();
            db.Entry(category).State = System.Data.Entity.EntityState.Modified;
            db.SaveChanges();

            

            return RedirectToAction("List");
        }

        [HttpGet]
        public ActionResult Delete(int id)
        {
            WebAppDbContext2 db = new WebAppDbContext2();

            var category=db.tbl_Category.Find(id);

            db.tbl_Category.Remove(category);
            db.SaveChanges();


            return RedirectToAction("List");
        }

        
    }
}