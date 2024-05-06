using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DevFolioBireysel.Models;

namespace DevFolioBireysel.Controllers
{
    public class ExperienceController : Controller
    {
        // GET: Experience
        DbDevFolioEntities db = new DbDevFolioEntities();
        public PartialViewResult PartialExperience()

        {
            var value = db.TblExperience.ToList();
            return PartialView(value);
        }
        public ActionResult Experience()
        {
            var value = db.TblExperience.ToList();
            return View(value);
        }
        [HttpGet]
        public ActionResult UpdateExperience(int id)
        {
            var value = db.TblExperience.Find(id);
            return View(value);
        }
        [HttpPost]
        public ActionResult UpdateExperience(TblExperience p)
        {
            var value = db.TblExperience.Find(p.ExperienceID);
            value.Baslik = p.Baslik;
            value.Puan = p.Puan;
            value.Logo = p.Logo;
            db.SaveChanges();
            return RedirectToAction("Experience");
        }
        public ActionResult DeleteExperience(int id)
        {
            var value = db.TblExperience.Find(id);
            db.TblExperience.Remove(value);
            db.SaveChanges();
            return RedirectToAction("Experience");
        }
        [HttpGet]
        public ActionResult CreateExperience()
        {
            return View();
        }
        [HttpPost]
        public ActionResult CreateExperience(TblExperience p)
        {
            db.TblExperience.Add(p);
            db.SaveChanges();
            return RedirectToAction("Experience");
        }
    }
}