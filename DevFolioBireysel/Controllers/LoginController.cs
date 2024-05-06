using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DevFolioBireysel.Models;
using System.Web.Security;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authentication.Cookies;

namespace DevFolioBireysel.Controllers
{
    public class LoginController : Controller
    {
        // GET: Login
        DbDevFolioEntities db = new DbDevFolioEntities();

        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(TblAdmin p)
        {
            var adminuserinfo = db.TblAdmin.FirstOrDefault(x => x.Username == p.Username && x.Password == p.Password);
            if (adminuserinfo != null)
            {
                FormsAuthentication.SetAuthCookie(adminuserinfo.Username, false);
                Session["Username"] = adminuserinfo.Username;
                return RedirectToAction("Index", "Dashboard");
            }

            return View();
        }
        public PartialViewResult PartialHeader()
        {
            return PartialView();
        }
        public PartialViewResult PartialScript()
        {
            return PartialView();
        }

    }
}