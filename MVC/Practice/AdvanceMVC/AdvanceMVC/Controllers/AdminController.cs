using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AdvanceMVC.Controllers
{
   
   
    public class AdminController : Controller
    {
        // GET: Admin

        WebAppDbEntities db = new WebAppDbEntities();

        [Authorize(Roles = "A,U")]

        public ActionResult Index()
        {
            return View();
        }





        [Authorize(Roles = "A")]
        public ActionResult AddUser()
        {
            return View();
        }
        [Authorize(Roles = "A")]
        [HttpPost]
        public ActionResult AddUser(tbl_User user)
        {
            db.tbl_User.Add(user);
            db.SaveChanges();

            return RedirectToAction("Index");
        }


        public ActionResult listUser(string SortOrder,string SortBy)
        {
            var users = db.tbl_User.ToList();

            ViewBag.SortOrder = SortOrder;

            switch (SortBy)
            {
                case "Email":
                    {
                        switch (SortOrder)
                        {
                            case "Asc":
                                {
                                    users = users.OrderBy(x => x.Email).ToList();
                                    break;
                                }
                            case "Dsc":
                                {
                                    users = users.OrderByDescending(x => x.Email).ToList();
                                    break;
                                }
                            default:
                                {
                                    users = users.OrderBy(x => x.Email).ToList();
                                    break;
                                }
                        }
                        break;
                    }
                case "UserName":
                    {
                        switch (SortOrder)
                        {
                            case "Asc":
                                {
                                    users = users.OrderBy(x => x.UserName).ToList();
                                    break;
                                }
                            case "Dsc":
                                {
                                    users = users.OrderByDescending(x => x.UserName).ToList();
                                    break;
                                }
                            default:
                                {
                                    users = users.OrderBy(x => x.UserName).ToList();
                                    break;
                                }
                        }
                        break;
                    }
                default:
                    
                    break;
                    
            }

            return View(users);
        }

        [HttpPost]
        public ActionResult listUser(string searchText)
        {

            var users = db.tbl_User.ToList();


            if(searchText != null)
            {
                users = db.tbl_User.Where(x => x.UserName.Contains(searchText)).ToList();
            }

            return View(users);
        }

    }
}