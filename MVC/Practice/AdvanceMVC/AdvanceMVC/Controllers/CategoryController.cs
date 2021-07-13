using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AdvanceMVC.Controllers
{
    public class CategoryController : Controller
    {
        WebAppDbEntities db = new WebAppDbEntities();
        // GET: Category
        [Authorize(Roles ="U")]
        public ActionResult Index()
        {

            var category = db.tbl_category_2.ToList();

            return View(category);
        }


        [HttpGet]
        public ActionResult Create()
        {

            

            return View();
        }

        [HttpPost]
        public ActionResult Create(tbl_category_2 category)
        {
            try
            {
                int userCount = db.tbl_category_2.Where(x => x.Name == category.Name).Count();
                TempData["Count"] = userCount;
                if (ModelState.IsValid && userCount == 0)
                {
                    db.tbl_category_2.Add(category);
                    db.SaveChanges();

                    TempData["Msg"] = "Category Added Succesfully";

                    return RedirectToAction("Create");
                }else if (userCount > 0)
                {
                    TempData["Msg"] = "Already have same name";

                    return RedirectToAction("Create");
                }
                else
                {
                    return View();
                }
            }
            catch (Exception e)
            {
                TempData["Msg"] = "No Data Added "+e.Message;
                return RedirectToAction("Create");
            }
            

   
        }


    }
}