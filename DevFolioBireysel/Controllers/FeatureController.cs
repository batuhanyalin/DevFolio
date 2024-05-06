using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DevFolioBireysel.Models;

namespace DevFolioBireysel.Controllers
{
    public class FeatureController : Controller
    {
        // GET: Feature
        DbDevFolioEntities db = new DbDevFolioEntities();

        [HttpGet]
        public ActionResult UpdateFeature(int id)
        {
            var value = db.TblFeature.Find(id);
            return View(value);
        }
        [HttpPost]
        public ActionResult UpdateFeature(TblFeature p)
        {
            var value = db.TblFeature.Find(p.FeatureID);
            value.HeaderTitle = p.HeaderTitle;
            value.HeaderDescription = p.HeaderDescription;
            db.SaveChanges();
            return RedirectToAction("Index","Dashboard");
        }

    }
}