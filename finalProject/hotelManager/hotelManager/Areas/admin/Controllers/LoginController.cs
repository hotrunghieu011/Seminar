using hotelManager.Areas.admin.Models;
using Model.DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
namespace hotelManager.Areas.admin.Controllers
{
    public class LoginController : Controller
    {
        // GET: admin/Login
        public ActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Login(LoginModel model )
        {
            var value = new AdminUserDAO().Login(model.UserName, model.Password);
            if (ModelState.IsValid && value)
            {
                return RedirectToAction("Index", "Home");
            }
            else
            {
                ModelState.AddModelError("", "Tên đăng nhập không đúng");
            }
            return View(model);
        }
    }
}