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

        [AcceptVerbs(HttpVerbs.Get | HttpVerbs.Post)]
        public ActionResult listUser(string searchText, string SortOrder, string SortBy, int pageNumber = 1)
        {
            var users = db.tbl_User.ToList();

            ViewBag.SortOrder = SortOrder;
            ViewBag.SortBy = SortBy;

            if (searchText != null)
            {
                users = db.tbl_User.Where(x => x.UserName.Contains(searchText)).ToList();
                users = ApplySorting(SortOrder, SortBy, users);
                users = ApplyPagination(users, pageNumber);


            }
            else
            {
                users = ApplySorting(SortOrder, SortBy, users);
                users = ApplyPagination(users, pageNumber);

            }



            return View(users);

        }

       
        

        [HttpPost]
        

        public List<tbl_User> ApplySorting(string SortOrder, string SortBy, List<tbl_User> users)
        {

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

            return users;
        
        }

        public List<tbl_User> ApplyPagination(List<tbl_User> users,int pageNumber)
        {
            ViewBag.TotalPages = Math.Ceiling(users.Count() / 2.0);
            ViewBag.PageNumber = pageNumber;

            users = users.Skip((pageNumber - 1) * 2).Take(2).ToList();
            
            return users;
        }



    }
}