using SaleShop.Areas.Admin.Models;
using SaleShop.EF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SaleShop.Areas.Admin.Controllers
{
    public class UserController : Controller
    {
        // GET: Admin/User
        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create(User request)
        {
            if (ModelState.IsValid)
            {
                var model = new UserModel().Add(request);
                if (model != 0)
                {
                    return RedirectToAction("Index", "Home");
                }
            }
            return View("Create");
        }
        public ActionResult Edit(int id)
        {
            return View(new UserModel().getItemID(id));
        }
        [HttpPost]
        public ActionResult Edit()
        {
            return View();
        }
        //public ActionResult Remove()
        //{
        //    return View();
        //}
        //[HttpDelete]
        //public ActionResult Remove()
        //{
        //    return View();
        //}
    }
}