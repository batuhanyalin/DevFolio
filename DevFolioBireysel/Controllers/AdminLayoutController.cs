using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DevFolioBireysel.Models;

namespace DevFolioBireysel.Controllers
{
    [Authorize]
    public class AdminLayoutController : Controller
    {
        DbDevFolioEntities db = new DbDevFolioEntities();
        // GET: AdminLayout
        public ActionResult AdminLayout()
        {
            return View();
        }
        public PartialViewResult NavBar()
        {
            return PartialView();
        }  
        public PartialViewResult SideBar()
        {
            ViewBag.userphoto = db.GetUserPhoto().FirstOrDefault();
            var value = db.TblAdmin.ToList();
            return PartialView(value);
        }
        public PartialViewResult Header()
        {
            return PartialView();
        }
        public PartialViewResult Scripts()
        {
            return PartialView();
        }
    }
}