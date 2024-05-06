using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DevFolioBireysel.Models;

namespace DevFolioBireysel.Controllers
{
    public class AboutController : Controller
    {
        // GET: About
        DbDevFolioEntities db = new DbDevFolioEntities();

        [HttpGet]
        public ActionResult About(int id)
        {
            var value = db.TblAbout.Find(id);
            return View(value);
        }

        [HttpPost]
        public ActionResult About(TblAbout p)
        {
            var value = db.TblAbout.Find(p.AboutID);
            value.Description = p.Description;
            db.SaveChanges();
            return RedirectToAction("Index","Dashboard");
        }
    }
}
