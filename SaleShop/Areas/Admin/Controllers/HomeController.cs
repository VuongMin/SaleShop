using SaleShop.Areas.Admin.Models;
using SaleShop.Commond;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;


namespace SaleShop.Areas.Admin.Controllers
{
    public class HomeController : Controller
    {
        // GET: Admin/Home
        public ActionResult Index(int page=1)
        {
            int size = 1;
                        return View(new UserModel().getPaging(page,size));
        }
         public ActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Login(Login request)
        {
            //(Login request) to be received from the other side (view_login and mapping follow class Login)
            if (ModelState.IsValid)
            {
                var model = new LoginModel().CheckLogin(request.UserName, request.Password);
                if(model!=0)
                {
                    //create a sesion 
                    var sesion = new UserSesion();
                    sesion.ID = model;
                    sesion.User = request.UserName;

                    Session.Add(Commond.ConstandSesionString.UserSesion, Session);
                    return RedirectToAction("Index", "Home");
                }
              
            }else
            {
                ModelState.AddModelError("", "User or Password is wrong!");
            }

            return View("Login");
        }
    }
}